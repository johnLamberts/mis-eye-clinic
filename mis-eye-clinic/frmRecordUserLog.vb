Imports MySql.Data.MySqlClient

Public Class frmRecordUserLog


    Sub FillUserLog()
        DataGridView1.Rows.Clear()

        Dim no As Integer
        con.Open()

        Dim userReportQuery As String = "SELECT logid, CONCAT(firstName, ' ', lastName) as FullName, actions, date FROM ec_userlog JOIN ec_users USING(userid)"

        cm = New MySqlCommand(userReportQuery, con)

        dr = cm.ExecuteReader

        While dr.Read
            no += 1
            DataGridView2.Rows.Add(dr.Item("logid").ToString, no, dr.Item("FullName").ToString, dr.Item("actions").ToString, Format(CDate(dr.Item("date")), "MM/dd/yyyy"))
        End While

        dr.Close()

        con.Close()


    End Sub


End Class