Public Class Level_4
    Dim Movements As New List(Of String)
    Dim UpDown As New List(Of Integer)
    Dim LeftRight As New List(Of Integer)

    'Controls the movement of the player and the image of the player depending on which direction the player is moving in
    Private Sub Moves(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim Position As TableLayoutPanelCellPosition = Grid_1.GetPositionFromControl([Player])
        Select Case e.KeyCode
            ' Directional Keys based on WASD movement
            Case Keys.W
                Player.Image = Image.FromFile($"{form1.Current_Directory}Resources\Snail_Up.png")
                Move_Checks(0, -1, Position)
            Case Keys.A
                Player.Image = Image.FromFile($"{form1.Current_Directory}Resources\True_Snail_Left.png")
                Move_Checks(-1, 0, Position)
            Case Keys.S
                Player.Image = Image.FromFile($"{form1.Current_Directory}Resources\Snail_Down.png")
                Move_Checks(0, +1, Position)
            Case Keys.D
                Player.Image = Image.FromFile($"{form1.Current_Directory}Resources\Snail_Right.png")
                Move_Checks(+1, 0, Position)
                ' Allows the player to restart the level by pressing R
            Case Keys.R
                form1.Restarts += 1
                Dim frm = New Level_4
                frm.Show()
                Me.Close()
                'Allow the player to acces the main menu from the levels
            Case Keys.T
                form1.Current_Level = 0
                Form4.Show()
                Me.Close()
                'Undo Button
            Case Keys.Z
                If Not Movements.Count < 1 Then
                    Undo(Position)
                End If
            Case Keys.Escape
                End
            Case Keys.Y
                form1.Current_Level = 4
                Settings.Show()
                Me.Hide()
        End Select
    End Sub

    'Checks the movement of the player and interacts with objects based on their colour
    Private Sub Move_Checks(Column_Change, Row_Change, Position)
        form1.Movement += 1
        Dim New_Position As TableLayoutPanelCellPosition = New TableLayoutPanelCellPosition(Position.Column + Column_Change, Position.Row + Row_Change)
        Dim Name As Control = Grid_1.GetControlFromPosition(New_Position.Column, New_Position.Row)
        Dim colour As Color = If(Name IsNot Nothing, Name.BackColor, Color.Empty)
        If Name Is Nothing Then
            Grid_1.SetCellPosition(Player, New_Position)
            Undo_Lists_Add(Column_Change, Row_Change, "Move")
        Else
            If Not Name.BackColor = Color.Red Then
                Dim Next_Position As TableLayoutPanelCellPosition = New TableLayoutPanelCellPosition(New_Position.Column + Column_Change, New_Position.Row + Row_Change)
                Dim Next_Name As Control = Grid_1.GetControlFromPosition(Next_Position.Column, Next_Position.Row)
                Select Case colour
                'Crates are pushed if the player moves into them and the space behind them is empty
                    Case Color.FromArgb(0, 192, 0) 'Crate
                        If Next_Name Is Nothing Then
                            Block_Move(New_Position, New_Position, Column_Change, Row_Change)
                            Grid_1.SetCellPosition(Player, New_Position)
                            Undo_Lists_Add(Column_Change, Row_Change, "Crate")
                        End If
                'If the player pushes the Win block then the player wins and the level closes and opens the main menu
                    Case Color.FromArgb(255, 255, 128) 'Win
                        Name.Dispose()
                        Grid_1.SetCellPosition(Player, New_Position)
                        'Displays tha game stats such as time and number of resets apon winning
                        MessageBox.Show($"You Win!
Time = {Math.Round(form1.Time, 2)}s
No.Moves = {form1.Movement}
No.Restarts = {form1.Restarts}")
                        Me.Close()
                        Form4.Show()
                'If the player pushes the Lock/Key block onto one another then they both disappear
                    Case Color.FromArgb(255, 128, 0) 'Lock/Key
                        If Next_Name Is Nothing Then
                            Block_Move(New_Position, New_Position, Column_Change, Row_Change)
                            Grid_1.SetCellPosition(Player, New_Position)
                        ElseIf colour = If(Next_Name IsNot Nothing, Next_Name.BackColor, Color.Empty) Then
                            Name.Dispose()
                            Next_Name.Dispose()
                            Grid_1.SetCellPosition(Player, New_Position)
                        End If
                'If the player pushes the Ice block it continues in a straight line until it reaches another object
                    Case Color.FromArgb(128, 255, 255) 'Ice
                        Dim flip As Boolean = False
                        If Next_Name Is Nothing Then
                            While flip = False
                                If Next_Name Is Nothing Then
                                    Next_Position = New TableLayoutPanelCellPosition(Next_Position.Column + Column_Change, Next_Position.Row + Row_Change)
                                    Next_Name = Grid_1.GetControlFromPosition(Next_Position.Column, Next_Position.Row)
                                Else
                                    flip = True
                                End If
                            End While
                            Next_Position = New TableLayoutPanelCellPosition(Next_Position.Column - Column_Change, Next_Position.Row - Row_Change)
                            Block_Move(New_Position, Next_Position, 0, 0)
                            Grid_1.SetCellPosition(Player, New_Position)
                        End If
                        'If the player occupies teh same space as this block then they are to the block at the end of the chain of slides
                    Case Color.FromArgb(192, 192, 0) 'Slide
                        If Next_Name Is Nothing Then
                            Name.BackColor = Color.Red
                            Grid_1.SetCellPosition(Player, Next_Position)
                        End If
                        Undo_Lists_Add(Column_Change, Row_Change, "Slide")
                'If the player occupies the same space as the pit then the level resets
                    Case Color.FromArgb(64, 64, 64) 'Pit
                        form1.Restarts += 1
                        Dim frm = New Level_4
                        frm.Show()
                        Me.Close()
                'if any one of the group tiles is moved then they all move
                    Case Color.FromArgb(255, 128, 255) 'Group Tiles
                        For x = 1 To 18
                            For y = 1 To 18
                                If (Grid_1.GetControlFromPosition(x, y)) Is Nothing Then
                                ElseIf (Grid_1.GetControlFromPosition(x, y)).BackColor = Color.FromArgb(255, 128, 255) Then

                                End If
                            Next
                        Next
                'If the player pushes the drill onto another block then that bloack as well as the drill is removed
                    Case Color.FromArgb(64, 0, 64) 'Drills
                        If Not Next_Name Is Nothing Then
                            If Not Next_Name.BackColor = Color.Red Then
                                Name.Dispose()
                                Next_Name.Dispose()
                                Grid_1.SetCellPosition(Player, New_Position)
                            End If
                        Else
                            Block_Move(New_Position, New_Position, Column_Change, Row_Change)
                            Grid_1.SetCellPosition(Player, New_Position)
                        End If
                End Select
            End If
        End If
    End Sub

    'Increments the game timer 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        form1.Time += 0.10834
    End Sub

    '
    Private Sub Undo(Position)
        Dim Action As String = Movements(Movements.Count - 1)
        Movements.RemoveAt(Movements.Count - 1)
        Dim Row_Reverse As Integer = UpDown(UpDown.Count - 1) * -1
        UpDown.RemoveAt(UpDown.Count - 1)
        Dim Column_Reverse As Integer = LeftRight(LeftRight.Count - 1) * -1
        LeftRight.RemoveAt(LeftRight.Count - 1)
        Dim New_Position As TableLayoutPanelCellPosition = New TableLayoutPanelCellPosition(Position.Column + Column_Reverse * -1, Position.Row + Row_Reverse * -1)
        Select Case Action
                '
            Case "Crate" 'Crate
                Grid_1.SetCellPosition(Player, New TableLayoutPanelCellPosition(Position.Column + Column_Reverse, Position.Row + Row_Reverse))
                Block_Move(New_Position, Position, 0, 0)
                '
            Case "Move"
                Grid_1.SetCellPosition(Player, New TableLayoutPanelCellPosition(Position.Column + Column_Reverse, Position.Row + Row_Reverse))
                '
            Case "Loc/Key" 'Lock/Key
                '
            Case "Ice" 'Ice
                '
            Case "Slide" 'Slide
                Grid_1.GetControlFromPosition(Position.Column + Column_Reverse, Position.Row + Row_Reverse).BackColor = Color.FromArgb(192, 192, 0)
                Grid_1.SetCellPosition(Player, New TableLayoutPanelCellPosition(Position.Column + Column_Reverse * 2, Position.Row + Row_Reverse * 2))
                '
            Case Action = "Group Tiles" 'Group Tiles
                '
            Case "Drills" 'Drills

        End Select
        '
        Select Case Row_Reverse
            Case 1
                Player.Image = Image.FromFile($"{form1.Current_Directory}Resources\Snail_Up.png")
            Case -1
                Player.Image = Image.FromFile($"{form1.Current_Directory}Resources\Snail_Down.png")
        End Select
        Select Case Column_Reverse
            Case 1
                Player.Image = Image.FromFile($"{form1.Current_Directory}Resources\True_Snail_Left.png")
            Case -1
                Player.Image = Image.FromFile($"{form1.Current_Directory}Resources\Snail_Right.png")
        End Select
    End Sub

    '
    Sub Undo_Lists_Add(Column_Change, Row_Change, BLock_Type)
        Movements.Add(BLock_Type)
        UpDown.Add(Row_Change)
        LeftRight.Add(Column_Change)
    End Sub

    '
    Sub Block_Move(From, From_Add, Column_Change, Row_Change)
        Grid_1.SetCellPosition(Grid_1.GetControlFromPosition(From.Column, From.Row), New TableLayoutPanelCellPosition(From_Add.Column + Column_Change, From_Add.Row + Row_Change))
    End Sub
End Class