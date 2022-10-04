Public Class frmChiNhanh
    Dim dsChiNhanh As DataTable
    Dim dsChiNhanhView As DataView

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsChiNhanh = XuLyDuLieu.DocDuLieu("SELECT * FROM ChiNhanh WHERE cn_xoa = false")
        dsChiNhanhView = New DataView(dsChiNhanh)
        dgvDanhSach.DataSource = dsChiNhanhView

        dgvDanhSach.Columns(3).Visible = False
        dgvDanhSach.Columns(0).HeaderText = "Ma chi nhanh"
        dgvDanhSach.Columns(1).HeaderText = "Ten chi nhanh"
        dgvDanhSach.Columns(2).HeaderText = "Dia chi"
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim chi_nhanh As DataRow = dsChiNhanh.NewRow()
        chi_nhanh("cn_ten") = tbTen.Text
        chi_nhanh("cn_dia_chi") = tbDiaChi.Text
        dsChiNhanh.Rows.Add(chi_nhanh)

        XuLyDuLieu.GhiDuLieu("ChiNhanh", dsChiNhanh)
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim cnv As DataRowView = dgvDanhSach.Rows(dgvDanhSach.SelectedCells(0).RowIndex).DataBoundItem
            Dim cn As DataRow = cnv.Row
            cnv("cn_ten") = tbTen.Text
            cnv("cn_dia_chi") = tbDiaChi.Text
            XuLyDuLieu.GhiDuLieu("ChiNhanh", dsChiNhanh)
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim cnv As DataRowView = dgvDanhSach.Rows(dgvDanhSach.SelectedCells(0).RowIndex).DataBoundItem
            Dim cn As DataRow = cnv.Row
            cnv("cn_xoa") = True
            XuLyDuLieu.GhiDuLieu("ChiNhanh", dsChiNhanh)
            dsChiNhanh.Rows.Remove(cn)
        End If
    End Sub

    Private Sub dgvDanhSach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSach.CellClick
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim cnv As DataRowView = dgvDanhSach.Rows(dgvDanhSach.SelectedCells(0).RowIndex).DataBoundItem
            Dim cn As DataRow = cnv.Row
            tbTen.Text = cn("cn_ten")
            tbDiaChi.Text = cnv("cn_dia_chi")
        End If
    End Sub

    Private Sub tbTim_TextChanged(sender As Object, e As EventArgs) Handles tbTim.TextChanged
        If tbTim.Text <> "" Then
            dsChiNhanhView.RowFilter = "cn_ten like '%" + tbTim.Text + "%'or cn_dia_chi like '%" + tbTim.Text + "%'"
        Else
            dsChiNhanhView.RowFilter = ""
        End If
    End Sub
End Class
