Imports MySql.Data.MySqlClient
Public Class frmDiscountList

    Dim _idx, _disc As String
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With frmDiscount
            .btnAdd.Show()
            .btnUpdate.Hide()
            .ShowDialog()
        End With
    End Sub




    Sub FillDiscount()

        Try
            Dim id As Integer = 0

            DataGridView1.Rows.Clear()

            con.Open()

            cm = New MySqlCommand("SELECT * FROM ec_discount", con)
            dr = cm.ExecuteReader

            While dr.Read
                id += 1
                DataGridView1.Rows.Add(dr.Item("dis_id").ToString, id, dr.Item("description_discount").ToString, dr.Item("discount").ToString, "Modify", "Delete")
            End While

            dr.Close()

            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colName = "Modify" Then

            With frmDiscount

                .LBLDISID.Text = _idx
                .TXTDESC.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
                .TXTDISC.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
                .btnAdd.Hide()
                .btnUpdate.Show()
                .ShowDialog()

            End With

        ElseIf colName = "Delete" Then

            If (MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()

                Dim query = "DELETE FROM ec_discount WHERE dis_id='" & _idx & "'"

                cm = New MySqlCommand(query, con)

                cm.ExecuteNonQuery()

                con.Close()

                MsgBox("Record has been successfully deleted.", vbInformation)

                FillDiscount()

            End If
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

        Dim id As Integer = DataGridView1.CurrentRow.Index

        _idx = DataGridView1.Item(0, id).Value

    End Sub
End Class