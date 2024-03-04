Imports MySql.Data.MySqlClient
Public Class frmClinicAptView
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()

    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        With frmClinicEyeReading
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = DataGridView2.Rows(e.RowIndex)
            End If
            .ShowDialog()
        End With
    End Sub


    Sub EyeReading()
        Dim nos As Integer = 0
        Try
            con.Open()

            cm = New MySqlCommand("SELECT * FROM ec_read_eye WHERE patientid='" & LBLPID.Text & "'", con)
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


End Class