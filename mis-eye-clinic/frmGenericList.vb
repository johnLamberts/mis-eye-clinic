Imports MySql.Data.MySqlClient


Public Class frmGenericList
    Dim _id, _genname As String
    Sub FillGeneric()
        Dim id As Integer = 0
        DataGridView1.Rows.Clear()
        con.Open()
        cm = New MySqlCommand("SELECT * FROM ec_generic", con)
        dr = cm.ExecuteReader
        While dr.Read
            id += 1
            DataGridView1.Rows.Add(dr.Item("genericid").ToString, id, dr.Item("genericname"), "Modify", "Delete")
        End While
        dr.Close()
        con.Close()
        LBLCOUNT.Text = "(" & DataGridView1.RowCount & ") record(s) found."
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With frmGenericCreate
            .btnAdd.Show()
            .btnUpdate.Hide()
            .ShowDialog()
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colName = "Modify" Then
            With frmGenericCreate
                .TXTGENERIC.Text = _genname
                .UIDLBL.Text = _id
                .ShowDialog()
            End With
        ElseIf colName = "Delete" Then
            If (MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                Dim query = "DELETE FROM ec_generic WHERE genericid='" & _id & "'"
                cm = New MySqlCommand(query, con)
                cm.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully deleted.", vbInformation)
                FillGeneric()
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim id As Integer = DataGridView1.CurrentRow.Index
        _id = DataGridView1.Item(0, id).Value
        _genname = DataGridView1.Item(2, id).Value
    End Sub


End Class