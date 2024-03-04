<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClinicAppointmentsCreate
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBLPRICE = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBOTIME = New System.Windows.Forms.ComboBox()
        Me.DTDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTREMAKRS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBOSPRO = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBOPN = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.CBAPPTTYPE = New System.Windows.Forms.ComboBox()
        Me.TXTAPPTREFNO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(805, 52)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(441, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Appointment Type"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LBLPRICE)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.CBOTIME)
        Me.Panel2.Controls.Add(Me.DTDate)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TXTREMAKRS)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.CBOSPRO)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.CBOPN)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(12, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(780, 264)
        Me.Panel2.TabIndex = 4
        '
        'LBLPRICE
        '
        Me.LBLPRICE.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPRICE.Location = New System.Drawing.Point(496, 85)
        Me.LBLPRICE.Name = "LBLPRICE"
        Me.LBLPRICE.Size = New System.Drawing.Size(90, 13)
        Me.LBLPRICE.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(430, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Unit Price: "
        '
        'CBOTIME
        '
        Me.CBOTIME.FormattingEnabled = True
        Me.CBOTIME.Location = New System.Drawing.Point(204, 219)
        Me.CBOTIME.Name = "CBOTIME"
        Me.CBOTIME.Size = New System.Drawing.Size(196, 24)
        Me.CBOTIME.TabIndex = 13
        '
        'DTDate
        '
        Me.DTDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DTDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDate.Location = New System.Drawing.Point(546, 219)
        Me.DTDate.Name = "DTDate"
        Me.DTDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DTDate.Size = New System.Drawing.Size(181, 23)
        Me.DTDate.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(446, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Preferred Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(102, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Preferred Time:"
        '
        'TXTREMAKRS
        '
        Me.TXTREMAKRS.Location = New System.Drawing.Point(104, 123)
        Me.TXTREMAKRS.Multiline = True
        Me.TXTREMAKRS.Name = "TXTREMAKRS"
        Me.TXTREMAKRS.Size = New System.Drawing.Size(623, 84)
        Me.TXTREMAKRS.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Additional Remarks"
        '
        'CBOSPRO
        '
        Me.CBOSPRO.FormattingEnabled = True
        Me.CBOSPRO.Location = New System.Drawing.Point(431, 47)
        Me.CBOSPRO.Name = "CBOSPRO"
        Me.CBOSPRO.Size = New System.Drawing.Size(296, 24)
        Me.CBOSPRO.TabIndex = 5
        Me.CBOSPRO.Text = "Choose Service"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(428, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Service Provided"
        '
        'CBOPN
        '
        Me.CBOPN.FormattingEnabled = True
        Me.CBOPN.Location = New System.Drawing.Point(104, 47)
        Me.CBOPN.Name = "CBOPN"
        Me.CBOPN.Size = New System.Drawing.Size(296, 24)
        Me.CBOPN.TabIndex = 5
        Me.CBOPN.Text = "Choose Patient"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Patient Name"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(430, 402)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 35)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(256, 402)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(138, 35)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Save"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(256, 402)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(138, 35)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'CBAPPTTYPE
        '
        Me.CBAPPTTYPE.FormattingEnabled = True
        Me.CBAPPTTYPE.Items.AddRange(New Object() {"NEW ", "FOLLOW-UP", "OPERATION/SURGERY"})
        Me.CBAPPTTYPE.Location = New System.Drawing.Point(444, 88)
        Me.CBAPPTTYPE.Name = "CBAPPTTYPE"
        Me.CBAPPTTYPE.Size = New System.Drawing.Size(296, 24)
        Me.CBAPPTTYPE.TabIndex = 3
        Me.CBAPPTTYPE.Text = "Choose Type"
        '
        'TXTAPPTREFNO
        '
        Me.TXTAPPTREFNO.Enabled = False
        Me.TXTAPPTREFNO.Location = New System.Drawing.Point(91, 88)
        Me.TXTAPPTREFNO.Name = "TXTAPPTREFNO"
        Me.TXTAPPTREFNO.Size = New System.Drawing.Size(296, 23)
        Me.TXTAPPTREFNO.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Appointment Reference No."
        '
        'frmClinicAppointmentsCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(805, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CBAPPTTYPE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTAPPTREFNO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmClinicAppointmentsCreate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LBLPRICE As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CBOTIME As ComboBox
    Friend WithEvents DTDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTREMAKRS As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CBOSPRO As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBOPN As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents CBAPPTTYPE As ComboBox
    Friend WithEvents TXTAPPTREFNO As TextBox
    Friend WithEvents Label1 As Label
End Class
