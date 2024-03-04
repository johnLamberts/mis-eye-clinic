Imports MySql.Data.MySqlClient
Public Class frmTreatmentCreate


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                Dim query = "UPDATE ec_treatment SET treatname= '" & TXTTREAT.Text & "', treat_price='" & NumericUpDown1.Value & "' WHERE treatid= '" & UIDLBL.Text & "'"
                cm = New MySqlCommand(query, con)
                cm.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully updated.", vbInformation)
                With frmTreatmentList
                    .FillTreatment()
                End With
                Me.Dispose()

                UserLog("Modify Treatment")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                Dim entry As Boolean = False

                con.Open()

                Dim validateEntry As String = "SELECT * FROM ec_treatment WHERE treatname LIKE '" & TXTTREAT.Text & "'"

                cm = New MySqlCommand(validateEntry, con)

                dr = cm.ExecuteReader

                If dr.HasRows Then
                    entry = True

                End If

                dr.Close()

                con.Close()


                If entry = False Then
                    Dim query = "INSERT INTO ec_treatment(treatname, treat_price) VALUES (@treatname, @treat_price)"
                    con.Open()
                    cm = New MySqlCommand(query, con)
                    cm.Parameters.AddWithValue("@treatname", TXTTREAT.Text)
                    cm.Parameters.AddWithValue("@treat_price", NumericUpDown1.Value)
                    cm.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Record has been successfully saved.", vbInformation)
                Else
                    MsgBox("Error! Duplicate Entry.", vbCritical)

                End If

                With frmTreatmentList
                    .FillTreatment()
                End With
                Clear()

                UserLog("Insert new brand record")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Clear()
        TXTTREAT.Clear()
        NumericUpDown1.Value = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class