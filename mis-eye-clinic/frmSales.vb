Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmSales
    Dim typeBtn As New Button
    Dim prodPic As New PictureBox
    Dim lblCode As New Label
    Dim lblPrice As New Label
    Dim _filterx As String
    Dim newPanel As New FlowLayoutPanel
    Dim lblCat As New Label


    Sub FillCart()
        DataGridView1.Rows.Clear()
        Try
            Dim total As Double
            Dim qty As Double

            con.Open()
            Dim getCartData As String = "SELECT cartid, c.price, c.quantity, p.quantity as StockAvailable, c.total, p.productcode, patientid, CONCAT(fname, ' ', lname) as FullName, productid FROM ec_cart c JOIN ec_products p USING(productid) JOIN ec_patients USING(patientid) WHERE c.transno='" & LBLTRANSNO.Text & "' AND c.status='Pending'"
            cm = New MySqlCommand(getCartData, con)
            dr = cm.ExecuteReader

            While dr.Read
                total += CDbl(dr.Item("total").ToString)
                qty += CInt(dr.Item("quantity").ToString)
                DataGridView1.Rows.Add(dr.Item("cartid").ToString, dr.Item("productid").ToString, dr.Item("productcode").ToString, dr.Item("price").ToString, dr.Item("quantity").ToString, dr.Item("total").ToString, "Remove")
            End While

            LBLTOTALAMOUNT.Visible = True
            LBLTOTALAMOUNT.Text = Format(total, "#,###,##0.00")

            With frmSalesSettlePayment
                .TXTPTNAME.Text = dr.Item("FullName")
                .LBLUSERID.Text = dr.Item("patientid")
                .TXTTOTAL.Text = Format(total, "#,###,###,##0.00")
                .TXTQUANTITY.Text = qty
                .LBLSTOCKAVAILABLE.Text = dr.Item("StockAvailable").ToString
            End With

            dr.Close()

            con.Close()


            If DataGridView1.Rows.Count < 1 Then
                btnCheckOut.Enabled = False

            Else
                btnCheckOut.Enabled = True
            End If

            frmSalesSettlePayment.LBLUSER.Text = firstName & lastName


        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub GetPatientsCart()
        Dim hasCart As Boolean
        Dim transno As String

        cm = New MySqlCommand("SELECT * FROM ec_cart WHERE patientid LIKE'" & LBLPID.Text & "' AND status='Pending'", con)
        con.Open()
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            hasCart = True
            transno = dr.Item("transno").ToString
        Else
            hasCart = False
            DataGridView1.Rows.Clear()
        End If
        dr.Close()
        con.Close()

        If hasCart = True Then
            LBLTRANSNO.Text = transno
            FillCart()
        End If
    End Sub

    Function TransNo() As String
        Dim newDate As String = Now.ToString("yyyyMMdd")

        Try

            con.Open()
            cm = New MySqlCommand("SELECT * FROM ec_cart WHERE transno LIKE '" & newDate & "%' ORDER BY cartid DESC", con)
            dr = cm.ExecuteReader

            dr.Read()


            If dr.HasRows Then
                TransNo = CLng(dr.Item("transno").ToString) + 1
            Else
                TransNo = newDate & "0001"
            End If

            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
        Return TransNo

    End Function





    Sub FillTypeButtons()
        con.Open()
        Dim typeQuery As String = "SELECT * FROM ec_catsub_eye JOIN ec_cateye USING (catid)"
        cm = New MySqlCommand(typeQuery, con)

        dr = cm.ExecuteReader

        While dr.Read
            typeBtn = New Button
            typeBtn.Width = 100
            typeBtn.Height = 35
            typeBtn.Text = dr.Item("sub_name")
            typeBtn.FlatStyle = FlatStyle.Flat
            typeBtn.BackColor = Color.FromArgb(9, 132, 227)
            typeBtn.ForeColor = Color.White
            typeBtn.Cursor = Cursors.Hand

            'lblCat = New Label
            'lblCat.Text = dr.Item("eye_name")
            'newPanel.Controls.Add(typeBtn)


            FlowLayoutPanel1.Controls.Add(typeBtn)
            FlowLayoutPanel1.Controls.Add(lblCat)


            AddHandler typeBtn.Click, AddressOf filterClick
        End While

        dr.Close()
        con.Close()

    End Sub

    Public Sub filterClick(sender As Object, e As EventArgs)

        If LBLPID.Text = String.Empty Then
            MsgBox("Please select a patient before continuing!", vbCritical)
            Return
        End If
        _filterx = sender.text.ToString

        FillProductsContainer()
    End Sub

    Sub FillProductsContainer()

        FlowLayoutPanel3.AutoScroll = True
        FlowLayoutPanel3.Controls.Clear()

        con.Open()

        Dim prodQuery As String = "SELECT productimg, productid, productcode, price, sub_name FROM ec_products JOIN ec_catsub_eye USING(scatid) WHERE sub_name LIKE '" & _filterx & "%'"
        cm = New MySqlCommand(prodQuery, con)

        dr = cm.ExecuteReader

        While dr.Read

            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte

            dr.GetBytes(0, 0, array, 0, CInt(len))

            Dim ms As New MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)

            prodPic = New PictureBox
            prodPic.BackgroundImage = bitmap
            prodPic.Width = 120
            prodPic.Height = 160
            prodPic.BackgroundImageLayout = ImageLayout.Stretch
            prodPic.Tag = dr.Item("productid").ToString


            lblCode = New Label
            lblCode.BackColor = Color.FromArgb(250, 177, 160)
            lblCode.ForeColor = Color.FromArgb(0, 0, 0)
            lblCode.Text = dr.Item("productcode").ToString
            lblCode.TextAlign = ContentAlignment.MiddleCenter
            lblCode.Dock = DockStyle.Top
            lblCode.Tag = dr.Item("productid").ToString

            lblPrice = New Label
            lblPrice.BackColor = Color.FromArgb(45, 52, 54)
            lblPrice.ForeColor = Color.White
            lblPrice.Text = dr.Item("price").ToString()
            lblPrice.Text = "P" & Format(CInt(lblPrice.Text), "###,###,##0.00")

            lblPrice.TextAlign = ContentAlignment.MiddleCenter
            lblPrice.Dock = DockStyle.Bottom
            lblPrice.Tag = dr.Item("productid").ToString()

            prodPic.Controls.Add(lblCode)
            prodPic.Controls.Add(lblPrice)
            FlowLayoutPanel3.Controls.Add(prodPic)


            AddHandler prodPic.Click, AddressOf selectClick
            AddHandler lblCode.Click, AddressOf selectClick
            AddHandler lblPrice.Click, AddressOf selectClick


        End While

        dr.Close()

        con.Close()

        'FillPatientComboBox()

    End Sub

    Public Sub selectClick(sender As Object, e As EventArgs)
        Try
            Dim productCode As String, price As Double

            Dim productid As String = sender.tag.ToString()

            con.Open()

            Dim getProductQuery As String = "SELECT productid, productcode, price FROM ec_products WHERE productid='" & productid & "'"
            'Dim displayProduct As String = "SELECT productimg, productid, productcode, price, brandname, typename FROM ec_products JOIN ec_brand USING(brandid) JOIN ec_type USING(typeid) WHERE productid='" & productid & "'"
            cm = New MySqlCommand(getProductQuery, con)

            dr = cm.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                productCode = dr.Item("productcode").ToString
                price = CDbl(dr.Item("price").ToString)
            End If




            dr.Close()
            con.Close()

            If LBLPID.Text = String.Empty Then
                MsgBox("Please select a customer first!", vbCritical)
            Else
                With frmSalesQuantity
                    Dim displayProduct As String = "SELECT  productimg, productid,  productcode, price, brandname, typename, quantity, sub_name FROM ec_products JOIN ec_brand USING(brandid) JOIN ec_type USING(typeid) JOIN ec_catsub_eye USING(scatid) WHERE productid='" & productid & "'"
                    cm = New MySqlCommand(displayProduct, con)
                    con.Open()
                    dr = cm.ExecuteReader
                    dr.Read()
                    Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
                    Dim array(CInt(len)) As Byte
                    dr.GetBytes(0, 0, array, 0, CInt(len))
                    Dim ms As New MemoryStream(array)
                    Dim bitmap As New System.Drawing.Bitmap(ms)
                    .PictureBox1.BackgroundImage = bitmap
                    .LBLPQID.Text = productid
                    .LBLPQCODE.Text = dr.Item("productcode").ToString
                    .LBLPQPRICE.Text = price
                    .LBLPQBRAND.Text = dr.Item("brandname").ToString
                    .LBLPQTYPE.Text = dr.Item("typename").ToString
                    .LBLAVAILSTOCK.Text = dr.Item("quantity").ToString
                    .AddToCart(productid, price)
                    .Show()
                    dr.Close()
                    con.Close()

                End With
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub




    Private Sub frmSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillTypeButtons()
        FillProductsContainer()

    End Sub


    Sub RefreshControls()
        Me.Controls.Clear()
        Me.InitializeComponent()

        FillTypeButtons()
        FillProductsContainer()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Refresh()

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LBLTRANSNO.Text = TransNo()
        With frmSalesViewBills
            .FillPatientsButton()
            .ShowDialog()
        End With
    End Sub






    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With frmSalesRecord
            .FillSalesRecords()
            .ShowDialog()
        End With
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RefreshControls()

    End Sub

    Private Sub btnCheckOut_Click_1(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        With frmSalesSettlePayment
            .ShowDialog()

        End With
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        With frmMainForm
            .Show()
        End With
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName = DataGridView1.Columns(e.ColumnIndex).Name

        If colName = "Delete" Then
            con.Open()
            Dim query = "DELETE FROM ec_cart WHERE cartid='" & DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString & "'"
            cm = New MySqlCommand(query, con)
            cm.ExecuteNonQuery()
            con.Close()
            MsgBox("Record has been successfully deleted.", vbInformation)
            GetPatientsCart()

        End If
    End Sub



End Class