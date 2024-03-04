<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsersCreate
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
        Me.LBLLBLID = New System.Windows.Forms.Label()
        Me.LBLUID = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CMBSTATUS = New System.Windows.Forms.ComboBox()
        Me.CMBPERMISSION = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTAGE = New System.Windows.Forms.TextBox()
        Me.TXTPHONE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTLASTNAME = New System.Windows.Forms.TextBox()
        Me.TXTFIRSTNAME = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LBLLBLID)
        Me.Panel1.Controls.Add(Me.LBLUID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(681, 65)
        Me.Panel1.TabIndex = 1
        '
        'LBLLBLID
        '
        Me.LBLLBLID.AutoSize = True
        Me.LBLLBLID.ForeColor = System.Drawing.Color.White
        Me.LBLLBLID.Location = New System.Drawing.Point(569, 46)
        Me.LBLLBLID.Name = "LBLLBLID"
        Me.LBLLBLID.Size = New System.Drawing.Size(56, 16)
        Me.LBLLBLID.TabIndex = 0
        Me.LBLLBLID.Text = "User ID:"
        Me.LBLLBLID.Visible = False
        '
        'LBLUID
        '
        Me.LBLUID.AutoSize = True
        Me.LBLUID.ForeColor = System.Drawing.Color.White
        Me.LBLUID.Location = New System.Drawing.Point(622, 46)
        Me.LBLUID.Name = "LBLUID"
        Me.LBLUID.Size = New System.Drawing.Size(47, 16)
        Me.LBLUID.TabIndex = 0
        Me.LBLUID.Text = "Label7"
        Me.LBLUID.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(681, 414)
        Me.Panel2.TabIndex = 2
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(251, 331)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(162, 40)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(251, 331)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(162, 40)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(437, 331)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 40)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.CMBSTATUS)
        Me.Panel4.Controls.Add(Me.CMBPERMISSION)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TXTAGE)
        Me.Panel4.Controls.Add(Me.TXTPHONE)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.TXTLASTNAME)
        Me.Panel4.Controls.Add(Me.TXTFIRSTNAME)
        Me.Panel4.Location = New System.Drawing.Point(212, 43)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(448, 254)
        Me.Panel4.TabIndex = 20
        '
        'CMBSTATUS
        '
        Me.CMBSTATUS.FormattingEnabled = True
        Me.CMBSTATUS.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.CMBSTATUS.Location = New System.Drawing.Point(257, 169)
        Me.CMBSTATUS.Name = "CMBSTATUS"
        Me.CMBSTATUS.Size = New System.Drawing.Size(162, 24)
        Me.CMBSTATUS.TabIndex = 5
        '
        'CMBPERMISSION
        '
        Me.CMBPERMISSION.FormattingEnabled = True
        Me.CMBPERMISSION.Items.AddRange(New Object() {"", "Doctor", "Cashier", "Receptionist"})
        Me.CMBPERMISSION.Location = New System.Drawing.Point(38, 169)
        Me.CMBPERMISSION.Name = "CMBPERMISSION"
        Me.CMBPERMISSION.Size = New System.Drawing.Size(162, 24)
        Me.CMBPERMISSION.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(254, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Permission"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(254, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Age"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Phone No."
        '
        'TXTAGE
        '
        Me.TXTAGE.Location = New System.Drawing.Point(257, 113)
        Me.TXTAGE.Name = "TXTAGE"
        Me.TXTAGE.Size = New System.Drawing.Size(162, 23)
        Me.TXTAGE.TabIndex = 3
        '
        'TXTPHONE
        '
        Me.TXTPHONE.Location = New System.Drawing.Point(38, 113)
        Me.TXTPHONE.Name = "TXTPHONE"
        Me.TXTPHONE.Size = New System.Drawing.Size(162, 23)
        Me.TXTPHONE.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(254, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First Name"
        '
        'TXTLASTNAME
        '
        Me.TXTLASTNAME.Location = New System.Drawing.Point(257, 63)
        Me.TXTLASTNAME.Name = "TXTLASTNAME"
        Me.TXTLASTNAME.Size = New System.Drawing.Size(162, 23)
        Me.TXTLASTNAME.TabIndex = 0
        '
        'TXTFIRSTNAME
        '
        Me.TXTFIRSTNAME.Location = New System.Drawing.Point(38, 63)
        Me.TXTFIRSTNAME.Name = "TXTFIRSTNAME"
        Me.TXTFIRSTNAME.Size = New System.Drawing.Size(162, 23)
        Me.TXTFIRSTNAME.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(36, 254)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(148, 28)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Browse Image"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EyeClinic_Alpha.My.Resources.Resources.picture
        Me.PictureBox1.Location = New System.Drawing.Point(20, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 174)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'frmUsersCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(681, 479)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmUsersCreate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CMBSTATUS As ComboBox
    Friend WithEvents CMBPERMISSION As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTAGE As TextBox
    Friend WithEvents TXTPHONE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTLASTNAME As TextBox
    Friend WithEvents TXTFIRSTNAME As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LBLLBLID As Label
    Friend WithEvents LBLUID As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
End Class
