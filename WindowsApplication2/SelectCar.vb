Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class SelectCar
    Dim strConn As String = ConfigurationManager.ConnectionStrings("ProCarSale.My.MySettings.myCon").ConnectionString
    Dim strSql As String
    Dim Conn As SqlConnection = New SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet = New DataSet

    Private Sub conDB()
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        Conn.ConnectionString = strConn
        Conn.Open()
    End Sub

    Private Sub SelectCar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        Conn.ConnectionString = strConn
        Conn.Open()
        strSql = "Select Cr_id, Cr_Color,Cr_Price From tbCars"
        da = New SqlDataAdapter(strSql, Conn)
        ds.Clear()
        da.Fill(ds, "tbPro")
        dgvProduct.DataSource = ds.Tables("tbPro")
        dgvProduct.Columns(0).HeaderCell.Value = "เลขทะเบียน"
        dgvProduct.Columns(1).HeaderCell.Value = "สี"
        dgvProduct.Columns(2).HeaderText = "ราคาเช่า/วัน"
        dgvProduct.Columns(0).Width = 150
        dgvProduct.Columns(1).Width = 150
        dgvProduct.Columns(2).Width = 100
        dgvProduct.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvProduct.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvProduct.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomLeft
    End Sub

    Private Sub btnSelect_Click(sender As System.Object, e As System.EventArgs) Handles btnSelect.Click
        Dim n As Integer
        n = dgvProduct.CurrentCell.RowIndex
        If lblStatus.Text = "กำลังเช่า" Then
            MessageBox.Show("รถคันนี้มีสถานะถูกเช้าอยู่ไม่สามารถเลือกได้", "Fail...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            sProID = dgvProduct.Item(0, n).Value

            Me.Close()
        End If

    End Sub

    Private Sub dgvProduct_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProduct.CellDoubleClick
        Call btnSelect_Click(sender, e)
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub dgvProduct_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProduct.CellEnter
        Dim strConn As String = ConfigurationManager.ConnectionStrings("ProCarSale.My.MySettings.myCon").ConnectionString
        Dim strSql As String
        Dim Conn As New SqlConnection
        Dim mycomm As New SqlCommand
        Dim myDR As SqlDataReader
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        Conn.ConnectionString = strConn
        Conn.Open()

        If dgvProduct.RowCount = 0 Or dgvProduct.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Dim r As Integer = dgvProduct.CurrentCell.RowIndex
        Dim Carid As String = dgvProduct.Item(0, r).Value
        conDB()
        strSql = "SELECT tbCars.*,tbGen.gName from tbCars,tbGen where tbCars.gId=tbGen.gId and tbCars.Cr_Id=@Cr_Id"
        mycomm = New SqlCommand(strSql, Conn)
        mycomm.CommandType = CommandType.Text
        mycomm.CommandTimeout = 15
        mycomm.Parameters.AddWithValue("@Cr_Id", Carid)
        myDR = mycomm.ExecuteReader
        myDR.Read()
        If myDR.Item("Cr_Amount") = 1 Then
            lblStatus.Text = "พร้อมให้เช่า"
            lblStatus.ForeColor = Color.Green
        Else
            lblStatus.Text = "กำลังเช่า"
            lblStatus.ForeColor = Color.Red
        End If

    End Sub
End Class