Imports MySql.Data.MySqlClient
Public Class frmClinicAttendTodayConfirm
    Dim newPanel As New Panel

    Dim lblDate As New Label
    Dim lblTime As New Label
    Dim lblNoAppt As New Label
    Dim lblPrice As New Label

    Dim patientName As New Label
    Dim serviceProvided As New Label
    Dim viewBtn As New Button
    Dim cancelBtn As New Button
    Dim confirmBtn As New Button

    Dim current As DateTime = DateTime.Now.ToString("yyyy-MM-dd")


    Sub ConfirmTodayAppointment()
        cfPanel.AutoScroll = True

        cfPanel.Controls.Clear()

        Try
            con.Open()

            cm = New MySqlCommand("SELECT * FROM ec_appointment ea JOIN ec_schedule USING(schedid) JOIN ec_patients USING(patientid) WHERE ea.status='Waiting List' AND appt_day='" & current.ToString("yyyy-MM-dd") & "'", con)
            dr = cm.ExecuteReader

            While dr.Read

                newPanel = New Panel
                newPanel.Size = New Size(395, 86)
                newPanel.BorderStyle = BorderStyle.FixedSingle

                lblTime = New Label
                lblTime.Text = Format(CDate(dr.Item("time_available").ToString), "hh:mm tt")
                lblTime.BackColor = Color.FromArgb(45, 52, 54)
                lblTime.ForeColor = Color.White
                lblTime.Location = New Point(30, 15)
                lblTime.Font = New Font("Bahnschrift Light", 9.75)

                lblDate = New Label
                lblDate.Text = dr.Item("appt_day").ToString
                lblDate.BackColor = Color.FromArgb(45, 52, 54)
                lblDate.ForeColor = Color.White
                lblDate.Location = New Point(30, 50)
                lblDate.Font = New Font("Bahnschrift Light", 9.75)


                lblPrice = New Label
                lblPrice.Text = dr.Item("price").ToString
                lblPrice.BackColor = Color.FromArgb(45, 52, 54)
                lblPrice.ForeColor = Color.White
                lblPrice.Location = New Point(30, 50)
                lblPrice.Font = New Font("Bahnschrift Light", 9.75)
                lblPrice.Visible = False
                lblPrice.Tag = dr.Item("price").ToString

                patientName = New Label
                patientName.Text = dr.Item("fname").ToString & " " & dr.Item("lname").ToString
                patientName.BackColor = Color.FromArgb(45, 52, 54)
                patientName.ForeColor = Color.White
                patientName.Location = New Point(173, 15)
                patientName.Font = New Font("Bahnschrift Light", 9.75)
                patientName.Tag = dr.Item("patientid").ToString


                serviceProvided = New Label
                serviceProvided.Text = dr.Item("service_name").ToString
                serviceProvided.BackColor = Color.FromArgb(45, 52, 54)
                serviceProvided.ForeColor = Color.White
                serviceProvided.Location = New Point(173, 50)
                serviceProvided.Font = New Font("Bahnschrift Light", 9.75)
                serviceProvided.Tag = dr.Item("service_name").ToString


                viewBtn = New Button
                viewBtn.Text = "View"
                viewBtn.Tag = dr.Item("appt_id").ToString
                viewBtn.Size = New Size(75, 24)
                viewBtn.FlatStyle = FlatStyle.Flat
                viewBtn.ForeColor = Color.Black
                viewBtn.Location = New Point(290, 3)

                cancelBtn = New Button
                cancelBtn.Text = "Cancel"
                cancelBtn.Tag = dr.Item("appt_id").ToString
                cancelBtn.Size = New Size(75, 24)
                cancelBtn.FlatStyle = FlatStyle.Flat
                cancelBtn.ForeColor = Color.Black
                cancelBtn.Location = New Point(290, 30)


                confirmBtn = New Button
                confirmBtn.Text = "Confirm"
                confirmBtn.Tag = dr.Item("appt_id").ToString
                confirmBtn.Size = New Size(75, 24)
                confirmBtn.FlatStyle = FlatStyle.Flat
                confirmBtn.ForeColor = Color.Black
                confirmBtn.Location = New Point(290, 57)


                newPanel.Controls.Add(lblTime)
                newPanel.Controls.Add(lblDate)
                newPanel.Controls.Add(patientName)
                newPanel.Controls.Add(serviceProvided)
                newPanel.Controls.Add(viewBtn)
                newPanel.Controls.Add(cancelBtn)
                newPanel.Controls.Add(confirmBtn)


                AddHandler cancelBtn.Click, AddressOf RemoveAppointment
                AddHandler viewBtn.Click, AddressOf ViewAppointment
                AddHandler confirmBtn.Click, AddressOf ConfirmAppointment


                cfPanel.Controls.Add(newPanel)

            End While

            dr.Close()

            con.Close()


        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub ViewAppointment(sender As Object, e As EventArgs)
        Dim appt_id = sender.Tag.ToString
        Try
            con.Open()
            Dim gets = "SELECT * FROM ec_appointment ea JOIN ec_schedule USING(schedid) JOIN ec_patients USING(patientid) WHERE ea.appt_id ='" & appt_id & "'"
            cm = New MySqlCommand(gets, con)
            cm.ExecuteNonQuery()

            dr = cm.ExecuteReader
            dr.Read()


            If dr.HasRows Then
                With frmClinicAptView


                    .LBLAPTPN.Text = dr.Item("firstName").ToString & " - " & dr.Item("lastName").ToString
                    .LBLAPTREF.Text = dr.Item("appt_refno").ToString
                    .LBLAPTTYPE.Text = dr.Item("appt_type").ToString
                    .LBLDATE.Text = dr.Item("appt_day").ToString
                    .LBLTIME.Text = dr.Item("time_available").ToString
                    .LBLSERVICE.Text = dr.Item("service_name").ToString

                    .ShowDialog()




                End With
            End If


            dr.Close()


            con.Close()

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try



    End Sub


    Private Sub RemoveAppointment(sender As Object, e As EventArgs)
        Dim apptid = sender.Tag.ToString

        If (MsgBox("Are you sure to cancel this appointment?", vbOKCancel + vbQuestion) = vbOK) Then
            con.Open()

            Dim updateQuery = "UPDATE ec_appointment SET status='Cancel' WHERE appt_id='" & apptid & "'"
            cm = New MySqlCommand(updateQuery, con)
            cm.ExecuteNonQuery()

            con.Close()

            MsgBox("Appointment made by patient was declined", vbOKOnly + vbInformation)
            With frmClinicAppointments
                .IncomingAppointment()
            End With
        End If

    End Sub

    Private Sub ConfirmAppointment(sender As Object, e As EventArgs)
        Dim apptid = sender.Tag.ToString

        If (MsgBox("Are you sure?", vbOKCancel + vbQuestion) = vbOK) Then
            con.Open()

            Dim updateQuery = "UPDATE ec_appointment SET status='Ready' WHERE appt_id='" & apptid & "'"
            cm = New MySqlCommand(updateQuery, con)
            cm.ExecuteNonQuery()

            con.Close()


            'con.Open()
            'Dim insertQuery = "INSERT INTO ec_billing_services(patientid, service_name, unit_price) SELECT patientid, service_name, price FROM ec_appointment WHERE appt_id='" & apptid & "'"

            'cm = New MySqlCommand(insertQuery, con)

            'With cm.Parameters
            '    .AddWithValue("@patientid", patientName.Text)
            '    .AddWithValue("@service_name", serviceProvided.Text)
            '    .AddWithValue("@unit_price", lblPrice.Text)
            'End With

            'cm.ExecuteNonQuery()



            con.Close()


            MsgBox("Successfully confirmed", vbOKOnly + vbInformation)

            With frmClinicAppointments
                .IncomingAppointment()
                .TodayAppointment()
                .OperationsSchedule()
            End With

            Me.Dispose()


        End If

    End Sub





    Private Sub frmClinicAttendTodayConfirm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConfirmTodayAppointment()
    End Sub

    Private Sub cfPanel_Paint(sender As Object, e As PaintEventArgs) Handles cfPanel.Paint

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Dispose()
    End Sub
End Class