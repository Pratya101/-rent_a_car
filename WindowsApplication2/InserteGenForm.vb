Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class InserteGenForm
    Dim strConn As String = ConfigurationManager.ConnectionStrings("ProCarSale.My.MySettings.myCon").ConnectionString
    Dim strSql As String
    Dim Conn As New SqlConnection
    Dim selectRow As Integer
    Dim mycomm As New SqlCommand
    Dim myDR As SqlDataReader
    Dim userAct As String
    Dim oldGID As String
    Private Sub conDB()
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        Conn.ConnectionString = strConn
        Conn.Open()
    End Sub
    Private Sub LoadType()
        Call conDB()
        strSql = "select * from tbType"
        mycomm = New SqlCommand(strSql, Conn)
        mycomm.CommandTimeout = 15
        mycomm.CommandType = CommandType.Text
        myDR = mycomm.ExecuteReader
        If myDR.HasRows Then
            While myDR.Read
                cboType.Items.Add(myDR.Item("tName"))
            End While
            cboType.SelectedIndex = 0
            myDR.Close()
        Else
            MessageBox.Show("ยังไม่มีข้อมูลประเภทในในระบบ ไม่สามารถจัดการข้อมูลรุ่นได้" & Chr(10) & "กรุณาดำเนินการในส่วนการจัดการข้อมูลประเภทก่อน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myDR.Close()
            Me.Close()
        End If

    End Sub
    Private Sub LoadBrand()
        Call conDB()
        strSql = "select * from tbBrand"
        mycomm = New SqlCommand(strSql, Conn)
        mycomm.CommandTimeout = 15
        mycomm.CommandType = CommandType.Text
        myDR = mycomm.ExecuteReader
        If myDR.HasRows Then
            While myDR.Read
                cboBrand.Items.Add(myDR.Item("bName"))
            End While
            cboBrand.SelectedIndex = 0
            myDR.Close()
        Else
            MessageBox.Show("ยังไม่มีข้อมูลยี่ห้อในระบบ ไม่สามารถจัดการข้อมูลยี่ห้อได้" & Chr(10) & "กรุณาดำเนินการในส่วนการจัดการยี่ห้อก่อน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myDR.Close()
            Me.Close()
        End If

    End Sub
    Private Sub LoadData()
        Call conDB()
        strSql = "SELECT dbo.tbGen.gId,dbo.tbGen.gName,dbo.tbGen.gGear,dbo.tbGen.gOli,dbo.tbGen.gYear FROM dbo.tbGen"
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbData2")
        dgvDataGen.ReadOnly = True
        dgvDataGen.DataSource = ds.Tables("tbData2")
        dgvDataGen.Columns(0).HeaderCell.Value = "รหัสรุ่น"
        dgvDataGen.Columns(1).HeaderCell.Value = "ชื่อรุ่น"
        dgvDataGen.Columns(2).HeaderCell.Value = "ระบบเกียร์"
        dgvDataGen.Columns(3).HeaderCell.Value = "ความจุถังน้ำมัน"
        dgvDataGen.Columns(4).HeaderCell.Value = "ปีที่ผลิต"
        dgvDataGen.Columns(0).Width = 100
        dgvDataGen.Columns(1).Width = 100
        dgvDataGen.Columns(2).Width = 100
        dgvDataGen.Columns(3).Width = 100
        dgvDataGen.Columns(4).Width = 100
        Conn.Close()
    End Sub
    Private Sub InserteGenForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call LoadData()
        Call LoadType()
        Call LoadBrand()
        gboData.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False

    End Sub

    Private Sub btnInserte_Click(sender As System.Object, e As System.EventArgs) Handles btnInserte.Click
        gboData.Enabled = True
        txtGId.Clear()
        txtGName.Clear()
        cboSize.SelectedIndex = 0
        cboType.SelectedIndex = 0
        cboYear.SelectedIndex = 0
        cboBrand.SelectedIndex = 0
        radAoto.Checked = False
        radPlain.Checked = False
        userAct = "Insert"
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call conDB()

        txtGId.Text = txtGId.Text.Trim()
        txtGName.Text = txtGName.Text.Trim()
        If txtGId.Text = "" Or txtGName.Text = "" Then
            MessageBox.Show("ท่านป้อนข้อมูลไม่สมบูรณ์" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtGId.Focus()
            Exit Sub
        Else
            'บันทึก 
            Dim Gear As String
            Dim depID As String
            Dim bId, tId As String

            If radAoto.Checked Then
                Gear = "Auto"
            Else
                Gear = "Normal"
            End If

            strSql = "select bId from tbBrand where bName = @sname "
            mycomm = New SqlCommand(strSql, Conn)
            mycomm.CommandType = CommandType.Text
            mycomm.CommandTimeout = 15
            mycomm.Parameters.AddWithValue("sname", cboBrand.SelectedItem)
            myDR = mycomm.ExecuteReader
            myDR.Read()
            bId = myDR.Item("bId")
            myDR.Close()


            strSql = "select tId from tbType where tName = @sname "
            mycomm = New SqlCommand(strSql, Conn)
            mycomm.CommandType = CommandType.Text
            mycomm.CommandTimeout = 15
            mycomm.Parameters.AddWithValue("sname", cboType.SelectedItem)
            myDR = mycomm.ExecuteReader
            myDR.Read()
            tId = myDR.Item("tId")
            myDR.Close()


            If userAct = "Insert" Then 'เพิ่ม
                'เช็ค PK
                strSql = "select * from tbGen where gId = @gIds "
                mycomm = New SqlCommand(strSql, Conn)
                mycomm.CommandType = CommandType.Text
                mycomm.CommandTimeout = 15
                mycomm.Parameters.AddWithValue("gIds", txtGId.Text)
                myDR = mycomm.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("รหัสรุ่นที่ท่านป้อน ซ้ำกับที่มีอยู่แล้วในระบบ" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "รหัสรุ่นซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    myDR.Close()
                    Exit Sub
                End If
                myDR.Close()
                strSql = "Insert into tbGen(gId, gName, gGear, gOli, gYear,bId,tId) " & _
                    " Values(@gid, @gname, @gGear, @gOli, @gYear, @bId, @tId)  "
                mycomm = New SqlCommand(strSql, Conn)
                mycomm.CommandType = CommandType.Text
                mycomm.CommandTimeout = 15
                mycomm.Parameters.AddWithValue("gid", txtGId.Text)
                mycomm.Parameters.AddWithValue("gname", txtGName.Text)
                mycomm.Parameters.AddWithValue("gGear", Gear)
                mycomm.Parameters.AddWithValue("gOli", cboSize.SelectedItem)
                mycomm.Parameters.AddWithValue("gYear", cboYear.SelectedItem)
                mycomm.Parameters.AddWithValue("bId", bId)
                mycomm.Parameters.AddWithValue("tId", tId)
                mycomm.ExecuteNonQuery()
                Call LoadData()
                Call btnCancel_Click(sender, e)
                MessageBox.Show("เพิ่มข้อมูลรุ่นใหม่เรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else 'แก้ไข 
                If oldGID <> txtGId.Text Then 'มีการเปลี่ยนแปลงรหัสพนักงาน
                    'เช็ค PK
                    strSql = "select gId from tbGen where gId = @gId "
                    mycomm = New SqlCommand(strSql, Conn)
                    mycomm.CommandType = CommandType.Text
                    mycomm.CommandTimeout = 15
                    mycomm.Parameters.AddWithValue("gId", txtGId.Text)
                    myDR = mycomm.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("รหัสรุ่นที่ท่านเปลี่ยนแปลง เป็นรหัสของรุ่นอื่นที่ใช้อยู่ในระบบ" & Chr(10) & "ต้องการที่จะแก้ไขรหัสรุ่นนี้ใช่หรือไม่ ?", "รหัสรุ่นซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End If
                    myDR.Close()
                End If
                strSql = "Update tbGen Set gId = @gid, gName=@gname, gGear=@gGear,gOli=@gOli, gYear=@gYear,bId=@bId,tId=@tId where gId = @ogid"

                mycomm = New SqlCommand(strSql, Conn)
                mycomm.CommandType = CommandType.Text
                mycomm.CommandTimeout = 15
                mycomm.Parameters.AddWithValue("gid", txtGId.Text)
                mycomm.Parameters.AddWithValue("gname", txtGName.Text)
                mycomm.Parameters.AddWithValue("gGear", Gear)
                mycomm.Parameters.AddWithValue("gOli", cboSize.SelectedItem)
                mycomm.Parameters.AddWithValue("gYear", cboYear.SelectedItem)
                mycomm.Parameters.AddWithValue("bId", bId)
                mycomm.Parameters.AddWithValue("tId", tId)
                mycomm.Parameters.AddWithValue("ogid", oldGID)
                mycomm.ExecuteNonQuery()
                Call LoadData()
                Call btnCancel_Click(sender, e)
                MessageBox.Show("แก้ไขข้อมูลรุ่นเรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        gboData.Enabled = False
        txtGId.Clear()
        txtGName.Clear()
        radAoto.Checked = False
        radPlain.Checked = False
        dgvDataGen.Enabled = True
        btnInserte.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnClose.Enabled = True
    End Sub

    Private Sub dgvDataGen_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDataGen.CellEnter
        If dgvDataGen.RowCount = 0 Or dgvDataGen.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Dim r As Integer = dgvDataGen.CurrentCell.RowIndex
        Dim Gid As String = dgvDataGen.Item(0, r).Value
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        conDB()
        strSql = "SELECT tbGen.*,tbType.tName,tbBrand.bName from tbGen,tbType,tbBrand where tbGen.tId=tbType.tId and tbGen.bId = tbBrand.bId and tbGen.gId=@Gid"
        mycomm = New SqlCommand(strSql, Conn)
        mycomm.CommandType = CommandType.Text
        mycomm.CommandTimeout = 15
        mycomm.Parameters.AddWithValue("@Gid", Gid)
        myDR = mycomm.ExecuteReader
        myDR.Read()
        txtGId.Text = myDR.Item("gId")
        txtGName.Text = myDR.Item("gName")
        If myDR.Item("gGear") = "Auto" Then
            radAoto.Checked = True
        Else
            radPlain.Checked = True
        End If
        cboSize.SelectedItem = myDR.Item("gOli")
        cboYear.SelectedItem = myDR.Item("gYear")
        cboType.SelectedItem = myDR.Item("tname")
        cboBrand.SelectedItem = myDR.Item("bName")
      

    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        dgvDataGen.Enabled = False
        gboData.Enabled = True
        txtGId.Focus()
        btnInserte.Enabled = False
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnClose.Enabled = False
        txtGName.Enabled = True
        userAct = "Edit"
        oldGID = txtGId.Text
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim dgr As DialogResult
        dgr = MessageBox.Show("โปรดยืนยันการลบข้อมูลรุ่น รหัส: " & txtGId.Text & " ชื่อ: " & txtGName.Text, "โปรดระวัง..", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        If dgr = Windows.Forms.DialogResult.Yes Then
            conDB()
            strSql = "Delete From tbGen where Gid = @gId "
            mycomm = New SqlCommand(strSql, Conn)
            mycomm.CommandType = CommandType.Text
            mycomm.CommandTimeout = 15
            mycomm.Parameters.AddWithValue("gId", txtGId.Text)
            mycomm.ExecuteNonQuery()
            Call LoadData()
            Me.Controls.Clear()
            InitializeComponent()
            InserteGenForm_Load(sender, e)
            MessageBox.Show("ลบข้อมูลรุ่นที่ต้องการเรียบร้อย", "ลบข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class