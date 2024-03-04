Imports MySql.Data.MySqlClient
Public Class frmClinicConsultationPayment

    Dim newPanel As New Panel

    Dim lblName As New Label
    Dim lblTreatment As New Label
    Dim lblPrice As New Label
    Dim lblTime As New Label

    Dim payBtn As New Button


    Private Sub frmClinicConsultationPayment_Load(sender As Object, e As EventArgs) Handles Me.Load
        fillOperationBill()

    End Sub
    Sub fillOperationBill()

        flBill.AutoScroll = True
        flBill.Controls.Clear()



        Try
            con.Open()
            Dim selectQuery As String = "SELECT * FROM ec_billing_operations eu  JOIN ec_patients USING(patientid) WHERE eu.status='Pending'"

            cm = New MySqlCommand(selectQuery, con)
            dr = cm.ExecuteReader

            While dr.Read

                newPanel = New Panel
                newPanel.Size = New Size(423, 131)
                newPanel.BorderStyle = BorderStyle.FixedSingle

                lblName = New Label
                lblName.AutoSize = False
                lblName.Width = 200
                lblName.Text = "Patient Name: " & Space(2) & dr.Item("fname").ToString & " - " & dr.Item("lname").ToString
                lblName.ForeColor = Color.Black

                lblName.Location = New Point(18, 27)
                lblName.Font = New Font("Bahnschrift Light", 9.75)

                lblTreatment = New Label
                lblTreatment.AutoSize = False
                lblTreatment.Width = 150
                lblTreatment.Text = "Treatment: " & Space(2) & dr.Item("treatment").ToString
                lblTreatment.ForeColor = Color.Black
                lblTreatment.Location = New Point(21, 57)
                lblTreatment.Font = New Font("Bahnschrift Light", 9.75)

                lblTime = New Label
                lblTime.AutoSize = False
                lblTime.Width = 190
                lblTime.Text = "Date Consult: " & Space(2) & Format(CDate(dr.Item("date_pay").ToString), "yyyy-mm-dd")
                lblTime.ForeColor = Color.Black
                lblTime.Location = New Point(255, 57)
                lblTime.Font = New Font("Bahnschrift Light", 9.75)


                lblPrice = New Label
                lblPrice.AutoSize = False
                lblPrice.Width = 150
                lblPrice.Text = "Unit Price: P" & Space(2) & dr.Item("unit_price").ToString
                lblPrice.ForeColor = Color.Black
                lblPrice.Location = New Point(255, 24)
                lblPrice.Font = New Font("Bahnschrift Light", 9.75)
                lblPrice.Tag = dr.Item("unit_price").ToString


                newPanel.Controls.Add(lblName)
                newPanel.Controls.Add(lblTreatment)
                newPanel.Controls.Add(lblTime)
                newPanel.Controls.Add(lblPrice)


                payBtn = New Button
                payBtn.Text = "Pay Now"
                payBtn.Size = New Size(89, 23)
                payBtn.FlatStyle = FlatStyle.Flat
                payBtn.BackColor = Color.White
                payBtn.ForeColor = Color.FromArgb(9, 132, 227)
                payBtn.Location = New Point(136, 91)
                payBtn.Tag = dr.Item("operaid").ToString

                'cancelBtn = New Button
                'cancelBtn.Text = "Cancel"
                'cancelBtn.Tag = dr.Item("appt_id").ToString
                'cancelBtn.Size = New Size(75, 24)
                'cancelBtn.FlatStyle = FlatStyle.Flat
                'cancelBtn.ForeColor = Color.Black
                'cancelBtn.Location = New Point(290, 30)


                'confirmBtn = New Button
                'confirmBtn.Text = "Confirm"
                'confirmBtn.Tag = dr.Item("appt_id").ToString
                'confirmBtn.Size = New Size(75, 24)
                'confirmBtn.FlatStyle = FlatStyle.Flat
                'confirmBtn.ForeColor = Color.Black
                'confirmBtn.Location = New Point(290, 57)


                newPanel.Controls.Add(payBtn)
                'newPanel.Controls.Add(cancelBtn)
                'newPanel.Controls.Add(confirmBtn)


                'AddHandler cancelBtn.Click, AddressOf RemoveAppointment
                'AddHandler viewBtn.Click, AddressOf ViewAppointment
                AddHandler payBtn.Click, AddressOf PayConsult

                flBill.Controls.Add(newPanel)

            End While

            dr.Close()

            con.Close()


        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub PayConsult(sender As Object, e As EventArgs)
        Dim id = sender.Tag.ToString

        With frmClinicPay
            con.Open()
            cm = New MySqlCommand("SELECT * FROM ec_billing_operations JOIN ec_patients USING(patientid) WHERE operaid='" & id & "' AND status='Pending'", con)

            dr = cm.ExecuteReader

            While dr.Read
                .LBLBID.Text = dr.Item("operaid")
                .LBLDESCRIPTION.Text = dr.Item("treatment")
                .LBLPN.Text = dr.Item("fname") & " " & dr.Item("lname")
                .LBLPRICE.Text = dr.Item("unit_price")
            End While

            dr.Close()

            con.Close()

            .ShowDialog()

        End With


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Dispose()
    End Sub
End Class