Imports MySql.Data.MySqlClient

Public Class frmSalesRecord
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub frmSalesRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Sub FillSalesRecords()
        DataGridView1.Rows.Clear()
        Dim nos As Integer = 0
        Dim sales_date As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Try
            con.Open()
            Dim getCartSales As String = "SELECT * FROM ec_cart 
                                          JOIN ec_products USING(productid) 
                                          JOIN ec_brand USING(brandid) 
                                          JOIN ec_category USING(catid)
                                          JOIN ec_type USING(typeid) 
                                          JOIN ec_generic USING(genericid) 
                                          WHERE date BETWEEN '" & sales_date & "' AND '" & sales_date & "' AND ec_cart.status='Success'"
            cm = New MySqlCommand(getCartSales, con)
            'With cm

            '    .Parameters.AddWithValue("date", date_filter)
            '    .ExecuteNonQuery()

            'End With

            dr = cm.ExecuteReader

            While dr.Read
                nos += 1
                DataGridView1.Rows.Add(nos, dr.Item("cartid").ToString, dr.Item("transno").ToString, dr.Item("productcode").ToString, dr.Item("brandname").ToString, dr.Item("genericname").ToString, dr.Item("catname").ToString, dr.Item("typename").ToString, dr.Item("price").ToString, dr.Item("quantity").ToString, dr.Item("total").ToString)
            End While



            dr.Close()

            con.Close()
            LBLTOTAL.Text = Format(FillTotalSales("SELECT IFNULL(SUM(total), 0) FROM ec_cart   WHERE date BETWEEN '" & sales_date & "' AND '" & sales_date & "' AND status='Success'"), "###,###,##0.00")


            DataGridView1.Rows.Add("", "", "", "", "", "", "", "", "", "")

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Function FillTotalSales(ByVal query As String) As Double
        con.Open()
        cm = New MySqlCommand(query, con)
        FillTotalSales = CDbl(cm.ExecuteScalar)
        con.Close()

        Return FillTotalSales
    End Function



    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        FillSalesRecords()
    End Sub

End Class