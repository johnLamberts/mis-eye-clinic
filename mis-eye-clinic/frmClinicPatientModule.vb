Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmClinicPatientModule

    Dim pn As New Label
    Dim dob As New Label
    Dim age As New Label
    Dim sex As New Label
    Dim em As New Label
    Dim phone_number As New Label
    Dim patientPic As New PictureBox

    Dim gen_info As New Button
    Dim app_list As New Button
    Dim med_history As New Button
    Dim modify As New Button

    Dim newPanel As New Panel
    Sub FillPatientMainInfo()
        flowPatientInfo.AutoScroll = True
        flowPatientInfo.Controls.Clear()

        con.Open()

        cm = New MySqlCommand("SELECT p_img, patientid, CONCAT(fname, ' ', lname, ' ', mname) as FullName, dob, age, gender, email_address, p_number FROM ec_patients", con)
        dr = cm.ExecuteReader

        While dr.Read

            newPanel = New Panel
            newPanel.Size = New Size(859, 211)
            newPanel.BorderStyle = BorderStyle.FixedSingle
            newPanel.Font = New Font("Bahnschrift Light", 11)
            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))
            Dim ms As New MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)

            patientPic = New PictureBox
            patientPic.Size = New Size(235, 128)
            patientPic.Location = New Point(15, 21)
            patientPic.BackgroundImage = bitmap
            patientPic.BackgroundImageLayout = ImageLayout.Stretch

            pn = New Label
            pn.AutoSize = False
            pn.Width = 250
            pn.Text = "Patient Name:" & Space(2) & dr.Item("FullName").ToString
            pn.Location = New Point(264, 37)


            dob = New Label
            dob.AutoSize = False
            dob.Width = 250
            dob.Text = "Date of Birth:" & Space(2) & Format(CDate(dr.Item("dob")), "yyyy-MM-dd")
            dob.Location = New Point(264, 72)

            age = New Label
            age.AutoSize = False
            age.Width = 250
            age.Text = "Age:" & Space(2) & dr.Item("age").ToString
            age.Location = New Point(264, 106)

            sex = New Label
            sex.AutoSize = False
            sex.Width = 250
            sex.Text = "Sex:" & Space(2) & dr.Item("gender").ToString
            sex.Location = New Point(605, 37)

            em = New Label
            em.AutoSize = False
            em.Width = 250
            em.Text = "Email Address:" & Space(2) & dr.Item("email_address").ToString
            em.Location = New Point(605, 72)

            phone_number = New Label
            phone_number.AutoSize = False
            phone_number.Width = 250
            phone_number.Text = "Phone Number:" & Space(2) & dr.Item("p_number").ToString
            phone_number.Location = New Point(605, 106)

            modify = New Button
            modify.Text = "Modify"
            modify.Size = New Size(149, 30)
            modify.Location = New Point(696, 161)
            modify.ForeColor = Color.FromArgb(9, 132, 227)
            modify.FlatStyle = FlatStyle.Flat
            modify.Font = New Font("Bahnschrift Light", 9)
            modify.Tag = dr.Item("patientid").ToString

            app_list = New Button
            app_list.Text = "Consultation List"
            app_list.Size = New Size(149, 30)
            app_list.Location = New Point(178, 161)
            app_list.ForeColor = Color.FromArgb(9, 132, 227)
            app_list.FlatStyle = FlatStyle.Flat
            app_list.Font = New Font("Bahnschrift Light", 9)
            app_list.Tag = dr.Item("patientid").ToString

            gen_info = New Button
            gen_info.Text = "General Information"
            gen_info.Size = New Size(139, 30)
            gen_info.Location = New Point(37, 161)
            gen_info.BackColor = Color.FromArgb(9, 132, 227)
            gen_info.ForeColor = Color.White
            gen_info.FlatStyle = FlatStyle.Flat
            gen_info.Font = New Font("Bahnschrift Light", 9)
            gen_info.Tag = dr.Item("patientid").ToString
            gen_info.Enabled = False

            med_history = New Button
            med_history.Text = "Medical History"
            med_history.Size = New Size(139, 30)
            med_history.Location = New Point(331, 161)
            med_history.BackColor = Color.FromArgb(9, 132, 227)
            med_history.ForeColor = Color.White
            med_history.FlatStyle = FlatStyle.Flat
            med_history.Font = New Font("Bahnschrift Light", 9)
            med_history.Tag = dr.Item("patientid").ToString

            newPanel.Controls.Add(patientPic)
            newPanel.Controls.Add(pn)
            newPanel.Controls.Add(dob)
            newPanel.Controls.Add(age)
            newPanel.Controls.Add(sex)
            newPanel.Controls.Add(em)
            newPanel.Controls.Add(phone_number)

            newPanel.Controls.Add(modify)
            newPanel.Controls.Add(app_list)
            newPanel.Controls.Add(gen_info)
            newPanel.Controls.Add(med_history)

            AddHandler modify.Click, AddressOf modify_patient
            AddHandler med_history.Click, AddressOf med_patient
            AddHandler app_list.Click, AddressOf consult_list
            AddHandler gen_info.Click, AddressOf gen_patient


            flowPatientInfo.Controls.Add(newPanel)
        End While


        con.Close()


    End Sub
    Private Sub modify_patient(sender As Object, e As EventArgs)
        Dim id = sender.Tag.ToString

        With frmPatientGeneralInfo
            con.Open()

            cm = New MySqlCommand("SELECT p_img, age, brgy, city, email_address, fname, lname, mname, municipal, p_number, postal_code, street, gender, marital_status FROM ec_patients WHERE patientid='" & id & "'", con)

            dr = cm.ExecuteReader

            While dr.Read
                Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
                Dim array(CInt(len)) As Byte
                dr.GetBytes(0, 0, array, 0, CInt(len))
                Dim ms As New MemoryStream(array)
                Dim bitmap As New System.Drawing.Bitmap(ms)

                .PictureBox1.BackgroundImage = bitmap
                .LBLCPID.Text = id
                .TXTAGE.Text = dr.Item("age").ToString
                .TXTBRGY.Text = dr.Item("brgy").ToString
                .TXTCITY.Text = dr.Item("city").ToString
                .TXTEMAIL.Text = dr.Item("email_address").ToString
                .TXTFIRSTNAME.Text = dr.Item("fname").ToString
                .TXTLASTNAME.Text = dr.Item("lname").ToString
                .TXTMN.Text = dr.Item("mname").ToString
                .TXTMUN.Text = dr.Item("municipal").ToString
                .TXTPHONE.Text = dr.Item("p_number").ToString
                .TXTPOSTAL.Text = dr.Item("postal_code").ToString
                .TXTST.Text = dr.Item("street")
                .CBOGENDER.Text = dr.Item("gender").ToString
                .CBOSTAT.Text = dr.Item("marital_status").ToString



            End While
            dr.Close()
            con.Close()

            .ShowDialog()

        End With
    End Sub

    Private Sub med_patient(sender As Object, e As EventArgs)
        Dim id = sender.Tag.ToString

        With frmMedicalHitory
            con.Open()

            cm = New MySqlCommand("SELECT * FROM ec_prescribed_treatment JOIN ec_patients USING(patientid) WHERE ec_prescribed_treatment.patientid='" & id & "'", con)

            dr = cm.ExecuteReader

            While dr.Read
                .LBLTREID.Text = id
            End While
            dr.Close()
            con.Close()

            .ShowDialog()

        End With
    End Sub

    Private Sub gen_patient(sender As Object, e As EventArgs)
        Dim id = sender.Tag.ToString

        With frmMedicalHitory
            con.Open()

            cm = New MySqlCommand("SELECT p_img, age, brgy, city, email_address, fname, lname, mname, municipal, p_number, postal_code, street, gender, marital_status FROM ec_patients WHERE patientid='" & id & "'", con)

            dr = cm.ExecuteReader

            While dr.Read
                .LBLTREID.Text = id
            End While
            dr.Close()
            con.Close()

            .ShowDialog()

        End With
    End Sub

    Private Sub consult_list(sender As Object, e As EventArgs)
        Dim id = sender.Tag.ToString

        With frmServicesList
            con.Open()

            cm = New MySqlCommand("SELECT * FROM ec_billing_services JOIN ec_patients USING(patientid) WHERE ec_billing_services.patientid='" & id & "'", con)

            dr = cm.ExecuteReader

            While dr.Read
                .LBLTREID.Text = id
            End While
            dr.Close()
            con.Close()

            .ShowDialog()

        End With
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With frmPatientGeneralInfo
            .btnAdd.Show()
            .btnUpdate.Hide()
            .ShowDialog()
        End With
    End Sub

    Private Sub frmClinicPatientModule_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillPatientMainInfo()
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        'con.Open()

        'cm = New MySqlCommand("SELECT  fname, lname, mname WHERE ec_patients WHERE fname LIKE '" & TXTSEARCH.Text & "%' OR mname LIKE'" & TXTSEARCH.Text & "%' OR lname LIKE '" & TXTSEARCH.Text & "'", con)
        'cm.ExecuteNonQuery()

        'FillPatientMainInfo()

        'con.Close()
    End Sub
End Class