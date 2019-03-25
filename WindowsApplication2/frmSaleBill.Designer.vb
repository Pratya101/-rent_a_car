<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaleBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaleBill))
        Me.crvSaveBill = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvSaveBill
        '
        Me.crvSaveBill.ActiveViewIndex = -1
        Me.crvSaveBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvSaveBill.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvSaveBill.DisplayBackgroundEdge = False
        Me.crvSaveBill.Location = New System.Drawing.Point(278, 0)
        Me.crvSaveBill.Name = "crvSaveBill"
        Me.crvSaveBill.ShowGroupTreeButton = False
        Me.crvSaveBill.ShowLogo = False
        Me.crvSaveBill.ShowPageNavigateButtons = False
        Me.crvSaveBill.ShowParameterPanelButton = False
        Me.crvSaveBill.Size = New System.Drawing.Size(803, 750)
        Me.crvSaveBill.TabIndex = 0
        Me.crvSaveBill.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmSaleBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.crvSaveBill)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(800, 800)
        Me.Name = "frmSaleBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ใบเสร็จ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvSaveBill As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
