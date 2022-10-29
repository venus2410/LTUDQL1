Public Class frmDangNhap
    Dim solan As Integer = 0
    Public tai_khoan As DataRow
    Public dsChiNhanh As DataTable
    Private Sub bDangNhap_Click(sender As Object, e As EventArgs) Handles bDangNhap.Click
        Dim str As String = "select tk_mat_khau from TaiKhoan,NguoiDung where tk_xoa=false and nd_xoa=false and tk_ma_nguoi_dung=nd_ma"
        Dim dstk As DataTable = XuLyDuLieu.DocDuLieu(str)
        Dim a As String = Util.getHash(tbMatKhau.Text)
        If dstk.Rows.Count > 0 Then
            If dstk.Rows(0)("tk_mat_khau") = Util.getHash(tbMatKhau.Text) Then

                str = "select tk_ten_dang_nhap, tk_ma,nd_ma, nd_ten from TaiKhoan,NguoiDung where tk_ma_nguoi_dung=nd_ma and tk_ten_dang_nhap like '" + tbTenDangNhap.Text + "'"
                dstk = XuLyDuLieu.DocDuLieu(str)
                tai_khoan = dstk.Rows(0)
                str = "select ChiNhanh.*,ndcn_ngay_ap_dung from ChiNhanh,NguoiDungChiNhanh where ndcn_ma_chi_nhanh=cn_ma and ndcn_xoa=false"
                dsChiNhanh = XuLyDuLieu.DocDuLieu(str)
                bDangNhap.DialogResult = DialogResult.Yes

                Return
            End If
        End If

        solan = solan + 1
        MessageBox.Show("sai ten dang nhap/mat khau")
        If solan = 5 Then
            Me.Close()
        End If

    End Sub
End Class