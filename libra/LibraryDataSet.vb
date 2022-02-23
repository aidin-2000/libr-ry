Partial Class LibraryDataSet
    Partial Public Class Выдача_книгDataTable
        Private Sub Выдача_книгDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Код_читателяColumn.ColumnName) Then
                'Добавьте здесь пользовательский код
            End If

        End Sub

    End Class
End Class
