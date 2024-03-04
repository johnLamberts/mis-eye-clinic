<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClinicMakeTreatment
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
        Me.LBLID = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LBLSTATUS = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBLDIAGNOSIS = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBLPART = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBLEYE = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLPN = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBOTREATMENT = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBLPRICE = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LBLPID = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LBLID)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 51)
        Me.Panel1.TabIndex = 0
        '
        'LBLID
        '
        Me.LBLID.AutoSize = True
        Me.LBLID.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.LBLID.ForeColor = System.Drawing.Color.White
        Me.LBLID.Location = New System.Drawing.Point(32, 27)
        Me.LBLID.Name = "LBLID"
        Me.LBLID.Size = New System.Drawing.Size(32, 19)
        Me.LBLID.TabIndex = 7
        Me.LBLID.Text = "ID: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 19)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "ID: "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(309, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(111, 23)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(256, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Date:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 561)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(432, 10)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LBLPID)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.LBLSTATUS)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.LBLDIAGNOSIS)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.LBLPART)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.LBLEYE)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.LBLPN)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(12, 123)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(408, 277)
        Me.Panel3.TabIndex = 2
        '
        'LBLSTATUS
        '
        Me.LBLSTATUS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLSTATUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLSTATUS.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!)
        Me.LBLSTATUS.Location = New System.Drawing.Point(118, 224)
        Me.LBLSTATUS.Name = "LBLSTATUS"
        Me.LBLSTATUS.Size = New System.Drawing.Size(197, 16)
        Me.LBLSTATUS.TabIndex = 7
        Me.LBLSTATUS.Text = "Label8"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(75, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Status:"
        '
        'LBLDIAGNOSIS
        '
        Me.LBLDIAGNOSIS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLDIAGNOSIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLDIAGNOSIS.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!)
        Me.LBLDIAGNOSIS.Location = New System.Drawing.Point(118, 185)
        Me.LBLDIAGNOSIS.Name = "LBLDIAGNOSIS"
        Me.LBLDIAGNOSIS.Size = New System.Drawing.Size(197, 16)
        Me.LBLDIAGNOSIS.TabIndex = 7
        Me.LBLDIAGNOSIS.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Diagnosis: "
        '
        'LBLPART
        '
        Me.LBLPART.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLPART.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLPART.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!)
        Me.LBLPART.Location = New System.Drawing.Point(118, 141)
        Me.LBLPART.Name = "LBLPART"
        Me.LBLPART.Size = New System.Drawing.Size(197, 16)
        Me.LBLPART.TabIndex = 5
        Me.LBLPART.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(81, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Part : "
        '
        'LBLEYE
        '
        Me.LBLEYE.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLEYE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLEYE.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!)
        Me.LBLEYE.Location = New System.Drawing.Point(118, 97)
        Me.LBLEYE.Name = "LBLEYE"
        Me.LBLEYE.Size = New System.Drawing.Size(197, 16)
        Me.LBLEYE.TabIndex = 3
        Me.LBLEYE.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Which Eye: "
        '
        'LBLPN
        '
        Me.LBLPN.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLPN.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!)
        Me.LBLPN.Location = New System.Drawing.Point(118, 57)
        Me.LBLPN.Name = "LBLPN"
        Me.LBLPN.Size = New System.Drawing.Size(197, 16)
        Me.LBLPN.TabIndex = 1
        Me.LBLPN.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Patient Name: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(8, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Treatment"
        '
        'CBOTREATMENT
        '
        Me.CBOTREATMENT.FormattingEnabled = True
        Me.CBOTREATMENT.Location = New System.Drawing.Point(134, 431)
        Me.CBOTREATMENT.Name = "CBOTREATMENT"
        Me.CBOTREATMENT.Size = New System.Drawing.Size(194, 24)
        Me.CBOTREATMENT.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 439)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Treatment:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 466)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Price:"
        '
        'LBLPRICE
        '
        Me.LBLPRICE.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLPRICE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLPRICE.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!)
        Me.LBLPRICE.Location = New System.Drawing.Point(131, 466)
        Me.LBLPRICE.Name = "LBLPRICE"
        Me.LBLPRICE.Size = New System.Drawing.Size(197, 16)
        Me.LBLPRICE.TabIndex = 9
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(79, 508)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(128, 35)
        Me.Button10.TabIndex = 10
        Me.Button10.Text = "Result"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(221, 508)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(128, 35)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "Cancel"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(53, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Patient ID: "
        '
        'LBLPID
        '
        Me.LBLPID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLPID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLPID.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!)
        Me.LBLPID.Location = New System.Drawing.Point(118, 23)
        Me.LBLPID.Name = "LBLPID"
        Me.LBLPID.Size = New System.Drawing.Size(197, 16)
        Me.LBLPID.TabIndex = 9
        Me.LBLPID.Text = "Label3"
        '
        'frmClinicMakeTreatment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(432, 571)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.LBLPRICE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBOTREATMENT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmClinicMakeTreatment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LBLSTATUS As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LBLDIAGNOSIS As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LBLPART As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBLEYE As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBLPN As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CBOTREATMENT As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LBLPRICE As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents LBLID As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LBLPID As Label
    Friend WithEvents Label11 As Label
End Class
