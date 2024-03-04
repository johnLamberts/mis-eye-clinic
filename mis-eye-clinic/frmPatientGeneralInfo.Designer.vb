<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientGeneralInfo
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBLPID = New System.Windows.Forms.Label()
        Me.TXTAGE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTLASTNAME = New System.Windows.Forms.TextBox()
        Me.TXTMN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DOB = New System.Windows.Forms.DateTimePicker()
        Me.CBOGENDER = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTEMAIL = New System.Windows.Forms.TextBox()
        Me.TXTPHONE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTFIRSTNAME = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXTPOSTAL = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXTCITY = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTBRGY = New System.Windows.Forms.TextBox()
        Me.TXTMUN = New System.Windows.Forms.TextBox()
        Me.TXTST = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CBOSTAT = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LBLCPID = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(362, 511)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(188, 34)
        Me.btnUpdate.TabIndex = 29
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(362, 511)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(188, 34)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(579, 511)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(188, 34)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(56, 358)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(173, 34)
        Me.btnAdd.TabIndex = 25
        Me.btnAdd.Text = "Browse Image"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EyeClinic_Alpha.My.Resources.Resources.picture
        Me.PictureBox1.Location = New System.Drawing.Point(37, 137)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 214)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LBLCPID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1099, 42)
        Me.Panel1.TabIndex = 30
        '
        'LBLPID
        '
        Me.LBLPID.AutoSize = True
        Me.LBLPID.Location = New System.Drawing.Point(22, 105)
        Me.LBLPID.Name = "LBLPID"
        Me.LBLPID.Size = New System.Drawing.Size(30, 16)
        Me.LBLPID.TabIndex = 39
        Me.LBLPID.Text = "Age"
        '
        'TXTAGE
        '
        Me.TXTAGE.Location = New System.Drawing.Point(25, 125)
        Me.TXTAGE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTAGE.Name = "TXTAGE"
        Me.TXTAGE.Size = New System.Drawing.Size(242, 23)
        Me.TXTAGE.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(550, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Last Name"
        '
        'TXTLASTNAME
        '
        Me.TXTLASTNAME.Location = New System.Drawing.Point(545, 63)
        Me.TXTLASTNAME.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTLASTNAME.Name = "TXTLASTNAME"
        Me.TXTLASTNAME.Size = New System.Drawing.Size(242, 23)
        Me.TXTLASTNAME.TabIndex = 31
        '
        'TXTMN
        '
        Me.TXTMN.Location = New System.Drawing.Point(287, 63)
        Me.TXTMN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTMN.Name = "TXTMN"
        Me.TXTMN.Size = New System.Drawing.Size(242, 23)
        Me.TXTMN.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Middle Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 16)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Gender"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(284, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Date of Birth"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(-89, 477)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Phone No."
        '
        'DOB
        '
        Me.DOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOB.Location = New System.Drawing.Point(287, 124)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(242, 23)
        Me.DOB.TabIndex = 42
        '
        'CBOGENDER
        '
        Me.CBOGENDER.FormattingEnabled = True
        Me.CBOGENDER.Items.AddRange(New Object() {"Male", "Female", "Prefer not to say"})
        Me.CBOGENDER.Location = New System.Drawing.Point(25, 246)
        Me.CBOGENDER.Name = "CBOGENDER"
        Me.CBOGENDER.Size = New System.Drawing.Size(242, 24)
        Me.CBOGENDER.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.CBOGENDER)
        Me.Panel2.Controls.Add(Me.TXTEMAIL)
        Me.Panel2.Controls.Add(Me.TXTPHONE)
        Me.Panel2.Controls.Add(Me.TXTLASTNAME)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TXTFIRSTNAME)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.DOB)
        Me.Panel2.Controls.Add(Me.TXTPOSTAL)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.TXTCITY)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TXTBRGY)
        Me.Panel2.Controls.Add(Me.TXTMUN)
        Me.Panel2.Controls.Add(Me.TXTST)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.CBOSTAT)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.LBLPID)
        Me.Panel2.Controls.Add(Me.TXTAGE)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TXTMN)
        Me.Panel2.Location = New System.Drawing.Point(263, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(813, 426)
        Me.Panel2.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(282, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Email Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Phone No."
        '
        'TXTEMAIL
        '
        Me.TXTEMAIL.Location = New System.Drawing.Point(285, 186)
        Me.TXTEMAIL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTEMAIL.Name = "TXTEMAIL"
        Me.TXTEMAIL.Size = New System.Drawing.Size(240, 23)
        Me.TXTEMAIL.TabIndex = 57
        '
        'TXTPHONE
        '
        Me.TXTPHONE.Location = New System.Drawing.Point(25, 186)
        Me.TXTPHONE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTPHONE.Name = "TXTPHONE"
        Me.TXTPHONE.Size = New System.Drawing.Size(240, 23)
        Me.TXTPHONE.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "First Name"
        '
        'TXTFIRSTNAME
        '
        Me.TXTFIRSTNAME.Location = New System.Drawing.Point(25, 64)
        Me.TXTFIRSTNAME.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTFIRSTNAME.Name = "TXTFIRSTNAME"
        Me.TXTFIRSTNAME.Size = New System.Drawing.Size(242, 23)
        Me.TXTFIRSTNAME.TabIndex = 55
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(291, 351)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 16)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Postal Code"
        '
        'TXTPOSTAL
        '
        Me.TXTPOSTAL.Location = New System.Drawing.Point(287, 371)
        Me.TXTPOSTAL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTPOSTAL.Name = "TXTPOSTAL"
        Me.TXTPOSTAL.Size = New System.Drawing.Size(242, 23)
        Me.TXTPOSTAL.TabIndex = 53
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 351)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 16)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "City"
        '
        'TXTCITY
        '
        Me.TXTCITY.Location = New System.Drawing.Point(25, 369)
        Me.TXTCITY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTCITY.Name = "TXTCITY"
        Me.TXTCITY.Size = New System.Drawing.Size(242, 23)
        Me.TXTCITY.TabIndex = 51
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(552, 287)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 16)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Municipal"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(284, 287)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 16)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Baranggay"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 287)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 16)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Street"
        '
        'TXTBRGY
        '
        Me.TXTBRGY.Location = New System.Drawing.Point(287, 307)
        Me.TXTBRGY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTBRGY.Name = "TXTBRGY"
        Me.TXTBRGY.Size = New System.Drawing.Size(242, 23)
        Me.TXTBRGY.TabIndex = 47
        '
        'TXTMUN
        '
        Me.TXTMUN.Location = New System.Drawing.Point(555, 307)
        Me.TXTMUN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTMUN.Name = "TXTMUN"
        Me.TXTMUN.Size = New System.Drawing.Size(242, 23)
        Me.TXTMUN.TabIndex = 45
        '
        'TXTST
        '
        Me.TXTST.Location = New System.Drawing.Point(25, 308)
        Me.TXTST.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTST.Name = "TXTST"
        Me.TXTST.Size = New System.Drawing.Size(242, 23)
        Me.TXTST.TabIndex = 46
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(284, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Marital Status"
        '
        'CBOSTAT
        '
        Me.CBOSTAT.FormattingEnabled = True
        Me.CBOSTAT.Items.AddRange(New Object() {"Married", "Divorced", "Separated", "Widowed", "Single"})
        Me.CBOSTAT.Location = New System.Drawing.Point(287, 246)
        Me.CBOSTAT.Name = "CBOSTAT"
        Me.CBOSTAT.Size = New System.Drawing.Size(242, 24)
        Me.CBOSTAT.TabIndex = 43
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 562)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1099, 42)
        Me.Panel3.TabIndex = 45
        '
        'LBLCPID
        '
        Me.LBLCPID.AutoSize = True
        Me.LBLCPID.Location = New System.Drawing.Point(523, 9)
        Me.LBLCPID.Name = "LBLCPID"
        Me.LBLCPID.Size = New System.Drawing.Size(72, 16)
        Me.LBLCPID.TabIndex = 57
        Me.LBLCPID.Text = "First Name"
        '
        'frmPatientGeneralInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1099, 604)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmPatientGeneralInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPatientList"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBLPID As Label
    Friend WithEvents TXTAGE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTLASTNAME As TextBox
    Friend WithEvents TXTMN As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DOB As DateTimePicker
    Friend WithEvents CBOGENDER As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents CBOSTAT As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTPHONE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTFIRSTNAME As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TXTPOSTAL As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TXTCITY As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TXTBRGY As TextBox
    Friend WithEvents TXTMUN As TextBox
    Friend WithEvents TXTST As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTEMAIL As TextBox
    Friend WithEvents LBLCPID As Label
End Class
