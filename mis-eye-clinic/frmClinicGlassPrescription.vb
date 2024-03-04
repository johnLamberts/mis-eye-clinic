Imports MySql.Data.MySqlClient
Public Class frmClinicGlassPrescription
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()

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
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim insertQuery As String = "INSERT INTO ec_glass_prescription(l_ds, l_da, l_dc,  l_ns ,  l_na ,  l_nc ,  r_ds ,  r_da ,  r_dc ,  r_ns ,  r_na ,  r_nc ,  date_taken , pid) VALUES 
(@l_ds, @l_da, @l_dc,  @l_ns ,  @l_na ,  @l_nc ,  @r_ds , 
@r_da , @r_dc ,  @r_ns ,  @r_na , @r_nc,  @date_taken , @pid)"
        con.Open()

        cm = New MySqlCommand(insertQuery, con)

        With cm.Parameters
            .AddWithValue("@l_ds", l_ds.Value)
            .AddWithValue("@l_da", l_da.Value)
            .AddWithValue("@l_dc", l_dc.Value)
            .AddWithValue("@l_ns", l_ns.Value)
            .AddWithValue("@l_na", l_na.Value)
            .AddWithValue("@l_nc", l_nc.Value)
            .AddWithValue("@r_ds", r_ds.Value)
            .AddWithValue("@r_da", r_da.Value)
            .AddWithValue("@r_dc", r_dc.Value)

            .AddWithValue("@r_ns", r_ns.Value)
            .AddWithValue("@r_na", r_na.Value)
            .AddWithValue("@r_nc", r_nc.Value)
            .AddWithValue("@date_taken", DateTimePicker1.Value.ToString("yyyy-MM-dd"))
            .AddWithValue("@pid", CBOPN.SelectedValue)

        End With

        cm.ExecuteNonQuery()
        MsgBox("Eye Glass prescription has been saved.", vbOKOnly + vbInformation)


        con.Close()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub frmClinicGlassPrescription_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillPatients()

    End Sub
End Class