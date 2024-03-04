Imports MySql.Data.MySqlClient
Public Class frmClinicPay
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Sub FillDiscount()
        con.Open()
        cm = New MySqlCommand("SELECT * FROM ec_discount", con)
        dr = cm.ExecuteReader

        While dr.Read
            CBODISCOUNT.Items.Add(dr.Item("description_discount").ToString)
        End While


        dr.Close()

        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBODISCOUNT.SelectedIndexChanged
        Try
            con.Open()
            cm = New MySqlCommand("SELECT * FROM ec_discount WHERE description_discount='" & CBODISCOUNT.Text & "'", con)
            dr = cm.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                Dim dcs As Double = CDbl(LBLPRICE.Text) - (CDbl(LBLPRICE.Text) * CDbl(dr.Item("discount").ToString) / 100)
                LBLDISCOUNT.Text = Format(CDbl(LBLPRICE.Text) - dcs, "###,###,##0.00")
                LBLAMOUNT.Text = Format(CDbl(LBLPRICE.Text) - CDbl(LBLDISCOUNT.Text), "###,###,##0.00")
            Else
                LBLDISCOUNT.Text = 0
            End If

            If CBODISCOUNT.SelectedItem = String.Empty Then
                CBOPTYPE.Enabled = False
            Else
                CBOPTYPE.Enabled = True

            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub frmClinicPay_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillDiscount()
    End Sub

    Private Sub CBOPTYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBOPTYPE.SelectedIndexChanged
        If CBOPTYPE.SelectedItem = "Cash" Then
            Panel3.Visible = True
        Else
            Panel3.Visible = False

        End If
    End Sub

    Private Sub TXTCASH_TextChanged(sender As Object, e As EventArgs) Handles TXTCASH.TextChanged
        Try
            Dim total As Double = CDbl(LBLAMOUNT.Text)
            Dim change As Double = CDbl(TXTCASH.Text) - total

            If change < 0 Then
                TXTCHANGE.Text = "0.00"
            Else
                TXTCHANGE.Text = Format(change, "#,###,##0.00")
            End If
        Catch ex As Exception
            TXTCHANGE.Text = "0.00"
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CBOPTYPE.Text = String.Empty Then
            MsgBox("ERROR! Cannot proceed", vbOKOnly + vbInformation)
        End If

        If TXTCASH.Text = String.Empty Then
            MsgBox("ERROR! Cash is required", vbOKOnly + vbInformation)

        Else
            Dim savePayment As String = "INSERT INTO ec_payment(patient_name, price, discount_type, discount, p_type, amount) VALUES (@patient_name, @price, @discount_type, @discount, @p_type, @amount)"
            con.Open()
            cm = New MySqlCommand(savePayment, con)

            With cm
                .Parameters.AddWithValue("@patient_name", LBLPN.Text)
                .Parameters.AddWithValue("@price", LBLPRICE.Text)
                .Parameters.AddWithValue("@discount_type", CBODISCOUNT.Text)
                .Parameters.AddWithValue("@discount", LBLDISCOUNT.Text)
                .Parameters.AddWithValue("@p_type", CBOPTYPE.Text)
                .Parameters.AddWithValue("@amount", LBLAMOUNT.Text)

                .ExecuteNonQuery()
            End With

            con.Close()


            con.Open()
            Dim updateStatusCartOperation As String = "UPDATE ec_billing_operations SET status='Paid' WHERE operaid='" & LBLBID.Text & "'"
            cm = New MySqlCommand(updateStatusCartOperation, con)

            With cm
                .ExecuteNonQuery()
            End With
            con.Close()


            con.Open()
            Dim updateStatusCartBill As String = "UPDATE ec_billing_services SET status='Paid' WHERE billid='" & LBLBID.Text & "'"
            cm = New MySqlCommand(updateStatusCartBill, con)

            With cm
                .ExecuteNonQuery()
            End With
            con.Close()

            con.Open()
            Dim updateAppointmentStatus As String = "UPDATE ec_appointment SET status='Completed' WHERE appt_id='" & LBLAPID.Text & "'"
            cm = New MySqlCommand(updateAppointmentStatus, con)

            With cm
                .ExecuteNonQuery()
            End With
            con.Close()

            MsgBox("Thank you for your recent purchase. We are honored to gain you as a customer and hope to serve you for a long time.", vbOKOnly + vbInformation)


            With frmClinicConsultationPayment
                .fillOperationBill()

            End With

            With frmClinicBillsAndPayment
                .FillBill()

            End With


            Me.Dispose()
        End If
    End Sub
End Class