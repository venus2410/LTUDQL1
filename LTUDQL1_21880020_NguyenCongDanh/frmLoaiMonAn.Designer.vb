<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoaiMonAn
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
        Me.lbDanhSach = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTen = New System.Windows.Forms.TextBox()
        Me.btThem = New System.Windows.Forms.Button()
        Me.btCapNhat = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.cbHienThi = New System.Windows.Forms.CheckBox()
        Me.bKhoiPhuc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbDanhSach
        '
        Me.lbDanhSach.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbDanhSach.FormattingEnabled = True
        Me.lbDanhSach.ItemHeight = 15
        Me.lbDanhSach.Location = New System.Drawing.Point(0, 0)
        Me.lbDanhSach.Name = "lbDanhSach"
        Me.lbDanhSach.Size = New System.Drawing.Size(306, 450)
        Me.lbDanhSach.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(410, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Loai mon an"
        '
        'tbTen
        '
        Me.tbTen.Location = New System.Drawing.Point(509, 101)
        Me.tbTen.Name = "tbTen"
        Me.tbTen.Size = New System.Drawing.Size(173, 23)
        Me.tbTen.TabIndex = 2
        '
        'btThem
        '
        Me.btThem.Location = New System.Drawing.Point(366, 217)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(75, 23)
        Me.btThem.TabIndex = 3
        Me.btThem.Text = "Them"
        Me.btThem.UseVisualStyleBackColor = True
        '
        'btCapNhat
        '
        Me.btCapNhat.Location = New System.Drawing.Point(509, 216)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btCapNhat.TabIndex = 4
        Me.btCapNhat.Text = "CapNhat"
        Me.btCapNhat.UseVisualStyleBackColor = True
        '
        'btXoa
        '
        Me.btXoa.Location = New System.Drawing.Point(642, 215)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(75, 23)
        Me.btXoa.TabIndex = 5
        Me.btXoa.Text = "Xoa"
        Me.btXoa.UseVisualStyleBackColor = True
        '
        'cbHienThi
        '
        Me.cbHienThi.AutoSize = True
        Me.cbHienThi.Location = New System.Drawing.Point(379, 265)
        Me.cbHienThi.Name = "cbHienThi"
        Me.cbHienThi.Size = New System.Drawing.Size(133, 19)
        Me.cbHienThi.TabIndex = 6
        Me.cbHienThi.Text = "Hien thi mon an xoa"
        Me.cbHienThi.UseVisualStyleBackColor = True
        '
        'bKhoiPhuc
        '
        Me.bKhoiPhuc.Location = New System.Drawing.Point(642, 265)
        Me.bKhoiPhuc.Name = "bKhoiPhuc"
        Me.bKhoiPhuc.Size = New System.Drawing.Size(75, 23)
        Me.bKhoiPhuc.TabIndex = 7
        Me.bKhoiPhuc.Text = "Khoi phuc"
        Me.bKhoiPhuc.UseMnemonic = False
        Me.bKhoiPhuc.UseVisualStyleBackColor = True
        '
        'frmLoaiMonAn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bKhoiPhuc)
        Me.Controls.Add(Me.cbHienThi)
        Me.Controls.Add(Me.btXoa)
        Me.Controls.Add(Me.btCapNhat)
        Me.Controls.Add(Me.btThem)
        Me.Controls.Add(Me.tbTen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbDanhSach)
        Me.Name = "frmLoaiMonAn"
        Me.Text = "frmLoaiMonAn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbDanhSach As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbTen As TextBox
    Friend WithEvents btThem As Button
    Friend WithEvents btCapNhat As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents cbHienThi As CheckBox
    Friend WithEvents bKhoiPhuc As Button
End Class
