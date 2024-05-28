<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblheader = New Label()
        pictureBox1 = New PictureBox()
        btnObservations = New Button()
        btnSeeEmployee = New Button()
        button1 = New Button()
        CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblheader
        ' 
        lblheader.AutoSize = True
        lblheader.Font = New Font("Times New Roman", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblheader.Location = New Point(312, 288)
        lblheader.Name = "lblheader"
        lblheader.Size = New Size(209, 72)
        lblheader.TabIndex = 10
        lblheader.Text = "Coffee Linked " & vbCrLf & "Management"
        ' 
        ' pictureBox1
        ' 
        pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), Image)
        pictureBox1.Location = New Point(249, 28)
        pictureBox1.Name = "pictureBox1"
        pictureBox1.Size = New Size(302, 257)
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        pictureBox1.TabIndex = 9
        pictureBox1.TabStop = False
        ' 
        ' btnObservations
        ' 
        btnObservations.Location = New Point(317, 400)
        btnObservations.Name = "btnObservations"
        btnObservations.Size = New Size(204, 23)
        btnObservations.TabIndex = 8
        btnObservations.Text = "Observations"
        btnObservations.UseVisualStyleBackColor = True
        ' 
        ' btnSeeEmployee
        ' 
        btnSeeEmployee.Location = New Point(282, 363)
        btnSeeEmployee.Name = "btnSeeEmployee"
        btnSeeEmployee.Size = New Size(133, 29)
        btnSeeEmployee.TabIndex = 7
        btnSeeEmployee.Text = "See employees"
        btnSeeEmployee.UseVisualStyleBackColor = True
        ' 
        ' button1
        ' 
        button1.Location = New Point(432, 363)
        button1.Name = "button1"
        button1.Size = New Size(119, 31)
        button1.TabIndex = 6
        button1.Text = "Add Worker"
        button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblheader)
        Controls.Add(pictureBox1)
        Controls.Add(btnObservations)
        Controls.Add(btnSeeEmployee)
        Controls.Add(button1)
        Name = "Form1"
        Text = "Form1"
        CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents lblheader As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents btnObservations As Button
    Private WithEvents btnSeeEmployee As Button
    Private WithEvents button1 As Button

End Class
