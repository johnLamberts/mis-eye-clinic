Imports MySql.Data.MySqlClient
Public Class frmClinicPrescription
    Sub FillTreatment()

        DataGridView1.Rows.Clear()
        Dim nos As Integer = 0

        con.Open()
        Dim query = "SELECT * FROM ec_prescribed_treatment JOIN ec_patients USING(patientid) WHERE ec_prescribed_treatment.status='In Progress'"
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader

        While dr.Read
            nos += 1
            DataGridView1.Rows.Add(dr.Item("presid").ToString, nos, dr.Item("date_taken").ToString, dr.Item("patientid").ToString, dr.Item("fname").ToString & " - " & dr.Item("lname").ToString, dr.Item("treatment").ToString, dr.Item("status").ToString, "Change Status")
        End While

        dr.Close()
        con.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colname As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colname = "Treatment" Then

            With frmClinicChangeStatus
                con.Open()

                Dim query = "SELECT * FROM ec_prescribed_treatment JOIN ec_patients USING(patientid) WHERE presid='" & DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString & "'"
                cm = New MySqlCommand(query, con)
                dr = cm.ExecuteReader

                While dr.Read
                    .LBLID.Text = dr.Item("presid").ToString
                    .LBLPN.Text = dr.Item("fname").ToString & " - " & dr.Item("lname").ToString
                    .LBLPID.Text = dr.Item("patientid").ToString
                    .LBLTREATMENT.Text = dr.Item("treatment").ToString
                End While

                dr.Close()


                con.Close()

                con.Open()

                Dim selectQuery = "SELECT * FROM ec_treatment WHERE treatname='" & .LBLTREATMENT.Text & "'"
                cm = New MySqlCommand(selectQuery, con)
                dr = cm.ExecuteReader

                While dr.Read
                    .LBLPRICE.Text = dr.Item("treat_price").ToString

                End While

                dr.Close()

                con.Close()

                .ShowDialog()

            End With


        End If
    End Sub

    Private Sub frmClinicPrescription_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillTreatment()
    End Sub
End Class