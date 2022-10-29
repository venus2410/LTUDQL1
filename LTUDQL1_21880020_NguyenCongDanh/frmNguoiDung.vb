Public Class frmNguoiDung
    Dim dsNguoiDung As DataTable
    Dim dsTaiKhoan As DataTable
    Private Sub frmNguoiDung_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "select * from NguoiDung,TaiKhoan where tk_ma_nguoi_dung=nd_ma and nd_xoa=false"
        dsNguoiDung = XuLyDuLieu.DocDuLieu(str)

        dgvDSNguoiDung.DataSource = dsNguoiDung

        dsTaiKhoan = XuLyDuLieu.DocCauTruc("select * from TaiKhoan")
    End Sub

    Private Sub bThem_Click(sender As Object, e As EventArgs) Handles bThem.Click
        If String.IsNullOrEmpty(tbTenDangNhap.Text) Then
            MessageBox.Show("Khong duoc de trong ten dang nhap", "thong bao")
            Return
        Else
            Dim str As String = String.Format("select * from TaiKhoan where tk_ten_dang_nhap like '{0}'", tbTenDangNhap.Text)
            Dim dstk As DataTable = XuLyDuLieu.DocDuLieu(str)
            If dstk.Rows.Count > 0 Then
                MessageBox.Show("Ten dang nhap da ton tai", "thong bao")
                Return
            End If
        End If

        Dim nguoi_dung As DataRow = dsNguoiDung.NewRow()
        nguoi_dung("nd_ten") = tbTen.Text
        nguoi_dung("nd_cmnd") = tbCMND.Text
        nguoi_dung("nd_dien_thoai") = tDienThoai.Text
        nguoi_dung("nd_ngay_sinh") = dtpNgaySinh.Value
        nguoi_dung("nd_dia_chi") = tbDiaChi.Text
        nguoi_dung("nd_xoa") = False
        nguoi_dung("tk_ten_dang_nhap") = tbTenDangNhap.Text
        nguoi_dung("tk_mat_khau") = Util.getHash(tbMatKhau.Text)
        nguoi_dung("tk_xoa") = False

        dsNguoiDung.Rows.Add(nguoi_dung)
        XuLyDuLieu.GhiDuLieu("NguoiDung", dsNguoiDung)
        nguoi_dung("tk_ma_nguoi_dung") = nguoi_dung("nd_ma")

        Dim tk As DataRow = dsTaiKhoan.NewRow()
        tk("tk_ten_dang_nhap") = nguoi_dung("tk_ten_dang_nhap")
        tk("tk_mat_khau") =  nguoi_dung("tk_mat_khau")
        tk("tk_xoa") = nguoi_dung("tk_xoa")
        tk("tk_ma_nguoi_dung") = nguoi_dung("nd_ma")
        dsTaiKhoan.Rows.Add(tk)
        XuLyDuLieu.GhiDuLieu("TaiKhoan", dsTaiKhoan)

        nguoi_dung("tk_ma") = tk("tk_ma")
        dsTaiKhoan.Rows.Remove(tk)


    End Sub
End Class