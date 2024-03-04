Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmUsersCreate
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Dispose()

    End Sub

    Sub Clear()
        TXTFIRSTNAME.Clear()
        TXTLASTNAME.Clear()
        TXTAGE.Clear()
        TXTPHONE.Clear()
        PictureBox1.BackgroundImage = Nothing
        CMBPERMISSION.SelectedIndex = -1
        CMBSTATUS.SelectedIndex = -1
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using odf As New OpenFileDialog With {.Filter = "(Image.Files)|*.jpg;*.png;*.jpeg; *.jpeg|*.jpg|*.png",
                               .Multiselect = False, .Title = "Select Image"}
            If odf.ShowDialog = 1 Then
                PictureBox1.BackgroundImage = Image.FromFile(odf.FileName)
            End If
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()

    End Sub


    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            Dim mainstream As New MemoryStream
            PictureBox1.BackgroundImage.Save(mainstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mainstream.GetBuffer

            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                Dim insertQuery As String = "UPDATE ec_users SET userimg=@userimg, firstName=@firstName, lastName=@lastName, phone_no=@phone_no, age=@age, permission=@permission, status=@status WHERE userid=@userid"
                cm = New MySqlCommand(insertQuery, con)
                With cm
                    .Parameters.AddWithValue("@userid", LBLUID.Text)
                    .Parameters.AddWithValue("@userimg", arrImage)
                    .Parameters.AddWithValue("@firstName", TXTFIRSTNAME.Text)
                    .Parameters.AddWithValue("@lastName", TXTLASTNAME.Text)
                    .Parameters.AddWithValue("@phone_no", TXTPHONE.Text)
                    .Parameters.AddWithValue("@age", TXTAGE.Text)
                    .Parameters.AddWithValue("@permission", CMBPERMISSION.SelectedItem)
                    .Parameters.AddWithValue("@status", CMBSTATUS.SelectedItem)
                    .ExecuteNonQuery()

                End With


                MsgBox("Record has been successfully saved.", vbInformation)
                con.Close()
                Clear()

                With frmUsers
                    .FillUsers()
                End With

                Me.Dispose()
                UserLog("Modify and Update new Service")

            End If

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim arrImage() As Byte


        Try

            If PictureBox1.BackgroundImage Is Nothing Then
                MsgBox("WARNING: You're required to put an image!", vbInformation)
            Else


                Dim mainstream As New MemoryStream

                PictureBox1.BackgroundImage.Save(mainstream, System.Drawing.Imaging.ImageFormat.Jpeg)

                arrImage = mainstream.GetBuffer

                con.Open()
                Dim insertQuery As String = "INSERT INTO ec_users(userimg, firstName, lastName, phone_no, age, permission, status) VALUES (@userimg, @firstName, @lastName, @phone_no, @age, @permission, @status)"
                cm = New MySqlCommand(insertQuery, con)
                With cm
                    .Parameters.AddWithValue("@userimg", arrImage)
                    .Parameters.AddWithValue("@firstName", TXTFIRSTNAME.Text)
                    .Parameters.AddWithValue("@lastName", TXTLASTNAME.Text)
                    .Parameters.AddWithValue("@phone_no", TXTPHONE.Text)
                    .Parameters.AddWithValue("@age", TXTAGE.Text)
                    .Parameters.AddWithValue("@permission", CMBPERMISSION.SelectedItem)
                    .Parameters.AddWithValue("@status", CMBSTATUS.SelectedItem)
                    .ExecuteNonQuery()

                End With

                MsgBox("Record has been successfully saved.", vbInformation)
                con.Close()
                Clear()

                With frmUsers
                    .FillUsers()
                End With

                UserLog("Insert and Save new Service")

            End If



        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class