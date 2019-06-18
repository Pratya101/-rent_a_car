Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class HireForm
    Dim strConn As String = ConfigurationManager.ConnectionStrings("ProCarSale.My.MySettings.myCon").ConnectionString
    Dim strSql As String
    Dim Conn As New SqlConnection
    Dim comm As New SqlCommand
    Dim DR As SqlDataReader
    Dim Ds As New DataSet
    Dim Da As SqlDataAdapter
    Dim Tran As SqlTransaction
    Dim strtype, teet As String
    Dim total, amount, DayAmountl As Integer

    Private Sub conDB()
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        Conn.ConnectionString = strConn
        Conn.Open()
    End Sub

    Private Sub HireForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gboDataHire.Enabled = False
        btnHOld.Enabled = False
        lblNameEmp.Text = empName
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



    End Sub

    Private Sub btnNewBill_Click(sender As System.Object, e As System.EventArgs) Handles btnNewBill.Click
        Dim ReStatus As Integer = 1
        If btnNewBill.Text = "เปิดบิลเช่า" Then
            Panel1.Enabled = True
            gboDataHire.Enabled = True
            btnNewBill.Text = "บันทึก"
            btnPrint.Enabled = False
            btnCancel.Text = "ยกเลิก"
            lblSalId.Text = getNewBill()
            lblSalDate.Text = FormatDateTime(Date.Now, DateFormat.ShortDate)
            lblSum.Text = "0"
            btnHOld.Enabled = True
            txtProId.Focus()
        Else 'บันทึก
            If lblNameCus.Text = "" Then
                MessageBox.Show("ท่านยังไม่ได้เลือกลูกค้าสำหรับการขาย", "Error... ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            ElseIf dgvDataHire.Rows.Count = 0 Then
                MessageBox.Show("ไม่ปรากฎรายการขายสินค้าใดๆ ในตารางการขาย", "Error... ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtProId.Focus()
                Exit Sub
            Else
                Dim r, i As Integer
                If Conn.State = ConnectionState.Open Then
                    Conn.Close()
                End If
                Conn.ConnectionString = strConn
                Conn.Open()
                strSql = "select Cus_Id from tbCustomers where (Cus_Name + space(2) + Cus_Lname) = @cFullName"
                comm = New SqlCommand(strSql, Conn)
                comm.Parameters.AddWithValue("@cFullName", lblNameCus.Text)
                DR = comm.ExecuteReader
                DR.Read()
                CusId = DR("Cus_Id")
                DR.Close()

                comm = New SqlCommand
                Tran = Conn.BeginTransaction
                comm.Transaction = Tran

                Try
                    Dim times As DateTime = DateTime.Now
                    strSql = "insert into tbHire Values(@salId, @salDate, @empId, @cusId,@total)"
                    comm.Connection = Conn
                    comm.CommandText = strSql
                    comm.Parameters.AddWithValue("@salId", lblSalId.Text)
                    comm.Parameters.Add("@salDate", times.ToString("G"))
                    comm.Parameters.AddWithValue("@empId", empid)
                    comm.Parameters.AddWithValue("@cusId", CusId)
                    comm.Parameters.AddWithValue("@total", lblSum.Text)
                    r = comm.ExecuteNonQuery
                    For i = 0 To dgvDataHire.RowCount - 1
                        strSql = "insert into tbHireDetail values(@salId, @proID, @salPrice, @salAmount,@DateAmount,@status)"
                        comm.CommandText = strSql
                        comm.Parameters.Clear()
                        comm.Parameters.AddWithValue("@salId", lblSalId.Text)
                        comm.Parameters.AddWithValue("@proId", dgvDataHire.Item(0, i).Value)
                        comm.Parameters.AddWithValue("@salPrice", dgvDataHire.Item(4, i).Value)
                        comm.Parameters.AddWithValue("@salAmount", dgvDataHire.Item(2, i).Value)
                        comm.Parameters.AddWithValue("@DateAmount", dgvDataHire.Item(3, i).Value)
                        comm.Parameters.AddWithValue("@status", ReStatus)
                        r = comm.ExecuteNonQuery
                        strSql = "update tbCars set Cr_Amount = Cr_Amount - @salAmount " & _
                    " Where Cr_Id = @proId "
                        comm.CommandText = strSql
                        r = comm.ExecuteNonQuery
                    Next i
                    MessageBox.Show("บันทึกข้อมูลการขายเรียบร้อย...", "Success..", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Tran.Commit()
                    btnPrint.Enabled = True
                    btnNewBill.Text = "เปิดบิลเช่า"
                    btnCancel.Text = "ออก"
                    dgvDataHire.Rows.Clear()
                    lblNameCus.Text = ""
                    Panel1.Enabled = False
                    dgvDataHire.Enabled = False

                Catch
                    MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้ กรุณาติดต่อผู้ดูแลระบบ...", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Tran.Rollback()
                End Try
            End If
        End If
    End Sub
    Private Sub txtAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 59 Then
            If Asc(e.KeyChar) = 13 Then
                Call btnAdd_Click(sender, e)
            ElseIf Asc(e.KeyChar) <> 8 Then
                e.KeyChar = Nothing
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        If lblNameCr.Text = "" Then
            MessageBox.Show("กรุณาระบุรายการสินค้าที่ต้องการจำหน่าย", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        ElseIf Val(txtAmount.Text) = 0 Then
            MessageBox.Show("รถหมายเลขทะเบียนนี้ไม่มีอยู่ในสต๊อกเนื่องจากมีการเช่าไปเเล้ว", "Warning..", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lblNameCr.Text = ""
            lblPriceDay.Text = ""
            txtAmount.Clear()
            txtAmountDay.Clear()
            lblSaleTotal.Text = ""
            txtProId.Clear()
            txtProId.Focus()
            Exit Sub
        ElseIf Val(txtAmountDay.Text) = 0 Then
            MessageBox.Show("กรุณาระบุจำนวนวันที่ต้องการเช่า", "Error..", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            Dim found As Boolean = False
            Dim i As Integer
            For i = 0 To dgvDataHire.RowCount - 1
                If dgvDataHire.Item(0, i).Value = lblNameCr.Text Then
                    Dim drg As DialogResult
                    drg = MessageBox.Show("สินค้าที่กำลังจะเพิ่ม มีอยู่แล้วในตาราง ท่านต้องการปรับปรุงจำนวนขายหรือไม่?", "Question..", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If drg = Windows.Forms.DialogResult.OK Then
                        lblSum.Text = Val(lblSum.Text) - Val(dgvDataHire.Item(4, i).Value)
                        dgvDataHire.Item(2, i).Value = txtAmount.Text
                        dgvDataHire.Item(3, i).Value = txtAmountDay.Text
                        dgvDataHire.Item(4, i).Value = lblSaleTotal.Text
                        lblSum.Text = Val(lblSum.Text) + Val(lblSaleTotal.Text)
                        found = True
                        Exit For
                    Else


                        Exit Sub
                    End If
                End If
            Next i
            If found = False Then
                dgvDataHire.Rows.Add()
                Dim n As Integer = dgvDataHire.RowCount - 1
                dgvDataHire.Rows(n).Cells(0).Value = lblNameCr.Text
                dgvDataHire.Rows(n).Cells(1).Value = lblPriceDay.Text
                dgvDataHire.Rows(n).Cells(2).Value = txtAmount.Text
                dgvDataHire.Rows(n).Cells(3).Value = txtAmountDay.Text
                dgvDataHire.Rows(n).Cells(4).Value = lblSaleTotal.Text
                'dgvDataHire.Item(0, n).Value = txtProId.Text
                'dgvDataHire.Item(1, n).Value = lblNameCr.Text
                'dgvDataHire.Item(2, n).Value = lblPriceDay.Text
                'dgvDataHire.Item(3, n).Value = txtAmount.Text
                'dgvDataHire.Item(4, n).Value = txtAmountDay.Text
                'dgvDataHire.Item(5, n).Value = lblSaleTotal.Text
                lblSum.Text = Val(lblSum.Text) + Val(lblSaleTotal.Text)
            End If
            lblNameCr.Text = ""
            lblPriceDay.Text = ""
            txtAmount.Clear()
            txtAmountDay.Clear()
            lblSaleTotal.Text = ""
            txtProId.Clear()
            txtProId.Focus()
        End If

    End Sub

    Private Function getNewBill() As String
        Call conDB()
        Dim lastID, newID As String
        Dim curYear As String
        curYear = Str(Year(Date.Now))
        curYear = curYear.Substring(3, 2)
        strSql = "Select Max(H_Id) as mSalID from tbHire  Where H_Id like 'S" & curYear & "-%' "
        comm = New SqlCommand(strSql, Conn)
        DR = comm.ExecuteReader()
        DR.Read()
        If IsDBNull(DR("mSalID")) Then
            newID = "S" & curYear & "-00001"
        Else
            lastID = DR("mSalID")
            lastID = lastID.Substring(4)
            lastID = Val(lastID) + 1
            Select Case lastID.Length
                Case 1 : lastID = "-0000" & lastID
                Case 2 : lastID = "-000" & lastID
                Case 3 : lastID = "-00" & lastID
                Case 4 : lastID = "-0" & lastID
            End Select
            newID = "S" & curYear & lastID
        End If
        DR.Close()
        Return newID
    End Function

    Private Sub findProduct()
        If txtProId.Text.Trim <> "" Then
            strSql = "Select * from tbCars Where Cr_id = @pid "
            comm = New SqlCommand(strSql, Conn)
            comm.Parameters.AddWithValue("@pid", txtProId.Text)
            DR = comm.ExecuteReader()
            If DR.HasRows Then
                DR.Read()
                lblNameCr.Text = DR("Cr_Id")
                lblPriceDay.Text = DR("Cr_Price")
                txtAmount.Text = DR("Cr_Amount")
                txtAmountDay.Text = 1
                total = (Val(lblPriceDay.Text) * Val(txtAmount.Text)) * Val(txtAmountDay.Text)
                lblSaleTotal.Text = total
                DayAmountl = total * Val(txtAmountDay.Text)
                lblSaleTotal.Text = DayAmountl
                txtAmount.Enabled = False
                txtAmountDay.Focus()
                txtProId.Clear()
            Else
                MessageBox.Show("ไม่พบรายการสินค้า ตามรหัสที่ระบุ", "Not found...", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtProId.Focus()
            End If
            DR.Close()
        End If

    End Sub

    Private Sub findCus()
        Dim fName, Lname As String
        strSql = "Select * from tbCustomers Where Cus_Code = @pid "
        comm = New SqlCommand(strSql, Conn)
        comm.Parameters.AddWithValue("@pid", CusCode)
        DR = comm.ExecuteReader()
        If DR.HasRows Then
            DR.Read()
            fName = DR("Cus_Name")
            Lname = DR("Cus_Lname")
            CusId = DR("Cus_Id")
            lblNameCus.Text = fName + Space(2) + Lname
        End If
        DR.Close()
    End Sub

    Private Sub txtProId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProId.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call findProduct()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If btnCancel.Text = "ยกเลิก" Then
            btnNewBill.Text = "เปิดบิลเช่า"
            btnCancel.Text = "ออก"
            lblSalId.Text = ""
            lblSalDate.Text = ""
            lblSaleTotal.Text = ""
            lblNameCus.Text = ""
            lblSum.Text = "0"
            dgvDataHire.Rows.Clear()
            Panel1.Enabled = False
            gboDataHire.Enabled = False
        Else
            Me.Close()
        End If

    End Sub
    Private Sub txtAmount_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAmount.TextChanged
        total = (Val(lblPriceDay.Text) * Val(txtAmount.Text)) * Val(txtAmountDay.Text)
        lblSaleTotal.Text = total
    End Sub

    Private Sub txtAmountDay_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAmountDay.TextChanged
        DayAmountl = total * Val(txtAmountDay.Text)
        lblSaleTotal.Text = DayAmountl
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If dgvDataHire.RowCount = 0 Or dgvDataHire.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        Dim n As Integer = dgvDataHire.CurrentCell.RowIndex
        lblSum.Text = Val(lblSum.Text) - Val(dgvDataHire.Item(4, n).Value)
        dgvDataHire.Rows.RemoveAt(n)

    End Sub

    Private Sub btnBrows_Click(sender As System.Object, e As System.EventArgs) Handles btnBrows.Click
        Dim frmMySaleFindCars As New SelectCar
        sProID = ""
        frmMySaleFindCars.ShowDialog()
        If sProID <> "" Then
            txtProId.Text = sProID
            Call findProduct()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim frmMySaleBill As New frmSaleBill
        sSalID = lblSalId.Text
        frmMySaleBill.ShowDialog()
    End Sub

    Private Sub btnHOld_Click(sender As System.Object, e As System.EventArgs) Handles btnHOld.Click
        CusStatatus = 2
        Dim frmMySaleFindCus As New Customers
        CusCode = ""
        frmMySaleFindCus.ShowDialog()
        If CusCode <> "" Then
            Call findCus()
        End If
    End Sub

    Private Sub txtProId_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtProId.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint


    End Sub
End Class