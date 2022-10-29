<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiNhánhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MónĂnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuChiNhanhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NguoiDungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HeeToolStripMenuItem, Me.QuảnLýToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HeeToolStripMenuItem
        '
        Me.HeeToolStripMenuItem.Name = "HeeToolStripMenuItem"
        Me.HeeToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.HeeToolStripMenuItem.Text = "Hệ thống"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChiNhánhToolStripMenuItem, Me.MónĂnToolStripMenuItem, Me.LoaiToolStripMenuItem, Me.MenuToolStripMenuItem, Me.MenuChiNhanhToolStripMenuItem, Me.NguoiDungToolStripMenuItem})
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.QuảnLýToolStripMenuItem.Text = "Quản lý"
        '
        'ChiNhánhToolStripMenuItem
        '
        Me.ChiNhánhToolStripMenuItem.Name = "ChiNhánhToolStripMenuItem"
        Me.ChiNhánhToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ChiNhánhToolStripMenuItem.Text = "Chi nhánh"
        '
        'MónĂnToolStripMenuItem
        '
        Me.MónĂnToolStripMenuItem.Name = "MónĂnToolStripMenuItem"
        Me.MónĂnToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.MónĂnToolStripMenuItem.Text = "Món ăn"
        '
        'LoaiToolStripMenuItem
        '
        Me.LoaiToolStripMenuItem.Name = "LoaiToolStripMenuItem"
        Me.LoaiToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.LoaiToolStripMenuItem.Text = "Loại món ăn"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'MenuChiNhanhToolStripMenuItem
        '
        Me.MenuChiNhanhToolStripMenuItem.Name = "MenuChiNhanhToolStripMenuItem"
        Me.MenuChiNhanhToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.MenuChiNhanhToolStripMenuItem.Text = "Menu - Chi Nhanh"
        '
        'NguoiDungToolStripMenuItem
        '
        Me.NguoiDungToolStripMenuItem.Name = "NguoiDungToolStripMenuItem"
        Me.NguoiDungToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.NguoiDungToolStripMenuItem.Text = "Nguoi Dung"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChiNhánhToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MónĂnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuChiNhanhToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NguoiDungToolStripMenuItem As ToolStripMenuItem
End Class
