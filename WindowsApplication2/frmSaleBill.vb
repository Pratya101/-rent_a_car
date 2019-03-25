Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class frmSaleBill
    Dim strConn As String = ConfigurationManager.ConnectionStrings("ProCarSale.My.MySettings.myCon").ConnectionString
    Dim strSql As String
    Dim Conn As SqlConnection = New SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet = New dtSale
    Dim myrpt As New MyBill
    Private Sub frmSaleBill_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If
        Conn.ConnectionString = strConn
        Conn.Open()
        strSql = "SELECT * FROM tbHire,tbHireDetail,tbCars,tbGen,tbCustomers where tbHireDetail.H_Id = tbHire.H_Id AND tbHireDetail.Cr_Id = tbCars.Cr_Id AND tbCars.gId = tbGen.gId AND tbHire.Cus_Id = tbCustomers.Cus_Id AND tbHire.H_Id = '" & sSalID & "'"
        da = New SqlDataAdapter(strSql, Conn)
        ds.Tables("dataSale").Clear()
        da.Fill(ds, "dataSale")
        myrpt.SetDataSource(ds.Tables("dataSale"))
        crvSaveBill.ReportSource = myrpt
        crvSaveBill.Show()
    End Sub
End Class