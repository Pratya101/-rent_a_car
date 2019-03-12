<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InserteGenForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDataGen = New System.Windows.Forms.DataGridView()
        Me.gboData = New System.Windows.Forms.GroupBox()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.cboBrand = New System.Windows.Forms.ComboBox()
        Me.cboYear = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radPlain = New System.Windows.Forms.RadioButton()
        Me.radAoto = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtGId = New System.Windows.Forms.TextBox()
        Me.txtGName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnInserte = New System.Windows.Forms.Button()
        CType(Me.dgvDataGen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboData.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(295, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "จัดการข้อมูลรุ่นห้อรถยนต์"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDataGen
        '
        Me.dgvDataGen.AllowUserToAddRows = False
        Me.dgvDataGen.AllowUserToDeleteRows = False
        Me.dgvDataGen.AllowUserToResizeColumns = False
        Me.dgvDataGen.AllowUserToResizeRows = False
        Me.dgvDataGen.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvDataGen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataGen.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDataGen.Location = New System.Drawing.Point(12, 64)
        Me.dgvDataGen.Name = "dgvDataGen"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvDataGen.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDataGen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDataGen.Size = New System.Drawing.Size(829, 247)
        Me.dgvDataGen.TabIndex = 3
        '
        'gboData
        '
        Me.gboData.Controls.Add(Me.cboSize)
        Me.gboData.Controls.Add(Me.Label6)
        Me.gboData.Controls.Add(Me.cboType)
        Me.gboData.Controls.Add(Me.cboBrand)
        Me.gboData.Controls.Add(Me.cboYear)
        Me.gboData.Controls.Add(Me.GroupBox3)
        Me.gboData.Controls.Add(Me.Label7)
        Me.gboData.Controls.Add(Me.Label5)
        Me.gboData.Controls.Add(Me.Label4)
        Me.gboData.Controls.Add(Me.Label10)
        Me.gboData.Controls.Add(Me.btnSave)
        Me.gboData.Controls.Add(Me.Label3)
        Me.gboData.Controls.Add(Me.btnCancel)
        Me.gboData.Controls.Add(Me.Label2)
        Me.gboData.Controls.Add(Me.Label11)
        Me.gboData.Controls.Add(Me.txtGId)
        Me.gboData.Controls.Add(Me.txtGName)
        Me.gboData.Location = New System.Drawing.Point(12, 331)
        Me.gboData.Name = "gboData"
        Me.gboData.Size = New System.Drawing.Size(829, 243)
        Me.gboData.TabIndex = 25
        Me.gboData.TabStop = False
        Me.gboData.Text = "ข้อมูล"
        '
        'cboSize
        '
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60"})
        Me.cboSize.Location = New System.Drawing.Point(535, 35)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(178, 21)
        Me.cboSize.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AllowDrop = True
        Me.Label6.AutoEllipsis = True
        Me.Label6.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(390, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 18)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "ความจุถังน้ำมัน"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(535, 117)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(178, 21)
        Me.cboType.TabIndex = 38
        '
        'cboBrand
        '
        Me.cboBrand.FormattingEnabled = True
        Me.cboBrand.Location = New System.Drawing.Point(535, 159)
        Me.cboBrand.Name = "cboBrand"
        Me.cboBrand.Size = New System.Drawing.Size(178, 21)
        Me.cboBrand.TabIndex = 37
        '
        'cboYear
        '
        Me.cboYear.FormattingEnabled = True
        Me.cboYear.Items.AddRange(New Object() {"2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019"})
        Me.cboYear.Location = New System.Drawing.Point(535, 77)
        Me.cboYear.Name = "cboYear"
        Me.cboYear.Size = New System.Drawing.Size(178, 21)
        Me.cboYear.TabIndex = 36
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radPlain)
        Me.GroupBox3.Controls.Add(Me.radAoto)
        Me.GroupBox3.Location = New System.Drawing.Point(30, 128)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(307, 52)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ระบบเกียร์"
        '
        'radPlain
        '
        Me.radPlain.AutoSize = True
        Me.radPlain.Location = New System.Drawing.Point(153, 24)
        Me.radPlain.Name = "radPlain"
        Me.radPlain.Size = New System.Drawing.Size(87, 17)
        Me.radPlain.TabIndex = 3
        Me.radPlain.TabStop = True
        Me.radPlain.Text = "เกียร์ธรรมดา"
        Me.radPlain.UseVisualStyleBackColor = True
        '
        'radAoto
        '
        Me.radAoto.AutoSize = True
        Me.radAoto.Location = New System.Drawing.Point(16, 24)
        Me.radAoto.Name = "radAoto"
        Me.radAoto.Size = New System.Drawing.Size(90, 17)
        Me.radAoto.TabIndex = 4
        Me.radAoto.TabStop = True
        Me.radAoto.Text = "เกียร์อัตโนมัติ"
        Me.radAoto.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AllowDrop = True
        Me.Label7.AutoEllipsis = True
        Me.Label7.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 18)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "ชื่อรุ่น"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AllowDrop = True
        Me.Label5.AutoEllipsis = True
        Me.Label5.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(413, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "ชื่อยี่ห้อ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.AutoEllipsis = True
        Me.Label4.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(403, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 18)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "ชื่อประเภท"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AllowDrop = True
        Me.Label10.AutoEllipsis = True
        Me.Label10.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(472, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 18)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "บันทึก"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(535, 207)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(45, 20)
        Me.btnSave.TabIndex = 27
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.AutoEllipsis = True
        Me.Label3.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "รหัสรุ่น"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(672, 205)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(45, 20)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.AutoEllipsis = True
        Me.Label2.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(416, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "ปีที่ผลิต"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AllowDrop = True
        Me.Label11.AutoEllipsis = True
        Me.Label11.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(598, 207)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 18)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "ยกเลิก"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGId
        '
        Me.txtGId.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtGId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGId.Location = New System.Drawing.Point(131, 35)
        Me.txtGId.Multiline = True
        Me.txtGId.Name = "txtGId"
        Me.txtGId.Size = New System.Drawing.Size(206, 27)
        Me.txtGId.TabIndex = 21
        '
        'txtGName
        '
        Me.txtGName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtGName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGName.Location = New System.Drawing.Point(131, 80)
        Me.txtGName.Multiline = True
        Me.txtGName.Name = "txtGName"
        Me.txtGName.Size = New System.Drawing.Size(206, 27)
        Me.txtGName.TabIndex = 22
        '
        'Label15
        '
        Me.Label15.AllowDrop = True
        Me.Label15.AutoEllipsis = True
        Me.Label15.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(218, 613)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 18)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "เพิ่ม"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AllowDrop = True
        Me.Label14.AutoEllipsis = True
        Me.Label14.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(522, 613)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 18)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "ออก"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AllowDrop = True
        Me.Label13.AutoEllipsis = True
        Me.Label13.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(326, 614)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 18)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "แก้ไข"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AllowDrop = True
        Me.Label12.AutoEllipsis = True
        Me.Label12.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(420, 613)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 18)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "ลบ"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(573, 613)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(45, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(372, 614)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(45, 20)
        Me.btnEdit.TabIndex = 28
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(471, 613)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(45, 20)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnInserte
        '
        Me.btnInserte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInserte.Location = New System.Drawing.Point(273, 614)
        Me.btnInserte.Name = "btnInserte"
        Me.btnInserte.Size = New System.Drawing.Size(45, 20)
        Me.btnInserte.TabIndex = 27
        Me.btnInserte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnInserte.UseVisualStyleBackColor = True
        '
        'InserteGenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 663)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnInserte)
        Me.Controls.Add(Me.gboData)
        Me.Controls.Add(Me.dgvDataGen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InserteGenForm"
        Me.Text = "InserteGenForm"
        CType(Me.dgvDataGen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboData.ResumeLayout(False)
        Me.gboData.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvDataGen As System.Windows.Forms.DataGridView
    Friend WithEvents gboData As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtGId As System.Windows.Forms.TextBox
    Friend WithEvents txtGName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnInserte As System.Windows.Forms.Button
    Friend WithEvents cboSize As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents cboBrand As System.Windows.Forms.ComboBox
    Friend WithEvents cboYear As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radPlain As System.Windows.Forms.RadioButton
    Friend WithEvents radAoto As System.Windows.Forms.RadioButton
End Class
