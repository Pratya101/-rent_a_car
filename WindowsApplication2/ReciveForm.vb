Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class ReciveForm
    Dim strConn As String = ConfigurationManager.ConnectionStrings("ProCarSale.My.MySettings.myCon").ConnectionString
    Dim strSql As String
    Dim Conn As New SqlConnection
    Dim mycomm As New SqlCommand
    Dim DR As SqlDataReader
    Dim Ds As New DataSet
    Dim Da As SqlDataAdapter
    Dim empName, empLname, cusName, cusLname As String
    Dim lastID, newID As String
    Dim curYear As String


    Private Sub ReciveForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnOk.Enabled = False
        btnCancel.Enabled = False
        btnClose.Enabled = True
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        Try
            Conn.ConnectionString = strConn
            Conn.Open()
        Catch
            MessageBox.Show("ไม่สามารถติดต่อฐานข้อมูลได้ กรุณาติดต่อผู้ดูแลระบบ", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Exit Sub
        End Try

        txtNote.Clear()
        txtFind.Clear()
        lblReCusName.Text = ""
        lblReDateHire.Text = ""
        lblReDateRecive.Text = ""
        lblReEmpName.Text = ""
        lblReCr_id.Text = ""
        lblReAmountDay.Text = ""
        lblReTotal.Text = ""
        lblBill.Text = ""
    End Sub

    Private Sub txtFind_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFind.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call findData()
        End If
    End Sub
    Private Sub findData()
        Dim fName, Lname As String
        Dim Cname, Clname As String
        strSql = "SELECT * FROM dbo.tbHireDetail INNER JOIN dbo.tbHire ON dbo.tbHireDetail.H_Id = dbo.tbHire.H_Id INNER JOIN dbo.tbCustomers ON dbo.tbCustomers.Cus_Id = dbo.tbHire.Cus_Id INNER JOIN dbo.tbEmployee ON dbo.tbHire.empId = dbo.tbEmployee.empId WHERE tbHireDetail.HD_Status=1 AND tbHireDetail.Cr_Id='" & txtFind.Text & "'"
        mycomm = New SqlCommand(strSql, Conn)
        DR = mycomm.ExecuteReader()
        If DR.HasRows Then
            DR.Read()
            lblReCr_id.Text = DR("Cr_id")
            Cname = DR("Cus_name")
            cusName = Cname
            Clname = DR("Cus_Lname")
            cusLname = Clname
            lblReCusName.Text = Cname + Space(2) + Clname
            lblReDateHire.Text = DR("H_Date")
            lblReDateRecive.Text = FormatDateTime(Date.Now, DateFormat.ShortDate)
            fName = DR("empName")
            empName = fName
            Lname = DR("empSurname")
            empLname = Lname
            lblReEmpName.Text = fName + Space(2) + Lname
            lblReAmountDay.Text = DR("HD_Date")
            lblReTotal.Text = DR("HD_Price")
            lblBill.Text = DR("H_Id")
            txtFind.Clear()
            btnOk.Enabled = True
            btnCancel.Enabled = True
            btnClose.Enabled = True
        Else
            MessageBox.Show("หมายเลขทะเบียนรถคันนี้ไม่ได้มีการถูกเช่า", "เตือน!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btnOk.Enabled = False
            btnCancel.Enabled = False
            btnClose.Enabled = True
            txtNote.Clear()
            txtFind.Clear()
            lblReCusName.Text = ""
            lblReDateHire.Text = ""
            lblReDateRecive.Text = ""
            lblReEmpName.Text = ""
            lblReCr_id.Text = ""
            lblReAmountDay.Text = ""
            lblReTotal.Text = ""
            lblBill.Text = ""
        End If
        DR.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call findData()
        btnOk.Enabled = True
        btnCancel.Enabled = True
        btnClose.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click

        Dim status As Integer = 1
        Dim status2 As Integer = 2
        Dim Cus_id, Emp_Id As String
        strSql = "select empId from tbEmployee where empName = @empname and empSurname = @empLname  "
        mycomm = New SqlCommand(strSql, Conn)
        mycomm.CommandType = CommandType.Text
        mycomm.CommandTimeout = 15
        mycomm.Parameters.AddWithValue("empName", empName)
        mycomm.Parameters.AddWithValue("empLname", empLname)
        DR = mycomm.ExecuteReader
        DR.Read()
        Emp_Id = DR.Item("empId")
        DR.Close()


        strSql = "select Cus_Id from tbCustomers where Cus_name = @cusName  and Cus_Lname = @cusLname"
        mycomm = New SqlCommand(strSql, Conn)
        mycomm.CommandType = CommandType.Text
        mycomm.CommandTimeout = 15
        mycomm.Parameters.AddWithValue("cusName", cusName)
        mycomm.Parameters.AddWithValue("cusLname", cusLname)
        DR = mycomm.ExecuteReader
        DR.Read()
        Cus_id = DR.Item("Cus_Id")
        DR.Close()

        Dim time As DateTime = DateTime.Now

        strSql = "Insert into tbReturn(Cr_Id, ReNote, Cus_id, H_Id, empId,ReDate) " & _
            " Values(@Cr_Id, @ReNote, @Cus_id, @H_Id, @empId, @ReDate)  "
        mycomm = New SqlCommand(strSql, Conn)
        mycomm.CommandType = CommandType.Text
        mycomm.CommandTimeout = 15
        mycomm.Parameters.AddWithValue("@Cr_Id", lblReCr_id.Text)
        mycomm.Parameters.AddWithValue("@ReNote", txtNote.Text)
        mycomm.Parameters.AddWithValue("@Cus_id", Cus_id)
        mycomm.Parameters.AddWithValue("@H_Id", lblBill.Text)
        mycomm.Parameters.AddWithValue("@empId", Emp_Id)
        mycomm.Parameters.AddWithValue("@ReDate", time.ToString("G"))
        mycomm.ExecuteNonQuery()


        strSql = "Update tbHireDetail Set HD_Status = @status where Cr_Id = @Cr_Id and H_Id=@H_Id "
        mycomm = New SqlCommand(strSql, Conn)
        mycomm.CommandType = CommandType.Text
        mycomm.CommandTimeout = 15
        mycomm.Parameters.AddWithValue("@H_Id", lblBill.Text)
        mycomm.Parameters.AddWithValue("@Cr_Id", lblReCr_id.Text)
        mycomm.Parameters.AddWithValue("@status", status2)
        mycomm.ExecuteNonQuery()

        strSql = "Update tbCars Set Cr_Amount = @status where Cr_Id = @Cr_Id"
        mycomm = New SqlCommand(strSql, Conn)
        mycomm.CommandType = CommandType.Text
        mycomm.CommandTimeout = 15
        mycomm.Parameters.AddWithValue("@Cr_Id", lblReCr_id.Text)
        mycomm.Parameters.AddWithValue("@status", status)
        mycomm.ExecuteNonQuery()
        MessageBox.Show("รับคือรถเรียบร้อยเเล้ว", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        btnOk.Enabled = False
        btnCancel.Enabled = False
        btnClose.Enabled = True
        Call Button3_Click(sender, e)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        txtNote.Clear()
        txtFind.Clear()
        lblReCusName.Text = ""
        lblReDateHire.Text = ""
        lblReDateRecive.Text = ""
        lblReEmpName.Text = ""
        lblReCr_id.Text = ""
        lblReAmountDay.Text = ""
        lblReTotal.Text = ""
        lblBill.Text = ""
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class