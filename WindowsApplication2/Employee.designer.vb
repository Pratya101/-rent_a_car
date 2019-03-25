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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnInserte = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
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
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(348, 18)
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
        Me.dgvDataEmloyee.Location = New System.Drawing.Point(37, 84)
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
        Me.dgvDataEmloyee.Size = New System.Drawing.Size(590, 487)
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
        Me.gboData.Controls.Add(Me.Label5)
        Me.gboData.Controls.Add(Me.Label4)
        Me.gboData.Controls.Add(Me.Label3)
        Me.gboData.Controls.Add(Me.Label2)
        Me.gboData.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboData.Location = New System.Drawing.Point(639, 83)
        Me.gboData.Name = "gboData"
        Me.gboData.Size = New System.Drawing.Size(420, 486)
        Me.gboData.TabIndex = 2
        Me.gboData.TabStop = False
        Me.gboData.Text = "ข้อมูล"
        '
        'txtEId
        '
        Me.txtEId.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtEId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(172, 446)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 33)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(289, 447)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(81, 33)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "ยกเลิก"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.txtEAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.txtEPrass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEPrass.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEPrass.Location = New System.Drawing.Point(169, 411)
        Me.txtEPrass.Multiline = True
        Me.txtEPrass.Name = "txtEPrass"
        Me.txtEPrass.Size = New System.Drawing.Size(206, 27)
        Me.txtEPrass.TabIndex = 9
        '
        'txtEUser
        '
        Me.txtEUser.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtEUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.txtENumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.txtETel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.txtELname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.txtEName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.btnInserte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInserte.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInserte.Image = CType(resources.GetObject("btnInserte.Image"), System.Drawing.Image)
        Me.btnInserte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInserte.Location = New System.Drawing.Point(652, 604)
        Me.btnInserte.Name = "btnInserte"
        Me.btnInserte.Size = New System.Drawing.Size(81, 33)
        Me.btnInserte.TabIndex = 12
        Me.btnInserte.Text = "เพิ่ม"
        Me.btnInserte.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInserte.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(863, 602)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(81, 33)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(764, 603)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(81, 33)
        Me.btnEdit.TabIndex = 20
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(965, 602)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(81, 33)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "ออก"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 655)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnInserte)
        Me.Controls.Add(Me.gboData)
        Me.Controls.Add(Me.dgvDataEmloyee)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnInserte As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtEId As System.Windows.Forms.TextBox
End Class
