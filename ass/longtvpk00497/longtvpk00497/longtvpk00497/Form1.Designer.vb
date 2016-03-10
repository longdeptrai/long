<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblMSP = New System.Windows.Forms.Label()
        Me.lblTSP = New System.Windows.Forms.Label()
        Me.lblLSP = New System.Windows.Forms.Label()
        Me.lblGN = New System.Windows.Forms.Label()
        Me.lblKN = New System.Windows.Forms.Label()
        Me.lblGB = New System.Windows.Forms.Label()
        Me.lblNN = New System.Windows.Forms.Label()
        Me.lblSL = New System.Windows.Forms.Label()
        Me.txtMSP = New System.Windows.Forms.TextBox()
        Me.txtTSP = New System.Windows.Forms.TextBox()
        Me.txtGN = New System.Windows.Forms.TextBox()
        Me.txtGB = New System.Windows.Forms.TextBox()
        Me.dtprNgaynhap = New System.Windows.Forms.DateTimePicker()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.lvwQLSP = New System.Windows.Forms.ListView()
        Me.STT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MSP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TSP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LSP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.KN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nudSL = New System.Windows.Forms.NumericUpDown()
        Me.cbxLSP = New System.Windows.Forms.ComboBox()
        Me.cbxKN = New System.Windows.Forms.ComboBox()
        CType(Me.nudSL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMSP
        '
        Me.lblMSP.AutoSize = True
        Me.lblMSP.Location = New System.Drawing.Point(62, 34)
        Me.lblMSP.Name = "lblMSP"
        Me.lblMSP.Size = New System.Drawing.Size(71, 13)
        Me.lblMSP.TabIndex = 0
        Me.lblMSP.Text = "Mã sản phẩm"
        '
        'lblTSP
        '
        Me.lblTSP.AutoSize = True
        Me.lblTSP.Location = New System.Drawing.Point(62, 101)
        Me.lblTSP.Name = "lblTSP"
        Me.lblTSP.Size = New System.Drawing.Size(75, 13)
        Me.lblTSP.TabIndex = 0
        Me.lblTSP.Text = "Tên sản phẩm"
        '
        'lblLSP
        '
        Me.lblLSP.AutoSize = True
        Me.lblLSP.Location = New System.Drawing.Point(62, 165)
        Me.lblLSP.Name = "lblLSP"
        Me.lblLSP.Size = New System.Drawing.Size(76, 13)
        Me.lblLSP.TabIndex = 0
        Me.lblLSP.Text = "Loại sản phẩm"
        '
        'lblGN
        '
        Me.lblGN.AutoSize = True
        Me.lblGN.Location = New System.Drawing.Point(333, 34)
        Me.lblGN.Name = "lblGN"
        Me.lblGN.Size = New System.Drawing.Size(50, 13)
        Me.lblGN.TabIndex = 0
        Me.lblGN.Text = "Giá nhập"
        '
        'lblKN
        '
        Me.lblKN.AutoSize = True
        Me.lblKN.Location = New System.Drawing.Point(330, 169)
        Me.lblKN.Name = "lblKN"
        Me.lblKN.Size = New System.Drawing.Size(53, 13)
        Me.lblKN.TabIndex = 0
        Me.lblKN.Text = "Kho nhập"
        '
        'lblGB
        '
        Me.lblGB.AutoSize = True
        Me.lblGB.Location = New System.Drawing.Point(333, 101)
        Me.lblGB.Name = "lblGB"
        Me.lblGB.Size = New System.Drawing.Size(44, 13)
        Me.lblGB.TabIndex = 0
        Me.lblGB.Text = "Giá bán"
        '
        'lblNN
        '
        Me.lblNN.AutoSize = True
        Me.lblNN.Location = New System.Drawing.Point(559, 98)
        Me.lblNN.Name = "lblNN"
        Me.lblNN.Size = New System.Drawing.Size(59, 13)
        Me.lblNN.TabIndex = 0
        Me.lblNN.Text = "Ngày nhập"
        '
        'lblSL
        '
        Me.lblSL.AutoSize = True
        Me.lblSL.Location = New System.Drawing.Point(559, 34)
        Me.lblSL.Name = "lblSL"
        Me.lblSL.Size = New System.Drawing.Size(49, 13)
        Me.lblSL.TabIndex = 0
        Me.lblSL.Text = "Số lượng"
        '
        'txtMSP
        '
        Me.txtMSP.Location = New System.Drawing.Point(160, 31)
        Me.txtMSP.Name = "txtMSP"
        Me.txtMSP.Size = New System.Drawing.Size(100, 20)
        Me.txtMSP.TabIndex = 1
        '
        'txtTSP
        '
        Me.txtTSP.Location = New System.Drawing.Point(160, 98)
        Me.txtTSP.Name = "txtTSP"
        Me.txtTSP.Size = New System.Drawing.Size(100, 20)
        Me.txtTSP.TabIndex = 1
        '
        'txtGN
        '
        Me.txtGN.Location = New System.Drawing.Point(411, 31)
        Me.txtGN.Name = "txtGN"
        Me.txtGN.Size = New System.Drawing.Size(100, 20)
        Me.txtGN.TabIndex = 1
        '
        'txtGB
        '
        Me.txtGB.Location = New System.Drawing.Point(411, 98)
        Me.txtGB.Name = "txtGB"
        Me.txtGB.Size = New System.Drawing.Size(100, 20)
        Me.txtGB.TabIndex = 1
        '
        'dtprNgaynhap
        '
        Me.dtprNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtprNgaynhap.Location = New System.Drawing.Point(636, 95)
        Me.dtprNgaynhap.Name = "dtprNgaynhap"
        Me.dtprNgaynhap.Size = New System.Drawing.Size(100, 20)
        Me.dtprNgaynhap.TabIndex = 2
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(336, 250)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(446, 250)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 3
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(553, 250)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 3
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(661, 250)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 3
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'lvwQLSP
        '
        Me.lvwQLSP.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.STT, Me.MSP, Me.TSP, Me.GN, Me.GB, Me.SL, Me.LSP, Me.KN, Me.NN})
        Me.lvwQLSP.GridLines = True
        Me.lvwQLSP.Location = New System.Drawing.Point(65, 293)
        Me.lvwQLSP.Name = "lvwQLSP"
        Me.lvwQLSP.Size = New System.Drawing.Size(671, 211)
        Me.lvwQLSP.TabIndex = 4
        Me.lvwQLSP.UseCompatibleStateImageBehavior = False
        Me.lvwQLSP.View = System.Windows.Forms.View.Details
        '
        'STT
        '
        Me.STT.Text = "STT"
        Me.STT.Width = 42
        '
        'MSP
        '
        Me.MSP.Text = "Mã SP"
        Me.MSP.Width = 72
        '
        'TSP
        '
        Me.TSP.Text = "Tên SP"
        Me.TSP.Width = 106
        '
        'GN
        '
        Me.GN.Text = "Giá nhập"
        Me.GN.Width = 68
        '
        'GB
        '
        Me.GB.Text = "Giá bán"
        '
        'SL
        '
        Me.SL.Text = "Số lượng"
        '
        'LSP
        '
        Me.LSP.Text = "Loại sản phẩm"
        Me.LSP.Width = 104
        '
        'KN
        '
        Me.KN.Text = "Kho nhập"
        Me.KN.Width = 61
        '
        'NN
        '
        Me.NN.Text = "Ngày nhập"
        Me.NN.Width = 93
        '
        'nudSL
        '
        Me.nudSL.Location = New System.Drawing.Point(636, 31)
        Me.nudSL.Name = "nudSL"
        Me.nudSL.Size = New System.Drawing.Size(100, 20)
        Me.nudSL.TabIndex = 5
        '
        'cbxLSP
        '
        Me.cbxLSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLSP.FormattingEnabled = True
        Me.cbxLSP.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.cbxLSP.Location = New System.Drawing.Point(144, 161)
        Me.cbxLSP.Name = "cbxLSP"
        Me.cbxLSP.Size = New System.Drawing.Size(116, 21)
        Me.cbxLSP.TabIndex = 6
        '
        'cbxKN
        '
        Me.cbxKN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxKN.FormattingEnabled = True
        Me.cbxKN.Items.AddRange(New Object() {"Kho 1", "Kho 2", "Kho 3", "Kho 4", "Kho 5"})
        Me.cbxKN.Location = New System.Drawing.Point(411, 165)
        Me.cbxKN.Name = "cbxKN"
        Me.cbxKN.Size = New System.Drawing.Size(100, 21)
        Me.cbxKN.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 516)
        Me.Controls.Add(Me.cbxKN)
        Me.Controls.Add(Me.cbxLSP)
        Me.Controls.Add(Me.nudSL)
        Me.Controls.Add(Me.lvwQLSP)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dtprNgaynhap)
        Me.Controls.Add(Me.txtGB)
        Me.Controls.Add(Me.txtGN)
        Me.Controls.Add(Me.txtTSP)
        Me.Controls.Add(Me.txtMSP)
        Me.Controls.Add(Me.lblSL)
        Me.Controls.Add(Me.lblNN)
        Me.Controls.Add(Me.lblGB)
        Me.Controls.Add(Me.lblKN)
        Me.Controls.Add(Me.lblGN)
        Me.Controls.Add(Me.lblLSP)
        Me.Controls.Add(Me.lblTSP)
        Me.Controls.Add(Me.lblMSP)
        Me.Name = "Form1"
        Me.Text = "Quản lý sản phẩm"
        CType(Me.nudSL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMSP As System.Windows.Forms.Label
    Friend WithEvents lblTSP As System.Windows.Forms.Label
    Friend WithEvents lblLSP As System.Windows.Forms.Label
    Friend WithEvents lblGN As System.Windows.Forms.Label
    Friend WithEvents lblKN As System.Windows.Forms.Label
    Friend WithEvents lblGB As System.Windows.Forms.Label
    Friend WithEvents lblNN As System.Windows.Forms.Label
    Friend WithEvents lblSL As System.Windows.Forms.Label
    Friend WithEvents txtMSP As System.Windows.Forms.TextBox
    Friend WithEvents txtTSP As System.Windows.Forms.TextBox
    Friend WithEvents txtGN As System.Windows.Forms.TextBox
    Friend WithEvents txtGB As System.Windows.Forms.TextBox
    Friend WithEvents dtprNgaynhap As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents lvwQLSP As System.Windows.Forms.ListView
    Friend WithEvents STT As System.Windows.Forms.ColumnHeader
    Friend WithEvents MSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents TSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents GN As System.Windows.Forms.ColumnHeader
    Friend WithEvents GB As System.Windows.Forms.ColumnHeader
    Friend WithEvents SL As System.Windows.Forms.ColumnHeader
    Friend WithEvents LSP As System.Windows.Forms.ColumnHeader
    Friend WithEvents KN As System.Windows.Forms.ColumnHeader
    Friend WithEvents NN As System.Windows.Forms.ColumnHeader
    Friend WithEvents nudSL As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbxLSP As System.Windows.Forms.ComboBox
    Friend WithEvents cbxKN As System.Windows.Forms.ComboBox

End Class
