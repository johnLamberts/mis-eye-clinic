Imports MySql.Data.MySqlClient

Public Class frmGenericCreate
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                Dim entry As Boolean = False
                con.Open()
                Dim validateEntry As String = "SELECT * FROM ec_generic WHERE genericname LIKE '" & TXTGENERIC.Text & "'"
                cm = New MySqlCommand(validateEntry, con)
                dr = cm.ExecuteReader
                If dr.HasRows Then
                    entry = True
                End If
                dr.Close()
                con.Close()


                If entry = False Then
                    Dim query = "INSERT INTO ec_generic(genericname) VALUES (@genericname)"
                    con.Open()
                    cm = New MySqlCommand(query, con)
                    cm.Parameters.AddWithValue("@genericname", TXTGENERIC.Text.Trim())
                    cm.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Record has been successfully saved.", vbInformation)
                Else
                    MsgBox("Error! Duplicate Entry.", vbCritical)

                End If

                With frmGenericList
                    .FillGeneric()
                End With
                Clear()

                UserLog("Insert and Save Style")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub Clear()
        TXTGENERIC.Clear()
        TXTGENERIC.Focus()
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()

    End Sub

    Private Sub frmGenericCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                Dim query = "UPDATE ec_generic SET genericname= '" & TXTGENERIC.Text & "' WHERE genericid= '" & UIDLBL.Text & "'"
                cm = New MySqlCommand(query, con)
                cm.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully updated.", vbInformation)
                With frmGenericList
                    .FillGeneric()
                End With
                Me.Dispose()

                UserLog("Modify and Update Style")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class