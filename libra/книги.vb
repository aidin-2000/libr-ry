Public Class книги
    Private Sub КнигиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles КнигиBindingNavigatorSaveItem.Click, КнигиBindingNavigatorSaveItem.Click, КнигиBindingNavigatorSaveItem.Click, КнигиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.КнигиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)

    End Sub

    Private Sub книги_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: данная строка кода позволяет загрузить данные в таблицу "LibraryDataSet.Книги". При необходимости она может быть перемещена или удалена.
        Me.КнигиTableAdapter.Fill(Me.LibraryDataSet.Книги)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim col As System.Windows.Forms.DataGridViewColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                col = DataGridViewTextBoxColumn2
            Case 1
                col = DataGridViewTextBoxColumn3
            Case 2
                col = DataGridViewTextBoxColumn4
            Case 3
                col = DataGridViewTextBoxColumn5
            Case 4
                col = DataGridViewTextBoxColumn6
            Case 5
                col = DataGridViewTextBoxColumn7
        End Select
        If RadioButton1.Checked Then
            КнигиDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            КнигиDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 0 To КнигиDataGridView.ColumnCount - 1
            For j = 0 To КнигиDataGridView.RowCount - 1
                КнигиBindingSource.Filter = "Жанр_Книги='" & ComboBox1.Text & "'"
            Next j
        Next i
  
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        КнигиBindingSource.Filter = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        КнигиBindingSource.Filter = "Автор_Книги='" & TextBox1.Text & "'"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        КнигиBindingSource.Filter = "Название_Книги='" & TextBox1.Text & "'"
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.КнигиTableAdapter.FillBy(Me.LibraryDataSet.Книги)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs)
        КнигиBindingSource.Filter = "Название_книги='" & TextBox1.Text & "'"
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        выдача_книг.Show()
    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        КнигиBindingSource.Filter = "Автор_Книги='" & TextBox1.Text & "'"
    End Sub
End Class