Public Class frmMainForm

    Dim isCollapsed As Boolean = True
    Dim sec_isCollapsed As Boolean = True
    Dim tri_isCollapsed As Boolean = True


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With frmAdminDashboard
            .TopLevel = False
            clinicPanel.Controls.Add(frmAdminDashboard)
            .FillDashboard()
            .YearlySales()
            .Monthly()
            .DailySales()

            .BringToFront()
            .Show()
        End With

        dp1.Size = dp1.MinimumSize
        dp2.Size = dp2.MinimumSize
        drop3.Size = drop3.MinimumSize
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isCollapsed Then
            Button17.Image = My.Resources.arrow_213_16
            dp1.Height += 100
            If dp1.Size = dp1.MaximumSize Then
                Timer1.Stop()
                isCollapsed = False
            End If
        Else
            dp1.Height -= 100
            Button17.Image = My.Resources.arrow_100_16
            If dp1.Size = dp1.MinimumSize Then
                Timer1.Stop()
                isCollapsed = True
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If sec_isCollapsed Then

            Button3.Image = My.Resources.arrow_213_16
            dp2.Height += 100

            If dp2.Size = dp2.MaximumSize Then

                Timer2.Stop()

                sec_isCollapsed = False

            End If
        Else
            Button3.Image = My.Resources.arrow_100_16
            dp2.Height -= 100
            If dp2.Size = dp2.MinimumSize Then
                Timer2.Stop()
                sec_isCollapsed = True
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If tri_isCollapsed Then

            dropBTN3.Image = My.Resources.arrow_213_16
            drop3.Height += 100

            If drop3.Size = drop3.MaximumSize Then

                Timer3.Stop()

                tri_isCollapsed = False

            End If
        Else

            dropBTN3.Image = My.Resources.arrow_100_16

            drop3.Height -= 100

            If drop3.Size = drop3.MinimumSize Then

                Timer3.Stop()

                tri_isCollapsed = True

            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        sec_isCollapsed = False

        Timer1.Start()
        Timer2.Start()
        'Timer3.Start()


    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        With frmSales
            '.TopLevel = False
            'Panel9.Controls.Add(frmSales)
            '.BringToFront()
            .Show()
        End With

        Me.Close()

    End Sub


    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        With frmProduct
            .TopLevel = False
            clinicPanel.Controls.Add(frmProduct)
            .FillProducts()
            .BringToFront()
            .Show()
        End With

        UserLog("Go to Product")

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With frmUsers
            .TopLevel = False
            clinicPanel.Controls.Add(frmUsers)
            .FillUsers()
            .BringToFront()
            .Show()
        End With

        UserLog("Go to User Management")

    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        With frmAdminDashboard
            .TopLevel = False
            clinicPanel.Controls.Add(frmAdminDashboard)
            .FillDashboard()
            .YearlySales()
            .Monthly()
            .DailySales()
            .BringToFront()
            .Show()
        End With

        UserLog("Check the Dashboard")

    End Sub


    Private Sub Button20_Click_1(sender As Object, e As EventArgs) Handles Button20.Click
        With frmClinicConsultation
            .Show()

        End With

        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        With frmAuditSalesReport
            .TopLevel = False
            clinicPanel.Controls.Add(frmAuditSalesReport)
            .BringToFront()
            .Show()
        End With

        UserLog("Go to Sales Report")
    End Sub

    Private Sub dropBTN3_Click(sender As Object, e As EventArgs) Handles dropBTN3.Click
        If tri_isCollapsed Then
            tri_isCollapsed = True
        Else
            tri_isCollapsed = False

        End If

        'Timer1.Start()
        'Timer2.Start()
        Timer3.Start()
    End Sub


    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        isCollapsed = False

        Timer1.Start()
        Timer2.Start()
        'Timer3.Start()
    End Sub

    Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        With frmClinicAppointments
            .Show()
            .IncomingAppointment()
        End With

        Me.Close()
    End Sub

    Private Sub Button18_Click_1(sender As Object, e As EventArgs) Handles Button18.Click
        With frmClinicBillsAndPayment
            .TopLevel = False
            clinicPanel.Controls.Add(frmClinicBillsAndPayment)
            .FillBill()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        With frmCategoryControl
            .TopLevel = False
            clinicPanel.Controls.Add(frmCategoryControl)
            .BringToFront()
            .Show()
        End With

        UserLog("Go to Maintenance")
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        With frmRecordStockInventory
            .TopLevel = False
            clinicPanel.Controls.Add(frmRecordStockInventory)
            .FillStocks()
            .BringToFront()
            .Show()
        End With

        UserLog("Go to Record Stock Inventory")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With frmClinicPatientModule
            .TopLevel = False
            clinicPanel.Controls.Add(frmClinicPatientModule)
            '.FillBill()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        With frmBackup
            .TopLevel = False
            clinicPanel.Controls.Add(frmBackup)
            '.FillBill()
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
