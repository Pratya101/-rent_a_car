Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class InserteTypeForm
    Dim strConn As String = ConfigurationManager.ConnectionStrings("ProCarSale.My.MySettings.myCon").ConnectionString
    Dim strSql As String
    Dim Conn As New SqlConnection
    Dim mycomm As New SqlCommand
    Dim myDR As SqlDataReader
    Dim userAct, chkTId As String
    Private Sub conDB()
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        Conn.ConnectionString = strConn
        Conn.Open()
    End Sub
    Private Sub LoadData()
        Call conDB()
        strSql = "SELECT * from tbType"
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbDataType")
        dgvDataType.ReadOnly = True
        dgvDataType.DataSource = ds.Tables("tbDataType")
        dgvDataType.Columns(0).HeaderCell.Value = "รหัสประเภท"
        dgvDataType.Columns(1).HeaderCell.Value = "ชื่อประเภท"
        dgvDataType.Columns(0).Width = 100
        dgvDataType.Columns(1).Width = 200
    End Sub
    Private Sub InserteTypeForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call LoadData()
        gboData.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
    End Sub
    Private Sub dgvDataBrand_CellEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDataType.CellEnter
        If dgvDataType.RowCount = 0 Or dgvDataType.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Dim r As Integer = dgvDataType.CurrentCell.RowIndex
        Dim eid As String = dgvDataType.Item(0, r).Value
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        conDB()
        strSql = "SELECT * from tbType where tId=@eid"
        mycomm = New SqlCommand(strSql, Conn)
        mycomm.CommandType = CommandType.Text
        mycomm.CommandTimeout = 15
        mycomm.Parameters.AddWithValue("@eid", eid)
        myDR = mycomm.ExecuteReader
        myDR.Read()
        txtTId.Text = myDR.Item("tId")
        txtTName.Text = myDR.Item("tName")
        myDR.Close()
    End Sub
    Private Sub btnInserte_Click(sender As System.Object, e As System.EventArgs) Handles btnInserte.Click
        gboData.Enabled = True
        txtTId.Clear()
        txtTName.Clear()
        userAct = "Insert"
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        chkTId = txtTId.Text
        gboData.Enabled = True
        txtTId.Enabled = True
        txtTName.Enabled = True
        userAct = "Edit"
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim dgr As DialogResult
        dgr = MessageBox.Show("โปรดยืนยันการลบข้อมูลประเภทรถยนต์ รหัส: " & txtTId.Text & " ชื่อ: " & txtTName.Text, "โปรดระวัง..", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        If dgr = Windows.Forms.DialogResult.Yes Then
            conDB()
            strSql = "Delete From tbType where tId = @tid "
            mycomm = New SqlCommand(strSql, Conn)
            mycomm.CommandType = CommandType.Text
            mycomm.CommandTimeout = 15
            mycomm.Parameters.AddWithValue("tid", txtTId.Text)
            mycomm.ExecuteNonQuery()
            Call LoadData()
            MessageBox.Show("ลบข้อมูลประเภทรถยนต์ที่ต้องการเรียบร้อย", "ลบข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        gboData.Enabled = False
        txtTId.Clear()
        txtTName.Clear()
        dgvDataType.Enabled = True
        btnInserte.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnClose.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        txtTId.Text = txtTId.Text.Trim()
        txtTName.Text = txtTName.Text.Trim()
        If txtTId.Text = "" Or txtTName.Text = "" Then
            MessageBox.Show("ท่านป้อนข้อมูลไม่สมบูรณ์" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtTId.Focus()
            Exit Sub
        Else
            'บันทึก 
            conDB()
            If userAct = "Insert" Then 'เพิ่ม
                'เช็ค PK
                strSql = "select bid from tbBrand where bid = @eid "
                mycomm = New SqlCommand(strSql, Conn)
                mycomm.CommandType = CommandType.Text
                mycomm.CommandTimeout = 15
                mycomm.Parameters.AddWithValue("eid", txtTId.Text)
                myDR = mycomm.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("รหัสประเภทที่ท่านป้อน ซ้ำกับที่มีอยู่แล้วในระบบ" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "รหัสประเภทซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    myDR.Close()
                    Exit Sub
                End If
                myDR.Close()

                strSql = "Insert into tbType(tId, tName) " & _
                    " Values(@tId, @tName)  "
                mycomm = New SqlCommand(strSql, Conn)
                mycomm.CommandType = CommandType.Text
                mycomm.CommandTimeout = 15
                mycomm.Parameters.AddWithValue("tId", txtTId.Text)
                mycomm.Parameters.AddWithValue("tName", txtTName.Text)
                mycomm.ExecuteNonQuery()
                Call LoadData()
                Call btnCancel_Click(sender, e)
                MessageBox.Show("เพิ่มข้อมูลประเภทใหม่เรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else 'แก้ไข 
                If chkTId <> txtTId.Text Then 'มีการเปลี่ยนแปลงรหัสพนักงาน
                    'เช็ค PK
                    strSql = "select tId from tbType where tId = @tId "
                    mycomm = New SqlCommand(strSql, Conn)
                    mycomm.CommandType = CommandType.Text
                    mycomm.CommandTimeout = 15
                    mycomm.Parameters.AddWithValue("tId", txtTId.Text)
                    myDR = mycomm.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("รหัสประเภทที่ท่านเปลี่ยนแปลง เป็นรหัสประเภทอื่นที่ใช้อยู่ในระบบ" & Chr(10) & "ต้องการที่จะแก้ไขรหัสประเภทนี้ใช่หรือไม่ ?", "รหัสประเภทซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End If
                    myDR.Close()
                End If
                strSql = "Update tbType Set tId = @tId, tname=@tname where tId = @chkTId"
                mycomm = New SqlCommand(strSql, Conn)
                mycomm.CommandType = CommandType.Text
                mycomm.CommandTimeout = 15
                mycomm.Parameters.AddWithValue("tId", txtTId.Text)
                mycomm.Parameters.AddWithValue("tname", txtTName.Text)
                mycomm.Parameters.AddWithValue("chkTId", chkTId)
                mycomm.ExecuteNonQuery()
                Call LoadData()
                Call btnCancel_Click(sender, e)
                MessageBox.Show("แก้ไขข้อมูลประเภทรถยนต์เรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        txtTId.Clear()
        txtTName.Clear()
    End Sub

    
End Class