<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClinicPay
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBODISCOUNT = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLPN = New System.Windows.Forms.Label()
        Me.LBLDESCRIPTION = New System.Windows.Forms.Label()
        Me.LBLPRICE = New System.Windows.Forms.Label()
        Me.LBLAMOUNT = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBLDISCOUNT = New System.Windows.Forms.Label()
        Me.CBOPTYPE = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTCHANGE = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTCASH = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LBLBID = New System.Windows.Forms.Label()
        Me.LBLAPID = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LBLAPID)
        Me.Panel1.Controls.Add(Me.LBLBID)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 68)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 19)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Bill ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(27, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Patient Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(38, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(55, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Unit Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(25, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Discount Type:"
        '
        'CBODISCOUNT
        '
        Me.CBODISCOUNT.FormattingEnabled = True
        Me.CBODISCOUNT.Location = New System.Drawing.Point(140, 207)
        Me.CBODISCOUNT.Name = "CBODISCOUNT"
        Me.CBODISCOUNT.Size = New System.Drawing.Size(181, 24)
        Me.CBODISCOUNT.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(69, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Amount:"
        '
        'LBLPN
        '
        Me.LBLPN.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLPN.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.LBLPN.Location = New System.Drawing.Point(140, 107)
        Me.LBLPN.Name = "LBLPN"
        Me.LBLPN.Size = New System.Drawing.Size(185, 19)
        Me.LBLPN.TabIndex = 4
        '
        'LBLDESCRIPTION
        '
        Me.LBLDESCRIPTION.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLDESCRIPTION.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.LBLDESCRIPTION.Location = New System.Drawing.Point(140, 142)
        Me.LBLDESCRIPTION.Name = "LBLDESCRIPTION"
        Me.LBLDESCRIPTION.Size = New System.Drawing.Size(185, 19)
        Me.LBLDESCRIPTION.TabIndex = 4
        '
        'LBLPRICE
        '
        Me.LBLPRICE.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLPRICE.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.LBLPRICE.Location = New System.Drawing.Point(140, 177)
        Me.LBLPRICE.Name = "LBLPRICE"
        Me.LBLPRICE.Size = New System.Drawing.Size(185, 19)
        Me.LBLPRICE.TabIndex = 4
        '
        'LBLAMOUNT
        '
        Me.LBLAMOUNT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLAMOUNT.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.LBLAMOUNT.Location = New System.Drawing.Point(140, 335)
        Me.LBLAMOUNT.Name = "LBLAMOUNT"
        Me.LBLAMOUNT.Size = New System.Drawing.Size(185, 19)
        Me.LBLAMOUNT.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 514)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(364, 10)
        Me.Panel2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(93, 467)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Pay Now"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(206, 467)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 28)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(58, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Discount:"
        '
        'LBLDISCOUNT
        '
        Me.LBLDISCOUNT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLDISCOUNT.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.LBLDISCOUNT.Location = New System.Drawing.Point(136, 248)
        Me.LBLDISCOUNT.Name = "LBLDISCOUNT"
        Me.LBLDISCOUNT.Size = New System.Drawing.Size(185, 19)
        Me.LBLDISCOUNT.TabIndex = 4
        '
        'CBOPTYPE
        '
        Me.CBOPTYPE.Enabled = False
        Me.CBOPTYPE.FormattingEnabled = True
        Me.CBOPTYPE.Items.AddRange(New Object() {"Cash", "GCash", "PayMaya"})
        Me.CBOPTYPE.Location = New System.Drawing.Point(140, 287)
        Me.CBOPTYPE.Name = "CBOPTYPE"
        Me.CBOPTYPE.Size = New System.Drawing.Size(181, 24)
        Me.CBOPTYPE.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(28, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Payment Type"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.TXTCHANGE)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.TXTCASH)
        Me.Panel3.Location = New System.Drawing.Point(0, 357)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(364, 117)
        Me.Panel3.TabIndex = 15
        Me.Panel3.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Change"
        '
        'TXTCHANGE
        '
        Me.TXTCHANGE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTCHANGE.Enabled = False
        Me.TXTCHANGE.Location = New System.Drawing.Point(81, 69)
        Me.TXTCHANGE.Name = "TXTCHANGE"
        Me.TXTCHANGE.ReadOnly = True
        Me.TXTCHANGE.Size = New System.Drawing.Size(244, 23)
        Me.TXTCHANGE.TabIndex = 4
        Me.TXTCHANGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Cash"
        '
        'TXTCASH
        '
        Me.TXTCASH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTCASH.Location = New System.Drawing.Point(81, 22)
        Me.TXTCASH.Name = "TXTCASH"
        Me.TXTCASH.Size = New System.Drawing.Size(244, 23)
        Me.TXTCASH.TabIndex = 2
        Me.TXTCASH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 19)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Appt_ID:"
        '
        'LBLBID
        '
        Me.LBLBID.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.LBLBID.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.LBLBID.ForeColor = System.Drawing.Color.White
        Me.LBLBID.Location = New System.Drawing.Point(82, 39)
        Me.LBLBID.Name = "LBLBID"
        Me.LBLBID.Size = New System.Drawing.Size(56, 19)
        Me.LBLBID.TabIndex = 2
        '
        'LBLAPID
        '
        Me.LBLAPID.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.LBLAPID.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.LBLAPID.ForeColor = System.Drawing.Color.White
        Me.LBLAPID.Location = New System.Drawing.Point(89, 20)
        Me.LBLAPID.Name = "LBLAPID"
        Me.LBLAPID.Size = New System.Drawing.Size(56, 19)
        Me.LBLAPID.TabIndex = 3
        '
        'frmClinicPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(364, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CBOPTYPE)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LBLDISCOUNT)
        Me.Controls.Add(Me.LBLAMOUNT)
        Me.Controls.Add(Me.LBLPRICE)
        Me.Controls.Add(Me.LBLDESCRIPTION)
        Me.Controls.Add(Me.LBLPN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBODISCOUNT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmClinicPay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CBODISCOUNT As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LBLPN As Label
    Friend WithEvents LBLDESCRIPTION As Label
    Friend WithEvents LBLPRICE As Label
    Friend WithEvents LBLAMOUNT As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents LBLDISCOUNT As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CBOPTYPE As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTCHANGE As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXTCASH As TextBox
    Friend WithEvents LBLAPID As Label
    Friend WithEvents LBLBID As Label
    Friend WithEvents Label11 As Label
End Class
