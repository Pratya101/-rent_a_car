<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDataEmloyee = New System.Windows.Forms.DataGridView()
        Me.gboData = New System.Windows.Forms.GroupBox()
        Me.txtEId = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.radEMen = New System.Windows.Forms.RadioButton()
        Me.radEWomen = New System.Windows.Forms.RadioButton()
        Me.txtEAdd = New System.Windows.Forms.TextBox()
        Me.txtEPrass = New System.Windows.Forms.TextBox()
        Me.txtEUser = New System.Windows.Forms.TextBox()
        Me.txtENumber = New System.Windows.Forms.TextBox()
        Me.txtETel = New System.Windows.Forms.TextBox()
        Me.txtELname = New System.Windows.Forms.TextBox()
        Me.txtEName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInserte = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.dgvDataEmloyee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboData.SuspendLayout()
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
        Me.Label1.Text = "จัดการข้อมูลพนักงาน"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDataEmloyee
        '
        Me.dgvDataEmloyee.AllowUserToAddRows = False
        Me.dgvDataEmloyee.AllowUserToDeleteRows = False
        Me.dgvDataEmloyee.AllowUserToOrderColumns = True
        Me.dgvDataEmloyee.AllowUserToResizeColumns = False
        Me.dgvDataEmloyee.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvDataEmloyee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDataEmloyee.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvDataEmloyee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataEmloyee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDataEmloyee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDataEmloyee.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDataEmloyee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDataEmloyee.GridColor = System.Drawing.SystemColors.MenuHighlight
        Me.dgvDataEmloyee.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvDataEmloyee.Location = New System.Drawing.Point(7, 84)
        Me.dgvDataEmloyee.Name = "dgvDataEmloyee"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataEmloyee.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDataEmloyee.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvDataEmloyee.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDataEmloyee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDataEmloyee.Size = New System.Drawing.Size(408, 487)
        Me.dgvDataEmloyee.TabIndex = 1
        '
        'gboData
        '
        Me.gboData.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gboData.Controls.Add(Me.txtEId)
        Me.gboData.Controls.Add(Me.Label16)
        Me.gboData.Controls.Add(Me.btnSave)
        Me.gboData.Controls.Add(Me.btnCancel)
        Me.gboData.Controls.Add(Me.radEMen)
        Me.gboData.Controls.Add(Me.radEWomen)
        Me.gboData.Controls.Add(Me.txtEAdd)
        Me.gboData.Controls.Add(Me.txtEPrass)
        Me.gboData.Controls.Add(Me.txtEUser)
        Me.gboData.Controls.Add(Me.txtENumber)
        Me.gboData.Controls.Add(Me.txtETel)
        Me.gboData.Controls.Add(Me.txtELname)
        Me.gboData.Controls.Add(Me.txtEName)
        Me.gboData.Controls.Add(Me.Label9)
        Me.gboData.Controls.Add(Me.Label8)
        Me.gboData.Controls.Add(Me.Label7)
        Me.gboData.Controls.Add(Me.Label6)
        Me.gboData.Controls.Add(Me.Label11)
        Me.gboData.Controls.Add(Me.Label10)
        Me.gboData.Controls.Add(Me.Label5)
        Me.gboData.Controls.Add(Me.Label4)
        Me.gboData.Controls.Add(Me.Label3)
        Me.gboData.Controls.Add(Me.Label2)
        Me.gboData.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboData.Location = New System.Drawing.Point(421, 85)
        Me.gboData.Name = "gboData"
        Me.gboData.Size = New System.Drawing.Size(420, 486)
        Me.gboData.TabIndex = 2
        Me.gboData.TabStop = False
        Me.gboData.Text = "ข้อมูล"
        '
        'txtEId
        '
        Me.txtEId.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtEId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEId.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEId.Location = New System.Drawing.Point(169, 24)
        Me.txtEId.Multiline = True
        Me.txtEId.Name = "txtEId"
        Me.txtEId.Size = New System.Drawing.Size(206, 27)
        Me.txtEId.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoEllipsis = True
        Me.Label16.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(34, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 23)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "รหัสพนักงาน"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Location = New System.Drawing.Point(214, 442)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(42, 42)
        Me.btnSave.TabIndex = 10
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = CType(resources.GetObject("btnCancel.BackgroundImage"), System.Drawing.Image)
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Location = New System.Drawing.Point(331, 443)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(42, 42)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'radEMen
        '
        Me.radEMen.AutoSize = True
        Me.radEMen.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEMen.Location = New System.Drawing.Point(170, 149)
        Me.radEMen.Name = "radEMen"
        Me.radEMen.Size = New System.Drawing.Size(50, 25)
        Me.radEMen.TabIndex = 3
        Me.radEMen.TabStop = True
        Me.radEMen.Text = "ชาย"
        Me.radEMen.UseVisualStyleBackColor = True
        '
        'radEWomen
        '
        Me.radEWomen.AutoSize = True
        Me.radEWomen.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEWomen.Location = New System.Drawing.Point(279, 149)
        Me.radEWomen.Name = "radEWomen"
        Me.radEWomen.Size = New System.Drawing.Size(56, 25)
        Me.radEWomen.TabIndex = 4
        Me.radEWomen.TabStop = True
        Me.radEWomen.Text = "หญิง"
        Me.radEWomen.UseVisualStyleBackColor = True
        '
        'txtEAdd
        '
        Me.txtEAdd.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtEAdd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEAdd.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEAdd.Location = New System.Drawing.Point(169, 183)
        Me.txtEAdd.Multiline = True
        Me.txtEAdd.Name = "txtEAdd"
        Me.txtEAdd.Size = New System.Drawing.Size(206, 94)
        Me.txtEAdd.TabIndex = 5
        '
        'txtEPrass
        '
        Me.txtEPrass.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtEPrass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEPrass.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEPrass.Location = New System.Drawing.Point(169, 411)
        Me.txtEPrass.Multiline = True
        Me.txtEPrass.Name = "txtEPrass"
        Me.txtEPrass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEPrass.Size = New System.Drawing.Size(206, 27)
        Me.txtEPrass.TabIndex = 9
        '
        'txtEUser
        '
        Me.txtEUser.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtEUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEUser.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEUser.Location = New System.Drawing.Point(169, 375)
        Me.txtEUser.Multiline = True
        Me.txtEUser.Name = "txtEUser"
        Me.txtEUser.Size = New System.Drawing.Size(206, 27)
        Me.txtEUser.TabIndex = 8
        '
        'txtENumber
        '
        Me.txtENumber.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtENumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtENumber.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtENumber.Location = New System.Drawing.Point(169, 325)
        Me.txtENumber.Multiline = True
        Me.txtENumber.Name = "txtENumber"
        Me.txtENumber.Size = New System.Drawing.Size(206, 27)
        Me.txtENumber.TabIndex = 7
        '
        'txtETel
        '
        Me.txtETel.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtETel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtETel.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtETel.Location = New System.Drawing.Point(169, 283)
        Me.txtETel.Multiline = True
        Me.txtETel.Name = "txtETel"
        Me.txtETel.Size = New System.Drawing.Size(206, 27)
        Me.txtETel.TabIndex = 6
        '
        'txtELname
        '
        Me.txtELname.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtELname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtELname.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtELname.Location = New System.Drawing.Point(169, 110)
        Me.txtELname.Multiline = True
        Me.txtELname.Name = "txtELname"
        Me.txtELname.Size = New System.Drawing.Size(206, 27)
        Me.txtELname.TabIndex = 2
        '
        'txtEName
        '
        Me.txtEName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtEName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEName.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEName.Location = New System.Drawing.Point(169, 69)
        Me.txtEName.Multiline = True
        Me.txtEName.Name = "txtEName"
        Me.txtEName.Size = New System.Drawing.Size(206, 27)
        Me.txtEName.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AllowDrop = True
        Me.Label9.AutoEllipsis = True
        Me.Label9.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(50, 420)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Prassword"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AllowDrop = True
        Me.Label8.AutoEllipsis = True
        Me.Label8.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(76, 384)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "User"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AllowDrop = True
        Me.Label7.AutoEllipsis = True
        Me.Label7.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "เลขที่บัตรประชาชน"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AllowDrop = True
        Me.Label6.AutoEllipsis = True
        Me.Label6.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "เบอร์โทร"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AllowDrop = True
        Me.Label11.AutoEllipsis = True
        Me.Label11.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(276, 457)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 18)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "ยกเลิก"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AllowDrop = True
        Me.Label10.AutoEllipsis = True
        Me.Label10.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(173, 457)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 18)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "บันทึก"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AllowDrop = True
        Me.Label5.AutoEllipsis = True
        Me.Label5.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(84, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ที่อยู่"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.AutoEllipsis = True
        Me.Label4.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เพศ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.AutoEllipsis = True
        Me.Label3.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(69, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "นามสกุล"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อ "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnInserte
        '
        Me.btnInserte.BackgroundImage = CType(resources.GetObject("btnInserte.BackgroundImage"), System.Drawing.Image)
        Me.btnInserte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInserte.Location = New System.Drawing.Point(288, 608)
        Me.btnInserte.Name = "btnInserte"
        Me.btnInserte.Size = New System.Drawing.Size(47, 47)
        Me.btnInserte.TabIndex = 20
        Me.btnInserte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnInserte.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Location = New System.Drawing.Point(499, 605)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(47, 47)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Location = New System.Drawing.Point(400, 607)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(47, 47)
        Me.btnEdit.TabIndex = 20
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = CType(resources.GetObject("btnClose.BackgroundImage"), System.Drawing.Image)
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Location = New System.Drawing.Point(601, 606)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(47, 47)
        Me.btnClose.TabIndex = 20
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AllowDrop = True
        Me.Label12.AutoEllipsis = True
        Me.Label12.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(451, 624)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 18)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "ลบ"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AllowDrop = True
        Me.Label13.AutoEllipsis = True
        Me.Label13.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(349, 623)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 18)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "แก้ไข"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AllowDrop = True
        Me.Label14.AutoEllipsis = True
        Me.Label14.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(550, 624)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 18)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "ออก"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AllowDrop = True
        Me.Label15.AutoEllipsis = True
        Me.Label15.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(239, 622)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 18)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "เพิ่ม"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmployeeForm
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
        Me.Controls.Add(Me.dgvDataEmloyee)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "จัดการข้อมูลพนักงาน"
        CType(Me.dgvDataEmloyee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboData.ResumeLayout(False)
        Me.gboData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvDataEmloyee As System.Windows.Forms.DataGridView
    Friend WithEvents gboData As System.Windows.Forms.GroupBox
    Friend WithEvents txtEAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtEPrass As System.Windows.Forms.TextBox
    Friend WithEvents txtEUser As System.Windows.Forms.TextBox
    Friend WithEvents txtENumber As System.Windows.Forms.TextBox
    Friend WithEvents txtETel As System.Windows.Forms.TextBox
    Friend WithEvents txtELname As System.Windows.Forms.TextBox
    Friend WithEvents txtEName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radEMen As System.Windows.Forms.RadioButton
    Friend WithEvents radEWomen As System.Windows.Forms.RadioButton
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnInserte As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtEId As System.Windows.Forms.TextBox
End Class
