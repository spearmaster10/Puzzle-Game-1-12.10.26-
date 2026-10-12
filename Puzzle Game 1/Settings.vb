Public Class Settings
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Select Case form1.Current_Level
                    'Takes user back to the main menu when the back button is clicked
            Case 0
                Form4.Show()
                Me.Close()
            Case 1
                Level_1.Show()
                Me.Close()
            Case 2
                Level_2.Show()
                Me.Close()
            Case 3
                Level_3.Show()
                Me.Close()
            Case 4
                Level_4.Show()
                Me.Close()
        End Select
    End Sub
End Class