Imports MySql.Data.MySqlClient
Public Class frmRecordStockInventory
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub



    Sub FillStocks()
        Dim nos As Integer = 0
        DataGridView1.Rows.Clear()
        Dim total As Double
        Dim getProductQuery As String = "SELECT * FROM ec_products JOIN ec_brand USING(brandid) JOIN ec_category USING(catid) JOIN ec_generic USING(genericid) JOIN ec_type USING(typeid) WHERE quantity > 0 AND " & CBOFILTER.Text & " LIKE '" & TXTSEARCH.Text & "%'"
        con.Open()
        cm = New MySqlCommand(getProductQuery, con)
        dr = cm.ExecuteReader

        While dr.Read
            nos += 1
            total += CDbl(dr.Item("quantity"))
            DataGridView1.Rows.Add(nos, dr.Item("productid"), dr.Item("productcode").ToString, dr.Item("brandname").ToString, dr.Item("catname").ToString, Space(2) & dr.Item("genericname").ToString, dr.Item("typename").ToString, dr.Item("quantity").ToString)
        End While
        dr.Close()
        cm = Nothing
        con.Close()

        LBLCOUNT.Text = DataGridView1.Rows.Count & " record(s) found. " & vbTab & total & " Avaiable Stock(s)"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CBOFILTER.Text = String.Empty Or TXTSEARCH.Text = String.Empty Then
            MsgBox("No records found!", vbInformation)
            Exit Sub
        Else
            FillStocks()
        End If
    End Sub



    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        If TabControl1.SelectedIndex = 2 Then
            With frmRecordUserLog
                .TopLevel = False
                Panel6.Controls.Add(frmRecordUserLog)
                .FillUserLog()
                .BringToFront()

                .Show()

            End With
        End If
    End Sub
End Class