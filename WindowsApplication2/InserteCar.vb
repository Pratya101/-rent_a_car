Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class InserteCar
    Dim strConn As String = ConfigurationManager.ConnectionStrings("ProCarSale.My.MySettings.myCon").ConnectionString
    Dim strSql As String
    Dim Conn As New SqlConnection
    Dim selectRow As Integer
    Dim mycomm As New SqlCommand
    Dim myDR As SqlDataReader
    Dim userAct As String
    Dim oldcID As String
    Private Sub conDB()
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        Conn.ConnectionString = strConn
        Conn.Open()
    End Sub
    Private Sub loadGen()
        Call conDB()
        strSql = "select * from tbGen"
        mycomm = New SqlCommand(strSql, Conn)
        mycomm.CommandTimeout = 15
        mycomm.CommandType = CommandType.Text
        myDR = mycomm.ExecuteReader
        If myDR.HasRows Then
            While myDR.Read
                cboGen.Items.Add(myDR.Item("gName"))
            End While
            cboGen.SelectedIndex = 0
            myDR.Close()
        Else
            MessageBox.Show("ยังไม่มีข้อมูลตำแหน่งในระบบ ไม่สามารถจัดการข้อมูลสินค้าได้" & Chr(10) & "กรุณาดำเนินการในส่วนการจัดการตำแหน่งก่อน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myDR.Close()
            Me.Close()
        End If
    End Sub
    Private Sub LoadData()
        Call conDB()
        strSql = "SELECT * FROM tbCars"
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbDataCar")
        dgvDataCar.ReadOnly = True
        dgvDataCar.DataSource = ds.Tables("tbDataCar")
        dgvDataCar.Columns(0).HeaderCell.Value = "เลขทะเบียนรถ"
        dgvDataCar.Columns(1).HeaderCell.Value = "สี"
        dgvDataCar.Columns(2).HeaderCell.Value = "เลขตัวถัง"
        dgvDataCar.Columns(3).HeaderCell.Value = "ราคา/วัน"
        dgvDataCar.Columns(4).Visible = False
        dgvDataCar.Columns(5).Visible = False
        dgvDataCar.Columns(0).Width = 150
        dgvDataCar.Columns(1).Width = 200
        dgvDataCar.Columns(2).Width = 300
        dgvDataCar.Columns(3).Width = 200
        Conn.Close()

    End Sub

    Private Sub InserteCar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call LoadData()
        Call loadGen()
        gpbData.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnInserte_Click(sender As System.Object, e As System.EventArgs) Handles btnInserte.Click
        gpbData.Enabled = True
        Label2.Visible = False
        lblStatus.Visible = False
        cboColor.SelectedIndex = 0
        txtCId.Clear()
        txtCNumber.Clear()
        txtCPrice.Clear()
        cboGen.SelectedIndex = 0
        userAct = "Insert"
    End Sub

    Private Sub dgvDataCar_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDataCar.CellEnter
        If dgvDataCar.RowCount = 0 Or dgvDataCar.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Dim r As Integer = dgvDataCar.CurrentCell.RowIndex
        Dim Carid As String = dgvDataCar.Item(0, r).Value
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        conDB()
        strSql = "SELECT tbCars.*,tbGen.gName from tbCars,tbGen where tbCars.gId=tbGen.gId and tbCars.Cr_Id=@Cr_Id"
        mycomm = New SqlCommand(strSql, Conn)
        mycomm.CommandType = CommandType.Text
        mycomm.CommandTimeout = 15
        mycomm.Parameters.AddWithValue("@Cr_Id", Carid)
        myDR = mycomm.ExecuteReader
        myDR.Read()
        txtCId.Text = myDR.Item("Cr_Id")
        txtCPrice.Text = myDR.Item("Cr_Price")
        cboColor.SelectedItem = myDR.Item("Cr_Color")
        txtCNumber.Text = myDR.Item("Cr_Number")
        cboGen.SelectedItem = myDR.Item("gName")

        If myDR.Item("Cr_Amount") = 1 Then
            lblStatus.Text = "พร้อมให้เช่า"
            lblStatus.ForeColor = Color.Green
        Else

            lblStatus.Text = "กำลังเช่า"
            lblStatus.ForeColor = Color.Yellow
        End If
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        lblStatus.Visible = False
        Label2.Visible = False
        Label2.Visible = False
        dgvDataCar.Enabled = False
        gpbData.Enabled = True
        txtCId.Focus()
        btnInserte.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnClose.Enabled = False
        userAct = "Edit"
        oldcID = txtCId.Text
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call conDB()

        txtCId.Text = txtCId.Text.Trim()
        txtCNumber.Text = txtCNumber.Text.Trim()
        txtCPrice.Text = txtCPrice.Text.Trim()
        If txtCId.Text = "" Or txtCNumber.Text = "" Or txtCPrice.Text = "" Then
            MessageBox.Show("ท่านป้อนข้อมูลไม่สมบูรณ์" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCId.Focus()
            Exit Sub
        ElseIf Not IsNumeric(txtCPrice.Text) Then
            MessageBox.Show("ท่านป้อนข้อมูลราคาเช่าไม่ถูกต้อง" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCPrice.Focus()
            Exit Sub
        Else
            'บันทึก 
            Dim gId As String
            strSql = "select gId from tbGen where gName = @sname "
            mycomm = New SqlCommand(strSql, Conn)
            mycomm.CommandType = CommandType.Text
            mycomm.CommandTimeout = 15
            mycomm.Parameters.AddWithValue("sname", cboGen.SelectedItem)
            myDR = mycomm.ExecuteReader
            myDR.Read()
            gId = myDR.Item("gId")
            myDR.Close()


            If userAct = "Insert" Then 'เพิ่ม
                'เช็ค PK
                strSql = "select * from tbCars where Cr_Id = @Cid "
                mycomm = New SqlCommand(strSql, Conn)
                mycomm.CommandType = CommandType.Text
                mycomm.CommandTimeout = 15
                mycomm.Parameters.AddWithValue("Cid", txtCId.Text)
                myDR = mycomm.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("รหัสสินค้าที่ท่านป้อน ซ้ำกับที่มีอยู่แล้วในระบบ" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "รหัสสินค้าซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    myDR.Close()
                    Exit Sub
                End If
                myDR.Close()
                strSql = "Insert into tbCars(Cr_Id, Cr_Color, Cr_Number, Cr_Price, gId,Cr_Amount) " & _
                    " Values(@cLicense, @cColor, @cNumber, @cPrice, @gId,@Amount)  "
                mycomm = New SqlCommand(strSql, Conn)
                mycomm.CommandType = CommandType.Text
                mycomm.CommandTimeout = 15
                mycomm.Parameters.AddWithValue("cLicense", txtCId.Text)
                mycomm.Parameters.AddWithValue("cColor", cboColor.SelectedItem)
                mycomm.Parameters.AddWithValue("cNumber", txtCNumber.Text)
                mycomm.Parameters.AddWithValue("cPrice", txtCPrice.Text)
                mycomm.Parameters.AddWithValue("gId", gId)
                mycomm.Parameters.AddWithValue("Amount", "1")
                mycomm.ExecuteNonQuery()
                Call LoadData()
                Call btnCancel_Click(sender, e)
                MessageBox.Show("เพิ่มข้อมูลสินค้าใหม่เรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else 'แก้ไข 
                If oldcID <> txtCId.Text Then 'มีการเปลี่ยนแปลงรหัสพนักงาน
                    'เช็ค PK
                    strSql = "select Cr_Id from tbCars where Cr_Id = @cId "
                    mycomm = New SqlCommand(strSql, Conn)
                    mycomm.CommandType = CommandType.Text
                    mycomm.CommandTimeout = 15
                    mycomm.Parameters.AddWithValue("cId", txtCId.Text)
                    myDR = mycomm.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("รหัสสินค้าที่ท่านเปลี่ยนแปลง เป็นรหัสของสินค้าอื่นที่ใช้อยู่ในระบบ" & Chr(10) & "ต้องการที่จะแก้ไขรหัสสินค้านี้ใช่หรือไม่ ?", "รหัสพนักงานซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End If
                    myDR.Close()
                End If
                strSql = "Update tbCars Set Cr_Id = @cLicense,Cr_Color=@cColor, Cr_Number=@cNumber,Cr_Price=@cPrice, gId=@gId,Cr_Amount=@Amount where Cr_Id = @ocid"

                mycomm = New SqlCommand(strSql, Conn)
                mycomm.CommandType = CommandType.Text
                mycomm.CommandTimeout = 15
                mycomm.Parameters.AddWithValue("cLicense", txtCId.Text)
                mycomm.Parameters.AddWithValue("cColor", cboColor.SelectedItem)
                mycomm.Parameters.AddWithValue("cNumber", txtCNumber.Text)
                mycomm.Parameters.AddWithValue("cPrice", txtCPrice.Text)
                mycomm.Parameters.AddWithValue("gId", gId)
                mycomm.Parameters.AddWithValue("Amount", "1")
                mycomm.Parameters.AddWithValue("ocid", oldcID)
                mycomm.ExecuteNonQuery()
                Call LoadData()
                Call btnCancel_Click(sender, e)
                MessageBox.Show("แก้ไขข้อมูลสินค้าเรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        gpbData.Enabled = False
        lblStatus.Visible = True
        Label2.Visible = True
        btnInserte.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnClose.Enabled = True
        dgvDataCar.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim dgr As DialogResult
        dgr = MessageBox.Show("โปรดยืนยันการลบข้อมูลสินค้า รหัส: " & txtCId.Text, "โปรดระวัง..", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        If dgr = Windows.Forms.DialogResult.Yes Then
            conDB()
            strSql = "Delete From tbCars where Cr_Id = @cId "
            mycomm = New SqlCommand(strSql, Conn)
            mycomm.CommandType = CommandType.Text
            mycomm.CommandTimeout = 15
            mycomm.Parameters.AddWithValue("cId", txtCId.Text)
            mycomm.ExecuteNonQuery()
            Call LoadData()
            Me.Controls.Clear()
            InitializeComponent()
            InserteCar_Load(sender, e)
            MessageBox.Show("ลบข้อมูลสินค้าที่ต้องการเรียบร้อย", "ลบข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub gpbData_Enter(sender As System.Object, e As System.EventArgs) Handles gpbData.Enter

    End Sub

    Private Sub dgvDataCar_CellContentClick_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDataCar.CellContentClick

    End Sub
End Class