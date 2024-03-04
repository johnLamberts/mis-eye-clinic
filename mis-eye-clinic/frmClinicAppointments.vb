Imports MySql.Data.MySqlClient

Public Class frmClinicAppointments
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

    Dim Sidebar As Boolean = True

    Dim current As DateTime = DateTime.Now.ToString("yyyy-MM-dd")


    Private Sub frmClinicAppointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IncomingAppointment()
        CancelAppointment()
        TodayAppointment()
        OperationsSchedule()

        LBLTODAYDATE.Text = current

    End Sub

    Sub OperationsSchedule()
        flpOS.AutoScroll = True

        flpOS.Controls.Clear()

        Try
            con.Open()

            cm = New MySqlCommand("SELECT * FROM ec_appointment ea JOIN ec_schedule USING(schedid) JOIN ec_patients USING(patientid) WHERE ea.status='Ready' AND appt_type='OPERATION/SURGERY' AND appt_day='" & current.ToString("yyyy-MM-dd") & "'", con)
            dr = cm.ExecuteReader

            While dr.Read

                newPanel = New Panel
                newPanel.Size = New Size(368, 86)
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


                flpOS.Controls.Add(newPanel)

            End While

            dr.Close()

            con.Close()

            'con.Open()
            'cm = New MySqlCommand("UPDATE ec_appointment SET appt_day='Ready' WHERE appt_day='" & current.ToString("yyyy-MM-dd") & "'", con)
            'cm.ExecuteNonQuery()

            'con.Close()


        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub TodayAppointment()
        tdPanel.AutoScroll = True

        tdPanel.Controls.Clear()

        Try
            con.Open()

            cm = New MySqlCommand("SELECT * FROM ec_appointment ea JOIN ec_schedule USING(schedid) JOIN ec_patients USING(patientid) WHERE ea.status='Ready' AND appt_day='" & current.ToString("yyyy-MM-dd") & "' AND  appt_type IN ('NEW', 'FOLLOW-UP')", con)
            dr = cm.ExecuteReader

            While dr.Read

                newPanel = New Panel
                newPanel.Size = New Size(368, 86)
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


                tdPanel.Controls.Add(newPanel)

            End While

            dr.Close()

            con.Close()

            'con.Open()
            'cm = New MySqlCommand("UPDATE ec_appointment SET appt_day='Ready' WHERE appt_day='" & current.ToString("yyyy-MM-dd") & "'", con)
            'cm.ExecuteNonQuery()

            'con.Close()


        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Sub CancelAppointment()
        flpOS.AutoScroll = True
        flpOS.Controls.Clear()


        con.Open()

        cm = New MySqlCommand("SELECT * FROM ec_appointment ea JOIN ec_schedule USING(schedid) JOIN ec_patients USING(patientid) WHERE ea.status='Cancel' ORDER BY appt_day ASC", con)

        dr = cm.ExecuteReader

        While dr.Read

            If dr.HasRows Then
                newPanel = New Panel
                newPanel.Size = New Size(368, 86)
                newPanel.BorderStyle = BorderStyle.FixedSingle

                lblTime = New Label
                lblTime.Text = dr.Item("time_available").ToString
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


                'viewBtn = New Button
                'viewBtn.Text = "View"
                'viewBtn.Tag = dr.Item("appt_id").ToString
                'viewBtn.Size = New Size(75, 24)
                'viewBtn.FlatStyle = FlatStyle.Flat
                'viewBtn.ForeColor = Color.Black
                'viewBtn.Location = New Point(290, 3)

                'cancelBtn = New Button
                'cancelBtn.Text = "Cancel"
                'cancelBtn.Tag = dr.Item("appt_id").ToString
                'cancelBtn.Size = New Size(75, 24)
                'cancelBtn.FlatStyle = FlatStyle.Flat
                'cancelBtn.ForeColor = Color.Black
                'cancelBtn.Location = New Point(290, 31)




                newPanel.Controls.Add(lblTime)
                newPanel.Controls.Add(lblDate)
                newPanel.Controls.Add(patientName)
                newPanel.Controls.Add(serviceProvided)
                newPanel.Controls.Add(viewBtn)
                newPanel.Controls.Add(cancelBtn)
                newPanel.Controls.Add(cancelBtn)


            End If


            flpOS.Controls.Add(newPanel)

        End While


        con.Close()


    End Sub

    Sub IncomingAppointment()

        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Clear()

        con.Open()

        cm = New MySqlCommand("SELECT * FROM ec_appointment ea JOIN ec_schedule USING(schedid) JOIN ec_patients USING(patientid) WHERE ea.status='Waiting List' AND appt_day >= NOw() + 1", con)

        dr = cm.ExecuteReader

        While dr.Read

            If dr.HasRows Then
                newPanel = New Panel
                newPanel.Size = New Size(368, 86)
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

                newPanel.Controls.Add(lblTime)
                newPanel.Controls.Add(lblDate)
                newPanel.Controls.Add(patientName)
                newPanel.Controls.Add(serviceProvided)
                newPanel.Controls.Add(viewBtn)
                newPanel.Controls.Add(cancelBtn)
                'newPanel.Controls.Add(confirmBtn)


                AddHandler cancelBtn.Click, AddressOf RemoveAppointment
                AddHandler viewBtn.Click, AddressOf ViewAppointment
                'AddHandler confirmBtn.Click, AddressOf ConfirmAppointment

            End If


            FlowLayoutPanel1.Controls.Add(newPanel)

        End While

        dr.Close()

        con.Close()

    End Sub



    Private Sub ViewAppointment(sender As Object, e As EventArgs)
        Dim appt_id = sender.Tag.ToString
        With frmClinicAptView

            Try
                con.Open()
                Dim gets = "SELECT * FROM ec_appointment ea JOIN ec_schedule USING(schedid) JOIN ec_patients USING(patientid) WHERE ea.appt_id ='" & appt_id & "'"
                cm = New MySqlCommand(gets, con)
                cm.ExecuteNonQuery()

                dr = cm.ExecuteReader
                dr.Read()


                If dr.HasRows Then
                    .LBLPID.Text = dr.Item("patientid").ToString
                    .LBLAPTPN.Text = dr.Item("fname").ToString & " - " & dr.Item("lname").ToString
                    .LBLAPTREF.Text = dr.Item("appt_refno").ToString
                    .LBLAPTTYPE.Text = dr.Item("appt_type").ToString
                    .LBLDATE.Text = Format(CDate(dr.Item("appt_day")), "yyyy-MM-dd")
                    .LBLTIME.Text = dr.Item("time_available").ToString
                    .LBLSERVICE.Text = dr.Item("service_name").ToString




                End If


                dr.Close()


                con.Close()

                'Dim nos As Integer = 0

                'con.Open()

                'cm = New MySqlCommand("SELECT * FROM ec_read_eye WHERE patientid='" & appt_id & "'", con)
                'dr = cm.ExecuteReader

                'While dr.Read
                '    nos += 1
                '    .DataGridView2.Rows.Add(dr.Item("read_id").ToString, nos, dr.Item("left_d").ToString, dr.Item("left_wg").ToString, dr.Item("left_pin").ToString, dr.Item("left_n").ToString, dr.Item("left_woutg").ToString, dr.Item("left_iop").ToString, dr.Item("left_woutg").ToString, dr.Item("right_d").ToString, dr.Item("right_wg").ToString, dr.Item("right_pin").ToString, dr.Item("right_n").ToString, dr.Item("right_woutg").ToString, dr.Item("right_iop").ToString, Format(CDate(dr.Item("date_taken")), "yyyy-MM-dd"))
                'End While

                'dr.Close()

                'con.Close()


                .EyeReading()

                .ShowDialog()


            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message, vbCritical)
            End Try

        End With


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
            IncomingAppointment()
            TodayAppointment()

        End If

    End Sub

    Private Sub ConfirmAppointment(sender As Object, e As EventArgs)
        Dim apptid = sender.Tag.ToString

        If (MsgBox("Are you sure?", vbOKCancel + vbQuestion) = vbOK) Then
            con.Open()

            Dim updateQuery = "UPDATE ec_appointment SET status='On going' WHERE appt_id='" & apptid & "'"
            cm = New MySqlCommand(updateQuery, con)
            cm.ExecuteNonQuery()

            con.Close()


            con.Open()
            Dim insertQuery = "INSERT INTO ec_billing_services(appt_id, patientid, service_name, unit_price) SELECT appt_id, patientid, service_name, price FROM ec_appointment WHERE appt_id='" & apptid & "'"

            cm = New MySqlCommand(insertQuery, con)

            With cm.Parameters
                .AddWithValue("@patientid", patientName.Text)
                .AddWithValue("@appt_id", apptid)
                .AddWithValue("@service_name", serviceProvided.Text)
                .AddWithValue("@unit_price", lblPrice.Text)
            End With

            cm.ExecuteNonQuery()



            con.Close()


            MsgBox("Successfully confirmed", vbOKOnly + vbInformation)


            IncomingAppointment()
            TodayAppointment()
        End If

    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If Sidebar Then
            sidebar1.Width += 100
            If sidebar1.Size = sidebar1.MaximumSize Then
                Timer1.Stop()
                Sidebar = False

                Button1.Visible = False
            End If
        Else
            sidebar1.Width -= 100
            If sidebar1.Size = sidebar1.MinimumSize Then
                Timer1.Stop()
                Sidebar = True
                Button1.Visible = True

            End If
        End If

    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If Sidebar Then
            sidebar1.Width += 100
            If sidebar1.Size = sidebar1.MaximumSize Then
                Timer2.Stop()
                Sidebar = False
                Button1.Visible = False

            End If
        Else
            sidebar1.Width -= 100
            If sidebar1.Size = sidebar1.MinimumSize Then
                Timer2.Stop()
                Sidebar = True
                Button1.Visible = True

            End If
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Sidebar = False

        Timer2.Start()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Sidebar = False
        Timer1.Start()
        Timer2.Start()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With frmClinicAppointmentsCreate
            .btnAdd.Show()
            .btnUpdate.Hide()

            '.FillSchedTime()

            .ShowDialog()

        End With
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        With frmMainForm
            .Show()
        End With
        Me.Dispose()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        With frmClinicConsultation
            .Show()

        End With
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With frmClinicDelayAppointment

            .FillDelayAppointment()
            .ShowDialog()


        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With frmClinicAttendTodayConfirm
            .ConfirmTodayAppointment()
            .ShowDialog()

        End With
    End Sub
End Class