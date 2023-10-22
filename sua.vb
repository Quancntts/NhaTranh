Public Class sua
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Chắc chắc mua ???", "Bản giá", MessageBoxButtons.YesNo)
        MessageBox.Show("Mua Thành Công", "Thông Tin")
        Me.Close()
    End Sub
End Class