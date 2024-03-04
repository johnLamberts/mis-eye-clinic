Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmProduct
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With frmProductCreate
            .btnAdd.Show()
            .btnUpdate.Hide()
            .TXTPCODE.Text = .GenerateProductCode()

            .FillSubCategory()
            .FillType()
            .FillStyle()
            .FillBrand()
            .FillLenses()



            .ShowDialog()
        End With
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Sub FillProducts()
        Dim nos As Integer = 0
        DataGridView1.Rows.Clear()

        con.Open()
        Dim getProductQuery As String = "SELECT * FROM ec_products JOIN ec_brand USING(brandid) JOIN ec_type USING(typeid) JOIN ec_category USING(catid) JOIN ec_generic USING(genericid) JOIN ec_catsub_eye USING(scatid) "
        cm = New MySqlCommand(getProductQuery, con)
        dr = cm.ExecuteReader

        While dr.Read
            nos += 1
            DataGridView1.Rows.Add(nos, dr.Item("productid").ToString, dr.Item("productcode").ToString, dr.Item("sub_name").ToString, dr.Item("brandname").ToString, dr.Item("catname").ToString, dr.Item("genericname").ToString, dr.Item("typename").ToString, dr.Item("material").ToString, dr.Item("lens_width").ToString & "-" & dr.Item("bridge_width").ToString & "-" & dr.Item("temple_length").ToString & "-" & dr.Item("lens_height").ToString, dr.Item("frame_age").ToString, dr.Item("price").ToString, dr.Item("quantity").ToString, dr.Item("productimg"), "Modify", "Delete")
        End While
        LBLCOUNT.Text = "(" & DataGridView1.RowCount & ") record(s) found."
        dr.Close()
        con.Close()


        For i = 0 To DataGridView1.Rows.Count - 1
            Dim row As DataGridViewRow = DataGridView1.Rows(i)
            row.Height = 100
        Next

        Dim imagecol = DirectCast(DataGridView1.Columns("productimg"), DataGridViewImageColumn)
        imagecol.ImageLayout = DataGridViewImageCellLayout.Stretch
        imagecol.Width = 20
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name

        If colName = "Modify" Then
            Try
                With frmProductCreate




                    .LBLID.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString

                    .TXTPCODE.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString

                    .CBOsub.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString

                    .CBObrand.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString

                    .CBOstyle.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString

                    .CBOlenses.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString

                    .CBOtype.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString


                    .ComboBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString

                    Dim rowData As String = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString

                    Dim arr() As String = rowData.Split("-")

                    .TXTLENSWIDTH.Text = arr(0)
                    .TXTBWIDTH.Text = arr(1)
                    .TXTTLENGTH.Text = arr(2)
                    .TXTLHEIGHT.Text = arr(3)


                    .TXTMATERIAL.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
                    .CBOFA.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString

                    .TXTPRICE.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString
                    .TXTQUANTITY.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value.ToString
                    .LBLID.Show()
                    .LBLIDLABEL.Show()
                    .btnAdd.Hide()
                    .btnUpdate.Show()

                    .FillSubCategory()
                    .FillType()
                    .FillStyle()
                    .FillBrand()
                    .FillLenses()

                    .ShowDialog()

                End With
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
        ElseIf colName = "Delete" Then
            If (MsgBox("Are you sure you want to delete this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                Dim query = "DELETE FROM ec_products WHERE productid='" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'"
                cm = New MySqlCommand(query, con)
                cm.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been successfully deleted.", vbInformation)
                FillProducts()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With frmProductStocks
            .FillProductOnStock()
            '.FillStockHistory()

            .ShowDialog()
        End With
    End Sub

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillProducts()

    End Sub
End Class