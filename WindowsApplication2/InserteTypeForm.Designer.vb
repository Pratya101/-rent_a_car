<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InserteTypeForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDataType = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnInserte = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTId = New System.Windows.Forms.TextBox()
        Me.txtTName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gboData = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgvDataType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboData.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("PSL-Kittithada", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(274, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "จัดการข้อมูลประเภทรถยนต์"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDataType
        '
        Me.dgvDataType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDataType.Location = New System.Drawing.Point(12, 75)
        Me.dgvDataType.Name = "dgvDataType"
        Me.dgvDataType.Size = New System.Drawing.Size(786, 239)
        Me.dgvDataType.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AllowDrop = True
        Me.Label15.AutoEllipsis = True
        Me.Label15.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(195, 498)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 18)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "เพิ่ม"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AllowDrop = True
        Me.Label14.AutoEllipsis = True
        Me.Label14.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(506, 498)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 18)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "ออก"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AllowDrop = True
        Me.Label13.AutoEllipsis = True
        Me.Label13.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(307, 498)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 18)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "แก้ไข"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AllowDrop = True
        Me.Label12.AutoEllipsis = True
        Me.Label12.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(407, 498)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 18)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "ลบ"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(557, 498)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(45, 20)
        Me.btnClose.TabIndex = 15
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(452, 496)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(45, 20)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(356, 496)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(45, 20)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnInserte
        '
        Me.btnInserte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInserte.Location = New System.Drawing.Point(247, 498)
        Me.btnInserte.Name = "btnInserte"
        Me.btnInserte.Size = New System.Drawing.Size(45, 20)
        Me.btnInserte.TabIndex = 13
        Me.btnInserte.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnInserte.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.AutoEllipsis = True
        Me.Label3.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "รหัสประเภท"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTId
        '
        Me.txtTId.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTId.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTId.Location = New System.Drawing.Point(197, 26)
        Me.txtTId.Multiline = True
        Me.txtTId.Name = "txtTId"
        Me.txtTId.Size = New System.Drawing.Size(206, 27)
        Me.txtTId.TabIndex = 21
        '
        'txtTName
        '
        Me.txtTName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtTName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTName.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTName.Location = New System.Drawing.Point(197, 71)
        Me.txtTName.Multiline = True
        Me.txtTName.Name = "txtTName"
        Me.txtTName.Size = New System.Drawing.Size(206, 27)
        Me.txtTName.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.AutoEllipsis = True
        Me.Label2.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "ชื่อประเภท"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gboData
        '
        Me.gboData.Controls.Add(Me.Label10)
        Me.gboData.Controls.Add(Me.btnSave)
        Me.gboData.Controls.Add(Me.Label3)
        Me.gboData.Controls.Add(Me.btnCancel)
        Me.gboData.Controls.Add(Me.Label2)
        Me.gboData.Controls.Add(Me.Label11)
        Me.gboData.Controls.Add(Me.txtTId)
        Me.gboData.Controls.Add(Me.txtTName)
        Me.gboData.Location = New System.Drawing.Point(12, 331)
        Me.gboData.Name = "gboData"
        Me.gboData.Size = New System.Drawing.Size(786, 121)
        Me.gboData.TabIndex = 24
        Me.gboData.TabStop = False
        Me.gboData.Text = "ข้อมูล"
        '
        'Label10
        '
        Me.Label10.AllowDrop = True
        Me.Label10.AutoEllipsis = True
        Me.Label10.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(521, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 18)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "บันทึก"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(584, 84)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(45, 20)
        Me.btnSave.TabIndex = 27
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(709, 84)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(45, 20)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AllowDrop = True
        Me.Label11.AutoEllipsis = True
        Me.Label11.Font = New System.Drawing.Font("PSL-Kittithada", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(635, 86)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 18)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "ยกเลิก"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InserteTypeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 530)
        Me.Controls.Add(Me.gboData)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnInserte)
        Me.Controls.Add(Me.dgvDataType)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InserteTypeForm"
        Me.Text = "InserteTypeForm"
        CType(Me.dgvDataType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboData.ResumeLayout(False)
        Me.gboData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvDataType As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnInserte As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTId As System.Windows.Forms.TextBox
    Friend WithEvents txtTName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gboData As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
