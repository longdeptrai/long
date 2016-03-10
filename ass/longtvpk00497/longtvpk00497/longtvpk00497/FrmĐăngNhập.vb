Public Class FrmĐăngNhập
    Dim KiemTraDangNhap As Boolean = False 'true
    Public TenDN As String
    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Application.Exit()
    End Sub

    Private Sub btnDN_Click(sender As Object, e As EventArgs) Handles btnDN.Click
        If (txtTTK.Text = "longtrinh" And txtMK.Text = "6789") Then
            KiemTraDangNhap = True
            TenDN = "Administrator"
            MessageBox.Show("Đăng nhập thành công")
            Form1.Show()
        ElseIf (txtTTK.Text = "longdeptrai" And txtMK.Text = "1111") Then
            KiemTraDangNhap = True
            TenDN = "Administrator"
            MessageBox.Show("Đăng nhập thành công")
            Form1.Show()
        ElseIf (txtTTK.Text = "long6789" And txtMK.Text = "1234") Then
            KiemTraDangNhap = True
            TenDN = "Administrator"
            MessageBox.Show("Đăng nhập thành công")
            Form1.Show()
        Else
            MessageBox.Show("Đăng nhập thất bại")
        End If
    End Sub

    Private Sub FrmĐăngNhập_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class