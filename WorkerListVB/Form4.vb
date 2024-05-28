Imports System.IO
Imports System.Windows.Forms

Partial Public Class Form4
    Inherits Form

    Public Sub New()
        InitializeComponent()
        AddEmployeesToComboBox()
    End Sub

    Private Sub AddEmployeesToComboBox()
        Dim linesA() As String = File.ReadAllLines("C:\Users\Roberto\source\repos\WorkersList\WorkersList\ListEmployeesA.txt")
        Dim linesB() As String = File.ReadAllLines("C:\Users\Roberto\source\repos\WorkersList\WorkersList\ListEmployeesB.txt")

        For i As Integer = 1 To linesA.Length - 1
            Dim element As String = ""
            Dim headers() As String = linesA(i).Split(","c)
            For j As Integer = 0 To 1
                element += $" {headers(j)}"
            Next
            cbEmployees.Items.Add(element)
        Next

        For i As Integer = 1 To linesB.Length - 1
            Dim element As String = ""
            Dim headers() As String = linesB(i).Split(","c)
            For j As Integer = 0 To 1
                element += $" {headers(j)}"
            Next
            element += $"{headers(14)}"
            cbEmployees.Items.Add(element)
        Next
    End Sub

    Private Sub cbEmployees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmployees.SelectedIndexChanged
        txtboxWrite.Text = cbEmployees.SelectedItem.ToString() + Environment.NewLine + Environment.NewLine +
                           "Performance:" + Environment.NewLine + Environment.NewLine +
                           "Complains:" + Environment.NewLine + Environment.NewLine +
                           "Posible Raise:" + Environment.NewLine + Environment.NewLine +
                           "Skills and Competencies:" + Environment.NewLine + Environment.NewLine +
                           "Teamwork and Collaboration:" + Environment.NewLine + Environment.NewLine +
                           "Attendance and Punctuality :"
    End Sub

    Private Sub btnExportOB_Click(sender As Object, e As EventArgs) Handles btnExportOB.Click
        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            saveFileDialog.FilterIndex = 1
            saveFileDialog.RestoreDirectory = True

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim filePath As String = saveFileDialog.FileName

                Try
                    File.WriteAllText(filePath, txtboxWrite.Text)
                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("An error occurred while saving the file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub btnImportOB_Click(sender As Object, e As EventArgs) Handles btnImportOB.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = openFileDialog.FileName
            txtboxWrite.Text = File.ReadAllText(fileName)
        End If
    End Sub
End Class
