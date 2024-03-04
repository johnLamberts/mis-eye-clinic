Imports MySql.Data.MySqlClient
Public Class frmClinicEyeReading



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            con.Open()

            Dim query = "INSERT INTO ec_read_eye(patientid, left_d, left_wg, left_pin, left_n, left_woutg, left_iop, right_d, right_wg, right_pin, right_n, right_woutg, right_iop, date_taken) VALUES(@patientid, @left_d, @left_wg, @left_pin, @left_n, @left_woutg, @left_iop, @right_d, @right_wg, @right_pin, @right_n, @right_woutg, @right_iop, @date_taken)"
            cm = New MySqlCommand(query, con)
            With cm.Parameters
                .Clear()
                .AddWithValue("@patientid", CBOPN.SelectedValue)
                .AddWithValue("@left_d", left_d.Text)
                .AddWithValue("@left_wg", left_wg.Value)
                .AddWithValue("@left_pin", left_pin.Value)
                .AddWithValue("@left_n", left_n.Text)
                .AddWithValue("@left_woutg", left_woutg.Value)
                .AddWithValue("@left_iop", left_iop.Value)

                .AddWithValue("@right_d", right_d.Text)
                .AddWithValue("@right_wg", right_wg.Value)
                .AddWithValue("@right_pin", right_pin.Value)
                .AddWithValue("@right_n", right_n.Text)
                .AddWithValue("@right_woutg", right_woutg.Value)
                .AddWithValue("@right_iop", right_iop.Value)
                .AddWithValue("@date_taken", DateTimePicker1.Value)


            End With

            cm.ExecuteNonQuery()

            con.Close()
            MsgBox("Eye Reading has been saved.", vbOKOnly + vbInformation)
            Me.Dispose()

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub FillPatients()
        Try
            con.Open()

            Dim patientQuery As String = "SELECT CONCAT(fname, ' ', lname) as FullName, patientid FROM ec_patients"
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
    Private Sub frmClinicEyeReading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillPatients()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class