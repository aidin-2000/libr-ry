Public Class накладная
    Private Sub НакладнаяBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles НакладнаяBindingNavigatorSaveItem.Click, НакладнаяBindingNavigatorSaveItem.Click, НакладнаяBindingNavigatorSaveItem.Click, НакладнаяBindingNavigatorSaveItem.Click, НакладнаяBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.НакладнаяBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub накладная_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "LibraryDataSet.Книги". При необходимости она может быть перемещена или удалена.
        Me.КнигиTableAdapter.Fill(Me.LibraryDataSet.Книги)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "LibraryDataSet.Накладная". При необходимости она может быть перемещена или удалена.
        Me.НакладнаяTableAdapter.Fill(Me.LibraryDataSet.Накладная)

    End Sub
End Class