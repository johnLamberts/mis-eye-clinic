
Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmAuditServiceReport

    Sub ServiceReport(ByVal query As String)


        Dim reportDs As New ReportDataSource

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\ServiceReport.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1

            Dim da As New MySqlDataAdapter

            con.Open()
            da.SelectCommand = New MySqlCommand(query, con)
            da.Fill(ds.Tables("ec_services"))
            con.Close()

            'Dim salesDate As New ReportParameter("sdate", "Date (FROM - TO): " & DateTimePicker1.Value.ToString("yyyy-MM-dd") & " - " & DateTimePicker2.Value.ToString("yyyy-MM-dd"))

            'ReportViewer1.LocalReport.SetParameters(salesDate)

            reportDs = New ReportDataSource("DataSet1", ds.Tables("ec_services"))

            ReportViewer1.LocalReport.DataSources.Add(reportDs)

            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.FullPage
            ReportViewer1.ZoomPercent = 30

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ReportViewer1.RefreshReport()
        ServiceReport("SELECT appt_refno, CONCAT(fname, ' ', lname) as patient_name, es.service_name, price FROM ec_billing_services es INNER JOIN ec_appointment ea ON ea.appt_id=es.appt_id INNER JOIN ec_patients ep ON ep.patientid=es.patientid WHERE es.status='Paid'")
    End Sub
End Class