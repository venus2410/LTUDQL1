<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonAn
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvDanhSach = New System.Windows.Forms.DataGridView()
        Me.tbTim = New System.Windows.Forms.TextBox()
        Me.tbTen = New System.Windows.Forms.TextBox()
        Me.cbLoai = New System.Windows.Forms.ComboBox()
        Me.nudGia = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvDanhSach)
        Me.Panel1.Controls.Add(Me.tbTim)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(453, 385)
        Me.Panel1.TabIndex = 0
        '
        'dgvDanhSach
        '
        Me.dgvDanhSach.AllowUserToAddRows = False
        Me.dgvDanhSach.AllowUserToDeleteRows = False
        Me.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDanhSach.Location = New System.Drawing.Point(0, 23)
        Me.dgvDanhSach.Name = "dgvDanhSach"
        Me.dgvDanhSach.RowTemplate.Height = 25
        Me.dgvDanhSach.Size = New System.Drawing.Size(453, 362)
        Me.dgvDanhSach.TabIndex = 1
        '
        'tbTim
        '
        Me.tbTim.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbTim.Location = New System.Drawing.Point(0, 0)
        Me.tbTim.Name = "tbTim"
        Me.tbTim.Size = New System.Drawing.Size(453, 23)
        Me.tbTim.TabIndex = 0
        '
        'tbTen
        '
        Me.tbTen.Location = New System.Drawing.Point(561, 81)
        Me.tbTen.Name = "tbTen"
        Me.tbTen.Size = New System.Drawing.Size(121, 23)
        Me.tbTen.TabIndex = 1
        '
        'cbLoai
        '
        Me.cbLoai.FormattingEnabled = True
        Me.cbLoai.Location = New System.Drawing.Point(562, 53)
        Me.cbLoai.Name = "cbLoai"
        Me.cbLoai.Size = New System.Drawing.Size(121, 23)
        Me.cbLoai.TabIndex = 3
        '
        'nudGia
        '
        Me.nudGia.Location = New System.Drawing.Point(562, 112)
        Me.nudGia.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nudGia.Name = "nudGia"
        Me.nudGia.Size = New System.Drawing.Size(120, 23)
        Me.nudGia.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(496, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Loại"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(496, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(496, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Giá"
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(496, 216)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 8
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(613, 215)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 9
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(730, 215)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 10
        Me.btnXoa.Text = "Xoá"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'frmMonAn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 385)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudGia)
        Me.Controls.Add(Me.cbLoai)
        Me.Controls.Add(Me.tbTen)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMonAn"
        Me.Text = "frmMonAn"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvDanhSach As DataGridView
    Friend WithEvents tbTim As TextBox
    Friend WithEvents tbTen As TextBox
    Friend WithEvents cbLoai As ComboBox
    Friend WithEvents nudGia As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
End Class
