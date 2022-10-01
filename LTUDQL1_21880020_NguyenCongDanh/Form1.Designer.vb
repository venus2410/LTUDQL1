<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiNhanh
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvDanhSach = New System.Windows.Forms.DataGridView()
        Me.tbTim = New System.Windows.Forms.TextBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.tbDiaChi = New System.Windows.Forms.TextBox()
        Me.tbTen = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvDanhSach)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tbTim)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnXoa)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCapNhat)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnThem)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tbDiaChi)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tbTen)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(693, 350)
        Me.SplitContainer1.SplitterDistance = 337
        Me.SplitContainer1.TabIndex = 0
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
        Me.dgvDanhSach.Size = New System.Drawing.Size(337, 327)
        Me.dgvDanhSach.TabIndex = 1
        '
        'tbTim
        '
        Me.tbTim.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbTim.Location = New System.Drawing.Point(0, 0)
        Me.tbTim.Name = "tbTim"
        Me.tbTim.Size = New System.Drawing.Size(337, 23)
        Me.tbTim.TabIndex = 0
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(255, 159)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 6
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(144, 159)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 5
        Me.btnCapNhat.Text = "Cập nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(32, 159)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 4
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'tbDiaChi
        '
        Me.tbDiaChi.Location = New System.Drawing.Point(164, 90)
        Me.tbDiaChi.Name = "tbDiaChi"
        Me.tbDiaChi.Size = New System.Drawing.Size(100, 23)
        Me.tbDiaChi.TabIndex = 3
        '
        'tbTen
        '
        Me.tbTen.Location = New System.Drawing.Point(164, 55)
        Me.tbTen.Name = "tbTen"
        Me.tbTen.Size = New System.Drawing.Size(100, 23)
        Me.tbTen.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Địa chỉ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên"
        '
        'frmChiNhanh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 350)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmChiNhanh"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgvDanhSach As DataGridView
    Friend WithEvents tbTim As TextBox
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents tbTen As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
