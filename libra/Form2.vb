Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "LibraryDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
        Me.СотрудникиTableAdapter.Fill(Me.LibraryDataSet.Сотрудники)

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class