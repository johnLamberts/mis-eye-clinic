Imports MySql.Data.MySqlClient
Public Class frmServicesCreate

    Sub Clear()
        TXTSNAME.Clear()
        TXTPRICE.Clear()
        TXTSNAME.Focus()
        btnAdd.Enabled = True
        btnUpdate.Enabled = False
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                Dim entry As Boolean = False
                con.Open()
                Dim validateEntry As String = "SELECT * FROM ec_services WHERE service_name LIKE '" & TXTSNAME.Text & "'"
                cm = New MySqlCommand(validateEntry, con)
                dr = cm.ExecuteReader
                If dr.HasRows Then
                    entry = True
                End If
                dr.Close()
                con.Close()


                If entry = False Then
                    Dim query = "INSERT INTO ec_services(service_name, price) VALUES (@service_name, @price)"
                    con.Open()
                    cm = New MySqlCommand(query, con)
                    cm.Parameters.AddWithValue("@service_name", TXTSNAME.Text)
                    cm.Parameters.AddWithValue("@price", CDbl(TXTPRICE.Text))

                    cm.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Record has been successfully saved.", vbInformation)
                Else
                    MsgBox("Error! Duplicate Entry.", vbCritical)

                End If

                With frmBrandList
                    .FillBrand()
                End With
                Clear()

                UserLog("Modify and Save new Service")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                Dim query = "UPDATE ec_services SET service_name= '" & TXTSNAME.Text & "', price='" & CDbl(TXTPRICE.Text) & "' WHERE sid= '" & LBLSID.Text & "'"
                cm = New MySqlCommand(query, con)
                cm.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully updated.", vbInformation)
                With frmServices
                    .FillServices()
                End With
                Me.Dispose()

                UserLog("Insert and Save new Service")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class