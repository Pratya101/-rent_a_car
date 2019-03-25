<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReciveForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReciveForm))
        Me.lblBill = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblReCusName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblReDateHire = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblReAmountDay = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblReCr_id = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblReDateRecive = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblReTotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.หมายเหตุ = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblReEmpName = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBill
        '
        Me.lblBill.AllowDrop = True
        Me.lblBill.AutoEllipsis = True
        Me.lblBill.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBill.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBill.Location = New System.Drawing.Point(171, 117)
        Me.lblBill.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBill.Name = "lblBill"
        Me.lblBill.Size = New System.Drawing.Size(239, 30)
        Me.lblBill.TabIndex = 44
        Me.lblBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.AutoEllipsis = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(30, 117)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 30)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "หมายเลขใบเสร็จ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReCusName
        '
        Me.lblReCusName.AllowDrop = True
        Me.lblReCusName.AutoEllipsis = True
        Me.lblReCusName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblReCusName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReCusName.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReCusName.Location = New System.Drawing.Point(171, 177)
        Me.lblReCusName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReCusName.Name = "lblReCusName"
        Me.lblReCusName.Size = New System.Drawing.Size(239, 30)
        Me.lblReCusName.TabIndex = 46
        Me.lblReCusName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.AutoEllipsis = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(30, 177)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 30)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "ชื่อลูกค้า"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReDateHire
        '
        Me.lblReDateHire.AllowDrop = True
        Me.lblReDateHire.AutoEllipsis = True
        Me.lblReDateHire.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblReDateHire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReDateHire.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReDateHire.Location = New System.Drawing.Point(171, 239)
        Me.lblReDateHire.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReDateHire.Name = "lblReDateHire"
        Me.lblReDateHire.Size = New System.Drawing.Size(239, 30)
        Me.lblReDateHire.TabIndex = 48
        Me.lblReDateHire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AllowDrop = True
        Me.Label5.AutoEllipsis = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(30, 239)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 30)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "วันที่เช่า"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReAmountDay
        '
        Me.lblReAmountDay.AllowDrop = True
        Me.lblReAmountDay.AutoEllipsis = True
        Me.lblReAmountDay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblReAmountDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReAmountDay.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReAmountDay.Location = New System.Drawing.Point(171, 293)
        Me.lblReAmountDay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReAmountDay.Name = "lblReAmountDay"
        Me.lblReAmountDay.Size = New System.Drawing.Size(239, 30)
        Me.lblReAmountDay.TabIndex = 50
        Me.lblReAmountDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AllowDrop = True
        Me.Label7.AutoEllipsis = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(30, 293)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 30)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "จำนวนวัน"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReCr_id
        '
        Me.lblReCr_id.AllowDrop = True
        Me.lblReCr_id.AutoEllipsis = True
        Me.lblReCr_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblReCr_id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReCr_id.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReCr_id.Location = New System.Drawing.Point(171, 357)
        Me.lblReCr_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReCr_id.Name = "lblReCr_id"
        Me.lblReCr_id.Size = New System.Drawing.Size(239, 30)
        Me.lblReCr_id.TabIndex = 52
        Me.lblReCr_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AllowDrop = True
        Me.Label9.AutoEllipsis = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(30, 357)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 30)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "หมายเลขทะเบียนรถ"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFind
        '
        Me.txtFind.Font = New System.Drawing.Font("PSL-Kittithada", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFind.Location = New System.Drawing.Point(437, 37)
        Me.txtFind.Multiline = True
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(239, 30)
        Me.txtFind.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoEllipsis = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(300, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 30)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "หมายเลขทะเบียนรถ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(693, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 30)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "ค้นหา"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblReDateRecive
        '
        Me.lblReDateRecive.AllowDrop = True
        Me.lblReDateRecive.AutoEllipsis = True
        Me.lblReDateRecive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblReDateRecive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReDateRecive.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReDateRecive.Location = New System.Drawing.Point(584, 117)
        Me.lblReDateRecive.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReDateRecive.Name = "lblReDateRecive"
        Me.lblReDateRecive.Size = New System.Drawing.Size(239, 30)
        Me.lblReDateRecive.TabIndex = 57
        Me.lblReDateRecive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AllowDrop = True
        Me.Label6.AutoEllipsis = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(434, 117)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 30)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "วันที่คืน"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReTotal
        '
        Me.lblReTotal.AllowDrop = True
        Me.lblReTotal.AutoEllipsis = True
        Me.lblReTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblReTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReTotal.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReTotal.Location = New System.Drawing.Point(584, 177)
        Me.lblReTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReTotal.Name = "lblReTotal"
        Me.lblReTotal.Size = New System.Drawing.Size(239, 30)
        Me.lblReTotal.TabIndex = 59
        Me.lblReTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AllowDrop = True
        Me.Label8.AutoEllipsis = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(434, 177)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 30)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "ราคารวม"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'หมายเหตุ
        '
        Me.หมายเหตุ.AllowDrop = True
        Me.หมายเหตุ.AutoEllipsis = True
        Me.หมายเหตุ.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.หมายเหตุ.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.หมายเหตุ.Image = CType(resources.GetObject("หมายเหตุ.Image"), System.Drawing.Image)
        Me.หมายเหตุ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.หมายเหตุ.Location = New System.Drawing.Point(434, 293)
        Me.หมายเหตุ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.หมายเหตุ.Name = "หมายเหตุ"
        Me.หมายเหตุ.Size = New System.Drawing.Size(138, 30)
        Me.หมายเหตุ.TabIndex = 60
        Me.หมายเหตุ.Text = "หมายเหตุ"
        Me.หมายเหตุ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("PSL-Kittithada", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Location = New System.Drawing.Point(584, 293)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(239, 94)
        Me.txtNote.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnOk.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(260, 430)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(90, 48)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "คืนรถ"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(373, 430)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 48)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "ยกเลิก"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.Font = New System.Drawing.Font("PSL-Kittithada", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(485, 430)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 48)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "ออก"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblReEmpName
        '
        Me.lblReEmpName.AllowDrop = True
        Me.lblReEmpName.AutoEllipsis = True
        Me.lblReEmpName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblReEmpName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReEmpName.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReEmpName.Location = New System.Drawing.Point(584, 239)
        Me.lblReEmpName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReEmpName.Name = "lblReEmpName"
        Me.lblReEmpName.Size = New System.Drawing.Size(239, 30)
        Me.lblReEmpName.TabIndex = 66
        Me.lblReEmpName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AllowDrop = True
        Me.Label10.AutoEllipsis = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label10.Location = New System.Drawing.Point(434, 239)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 30)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "ชื่อพนักงานออกบิล"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ReciveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 490)
        Me.Controls.Add(Me.lblReEmpName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.หมายเหตุ)
        Me.Controls.Add(Me.lblReTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblReDateRecive)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.lblReCr_id)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblReAmountDay)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblReDateHire)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblReCusName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblBill)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReciveForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "จัดการข้อมูลการคืนรถยนต์"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBill As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblReCusName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblReDateHire As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblReAmountDay As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblReCr_id As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblReDateRecive As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblReTotal As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents หมายเหตุ As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblReEmpName As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
