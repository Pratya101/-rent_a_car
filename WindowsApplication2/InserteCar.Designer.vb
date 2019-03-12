<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InserteCar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InserteCar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDataCar = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.gpbData = New System.Windows.Forms.GroupBox()
        Me.cboGen = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCColor = New System.Windows.Forms.TextBox()
        Me.txtCNumber = New System.Windows.Forms.TextBox()
        Me.txtCPrice = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCId = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnInserte = New System.Windows.Forms.Button()
        CType(Me.dgvDataCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbData.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(299, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "จัดการข้อมูลรถยนต์"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDataCar
        '
        Me.dgvDataCar.AllowUserToAddRows = False
        Me.dgvDataCar.AllowUserToDeleteRows = False
        Me.dgvDataCar.AllowUserToResizeColumns = False
        Me.dgvDataCar.AllowUserToResizeRows = False
        Me.dgvDataCar.BackgroundColor = System.Drawing.Color.Cyan
        Me.dgvDataCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataCar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDataCar.Location = New System.Drawing.Point(7, 57)
        Me.dgvDataCar.Name = "dgvDataCar"
        Me.dgvDataCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDataCar.Size = New System.Drawing.Size(829, 247)
        Me.dgvDataCar.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AllowDrop = True
        Me.Label15.AutoEllipsis = True
        Me.Label15.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(206, 620)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 18)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "เพิ่ม"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AllowDrop = True
        Me.Label14.AutoEllipsis = True
        Me.Label14.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(517, 620)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 18)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "ออก"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AllowDrop = True
        Me.Label13.AutoEllipsis = True
        Me.Label13.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(316, 622)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 18)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "แก้ไข"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AllowDrop = True
        Me.Label12.AutoEllipsis = True
        Me.Label12.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(418, 621)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 18)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "ลบ"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(568, 620)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(45, 20)
        Me.btnClose.TabIndex = 22
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(466, 620)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(45, 20)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Location = New System.Drawing.Point(367, 604)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(45, 47)
        Me.btnEdit.TabIndex = 20
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'gpbData
        '
        Me.gpbData.BackColor = System.Drawing.Color.Transparent
        Me.gpbData.Controls.Add(Me.cboGen)
        Me.gpbData.Controls.Add(Me.btnSave)
        Me.gpbData.Controls.Add(Me.btnCancel)
        Me.gpbData.Controls.Add(Me.Label16)
        Me.gpbData.Controls.Add(Me.Label17)
        Me.gpbData.Controls.Add(Me.txtCColor)
        Me.gpbData.Controls.Add(Me.txtCNumber)
        Me.gpbData.Controls.Add(Me.txtCPrice)
        Me.gpbData.Controls.Add(Me.Label19)
        Me.gpbData.Controls.Add(Me.Label20)
        Me.gpbData.Controls.Add(Me.Label21)
        Me.gpbData.Controls.Add(Me.Label22)
        Me.gpbData.Controls.Add(Me.txtCId)
        Me.gpbData.Controls.Add(Me.Label23)
        Me.gpbData.Location = New System.Drawing.Point(7, 332)
        Me.gpbData.Name = "gpbData"
        Me.gpbData.Size = New System.Drawing.Size(829, 243)
        Me.gpbData.TabIndex = 27
        Me.gpbData.TabStop = False
        Me.gpbData.Text = "ข้อมูล"
        '
        'cboGen
        '
        Me.cboGen.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGen.FormattingEnabled = True
        Me.cboGen.Location = New System.Drawing.Point(552, 114)
        Me.cboGen.Name = "cboGen"
        Me.cboGen.Size = New System.Drawing.Size(206, 29)
        Me.cboGen.TabIndex = 53
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(578, 212)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(45, 20)
        Me.btnSave.TabIndex = 50
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(712, 212)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(45, 20)
        Me.btnCancel.TabIndex = 49
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AllowDrop = True
        Me.Label16.AutoEllipsis = True
        Me.Label16.BackColor = System.Drawing.Color.Red
        Me.Label16.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(641, 212)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 18)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "ยกเลิก"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AllowDrop = True
        Me.Label17.AutoEllipsis = True
        Me.Label17.BackColor = System.Drawing.Color.Lime
        Me.Label17.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(510, 212)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 18)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "บันทึก"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCColor
        '
        Me.txtCColor.BackColor = System.Drawing.Color.White
        Me.txtCColor.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCColor.Location = New System.Drawing.Point(171, 184)
        Me.txtCColor.Multiline = True
        Me.txtCColor.Name = "txtCColor"
        Me.txtCColor.Size = New System.Drawing.Size(206, 27)
        Me.txtCColor.TabIndex = 44
        '
        'txtCNumber
        '
        Me.txtCNumber.BackColor = System.Drawing.Color.White
        Me.txtCNumber.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCNumber.Location = New System.Drawing.Point(171, 108)
        Me.txtCNumber.Multiline = True
        Me.txtCNumber.Name = "txtCNumber"
        Me.txtCNumber.Size = New System.Drawing.Size(206, 27)
        Me.txtCNumber.TabIndex = 43
        '
        'txtCPrice
        '
        Me.txtCPrice.BackColor = System.Drawing.Color.White
        Me.txtCPrice.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPrice.Location = New System.Drawing.Point(552, 53)
        Me.txtCPrice.Multiline = True
        Me.txtCPrice.Name = "txtCPrice"
        Me.txtCPrice.Size = New System.Drawing.Size(206, 27)
        Me.txtCPrice.TabIndex = 42
        '
        'Label19
        '
        Me.Label19.AutoEllipsis = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(92, 188)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 23)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "สีรถ"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoEllipsis = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(88, 112)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 23)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "เลขตัวถัง"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AutoEllipsis = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(473, 57)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 23)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "ราคาเช่า"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoEllipsis = True
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label22.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(473, 112)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 23)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "รหัสรุ่น"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCId
        '
        Me.txtCId.BackColor = System.Drawing.Color.White
        Me.txtCId.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCId.Location = New System.Drawing.Point(171, 29)
        Me.txtCId.Multiline = True
        Me.txtCId.Name = "txtCId"
        Me.txtCId.Size = New System.Drawing.Size(206, 27)
        Me.txtCId.TabIndex = 36
        '
        'Label23
        '
        Me.Label23.AutoEllipsis = True
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label23.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(86, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(60, 23)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "ทะเบียนรถ"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnInserte
        '
        Me.btnInserte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInserte.BackgroundImage = CType(resources.GetObject("btnInserte.BackgroundImage"), System.Drawing.Image)
        Me.btnInserte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInserte.Location = New System.Drawing.Point(258, 604)
        Me.btnInserte.Name = "btnInserte"
        Me.btnInserte.Size = New System.Drawing.Size(47, 47)
        Me.btnInserte.TabIndex = 20
        Me.btnInserte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnInserte.UseVisualStyleBackColor = True
        '
        'InserteCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(853, 663)
        Me.Controls.Add(Me.gpbData)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnInserte)
        Me.Controls.Add(Me.dgvDataCar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InserteCar"
        Me.Text = "InserteCar"
        CType(Me.dgvDataCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbData.ResumeLayout(False)
        Me.gpbData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvDataCar As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents gpbData As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCColor As System.Windows.Forms.TextBox
    Friend WithEvents txtCNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtCPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtCId As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cboGen As System.Windows.Forms.ComboBox
    Friend WithEvents btnInserte As System.Windows.Forms.Button
End Class
