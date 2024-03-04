Imports MySql.Data.MySqlClient


Public Class frmClinicChangeStatus
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Dispose()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            con.Open()

            Dim insertQuery = "INSERT INTO ec_billing_operations(patientid, treatment, unit_price, status, date_pay) SELECT @patientid, @treatment, @unit_price, @status, @date_taken FROM ec_prescribed_treatment WHERE presid='" & LBLID.Text & "'"
            cm = New MySqlCommand(insertQuery, con)

            With cm.Parameters
                .AddWithValue("@patientid", LBLPID.Text)
                .AddWithValue("@treatment", LBLTREATMENT.Text)
                .AddWithValue("@unit_price", LBLPRICE.Text)
                .AddWithValue("@status", "Pending")
                .AddWithValue("@date_taken", Now.ToString("yyyy-MM-dd"))

            End With
            cm.ExecuteNonQuery()


            con.Close()

            con.Open()

            Dim updateQ = "UPDATE ec_prescribed_treatment SET status='Completed' WHERE presid='" & LBLID.Text & "'"
            cm = New MySqlCommand(updateQ, con)

            cm.ExecuteNonQuery()


            con.Close()

            MsgBox("Status Changed", vbOKOnly + vbInformation)
            Me.Dispose()

            With frmClinicPrescription
                .FillTreatment()
            End With

            Me.Dispose()

        Catch ex As Exception
            con.Close()


            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Private Sub LBLTREATMENT_TextChanged(sender As Object, e As EventArgs) Handles LBLTREATMENT.TextChanged

    End Sub
End Class