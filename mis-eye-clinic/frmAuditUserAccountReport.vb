
Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmAuditUserAccountReport
    Private Sub frmAuditUserAccountReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub
    Sub GetUserReport(ByVal query As String)


        Dim reportDs As New ReportDataSource

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\UserReport.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1

            Dim da As New MySqlDataAdapter

            con.Open()
            da.SelectCommand = New MySqlCommand(query, con)
            da.Fill(ds.Tables("ec_users"))
            con.Close()

            'Dim salesDate As New ReportParameter("sdate", "Date (FROM - TO): " & DateTimePicker1.Value.ToString("yyyy-MM-dd") & " - " & DateTimePicker2.Value.ToString("yyyy-MM-dd"))

            'ReportViewer1.LocalReport.SetParameters(salesDate)

            reportDs = New ReportDataSource("DataSet1", ds.Tables("ec_users"))

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
        GetUserReport("SELECT * FROM ec_users")

    End Sub
End Class