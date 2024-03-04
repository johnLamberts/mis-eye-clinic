Public Class frmCategoryControl
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click

        If TabControl1.SelectedIndex = 0 Then
            With frmCategoryEyeList
                .TopLevel = False
                Panel8.Controls.Add(frmCategoryEyeList)
                .FillCategoryEye()
                .FillSub()
                .BringToFront()

                .Show()

            End With
        ElseIf TabControl1.SelectedIndex = 1 Then
            With frmBrandList
                .TopLevel = False
                Panel2.Controls.Add(frmBrandList)
                .FillBrand()
                .BringToFront()
                .Show()
            End With
        ElseIf TabControl1.SelectedIndex = 2 Then
            With frmGenericList
                .TopLevel = False
                Panel3.Controls.Add(frmGenericList)
                .FillGeneric()
                .BringToFront()
                .Show()
            End With
        ElseIf TabControl1.SelectedIndex = 3 Then
            With frmClassificationList
                .TopLevel = False
                Panel4.Controls.Add(frmClassificationList)
                .FillClassification()
                .BringToFront()
                .Show()
            End With

        ElseIf TabControl1.SelectedIndex = 4 Then
            With frmTypeList
                .TopLevel = False
                Panel5.Controls.Add(frmTypeList)
                .FillType()
                .BringToFront()
                .Show()
            End With

        ElseIf TabControl1.SelectedIndex = 5 Then
            With frmDiscountList
                .TopLevel = False
                Panel6.Controls.Add(frmDiscountList)
                .FillDiscount()
                .BringToFront()
                .Show()
            End With

        ElseIf TabControl1.SelectedIndex = 6 Then
            With frmServices
                .TopLevel = False
                Panel7.Controls.Add(frmServices)
                .FillServices()
                .BringToFront()
                .Show()
            End With


        ElseIf TabControl1.SelectedIndex = 7 Then
            With frmScheduleList
                .TopLevel = False
                schedPanel.Controls.Add(frmScheduleList)
                .FillSchedule
                .BringToFront()
                .Show()
            End With

        ElseIf TabControl1.SelectedIndex = 8 Then
            With frmTreatmentList
                .TopLevel = False
                panelTreat.Controls.Add(frmTreatmentList)
                .FillTreatment()
                .BringToFront()
                .Show()
            End With
        End If
    End Sub

    Private Sub frmCategoryControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With frmCategoryEyeList
            .TopLevel = False
            Panel8.Controls.Add(frmCategoryEyeList)
            .FillCategoryEye()
            .FillSub()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub
End Class