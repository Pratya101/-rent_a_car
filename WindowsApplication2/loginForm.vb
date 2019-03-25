Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class loginForm
    Dim strConn As String = ConfigurationManager.ConnectionStrings("ProCarSale.My.MySettings.myCon").ConnectionString
    Dim strSql As String
    Dim Conn As New SqlConnection
    Dim mycomm As New SqlCommand
    Dim myDR As SqlDataReader
    Private Sub conDB()
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        Conn.ConnectionString = strConn
        Conn.Open()
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Call conDB()
        strSql = "select * from tbEmployee where empUsername = @username and empPassword=@password "
        mycomm = New SqlCommand(strSql, Conn)
        mycomm.CommandType = CommandType.Text
        mycomm.CommandTimeout = 15
        mycomm.Parameters.AddWithValue("username", txtUsername.Text)
        mycomm.Parameters.AddWithValue("password", txtPassword.Text)
        myDR = mycomm.ExecuteReader
        If myDR.HasRows Then
            myDR.Read()
            empid = myDR.Item("empId")
            username = myDR.Item("empUsername")
            password = myDR.Item("empPassword")
            Name = myDR.Item("empName")
            Status = myDR.Item("empstatus")
            surname = myDR.Item("empSurname")
            MessageBox.Show("ยินดีต้อยรับคุณ " + Name + "  " + surname + " เข้าสู่ระบบ", "เตือน!", MessageBoxButtons.OK)
            empName = "" + Name + Space(2) + surname + ""
            myDR.Close()
            Conn.Close()
            Me.Close()
        Else
            MessageBox.Show("Username หรือ Password ไม่ถูกต้อง กรุณาตรวจสอบใหม่ด้วยค่ะ", "เตือน!", MessageBoxButtons.OK)
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()
            myDR.Close()
            Conn.Close()
            Exit Sub
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class