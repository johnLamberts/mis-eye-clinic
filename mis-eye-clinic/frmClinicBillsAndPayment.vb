Imports MySql.Data.MySqlClient
Public Class frmClinicBillsAndPayment


    Dim _bid, _pid, _desc, _price, _disc, _amountx

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With frmClinicConsultationPayment
            .fillOperationBill()
            .ShowDialog()
        End With
    End Sub

    Private Sub frmClinicBillsAndPayment_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillBill()
    End Sub
    Sub FillBill()
        DataGridView1.Rows.Clear()

        Dim nos As Integer = 0

        con.Open()
        cm = New MySqlCommand("SELECT * FROM ec_billing_services eb JOIN ec_patients USING(patientid) WHERE eb.status='Pending'", con)

        dr = cm.ExecuteReader

        While dr.Read
            nos += 1

            DataGridView1.Rows.Add(dr.Item("billid"), nos, dr.Item("appt_id"), dr.Item("fname") & " " & dr.Item("lname"), dr.Item("service_name"), dr.Item("unit_price").ToString, dr.Item("status"), "Create Invoice")
        End While

        dr.Close()
        con.Close()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName = DataGridView1.Columns(e.ColumnIndex).Name

        If colName = "Invoice" Then
            With frmClinicPay

                con.Open()
                cm = New MySqlCommand("SELECT * FROM ec_billing_services JOIN ec_patients USING(patientid) WHERE billid='" & DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString & "'", con)

                dr = cm.ExecuteReader

                While dr.Read
                    .LBLAPID.Text = dr.Item("appt_id")
                    .LBLBID.Text = dr.Item("billid")
                    .LBLDESCRIPTION.Text = dr.Item("service_name")
                    .LBLPN.Text = dr.Item("fname") & " " & dr.Item("lname")
                    .LBLPRICE.Text = dr.Item("unit_price")
                    .LBLBID.Text = dr.Item("billid")
                End While

                dr.Close()

                con.Close()


                .ShowDialog()

            End With
        End If


    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged


        Dim crw = DataGridView1.CurrentRow.Index

        _bid = DataGridView1.Item(0, crw).Value
        _pid = DataGridView1.Item(2, crw).Value
        _desc = DataGridView1.Item(3, crw).Value
        _price = DataGridView1.Item(4, crw).Value
        _disc = DataGridView1.Item(5, crw).Value
        _amountx = DataGridView1.Item(6, crw).Value


    End Sub
End Class