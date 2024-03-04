Imports MySql.Data.MySqlClient

Public Class frmClassification


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                Dim query = "UPDATE ec_category SET catname= '" & TXTCAT.Text & "' WHERE catid= '" & UIDLBL.Text & "'"
                cm = New MySqlCommand(query, con)
                cm.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully updated.", vbInformation)
                With frmClassificationList
                    .FillClassification()
                End With
                Me.Dispose()
                UserLog("Modify Lenses")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                Dim query = "INSERT INTO ec_category(catname) VALUES ('" & TXTCAT.Text & "')"
                cm = New MySqlCommand(query, con)
                cm.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully saved.", vbInformation)
                With frmClassificationList
                    .FillClassification()
                End With
                TXTCAT.Clear()
                TXTCAT.Focus()

                UserLog("Add new Lenses")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmClassification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TXTCAT_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class