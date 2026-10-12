Public Class Form2

    Dim Password As String = ""
    Dim Username As String = ""
    Dim Pass_Len As Integer = 0
    Dim User_Len As Integer = 0


    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles PasswordInput.TextChanged

        Try
            Password += PasswordInput.Text(PasswordInput.Text.Length - 1)
        Catch
        End Try
        If Pass_Len > PasswordInput.Text.Length Then
            'assword.Remove(PasswordInput.Text.Length, PasswordInput.Text.Length)
            Pass_Len += -1

        ElseIf Pass_Len < PasswordInput.Text.Length Then
            Pass_Len += 1

        End If
        Dim temp As String = ""
        For i = 0 To Pass_Len - 1
            temp += "*"
        Next
        PasswordInput.Text = temp
    End Sub

    Private Sub Username_TextChanged(sender As Object, e As EventArgs) Handles UsernameInput.TextChanged

    End Sub


    'Opens menu when button is pressed and both the inputted username and password is valid
    Private Sub Button_TextChanged(sender As Object, e As EventArgs) Handles Button1.Click
        Username = UsernameInput.Text
        User_Len = UsernameInput.Text.Length
        If (User_Len >= 5) And (User_Len <= 15) And (Pass_Len >= 5) And (Pass_Len <= 15) Then
            Form4.Show()
            Me.Close()
        End If
    End Sub

End Class