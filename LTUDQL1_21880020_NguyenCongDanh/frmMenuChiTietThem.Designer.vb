<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuChiTietThem
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
        Me.dgvDSMonAn = New System.Windows.Forms.DataGridView()
        Me.bDongY = New System.Windows.Forms.Button()
        Me.bDong = New System.Windows.Forms.Button()
        CType(Me.dgvDSMonAn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDSMonAn
        '
        Me.dgvDSMonAn.AllowUserToAddRows = False
        Me.dgvDSMonAn.AllowUserToDeleteRows = False
        Me.dgvDSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDSMonAn.Location = New System.Drawing.Point(23, 77)
        Me.dgvDSMonAn.Name = "dgvDSMonAn"
        Me.dgvDSMonAn.RowTemplate.Height = 25
        Me.dgvDSMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDSMonAn.Size = New System.Drawing.Size(522, 150)
        Me.dgvDSMonAn.TabIndex = 0
        '
        'bDongY
        '
        Me.bDongY.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bDongY.Location = New System.Drawing.Point(23, 28)
        Me.bDongY.Name = "bDongY"
        Me.bDongY.Size = New System.Drawing.Size(75, 23)
        Me.bDongY.TabIndex = 1
        Me.bDongY.Text = "Them"
        Me.bDongY.UseVisualStyleBackColor = True
        '
        'bDong
        '
        Me.bDong.Location = New System.Drawing.Point(186, 28)
        Me.bDong.Name = "bDong"
        Me.bDong.Size = New System.Drawing.Size(75, 23)
        Me.bDong.TabIndex = 2
        Me.bDong.Text = "Dong"
        Me.bDong.UseVisualStyleBackColor = True
        '
        'frmMenuChiTietThem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 250)
        Me.Controls.Add(Me.bDong)
        Me.Controls.Add(Me.bDongY)
        Me.Controls.Add(Me.dgvDSMonAn)
        Me.Name = "frmMenuChiTietThem"
        Me.Text = "frmMenuChiTietThem"
        CType(Me.dgvDSMonAn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvDSMonAn As DataGridView
    Friend WithEvents bDongY As Button
    Friend WithEvents bDong As Button
End Class
