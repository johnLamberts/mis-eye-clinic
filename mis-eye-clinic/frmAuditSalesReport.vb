
Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmAuditSalesReport

    Dim sales_date1, sales_date2 As String
    Private Sub frmAuditSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Sub GetSalesReport(ByVal query As String)


        Dim reportDs As New ReportDataSource

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\AuditSalesReport.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1

            Dim da As New MySqlDataAdapter

            con.Open()
            da.SelectCommand = New MySqlCommand(query, con)
            da.Fill(ds.Tables("ec_sales"))
            con.Close()

            Dim salesDate As New ReportParameter("sdate", "Date (FROM - TO): " & DateTimePicker1.Value.ToString("yyyy-MM-dd") & " - " & DateTimePicker2.Value.ToString("yyyy-MM-dd"))

            ReportViewer1.LocalReport.SetParameters(salesDate)

            reportDs = New ReportDataSource("DataSet1", ds.Tables("ec_sales"))

            ReportViewer1.LocalReport.DataSources.Add(reportDs)

            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.FullPage
            ReportViewer1.ZoomPercent = 30

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ReportViewer1.RefreshReport()
        GetSalesReport("SELECT * FROM ec_sales WHERE sales_date BETWEEN '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' AND '" & DateTimePicker2.Value.ToString("yyyy-MM-dd") & "'")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        If TabControl1.SelectedIndex = 1 Then
            With frmAuditStockReport
                .TopLevel = False
                Panel2.Controls.Add(frmAuditStockReport)
                .BringToFront()
                .Show()
            End With

        ElseIf TabControl1.SelectedIndex = 2 Then
            With frmAuditInventoryReport
                .TopLevel = False
                Panel3.Controls.Add(frmAuditInventoryReport)
                .BringToFront()
                .Show()
            End With

        ElseIf TabControl1.SelectedIndex = 3 Then
            With frmAuditUserAccountReport
                .TopLevel = False
                userAccPanel.Controls.Add(frmAuditUserAccountReport)
                .BringToFront()
                .Show()
            End With

        ElseIf TabControl1.SelectedIndex = 4 Then
            With frmAuditServiceReport
                .TopLevel = False
                servicePanel.Controls.Add(frmAuditServiceReport)
                .BringToFront()
                .Show()
            End With
        End If
    End Sub
End Class