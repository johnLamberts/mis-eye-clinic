Imports MySql.Data.MySqlClient
Public Class frmClinicDiagnosis
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName = DataGridView1.Columns(e.ColumnIndex).Name

        If colName = "Treatment" Then
            With frmClinicMakeTreatment
                con.Open()

                Dim query = "SELECT * FROM ec_diagnosis JOIN ec_patients USING(patientid) WHERE diagnosisid='" & DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString & "'"
                cm = New MySqlCommand(query, con)
                dr = cm.ExecuteReader

                While dr.Read
                    .LBLID.Text = dr.Item("diagnosisid").ToString
                    .LBLDIAGNOSIS.Text = dr.Item("diagnosis").ToString
                    .LBLEYE.Text = dr.Item("eye").ToString
                    .LBLPART.Text = dr.Item("part").ToString
                    .LBLDIAGNOSIS.Text = dr.Item("diagnosis").ToString
                    .LBLPN.Text = dr.Item("fname").ToString & "-" & dr.Item("lname").ToString
                    .LBLPID.Text = dr.Item("patientid")
                End While

                dr.Close()


                con.Close()
                .ShowDialog()
            End With
        End If
    End Sub

    Sub FillDiagnosis()

        DataGridView1.Rows.Clear()
        Dim nos As Integer = 0

        con.Open()
        Dim query = "SELECT * FROM ec_diagnosis ed JOIN ec_patients USING(patientid) WHERE ed.status='Ready'"
        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader

        While dr.Read
            nos += 1
            DataGridView1.Rows.Add(dr.Item("diagnosisid").ToString, nos, dr.Item("fname").ToString & " " & dr.Item("lname").ToString, dr.Item("eye").ToString, dr.Item("part").ToString, dr.Item("diagnosis").ToString, dr.Item("status").ToString, dr.Item("date_taken").ToString, "Add Treatment")
        End While

        dr.Close()
        con.Close()

    End Sub

    Private Sub frmClinicDiagnosis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        FillDiagnosis()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With frmClinicGlassPrescription
            .btnAdd.Show()
            .btnUpdate.Hide()
            .ShowDialog()

        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With frmClinicEyeReading
            .btnAdd.Show()
            .btnUpdate.Hide()
            .ShowDialog()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With frmClinicDiagnosisCreate
            .ShowDialog()
        End With
    End Sub
End Class