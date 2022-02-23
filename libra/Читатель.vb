Public Class Читатель
    Private Sub ЧитательBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ЧитательBindingNavigatorSaveItem.Click, ЧитательBindingNavigatorSaveItem.Click, ЧитательBindingNavigatorSaveItem.Click, ЧитательBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ЧитательBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub Читатель_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "LibraryDataSet.Читатель". При необходимости она может быть перемещена или удалена.
        Me.ЧитательTableAdapter.Fill(Me.LibraryDataSet.Читатель)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ЧитательBindingSource.MoveFirst()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ЧитательBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ЧитательBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ЧитательBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ЧитательBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.ЧитательBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Close()
    End Sub
End Class