Imports MySql.Data.MySqlClient
Public Class frmClassificationList
    Dim _idx, _catnamex As String
    Sub FillClassification()
        Dim id As Integer = 0
        DataGridView1.Rows.Clear()
        con.Open()
        cm = New MySqlCommand("SELECT * FROM ec_category", con)
        dr = cm.ExecuteReader
        While dr.Read
            id += 1
            DataGridView1.Rows.Add(dr.Item("catid").ToString, id, dr.Item("catname"), "Modify", "Delete")
        End While

        If dr.HasRows > 0 Then
            LBLCOUNT.Text = "(" & DataGridView1.RowCount & ") record(s) found."
        Else
            LBLCOUNT.Text = "No Records found."
        End If
        dr.Close()
        con.Close()
       
    End Sub

    Private Sub frmClassificationList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With frmClassification
            .btnAdd.Show()
            .btnUpdate.Hide()
            .ShowDialog()
        End With
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim id As Integer = DataGridView1.CurrentRow.Index
        _idx = DataGridView1.Item(0, id).Value
        _catnamex = DataGridView1.Item(2, id).Value
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub LBLCOUNT_Click(sender As Object, e As EventArgs) Handles LBLCOUNT.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colName = "Modify" Then
            With frmClassification
                .TXTCAT.Text = _catnamex
                .UIDLBL.Text = _idx
                .ShowDialog()
            End With
        ElseIf colName = "Delete" Then
            If (MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                Dim query = "DELETE FROM ec_category WHERE catid='" & _idx & "'"
                cm = New MySqlCommand(query, con)
                cm.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully deleted.", vbInformation)
                FillClassification()
            End If
        End If
    End Sub
End Class