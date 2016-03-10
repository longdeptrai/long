Public Class Form1

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtMSP.Text = "" Then
            MessageBox.Show("Vui lòng nhập mã sản phẩm")
        ElseIf txtTSP.Text = "" Then
            MessageBox.Show("Vui lòng nhập tên sản phẩm")
        ElseIf txtGN.Text = "" Then
            MessageBox.Show("Vui lòng nhập giá sản phẩm")
        ElseIf txtGB.Text = "" Then
            MessageBox.Show("Vui lòng nhập giá sản phẩm")
        ElseIf nudSL.Text < 1 Then
            MessageBox.Show("Vui lòng nhập số lượng sản phẩm")
        ElseIf cbxLSP.Text = "" Then
            MessageBox.Show("Vui lòng nhập loại sản phẩm")
        ElseIf cbxKN.Text = "" Then
            MessageBox.Show("Vui lòng nhập kho")
        ElseIf dtprNgaynhap.Text = "" Then
            MessageBox.Show("Vui lòng nhập ngày")

        End If
        Try
            txtGN.Text = txtGB.Text * 3
        Catch ex As Exception
            MessageBox.Show("Giá nhập và giá bán phải là số")

        End Try

        Dim SoDongHienCoTrongListView As Integer
        SoDongHienCoTrongListView = lvwQLSP.Items.Count
        Dim item As ListViewItem = New ListViewItem(SoDongHienCoTrongListView + 1)
        item.SubItems.Add(txtMSP.Text)
        item.SubItems.Add(txtTSP.Text)
        item.SubItems.Add(txtGN.Text)
        item.SubItems.Add(txtGB.Text)
        item.SubItems.Add(nudSL.Text)
        item.SubItems.Add(cbxLSP.Text)
        item.SubItems.Add(cbxKN.Text)
        item.SubItems.Add(dtprNgaynhap.Text)
        lvwQLSP.Items.Add(item)
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Application.Exit()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        For i As Integer = 0 To lvwQLSP.SelectedItems.Count - 1 Step 1
            lvwQLSP.Items.RemoveAt(lvwQLSP.SelectedIndices(i))
        Next

    End Sub
End Class
