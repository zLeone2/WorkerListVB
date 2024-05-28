<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnExportOB = New Button()
        btnImportOB = New Button()
        cbEmployees = New ComboBox()
        txtboxWrite = New TextBox()
        SuspendLayout()
        ' 
        ' btnExportOB
        ' 
        btnExportOB.Location = New Point(255, 94)
        btnExportOB.Name = "btnExportOB"
        btnExportOB.Size = New Size(75, 23)
        btnExportOB.TabIndex = 7
        btnExportOB.Text = "Export Text"
        btnExportOB.UseVisualStyleBackColor = True
        ' 
        ' btnImportOB
        ' 
        btnImportOB.Location = New Point(156, 94)
        btnImportOB.Name = "btnImportOB"
        btnImportOB.Size = New Size(75, 23)
        btnImportOB.TabIndex = 6
        btnImportOB.Text = "Import Text"
        btnImportOB.UseVisualStyleBackColor = True
        ' 
        ' cbEmployees
        ' 
        cbEmployees.FormattingEnabled = True
        cbEmployees.Location = New Point(535, 94)
        cbEmployees.Name = "cbEmployees"
        cbEmployees.RightToLeft = RightToLeft.No
        cbEmployees.Size = New Size(109, 23)
        cbEmployees.TabIndex = 5
        cbEmployees.Text = "Select Employee"
        ' 
        ' txtboxWrite
        ' 
        txtboxWrite.Location = New Point(156, 123)
        txtboxWrite.Multiline = True
        txtboxWrite.Name = "txtboxWrite"
        txtboxWrite.Size = New Size(488, 233)
        txtboxWrite.TabIndex = 4
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExportOB)
        Controls.Add(btnImportOB)
        Controls.Add(cbEmployees)
        Controls.Add(txtboxWrite)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents btnExportOB As Button
    Private WithEvents btnImportOB As Button
    Private WithEvents cbEmployees As ComboBox
    Private WithEvents txtboxWrite As TextBox
End Class
