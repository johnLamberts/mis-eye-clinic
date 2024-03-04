Imports MySql.Data.MySqlClient
Public Class frmSalesViewBills
    Dim btnPatient As New Button

    Sub FillPatientsButton()
        con.Open()
        cm = New MySqlCommand("SELECT * FROM ec_patient_bill", con)
        dr = cm.ExecuteReader

        While dr.Read
            btnPatient = New Button
            btnPatient.Width = 140
            btnPatient.Height = 50
            If CDbl(dr.Item("bill").ToString) > 1 Then
                btnPatient.Text = dr.Item("fullName") & " - " & dr.Item("bill").ToString
                btnPatient.BackColor = Color.FromArgb(108, 92, 231)
            Else
                btnPatient.Text = dr.Item("fullName")
                btnPatient.BackColor = Color.FromArgb(9, 132, 227)
            End If
            btnPatient.Tag = dr.Item("patientid")
            btnPatient.FlatStyle = FlatStyle.Flat
            btnPatient.ForeColor = Color.White
            btnPatient.Cursor = Cursors.Hand
            btnPatient.TextAlign = ContentAlignment.MiddleLeft
            FlowLayoutPanel1.Controls.Add(btnPatient)

            AddHandler btnPatient.Click, AddressOf Patient_Click

        End While

        dr.Close()
        con.Close()
    End Sub

    Sub Patient_Click(sender As Object, e As EventArgs)
        Dim fullName As String = sender.text.ToString
        Dim userid As String = sender.tag.ToString
        With frmSales
            .TXTPN.Text = fullName
            .LBLPID.Text = userid
            .GetPatientsCart()
        End With
        Me.Dispose()
    End Sub


End Class