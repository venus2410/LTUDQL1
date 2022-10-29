<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNguoiDung
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
        Me.tbTen = New System.Windows.Forms.TextBox()
        Me.tbCMND = New System.Windows.Forms.TextBox()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.tbDiaChi = New System.Windows.Forms.TextBox()
        Me.tbTenDangNhap = New System.Windows.Forms.TextBox()
        Me.tbMatKhau = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bThem = New System.Windows.Forms.Button()
        Me.bCapNhat = New System.Windows.Forms.Button()
        Me.bXoa = New System.Windows.Forms.Button()
        Me.dgvDSNguoiDung = New System.Windows.Forms.DataGridView()
        Me.tDienThoai = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvDSNguoiDung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbTen
        '
        Me.tbTen.Location = New System.Drawing.Point(769, 50)
        Me.tbTen.Name = "tbTen"
        Me.tbTen.Size = New System.Drawing.Size(200, 23)
        Me.tbTen.TabIndex = 0
        '
        'tbCMND
        '
        Me.tbCMND.Location = New System.Drawing.Point(769, 91)
        Me.tbCMND.Name = "tbCMND"
        Me.tbCMND.Size = New System.Drawing.Size(200, 23)
        Me.tbCMND.TabIndex = 1
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.CustomFormat = "dd/mm/yyyy"
        Me.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgaySinh.Location = New System.Drawing.Point(769, 133)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(200, 23)
        Me.dtpNgaySinh.TabIndex = 2
        Me.dtpNgaySinh.Value = New Date(2022, 10, 15, 20, 43, 36, 0)
        '
        'tbDiaChi
        '
        Me.tbDiaChi.Location = New System.Drawing.Point(769, 178)
        Me.tbDiaChi.Name = "tbDiaChi"
        Me.tbDiaChi.Size = New System.Drawing.Size(200, 23)
        Me.tbDiaChi.TabIndex = 3
        '
        'tbTenDangNhap
        '
        Me.tbTenDangNhap.Location = New System.Drawing.Point(769, 240)
        Me.tbTenDangNhap.Name = "tbTenDangNhap"
        Me.tbTenDangNhap.Size = New System.Drawing.Size(100, 23)
        Me.tbTenDangNhap.TabIndex = 4
        '
        'tbMatKhau
        '
        Me.tbMatKhau.Location = New System.Drawing.Point(769, 284)
        Me.tbMatKhau.Name = "tbMatKhau"
        Me.tbMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbMatKhau.Size = New System.Drawing.Size(100, 23)
        Me.tbMatKhau.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(670, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ten"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(670, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "CMND"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(670, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Ngay sinh"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(670, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Dia chi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(670, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Ten dang nhap"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(670, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Mat khau"
        '
        'bThem
        '
        Me.bThem.Location = New System.Drawing.Point(670, 335)
        Me.bThem.Name = "bThem"
        Me.bThem.Size = New System.Drawing.Size(75, 23)
        Me.bThem.TabIndex = 12
        Me.bThem.Text = "Them"
        Me.bThem.UseVisualStyleBackColor = True
        '
        'bCapNhat
        '
        Me.bCapNhat.Location = New System.Drawing.Point(806, 335)
        Me.bCapNhat.Name = "bCapNhat"
        Me.bCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.bCapNhat.TabIndex = 13
        Me.bCapNhat.Text = "Cap nhat"
        Me.bCapNhat.UseVisualStyleBackColor = True
        '
        'bXoa
        '
        Me.bXoa.Location = New System.Drawing.Point(940, 335)
        Me.bXoa.Name = "bXoa"
        Me.bXoa.Size = New System.Drawing.Size(75, 23)
        Me.bXoa.TabIndex = 14
        Me.bXoa.Text = "Xoa"
        Me.bXoa.UseVisualStyleBackColor = True
        '
        'dgvDSNguoiDung
        '
        Me.dgvDSNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSNguoiDung.Location = New System.Drawing.Point(13, 25)
        Me.dgvDSNguoiDung.Name = "dgvDSNguoiDung"
        Me.dgvDSNguoiDung.RowTemplate.Height = 25
        Me.dgvDSNguoiDung.Size = New System.Drawing.Size(634, 377)
        Me.dgvDSNguoiDung.TabIndex = 15
        '
        'tDienThoai
        '
        Me.tDienThoai.Location = New System.Drawing.Point(769, 208)
        Me.tDienThoai.Name = "tDienThoai"
        Me.tDienThoai.Size = New System.Drawing.Size(200, 23)
        Me.tDienThoai.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(670, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Dien thoai"
        '
        'frmNguoiDung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tDienThoai)
        Me.Controls.Add(Me.dgvDSNguoiDung)
        Me.Controls.Add(Me.bXoa)
        Me.Controls.Add(Me.bCapNhat)
        Me.Controls.Add(Me.bThem)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMatKhau)
        Me.Controls.Add(Me.tbTenDangNhap)
        Me.Controls.Add(Me.tbDiaChi)
        Me.Controls.Add(Me.dtpNgaySinh)
        Me.Controls.Add(Me.tbCMND)
        Me.Controls.Add(Me.tbTen)
        Me.Name = "frmNguoiDung"
        Me.Text = "frmNguoiDung"
        CType(Me.dgvDSNguoiDung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbTen As TextBox
    Friend WithEvents tbCMND As TextBox
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents tbTenDangNhap As TextBox
    Friend WithEvents tbMatKhau As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents bThem As Button
    Friend WithEvents bCapNhat As Button
    Friend WithEvents bXoa As Button
    Friend WithEvents dgvDSNguoiDung As DataGridView
    Friend WithEvents tDienThoai As TextBox
    Friend WithEvents Label7 As Label
End Class
