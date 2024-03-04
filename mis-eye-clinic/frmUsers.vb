
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmUsers
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With frmUsersCreate
            .btnSave.Show()
            .btnUpdate.Hide()
            .ShowDialog()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With frmUsersCredential
            .btnSave.Show()
            .btnUpdate.Hide()
            .ShowDialog()
        End With
    End Sub

    Sub FillUsers()
        Dim nos As Integer = 0
        DataGridView1.Rows.Clear()
        con.Open()
        Dim getProductQuery As String = "SELECT * FROM ec_users"
        cm = New MySqlCommand(getProductQuery, con)
        dr = cm.ExecuteReader

        While dr.Read
            nos += 1
            DataGridView1.Rows.Add(nos, dr.Item("userid"), dr.Item("userimg"), dr.Item("firstName"), dr.Item("lastName"), dr.Item("phone_no"), dr.Item("age"), dr.Item("permission"), dr.Item("status"), "Modify", "Delete")
        End While
        LBLCOUNT.Text = "(" & DataGridView1.RowCount & ") record(s) found."
        dr.Close()
        con.Close()


        For i = 0 To DataGridView1.Rows.Count - 1
            Dim row As DataGridViewRow = DataGridView1.Rows(i)
            row.Height = 100
        Next

        Dim imagecol = DirectCast(DataGridView1.Columns("userimg"), DataGridViewImageColumn)
        imagecol.ImageLayout = DataGridViewImageCellLayout.Stretch
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colName = "Modify" Then
            With frmUsersCreate

                con.Open()

                Dim getImageQuery As String = "SELECT userimg FROM ec_users WHERE userid='" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'"
                cm = New MySqlCommand(getImageQuery, con)

                dr = cm.ExecuteReader

                While dr.Read
                    Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
                    Dim array(CInt(len)) As Byte
                    dr.GetBytes(0, 0, array, 0, CInt(len))
                    Dim ms As New MemoryStream(array)
                    Dim bitmap As New System.Drawing.Bitmap(ms)
                    .PictureBox1.BackgroundImage = bitmap

                End While
                .LBLUID.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .TXTFIRSTNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .TXTLASTNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .TXTPHONE.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                .TXTAGE.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                .CMBPERMISSION.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
                .CMBSTATUS.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
                dr.Close()
                con.Close()

                .LBLLBLID.Show()
                .LBLUID.Show()
                .btnSave.Hide()
                .btnUpdate.Show()
                .ShowDialog()

            End With
        ElseIf colName = "Delete" Then
            If (MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                Dim query = "DELETE FROM ec_users WHERE userid='" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'"
                cm = New MySqlCommand(query, con)
                cm.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully deleted.", vbInformation)
                FillUsers()
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class