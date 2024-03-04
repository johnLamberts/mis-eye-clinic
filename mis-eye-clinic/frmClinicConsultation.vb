Imports MySql.Data.MySqlClient
Public Class frmClinicConsultation
    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)


    End Sub

    'Private Sub Button10_MouseHover(sender As Object, e As EventArgs)
    '    Button10.ForeColor = Color.FromArgb(9, 132, 227)
    '    Button10.BackColor = Color.White
    'End Sub

    'Private Sub Button10_MouseLeave(sender As Object, e As EventArgs)
    '    Button10.BackColor = Color.FromArgb(9, 132, 227)
    '    Button10.ForeColor = Color.White
    'End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub frmClinicConsultation_Load(sender As Object, e As EventArgs) Handles Me.Load
        With frmClinicDiagnosis
            .TopLevel = False
            panelChild.Controls.Add(frmClinicDiagnosis)
            .FillDiagnosis()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With frmClinicPrescription
            .TopLevel = False
            panelChild.Controls.Add(frmClinicPrescription)
            .FillTreatment()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With frmClinicDiagnosis
            .TopLevel = False
            panelChild.Controls.Add(frmClinicDiagnosis)
            .FillDiagnosis()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With frmMainForm

            .Show()

        End With
        Me.Close()

    End Sub
End Class