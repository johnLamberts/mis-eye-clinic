Imports MySql.Data.MySqlClient
Public Class frmSalesQuantity
    Dim ProductId As String, Price As Double

    Sub AddToCart(ByVal ProductId As String, ByVal Price As Double)
        Me.ProductId = ProductId
        Me.Price = Price

    End Sub

    'Private Sub frmSalesQuantity_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
    '    If e.KeyCode = Keys.Escape Then
    '        Me.Dispose()
    '    ElseIf e.KeyCode = Keys.Enter Then
    '        Dim trans_date As String = Now.ToString("yyyy-MM-dd")
    '        con.Open()

    '        Dim getProductQuery As String = "INSERT INTO ec_cart(productid, patientid, transno, price, quantity, date) VALUES (@productid, @patientid, @transno, @price, @quantity, @date)"
    '        cm = New MySqlCommand(getProductQuery, con)

    '        With cm
    '            .Parameters.AddWithValue("@patientid", frmSales.LBLPID.Text)
    '            .Parameters.AddWithValue("@productid", ProductId)
    '            .Parameters.AddWithValue("@transno", frmSales.LBLTRANSNO.Text)
    '            .Parameters.AddWithValue("@price", Price)
    '            .Parameters.AddWithValue("@date", trans_date)
    '            .Parameters.AddWithValue("@quantity", qty.Value)

    '            .ExecuteNonQuery()


    '        End With
    '        con.Close()

    '        con.Open()

    '        cm = New MySqlCommand("UPDATE ec_cart SET total=price*quantity", con)
    '        cm.ExecuteNonQuery()


    '        con.Close()

    '        frmSales.FillCart()
    '        Me.Dispose()
    '    End If
    'End Sub

    Private Sub frmSalesQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim trans_date As String = Now.ToString("yyyy-MM-dd")

        'Validate the Stock before continuing 
        If LBLAVAILSTOCK.Text = String.Empty Or LBLAVAILSTOCK.Text = "0" Then
            MsgBox("No available item at the moment", vbInformation)
            Exit Sub

        Else

        End If

        con.Open()

        cm = New MySqlCommand("SELECT quantity FROM ec_products WHERE productid ='" & LBLPQID.Text & "' AND quantity >= '" & CInt(LBLAVAILSTOCK.Text) & "'", con)
        dr = cm.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            dr.Close()
            con.Close()
        Else
            MsgBox("Order cannot be processed! Remaining Stock: " & dr.Item("quantity"), vbInformation)
            dr.Close()
            con.Close()
        End If


        con.Open()

        cm = New MySqlCommand("SELECT quantity FROM ec_products WHERE productid ='" & LBLPQID.Text & "'", con)
        dr = cm.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            If qty.Value > dr.Item("quantity") Then
                MsgBox("WARNING: The number of items cannot be processed! Stock Remaining" & dr.Item("quantity"), vbInformation)
                dr.Read()

                con.Close()

                qty.ResetText()
                qty.Focus()
                Exit Sub
            Else
                dr.Read()
                con.Close()
            End If
        End If

        con.Open()

        Dim getProductQuery As String = "INSERT INTO ec_cart(productid, patientid, transno, price, quantity, date) VALUES (@productid, @patientid, @transno, @price, @quantity, @date)"
        cm = New MySqlCommand(getProductQuery, con)

        With cm
            .Parameters.AddWithValue("@patientid", frmSales.LBLPID.Text)
            .Parameters.AddWithValue("@productid", ProductId)
            .Parameters.AddWithValue("@transno", frmSales.LBLTRANSNO.Text)
            .Parameters.AddWithValue("@price", Price)
            .Parameters.AddWithValue("@date", trans_date)
            .Parameters.AddWithValue("@quantity", qty.Value)

            .ExecuteNonQuery()


        End With
        con.Close()

        con.Open()

        cm = New MySqlCommand("UPDATE ec_cart SET total=price*quantity", con)
        cm.ExecuteNonQuery()


        con.Close()

        frmSales.FillCart()
        Me.Dispose()
        UserLog("Order Product")

    End Sub
End Class