Imports MySql.Data.MySqlClient
Public Class frmClinicDelayAppointment


    Sub FillDelayAppointment()

        Dim nos As Integer = 0
        Try
            con.Open()

            cm = New MySqlCommand("UPDATE ec_appointment SET status='Delay' WHERE appt_day < CURDATE()", con)
            cm.ExecuteNonQuery()

            con.Close()

            con.Open()

            cm = New MySqlCommand("SELECT * FROM ec_appointment ea JOIN ec_schedule USING(schedid) JOIN ec_patients USING(patientid) WHERE ea.status='Delay' AND appt_day < '" & DateTime.Now.ToString("yyyy-MM-dd") & "'", con)
            dr = cm.ExecuteReader

            While dr.Read
                nos += 1
                DataGridView1.Rows.Add(dr.Item("appt_id").ToString, nos, dr.Item("appt_refno").ToString, dr.Item("appt_type").ToString, dr.Item("fname").ToString & dr.Item("lname").ToString, dr.Item("time_available").ToString, Format(CDate(dr.Item("appt_day").ToString), "yyyy-MM-dd"), dr.Item("status").ToString)

            End While

            dr.Close()

            con.Close()





        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()

    End Sub
End Class