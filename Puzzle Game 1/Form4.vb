Public Class Form4
    'When the exit button is clicked end the program
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        End
    End Sub

    'When play button is clicked open the level selector
    Private Sub PlayBtn_Click(sender As Object, e As EventArgs) Handles PlayBtn.Click
        Form5.Show()
        Me.Close()
    End Sub

    'When controls button is clicked open the controls
    Private Sub ControlsBtn_Click(sender As Object, e As EventArgs) Handles ControlsBtn.Click
        Settings.Show()
        Me.Close()
    End Sub


End Class