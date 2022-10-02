<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.tbTen = New System.Windows.Forms.TextBox()
        Me.tbMoTa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bThem = New System.Windows.Forms.Button()
        Me.bCapNhat = New System.Windows.Forms.Button()
        Me.bXoa = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.cbHienThi = New System.Windows.Forms.CheckBox()
        Me.bKhoiPhuc = New System.Windows.Forms.Button()
        Me.dgvDSMonAn = New System.Windows.Forms.DataGridView()
        Me.bThemMonAn = New System.Windows.Forms.Button()
        Me.bXoaMonAn = New System.Windows.Forms.Button()
        Me.bCapNhatGia = New System.Windows.Forms.Button()
        CType(Me.dgvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDSMonAn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDanhSach
        '
        Me.dgvDanhSach.AllowUserToAddRows = False
        Me.dgvDanhSach.AllowUserToDeleteRows = False
        Me.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSach.Location = New System.Drawing.Point(0, 29)
        Me.dgvDanhSach.Name = "dgvDanhSach"
        Me.dgvDanhSach.RowTemplate.Height = 25
        Me.dgvDanhSach.Size = New System.Drawing.Size(345, 446)
        Me.dgvDanhSach.TabIndex = 0
        '
        'tbTen
        '
        Me.tbTen.Location = New System.Drawing.Point(534, 49)
        Me.tbTen.Name = "tbTen"
        Me.tbTen.Size = New System.Drawing.Size(100, 23)
        Me.tbTen.TabIndex = 1
        '
        'tbMoTa
        '
        Me.tbMoTa.Location = New System.Drawing.Point(534, 92)
        Me.tbMoTa.Name = "tbMoTa"
        Me.tbMoTa.Size = New System.Drawing.Size(100, 23)
        Me.tbMoTa.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(466, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ten"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(466, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mo ta"
        '
        'bThem
        '
        Me.bThem.Location = New System.Drawing.Point(423, 190)
        Me.bThem.Name = "bThem"
        Me.bThem.Size = New System.Drawing.Size(75, 23)
        Me.bThem.TabIndex = 5
        Me.bThem.Text = "Them"
        Me.bThem.UseVisualStyleBackColor = True
        '
        'bCapNhat
        '
        Me.bCapNhat.Location = New System.Drawing.Point(534, 190)
        Me.bCapNhat.Name = "bCapNhat"
        Me.bCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.bCapNhat.TabIndex = 6
        Me.bCapNhat.Text = "Cap nhat"
        Me.bCapNhat.UseVisualStyleBackColor = True
        '
        'bXoa
        '
        Me.bXoa.Location = New System.Drawing.Point(641, 190)
        Me.bXoa.Name = "bXoa"
        Me.bXoa.Size = New System.Drawing.Size(75, 23)
        Me.bXoa.TabIndex = 7
        Me.bXoa.Text = "Xoa"
        Me.bXoa.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(0, 0)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(591, 23)
        Me.TextBox3.TabIndex = 8
        '
        'cbHienThi
        '
        Me.cbHienThi.AutoSize = True
        Me.cbHienThi.Location = New System.Drawing.Point(423, 236)
        Me.cbHienThi.Name = "cbHienThi"
        Me.cbHienThi.Size = New System.Drawing.Size(139, 19)
        Me.cbHienThi.TabIndex = 9
        Me.cbHienThi.Text = "Hien thi menu da xoa"
        Me.cbHienThi.UseVisualStyleBackColor = True
        '
        'bKhoiPhuc
        '
        Me.bKhoiPhuc.Location = New System.Drawing.Point(641, 232)
        Me.bKhoiPhuc.Name = "bKhoiPhuc"
        Me.bKhoiPhuc.Size = New System.Drawing.Size(75, 23)
        Me.bKhoiPhuc.TabIndex = 10
        Me.bKhoiPhuc.Text = "Khoi Phuc"
        Me.bKhoiPhuc.UseVisualStyleBackColor = True
        '
        'dgvDSMonAn
        '
        Me.dgvDSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSMonAn.Location = New System.Drawing.Point(371, 325)
        Me.dgvDSMonAn.Name = "dgvDSMonAn"
        Me.dgvDSMonAn.RowTemplate.Height = 25
        Me.dgvDSMonAn.Size = New System.Drawing.Size(400, 150)
        Me.dgvDSMonAn.TabIndex = 11
        '
        'bThemMonAn
        '
        Me.bThemMonAn.Location = New System.Drawing.Point(423, 296)
        Me.bThemMonAn.Name = "bThemMonAn"
        Me.bThemMonAn.Size = New System.Drawing.Size(75, 23)
        Me.bThemMonAn.TabIndex = 12
        Me.bThemMonAn.Text = "Them mon"
        Me.bThemMonAn.UseVisualStyleBackColor = True
        '
        'bXoaMonAn
        '
        Me.bXoaMonAn.Location = New System.Drawing.Point(534, 296)
        Me.bXoaMonAn.Name = "bXoaMonAn"
        Me.bXoaMonAn.Size = New System.Drawing.Size(75, 23)
        Me.bXoaMonAn.TabIndex = 13
        Me.bXoaMonAn.Text = "Xoa mon"
        Me.bXoaMonAn.UseVisualStyleBackColor = True
        '
        'bCapNhatGia
        '
        Me.bCapNhatGia.Location = New System.Drawing.Point(641, 296)
        Me.bCapNhatGia.Name = "bCapNhatGia"
        Me.bCapNhatGia.Size = New System.Drawing.Size(75, 23)
        Me.bCapNhatGia.TabIndex = 14
        Me.bCapNhatGia.Text = "Cap nhat"
        Me.bCapNhatGia.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 485)
        Me.Controls.Add(Me.bCapNhatGia)
        Me.Controls.Add(Me.bXoaMonAn)
        Me.Controls.Add(Me.bThemMonAn)
        Me.Controls.Add(Me.dgvDSMonAn)
        Me.Controls.Add(Me.bKhoiPhuc)
        Me.Controls.Add(Me.cbHienThi)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.bXoa)
        Me.Controls.Add(Me.bCapNhat)
        Me.Controls.Add(Me.bThem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMoTa)
        Me.Controls.Add(Me.tbTen)
        Me.Controls.Add(Me.dgvDanhSach)
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        CType(Me.dgvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDSMonAn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDanhSach As DataGridView
    Friend WithEvents tbTen As TextBox
    Friend WithEvents tbMoTa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bThem As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bXoa As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents cbHienThi As CheckBox
    Friend WithEvents bKhoiPhuc As Button
    Friend WithEvents dgvDSMonAn As DataGridView
    Friend WithEvents bThemMonAn As Button
    Friend WithEvents bXoaMonAn As Button
    Friend WithEvents bCapNhatGia As Button
End Class
