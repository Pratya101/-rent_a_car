Public Class mainForm

    Private Sub mainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim loginForm As loginForm = New loginForm
        loginForm.ShowDialog()

        If Status = "" Then
            End
        Else
            'select case staName
            'Case "พนักงานขาย"

            'case "ผู้จัดการ"

            If Status <> "1" Then
                AddEmp.Visible = True
            ElseIf Status <> "2" Then
                AddEmp.Visible = False
            End If
        End If
    End Sub

    Private Sub จดการรถToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles จดการรถToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub จดการยหอToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles จดการยหอToolStripMenuItem.Click
        InserteBrandForm.ShowDialog()
    End Sub

    Private Sub จดการประเถทToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles จดการประเถทToolStripMenuItem.Click
        InserteTypeForm.ShowDialog()
    End Sub

    Private Sub จดการรนToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles จดการรนToolStripMenuItem.Click
        Dim gen As New InserteGenForm
        gen.ShowDialog()
    End Sub

    Private Sub จดการสนคาToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles จดการสนคาToolStripMenuItem.Click
        InserteCar.ShowDialog()
    End Sub

    Private Sub AddEmp_Click(sender As System.Object, e As System.EventArgs) Handles AddEmp.Click
        EmployeeForm.ShowDialog()
    End Sub
End Class