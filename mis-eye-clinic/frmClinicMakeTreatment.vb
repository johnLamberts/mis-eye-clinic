Imports MySql.Data.MySqlClient
Public Class frmClinicMakeTreatment
    Private Sub CBOTREATMENT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOTREATMENT.SelectedIndexChanged
        Try
            con.Open()

            Dim patientQuery As String = "SELECT treat_price FROM ec_treatment WHERE treatname='" & CBOTREATMENT.Text & "'"
            cm = New MySqlCommand(patientQuery, con)

            dr = cm.ExecuteReader

            While dr.Read
                LBLPRICE.Text = dr.Item("treat_price")
            End While
            'Dim da As New MySqlDataAdapter(cm)
            'Dim dt As New DataTable

            'da.Fill(dt)

            'CBOTREATMENT.DataSource = dt
            'CBOTREATMENT.DisplayMember = "treatname"
            'CBOTREATMENT.ValueMember = "treatid"

            dr.Close()
            con.Close()


        Catch ex As Exception
            con.Clone()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            Dim query = "INSERT INTO ec_prescribed_treatment(date_taken, patientid, treatment, status) VALUES (@date_taken, @patientid, @treatment, @status)"

            con.Open()

            cm = New MySqlCommand(query, con)

            With cm.Parameters
                .AddWithValue("@date_taken", DateTimePicker1.Value)
                .AddWithValue("@patientid", LBLPID.Text)
                .AddWithValue("@treatment", CBOTREATMENT.Text)
                .AddWithValue("@status", "In Progress")
            End With

            cm.ExecuteNonQuery()

            con.Close()


            con.Open()
            Dim updateQuery = "UPDATE ec_diagnosis SET status='On going Treatment' WHERE diagnosisid='" & LBLID.Text & "'"
            cm = New MySqlCommand(updateQuery, con)
            cm.ExecuteNonQuery()

            con.Close()



            With frmClinicDiagnosis
                .FillDiagnosis()
            End With


            MsgBox("Treatment has been made", vbOKOnly + vbInformation)
            Me.Dispose()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub FillTreatment()
        Try
            con.Open()

            Dim patientQuery As String = "SELECT * FROM ec_treatment"
            cm = New MySqlCommand(patientQuery, con)

            dr = cm.ExecuteReader

            While dr.Read
                CBOTREATMENT.Items.Add(dr.Item("treatname").ToString)
            End While
            dr.Close()
            con.Close()


        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Dispose()
    End Sub

    Private Sub frmClinicMakeTreatment_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillTreatment()
    End Sub

    Private Sub LBLPRICE_Click(sender As Object, e As EventArgs) Handles LBLPRICE.Click
    End Sub


End Class