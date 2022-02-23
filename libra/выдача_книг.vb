Public Class выдача_книг
    Private Sub Выдача_книгBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Выдача_книгBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Выдача_книгBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub выдача_книг_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "LibraryDataSet2.Выдача_книги". При необходимости она может быть перемещена или удалена.
        Me.Выдача_книгиTableAdapter.Fill(Me.LibraryDataSet2.Выдача_книги)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "LibraryDataSet.Выдача_книг". При необходимости она может быть перемещена или удалена.
        Me.Выдача_книгTableAdapter.Fill(Me.LibraryDataSet.Выдача_книг)

    End Sub

    Private Sub Выдача_книгиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseиBindingNavigatorSaveItem.Click, MyBaseиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Выдача_книгиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet2)

    End Sub
End Class