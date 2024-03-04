Imports MySql.Data.MySqlClient
Public Class frmClinicSchedule

    Dim schedBtn As New Button

    Sub SetSchedule()
        con.Open()
        cm = New MySqlCommand("SELECT * FROM ec_schedule", con)
        dr = cm.ExecuteReader

        While dr.Read

            schedBtn = New Button
            schedBtn.Width = 125
            schedBtn.Height = 50


            'If dr.Item("FullName").ToString Is Nothing Then
            '    schedBtn.Text = dr.Item("time_available").ToString
            'Else
            'End If

            schedBtn.Text = dr.Item("time_available").ToString

            schedBtn.BackColor = Color.FromArgb(9, 132, 227)
            schedBtn.Tag = dr.Item("schedid")
            schedBtn.FlatStyle = FlatStyle.Flat
            schedBtn.ForeColor = Color.White
            schedBtn.Cursor = Cursors.Hand
            schedBtn.TextAlign = ContentAlignment.MiddleLeft
            FlowLayoutPanel1.Controls.Add(schedBtn)

            'AddHandler schedBtn.Click, AddressOf Patient_Click

        End While




        dr.Close()
        con.Close()

    End Sub

    Sub Patient_Click(sender As Object, e As EventArgs)
        Dim time_available As String = sender.Text.ToString
        Dim schedid As String = sender.Tag.ToString

        'If day <> 0 Then

        With frmClinicAppointmentsCreate
            .DTDate.Text = LBLDate.Text
            .FillSchedTime()
            .CBOTIME.Text = time_available
            .CBOTIME.Enabled = False
            .btnAdd.Show()
            .btnUpdate.Hide()
            .ShowDialog()
        End With
        Me.Dispose()
    End Sub

    Private Sub frmClinicSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetSchedule()
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class