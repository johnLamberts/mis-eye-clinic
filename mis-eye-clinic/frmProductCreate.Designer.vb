<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductCreate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBLID = New System.Windows.Forms.Label()
        Me.LBLIDLABEL = New System.Windows.Forms.Label()
        Me.TXTPCODE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CBObrand = New System.Windows.Forms.ComboBox()
        Me.CBOstyle = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.CBOtype = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTBWIDTH = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTLENSWIDTH = New System.Windows.Forms.TextBox()
        Me.TXTTLENGTH = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTLHEIGHT = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTMATERIAL = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXTPRICE = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXTQUANTITY = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CBOsub = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CBOlenses = New System.Windows.Forms.ComboBox()
        Me.CBOFA = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.LBLID)
        Me.Panel1.Controls.Add(Me.LBLIDLABEL)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1112, 70)
        Me.Panel1.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(542, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 18)
        Me.Label10.TabIndex = 17
        '
        'LBLID
        '
        Me.LBLID.ForeColor = System.Drawing.Color.White
        Me.LBLID.Location = New System.Drawing.Point(1059, 42)
        Me.LBLID.Name = "LBLID"
        Me.LBLID.Size = New System.Drawing.Size(41, 18)
        Me.LBLID.TabIndex = 17
        Me.LBLID.Visible = False
        '
        'LBLIDLABEL
        '
        Me.LBLIDLABEL.AutoSize = True
        Me.LBLIDLABEL.ForeColor = System.Drawing.Color.White
        Me.LBLIDLABEL.Location = New System.Drawing.Point(975, 42)
        Me.LBLIDLABEL.Name = "LBLIDLABEL"
        Me.LBLIDLABEL.Size = New System.Drawing.Size(84, 18)
        Me.LBLIDLABEL.TabIndex = 17
        Me.LBLIDLABEL.Text = "Product ID: "
        Me.LBLIDLABEL.Visible = False
        '
        'TXTPCODE
        '
        Me.TXTPCODE.Font = New System.Drawing.Font("Bahnschrift Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPCODE.Location = New System.Drawing.Point(43, 105)
        Me.TXTPCODE.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTPCODE.Name = "TXTPCODE"
        Me.TXTPCODE.ReadOnly = True
        Me.TXTPCODE.Size = New System.Drawing.Size(183, 21)
        Me.TXTPCODE.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light", 8.0!)
        Me.Label1.Location = New System.Drawing.Point(39, 91)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Product Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(551, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Brand Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(829, 183)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Style"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(826, 108)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(549, 181)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 261)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Frame Age"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(404, 509)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(138, 35)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(593, 509)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 35)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(404, 509)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(138, 35)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(43, 158)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 225)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(43, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(183, 35)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Browse Image"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CBObrand
        '
        Me.CBObrand.FormattingEnabled = True
        Me.CBObrand.Location = New System.Drawing.Point(553, 131)
        Me.CBObrand.Name = "CBObrand"
        Me.CBObrand.Size = New System.Drawing.Size(223, 26)
        Me.CBObrand.TabIndex = 20
        Me.CBObrand.Text = "Select Brand"
        '
        'CBOstyle
        '
        Me.CBOstyle.FormattingEnabled = True
        Me.CBOstyle.Location = New System.Drawing.Point(834, 206)
        Me.CBOstyle.Name = "CBOstyle"
        Me.CBOstyle.Size = New System.Drawing.Size(220, 26)
        Me.CBOstyle.TabIndex = 21
        Me.CBOstyle.Text = "Select Style"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Male", "Gender"})
        Me.ComboBox3.Location = New System.Drawing.Point(833, 131)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(222, 26)
        Me.ComboBox3.TabIndex = 22
        Me.ComboBox3.Text = "Select Gender"
        '
        'CBOtype
        '
        Me.CBOtype.FormattingEnabled = True
        Me.CBOtype.Location = New System.Drawing.Point(553, 207)
        Me.CBOtype.Name = "CBOtype"
        Me.CBOtype.Size = New System.Drawing.Size(222, 26)
        Me.CBOtype.TabIndex = 23
        Me.CBOtype.Text = "Select Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(551, 339)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 18)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Bridge Width"
        '
        'TXTBWIDTH
        '
        Me.TXTBWIDTH.Location = New System.Drawing.Point(553, 359)
        Me.TXTBWIDTH.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTBWIDTH.Name = "TXTBWIDTH"
        Me.TXTBWIDTH.Size = New System.Drawing.Size(222, 26)
        Me.TXTBWIDTH.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(551, 261)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 18)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Lens Width"
        '
        'TXTLENSWIDTH
        '
        Me.TXTLENSWIDTH.Location = New System.Drawing.Point(553, 283)
        Me.TXTLENSWIDTH.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTLENSWIDTH.Name = "TXTLENSWIDTH"
        Me.TXTLENSWIDTH.Size = New System.Drawing.Size(222, 26)
        Me.TXTLENSWIDTH.TabIndex = 25
        '
        'TXTTLENGTH
        '
        Me.TXTTLENGTH.Location = New System.Drawing.Point(834, 281)
        Me.TXTTLENGTH.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTTLENGTH.Name = "TXTTLENGTH"
        Me.TXTTLENGTH.Size = New System.Drawing.Size(220, 26)
        Me.TXTTLENGTH.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(826, 258)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 18)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Temple Length"
        '
        'TXTLHEIGHT
        '
        Me.TXTLHEIGHT.Location = New System.Drawing.Point(275, 359)
        Me.TXTLHEIGHT.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTLHEIGHT.Name = "TXTLHEIGHT"
        Me.TXTLHEIGHT.Size = New System.Drawing.Size(222, 26)
        Me.TXTLHEIGHT.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(270, 339)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 18)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Lens Height"
        '
        'TXTMATERIAL
        '
        Me.TXTMATERIAL.Location = New System.Drawing.Point(833, 356)
        Me.TXTMATERIAL.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTMATERIAL.Name = "TXTMATERIAL"
        Me.TXTMATERIAL.Size = New System.Drawing.Size(223, 26)
        Me.TXTMATERIAL.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(829, 333)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 18)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Material"
        '
        'TXTPRICE
        '
        Me.TXTPRICE.Location = New System.Drawing.Point(275, 435)
        Me.TXTPRICE.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTPRICE.Name = "TXTPRICE"
        Me.TXTPRICE.Size = New System.Drawing.Size(222, 26)
        Me.TXTPRICE.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(273, 417)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 18)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Initial Price"
        '
        'TXTQUANTITY
        '
        Me.TXTQUANTITY.Location = New System.Drawing.Point(553, 435)
        Me.TXTQUANTITY.Margin = New System.Windows.Forms.Padding(4)
        Me.TXTQUANTITY.Name = "TXTQUANTITY"
        Me.TXTQUANTITY.Size = New System.Drawing.Size(222, 26)
        Me.TXTQUANTITY.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(551, 417)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 18)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Initial Quantity"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(272, 108)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 18)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Sub Category"
        '
        'CBOsub
        '
        Me.CBOsub.FormattingEnabled = True
        Me.CBOsub.Location = New System.Drawing.Point(275, 131)
        Me.CBOsub.Name = "CBOsub"
        Me.CBOsub.Size = New System.Drawing.Size(223, 26)
        Me.CBOsub.TabIndex = 29
        Me.CBOsub.Text = "Select Sub Categoory"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(270, 182)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 18)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Contact Lenses"
        '
        'CBOlenses
        '
        Me.CBOlenses.FormattingEnabled = True
        Me.CBOlenses.Items.AddRange(New Object() {"Male", "Gender"})
        Me.CBOlenses.Location = New System.Drawing.Point(275, 207)
        Me.CBOlenses.Name = "CBOlenses"
        Me.CBOlenses.Size = New System.Drawing.Size(222, 26)
        Me.CBOlenses.TabIndex = 22
        Me.CBOlenses.Text = "Select Lenses"
        '
        'CBOFA
        '
        Me.CBOFA.FormattingEnabled = True
        Me.CBOFA.Items.AddRange(New Object() {"Adult", "Child"})
        Me.CBOFA.Location = New System.Drawing.Point(273, 283)
        Me.CBOFA.Name = "CBOFA"
        Me.CBOFA.Size = New System.Drawing.Size(225, 26)
        Me.CBOFA.TabIndex = 30
        '
        'frmProductCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1112, 577)
        Me.ControlBox = False
        Me.Controls.Add(Me.CBOFA)
        Me.Controls.Add(Me.CBOsub)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TXTQUANTITY)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TXTMATERIAL)
        Me.Controls.Add(Me.TXTPRICE)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXTLHEIGHT)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXTTLENGTH)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXTBWIDTH)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXTLENSWIDTH)
        Me.Controls.Add(Me.CBOtype)
        Me.Controls.Add(Me.CBOlenses)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.CBOstyle)
        Me.Controls.Add(Me.CBObrand)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTPCODE)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Bahnschrift Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmProductCreate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TXTPCODE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents LBLIDLABEL As Label
    Friend WithEvents LBLID As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CBObrand As ComboBox
    Friend WithEvents CBOstyle As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents CBOtype As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTBWIDTH As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTLENSWIDTH As TextBox
    Friend WithEvents TXTTLENGTH As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTLHEIGHT As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TXTMATERIAL As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TXTPRICE As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TXTQUANTITY As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents CBOsub As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents CBOlenses As ComboBox
    Friend WithEvents CBOFA As ComboBox
End Class
