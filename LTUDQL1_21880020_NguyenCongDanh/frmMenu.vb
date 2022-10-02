Public Class frmMenu
    Dim dsMenu As DataTable
    Dim dsMonAn As DataTable
    Dim ma_menu As Integer

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DocDSMenu(cbHienThi.Checked)

    End Sub
    Private Sub DocDSMenu(ByVal xoa As Boolean)
        Dim sql As String = String.Format("select mn_ma, mn_ten, mn_mo_ta, mn_xoa from Menu where mn_xoa=false")
        If xoa Then
            sql = String.Format("select mn_ma, mn_ten, mn_mo_ta, mn_xoa from Menu")
        End If
        dsMenu = XuLyDuLieu.DocDuLieu(sql)
        dgvDanhSach.DataSource = dsMenu

    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        Dim menu As DataRow = dsMenu.NewRow()
        menu("mn_ten") = tbTen.Text
        menu("mn_mo_ta") = tbMoTa.Text
        dsMenu.Rows.Add(menu)
        XuLyDuLieu.GhiDuLieu("Menu", dsMenu)
        DocDSMenu(cbHienThi.Checked)
    End Sub

    Private Sub cbHienThi_CheckedChanged(sender As Object, e As EventArgs) Handles cbHienThi.CheckedChanged
        DocDSMenu(cbHienThi.Checked)
    End Sub

    Private Sub dgvDanhSach_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSach.CellClick
        If dgvDanhSach.SelectedCells.Count > 0 Then
            Dim menuv As DataRowView = dgvDanhSach.Rows(dgvDanhSach.SelectedCells(0).RowIndex).DataBoundItem
            Dim menu As DataRow = menuv.Row
            tbTen.Text = menuv("mn_ten")
            tbMoTa.Text = ""
            If Not IsDBNull(menu("mn_mo_ta")) Then
                tbMoTa.Text = menu("mn_mo_ta")
            End If

            ma_menu = menu("mn_ma")
            DocChiTietMenu(menu("mn_ma"))
        End If
    End Sub

    Private Sub DocChiTietMenu(ByVal ma_menu As Integer)
        Dim sql As String = String.Format("select mct_ma, ma_ten, mct_gia, mct_ma_menu, mct_ma_mon_an from MenuChiTiet,MonAn where ma_ma=mct_ma_mon_an and mct_ma_menu={0}", ma_menu)
        dsMonAn = XuLyDuLieu.DocDuLieu(sql)
        dgvDSMonAn.DataSource = dsMonAn
        dgvDSMonAn.Columns(0).Visible = False
        dgvDSMonAn.Columns(3).Visible = False
        dgvDSMonAn.Columns(4).Visible = False
    End Sub

    Private Sub bXoaMonAn_Click(sender As Object, e As EventArgs) Handles bXoaMonAn.Click
        If dgvDSMonAn.SelectedCells.Count > 0 Then
            Dim mav As DataRowView = dgvDSMonAn.Rows(dgvDSMonAn.SelectedCells(0).RowIndex).DataBoundItem
            Dim ma As DataRow = mav.Row
            ma.Delete()
            XuLyDuLieu.GhiDuLieu("MenuChiTiet", dsMonAn)
        End If
    End Sub

    Private Sub bThemMonAn_Click(sender As Object, e As EventArgs) Handles bThemMonAn.Click
        Dim frm As frmMenuChiTietThem = New frmMenuChiTietThem()
        Dim dr As DialogResult = frm.ShowDialog()
        If dr = DialogResult.OK Then
            For Each monan In frm.dsMonAnDuocChon.Rows
                If KiemTraMaMonAn(monan("ma_ma")) Then
                    Dim chi_tiet As DataRow = dsMonAn.NewRow()
                    chi_tiet("ma_ten") = monan("ma_ten")
                    chi_tiet("mct_gia") = monan("ma_gia")
                    chi_tiet("mct_ma_menu") = ma_menu
                    chi_tiet("mct_ma_mon_an") = monan("ma_ma")
                    dsMonAn.Rows.Add(chi_tiet)
                End If
            Next
            XuLyDuLieu.GhiDuLieu("MenuChiTiet", dsMonAn)
            MessageBox.Show("ok" + frm.dsMonAnDuocChon.Rows.Count.ToString())
        Else
            MessageBox.Show("no ok")

        End If

    End Sub
    Private Function KiemTraMaMonAn(ByVal ma_monan As Integer)
        Dim kq As Boolean = True
        For Each monan In dsMonAn.Rows
            If monan("mct_ma_mon_an") = ma_monan Then
                kq = False
                Exit For
            End If
        Next
        Return kq
    End Function

    Private Sub bCapNhatGia_Click(sender As Object, e As EventArgs) Handles bCapNhatGia.Click
        XuLyDuLieu.GhiDuLieu("MenuChiTiet", dsMonAn)
    End Sub
End Class