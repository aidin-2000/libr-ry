﻿Public Class сотрудник
    Private Sub СотрудникиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles СотрудникиBindingNavigatorSaveItem.Click, СотрудникиBindingNavigatorSaveItem.Click, СотрудникиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.СотрудникиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub сотрудник_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "LibraryDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
        Me.СотрудникиTableAdapter.Fill(Me.LibraryDataSet.Сотрудники)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        СотрудникиBindingSource.MoveFirst()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        СотрудникиBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        СотрудникиBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        СотрудникиBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        СотрудникиBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.СотрудникиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Close()
    End Sub
End Class