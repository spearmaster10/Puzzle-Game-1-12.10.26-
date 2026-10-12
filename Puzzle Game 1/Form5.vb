Public Class Form5
    'When Slect 1 button is clicked open level 1 and close the level selector
    Private Sub Select_1_Click(sender As Object, e As EventArgs) Handles Select_1.Click
        Back_To_Zero()
        Level_1.Show()
        Me.Close()
        form1.Current_Level = 1
    End Sub
    'When Slect 2 button is clicked open level 2 and close the level selector
    Private Sub Select_2_Click(sender As Object, e As EventArgs) Handles Select_2.Click
        Back_To_Zero()
        Level_2.Show()
        Me.Close()
        form1.Current_Level = 2
    End Sub
    'When Slect 3 button is clicked open level 3 and close the level selector
    Private Sub Select_3_Click(sender As Object, e As EventArgs) Handles Select_3.Click
        Back_To_Zero()
        Level_3.Show()
        Me.Close()
        form1.Current_Level = 3
    End Sub
    'When Slect 4 button is clicked open level 4 and close the level selector
    Private Sub Select_4_Click(sender As Object, e As EventArgs) Handles Select_4.Click
        Back_To_Zero()
        Level_4.Show()
        Me.Close()
        form1.Current_Level = 4
    End Sub
    Private Sub Back_To_Zero()
        form1.Movement = 0
        form1.Restarts = 0
        form1.Time = 0
    End Sub

    Private Sub Back_Btn_Click(sender As Object, e As EventArgs) Handles Back_Btn.Click
        Form4.Show()
        Me.Close()
    End Sub
End Class