<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmĐăngNhập
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
        Me.lblTTK = New System.Windows.Forms.Label()
        Me.lblMK = New System.Windows.Forms.Label()
        Me.txtTTK = New System.Windows.Forms.TextBox()
        Me.txtMK = New System.Windows.Forms.TextBox()
        Me.btnDN = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.cbxHMK = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblTTK
        '
        Me.lblTTK.AutoSize = True
        Me.lblTTK.Location = New System.Drawing.Point(61, 50)
        Me.lblTTK.Name = "lblTTK"
        Me.lblTTK.Size = New System.Drawing.Size(73, 13)
        Me.lblTTK.TabIndex = 0
        Me.lblTTK.Text = "Tên tài khoản"
        '
        'lblMK
        '
        Me.lblMK.AutoSize = True
        Me.lblMK.Location = New System.Drawing.Point(61, 107)
        Me.lblMK.Name = "lblMK"
        Me.lblMK.Size = New System.Drawing.Size(52, 13)
        Me.lblMK.TabIndex = 0
        Me.lblMK.Text = "Mật khẩu"
        '
        'txtTTK
        '
        Me.txtTTK.Location = New System.Drawing.Point(158, 47)
        Me.txtTTK.Name = "txtTTK"
        Me.txtTTK.Size = New System.Drawing.Size(153, 20)
        Me.txtTTK.TabIndex = 1
        '
        'txtMK
        '
        Me.txtMK.Location = New System.Drawing.Point(158, 107)
        Me.txtMK.Name = "txtMK"
        Me.txtMK.Size = New System.Drawing.Size(153, 20)
        Me.txtMK.TabIndex = 1
        '
        'btnDN
        '
        Me.btnDN.Location = New System.Drawing.Point(84, 197)
        Me.btnDN.Name = "btnDN"
        Me.btnDN.Size = New System.Drawing.Size(75, 23)
        Me.btnDN.TabIndex = 2
        Me.btnDN.Text = "Đăng nhập"
        Me.btnDN.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(236, 197)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 2
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'cbxHMK
        '
        Me.cbxHMK.AutoSize = True
        Me.cbxHMK.Location = New System.Drawing.Point(158, 152)
        Me.cbxHMK.Name = "cbxHMK"
        Me.cbxHMK.Size = New System.Drawing.Size(95, 17)
        Me.cbxHMK.TabIndex = 3
        Me.cbxHMK.Text = "Hiện mật khẩu"
        Me.cbxHMK.UseVisualStyleBackColor = True
        '
        'FrmĐăngNhập
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 306)
        Me.Controls.Add(Me.cbxHMK)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDN)
        Me.Controls.Add(Me.txtMK)
        Me.Controls.Add(Me.txtTTK)
        Me.Controls.Add(Me.lblMK)
        Me.Controls.Add(Me.lblTTK)
        Me.Name = "FrmĐăngNhập"
        Me.Text = "Đăng nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTTK As System.Windows.Forms.Label
    Friend WithEvents lblMK As System.Windows.Forms.Label
    Friend WithEvents txtTTK As System.Windows.Forms.TextBox
    Friend WithEvents txtMK As System.Windows.Forms.TextBox
    Friend WithEvents btnDN As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents cbxHMK As System.Windows.Forms.CheckBox
End Class
