<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mainProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.subBrand = New System.Windows.Forms.ToolStripMenuItem()
        Me.subType = New System.Windows.Forms.ToolStripMenuItem()
        Me.subGen = New System.Windows.Forms.ToolStripMenuItem()
        Me.subProducts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainEmp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainHire = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainRecive = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightGray
        Me.MenuStrip1.Font = New System.Drawing.Font("PSL-Kittithada", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mainProduct, Me.mainEmp, Me.mainHire, Me.mainRecive, Me.mainCustomers, Me.mainLogout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(948, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mainProduct
        '
        Me.mainProduct.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subBrand, Me.subType, Me.subGen, Me.subProducts})
        Me.mainProduct.Image = CType(resources.GetObject("mainProduct.Image"), System.Drawing.Image)
        Me.mainProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mainProduct.Name = "mainProduct"
        Me.mainProduct.Size = New System.Drawing.Size(105, 25)
        Me.mainProduct.Text = "จัดการสินค้า"
        Me.mainProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'subBrand
        '
        Me.subBrand.Name = "subBrand"
        Me.subBrand.Size = New System.Drawing.Size(155, 26)
        Me.subBrand.Text = "จัดการยี่ห้อ"
        '
        'subType
        '
        Me.subType.Name = "subType"
        Me.subType.Size = New System.Drawing.Size(155, 26)
        Me.subType.Text = "จัดการประเถท"
        '
        'subGen
        '
        Me.subGen.Name = "subGen"
        Me.subGen.Size = New System.Drawing.Size(155, 26)
        Me.subGen.Text = "จัดการรุ่น"
        '
        'subProducts
        '
        Me.subProducts.Name = "subProducts"
        Me.subProducts.Size = New System.Drawing.Size(155, 26)
        Me.subProducts.Text = "จัดการสินค้า"
        '
        'mainEmp
        '
        Me.mainEmp.Image = CType(resources.GetObject("mainEmp.Image"), System.Drawing.Image)
        Me.mainEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mainEmp.Name = "mainEmp"
        Me.mainEmp.Size = New System.Drawing.Size(122, 25)
        Me.mainEmp.Text = "จัดการพนักงาน"
        Me.mainEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mainHire
        '
        Me.mainHire.Image = CType(resources.GetObject("mainHire.Image"), System.Drawing.Image)
        Me.mainHire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mainHire.Name = "mainHire"
        Me.mainHire.Size = New System.Drawing.Size(55, 25)
        Me.mainHire.Text = "เช่า"
        Me.mainHire.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mainRecive
        '
        Me.mainRecive.Image = CType(resources.GetObject("mainRecive.Image"), System.Drawing.Image)
        Me.mainRecive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mainRecive.Name = "mainRecive"
        Me.mainRecive.Size = New System.Drawing.Size(70, 25)
        Me.mainRecive.Text = "รับคืน"
        Me.mainRecive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mainCustomers
        '
        Me.mainCustomers.Image = CType(resources.GetObject("mainCustomers.Image"), System.Drawing.Image)
        Me.mainCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mainCustomers.Name = "mainCustomers"
        Me.mainCustomers.Size = New System.Drawing.Size(137, 25)
        Me.mainCustomers.Text = "จัดการข้อมูลลูกค้า"
        Me.mainCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mainLogout
        '
        Me.mainLogout.Image = CType(resources.GetObject("mainLogout.Image"), System.Drawing.Image)
        Me.mainLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mainLogout.Name = "mainLogout"
        Me.mainLogout.Size = New System.Drawing.Size(112, 25)
        Me.mainLogout.Text = "ออกจากระบบ"
        Me.mainLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(948, 449)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "โปรแกมระบบเช่ารถ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mainProduct As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subBrand As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subType As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subGen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subProducts As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mainEmp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mainHire As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mainRecive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mainLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mainCustomers As System.Windows.Forms.ToolStripMenuItem
End Class
