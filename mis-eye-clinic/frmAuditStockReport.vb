Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmAuditStockReport

    Dim stock_date1 As String
    Dim stock_date2 As String

    Private Sub frmAuditStockReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Sub GetStockReport(ByVal query As String)


        Dim reportDs As New ReportDataSource

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\AuditStockReport.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1

            Dim da As New MySqlDataAdapter

            con.Open()
            da.SelectCommand = New MySqlCommand(query, con)
            da.Fill(ds.Tables("ec_stockin"))
            con.Close()

            'Dim salesDate As New ReportParameter("sdate", "Date (FROM - TO): " & sales_date1 & " - " & sales_date2)

            'ReportViewer1.LocalReport.SetParameters(salesDate)

            reportDs = New ReportDataSource("DataSet1", ds.Tables("ec_stockin"))

            ReportViewer1.LocalReport.DataSources.Add(reportDs)

            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 30

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ReportViewer1.RefreshReport()
        GetStockReport("SELECT * FROM ec_stockin s JOIN ec_products p USING(productid) JOIN ec_brand USING(brandid) JOIN ec_generic USING(genericid) JOIN ec_category USING(catid) JOIN ec_type USING(typeid) WHERE p.quantity > 0 AND s.date BETWEEN '" & DTP1.Value.ToString("yyyy-MM-dd") & "' AND '" & DTP2.Value.ToString("yyyy-MM-dd") & "'")

    End Sub
End Class