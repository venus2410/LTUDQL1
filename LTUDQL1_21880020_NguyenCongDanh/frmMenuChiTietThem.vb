Public Class frmMenuChiTietThem
    Dim dsMonAn As DataTable
    Public dsMonAnDuocChon As DataTable
    Private Sub frmMenuChiTietThem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "select * from MonAn where ma_xoa=false"
        dsMonAn = XuLyDuLieu.DocDuLieu(str)
        dgvDSMonAn.DataSource = dsMonAn

        dsMonAnDuocChon = XuLyDuLieu.DocCauTruc(str)
    End Sub

    Private Sub bDong_Click(sender As Object, e As EventArgs) Handles bDong.Click
        Me.Close()
    End Sub

    Private Sub bDongY_Click(sender As Object, e As EventArgs) Handles bDongY.Click
        If dgvDSMonAn.SelectedRows.Count > 0 Then
            For Each row In dgvDSMonAn.SelectedRows
                Dim mav As DataRowView = dgvDSMonAn.Rows(dgvDSMonAn.Rows.IndexOf(row)).DataBoundItem
                Dim ma As DataRow = mav.Row
                Dim mon_an As DataRow = dsMonAnDuocChon.NewRow()
                mon_an("ma_ma") = ma("ma_ma")
                mon_an("ma_ten") = ma("ma_ten")
                mon_an("ma_gia") = ma("ma_gia")

                dsMonAnDuocChon.Rows.Add(mon_an)
            Next
        End If
    End Sub
End Class