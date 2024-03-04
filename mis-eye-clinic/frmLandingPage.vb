Public Class frmLandingPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button3.Click

        With frmHome
            .TopLevel = False
            Panel2.Controls.Add(frmHome)
            .BringToFront()
            .Show()

        End With

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        With about
            .TopLevel = False
            Panel2.Controls.Add(about)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub frmLandingPage_Load(sender As Object, e As EventArgs) Handles Me.Load
        With frmHome
            .TopLevel = False
            Panel2.Controls.Add(frmHome)
            .BringToFront()
            .Show()

        End With

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With frmLogin
            .Show()

        End With

        Me.Close()

    End Sub
End Class