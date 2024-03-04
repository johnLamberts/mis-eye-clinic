Imports MySql.Data.MySqlClient

Public Class frmDiscount
    Private Sub TXTCAT_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                Dim query = "INSERT INTO ec_discount(description_discount, discount) VALUES (@description_discount, @discount)"
                cm = New MySqlCommand(query, con)

                With cm
                    .Parameters.AddWithValue("@description_discount", TXTDESC.Text)
                    .Parameters.AddWithValue("@discount", TXTDISC.Text)
                    .ExecuteNonQuery()
                End With
                con.Close()
                MsgBox("Record has been successfully saved.", vbInformation)

                With frmDiscountList
                    .FillDiscount()
                End With

                TXTDESC.Clear()

                TXTDISC.Clear()

                TXTDESC.Focus()

                UserLog("Insert and Add new Discount")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()

                Dim query = "UPDATE ec_discount SET description_discount= '" & TXTDESC.Text & "', discount='" & TXTDISC.Text & "' WHERE dis_id= '" & LBLDISID.Text & "'"

                cm = New MySqlCommand(query, con)

                cm.ExecuteNonQuery()

                con.Close()

                MsgBox("Record has been successfully updated.", vbInformation)

                With frmDiscountList
                    .FillDiscount()
                End With

                Me.Dispose()

                UserLog("Modify and Update Discount")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class