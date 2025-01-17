﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class Customers
    Dim strConn As String = ConfigurationManager.ConnectionStrings("ProCarSale.My.MySettings.myCon").ConnectionString
    Dim strSql As String
    Dim Conn As New SqlConnection
    Dim mycomm As New SqlCommand
    Dim myDR As SqlDataReader
    Dim userAct, chkEId, oldEmpID As String
    Private Sub conDB()
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        Conn.ConnectionString = strConn
        Conn.Open()
    End Sub
    Private Sub LoadData()
        Call conDB()
        strSql = "SELECT Cus_id,Cus_Name,Cus_Lname,Cus_Code,Cus_Tel from tbCusTomers"
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbDataCustomers")
        dgvDataEmloyee.ReadOnly = True
        dgvDataEmloyee.DataSource = ds.Tables("tbDataCustomers")
        dgvDataEmloyee.Columns(0).HeaderCell.Value = "รหัสลูกค้า"
        dgvDataEmloyee.Columns(1).HeaderCell.Value = "ชื่อ"
        dgvDataEmloyee.Columns(2).HeaderCell.Value = "นามสกุล"
        dgvDataEmloyee.Columns(3).HeaderCell.Value = "รหัสบัตรประจำตัวประชาชน"
        dgvDataEmloyee.Columns(4).HeaderCell.Value = "เบอร์โทร"
        dgvDataEmloyee.Columns(0).Width = 100
        dgvDataEmloyee.Columns(1).Width = 100
        dgvDataEmloyee.Columns(2).Width = 100
        dgvDataEmloyee.Columns(3).Width = 190
        dgvDataEmloyee.Columns(4).Width = 100
        Conn.Close()
    End Sub
    Private Sub dgvData_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDataEmloyee.CellEnter
        If dgvDataEmloyee.RowCount = 0 Or dgvDataEmloyee.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Dim r As Integer = dgvDataEmloyee.CurrentCell.RowIndex
        Dim eid As String = dgvDataEmloyee.Item(0, r).Value
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        conDB()
        strSql = "SELECT * from tbCustomers where Cus_Id=@eid"
        mycomm = New SqlCommand(strSql, Conn)
        mycomm.CommandType = CommandType.Text
        mycomm.CommandTimeout = 15
        mycomm.Parameters.AddWithValue("@eid", eid)
        myDR = mycomm.ExecuteReader
        myDR.Read()
        txtEId.Text = myDR.Item("Cus_Id")
        txtEName.Text = myDR.Item("Cus_Name")
        txtELname.Text = myDR.Item("Cus_Lname")
        txtEAdd.Text = myDR.Item("Address")
        txtETel.Text = myDR.Item("Cus_Tel")
        txtENumber.Text = myDR.Item("Cus_Code")
        If myDR.Item("Sex") = "1" Then
            radEMen.Checked = True
        Else
            radEWomen.Checked = True
        End If
        CusCode = myDR.Item("Cus_Code")
        myDR.Close()
    End Sub
    Private Sub EmployeeForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call LoadData()
        If CusStatatus = 1 Then
            btnSelect.Visible = False
        Else
            btnSelect.Visible = True
        End If
        gboData.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
    End Sub

    Private Sub btnInserte_Click(sender As System.Object, e As System.EventArgs) Handles btnInserte.Click
        gboData.Enabled = True
        txtEId.Clear()
        txtEName.Clear()
        txtELname.Clear()
        txtEAdd.Clear()
        txtETel.Clear()
        txtENumber.Clear()
        txtEId.Focus()
        radEMen.Checked = False
        radEWomen.Checked = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnClose.Enabled = False
        userAct = "Insert"
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        chkEId = txtEAdd.Text
        gboData.Enabled = True
        txtEId.Enabled = True
        txtEName.Enabled = True
        txtELname.Enabled = True
        txtEAdd.Enabled = True
        txtETel.Enabled = True
        userAct = "Edit"
        oldEmpID = txtEId.Text

    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim dgr As DialogResult
        dgr = MessageBox.Show("โปรดยืนยันการลบข้อมูลลุกค้า รหัส: " & txtEId.Text & " ชื่อ: " & txtEName.Text, "โปรดระวัง..", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        If dgr = Windows.Forms.DialogResult.Yes Then
            conDB()
            strSql = "Delete From tbCustomers where Cus_Id = @empid "
            mycomm = New SqlCommand(strSql, Conn)
            mycomm.CommandType = CommandType.Text
            mycomm.CommandTimeout = 15
            mycomm.Parameters.AddWithValue("empId", txtEId.Text)
            mycomm.ExecuteNonQuery()
            Call LoadData()
            Me.Controls.Clear()
            InitializeComponent()
            EmployeeForm_Load(sender, e)
            MessageBox.Show("ลบข้อมูลลุกค้าที่ต้องการเรียบร้อย", "ลบข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        CusId = ""
        CusCode = ""
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Call LoadData()
        gboData.Enabled = False
        dgvDataEmloyee.Enabled = True
        btnInserte.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnClose.Enabled = True
        EmployeeForm_Load(sender, e)
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call conDB()
        txtEId.Text = txtEId.Text.Trim()
        txtEName.Text = txtEName.Text.Trim()
        txtELname.Text = txtELname.Text.Trim()
        txtEAdd.Text = txtEAdd.Text.Trim()
        If txtEId.Text = "" Or txtEName.Text = "" Or txtELname.Text = "" Or txtEAdd.Text = "" Then
            MessageBox.Show("ท่านป้อนข้อมูลไม่สมบูรณ์" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtEId.Focus()
            Exit Sub
        ElseIf txtETel.Text.Length <> 10 Then
            MessageBox.Show("ท่านป้อนข้อมูลเบอร์โทรศัพท์ไม่ถูกต้อง" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf txtENumber.Text.Length <> 13 Then
            MessageBox.Show("ท่านป้อนข้อมูลเลขบัตรประชานไม่ถูกต้อง" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf Not IsNumeric(txtETel.Text) Or Not IsNumeric(txtENumber.Text) Then
            MessageBox.Show("ท่านป้อนข้อมูลไม่ถูกต้อง" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
    


        Else
            'บันทึก 
            Dim gender As String

            If radEMen.Checked Then
                gender = "1"
            Else
                gender = "2"
            End If

            If userAct = "Insert" Then 'เพิ่ม
                'เช็ค PK
                strSql = "select Cus_Id from tbCustomers where Cus_Id = @eid "
                mycomm = New SqlCommand(strSql, Conn)
                mycomm.CommandType = CommandType.Text
                mycomm.CommandTimeout = 15
                mycomm.Parameters.AddWithValue("eid", txtEId.Text)
                myDR = mycomm.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("รหัสพนักงานที่ท่านป้อน ซ้ำกับที่มีอยู่แล้วในระบบ" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "รหัสพนักงานซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    myDR.Close()
                    Exit Sub
                End If

                myDR.Close()
                strSql = "Insert into tbCustomers(Cus_Id, Cus_Name, Cus_Lname, Cus_Code,Cus_Tel,Sex,Address,Status) " & _
                    " Values(@eid, @ename, @eLname, @eNumber,@eTel,@eSex,@eadd,@Status)  "
                mycomm = New SqlCommand(strSql, Conn)
                mycomm.CommandType = CommandType.Text
                mycomm.CommandTimeout = 15
                mycomm.Parameters.AddWithValue("eid", txtEId.Text)
                mycomm.Parameters.AddWithValue("ename", txtEName.Text)
                mycomm.Parameters.AddWithValue("eLname", txtELname.Text)
                mycomm.Parameters.AddWithValue("eadd", txtEAdd.Text)
                mycomm.Parameters.AddWithValue("eTel", txtETel.Text)
                mycomm.Parameters.AddWithValue("eSex", gender)
                mycomm.Parameters.AddWithValue("Status", "1")
                mycomm.Parameters.AddWithValue("eNumber", txtENumber.Text)


                mycomm.ExecuteNonQuery()
                Call LoadData()
                Call btnCancel_Click(sender, e)
                MessageBox.Show("เพิ่มข้อมูลพนักงานใหม่เรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else 'แก้ไข 
                If oldEmpID <> txtEId.Text Then 'มีการเปลี่ยนแปลงรหัสพนักงาน
                    'เช็ค PK
                    strSql = "select Cus_id from tbCustomers where Cus_id = @eid "
                    mycomm = New SqlCommand(strSql, Conn)
                    mycomm.CommandType = CommandType.Text
                    mycomm.CommandTimeout = 15
                    mycomm.Parameters.AddWithValue("eid", txtEId.Text)
                    myDR = mycomm.ExecuteReader
                    If myDR.HasRows Then
                        myDR.Read()
                        If myDR.Item("Cus_id") <> oldEmpID Then
                            MessageBox.Show("รหัสพนักงานที่ท่านเปลี่ยนแปลง เป็นรหัสของพนักงานคนอื่นที่ใช้อยู่ในระบบ" & Chr(10) & "ต้องการที่จะแก้ไขรหัสพนักงานนี้ใช่หรือไม่ ?", "รหัสพนักงานซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            myDR.Close()
                            Exit Sub
                        End If
                    End If
                    myDR.Close()
                End If
                strSql = "Update tbCustomers Set Cus_id = @eid, Cus_Name=@ename, Cus_LName=@eLname, Cus_Code=@eNumber,Cus_Tel=@etel,Sex=@eSex, Address=@eadd where Cus_id = @eoid"
                mycomm = New SqlCommand(strSql, Conn)
                mycomm.CommandType = CommandType.Text
                mycomm.CommandTimeout = 15
                mycomm.Parameters.AddWithValue("eid", txtEId.Text)
                mycomm.Parameters.AddWithValue("ename", txtEName.Text)
                mycomm.Parameters.AddWithValue("eLname", txtELname.Text)
                mycomm.Parameters.AddWithValue("eadd", txtEAdd.Text)
                mycomm.Parameters.AddWithValue("eTel", txtETel.Text)
                mycomm.Parameters.AddWithValue("eSex", gender)
                mycomm.Parameters.AddWithValue("eNumber", txtENumber.Text)
                mycomm.Parameters.AddWithValue("eoid", oldEmpID)
                mycomm.ExecuteNonQuery()
                Call LoadData()
                Call btnCancel_Click(sender, e)
                CusCode = txtENumber.Text
                MessageBox.Show("แก้ไขข้อมูลลูกค้าเรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
        End If
    End Sub
    Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnSelect.Click
        Dim n As Integer
        n = dgvDataEmloyee.CurrentCell.RowIndex
        CusCode = dgvDataEmloyee.Item(3, n).Value
        Me.Close()
    End Sub

    Private Sub dgvDataEmloyee_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDataEmloyee.CellDoubleClick
        If CusStatatus = 2 Then
            Call btnSelect_Click(sender, e)
        End If
    End Sub

   
End Class