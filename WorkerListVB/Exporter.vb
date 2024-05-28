Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports Novacode
Imports OfficeOpenXml
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Newtonsoft.Json
Imports System.Xml
Imports Xceed.Words.NET

Friend Class Exporter

    Public Shared Sub DOCXexport(dataGridView As DataGridView)
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Word files (*.docx)|*.docx"
        saveFileDialog.Title = "Save As DOCX"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Using doc As DocX = DocX.Create(saveFileDialog.FileName)
                Dim table As Xceed.Document.NET.Table = doc.AddTable(dataGridView.Rows.Count + 1, dataGridView.Columns.Count)
                For i As Integer = 0 To dataGridView.Columns.Count - 1
                    table.Rows(0).Cells(i).Paragraphs(0).Append(dataGridView.Columns(i).HeaderText)
                Next

                For i As Integer = 0 To dataGridView.Rows.Count - 1
                    For j As Integer = 0 To dataGridView.Columns.Count - 1
                        table.Rows(i + 1).Cells(j).Paragraphs(0).Append(If(dataGridView(j, i).Value?.ToString(), String.Empty))
                    Next
                Next

                doc.InsertTable(table)
                doc.Save()
            End Using

            MessageBox.Show("DOCX Exported")
        End If
    End Sub

    Public Shared Sub XLSXexport(dataGridView As DataGridView)
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx"
        saveFileDialog.Title = "Save As XLSX"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial
            Using excelPackage As New ExcelPackage()
                Dim worksheet As ExcelWorksheet = excelPackage.Workbook.Worksheets.Add("DataGridViewData")

                For i As Integer = 0 To dataGridView.Columns.Count - 1
                    worksheet.Cells(1, i + 1).Value = dataGridView.Columns(i).HeaderText
                Next

                For i As Integer = 0 To dataGridView.Rows.Count - 1
                    For j As Integer = 0 To dataGridView.Columns.Count - 1
                        worksheet.Cells(i + 2, j + 1).Value = If(dataGridView(j, i).Value?.ToString(), String.Empty)
                    Next
                Next

                File.WriteAllBytes(saveFileDialog.FileName, excelPackage.GetAsByteArray())
            End Using

            MessageBox.Show("XLSX Exported")
        End If
    End Sub

    Public Shared Sub XMLexport(dataGridView As DataGridView)
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "XML files (*.xml)|*.xml"
        saveFileDialog.Title = "Guardar como XML"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim xmlDoc As New XmlDocument()
            Dim root As XmlElement = xmlDoc.CreateElement("DataGridViewData")
            xmlDoc.AppendChild(root)

            For Each row As DataGridViewRow In dataGridView.Rows
                If dataGridView.AllowUserToAddRows AndAlso row.IsNewRow Then
                    Continue For
                End If

                Dim rowElement As XmlElement = xmlDoc.CreateElement("Row")
                root.AppendChild(rowElement)

                For Each cell As DataGridViewCell In row.Cells
                    Dim columnName As String = dataGridView.Columns(cell.ColumnIndex).Name
                    Dim cellValue As String = (If(cell.Value?.ToString(), String.Empty)).Replace(" ", "_")

                    Dim cellElement As XmlElement = xmlDoc.CreateElement(columnName.Replace(" ", "_"))
                    cellElement.InnerText = cellValue
                    rowElement.AppendChild(cellElement)
                Next
            Next

            xmlDoc.Save(saveFileDialog.FileName)
            MessageBox.Show("XML Table Exported")
        End If
    End Sub

    Public Shared Sub JSONexport(dataGridView As DataGridView)
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "JSON files (*.json)|*.json"
        saveFileDialog.Title = "Save as JSON"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim rowsList As New List(Of Dictionary(Of String, Object))()

            For Each row As DataGridViewRow In dataGridView.Rows
                If dataGridView.AllowUserToAddRows AndAlso row.IsNewRow Then
                    Continue For
                End If

                Dim rowDict As New Dictionary(Of String, Object)()

                For Each cell As DataGridViewCell In row.Cells
                    rowDict(dataGridView.Columns(cell.ColumnIndex).HeaderText) = If(cell.Value, String.Empty)
                Next

                rowsList.Add(rowDict)
            Next

            Dim json As String = JsonConvert.SerializeObject(rowsList, Newtonsoft.Json.Formatting.Indented)
            File.WriteAllText(saveFileDialog.FileName, json)
            MessageBox.Show("JSON Table Exported")
        End If
    End Sub

    Public Shared Sub PDFexport(dataGridView As DataGridView)
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf"
        saveFileDialog.Title = "Save As PDF"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim pdfDoc As New Document(PageSize.A4)
            Try
                Dim writer As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(saveFileDialog.FileName, FileMode.Create))
                pdfDoc.Open()

                Dim pdfTable As New PdfPTable(dataGridView.ColumnCount)
                For Each column As DataGridViewColumn In dataGridView.Columns
                    Dim cell As New PdfPCell(New Phrase(column.HeaderText))
                    pdfTable.AddCell(cell)
                Next

                For Each row As DataGridViewRow In dataGridView.Rows
                    If dataGridView.AllowUserToAddRows AndAlso row.IsNewRow Then
                        Continue For
                    End If

                    For Each cell As DataGridViewCell In row.Cells
                        pdfTable.AddCell(If(cell.Value?.ToString(), String.Empty))
                    Next
                Next

                pdfDoc.Add(pdfTable)
                MessageBox.Show("PDF Table Exported")
            Catch ex As Exception
                MessageBox.Show($" {ex.Message}", "Error")
            Finally
                pdfDoc.Close()
            End Try
        End If
    End Sub

End Class
