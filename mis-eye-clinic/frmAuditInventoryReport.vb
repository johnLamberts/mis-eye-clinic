Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmAuditInventoryReport
    Sub GetInventoryReport(ByVal query As String)


        Dim reportDs As New ReportDataSource

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\AuditInventoryReport.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet2

            Dim da As New MySqlDataAdapter

            con.Open()
            da.SelectCommand = New MySqlCommand(query, con)
            da.Fill(ds.Tables("inventory_report"))
            con.Close()

            'Dim salesDate As New ReportParameter("sdate", "Date (FROM - TO): " & sales_date1 & " - " & sales_date2)

            'ReportViewer1.LocalReport.SetParameters(salesDate)

            reportDs = New ReportDataSource("DataSet2", ds.Tables("inventory_report"))

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
        GetInventoryReport("SELECT * FROM inventory_report")

    End Sub


End Class