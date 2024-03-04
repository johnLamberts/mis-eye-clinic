Imports MySql.Data.MySqlClient

Public Class frmTypeCreate
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                Dim entry As Boolean = False
                con.Open()
                Dim validateEntry As String = "SELECT * FROM ec_type WHERE typename LIKE '" & TXTTYPE.Text & "'"
                cm = New MySqlCommand(validateEntry, con)
                dr = cm.ExecuteReader
                If dr.HasRows Then
                    entry = True
                End If
                dr.Close()
                con.Close()


                If entry = False Then
                    Dim query = "INSERT INTO ec_type(typename) VALUES (@typename)"
                    con.Open()
                    cm = New MySqlCommand(query, con)
                    cm.Parameters.AddWithValue("@typename", TXTTYPE.Text.Trim())
                    cm.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Record has been successfully saved.", vbInformation)
                Else
                    MsgBox("Error! Duplicate Entry.", vbCritical)

                End If

                With frmTypeList
                    .FillType()
                End With
                Clear()
                UserLog("Insert and Save new Type")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Clear()
        TXTTYPE.Clear()
        TXTTYPE.Focus()
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                Dim query = "UPDATE ec_type SET typename= '" & TXTTYPE.Text & "' WHERE typeid= '" & UIDLBL.Text & "'"
                cm = New MySqlCommand(query, con)
                cm.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully updated.", vbInformation)
                With frmTypeList
                    .FillType()
                End With
                Me.Dispose()

                UserLog("Modify and Update new Service")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class