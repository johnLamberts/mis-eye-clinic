Imports MySql.Data.MySqlClient
Public Class frmAdminDashboard
    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub YearlySales()
        'Try

        '    con.Open()
        '    cm = New MySqlCommand("SELECT year(sales_date) as yearly, sum(total) as total_sales FROM `ec_sales` GROUP BY yearly ASC", con)
        '    dr = cm.ExecuteReader

        '    While dr.Read
        '        Chart1.Series("Yearly").Points.AddXY(dr.Item("yearly"), dr.Item("total_sales"))

        '    End While


        '    dr.Close()

        '    con.Close()


        'Catch ex As Exception
        '    MsgBox(ex.Message, vbCritical)
        'End Try
    End Sub

    Sub Monthly()
        Try

            con.Open()
            cm = New MySqlCommand("SELECT MONTHNAME(sales_date) as Month, SUM(total) as Monthly FROM `ec_sales` WHERE MONTH(sales_date)", con)
            dr = cm.ExecuteReader

            While dr.Read
                LBLMONTHLY.Text = "P" & Format(dr.Item("Monthly"), "#,###,###,##0.00")
            End While


            dr.Close()

            con.Close()




        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub DailySales()
        Try

            con.Open()
            cm = New MySqlCommand("SELECT SUM(total) as Weekly FROM ec_sales WHERE DATE(sales_date) > (NOW() - INTERVAL 7 DAY)", con)
            dr = cm.ExecuteReader

            While dr.Read
                LBLWEEKLY.Text = "P" & Format(dr.Item("Weekly"), "#,###,###,##0.00")
            End While


            dr.Close()

            con.Close()




        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Sub FillDashboard()

        Try
            con.Open()

            cm = New MySqlCommand("SELECT IFNULL(SUM(total), 0) FROM ec_sales", con)

            Dim total As Double = CDbl(cm.ExecuteScalar)

            LBLTSALES.Text = Format(total, "#,###,##0.00")

            con.Close()

            con.Open()
            cm = New MySqlCommand("SELECT COUNT(*) FROM ec_products", con)
            Dim totalproduct As Double = CDbl(cm.ExecuteScalar)
            LBLTPRODUCT.Text = totalproduct
            con.Close()

            con.Open()
            cm = New MySqlCommand("SELECT COUNT(*) FROM ec_patients", con)
            Dim totalusers As Double = CDbl(cm.ExecuteScalar)
            LBLTUSER.Text = totalusers
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class