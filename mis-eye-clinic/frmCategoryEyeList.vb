Imports MySql.Data.MySqlClient
Public Class frmCategoryEyeList

    Dim _id1, _catname, _id2, _subcat, _catname2 As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With frmCategoryEyeSubCreate
            .btnAdd.Show()
            .btnUpdate.Hide()
            .ShowDialog()
        End With
    End Sub

    Sub FillSub()
        Dim id As Integer = 0
        DataGridView3.Rows.Clear()
        con.Open()
        cm = New MySqlCommand("SELECT * FROM ec_catsub_eye JOIN ec_cateye USING(catid)", con)
        dr = cm.ExecuteReader
        While dr.Read
            id += 1
            DataGridView3.Rows.Add(dr.Item("scatid").ToString, id, dr.Item("eye_name").ToString, dr.Item("sub_name").ToString, "Modify", "Delete")
        End While
        dr.Close()
        con.Close()
        'LBLCOUNT.Text = "(" & DataGridView3.RowCount & ") record(s) found."
    End Sub

    Sub FillCategoryEye()
        Dim id As Integer = 0
        DataGridView2.Rows.Clear()
        con.Open()
        cm = New MySqlCommand("SELECT * FROM ec_cateye", con)
        dr = cm.ExecuteReader
        While dr.Read
            id += 1
            DataGridView2.Rows.Add(dr.Item("catid").ToString, id, dr.Item("eye_name"), "Modify", "Delete")
        End While
        dr.Close()
        con.Close()
        'LBLCOUNT.Text = "(" & DataGridView3.RowCount & ") record(s) found."
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With frmCategoryEyeCreateForm1
            .btnAdd.Show()
            .btnUpdate.Hide()
            .ShowDialog()
        End With
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim colName As String = DataGridView2.Columns(e.ColumnIndex).Name

        If colName = "Edit" Then
            With frmCategoryEyeCreateForm1
                .TXTSUB.Text = _catname
                .UIDLBL.Text = _id1
                .ShowDialog()
            End With
        ElseIf colName = "Deduct" Then
            If (MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                Dim query = "DELETE FROM  ec_cateye WHERE catid='" & _id1 & "'"
                cm = New MySqlCommand(query, con)
                cm.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully deleted.", vbInformation)
                FillCategoryEye()
            End If
        End If
    End Sub

    Private Sub frmCategoryEyeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Dim colName As String = DataGridView3.Columns(e.ColumnIndex).Name

        If colName = "Modify" Then
            With frmCategoryEyeSubCreate
                .TXTSUB.Text = _subcat
                .ComboBox1.Text = _catname2
                .UIDLBL.Text = _id2
                .ShowDialog()
            End With
        ElseIf colName = "Delete" Then
            If (MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                Dim query = "DELETE FROM  ec_catsub_eye WHERE scatid='" & _id2 & "'"
                cm = New MySqlCommand(query, con)
                cm.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully deleted.", vbInformation)
                FillSub()
            End If
        End If
    End Sub

    Private Sub DataGridView3_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView3.SelectionChanged
        Dim id As Integer = DataGridView3.CurrentRow.Index
        _id2 = DataGridView3.Item(0, id).Value
        _catname2 = DataGridView3.Item(2, id).Value
        _subcat = DataGridView3.Item(3, id).Value
    End Sub

    Private Sub DataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView2.SelectionChanged
        Dim id As Integer = DataGridView2.CurrentRow.Index
        _id1 = DataGridView2.Item(0, id).Value
        _catname = DataGridView2.Item(2, id).Value
    End Sub
End Class