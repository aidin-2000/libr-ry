Public Class таблица_выдача_книги
    Private Sub Выдача_книгBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Выдача_книгBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Выдача_книгBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub таблица_выдача_книги_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "LibraryDataSet.Выдача_книг". При необходимости она может быть перемещена или удалена.
        Me.Выдача_книгTableAdapter.Fill(Me.LibraryDataSet.Выдача_книг)

    End Sub
End Class