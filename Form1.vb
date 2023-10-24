Public Class Form1
    Private Sub ĐăngNhậpĐăngKýToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngNhậpĐăngKýToolStripMenuItem.Click
        Dim n = New Form1()
        Dim gg = New DangKy()
        gg.Show()
        n.Close()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        DangKy.Show()
    End Sub

    Private Sub GiớiThiệuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiớiThiệuToolStripMenuItem.Click
        GioiThieu.Show()

    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click

    End Sub

    Private Sub KhungTranhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhungTranhToolStripMenuItem.Click
        KhungTranh.Show()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        KhungTranh.Show()

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click, Label25.Click

    End Sub
End Class
