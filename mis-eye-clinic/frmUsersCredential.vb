
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmUsersCredential
    Private Sub frmUsersCredential_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBUSERS.SelectedIndex = -1
        FillUsersCombo()

    End Sub

    Sub FillUsersCombo()
        con.Open()
        Dim userQuery As String = "SELECT userid, firstName FROM ec_users WHERE hasCredentials=0"
        cm = New MySqlCommand(userQuery, con)
        cm.ExecuteNonQuery()

        dr = cm.ExecuteReader

        While dr.Read
            CMBUSERS.Items.Add(dr.Item("firstName"))
        End While


        dr.Close()

        con.Close()

    End Sub

    Private Sub CMBUSERS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBUSERS.SelectedIndexChanged
        Dim userQuery As String = "SELECT userimg, userid, firstName, hasCredentials FROM ec_users WHERE firstName=@firstName AND hasCredentials=0"

        cm = New MySqlCommand(userQuery, con)
        cm.Parameters.AddWithValue("@firstName", CMBUSERS.SelectedItem)
        con.Open()
        dr = cm.ExecuteReader

        While dr.Read
            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))
            Dim ms As New MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            PictureBox1.BackgroundImage = bitmap

            LBLNAME.Visible = True
            LBLUSERID.Visible = True
            LBLUSERID.Text = dr.Item("userid").ToString
            LBLNAME.Text = dr.Item("firstName").ToString
        End While

        dr.Close()
        con.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        con.Open()
        Dim insertLogin As String = "INSERT INTO ec_login(userid, username, password) VALUES(@userid, @username, @password)"
        cm = New MySqlCommand(insertLogin, con)
        With cm.Parameters
            .AddWithValue("@userid", CInt(LBLUSERID.Text))
            .AddWithValue("@username", TXTUN.Text)
            .AddWithValue("@password", TXTPW.Text)
        End With
        cm.ExecuteNonQuery()
        hasCredentials(CInt(LBLUSERID.Text))
        MsgBox("Record has been successfully saved.", vbInformation)
        con.Close()
        Clear()

        Me.Dispose()

        UserLog("Insert and Save new Service")


    End Sub

    Sub Clear()
        TXTPW.Clear()
        TXTUN.Clear()
        TXTCONFIRMPW.Clear()
        CMBUSERS.SelectedIndex = -1
        LBLNAME.Visible = False
        LBLUSERID.Visible = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub hasCredentials(ByVal UserId As String)
        cm = New MySqlCommand("UPDATE ec_users SET hasCredentials=1 WHERE userid=@userid", con)
        cm.Parameters.AddWithValue("@userid", UserId)
        cm.ExecuteNonQuery()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()

    End Sub
End Class