<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HireForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HireForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDataHire = New System.Windows.Forms.DataGridView()
        Me.Cr_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cr_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cr_Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaleTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNewBill = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gboDataHire = New System.Windows.Forms.GroupBox()
        Me.lblSaleTotal = New System.Windows.Forms.Label()
        Me.lblPriceDay = New System.Windows.Forms.Label()
        Me.lblNameCr = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtAmountDay = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBrows = New System.Windows.Forms.Button()
        Me.txtProId = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnHOld = New System.Windows.Forms.Button()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNameCus = New System.Windows.Forms.Label()
        Me.lblNameEmp = New System.Windows.Forms.Label()
        Me.lblSalDate = New System.Windows.Forms.Label()
        Me.lblSalId = New System.Windows.Forms.Label()
        CType(Me.dgvDataHire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboDataHire.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.AutoEllipsis = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(11, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 30)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "หมายเลขใบเสร็จ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.AutoEllipsis = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(288, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 30)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "วันที่เช่า"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDataHire
        '
        Me.dgvDataHire.AllowUserToAddRows = False
        Me.dgvDataHire.AllowUserToDeleteRows = False
        Me.dgvDataHire.AllowUserToResizeColumns = False
        Me.dgvDataHire.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvDataHire.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDataHire.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDataHire.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDataHire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataHire.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cr_id, Me.Cr_Price, Me.Cr_Amount, Me.AmountDay, Me.SaleTotal})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDataHire.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvDataHire.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDataHire.Location = New System.Drawing.Point(14, 88)
        Me.dgvDataHire.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDataHire.Name = "dgvDataHire"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvDataHire.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDataHire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDataHire.Size = New System.Drawing.Size(810, 243)
        Me.dgvDataHire.TabIndex = 7
        '
        'Cr_id
        '
        Me.Cr_id.HeaderText = "เลขทะเบียน"
        Me.Cr_id.Name = "Cr_id"
        Me.Cr_id.Width = 145
        '
        'Cr_Price
        '
        Me.Cr_Price.HeaderText = "ราคา/วัน"
        Me.Cr_Price.Name = "Cr_Price"
        Me.Cr_Price.Width = 145
        '
        'Cr_Amount
        '
        Me.Cr_Amount.HeaderText = "จำนวนคัน"
        Me.Cr_Amount.Name = "Cr_Amount"
        Me.Cr_Amount.Width = 145
        '
        'AmountDay
        '
        Me.AmountDay.HeaderText = "จำนวนวัน"
        Me.AmountDay.Name = "AmountDay"
        Me.AmountDay.Width = 145
        '
        'SaleTotal
        '
        Me.SaleTotal.HeaderText = "ราคารวม"
        Me.SaleTotal.Name = "SaleTotal"
        Me.SaleTotal.Width = 190
        '
        'btnNewBill
        '
        Me.btnNewBill.BackColor = System.Drawing.Color.Lime
        Me.btnNewBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNewBill.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewBill.Image = CType(resources.GetObject("btnNewBill.Image"), System.Drawing.Image)
        Me.btnNewBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNewBill.Location = New System.Drawing.Point(443, 9)
        Me.btnNewBill.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewBill.Name = "btnNewBill"
        Me.btnNewBill.Size = New System.Drawing.Size(127, 37)
        Me.btnNewBill.TabIndex = 28
        Me.btnNewBill.Text = "เปิดบิลเช่า"
        Me.btnNewBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNewBill.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoEllipsis = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(11, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 30)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "ชื่อพนักงาน"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.AutoEllipsis = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(11, 109)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 30)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "ชื่อลูกค้า"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gboDataHire
        '
        Me.gboDataHire.Controls.Add(Me.lblSaleTotal)
        Me.gboDataHire.Controls.Add(Me.lblPriceDay)
        Me.gboDataHire.Controls.Add(Me.lblNameCr)
        Me.gboDataHire.Controls.Add(Me.txtAmount)
        Me.gboDataHire.Controls.Add(Me.txtAmountDay)
        Me.gboDataHire.Controls.Add(Me.btnAdd)
        Me.gboDataHire.Controls.Add(Me.Label13)
        Me.gboDataHire.Controls.Add(Me.Label12)
        Me.gboDataHire.Controls.Add(Me.Label11)
        Me.gboDataHire.Controls.Add(Me.Label6)
        Me.gboDataHire.Controls.Add(Me.btnBrows)
        Me.gboDataHire.Controls.Add(Me.txtProId)
        Me.gboDataHire.Controls.Add(Me.Label10)
        Me.gboDataHire.Controls.Add(Me.btnDelete)
        Me.gboDataHire.Controls.Add(Me.Label5)
        Me.gboDataHire.Controls.Add(Me.dgvDataHire)
        Me.gboDataHire.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gboDataHire.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboDataHire.Location = New System.Drawing.Point(14, 253)
        Me.gboDataHire.Margin = New System.Windows.Forms.Padding(4)
        Me.gboDataHire.Name = "gboDataHire"
        Me.gboDataHire.Padding = New System.Windows.Forms.Padding(4)
        Me.gboDataHire.Size = New System.Drawing.Size(857, 396)
        Me.gboDataHire.TabIndex = 35
        Me.gboDataHire.TabStop = False
        Me.gboDataHire.Text = "รายการเช่า"
        '
        'lblSaleTotal
        '
        Me.lblSaleTotal.AllowDrop = True
        Me.lblSaleTotal.AutoEllipsis = True
        Me.lblSaleTotal.BackColor = System.Drawing.Color.White
        Me.lblSaleTotal.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaleTotal.Location = New System.Drawing.Point(705, 52)
        Me.lblSaleTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaleTotal.Name = "lblSaleTotal"
        Me.lblSaleTotal.Size = New System.Drawing.Size(86, 27)
        Me.lblSaleTotal.TabIndex = 5
        Me.lblSaleTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPriceDay
        '
        Me.lblPriceDay.AllowDrop = True
        Me.lblPriceDay.AutoEllipsis = True
        Me.lblPriceDay.BackColor = System.Drawing.Color.White
        Me.lblPriceDay.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceDay.Location = New System.Drawing.Point(394, 54)
        Me.lblPriceDay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPriceDay.Name = "lblPriceDay"
        Me.lblPriceDay.Size = New System.Drawing.Size(84, 27)
        Me.lblPriceDay.TabIndex = 2
        Me.lblPriceDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNameCr
        '
        Me.lblNameCr.AllowDrop = True
        Me.lblNameCr.AutoEllipsis = True
        Me.lblNameCr.BackColor = System.Drawing.Color.White
        Me.lblNameCr.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameCr.Location = New System.Drawing.Point(152, 53)
        Me.lblNameCr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNameCr.Name = "lblNameCr"
        Me.lblNameCr.Size = New System.Drawing.Size(235, 27)
        Me.lblNameCr.TabIndex = 1
        Me.lblNameCr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAmount.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(487, 55)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmount.Multiline = True
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(86, 27)
        Me.txtAmount.TabIndex = 3
        '
        'txtAmountDay
        '
        Me.txtAmountDay.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtAmountDay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAmountDay.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountDay.Location = New System.Drawing.Point(581, 53)
        Me.txtAmountDay.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAmountDay.Multiline = True
        Me.txtAmountDay.Name = "txtAmountDay"
        Me.txtAmountDay.Size = New System.Drawing.Size(116, 27)
        Me.txtAmountDay.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(795, 26)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(54, 53)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AllowDrop = True
        Me.Label13.AutoEllipsis = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(705, 26)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 23)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "เป็นเงิน"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AllowDrop = True
        Me.Label12.AutoEllipsis = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(487, 27)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 23)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "จำนวน"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AllowDrop = True
        Me.Label11.AutoEllipsis = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(395, 27)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 23)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "ราคา/วัน"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AllowDrop = True
        Me.Label6.AutoEllipsis = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(581, 25)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 23)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "จำนวนวัน"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBrows
        '
        Me.btnBrows.Location = New System.Drawing.Point(121, 53)
        Me.btnBrows.Name = "btnBrows"
        Me.btnBrows.Size = New System.Drawing.Size(29, 29)
        Me.btnBrows.TabIndex = 46
        Me.btnBrows.Text = "..."
        Me.btnBrows.UseVisualStyleBackColor = True
        '
        'txtProId
        '
        Me.txtProId.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtProId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProId.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProId.Location = New System.Drawing.Point(16, 53)
        Me.txtProId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProId.Multiline = True
        Me.txtProId.Name = "txtProId"
        Me.txtProId.Size = New System.Drawing.Size(106, 28)
        Me.txtProId.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AllowDrop = True
        Me.Label10.AutoEllipsis = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(17, 26)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 23)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "ค้นหาเลขทะเบียน"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(795, 337)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(54, 53)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AllowDrop = True
        Me.Label5.AutoEllipsis = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(152, 26)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(235, 23)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "หมายเลขทะเบียน"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(723, 9)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(127, 37)
        Me.btnCancel.TabIndex = 38
        Me.btnCancel.Text = "ยกเลิก"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(288, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 0)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "คัน"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(573, 9)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(147, 37)
        Me.btnPrint.TabIndex = 42
        Me.btnPrint.Text = "พิมพ์ใบเสร็จรับเงิน"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnHOld
        '
        Me.btnHOld.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHOld.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHOld.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHOld.Image = CType(resources.GetObject("btnHOld.Image"), System.Drawing.Image)
        Me.btnHOld.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHOld.Location = New System.Drawing.Point(424, 99)
        Me.btnHOld.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHOld.Name = "btnHOld"
        Me.btnHOld.Size = New System.Drawing.Size(119, 43)
        Me.btnHOld.TabIndex = 39
        Me.btnHOld.Text = "เลือกลูกค้า"
        Me.btnHOld.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHOld.UseVisualStyleBackColor = False
        '
        'lblSum
        '
        Me.lblSum.AllowDrop = True
        Me.lblSum.AutoEllipsis = True
        Me.lblSum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSum.Font = New System.Drawing.Font("PSL-Kittithada", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSum.Location = New System.Drawing.Point(611, 112)
        Me.lblSum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(239, 106)
        Me.lblSum.TabIndex = 43
        Me.lblSum.Text = "0"
        Me.lblSum.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label9
        '
        Me.Label9.AllowDrop = True
        Me.Label9.AutoEllipsis = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("PSL-Kittithada", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(611, 76)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(239, 36)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "ราคารวม"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblNameCus)
        Me.Panel1.Controls.Add(Me.lblNameEmp)
        Me.Panel1.Controls.Add(Me.lblSalDate)
        Me.Panel1.Controls.Add(Me.lblSalId)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.btnHOld)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(15, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(583, 161)
        Me.Panel1.TabIndex = 45
        '
        'lblNameCus
        '
        Me.lblNameCus.AllowDrop = True
        Me.lblNameCus.AutoEllipsis = True
        Me.lblNameCus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNameCus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNameCus.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameCus.Location = New System.Drawing.Point(143, 109)
        Me.lblNameCus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNameCus.Name = "lblNameCus"
        Me.lblNameCus.Size = New System.Drawing.Size(273, 28)
        Me.lblNameCus.TabIndex = 40
        Me.lblNameCus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNameEmp
        '
        Me.lblNameEmp.AllowDrop = True
        Me.lblNameEmp.AutoEllipsis = True
        Me.lblNameEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNameEmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNameEmp.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNameEmp.Location = New System.Drawing.Point(143, 64)
        Me.lblNameEmp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNameEmp.Name = "lblNameEmp"
        Me.lblNameEmp.Size = New System.Drawing.Size(420, 30)
        Me.lblNameEmp.TabIndex = 44
        Me.lblNameEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSalDate
        '
        Me.lblSalDate.AllowDrop = True
        Me.lblSalDate.AutoEllipsis = True
        Me.lblSalDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSalDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalDate.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalDate.Location = New System.Drawing.Point(406, 19)
        Me.lblSalDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalDate.Name = "lblSalDate"
        Me.lblSalDate.Size = New System.Drawing.Size(157, 30)
        Me.lblSalDate.TabIndex = 43
        Me.lblSalDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSalId
        '
        Me.lblSalId.AllowDrop = True
        Me.lblSalId.AutoEllipsis = True
        Me.lblSalId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSalId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalId.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalId.Location = New System.Drawing.Point(143, 19)
        Me.lblSalId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalId.Name = "lblSalId"
        Me.lblSalId.Size = New System.Drawing.Size(137, 30)
        Me.lblSalId.TabIndex = 42
        Me.lblSalId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HireForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 662)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gboDataHire)
        Me.Controls.Add(Me.btnNewBill)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HireForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "จัดการข้อมูลการเช่า"
        CType(Me.dgvDataHire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboDataHire.ResumeLayout(False)
        Me.gboDataHire.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvDataHire As System.Windows.Forms.DataGridView
    Friend WithEvents btnNewBill As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gboDataHire As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnHOld As System.Windows.Forms.Button
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnBrows As System.Windows.Forms.Button
    Friend WithEvents txtProId As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAmountDay As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblNameCus As System.Windows.Forms.Label
    Friend WithEvents lblNameEmp As System.Windows.Forms.Label
    Friend WithEvents lblSalDate As System.Windows.Forms.Label
    Friend WithEvents lblSalId As System.Windows.Forms.Label
    Friend WithEvents lblPriceDay As System.Windows.Forms.Label
    Friend WithEvents lblNameCr As System.Windows.Forms.Label
    Friend WithEvents lblSaleTotal As System.Windows.Forms.Label
    Friend WithEvents Cr_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cr_Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cr_Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaleTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
