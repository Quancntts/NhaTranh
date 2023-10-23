Public Class Muahoa3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Chắc chắc mua ???", "Bản giá", MessageBoxButtons.YesNo)
        MessageBox.Show("Mua Thành Công", "Thông Tin")
        Me.Close()
    End Sub
End Class