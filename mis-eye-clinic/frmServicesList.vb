Imports MySql.Data.MySqlClient
Public Class frmServicesList
    Private Sub frmServicesList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreatmentRecords()
    End Sub

    Sub TreatmentRecords()
        Dim nos As Integer = 0
        Try
            con.Open()

            cm = New MySqlCommand("SELECT * FROM ec_billing_services JOIN ec_patients USING(patientid) WHERE ec_billing_services.patientid='" & LBLTREID.Text & "'", con)
            dr = cm.ExecuteReader

            While dr.Read
                nos += 1
                DataGridView1.Rows.Add(dr.Item("billid").ToString, nos, dr.Item("fname").ToString & Space(2) & dr.Item("lname").ToString, dr.Item("service_name").ToString)
            End While

            dr.Close()

            con.Close()


        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class