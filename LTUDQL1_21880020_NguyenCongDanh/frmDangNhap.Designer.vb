<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
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
        Me.bDangNhap = New System.Windows.Forms.Button()
        Me.bThoat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbTenDangNhap = New System.Windows.Forms.TextBox()
        Me.tbMatKhau = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bDangNhap
        '
        Me.bDangNhap.Location = New System.Drawing.Point(250, 232)
        Me.bDangNhap.Name = "bDangNhap"
        Me.bDangNhap.Size = New System.Drawing.Size(75, 23)
        Me.bDangNhap.TabIndex = 0
        Me.bDangNhap.Text = "Dang nhap"
        Me.bDangNhap.UseVisualStyleBackColor = True
        '
        'bThoat
        '
        Me.bThoat.Location = New System.Drawing.Point(420, 232)
        Me.bThoat.Name = "bThoat"
        Me.bThoat.Size = New System.Drawing.Size(75, 23)
        Me.bThoat.TabIndex = 1
        Me.bThoat.Text = "Thoat"
        Me.bThoat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(225, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ten dang nhap"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mat khau"
        '
        'tbTenDangNhap
        '
        Me.tbTenDangNhap.Location = New System.Drawing.Point(321, 101)
        Me.tbTenDangNhap.Name = "tbTenDangNhap"
        Me.tbTenDangNhap.Size = New System.Drawing.Size(148, 23)
        Me.tbTenDangNhap.TabIndex = 4
        '
        'tbMatKhau
        '
        Me.tbMatKhau.Location = New System.Drawing.Point(321, 160)
        Me.tbMatKhau.Name = "tbMatKhau"
        Me.tbMatKhau.Size = New System.Drawing.Size(148, 23)
        Me.tbMatKhau.TabIndex = 5
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tbMatKhau)
        Me.Controls.Add(Me.tbTenDangNhap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bThoat)
        Me.Controls.Add(Me.bDangNhap)
        Me.Name = "frmDangNhap"
        Me.Text = "frmDangNhap"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bDangNhap As Button
    Friend WithEvents bThoat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTenDangNhap As TextBox
    Friend WithEvents tbMatKhau As TextBox
End Class
