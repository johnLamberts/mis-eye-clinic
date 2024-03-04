Imports MySql.Data.MySqlClient

Public Class frmScheduleCreate
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim date_sched As String = DateTimePicker1.Value.ToString("hh:mm")

            con.Open()

            cm = New MySqlCommand("INSERT INTO ec_schedule(time_available, slots_avalaible) VALUES(@time_available, @slots_avalaible)", con)

            With cm
                .Parameters.Clear()
                .Parameters.AddWithValue("@time_available", date_sched)
                .Parameters.AddWithValue("@slots_avalaible", NumericUpDown1.Value)
                cm.ExecuteNonQuery()
            End With
            MsgBox("Record has been saved.", vbOKOnly + vbInformation)

            con.Close()

            With frmScheduleList
                .FillSchedule()
            End With

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub frmScheduleCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class