<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        cbExport = New ComboBox()
        cboxTypeEmployee = New ComboBox()
        dtgridEmployees = New DataGridView()
        CType(dtgridEmployees, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbExport
        ' 
        cbExport.FormattingEnabled = True
        cbExport.Items.AddRange(New Object() {"DOCX", "XLSX", "XML", "JSON", "PDF"})
        cbExport.Location = New Point(36, 6)
        cbExport.Name = "cbExport"
        cbExport.Size = New Size(121, 23)
        cbExport.TabIndex = 5
        cbExport.Text = "Export"
        ' 
        ' cboxTypeEmployee
        ' 
        cboxTypeEmployee.AccessibleName = ""
        cboxTypeEmployee.BackColor = SystemColors.Window
        cboxTypeEmployee.FormattingEnabled = True
        cboxTypeEmployee.Items.AddRange(New Object() {"Type A Employee", "Type B Employee"})
        cboxTypeEmployee.Location = New Point(659, 6)
        cboxTypeEmployee.Name = "cboxTypeEmployee"
        cboxTypeEmployee.Size = New Size(121, 23)
        cboxTypeEmployee.TabIndex = 4
        cboxTypeEmployee.Text = "Type"
        ' 
        ' dtgridEmployees
        ' 
        dtgridEmployees.AllowUserToAddRows = False
        dtgridEmployees.AllowUserToDeleteRows = False
        dtgridEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgridEmployees.Location = New Point(21, 35)
        dtgridEmployees.Name = "dtgridEmployees"
        dtgridEmployees.Size = New Size(759, 409)
        dtgridEmployees.TabIndex = 3
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cbExport)
        Controls.Add(cboxTypeEmployee)
        Controls.Add(dtgridEmployees)
        Name = "Form3"
        Text = "Form3"
        CType(dtgridEmployees, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Private WithEvents cbExport As ComboBox
    Private WithEvents cboxTypeEmployee As ComboBox
    Private WithEvents dtgridEmployees As DataGridView
End Class
