Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class DangKy
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged, txtpass.TextChanged

    End Sub

    Private Sub btndangnhap_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btndangnhap_Click_1(sender As Object, e As EventArgs) Handles btndangnhap.Click
        Dim n = New DangKy()
        Dim username As String
        Dim password As String
        username = txtuser.Text
        password = txtpass.Text
        If (username.Equals("MinhQuan") And password.Equals("123")) Then
            MessageBox.Show("Đăng Nhập Thành Công", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Lỗi!!!,Đăng Nhập Không Thành Công", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        Me.Close()


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class