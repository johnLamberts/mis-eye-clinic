Imports System.Text
Imports MySql.Data.MySqlClient
Public Class frmClinicAppointmentsCreate

    Private Sub frmClinicAppointmentsCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTAPPTREFNO.Text = GenerateAppointmentRefNo()
        FillPatients()
        FillService()
        CBOSPRO.SelectedIndex = -1
        FillSchedTime()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()



    End Sub


    Sub FillPatients()
        Try
            con.Open()

            Dim patientQuery As String = "SELECT patientid, CONCAT(fname, ' ', lname) as FullName FROM ec_patients"
            cm = New MySqlCommand(patientQuery, con)
            Dim da As New MySqlDataAdapter(cm)
            Dim dt As New DataTable

            da.Fill(dt)

            CBOPN.DataSource = dt
            CBOPN.DisplayMember = "FullName"
            CBOPN.ValueMember = "patientid"

            con.Close()


        Catch ex As Exception
            con.Clone()
            MsgBox(ex.Message, vbCritical)
        End Try


    End Sub

    Sub FillSchedTime()
        Try
            con.Open()

            Dim serviceQuery As String = "SELECT * FROM ec_schedule"
            cm = New MySqlCommand(serviceQuery, con)
            Dim da As New MySqlDataAdapter(cm)
            Dim dt As New DataTable

            da.Fill(dt)

            CBOTIME.DataSource = dt
            CBOTIME.DisplayMember = "time_available"
            CBOTIME.ValueMember = "schedid"

            con.Close()


        Catch ex As Exception
            con.Clone()
            MsgBox(ex.Message, vbCritical)
        End Try


    End Sub

    Sub FillService()
        Try
            con.Open()

            Dim serviceQuery As String = "SELECT sid, service_name FROM ec_services"
            cm = New MySqlCommand(serviceQuery, con)
            'Dim da As New MySqlDataAdapter(cm)
            'Dim dt As New DataTable

            'da.Fill(dt)

            'CBOSPRO.DataSource = dt
            'CBOSPRO.DisplayMember = "service_name"
            'CBOSPRO.ValueMember = "sid"

            dr = cm.ExecuteReader

            While dr.Read
                CBOSPRO.Items.Add(dr.Item("service_name"))
            End While

            con.Close()


        Catch ex As Exception
            con.Clone()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    Function GenerateAppointmentRefNo() As String
        Dim validchars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"

        Dim sb As New StringBuilder()
        Dim rand As New Random()
        For i As Integer = 1 To 6
            Dim idx As Integer = rand.Next(0, validchars.Length)
            Dim randomChar As Char = validchars(idx)
            sb.Append(randomChar)
        Next i

        Dim randomString = sb.ToString()

        Return "APT-" & randomString
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If (MsgBox("Are you sure you want to save this record?", vbYesNo + vbQuestion) = vbYes) Then
                Dim checkDuplicated As Boolean = False

                Dim validateEntry = "SELECT time_available, appt_day FROM ec_appointment INNER JOIN ec_schedule ON ec_schedule.schedid=ec_appointment.schedid WHERE appt_day='" & DTDate.Value.ToString("yyyy-MM-dd") & "'  AND ec_schedule.time_available= '" & CBOTIME.Text & "'"

                con.Open()

                cm = New MySqlCommand(validateEntry, con)

                dr = cm.ExecuteReader

                If dr.HasRows Then
                    checkDuplicated = True
                End If


                dr.Close()

                con.Close()

                If CBAPPTTYPE.Text = "Choose Type" Or CBOSPRO.Text = "Choose Service" Or CBOPN.Text = "Choose Patient" Then
                    MsgBox("ERR! Appointment and Services are required!", vbOKOnly + vbInformation)
                    Exit Sub
                Else
                    If checkDuplicated = False Then
                        Dim insertAppt As String = "INSERT INTO ec_appointment(appt_refno, appt_type, patientid, schedid, appt_day, service_name, price, remarks) VALUES (@appt_refno, @appt_type, @patientid, @schedid, @appt_day, @service_name, @price, @remarks)"
                        con.Open()

                        cm = New MySqlCommand(insertAppt, con)

                        With cm.Parameters
                            .AddWithValue("@appt_refno", TXTAPPTREFNO.Text)
                            .AddWithValue("@appt_type", CBAPPTTYPE.Text)
                            .AddWithValue("@patientid", CBOPN.SelectedValue)
                            .AddWithValue("@schedid", CBOTIME.SelectedValue)
                            .AddWithValue("@appt_day", DTDate.Value)
                            .AddWithValue("@service_name", CBOSPRO.Text)
                            .AddWithValue("@price", LBLPRICE.Text)
                            .AddWithValue("@remarks", TXTREMAKRS.Text)
                        End With
                        cm.ExecuteNonQuery()

                        con.Close()

                        con.Open()

                        Dim updateStatus As String = "UPDATE ec_appointment Set status='Waiting List' WHERE appt_id=(SELECT LAST_INSERT_ID(MAX(appt_id)) FROM ec_appointment WHERE appt_day >= NOW() + 1)"
                        cm = New MySqlCommand(updateStatus, con)


                        cm.ExecuteNonQuery()
                        MsgBox("Records has been saved.", vbOKOnly + vbInformation)

                        con.Close()



                    Else
                        MsgBox("Error! The schedule was already choose by someone", vbOKOnly + vbInformation)

                    End If
                End If





                With frmClinicAppointments
                    .TodayAppointment()
                    .OperationsSchedule()

                    .IncomingAppointment()
                End With


                Me.Dispose()

                End If

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub


    Private Sub CBOSPRO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOSPRO.SelectedIndexChanged
        Dim query = "SELECT price FROM ec_services WHERE service_name=@name"

        cm = New MySqlCommand(query, con)
        cm.Parameters.AddWithValue("@name", CBOSPRO.SelectedItem)
        con.Open()

        dr = cm.ExecuteReader

        While dr.Read
            LBLPRICE.Text = dr.Item("price").ToString
        End While

        dr.Close()

        con.Close()
    End Sub
End Class