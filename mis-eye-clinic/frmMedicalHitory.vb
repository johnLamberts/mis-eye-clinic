Imports MySql.Data.MySqlClient
Public Class frmMedicalHitory
    Sub TreatmentRecords()
        Dim nos As Integer = 0
        Try
            con.Open()

            cm = New MySqlCommand("SELECT * FROM ec_prescribed_treatment JOIN ec_patients USING(patientid) WHERE ec_prescribed_treatment.patientid='" & LBLTREID.Text & "'", con)
            dr = cm.ExecuteReader

            While dr.Read
                nos += 1
                DataGridView1.Rows.Add(dr.Item("presid").ToString, nos, Format(CDate(dr.Item("date_taken")), "yyyy-MM-dd"), dr.Item("fname").ToString & Space(2) & dr.Item("lname").ToString, dr.Item("treatment").ToString, dr.Item("status").ToString)
            End While

            dr.Close()

            con.Close()


        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub EyeReading()
        Dim nos As Integer = 0
        Try
            con.Open()

            cm = New MySqlCommand("SELECT * FROM ec_read_eye WHERE patientid='" & LBLTREID.Text & "'", con)
            dr = cm.ExecuteReader

            While dr.Read
                nos += 1
                DataGridView2.Rows.Add(dr.Item("read_id").ToString, nos, dr.Item("left_d").ToString, dr.Item("left_wg").ToString, dr.Item("left_pin").ToString, dr.Item("left_n").ToString, dr.Item("left_woutg").ToString, dr.Item("left_iop").ToString, dr.Item("left_woutg").ToString, dr.Item("right_d").ToString, dr.Item("right_wg").ToString, dr.Item("right_pin").ToString, dr.Item("right_n").ToString, dr.Item("right_woutg").ToString, dr.Item("right_iop").ToString, Format(CDate(dr.Item("date_taken")), "yyyy-MM-dd"))
            End While

            dr.Close()

            con.Close()


        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub frmMedicalHitory_Load(sender As Object, e As EventArgs) Handles Me.Load
        TreatmentRecords()
        EyeReading()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub
End Class