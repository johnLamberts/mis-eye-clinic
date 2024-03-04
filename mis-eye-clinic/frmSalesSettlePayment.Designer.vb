<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalesSettlePayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBLSTOCKAVAILABLE = New System.Windows.Forms.Label()
        Me.LBLUSER = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTPTNAME = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTDISC = New System.Windows.Forms.TextBox()
        Me.TXTTOTALDUE = New System.Windows.Forms.TextBox()
        Me.CMBPAYMENTTYPE = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTTOTAL = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CMBDISTYPE = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTCASH = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTCHANGE = New System.Windows.Forms.TextBox()
        Me.LBLUSERID = New System.Windows.Forms.Label()
        Me.TXTQUANTITY = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LBLSTOCKAVAILABLE)
        Me.Panel1.Controls.Add(Me.LBLUSER)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 56)
        Me.Panel1.TabIndex = 0
        '
        'LBLSTOCKAVAILABLE
        '
        Me.LBLSTOCKAVAILABLE.Font = New System.Drawing.Font("Bahnschrift Light", 8.0!)
        Me.LBLSTOCKAVAILABLE.ForeColor = System.Drawing.Color.White
        Me.LBLSTOCKAVAILABLE.Location = New System.Drawing.Point(95, 37)
        Me.LBLSTOCKAVAILABLE.Name = "LBLSTOCKAVAILABLE"
        Me.LBLSTOCKAVAILABLE.Size = New System.Drawing.Size(101, 13)
        Me.LBLSTOCKAVAILABLE.TabIndex = 0
        '
        'LBLUSER
        '
        Me.LBLUSER.Font = New System.Drawing.Font("Bahnschrift Light", 8.0!)
        Me.LBLUSER.ForeColor = System.Drawing.Color.White
        Me.LBLUSER.Location = New System.Drawing.Point(385, 37)
        Me.LBLUSER.Name = "LBLUSER"
        Me.LBLUSER.Size = New System.Drawing.Size(101, 13)
        Me.LBLUSER.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift Light", 8.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Avalaible Stock:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift Light", 8.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(290, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "In-Charge Person: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Discount"
        '
        'TXTPTNAME
        '
        Me.TXTPTNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTPTNAME.Location = New System.Drawing.Point(184, 85)
        Me.TXTPTNAME.Name = "TXTPTNAME"
        Me.TXTPTNAME.ReadOnly = True
        Me.TXTPTNAME.Size = New System.Drawing.Size(220, 27)
        Me.TXTPTNAME.TabIndex = 2
        Me.TXTPTNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(274, 489)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 44)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Pay Now"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(107, 489)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 44)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancel Payment"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(101, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total Due"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 303)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Payment Type"
        '
        'TXTDISC
        '
        Me.TXTDISC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTDISC.Location = New System.Drawing.Point(184, 253)
        Me.TXTDISC.Name = "TXTDISC"
        Me.TXTDISC.ReadOnly = True
        Me.TXTDISC.Size = New System.Drawing.Size(220, 27)
        Me.TXTDISC.TabIndex = 2
        Me.TXTDISC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTTOTALDUE
        '
        Me.TXTTOTALDUE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTTOTALDUE.Location = New System.Drawing.Point(184, 337)
        Me.TXTTOTALDUE.Name = "TXTTOTALDUE"
        Me.TXTTOTALDUE.ReadOnly = True
        Me.TXTTOTALDUE.Size = New System.Drawing.Size(220, 27)
        Me.TXTTOTALDUE.TabIndex = 2
        Me.TXTTOTALDUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CMBPAYMENTTYPE
        '
        Me.CMBPAYMENTTYPE.Enabled = False
        Me.CMBPAYMENTTYPE.FormattingEnabled = True
        Me.CMBPAYMENTTYPE.Items.AddRange(New Object() {"Cash", "GCash", "PayMaya"})
        Me.CMBPAYMENTTYPE.Location = New System.Drawing.Point(184, 295)
        Me.CMBPAYMENTTYPE.Name = "CMBPAYMENTTYPE"
        Me.CMBPAYMENTTYPE.Size = New System.Drawing.Size(220, 27)
        Me.CMBPAYMENTTYPE.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Total Amount"
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTTOTAL.Location = New System.Drawing.Point(184, 127)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.ReadOnly = True
        Me.TXTTOTAL.Size = New System.Drawing.Size(220, 27)
        Me.TXTTOTAL.TabIndex = 2
        Me.TXTTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(69, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Discount Type"
        '
        'CMBDISTYPE
        '
        Me.CMBDISTYPE.FormattingEnabled = True
        Me.CMBDISTYPE.Location = New System.Drawing.Point(185, 211)
        Me.CMBDISTYPE.Name = "CMBDISTYPE"
        Me.CMBDISTYPE.Size = New System.Drawing.Size(219, 27)
        Me.CMBDISTYPE.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cash"
        '
        'TXTCASH
        '
        Me.TXTCASH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTCASH.Location = New System.Drawing.Point(184, 17)
        Me.TXTCASH.Name = "TXTCASH"
        Me.TXTCASH.Size = New System.Drawing.Size(220, 27)
        Me.TXTCASH.TabIndex = 2
        Me.TXTCASH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TXTCHANGE)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TXTCASH)
        Me.Panel2.Location = New System.Drawing.Point(-3, 370)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 106)
        Me.Panel2.TabIndex = 12
        Me.Panel2.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(117, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 19)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Change"
        '
        'TXTCHANGE
        '
        Me.TXTCHANGE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTCHANGE.Enabled = False
        Me.TXTCHANGE.Location = New System.Drawing.Point(184, 64)
        Me.TXTCHANGE.Name = "TXTCHANGE"
        Me.TXTCHANGE.ReadOnly = True
        Me.TXTCHANGE.Size = New System.Drawing.Size(220, 27)
        Me.TXTCHANGE.TabIndex = 4
        Me.TXTCHANGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LBLUSERID
        '
        Me.LBLUSERID.Location = New System.Drawing.Point(404, 85)
        Me.LBLUSERID.Name = "LBLUSERID"
        Me.LBLUSERID.Size = New System.Drawing.Size(64, 27)
        Me.LBLUSERID.TabIndex = 13
        Me.LBLUSERID.Visible = False
        '
        'TXTQUANTITY
        '
        Me.TXTQUANTITY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTQUANTITY.Location = New System.Drawing.Point(184, 169)
        Me.TXTQUANTITY.Name = "TXTQUANTITY"
        Me.TXTQUANTITY.ReadOnly = True
        Me.TXTQUANTITY.Size = New System.Drawing.Size(220, 27)
        Me.TXTQUANTITY.TabIndex = 15
        Me.TXTQUANTITY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(74, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 19)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Buying Stock"
        '
        'frmSalesSettlePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 545)
        Me.ControlBox = False
        Me.Controls.Add(Me.TXTQUANTITY)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LBLUSERID)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CMBDISTYPE)
        Me.Controls.Add(Me.CMBPAYMENTTYPE)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTTOTALDUE)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.TXTDISC)
        Me.Controls.Add(Me.TXTPTNAME)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSalesSettlePayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTPTNAME As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTDISC As TextBox
    Friend WithEvents TXTTOTALDUE As TextBox
    Friend WithEvents CMBPAYMENTTYPE As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTTOTAL As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CMBDISTYPE As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTCASH As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTCHANGE As TextBox
    Friend WithEvents LBLUSER As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LBLUSERID As Label
    Friend WithEvents TXTQUANTITY As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LBLSTOCKAVAILABLE As Label
    Friend WithEvents Label11 As Label
End Class
