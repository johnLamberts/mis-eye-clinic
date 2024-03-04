<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesQuantity
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBLPQID = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLPQCODE = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBLPQPRICE = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLPQBRAND = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBLPQTYPE = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.qty = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBLAVAILSTOCK = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LBLPQID)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(197, 377)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Product ID: "
        '
        'LBLPQID
        '
        Me.LBLPQID.ForeColor = System.Drawing.Color.White
        Me.LBLPQID.Location = New System.Drawing.Point(87, 15)
        Me.LBLPQID.Name = "LBLPQID"
        Me.LBLPQID.Size = New System.Drawing.Size(41, 17)
        Me.LBLPQID.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 320)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Code: "
        '
        'LBLPQCODE
        '
        Me.LBLPQCODE.Location = New System.Drawing.Point(326, 63)
        Me.LBLPQCODE.Name = "LBLPQCODE"
        Me.LBLPQCODE.Size = New System.Drawing.Size(123, 21)
        Me.LBLPQCODE.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(275, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Price: "
        '
        'LBLPQPRICE
        '
        Me.LBLPQPRICE.Location = New System.Drawing.Point(326, 101)
        Me.LBLPQPRICE.Name = "LBLPQPRICE"
        Me.LBLPQPRICE.Size = New System.Drawing.Size(123, 21)
        Me.LBLPQPRICE.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(236, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Brand Name: "
        '
        'LBLPQBRAND
        '
        Me.LBLPQBRAND.Location = New System.Drawing.Point(326, 134)
        Me.LBLPQBRAND.Name = "LBLPQBRAND"
        Me.LBLPQBRAND.Size = New System.Drawing.Size(123, 21)
        Me.LBLPQBRAND.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(279, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Type: "
        '
        'LBLPQTYPE
        '
        Me.LBLPQTYPE.Location = New System.Drawing.Point(326, 167)
        Me.LBLPQTYPE.Name = "LBLPQTYPE"
        Me.LBLPQTYPE.Size = New System.Drawing.Size(123, 21)
        Me.LBLPQTYPE.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(267, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Quantity"
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(329, 230)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(122, 23)
        Me.qty.TabIndex = 3
        Me.qty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(215, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 29)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add To Cart"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(348, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 29)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Available Stock: "
        '
        'LBLAVAILSTOCK
        '
        Me.LBLAVAILSTOCK.Location = New System.Drawing.Point(326, 200)
        Me.LBLAVAILSTOCK.Name = "LBLAVAILSTOCK"
        Me.LBLAVAILSTOCK.Size = New System.Drawing.Size(123, 21)
        Me.LBLAVAILSTOCK.TabIndex = 2
        '
        'frmSalesQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(498, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.LBLAVAILSTOCK)
        Me.Controls.Add(Me.LBLPQTYPE)
        Me.Controls.Add(Me.LBLPQBRAND)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LBLPQPRICE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LBLPQCODE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSalesQuantity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LBLPQCODE As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBLPQPRICE As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBLPQBRAND As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBLPQTYPE As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents qty As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LBLPQID As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LBLAVAILSTOCK As Label
End Class
