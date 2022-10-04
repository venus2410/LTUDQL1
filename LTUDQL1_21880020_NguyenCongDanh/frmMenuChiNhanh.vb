Public Class frmMenuChiNhanh
    Dim dsMenuChiNhanh As DataTable
    Dim dsChiNhanh As DataTable
    Dim dsMenu As DataTable
    Dim dsMonAn As DataTable

    Private Sub frmMenuChiNhanh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "select * from ChiNhanh where cn_xoa=false"
        dsChiNhanh = XuLyDuLieu.DocDuLieu(str)

        cbChiNhanh.DataSource = dsChiNhanh
        cbChiNhanh.DisplayMember = "cn_ten"
        cbChiNhanh.ValueMember = "cn_ma"

        str = "select mn_ma, mn_ten, mn_mo_ta from Menu where mn_xoa=false"
        dsMenu = XuLyDuLieu.DocDuLieu(str)

        cbMenu.DataSource = dsMenu
        cbMenu.DisplayMember = "mn_ten"
        cbMenu.ValueMember = "mn_ma"

        str = "select mcn_ma, mcn_ngay_ap_dung, cn_ten, mn_ten, mcn_ma_chi_nhanh, mcn_ma_menu, mcn_xoa from MenuChiNhanh,Menu,ChiNhanh where mcn_xoa=false and mcn_ma_chi_nhanh=cn_ma
                and mcn_ma_menu=mn_ma"
        dsMenuChiNhanh = XuLyDuLieu.DocDuLieu(str)
        dgvDanhSach.DataSource = dsMenuChiNhanh

        dgvDanhSach.Columns(0).Visible = False
        dgvDanhSach.Columns(4).Visible = False
        dgvDanhSach.Columns(5).Visible = False
        dgvDanhSach.Columns(6).Visible = False

    End Sub
    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        If cbMenu.SelectedIndex < 0 Then
            Return
        End If
        If cbChiNhanh.SelectedIndex < 0 Then
            Return
        End If


        Dim menu_chi_nhanh As DataRow = dsMenuChiNhanh.NewRow()
        Dim chi_nhanh As DataRow = dsChiNhanh.Rows(cbChiNhanh.SelectedIndex)
        Dim menu As DataRow = dsMenu.Rows(cbMenu.SelectedIndex)

        menu_chi_nhanh("mcn_ngay_ap_dung") = dtpNgay.Value
        menu_chi_nhanh("cn_ten") = chi_nhanh("cn_ten")
        menu_chi_nhanh("mn_ten") = menu("mn_ten")
        menu_chi_nhanh("mcn_ma_chi_nhanh") = chi_nhanh("cn_ma")
        menu_chi_nhanh("mcn_ma_menu") = menu("mn_ma")

        dsMenuChiNhanh.Rows.Add(menu_chi_nhanh)
        XuLyDuLieu.GhiDuLieu("MenuChiNhanh", dsMenuChiNhanh)

    End Sub
    Private Sub cbChiNhanh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbChiNhanh.SelectedIndexChanged

    End Sub

    Private Sub cbMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMenu.SelectedIndexChanged
        If cbMenu.SelectedIndex >= 0 Then
            Dim menu As DataRow = dsMenu.Rows(cbMenu.SelectedIndex)

            If Not IsDBNull(menu("mn_mo_ta")) Then
                lMoTa.Text = menu("mn_mo_ta")
            Else
                lMoTa.Text = ""
            End If
            DocChiTietMenu(menu("mn_ma"))
        End If
    End Sub
    Private Sub DocChiTietMenu(ByVal ma_menu As Integer)
        Dim sql As String = String.Format("select mct_ma, ma_ten, mct_gia, mct_ma_menu, mct_ma_mon_an from MenuChiTiet,MonAn where ma_ma=mct_ma_mon_an and mct_ma_menu={0}", ma_menu)
        dsMonAn = XuLyDuLieu.DocDuLieu(sql)
        dgvDanhSachMonAn.DataSource = dsMonAn
        dgvDanhSachMonAn.Columns(0).Visible = False
        dgvDanhSachMonAn.Columns(3).Visible = False
        dgvDanhSachMonAn.Columns(4).Visible = False
    End Sub

    Private Sub dgvDanhSach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSach.CellContentClick
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim mcnv As DataRowView = dgvDanhSach.Rows(dgvDanhSach.SelectedCells(0).RowIndex).DataBoundItem
            Dim mcn As DataRow = mcnv.Row
            cbChiNhanh.SelectedValue = mcn("mcn_ma_chi_nhanh")
            cbMenu.SelectedValue = mcn("mcn_ma_menu")
            dtpNgay.Value = mcn("mcn_ngay_ap_dung")
        End If
    End Sub
End Class