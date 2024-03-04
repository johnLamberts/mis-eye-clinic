Imports MySql.Data.MySqlClient

Module DbConfig

    Public cm As New MySqlCommand
    Public dr As MySqlDataReader
    Public dt As New DataTable
    Public da As New MySqlDataAdapter
    Public username, password, userid, firstName, lastName, permission As String

    'Sub Connection()
    '    con = New MySqlConnection("server=localhost;username=root;password=;database=morales_eyeclinic")
    'End Sub

    Public Function strCon() As MySqlConnection
        Return New MySqlConnection("server=localhost;username=root;password=;database=morales_eyeclinic; convert zero DateTime=true")
    End Function

    Public con As MySqlConnection = strCon()

    Public Function Empty(ByVal Text As Object) As Boolean
        On Error Resume Next
        If Text.Text = "" Then

        End If
    End Function

    Public Function ValidateDuplicateEntry(ByVal query As String) As Boolean

        con.Open()

        cm = New MySqlCommand(query, con)
        dr = cm.ExecuteReader

        dr.Read()

        If dr.HasRows Then
            ValidateDuplicateEntry = True
            MsgBox("WARNING: Duplicate Entry!", vbCritical)
        Else
            ValidateDuplicateEntry = False
        End If

        dr.Close()

        con.Close()


    End Function

    Public Sub FillComboBox(ByVal query As String, cbo As ComboBox, id As String, name As String)
        Try

            con.Open()
            cm = New MySqlCommand(query, con)
            da.SelectCommand = cm

            da.Fill(dt)

            cbo.DataSource = dt
            cbo.ValueMember = id
            cbo.DisplayMember = name
            cbo.Text = "Select a category"
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try




    End Sub

    Sub UserLog(ByVal actions As String)
        Try
            con.Open()
            cm = New MySqlCommand("INSERT INTO ec_userlog(userid, actions, date) VALUES (@userid, @actions, @date)", con)

            With cm
                .Parameters.AddWithValue("@userid", userid)
                .Parameters.AddWithValue("@actions", actions)
                .Parameters.AddWithValue("@date", Now.ToString("yyyy-MM-dd"))
            End With
            cm.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub
End Module
