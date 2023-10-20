Imports System.Reflection.Emit

Public Class mua_khung
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub gb1_Enter(sender As Object, e As EventArgs) Handles gb1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Chắc chắc mua ???", "Bản giá", MessageBoxButtons.YesNo)
        MessageBox.Show("Mua Thành Công", "Thông Tin")
        Me.Close()
    End Sub
End Class