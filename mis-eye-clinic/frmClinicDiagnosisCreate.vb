Imports MySql.Data.MySqlClient
Public Class frmClinicDiagnosisCreate

    Private Sub frmClinicDiagnosisCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FillTreatment()
        FillPatients()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Dispose()

    End Sub



    Sub FillPatients()
        Try
            con.Open()

            Dim patientQuery As String = "SELECT CONCAT(fname, ' ', lname) as FullName, patientid FROM ec_patients "
            cm = New MySqlCommand(patientQuery, con)
            Dim da As New MySqlDataAdapter(cm)
            Dim dt As New DataTable

            da.Fill(dt)

            CBOPN.DataSource = dt
            CBOPN.DisplayMember = "FullName"
            CBOPN.ValueMember = "patientid"

            con.Close()


        Catch ex As Exception
            con.Clone()
            MsgBox(ex.Message, vbCritical)
        End Try


    End Sub

    'Sub FillTreatment()
    '    Try
    '        con.Open()

    '        Dim patientQuery As String = "SELECT * FROM ec_treatment"
    '        cm = New MySqlCommand(patientQuery, con)
    '        Dim da As New MySqlDataAdapter(cm)
    '        Dim dt As New DataTable

    '        da.Fill(dt)

    '        CBOTREAT.DataSource = dt
    '        CBOTREAT.DisplayMember = "treatname"
    '        CBOTREAT.ValueMember = "treatid"

    '        con.Close()


    '    Catch ex As Exception
    '        con.Clone()
    '        MsgBox(ex.Message, vbCritical)
    '    End Try


    'End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then

                con.Open()

                Dim query = "INSERT INTO ec_diagnosis(patientid, eye, part, diagnosis,  date_taken) VALUES (@patientid, @eye, @part, @diagnosis,  @date_taken)"

                cm = New MySqlCommand(query, con)

                With cm.Parameters
                    .Clear()

                    .AddWithValue("@patientid", CBOPN.SelectedValue)
                    .AddWithValue("@eye", TXTEYE.Text)
                    .AddWithValue("@part", TXTPART.Text)
                    .AddWithValue("@diagnosis", TXTDIAGNOSIS.Text)

                    .AddWithValue("@date_taken", DateTimePicker1.Value)

                End With

                cm.ExecuteNonQuery()

                con.Close()

                MsgBox("Record has been successfully saved.", vbInformation)

                With frmClinicDiagnosis
                    .FillDiagnosis()
                End With

                UserLog("Insert new diagnosis record")

            End If
            Me.Dispose()

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub CBOPN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOPN.SelectedIndexChanged

    End Sub
End Class