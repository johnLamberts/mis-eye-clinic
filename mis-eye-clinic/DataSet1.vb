Partial Class DataSet1
    Partial Public Class ec_usersDataTable
        Private Sub ec_usersDataTable_ec_usersRowChanging(sender As Object, e As ec_usersRowChangeEvent) Handles Me.ec_usersRowChanging

        End Sub

        'Private Sub ec_usersDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
        '    If (e.Column.ColumnName = Me.DataColumn1Column.ColumnName) Then
        '        'Add user code here
        '    End If

        'End Sub

    End Class

    Partial Public Class ec_stockinDataTable
        Private Sub ec_stockinDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.receivedbyColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class ec_salesDataTable
        Private Sub ec_salesDataTable_ec_salesRowChanging(sender As Object, e As ec_salesRowChangeEvent) Handles Me.ec_salesRowChanging

        End Sub

    End Class
End Class
