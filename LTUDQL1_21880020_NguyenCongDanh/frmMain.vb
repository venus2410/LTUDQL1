Public Class frmMain
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
End Class