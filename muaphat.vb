Public Class muaphat
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Chắc chắc mua ???", "Bản giá", MessageBoxButtons.OKCancel)
        MessageBox.Show("Sản Phẩm Đã Hết Hàng")
        MessageBox.Show("Mua Không Thành Công", "Thông Tin")
        Me.Close()
    End Sub
End Class