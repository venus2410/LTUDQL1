Public Class frmMonAn
    Dim dsMonAn As DataTable
    Dim dsMonAnView As DataView

    Dim dsLoaiMonAn As DataTable
    Private Sub frmMonAn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select * from LoaiMonAn where lma_xoa=false"
        dsLoaiMonAn = XuLyDuLieu.DocDuLieu(sql)
        cbLoai.DataSource = dsLoaiMonAn
        cbLoai.DisplayMember = "lma_ten"
        cbLoai.ValueMember = "lma_ma"
        DocDSMonAn()
    End Sub

    Private Sub DocDSMonAn()
        Dim sql As String = "select ma_ma,ma_ten,lma_ten,ma_loai_mon_an, ma_gia,ma_xoa from MonAn, LoaiMonAn where ma_xoa=false and lma_ma=ma_loai_mon_an"
        dsMonAn = XuLyDuLieu.DocDuLieu(sql)
        dsMonAnView = New DataView(dsMonAn)
        dgvDanhSach.DataSource = dsMonAnView
        dgvDanhSach.Columns(3).Visible = False
        dgvDanhSach.Columns(5).Visible = False
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim monan As DataRow = dsMonAn.NewRow()
        monan("ma_ten") = tbTen.Text
        monan("ma_loai_mon_an") = cbLoai.SelectedItem("lma_ma")
        monan("lma_ten") = cbLoai.SelectedItem("lma_ten")
        monan("ma_gia") = nudGia.Value
        monan("ma_xoa") = False

        dsMonAn.Rows.Add(monan)
        XuLyDuLieu.GhiDuLieu("MonAn", dsMonAn)
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim monanv As DataRowView = dgvDanhSach.Rows(dgvDanhSach.SelectedCells(0).RowIndex).DataBoundItem
            Dim monan As DataRow = monanv.Row
            monanv("ma_ten") = tbTen.Text
            monanv("ma_loai_mon_an") = cbLoai.SelectedItem("lma_ma")
            monanv("lma_ten") = cbLoai.SelectedItem("lma_ten")
            monanv("ma_gia") = nudGia.Value
            XuLyDuLieu.GhiDuLieu("MonAn", dsMonAn)
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim monanv As DataRowView = dgvDanhSach.Rows(dgvDanhSach.SelectedCells(0).RowIndex).DataBoundItem
            Dim monan As DataRow = monanv.Row
            monanv("ma_xoa") = True

            XuLyDuLieu.GhiDuLieu("MonAn", dsMonAn)
            dsMonAn.Rows.Remove(monan)
        End If
    End Sub

    Private Sub dgvDanhSach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSach.CellContentClick

    End Sub

    Private Sub dgvDanhSach_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDanhSach.SelectionChanged
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim monanv As DataRowView = dgvDanhSach.Rows(dgvDanhSach.SelectedCells(0).RowIndex).DataBoundItem
            Dim monan As DataRow = monanv.Row
            tbTen.Text = monanv("ma_ten")
            cbLoai.SelectedValue = monanv("ma_loai_mon_an")
            nudGia.Value = monanv("ma_gia")
        End If
    End Sub

    Private Sub tbTim_TextChanged(sender As Object, e As EventArgs) Handles tbTim.TextChanged
        If tbTim.Text <> "" Then
            dsMonAnView.RowFilter = "ma_ten like '%" + tbTim.Text + "%'"
        Else
            dsMonAnView.RowFilter = ""
        End If
    End Sub
End Class