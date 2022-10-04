<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuChiNhanh
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
        Me.dgvDanhSach = New System.Windows.Forms.DataGridView()
        Me.cbMenu = New System.Windows.Forms.ComboBox()
        Me.cbChiNhanh = New System.Windows.Forms.ComboBox()
        Me.dtpNgay = New System.Windows.Forms.DateTimePicker()
        Me.dgvDanhSachMonAn = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lMoTa = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bThem = New System.Windows.Forms.Button()
        Me.bCapNhat = New System.Windows.Forms.Button()
        Me.bXoa = New System.Windows.Forms.Button()
        CType(Me.dgvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDanhSachMonAn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDanhSach
        '
        Me.dgvDanhSach.AllowUserToAddRows = False
        Me.dgvDanhSach.AllowUserToDeleteRows = False
        Me.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSach.Location = New System.Drawing.Point(12, 12)
        Me.dgvDanhSach.Name = "dgvDanhSach"
        Me.dgvDanhSach.RowTemplate.Height = 25
        Me.dgvDanhSach.Size = New System.Drawing.Size(240, 394)
        Me.dgvDanhSach.TabIndex = 0
        '
        'cbMenu
        '
        Me.cbMenu.FormattingEnabled = True
        Me.cbMenu.Location = New System.Drawing.Point(449, 83)
        Me.cbMenu.Name = "cbMenu"
        Me.cbMenu.Size = New System.Drawing.Size(121, 23)
        Me.cbMenu.TabIndex = 1
        '
        'cbChiNhanh
        '
        Me.cbChiNhanh.FormattingEnabled = True
        Me.cbChiNhanh.Location = New System.Drawing.Point(449, 54)
        Me.cbChiNhanh.Name = "cbChiNhanh"
        Me.cbChiNhanh.Size = New System.Drawing.Size(121, 23)
        Me.cbChiNhanh.TabIndex = 2
        '
        'dtpNgay
        '
        Me.dtpNgay.CustomFormat = "dd/mm/yyyy"
        Me.dtpNgay.Location = New System.Drawing.Point(449, 25)
        Me.dtpNgay.Name = "dtpNgay"
        Me.dtpNgay.Size = New System.Drawing.Size(200, 23)
        Me.dtpNgay.TabIndex = 3
        '
        'dgvDanhSachMonAn
        '
        Me.dgvDanhSachMonAn.AllowUserToAddRows = False
        Me.dgvDanhSachMonAn.AllowUserToDeleteRows = False
        Me.dgvDanhSachMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachMonAn.Location = New System.Drawing.Point(360, 197)
        Me.dgvDanhSachMonAn.Name = "dgvDanhSachMonAn"
        Me.dgvDanhSachMonAn.RowTemplate.Height = 25
        Me.dgvDanhSachMonAn.Size = New System.Drawing.Size(409, 209)
        Me.dgvDanhSachMonAn.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(360, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Ngay"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(360, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Chi nhanh"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(360, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Menu"
        '
        'lMoTa
        '
        Me.lMoTa.AutoSize = True
        Me.lMoTa.Location = New System.Drawing.Point(24, 30)
        Me.lMoTa.Name = "lMoTa"
        Me.lMoTa.Size = New System.Drawing.Size(0, 15)
        Me.lMoTa.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lMoTa)
        Me.GroupBox1.Location = New System.Drawing.Point(336, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 274)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thong tin menu"
        '
        'bThem
        '
        Me.bThem.Location = New System.Drawing.Point(360, 120)
        Me.bThem.Name = "bThem"
        Me.bThem.Size = New System.Drawing.Size(75, 23)
        Me.bThem.TabIndex = 10
        Me.bThem.Text = "Them"
        Me.bThem.UseVisualStyleBackColor = True
        '
        'bCapNhat
        '
        Me.bCapNhat.Location = New System.Drawing.Point(469, 120)
        Me.bCapNhat.Name = "bCapNhat"
        Me.bCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.bCapNhat.TabIndex = 11
        Me.bCapNhat.Text = "Cap nhat"
        Me.bCapNhat.UseVisualStyleBackColor = True
        '
        'bXoa
        '
        Me.bXoa.Location = New System.Drawing.Point(574, 120)
        Me.bXoa.Name = "bXoa"
        Me.bXoa.Size = New System.Drawing.Size(75, 23)
        Me.bXoa.TabIndex = 12
        Me.bXoa.Text = "Xoa"
        Me.bXoa.UseVisualStyleBackColor = True
        '
        'frmMenuChiNhanh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bXoa)
        Me.Controls.Add(Me.bCapNhat)
        Me.Controls.Add(Me.bThem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDanhSachMonAn)
        Me.Controls.Add(Me.dtpNgay)
        Me.Controls.Add(Me.cbChiNhanh)
        Me.Controls.Add(Me.cbMenu)
        Me.Controls.Add(Me.dgvDanhSach)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMenuChiNhanh"
        Me.Text = "frmMenuChiNhanh"
        CType(Me.dgvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDanhSachMonAn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDanhSach As DataGridView
    Friend WithEvents cbMenu As ComboBox
    Friend WithEvents cbChiNhanh As ComboBox
    Friend WithEvents dtpNgay As DateTimePicker
    Friend WithEvents dgvDanhSachMonAn As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lMoTa As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bThem As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bXoa As Button
End Class
