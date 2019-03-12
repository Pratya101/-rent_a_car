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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.จดการรถToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.จดการยหอToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.จดการประเถทToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.จดการรนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.จดการสนคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEmp = New System.Windows.Forms.ToolStripMenuItem()
        Me.เชาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รบคนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.จดการรถToolStripMenuItem, Me.AddEmp, Me.เชาToolStripMenuItem, Me.รบคนToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(607, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'จดการรถToolStripMenuItem
        '
        Me.จดการรถToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.จดการยหอToolStripMenuItem, Me.จดการประเถทToolStripMenuItem, Me.จดการรนToolStripMenuItem, Me.จดการสนคาToolStripMenuItem})
        Me.จดการรถToolStripMenuItem.Name = "จดการรถToolStripMenuItem"
        Me.จดการรถToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.จดการรถToolStripMenuItem.Text = "จัดการสินค้า"
        '
        'จดการยหอToolStripMenuItem
        '
        Me.จดการยหอToolStripMenuItem.Name = "จดการยหอToolStripMenuItem"
        Me.จดการยหอToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.จดการยหอToolStripMenuItem.Text = "จัดการยี่ห้อ"
        '
        'จดการประเถทToolStripMenuItem
        '
        Me.จดการประเถทToolStripMenuItem.Name = "จดการประเถทToolStripMenuItem"
        Me.จดการประเถทToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.จดการประเถทToolStripMenuItem.Text = "จัดการประเถท"
        '
        'จดการรนToolStripMenuItem
        '
        Me.จดการรนToolStripMenuItem.Name = "จดการรนToolStripMenuItem"
        Me.จดการรนToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.จดการรนToolStripMenuItem.Text = "จัดการรุ่น"
        '
        'จดการสนคาToolStripMenuItem
        '
        Me.จดการสนคาToolStripMenuItem.Name = "จดการสนคาToolStripMenuItem"
        Me.จดการสนคาToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.จดการสนคาToolStripMenuItem.Text = "จัดการสินค้่า"
        '
        'AddEmp
        '
        Me.AddEmp.Name = "AddEmp"
        Me.AddEmp.Size = New System.Drawing.Size(88, 20)
        Me.AddEmp.Text = "จัดการพนักงาน"
        '
        'เชาToolStripMenuItem
        '
        Me.เชาToolStripMenuItem.Name = "เชาToolStripMenuItem"
        Me.เชาToolStripMenuItem.Size = New System.Drawing.Size(34, 20)
        Me.เชาToolStripMenuItem.Text = "เช่า"
        '
        'รบคนToolStripMenuItem
        '
        Me.รบคนToolStripMenuItem.Name = "รบคนToolStripMenuItem"
        Me.รบคนToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.รบคนToolStripMenuItem.Text = "รับคืน"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents จดการรถToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents จดการยหอToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents จดการประเถทToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents จดการรนToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents จดการสนคาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEmp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents เชาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents รบคนToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
