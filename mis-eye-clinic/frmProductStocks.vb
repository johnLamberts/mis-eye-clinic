Imports MySql.Data.MySqlClient
Public Class frmProductStocks
    Sub FillProductOnStock()
        If CMBFILTER.Text = String.Empty Or TXTSEARCH.Text = String.Empty Then
            DataGridView3.Rows.Clear()

            Return
        End If


        Dim nos As Integer = 0
        DataGridView3.Rows.Clear()
        Dim getProductQuery As String = "SELECT * FROM ec_products JOIN ec_brand USING(brandid) JOIN ec_type USING(typeid) JOIN ec_category USING(catid) JOIN ec_generic USING(genericid) WHERE " & CMBFILTER.Text & " LIKE '" & TXTSEARCH.Text & "%'"
        con.Open()
        cm = New MySqlCommand(getProductQuery, con)
        dr = cm.ExecuteReader

        While dr.Read
            nos += 1
            DataGridView3.Rows.Add(nos, dr.Item("productid"), dr.Item("productcode").ToString & Space(2) & "|" & Space(2) & dr.Item("brandname").ToString & Space(2) & "|" & Space(2) & dr.Item("catname").ToString & Space(2) & "|" & Space(2) & dr.Item("genericname").ToString & Space(2) & "|" & Space(2) & dr.Item("typename").ToString, "Modify")
        End While
        dr.Close()
        con.Close()

    End Sub

    Sub FillStockHistory()
        Dim sdate1 As String = DTP1.Value.ToString("yyy-MM-dd")
        Dim sdate2 As String = DTP2.Value.ToString("yyy-MM-dd")

        Dim nos As Integer = 0
        DataGridView4.Rows.Clear()
        Dim getProductQuery As String = "SELECT * FROM ec_stockin JOIN ec_products USING(productid) JOIN ec_brand USING(brandid) JOIN ec_category USING(catid) JOIN ec_generic USING(genericid) JOIN ec_type USING(typeid) WHERE date BETWEEN '" & sdate1 & "' AND '" & sdate2 & "' ORDER BY ec_stockin.stockid"
        con.Open()
        cm = New MySqlCommand(getProductQuery, con)
        'With cm
        '    .Parameters.Add("@date1", st1)
        '    .Parameters.Add("@date2", st2)
        '    .ExecuteNonQuery()
        'End With
        dr = cm.ExecuteReader

        While dr.Read
            nos += 1
            DataGridView4.Rows.Add(nos, dr.Item("stockid").ToString, dr.Item("receivedby").ToString, dr.Item("productcode"), dr.Item("brandname").ToString, dr.Item("genericname").ToString, dr.Item("catname").ToString, dr.Item("typename").ToString, dr.Item("quantity").ToString, Format(CDate(dr.Item("date")), "MM/dd/yyyy"))


        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub CMBFILTER_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CMBFILTER.KeyPress
        'e.Handled = True
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        FillProductOnStock()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        FillProductOnStock()

    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Try
            If TXTRECBY.Text = String.Empty Or TXTREFNO.Text = String.Empty Then
                MsgBox("Please validate your reference and accomodated person.", vbInformation)
                Return
            End If

            Dim colName As String = DataGridView3.Columns(e.ColumnIndex).Name
            Dim rowData As String = DataGridView3.Rows(e.RowIndex).Cells(2).Value.ToString

            Dim arr() As String = rowData.Split("|")
            If colName = "Modify" Then

                If MsgBox("Product Code: " & arr(0) & vbCr & "Brand Name: " & arr(1) & vbCr & "Generic Name: " & arr(2) & vbCr & "Classification Name: " & arr(3) & vbCr & "Type Name: " & arr(4) & vbCr, vbYesNo + vbInformation) = vbYes Then
                    DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, DataGridView3.Rows(e.RowIndex).Cells(1).Value.ToString, arr(0).ToString, arr(1).ToString, arr(2), arr(3).ToString.ToString, arr(4).ToString.ToString)
                End If
            End If

            LBLCOUNT.Text = "(" & DataGridView1.Rows.Count & ") record(s) found."
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try

            For id As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(id).Cells(7).Value = String.Empty Then
                    MsgBox("Please Input Quantity.", vbExclamation)
                    Return
                End If
            Next

            Dim Tdate As String = DTPREC.Value.ToString("yyyy-MM-dd")
            Dim isSuccess As Boolean = False
            For id As Integer = 0 To DataGridView1.Rows.Count - 1

                'Avoiding a duplicate records would be a mess
                Dim hasFound As Boolean = False
                con.Open()
                Dim getStock As String = "SELECT * FROM ec_stockin WHERE reference_no='" & TXTREFNO.Text & "' AND productid='" & DataGridView1.Rows(id).Cells(1).Value.ToString & "' AND date='" & Tdate & "'"
                cm = New MySqlCommand(getStock, con)
                dr = cm.ExecuteReader
                dr.Read()

                If dr.HasRows() Then hasFound = True Else hasFound = False

                dr.Close()
                con.Close()



                If hasFound = False Then
                    con.Open()
                    Dim insertStock As String = "INSERT INTO ec_stockin(reference_no, receivedby, productid, quantity, date) VALUES (@reference_no, @receivedby, @productid, @quantity, @date)"
                    cm = New MySqlCommand(insertStock, con)

                    With cm
                        .Parameters.AddWithValue("@reference_no", TXTREFNO.Text)
                        .Parameters.AddWithValue("@receivedby", TXTRECBY.Text)
                        .Parameters.AddWithValue("@productid", CInt(DataGridView1.Rows(id).Cells(1).Value.ToString))
                        .Parameters.AddWithValue("@quantity", CInt(DataGridView1.Rows(id).Cells(7).Value.ToString))
                        .Parameters.AddWithValue("@date", Tdate)
                        .ExecuteNonQuery()
                    End With
                    con.Close()


                    con.Open()
                    Dim updatedQuantityProducts As String = "UPDATE ec_products SET quantity=quantity + @quantity WHERE productid=@productid"
                    cm = New MySqlCommand(updatedQuantityProducts, con)

                    With cm

                        .Parameters.AddWithValue("@productid", DataGridView1.Rows(id).Cells(1).Value.ToString)
                        .Parameters.AddWithValue("@quantity", DataGridView1.Rows(id).Cells(7).Value.ToString)
                        .ExecuteNonQuery()
                    End With
                    con.Close()

                    isSuccess = True
                Else
                    MsgBox("Duplicate Records Found! Please changed your reference no.", vbCritical)
                End If
            Next

            If isSuccess = True Then MsgBox("Stock has been successfully added.", vbInformation)

            UserLog("New Stock added, Check the stocks!")


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DTP1.ValueChanged

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        FillStockHistory()
    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class