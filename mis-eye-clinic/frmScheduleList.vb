Imports MySql.Data.MySqlClient
Public Class frmScheduleList


    Sub FillSchedule()
        DataGridView1.Rows.Clear()

        Dim no As Integer = 0
        con.Open()

        cm = New MySqlCommand("SELECT * FROM ec_schedule", con)
        dr = cm.ExecuteReader
        While dr.Read
            no += 1
            DataGridView1.Rows.Add(dr.Item("schedid").ToString, no, dr.Item("time_available").ToString, dr.Item("available").ToString)
        End While

        dr.Close()
        con.Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With frmScheduleCreate
            .btnAdd.Show()
            .btnUpdate.Hide()

            .ShowDialog()
        End With
    End Sub


End Class