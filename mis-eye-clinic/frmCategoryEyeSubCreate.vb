Imports MySql.Data.MySqlClient
Public Class frmCategoryEyeSubCreate
    Dim da As New MySqlDataAdapter
    Sub FillComboCategory()
        Try

            con.Open()
            Dim query = "SELECT * FROM ec_cateye ORDER BY catid"
            cm = New MySqlCommand(query, con)
            da.SelectCommand = cm

            da.Fill(dt)

            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "eye_name"
            ComboBox1.ValueMember = "catid"
            ComboBox1.Text = "Select a category"
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                Dim entry As Boolean = False
                con.Open()
                Dim validateEntry As String = "SELECT * FROM ec_catsub_eye WHERE sub_name LIKE '" & TXTSUB.Text & "'"
                cm = New MySqlCommand(validateEntry, con)
                dr = cm.ExecuteReader
                If dr.HasRows Then
                    entry = True
                End If
                dr.Close()
                con.Close()


                If entry = False Then
                    Dim query = "INSERT INTO ec_catsub_eye(catid, sub_name) VALUES (@catid, @sub_name)"
                    con.Open()
                    cm = New MySqlCommand(query, con)
                    cm.Parameters.AddWithValue("@sub_name", TXTSUB.Text)
                    cm.Parameters.AddWithValue("@catid", ComboBox1.SelectedValue)

                    cm.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Record has been successfully saved.", vbInformation)
                Else
                    MsgBox("Error! Duplicate Entry.", vbCritical)

                End If

                With frmCategoryEyeList
                    .FillSub()
                End With

                Clear()

                UserLog("Insert new Sub Category")

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
                Dim query = "UPDATE ec_catsub_eye SET sub_name= '" & TXTSUB.Text & "', catid= '" & ComboBox1.SelectedValue & "' WHERE scatid= '" & UIDLBL.Text & "'"
                cm = New MySqlCommand(query, con)
                cm.ExecuteNonQuery()
                con.Close()

                MsgBox("Record has been successfully updated.", vbInformation)
                With frmCategoryEyeList
                    .FillSub()
                End With
                Me.Dispose()
                dt.Clear()
                da.Dispose()

                UserLog("Modify Sub Category")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        dt.Clear()
        da.Dispose()
    End Sub

    Private Sub frmCategoryEyeSubCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FillComboCategory()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class