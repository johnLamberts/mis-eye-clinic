Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmPatientGeneralInfo
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim arrImage() As Byte


        Try

            If PictureBox1.BackgroundImage Is Nothing Then
                MsgBox("WARNING: You're required to put an image!", vbInformation)
            Else


                Dim mainstream As New MemoryStream

                PictureBox1.BackgroundImage.Save(mainstream, System.Drawing.Imaging.ImageFormat.Jpeg)

                arrImage = mainstream.GetBuffer

                con.Open()
                Dim insertQuery As String = "UPDATE ec_patients SET p_img=@p_img, fname=@fname, mname=@mname, lname=@lname, p_number=@p_number, age=@age, gender=@gender, email_address=@email_address, dob=@dob, marital_status=@marital_status, street=@street, brgy=@brgy, municipal=@municipal, city=@city, postal_code=@postal_code WHERE patientid='" & LBLCPID.Text & "'"
                cm = New MySqlCommand(insertQuery, con)
                With cm
                    .Parameters.AddWithValue("@p_img", arrImage)
                    .Parameters.AddWithValue("@fname", TXTFIRSTNAME.Text)
                    .Parameters.AddWithValue("@mname", TXTMN.Text)
                    .Parameters.AddWithValue("@lname", TXTLASTNAME.Text)
                    .Parameters.AddWithValue("@p_number", TXTPHONE.Text)
                    .Parameters.AddWithValue("@age", TXTAGE.Text)
                    .Parameters.AddWithValue("@gender", CBOGENDER.Text)
                    .Parameters.AddWithValue("@email_address", TXTEMAIL.Text)

                    .Parameters.AddWithValue("@dob", DOB.Value)
                    .Parameters.AddWithValue("@marital_status", CBOSTAT.Text)
                    .Parameters.AddWithValue("@street", TXTST.Text)
                    .Parameters.AddWithValue("@brgy", TXTCITY.Text)
                    .Parameters.AddWithValue("@municipal", TXTMUN.Text)
                    .Parameters.AddWithValue("@city", TXTCITY.Text)
                    .Parameters.AddWithValue("@postal_code", TXTPOSTAL.Text)
                    .Parameters.AddWithValue("@date_created", Now.ToShortDateString)

                    .ExecuteNonQuery()

                End With

                MsgBox("Record has been successfully saved.", vbInformation)
                con.Close()

                With frmClinicPatientModule
                    .FillPatientMainInfo()
                End With

                UserLog("Insert and Save new Service")


                Me.Dispose()

            End If



        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim arrImage() As Byte


        Try

            If PictureBox1.BackgroundImage Is Nothing Then
                MsgBox("WARNING: You're required to put an image!", vbInformation)
            Else


                Dim mainstream As New MemoryStream

                PictureBox1.BackgroundImage.Save(mainstream, System.Drawing.Imaging.ImageFormat.Jpeg)

                arrImage = mainstream.GetBuffer

                con.Open()
                Dim insertQuery As String = "INSERT INTO ec_patients(p_img, fname, mname, lname, p_number, age, gender, email_address, dob, marital_status, street, brgy, municipal, city, postal_code, date_created) " &
                    " VALUES (@p_img, @fname, @mname, @lname, @p_number, @age, @gender, @email_address, @dob, @marital_status, @street, @brgy, @municipal, @city, @postal_code, @date_created)"
                cm = New MySqlCommand(insertQuery, con)
                With cm
                    .Parameters.AddWithValue("@p_img", arrImage)
                    .Parameters.AddWithValue("@fname", TXTFIRSTNAME.Text)
                    .Parameters.AddWithValue("@mname", TXTMN.Text)
                    .Parameters.AddWithValue("@lname", TXTLASTNAME.Text)
                    .Parameters.AddWithValue("@p_number", TXTPHONE.Text)
                    .Parameters.AddWithValue("@age", TXTAGE.Text)
                    .Parameters.AddWithValue("@gender", CBOGENDER.Text)
                    .Parameters.AddWithValue("@email_address", TXTEMAIL.Text)

                    .Parameters.AddWithValue("@dob", DOB.Value)
                    .Parameters.AddWithValue("@marital_status", CBOSTAT.Text)
                    .Parameters.AddWithValue("@street", TXTST.Text)
                    .Parameters.AddWithValue("@brgy", TXTCITY.Text)
                    .Parameters.AddWithValue("@municipal", TXTMUN.Text)
                    .Parameters.AddWithValue("@city", TXTCITY.Text)
                    .Parameters.AddWithValue("@postal_code", TXTPOSTAL.Text)
                    .Parameters.AddWithValue("@date_created", Now.ToShortDateString)

                    .ExecuteNonQuery()

                End With

                MsgBox("Record has been successfully saved.", vbInformation)
                con.Close()

                With frmClinicPatientModule
                    .FillPatientMainInfo()
                End With

                UserLog("Insert and Save new Service")


                Me.Dispose()

            End If



        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using odf As New OpenFileDialog With {.Filter = "(Image.Files)|*.jpg;*.png;*.jpeg; *.jpeg|*.jpg|*.png",
                              .Multiselect = False, .Title = "Select Image"}
            If odf.ShowDialog = 1 Then
                PictureBox1.BackgroundImage = Image.FromFile(odf.FileName)
            End If
        End Using
    End Sub

End Class