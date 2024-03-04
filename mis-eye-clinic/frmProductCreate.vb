Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Text

Public Class frmProductCreate

    Dim isUpdate As Boolean = False
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            Dim mainstream As New MemoryStream
            PictureBox1.BackgroundImage.Save(mainstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mainstream.GetBuffer

            If (MsgBox("Are you sure you want to update this record?", vbYesNo + vbQuestion) = vbYes) Then
                con.Open()
                Dim insertQuery As String = "UPDATE ec_products SET productcode=@productcode, brandid=@brandid, catid=@categoryid, genericid=@genericid, typeid=@typeid, quantity=@quantity, price=@price, productimg=@productimg, frame_age=@frame_age, lens_width=@lens_width, bridge_width=bridge_width WHERE productid=@productid"
                cm = New MySqlCommand(insertQuery, con)
                With cm
                    .Parameters.AddWithValue("@productcode", TXTPCODE.Text)
                    .Parameters.AddWithValue("@brandid", CBObrand.SelectedValue)
                    .Parameters.AddWithValue("@categoryid", CBOlenses.SelectedValue)
                    .Parameters.AddWithValue("@genericid", CBOstyle.SelectedValue)
                    .Parameters.AddWithValue("@typeid", CBOtype.SelectedValue)
                    .Parameters.AddWithValue("@quantity", CInt(TXTQUANTITY.Text))
                    .Parameters.AddWithValue("@price", CInt(TXTPRICE.Text))
                    .Parameters.AddWithValue("@frame_age", CBOFA.Text)
                    .Parameters.AddWithValue("@lens_width", TXTLENSWIDTH.Text)
                    .Parameters.AddWithValue("@bridge_width", TXTBWIDTH.Text)
                    .Parameters.AddWithValue("@temple_length", TXTTLENGTH.Text)
                    .Parameters.AddWithValue("@lens_height", TXTLHEIGHT.Text)
                    .Parameters.AddWithValue("@material", TXTMATERIAL.Text)
                    .Parameters.AddWithValue("@scatid", CBOsub.SelectedValue)
                    .Parameters.AddWithValue("@productimg", arrImage)

                    .ExecuteNonQuery()

                End With

                MsgBox("Record has been successfully saved.", vbInformation)
                con.Close()
                Clear()

                With frmProduct
                    .FillProducts()
                End With
                Me.Dispose()

                UserLog("Modify and Update Product")

            End If

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim arrImage() As Byte




        Try
            If PictureBox1.BackgroundImage Is Nothing Then
                MsgBox("WARNING: You're required to put an image!", vbInformation)
            Else

                Dim mainstream As New MemoryStream

                PictureBox1.BackgroundImage.Save(mainstream, System.Drawing.Imaging.ImageFormat.Jpeg)

                arrImage = mainstream.GetBuffer

                con.Open()
                Dim insertQuery As String = "INSERT INTO ec_products(productcode, brandid, catid, genericid, typeid, quantity, price, productimg, frame_age, lens_width, bridge_width, temple_length, lens_height, material, scatid) VALUES (@productcode, @brandid, @categoryid, @genericid, @typeid, @quantity, @price, @productimg, @frame_age, @lens_width, @bridge_width, @temple_length, @lens_height, @material, @scatid)"
                cm = New MySqlCommand(insertQuery, con)

                With cm
                    .Parameters.AddWithValue("@productcode", TXTPCODE.Text)
                    .Parameters.AddWithValue("@brandid", CBObrand.SelectedValue)
                    .Parameters.AddWithValue("@categoryid", CBOlenses.SelectedValue)
                    .Parameters.AddWithValue("@genericid", CBOstyle.SelectedValue)
                    .Parameters.AddWithValue("@typeid", CBOtype.SelectedValue)
                    .Parameters.AddWithValue("@quantity", CInt(TXTQUANTITY.Text))
                    .Parameters.AddWithValue("@price", CInt(TXTPRICE.Text))
                    .Parameters.AddWithValue("@frame_age", CBOFA.Text)
                    .Parameters.AddWithValue("@lens_width", TXTLENSWIDTH.Text)
                    .Parameters.AddWithValue("@bridge_width", TXTBWIDTH.Text)
                    .Parameters.AddWithValue("@temple_length", TXTTLENGTH.Text)
                    .Parameters.AddWithValue("@lens_height", TXTLHEIGHT.Text)
                    .Parameters.AddWithValue("@material", TXTMATERIAL.Text)
                    .Parameters.AddWithValue("@scatid", CBOsub.SelectedValue)
                    .Parameters.AddWithValue("@productimg", arrImage)

                    .ExecuteNonQuery()

                End With

                MsgBox("Record has been successfully saved.", vbInformation)
                con.Close()
                Clear()

                With frmProduct
                    .FillProducts()
                End With
                UserLog("Insert and Save new Product")

            End If



        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Clear()
        TXTLENSWIDTH.Clear()
        CBOFA.Text = ""
        TXTPCODE.Clear()
        TXTQUANTITY.Clear()
        TXTPRICE.Clear()
        TXTLHEIGHT.Clear()
        TXTMATERIAL.Clear()
        TXTBWIDTH.Clear()
        TXTTLENGTH.Clear()

        CBObrand.SelectedIndex = -1
        CBOlenses.SelectedIndex = -1
        CBOstyle.SelectedIndex = -1
        CBOtype.SelectedIndex = -1
        CBOsub.SelectedIndex = -1

        PictureBox1.BackgroundImage = Nothing
    End Sub



    Sub FillGenericAutoSuggest()
        con.Open()
        Dim query As String = "SELECT * FROM ec_generic ORDER BY genericname"
        cm = New MySqlCommand(query, con)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "genericname")
        Dim col As New AutoCompleteStringCollection
        For id As Integer = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(id)("genericname").ToString)
        Next
        'TXTGN.AutoCompleteSource = AutoCompleteSource.CustomSource
        'TXTGN.AutoCompleteCustomSource = col
        'TXTGN.AutoCompleteMode = AutoCompleteMode.Suggest
        cm = Nothing
        con.Close()
    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using odf As New OpenFileDialog With {.Filter = "(Image.Files)|*.jpg;*.png;*.jpeg; *.jpeg|*.jpg|*.png",
                                .Multiselect = False, .Title = "Select Image"}
            If odf.ShowDialog = 1 Then
                PictureBox1.BackgroundImage = Image.FromFile(odf.FileName)
            End If
        End Using
    End Sub




    Private Sub TXTBN_TextChanged_1(sender As Object, e As EventArgs)
        'Try
        '    con.Open()
        '    cm = New MySqlCommand("SELECT * FROM ec_brand WHERE brandname=@brandname", con)
        '    cm.Parameters.AddWithValue("@brandname", TXTBN.Text)
        '    dr = cm.ExecuteReader
        '    dr.Read()

        '    If dr.HasRows Then
        '        LBLBN.Text = dr.Item(0).ToString
        '    Else
        '        LBLBN.Text = String.Empty
        '    End If
        '    cm = Nothing
        '    dr.Close()
        '    con.Close()
        'Catch ex As Exception
        '    con.Close()
        '    MsgBox(ex.Message, vbCritical)
        'End Try
    End Sub




    Sub FillSubCategory()

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim subQuery As String = "SELECT * FROM ec_catsub_eye"


        con.Open()
        cm = New MySqlCommand(subQuery, con)
        da.SelectCommand = cm
        CBOsub.Items.Clear()


        da.Fill(dt)

        CBOsub.DataSource = dt
        CBOsub.ValueMember = "scatid"
        CBOsub.DisplayMember = "sub_name"
        CBOsub.Text = "Select a category"
        con.Close()
    End Sub

    Sub FillStyle()

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim styleQuery As String = "SELECT * FROM ec_generic"


        con.Open()
        cm = New MySqlCommand(styleQuery, con)
        da.SelectCommand = cm


        da.Fill(dt)

        CBOstyle.DataSource = dt
        CBOstyle.ValueMember = "genericid"
        CBOstyle.DisplayMember = "genericname"
        CBOstyle.Text = "Select a category"
        con.Close()
    End Sub

    Sub FillType()

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim typeQuery As String = "SELECT * FROM ec_type"


        con.Open()
        cm = New MySqlCommand(typeQuery, con)
        da.SelectCommand = cm


        da.Fill(dt)

        CBOtype.DataSource = dt
        CBOtype.ValueMember = "typeid"
        CBOtype.DisplayMember = "typename"
        CBObrand.Text = "Select a category"
        con.Close()
    End Sub

    Sub FillBrand()
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim brandQuery As String = "SELECT * FROM ec_brand"

        con.Open()
        cm = New MySqlCommand(brandQuery, con)
        da.SelectCommand = cm


        da.Fill(dt)

        CBObrand.DataSource = dt
        CBObrand.ValueMember = "brandid"
        CBObrand.DisplayMember = "brandname"
        CBObrand.Text = "Select a category"
        con.Close()
    End Sub

    Sub FillLenses()
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable
        Dim lenseQuery As String = "SELECT * FROM ec_category"

        con.Open()
        cm = New MySqlCommand(lenseQuery, con)
        da.SelectCommand = cm


        da.Fill(dt)

        CBOlenses.DataSource = dt
        CBOlenses.ValueMember = "catid"
        CBOlenses.DisplayMember = "catname"
        CBObrand.Text = "Select a category"
        con.Close()
    End Sub
    Function GenerateProductCode() As String
        Dim validchars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"

        Dim sb As New StringBuilder()
        Dim rand As New Random()
        For i As Integer = 1 To 6
            Dim idx As Integer = rand.Next(0, validchars.Length)
            Dim randomChar As Char = validchars(idx)
            sb.Append(randomChar)
        Next i

        Dim randomString = sb.ToString()

        Return "PRC-" & randomString
    End Function

    Private Sub frmProductCreate_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

End Class