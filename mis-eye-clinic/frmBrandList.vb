Imports MySql.Data.MySqlClient
Public Class frmBrandList
    Dim _idx, _brandnamex As String

    Sub FillBrand()
        Dim id As Integer = 0
        DataGridView1.Rows.Clear()
        con.Open()
        cm = New MySqlCommand("SELECT * FROM ec_brand", con)
        dr = cm.ExecuteReader
        While dr.Read
            id += 1
            DataGridView1.Rows.Add(dr.Item("brandid").ToString, id, dr.Item("brandname"), "Modify", "Delete")
        End While
        dr.Close()
        con.Close()
        LBLCOUNT.Text = "(" & DataGridView1.RowCount & ") record(s) found."
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With frmBrandCreate
            .btnUpdate.Hide()
            .btnAdd.Show()
            .ShowDialog()
        End With
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colName = "Modify" Then
            With frmBrandCreate
                .btnAdd.Hide()
                .btnUpdate.Show()
                .TXTBRAND.Text = _brandnamex
                .UIDLBL.Text = _idx
                .ShowDialog()
            End With
        ElseIf colName = "Delete" Then
            If (MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                Dim query = "DELETE FROM ec_brand WHERE brandid='" & _idx & "'"
                cm = New MySqlCommand(query, con)
                cm.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully deleted.", vbInformation)
                FillBrand()
            End If
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim id As Integer = DataGridView1.CurrentRow.Index
        _idx = DataGridView1.Item(0, id).Value
        _brandnamex = DataGridView1.Item(2, id).Value
    End Sub
End Class