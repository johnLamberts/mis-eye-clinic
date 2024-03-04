Imports MySql.Data.MySqlClient
Public Class frmCategoryEyeCreateForm1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                Dim entry As Boolean = False
                con.Open()
                Dim validateEntry As String = "SELECT * FROM ec_cateye WHERE eye_name LIKE '" & TXTSUB.Text & "'"
                cm = New MySqlCommand(validateEntry, con)
                dr = cm.ExecuteReader
                If dr.HasRows Then
                    entry = True
                End If
                dr.Close()
                con.Close()


                If entry = False Then
                    Dim query = "INSERT INTO ec_cateye(eye_name) VALUES (@eye_name)"
                    con.Open()
                    cm = New MySqlCommand(query, con)
                    cm.Parameters.AddWithValue("@eye_name", TXTSUB.Text.Trim())
                    cm.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Record has been successfully saved.", vbInformation)
                Else
                    MsgBox("Error! Duplicate Entry.", vbCritical)

                End If

                With frmCategoryEyeList
                    .FillCategoryEye()
                End With
                Clear()
                UserLog("Insert new Category")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Clear()
        TXTSUB.Clear()
        TXTSUB.Focus()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                Dim query = "UPDATE ec_cateye SET eye_name= '" & TXTSUB.Text & "' WHERE catid= '" & UIDLBL.Text & "'"
                cm = New MySqlCommand(query, con)
                cm.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully updated.", vbInformation)
                With frmCategoryEyeList
                    .FillCategoryEye()
                End With
                Me.Dispose()
                UserLog("Modify Category")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub frmCategoryEyeCreateForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class