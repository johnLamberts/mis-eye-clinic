Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim isLogin As Boolean = False
            If TXTUSN.Text = String.Empty Or TXTPW.Text = String.Empty Then
                MsgBox("Required empty fields.", vbInformation)
                Return
            End If

            con.Open()
            cm = New MySqlCommand("SELECT * FROM ec_login JOIN ec_users USING(userid) WHERE username=@username AND password=@password ", con)

            With cm
                .Parameters.AddWithValue("@username", TXTUSN.Text)
                .Parameters.AddWithValue("@password", TXTPW.Text)
            End With

            dr = cm.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                isLogin = True
                userid = dr.Item("userid").ToString
                username = dr.Item("username").ToString
                password = dr.Item("password").ToString
                firstName = dr.Item("firstName").ToString
                lastName = dr.Item("lastName").ToString
                permission = dr.Item("permission").ToString

            Else
                isLogin = False
            End If

            dr.Close()
            con.Close()

            If isLogin = True Then
                If permission = "admin" Then
                    With frmMainForm
                        .Show()
                    End With

                End If
                Me.Close()

            Else
                MsgBox("Access Denied! Wrong Username and Password", vbOK)

            End If
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With frmHome
            .Show()
        End With
        Me.Close()

    End Sub
End Class