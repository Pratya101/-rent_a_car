Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class InserteBrandForm
    Dim strConn As String = ConfigurationManager.ConnectionStrings("ProCarSale.My.MySettings.myCon").ConnectionString
    Dim strSql As String
    Dim Conn As New SqlConnection
    Dim mycomm As New SqlCommand
    Dim myDR As SqlDataReader
    Dim userAct, chkBid As String
    Private Sub conDB()
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        Conn.ConnectionString = strConn
        Conn.Open()
    End Sub
    Private Sub InserteBrandForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call LoadData()
        gboData.Enabled = False
        btnDelete.Enabled = False
        btnEdit.Enabled = False
    End Sub
    Private Sub LoadData()
        Call conDB()
        strSql = "SELECT * from tbBrand"
        Dim da As SqlDataAdapter = New SqlDataAdapter(strSql, Conn)
        Dim ds As DataSet = New DataSet
        ds.Tables.Clear()
        da.Fill(ds, "tbDataBrand")
        dgvDataBrand.ReadOnly = True
        dgvDataBrand.DataSource = ds.Tables("tbDataBrand")
        dgvDataBrand.Columns(0).HeaderCell.Value = "รหัสยี่ห้อ"
        dgvDataBrand.Columns(1).HeaderCell.Value = "ชื่อยี่ห้อ"
        dgvDataBrand.Columns(0).Width = 100
        dgvDataBrand.Columns(1).Width = 200
    End Sub

    Private Sub btnInserte_Click(sender As System.Object, e As System.EventArgs) Handles btnInserte.Click
        gboData.Enabled = True
        txtBid.Clear()
        txtBName.Clear()
        userAct = "Insert"
    End Sub

    Private Sub dgvDataBrand_CellEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDataBrand.CellEnter
        If dgvDataBrand.RowCount = 0 Or dgvDataBrand.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Dim r As Integer = dgvDataBrand.CurrentCell.RowIndex
        Dim eid As String = dgvDataBrand.Item(0, r).Value
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        conDB()
        strSql = "SELECT * from tbBrand where bId=@eid"
        mycomm = New SqlCommand(strSql, Conn)
        mycomm.CommandType = CommandType.Text
        mycomm.CommandTimeout = 15
        mycomm.Parameters.AddWithValue("@eid", eid)
        myDR = mycomm.ExecuteReader
        myDR.Read()
        txtBid.Text = myDR.Item("bId")
        txtBName.Text = myDR.Item("bName")
        myDR.Close()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        txtBid.Text = txtBid.Text.Trim()
        txtBName.Text = txtBName.Text.Trim()
        If txtBid.Text = "" Or txtBName.Text = "" Then
            MessageBox.Show("ท่านป้อนข้อมูลไม่สมบูรณ์" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "ข้อมูลไม่สมบูรณ์", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtBid.Focus()
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
                mycomm.Parameters.AddWithValue("eid", txtBid.Text)
                myDR = mycomm.ExecuteReader
                If myDR.HasRows Then
                    MessageBox.Show("รหัสยี่ห้อที่ท่านป้อน ซ้ำกับที่มีอยู่แล้วในระบบ" & Chr(10) & "กรุณาตรวจสอบและแก้ไขให้ถูกต้อง", "รหัสยี่ห้อซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    myDR.Close()
                    Exit Sub
                End If
                myDR.Close()

                strSql = "Insert into tbBrand(bId, bName) " & _
                    " Values(@bId, @bName)  "
                mycomm = New SqlCommand(strSql, Conn)
                mycomm.CommandType = CommandType.Text
                mycomm.CommandTimeout = 15
                mycomm.Parameters.AddWithValue("bId", txtBid.Text)
                mycomm.Parameters.AddWithValue("bName", txtBName.Text)
                mycomm.ExecuteNonQuery()
                Call LoadData()
                Call btnCancel_Click(sender, e)
                MessageBox.Show("เพิ่มข้อมูลยี่ห้อใหม่เรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else 'แก้ไข 
                If chkBid <> txtBid.Text Then 'มีการเปลี่ยนแปลงรหัสพนักงาน
                    'เช็ค PK
                    strSql = "select bid from tbBrand where bid = @bid "
                    mycomm = New SqlCommand(strSql, Conn)
                    mycomm.CommandType = CommandType.Text
                    mycomm.CommandTimeout = 15
                    mycomm.Parameters.AddWithValue("bid", txtBid.Text)
                    myDR = mycomm.ExecuteReader
                    If myDR.HasRows Then
                        MessageBox.Show("รหัสยี่ห้อที่ท่านเปลี่ยนแปลง เป็นรหัสยี่ห้อของคันอื่นที่ใช้อยู่ในระบบ" & Chr(10) & "ต้องการที่จะแก้ไขรหัสยี่ห้อนี้ใช่หรือไม่ ?", "รหัสยี่ห้อซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End If
                    myDR.Close()
                End If
                strSql = "Update tbBrand Set bid = @bid, bname=@bname where bid = @chkbId"
                mycomm = New SqlCommand(strSql, Conn)
                mycomm.CommandType = CommandType.Text
                mycomm.CommandTimeout = 15
                mycomm.Parameters.AddWithValue("bid", txtBid.Text)
                mycomm.Parameters.AddWithValue("bname", txtBName.Text)
                mycomm.Parameters.AddWithValue("chkbId", chkBid)
                mycomm.ExecuteNonQuery()
                Call LoadData()
                Call btnCancel_Click(sender, e)
                MessageBox.Show("แก้ไขข้อมูลยี่ห้อรถยนต์เรียบร้อย", "บันทึกสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        txtBid.Clear()
        txtBName.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        gboData.Enabled = False
        txtBid.Clear()
        txtBName.Clear()
        dgvDataBrand.Enabled = True
        btnInserte.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnClose.Enabled = True
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim dgr As DialogResult
        dgr = MessageBox.Show("โปรดยืนยันการลบข้อมูลยี่ห้อรถยนต์ รหัส: " & txtBid.Text & " ชื่อ: " & txtBName.Text, "โปรดระวัง..", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        If dgr = Windows.Forms.DialogResult.Yes Then
            conDB()
            strSql = "Delete From tbBrand where bId = @bid "
            mycomm = New SqlCommand(strSql, Conn)
            mycomm.CommandType = CommandType.Text
            mycomm.CommandTimeout = 15
            mycomm.Parameters.AddWithValue("bid", txtBid.Text)
            mycomm.ExecuteNonQuery()
            Call LoadData()
            MessageBox.Show("ลบข้อมูลยี่ห้อรถยนต์ที่ต้องการเรียบร้อย", "ลบข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        chkBid = txtBid.Text
        gboData.Enabled = True
        txtBid.Enabled = True
        txtBName.Enabled = True
        userAct = "Edit"
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class