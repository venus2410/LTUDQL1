Public Class frmMain
    Dim tai_khoan As DataRow
    Dim dsChiNhanh As DataTable
    Private Sub HeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HeeToolStripMenuItem.Click

    End Sub

    Private Sub ChiNhánhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiNhánhToolStripMenuItem.Click
        Dim frm As frmChiNhanh = New frmChiNhanh()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub MónĂnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MónĂnToolStripMenuItem.Click
        Dim frm As frmMonAn = New frmMonAn()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub LoaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoaiToolStripMenuItem.Click
        Dim frm As frmLoaiMonAn = New frmLoaiMonAn()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Dim frm As frmMenu = New frmMenu()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub MenuChiNhanhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuChiNhanhToolStripMenuItem.Click
        Dim frm As frmMenuChiNhanh = New frmMenuChiNhanh()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub NguoiDungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NguoiDungToolStripMenuItem.Click
        Dim frm As frmNguoiDung = New frmNguoiDung()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frm As frmDangNhap = New frmDangNhap()
        Dim dr As DialogResult = frm.ShowDialog()
        If dr = DialogResult.Yes Then
            tai_khoan = frm.tai_khoan
            dsChiNhanh = frm.dsChiNhanh
        Else
            Me.Close()
        End If
    End Sub
End Class