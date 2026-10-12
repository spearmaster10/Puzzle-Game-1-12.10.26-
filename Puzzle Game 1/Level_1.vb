Imports System.Numerics
Imports System.Runtime.InteropServices

Public Class Level_1
    Dim blocks(3) As Crate
    'blocks(0) = New Crate With {.name = "Crate_1", .location = (100, 100)}
    'blocks(1) = New Crate With {.name = "Crate_1", .location = (100, 100)}
    'blocks(2) = New Crate With {.name = "Crate_1", .location = (100, 100)}
    'blocks(3) = New Crate With {.name = "Crate_1", .location = (100, 100)}

    Public Sub crate(Name, X_Axis, Y_Axis, Picture)
        Dim picture_box As New PictureBox
        picture_box.Name = Name
        picture_box.Width = 37
        picture_box.Height = 37
        picture_box.Top = Y_Axis
        picture_box.Left = X_Axis
        'picture_box.ImageLocation = Picture
        picture_box.BackColor = Color.FromArgb(50, 255, 255, 255)
    End Sub

    Dim Level_1(9, 9) As String
    Dim Level = {{"crate_3", 37, 37, "d"}, {3, 4, 6, 6}}


    'dDim box As New Crate("crate_3", 37, 37, "d")

    Dim check As Boolean = False

    'acts as a vector for the player character's movement
    Dim movement As New Point(0, 0)
    Dim direction As Integer = 0

    ''
    Dim Row_Move As Integer = 0
    Dim Column_Move As Integer = 0

    'Subroutine that activates when any key is pressed
    Private Sub Moves(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        'changes the movement vector for the player depending on arrow key inputted and adds to player position
        Select Case e.KeyCode
            Case Keys.A
                Me.Close()
                movement.X = -37
                movement.Y = 0
                ''
                Row_Move = 0
                Column_Move = -1
                ''
                If Not direction = 2 Then
                    player.Image = Image.FromFile("C:\Users\User\source\repos\Puzzle Game 1\Puzzle Game 1\Resources\Snail_Left.png")
                    direction = 2
                    ''

                End If
            Case Keys.D
                movement.X = 37
                movement.Y = 0
                ''
                Row_Move = 0
                Column_Move = 1
                ''
                If Not direction = 1 Then
                    player.Image = Image.FromFile("C:\Users\User\source\repos\Puzzle Game 1\Puzzle Game 1\Resources\Snail_Right.png")
                    direction = 1
                End If
            Case Keys.W
                movement.X = 0
                movement.Y = -37
                ''
                Row_Move = 1
                Column_Move = 0
                ''
                If Not direction = 3 Then
                    player.Image = Image.FromFile("C:\Users\User\source\repos\Puzzle Game 1\Puzzle Game 1\Resources\Snail_Up.png")
                    direction = 3
                End If
            Case Keys.S
                movement.X = 0
                movement.Y = 37
                ''
                Row_Move = -1
                Column_Move = 0
                ''
                If Not direction = 4 Then
                    player.Image = Image.FromFile("C:\Users\User\source\repos\Puzzle Game 1\Puzzle Game 1\Resources\Snail_Down.png")
                    direction = 4
                End If
        End Select

        ''

        Grid_1.SetColumnSpan(player, Column_Move)
        Grid_1.SetRowSpan(player, Row_Move)
        ''
        Dim clear_space As Integer = 0
        clear_space += Push(Crate_1) + Push(Crate_2)
        If clear_space = 2 Then
            player.Top += movement.Y
            player.Left += movement.X
        End If
        'Push(Crate_2)
        'If Not Player_Shadow.Bounds.IntersectsWith(Wall.Bounds) Then
        'Player.Top += movement.Y
        'Player.Left += movement.X
        'End If

        Threading.Thread.Sleep(50)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    'Subroutine thsat checks if the player is about to intersect a block and if ther is space then pushes said block in the direction of movement
    Public Function Push(Block)

        Dim clear As Integer = 0

        Player_Shadow.Top = player.Top + movement.Y
        Player_Shadow.Left = player.Left + movement.X
        If Player_Shadow.Bounds.IntersectsWith(Block.Bounds) Then
            Player_Shadow.Top += movement.Y
            Player_Shadow.Left += movement.X
            If Intersect(wall_1) And Intersect(Wall_2) And Intersect(wall_3) = True Then
                Block.Top += movement.Y
                Block.Left += movement.X
                clear = 1
            End If
        ElseIf Intersect(wall_1) And Intersect(Wall_2) And Intersect(wall_3) = True Then
            clear = 1
        End If

        Return clear

    End Function

    '''
    Public Function Crate(Block)
        Dim colour As String = Block.backcolor
        Dim clear As Boolean = False
        'Shadow.Top = Block.Top + movement.Y
        'Shadow.Left = Block.Left + movement.X
        Player_Shadow.Top = player.Top + movement.Y
        Player_Shadow.Left = player.Left + movement.X
        If Player_Shadow.Bounds.IntersectsWith((Block).Bounds) Then
            Player_Shadow.Top += movement.Y
            Player_Shadow.Left += movement.X
            If Intersect(wall_1) And Intersect(Wall_2) And Intersect(wall_3) = True Then
                Block.Top += movement.Y
                Block.Left += movement.X
                clear = True
            End If
        ElseIf Intersect(wall_1) And Intersect(Wall_2) And Intersect(wall_3) = True Then
            clear = True
        End If

        Select Case colour
            Case colour = "Yellow"
                'Win_Block

                'Shadow.Top = Block.Top + movement.Y
                'Shadow.Left = Block.Left + movement.X

            Case colour = "Lime"
                'Crate

            Case colour = "Cyan"
                'Wall

            Case colour = "Blue"

        End Select

        Return clear
    End Function

    Public Function Intersect(wall)
        Dim open As Boolean = False
        If Not Player_Shadow.Bounds.IntersectsWith(wall.Bounds) Then
            open = True
        End If
        Return open

        'Player_Shadow.Bounds.IntersectsWith(Class.picturebox)
    End Function

    Private Sub Switch(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim setting As String = "J"
        Select Case e.KeyCode
            Case Keys.D0
                End
            Case Keys.J
                Me.Close()
                Settings.Show()
        End Select
    End Sub


End Class