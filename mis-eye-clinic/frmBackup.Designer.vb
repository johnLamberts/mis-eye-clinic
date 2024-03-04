<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
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
        Me.BTNBACKUP = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTNBACKUP
        '
        Me.BTNBACKUP.Location = New System.Drawing.Point(344, 92)
        Me.BTNBACKUP.Name = "BTNBACKUP"
        Me.BTNBACKUP.Size = New System.Drawing.Size(448, 142)
        Me.BTNBACKUP.TabIndex = 0
        Me.BTNBACKUP.Text = "Backup"
        Me.BTNBACKUP.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(81, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(448, 150)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Restore"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1246, 563)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNBACKUP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBackup"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNBACKUP As Button
    Friend WithEvents Button1 As Button
End Class
