Public Class mainForm
    Private Sub mainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim loginForm As loginForm = New loginForm
        empid = ""
        MenuStrip1.Visible = False
        loginForm.ShowDialog()
        If empid = "" Then
            End
        Else
            MenuStrip1.Visible = True
            Select Case Status
                Case "admin"
                    mainProduct.Enabled = True
                    mainEmp.Enabled = True
                    mainHire.Enabled = True
                    mainRecive.Enabled = True
                    mainCustomers.Enabled = True
                Case "employee"
                    mainProduct.Enabled = True
                    mainEmp.Enabled = False
                    mainHire.Enabled = True
                    mainRecive.Enabled = True
                    mainCustomers.Enabled = True
            End Select

        End If
    End Sub
    Private Sub จดการยหอToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles subBrand.Click
        Dim InserteBrandForm As New InserteBrandForm
        InserteBrandForm.ShowDialog()
    End Sub

    Private Sub จดการประเถทToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles subType.Click
        Dim InserteTypeForm As New InserteTypeForm
        InserteTypeForm.ShowDialog()
    End Sub

    Private Sub จดการรนToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles subGen.Click
        Dim gen As New InserteGenForm
        gen.ShowDialog()
    End Sub

    Private Sub จดการสนคาToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles subProducts.Click
        Dim InserteCar As New InserteCar
        InserteCar.ShowDialog()
    End Sub

    Private Sub AddEmp_Click(sender As System.Object, e As System.EventArgs) Handles mainEmp.Click
        Dim EmployeeForm As New EmployeeForm
        EmployeeForm.ShowDialog()
    End Sub

    Private Sub mainLogout_Click(sender As System.Object, e As System.EventArgs) Handles mainLogout.Click
        empid = ""
        Status = ""
        Call mainForm_Load(sender, e)
    End Sub

    Private Sub mainHire_Click(sender As System.Object, e As System.EventArgs) Handles mainHire.Click
        Dim hiewForm As New HireForm
        hiewForm.ShowDialog()
    End Sub

    Private Sub mainCustomers_Click(sender As System.Object, e As System.EventArgs) Handles mainCustomers.Click
        CusStatatus = 1
        Dim frmMyAddCus As New Customers
        frmMyAddCus.ShowDialog()
    End Sub

    Private Sub mainRecive_Click(sender As System.Object, e As System.EventArgs) Handles mainRecive.Click
        Dim frmMyRecive As New ReciveForm
        frmMyRecive.ShowDialog()
    End Sub
End Class