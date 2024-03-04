Imports MySql.Data.MySqlClient

Public Class frmSalesSettlePayment
    Private Sub frmSalesSettlePayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDiscountCombo()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Sub FillDiscountCombo()
        con.Open()
        cm = New MySqlCommand("SELECT * FROM ec_discount", con)
        dr = cm.ExecuteReader

        While dr.Read
            CMBDISTYPE.Items.Add(dr.Item("description_discount").ToString)
        End While


        dr.Close()

        con.Close()

    End Sub


    Sub ComputeSales()
    End Sub

    Private Sub CMBDISTYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBDISTYPE.SelectedIndexChanged
        Try
            con.Open()
            cm = New MySqlCommand("SELECT * FROM ec_discount WHERE description_discount='" & CMBDISTYPE.Text & "'", con)
            dr = cm.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                Dim dcs As Double = CDbl(TXTTOTAL.Text) - (CDbl(TXTTOTAL.Text) * CDbl(dr.Item("discount").ToString) / 100)
                TXTDISC.Text = Format(CDbl(TXTTOTAL.Text) - dcs, "###,###,##0.00")
                TXTTOTALDUE.Text = Format(CDbl(TXTTOTAL.Text) - CDbl(TXTDISC.Text), "###,###,##0.00")

            Else
                TXTDISC.Text = 0

            End If

            If CMBDISTYPE.SelectedItem = String.Empty Then
                CMBPAYMENTTYPE.Enabled = False
            Else
                CMBPAYMENTTYPE.Enabled = True

            End If

            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBPAYMENTTYPE.SelectedIndexChanged
        If CMBPAYMENTTYPE.SelectedItem = "Cash" Then
            Panel2.Visible = True
        End If
    End Sub

    Sub ShowUpdatedStock()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim sales_date = Now.ToString("yyyy-MM-dd")
            Dim sales_time = Now.ToString("hh:mm:ss")


            If CMBPAYMENTTYPE.Text = String.Empty Then
                MsgBox("ERROR: Payment Type cannot be an empty field.", vbInformation)
                Exit Sub
            End If


            If TXTCASH.Text = String.Empty Then
                MsgBox("ERROR: Cash cannot be an empty field.", vbInformation)
                Return
            Else
                If LBLSTOCKAVAILABLE.Text > TXTQUANTITY.Text Then

                    Dim savePayment As String = "INSERT INTO ec_sales(userid, patient_name, transno, subtotal, discount, payment_type, total, sales_date, sales_time) VALUES (@userid, @patient_name, @transno, @subtotal, @discount, @payment_type, @total, @sales_date, @sales_time)"
                    con.Open()
                    cm = New MySqlCommand(savePayment, con)

                    With cm
                        .Parameters.AddWithValue("@userid", CInt(LBLUSERID.Text))
                        .Parameters.AddWithValue("@patient_name", TXTPTNAME.Text)
                        .Parameters.AddWithValue("@transno", frmSales.LBLTRANSNO.Text)
                        .Parameters.AddWithValue("@subtotal", CDbl(TXTTOTAL.Text))
                        .Parameters.AddWithValue("@discount", TXTDISC.Text)
                        .Parameters.AddWithValue("@payment_type", CMBPAYMENTTYPE.Text)
                        .Parameters.AddWithValue("@total", CDbl(TXTTOTALDUE.Text))
                        .Parameters.AddWithValue("@sales_date", sales_date)
                        .Parameters.AddWithValue("@sales_time", sales_time)
                        .ExecuteNonQuery()
                    End With

                    con.Close()


                    con.Open()
                    Dim updateStatusCart As String = "UPDATE ec_cart SET status='Success' WHERE transno='" & frmSales.LBLTRANSNO.Text & "'"
                    cm = New MySqlCommand(updateStatusCart, con)

                    With cm
                        .ExecuteNonQuery()
                    End With
                    con.Close()


                    With frmSales

                        For index = 0 To .DataGridView1.Rows.Count - 1
                            con.Open()

                            Dim stockUpdate As String = "UPDATE ec_products SET quantity=quantity -'" & CInt(.DataGridView1.Rows(index).Cells(4).Value.ToString) & "' WHERE productid='" & CInt(.DataGridView1.Rows(index).Cells(1).Value.ToString) & "'"
                            cm = New MySqlCommand(stockUpdate, con)
                            cm.ExecuteNonQuery()
                            con.Close()
                        Next



                    End With
                Else
                    MsgBox("ERROR: The number of items that you want to purchase will not be processed! Insufficient Stock", vbInformation)
                    Exit Sub
                End If



            End If




            'With frmSales
            '    .LBLTRANSNO.Text = .TransNo()

            '    .FillCart()
            'End With

            MsgBox("We’re glad to inform you that we have confirmed your payment. Thank you!", vbOKOnly + vbInformation)
            Me.Dispose()
            frmSales.RefreshControls()


            UserLog("Successfully paid the product")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXTCASH.TextChanged
        Try
            Dim total As Double = CDbl(TXTTOTALDUE.Text)
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

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click, Label11.Click

    End Sub

    Private Sub LBLSTOCKAVAILABLE_Click(sender As Object, e As EventArgs) Handles LBLSTOCKAVAILABLE.Click

    End Sub
End Class