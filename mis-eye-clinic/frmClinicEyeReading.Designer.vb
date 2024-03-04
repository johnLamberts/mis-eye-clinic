<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClinicEyeReading
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.left_d = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.left_n = New System.Windows.Forms.TextBox()
        Me.left_wg = New System.Windows.Forms.NumericUpDown()
        Me.left_woutg = New System.Windows.Forms.NumericUpDown()
        Me.left_pin = New System.Windows.Forms.NumericUpDown()
        Me.left_iop = New System.Windows.Forms.NumericUpDown()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.right_wg = New System.Windows.Forms.NumericUpDown()
        Me.right_d = New System.Windows.Forms.TextBox()
        Me.right_woutg = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.right_pin = New System.Windows.Forms.NumericUpDown()
        Me.right_n = New System.Windows.Forms.TextBox()
        Me.right_iop = New System.Windows.Forms.NumericUpDown()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CBOPN = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.left_wg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.left_woutg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.left_pin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.left_iop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.right_wg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.right_woutg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.right_pin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.right_iop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 78)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.EyeClinic_Alpha.My.Resources.Resources.cross
        Me.Button1.Location = New System.Drawing.Point(784, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 608)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(772, 10)
        Me.Panel2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(21, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Left Eye "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Distance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "With Glasses"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(436, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Near"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "PIN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(372, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Without Glasses"
        '
        'left_d
        '
        Me.left_d.Location = New System.Drawing.Point(109, 66)
        Me.left_d.Name = "left_d"
        Me.left_d.Size = New System.Drawing.Size(254, 23)
        Me.left_d.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(445, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "IOP"
        '
        'left_n
        '
        Me.left_n.Location = New System.Drawing.Point(479, 66)
        Me.left_n.Name = "left_n"
        Me.left_n.Size = New System.Drawing.Size(252, 23)
        Me.left_n.TabIndex = 5
        '
        'left_wg
        '
        Me.left_wg.DecimalPlaces = 2
        Me.left_wg.Location = New System.Drawing.Point(109, 96)
        Me.left_wg.Name = "left_wg"
        Me.left_wg.Size = New System.Drawing.Size(254, 23)
        Me.left_wg.TabIndex = 11
        '
        'left_woutg
        '
        Me.left_woutg.DecimalPlaces = 2
        Me.left_woutg.Location = New System.Drawing.Point(479, 98)
        Me.left_woutg.Name = "left_woutg"
        Me.left_woutg.Size = New System.Drawing.Size(252, 23)
        Me.left_woutg.TabIndex = 11
        '
        'left_pin
        '
        Me.left_pin.DecimalPlaces = 2
        Me.left_pin.Location = New System.Drawing.Point(109, 125)
        Me.left_pin.Name = "left_pin"
        Me.left_pin.Size = New System.Drawing.Size(254, 23)
        Me.left_pin.TabIndex = 11
        '
        'left_iop
        '
        Me.left_iop.DecimalPlaces = 2
        Me.left_iop.Location = New System.Drawing.Point(479, 127)
        Me.left_iop.Name = "left_iop"
        Me.left_iop.Size = New System.Drawing.Size(252, 23)
        Me.left_iop.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.left_iop)
        Me.Panel3.Controls.Add(Me.left_pin)
        Me.Panel3.Controls.Add(Me.left_woutg)
        Me.Panel3.Controls.Add(Me.left_wg)
        Me.Panel3.Controls.Add(Me.left_n)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.left_d)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(12, 153)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(745, 175)
        Me.Panel3.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bahnschrift Light", 14.0!)
        Me.Label14.Location = New System.Drawing.Point(21, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 23)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Right Eye"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(47, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 16)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Distance"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 16)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "With Glasses"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(436, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 16)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Near"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(76, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "PIN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(372, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Without Glasses"
        '
        'right_wg
        '
        Me.right_wg.DecimalPlaces = 2
        Me.right_wg.Location = New System.Drawing.Point(111, 96)
        Me.right_wg.Name = "right_wg"
        Me.right_wg.Size = New System.Drawing.Size(252, 23)
        Me.right_wg.TabIndex = 11
        '
        'right_d
        '
        Me.right_d.Location = New System.Drawing.Point(111, 66)
        Me.right_d.Name = "right_d"
        Me.right_d.Size = New System.Drawing.Size(252, 23)
        Me.right_d.TabIndex = 5
        '
        'right_woutg
        '
        Me.right_woutg.DecimalPlaces = 2
        Me.right_woutg.Location = New System.Drawing.Point(479, 101)
        Me.right_woutg.Name = "right_woutg"
        Me.right_woutg.Size = New System.Drawing.Size(252, 23)
        Me.right_woutg.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(445, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "IOP"
        '
        'right_pin
        '
        Me.right_pin.DecimalPlaces = 2
        Me.right_pin.Location = New System.Drawing.Point(111, 125)
        Me.right_pin.Name = "right_pin"
        Me.right_pin.Size = New System.Drawing.Size(252, 23)
        Me.right_pin.TabIndex = 11
        '
        'right_n
        '
        Me.right_n.Location = New System.Drawing.Point(479, 66)
        Me.right_n.Name = "right_n"
        Me.right_n.Size = New System.Drawing.Size(252, 23)
        Me.right_n.TabIndex = 5
        '
        'right_iop
        '
        Me.right_iop.DecimalPlaces = 2
        Me.right_iop.Location = New System.Drawing.Point(479, 130)
        Me.right_iop.Name = "right_iop"
        Me.right_iop.Size = New System.Drawing.Size(252, 23)
        Me.right_iop.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.right_iop)
        Me.Panel4.Controls.Add(Me.right_n)
        Me.Panel4.Controls.Add(Me.right_pin)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.right_woutg)
        Me.Panel4.Controls.Add(Me.right_d)
        Me.Panel4.Controls.Add(Me.right_wg)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Location = New System.Drawing.Point(12, 343)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(745, 175)
        Me.Panel4.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(35, 91)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 16)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Patient Name:"
        '
        'CBOPN
        '
        Me.CBOPN.FormattingEnabled = True
        Me.CBOPN.Location = New System.Drawing.Point(122, 84)
        Me.CBOPN.Name = "CBOPN"
        Me.CBOPN.Size = New System.Drawing.Size(144, 24)
        Me.CBOPN.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(542, 90)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 16)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Date Today:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(611, 86)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(146, 23)
        Me.DateTimePicker1.TabIndex = 10
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(314, 555)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(99, 33)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(437, 555)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 33)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(314, 555)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(99, 33)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'frmClinicEyeReading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(772, 618)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CBOPN)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmClinicEyeReading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.left_wg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.left_woutg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.left_pin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.left_iop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.right_wg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.right_woutg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.right_pin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.right_iop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents left_d As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents left_n As TextBox
    Friend WithEvents left_wg As NumericUpDown
    Friend WithEvents left_woutg As NumericUpDown
    Friend WithEvents left_pin As NumericUpDown
    Friend WithEvents left_iop As NumericUpDown
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents right_wg As NumericUpDown
    Friend WithEvents right_d As TextBox
    Friend WithEvents right_woutg As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents right_pin As NumericUpDown
    Friend WithEvents right_n As TextBox
    Friend WithEvents right_iop As NumericUpDown
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents CBOPN As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnUpdate As Button
End Class
