Imports System.Data
Imports System.IO
Imports System.Windows.Forms

Partial Public Class Form3
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub LoadDataFromFile(filePath As String)
        Dim dataTable As New DataTable()

        Dim lines() As String = File.ReadAllLines(filePath)

        If lines.Length > 0 Then
            Dim headers() As String = lines(0).Split(","c)

            For Each header As String In headers
                dataTable.Columns.Add(header)
            Next

            For i As Integer = 1 To lines.Length - 1
                Dim cells() As String = lines(i).Split(","c)
                dataTable.Rows.Add(cells)
            Next

            dtgridEmployees.DataSource = dataTable
        Else
            MessageBox.Show("El archivo está vacío.")
        End If
    End Sub

    Private Sub cboxTypeEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxTypeEmployee.SelectedIndexChanged
        Dim selectedOption As String = cboxTypeEmployee.SelectedItem.ToString()
        Select Case selectedOption
            Case "Type A Employee"
                LoadDataFromFile("C:\Users\Roberto\source\repos\WorkerListVB\WorkerListVB\ListEmployeeA.txt")
            Case "Type B Employee"
                LoadDataFromFile("C:\Users\Roberto\source\repos\WorkersList\WorkersList\ListEmployeesB.txt")
        End Select
    End Sub

    Private Sub cbExport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbExport.SelectedIndexChanged
        If dtgridEmployees.Rows.Count = 0 Then
            Return
        End If
        Dim selectedOption As String = cbExport.SelectedItem.ToString()
        Select Case selectedOption
            Case "DOCX"
                Exporter.DOCXexport(dtgridEmployees)
            Case "XLSX"
                Exporter.XLSXexport(dtgridEmployees)
            Case "XML"
                Exporter.XMLexport(dtgridEmployees)
            Case "JSON"
                Exporter.JSONexport(dtgridEmployees)
            Case "PDF"
                Exporter.PDFexport(dtgridEmployees)
        End Select
    End Sub
End Class
