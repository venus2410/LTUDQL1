Public Class frmLoaiMonAn
    Dim dsLoaiMonAn As DataTable
    Dim dsLoaiMonAnView As DataView
    Private Sub frmLoaiMonAn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbHienThi.Checked = False
        DocDSLoaiMonAn(cbHienThi.Checked)
    End Sub
    Private Sub DocDSLoaiMonAn(ByVal xoa As Boolean)
        Dim sql As String = String.Format("select * from LoaiMonAn where lma_xoa={0} order by lma_ten", xoa)
        If xoa Then
            sql = String.Format("select * from LoaiMonAn order by lma_ten", xoa)
        End If
        dsLoaiMonAn = XuLyDuLieu.DocDuLieu(sql)
        lbDanhSach.Items.Clear()
        For Each lma In dsLoaiMonAn.Rows
            If lma("lma_xoa") Then
                lbDanhSach.Items.Add(lma("lma_ten") + " - xoa")
            Else
                lbDanhSach.Items.Add(lma("lma_ten"))
            End If
        Next

    End Sub

    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Dim loai_mon_an As DataRow = dsLoaiMonAn.NewRow()
        loai_mon_an("lma_ten") = tbTen.Text

        dsLoaiMonAn.Rows.Add(loai_mon_an)
        XuLyDuLieu.GhiDuLieu("LoaiMonAn", dsLoaiMonAn)

        DocDSLoaiMonAn(cbHienThi.Checked)
    End Sub

    Private Sub lbDanhSach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbDanhSach.SelectedIndexChanged
        If lbDanhSach.SelectedIndex >= 0 Then
            Dim loai_mon_an As DataRow = dsLoaiMonAn.Rows(lbDanhSach.SelectedIndex)
            tbTen.Text = loai_mon_an("lma_ten")
            If loai_mon_an("lma_xoa") Then
                bKhoiPhuc.Enabled = True
            Else
                bKhoiPhuc.Enabled = False
            End If
        End If
    End Sub

    Private Sub btCapNhat_Click(sender As Object, e As EventArgs) Handles btCapNhat.Click
        If lbDanhSach.SelectedIndex >= 0 Then
            Dim loai_mon_an As DataRow = dsLoaiMonAn.Rows(lbDanhSach.SelectedIndex)
            loai_mon_an("lma_ten") = tbTen.Text

            XuLyDuLieu.GhiDuLieu("LoaiMonAn", dsLoaiMonAn)

            DocDSLoaiMonAn(cbHienThi.Checked)
        End If

    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        If lbDanhSach.SelectedIndex >= 0 Then
            Dim loai_mon_an As DataRow = dsLoaiMonAn.Rows(lbDanhSach.SelectedIndex)
            loai_mon_an("lma_xoa") = True

            XuLyDuLieu.GhiDuLieu("LoaiMonAn", dsLoaiMonAn)

            DocDSLoaiMonAn(cbHienThi.Checked)
        End If
    End Sub

    Private Sub cbHienThi_CheckedChanged(sender As Object, e As EventArgs) Handles cbHienThi.CheckedChanged
        DocDSLoaiMonAn(cbHienThi.Checked)
    End Sub

    Private Sub bKhoiPhuc_Click(sender As Object, e As EventArgs) Handles bKhoiPhuc.Click
        If lbDanhSach.SelectedIndex >= 0 Then
            Dim loai_mon_an As DataRow = dsLoaiMonAn.Rows(lbDanhSach.SelectedIndex)
            loai_mon_an("lma_xoa") = False

            XuLyDuLieu.GhiDuLieu("LoaiMonAn", dsLoaiMonAn)

            DocDSLoaiMonAn(cbHienThi.Checked)
        End If
    End Sub
End Class