<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClinicChangeStatus
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
        Me.ID = New System.Windows.Forms.Label()
        Me.LBLID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTSTATUS = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBLPN = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBLPRICE = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBLPID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLTREATMENT = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LBLID)
        Me.Panel1.Controls.Add(Me.ID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(505, 67)
        Me.Panel1.TabIndex = 0
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Font = New System.Drawing.Font("Bahnschrift Light", 10.0!)
        Me.ID.ForeColor = System.Drawing.Color.White
        Me.ID.Location = New System.Drawing.Point(12, 40)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(24, 17)
        Me.ID.TabIndex = 0
        Me.ID.Text = "ID:"
        '
        'LBLID
        '
        Me.LBLID.Font = New System.Drawing.Font("Bahnschrift Light", 10.0!)
        Me.LBLID.ForeColor = System.Drawing.Color.White
        Me.LBLID.Location = New System.Drawing.Point(42, 40)
        Me.LBLID.Name = "LBLID"
        Me.LBLID.Size = New System.Drawing.Size(48, 17)
        Me.LBLID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Status:"
        '
        'TXTSTATUS
        '
        Me.TXTSTATUS.Location = New System.Drawing.Point(147, 208)
        Me.TXTSTATUS.Name = "TXTSTATUS"
        Me.TXTSTATUS.Size = New System.Drawing.Size(253, 23)
        Me.TXTSTATUS.TabIndex = 2
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(166, 257)
        Me.Button10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(89, 28)
        Me.Button10.TabIndex = 3
        Me.Button10.Text = "Change"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(286, 257)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(89, 28)
        Me.Button8.TabIndex = 4
        Me.Button8.Text = "Cancel"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LBLTREATMENT)
        Me.Panel2.Controls.Add(Me.LBLPRICE)
        Me.Panel2.Controls.Add(Me.LBLPID)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.LBLPN)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(43, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(426, 92)
        Me.Panel2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Patient Name:"
        '
        'LBLPN
        '
        Me.LBLPN.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLPN.Location = New System.Drawing.Point(109, 48)
        Me.LBLPN.Name = "LBLPN"
        Me.LBLPN.Size = New System.Drawing.Size(108, 16)
        Me.LBLPN.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(256, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Price:"
        '
        'LBLPRICE
        '
        Me.LBLPRICE.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLPRICE.Location = New System.Drawing.Point(303, 48)
        Me.LBLPRICE.Name = "LBLPRICE"
        Me.LBLPRICE.Size = New System.Drawing.Size(108, 16)
        Me.LBLPRICE.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Patient ID:"
        '
        'LBLPID
        '
        Me.LBLPID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLPID.Location = New System.Drawing.Point(109, 21)
        Me.LBLPID.Name = "LBLPID"
        Me.LBLPID.Size = New System.Drawing.Size(108, 16)
        Me.LBLPID.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(234, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Treatment:"
        '
        'LBLTREATMENT
        '
        Me.LBLTREATMENT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBLTREATMENT.Location = New System.Drawing.Point(303, 21)
        Me.LBLTREATMENT.Name = "LBLTREATMENT"
        Me.LBLTREATMENT.Size = New System.Drawing.Size(108, 16)
        Me.LBLTREATMENT.TabIndex = 0
        '
        'frmClinicChangeStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(505, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.TXTSTATUS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmClinicChangeStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBLID As Label
    Friend WithEvents ID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTSTATUS As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LBLPRICE As Label
    Friend WithEvents LBLPN As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBLPID As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LBLTREATMENT As Label
    Friend WithEvents Label5 As Label
End Class
