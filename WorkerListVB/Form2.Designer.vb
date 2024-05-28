<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        txtboxValidation = New TextBox()
        btnPassword = New Button()
        btnID = New Button()
        label1 = New Label()
        vacationlbl = New Label()
        lblbonus = New Label()
        lblsalary = New Label()
        lblhours = New Label()
        lbldth = New Label()
        lblemail = New Label()
        lblphone = New Label()
        lbladress = New Label()
        lblgender = New Label()
        lblbrth = New Label()
        lblpass = New Label()
        lblastnm = New Label()
        lblname = New Label()
        btnTB = New Button()
        txtboxEmail = New TextBox()
        txtboxPosition = New TextBox()
        txtboxVacation = New TextBox()
        txtboxBonus = New TextBox()
        txtboxSalary = New TextBox()
        txtboxHourspr = New TextBox()
        txtboxGender = New TextBox()
        txtboxDateHire = New TextBox()
        txtboxAdress = New TextBox()
        txtboxPhone = New TextBox()
        txtboxDateBirth = New TextBox()
        txtboxLastName = New TextBox()
        txtbosName = New TextBox()
        btnTA = New Button()
        SuspendLayout()
        ' 
        ' txtboxValidation
        ' 
        txtboxValidation.Location = New Point(552, 136)
        txtboxValidation.Multiline = True
        txtboxValidation.Name = "txtboxValidation"
        txtboxValidation.ReadOnly = True
        txtboxValidation.Size = New Size(220, 44)
        txtboxValidation.TabIndex = 70
        ' 
        ' btnPassword
        ' 
        btnPassword.Location = New Point(253, 247)
        btnPassword.Name = "btnPassword"
        btnPassword.Size = New Size(75, 23)
        btnPassword.TabIndex = 69
        btnPassword.Text = "Generate"
        btnPassword.UseVisualStyleBackColor = True
        ' 
        ' btnID
        ' 
        btnID.Location = New Point(240, 320)
        btnID.Name = "btnID"
        btnID.Size = New Size(113, 23)
        btnID.TabIndex = 68
        btnID.Text = "Generate ID"
        btnID.UseVisualStyleBackColor = True
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Location = New Point(54, 302)
        label1.Name = "label1"
        label1.Size = New Size(50, 15)
        label1.TabIndex = 67
        label1.Text = "Position"
        ' 
        ' vacationlbl
        ' 
        vacationlbl.AutoSize = True
        vacationlbl.Location = New Point(370, 229)
        vacationlbl.Name = "vacationlbl"
        vacationlbl.Size = New Size(89, 15)
        vacationlbl.TabIndex = 66
        vacationlbl.Text = "Vacational Days"
        ' 
        ' lblbonus
        ' 
        lblbonus.AutoSize = True
        lblbonus.Location = New Point(160, 302)
        lblbonus.Name = "lblbonus"
        lblbonus.Size = New Size(40, 15)
        lblbonus.TabIndex = 65
        lblbonus.Text = "Bonus"
        ' 
        ' lblsalary
        ' 
        lblsalary.AutoSize = True
        lblsalary.Location = New Point(54, 229)
        lblsalary.Name = "lblsalary"
        lblsalary.Size = New Size(37, 15)
        lblsalary.TabIndex = 64
        lblsalary.Text = "salary"
        ' 
        ' lblhours
        ' 
        lblhours.AutoSize = True
        lblhours.Location = New Point(346, 165)
        lblhours.Name = "lblhours"
        lblhours.Size = New Size(87, 15)
        lblhours.TabIndex = 63
        lblhours.Text = "hours per week"
        ' 
        ' lbldth
        ' 
        lbldth.AutoSize = True
        lbldth.Location = New Point(253, 165)
        lbldth.Name = "lbldth"
        lbldth.Size = New Size(68, 15)
        lbldth.TabIndex = 62
        lbldth.Text = "Date of hire"
        ' 
        ' lblemail
        ' 
        lblemail.AutoSize = True
        lblemail.Location = New Point(151, 229)
        lblemail.Name = "lblemail"
        lblemail.Size = New Size(81, 15)
        lblemail.TabIndex = 61
        lblemail.Text = "Emprise Email"
        ' 
        ' lblphone
        ' 
        lblphone.AutoSize = True
        lblphone.Location = New Point(42, 165)
        lblphone.Name = "lblphone"
        lblphone.Size = New Size(86, 15)
        lblphone.TabIndex = 60
        lblphone.Text = "phone number"
        ' 
        ' lbladress
        ' 
        lbladress.AutoSize = True
        lbladress.Location = New Point(151, 165)
        lbladress.Name = "lbladress"
        lbladress.Size = New Size(40, 15)
        lbladress.TabIndex = 59
        lbladress.Text = "adress"
        ' 
        ' lblgender
        ' 
        lblgender.AutoSize = True
        lblgender.Location = New Point(376, 107)
        lblgender.Name = "lblgender"
        lblgender.Size = New Size(45, 15)
        lblgender.TabIndex = 58
        lblgender.Text = "Gender"
        ' 
        ' lblbrth
        ' 
        lblbrth.AutoSize = True
        lblbrth.Location = New Point(264, 107)
        lblbrth.Name = "lblbrth"
        lblbrth.Size = New Size(73, 15)
        lblbrth.TabIndex = 57
        lblbrth.Text = "Date of Birth"
        ' 
        ' lblpass
        ' 
        lblpass.AutoSize = True
        lblpass.Location = New Point(264, 229)
        lblpass.Name = "lblpass"
        lblpass.Size = New Size(57, 15)
        lblpass.TabIndex = 56
        lblpass.Text = "Password"
        ' 
        ' lblastnm
        ' 
        lblastnm.AutoSize = True
        lblastnm.Location = New Point(151, 107)
        lblastnm.Name = "lblastnm"
        lblastnm.Size = New Size(63, 15)
        lblastnm.TabIndex = 55
        lblastnm.Text = "Last Name"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Location = New Point(63, 107)
        lblname.Name = "lblname"
        lblname.Size = New Size(39, 15)
        lblname.TabIndex = 54
        lblname.Text = "Name"
        ' 
        ' btnTB
        ' 
        btnTB.Location = New Point(697, 107)
        btnTB.Name = "btnTB"
        btnTB.Size = New Size(75, 23)
        btnTB.TabIndex = 53
        btnTB.Text = "Type B"
        btnTB.UseVisualStyleBackColor = True
        ' 
        ' txtboxEmail
        ' 
        txtboxEmail.Location = New Point(140, 247)
        txtboxEmail.Name = "txtboxEmail"
        txtboxEmail.Size = New Size(100, 23)
        txtboxEmail.TabIndex = 52
        ' 
        ' txtboxPosition
        ' 
        txtboxPosition.Location = New Point(28, 320)
        txtboxPosition.Name = "txtboxPosition"
        txtboxPosition.Size = New Size(100, 23)
        txtboxPosition.TabIndex = 51
        ' 
        ' txtboxVacation
        ' 
        txtboxVacation.Location = New Point(359, 247)
        txtboxVacation.Name = "txtboxVacation"
        txtboxVacation.Size = New Size(100, 23)
        txtboxVacation.TabIndex = 50
        ' 
        ' txtboxBonus
        ' 
        txtboxBonus.Location = New Point(134, 320)
        txtboxBonus.Name = "txtboxBonus"
        txtboxBonus.Size = New Size(100, 23)
        txtboxBonus.TabIndex = 49
        ' 
        ' txtboxSalary
        ' 
        txtboxSalary.Location = New Point(28, 247)
        txtboxSalary.Name = "txtboxSalary"
        txtboxSalary.Size = New Size(100, 23)
        txtboxSalary.TabIndex = 48
        ' 
        ' txtboxHourspr
        ' 
        txtboxHourspr.Location = New Point(346, 183)
        txtboxHourspr.Name = "txtboxHourspr"
        txtboxHourspr.Size = New Size(100, 23)
        txtboxHourspr.TabIndex = 47
        ' 
        ' txtboxGender
        ' 
        txtboxGender.Location = New Point(346, 125)
        txtboxGender.Name = "txtboxGender"
        txtboxGender.Size = New Size(100, 23)
        txtboxGender.TabIndex = 46
        ' 
        ' txtboxDateHire
        ' 
        txtboxDateHire.Location = New Point(240, 183)
        txtboxDateHire.Name = "txtboxDateHire"
        txtboxDateHire.Size = New Size(100, 23)
        txtboxDateHire.TabIndex = 45
        ' 
        ' txtboxAdress
        ' 
        txtboxAdress.Location = New Point(134, 183)
        txtboxAdress.Name = "txtboxAdress"
        txtboxAdress.Size = New Size(100, 23)
        txtboxAdress.TabIndex = 44
        ' 
        ' txtboxPhone
        ' 
        txtboxPhone.Location = New Point(28, 183)
        txtboxPhone.Name = "txtboxPhone"
        txtboxPhone.Size = New Size(100, 23)
        txtboxPhone.TabIndex = 43
        ' 
        ' txtboxDateBirth
        ' 
        txtboxDateBirth.Location = New Point(240, 125)
        txtboxDateBirth.Name = "txtboxDateBirth"
        txtboxDateBirth.Size = New Size(100, 23)
        txtboxDateBirth.TabIndex = 42
        ' 
        ' txtboxLastName
        ' 
        txtboxLastName.Location = New Point(134, 125)
        txtboxLastName.Name = "txtboxLastName"
        txtboxLastName.Size = New Size(100, 23)
        txtboxLastName.TabIndex = 41
        ' 
        ' txtbosName
        ' 
        txtbosName.Location = New Point(28, 125)
        txtbosName.Name = "txtbosName"
        txtbosName.Size = New Size(100, 23)
        txtbosName.TabIndex = 40
        ' 
        ' btnTA
        ' 
        btnTA.Location = New Point(552, 107)
        btnTA.Name = "btnTA"
        btnTA.Size = New Size(75, 23)
        btnTA.TabIndex = 39
        btnTA.Text = "Type A"
        btnTA.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtboxValidation)
        Controls.Add(btnPassword)
        Controls.Add(btnID)
        Controls.Add(label1)
        Controls.Add(vacationlbl)
        Controls.Add(lblbonus)
        Controls.Add(lblsalary)
        Controls.Add(lblhours)
        Controls.Add(lbldth)
        Controls.Add(lblemail)
        Controls.Add(lblphone)
        Controls.Add(lbladress)
        Controls.Add(lblgender)
        Controls.Add(lblbrth)
        Controls.Add(lblpass)
        Controls.Add(lblastnm)
        Controls.Add(lblname)
        Controls.Add(btnTB)
        Controls.Add(txtboxEmail)
        Controls.Add(txtboxPosition)
        Controls.Add(txtboxVacation)
        Controls.Add(txtboxBonus)
        Controls.Add(txtboxSalary)
        Controls.Add(txtboxHourspr)
        Controls.Add(txtboxGender)
        Controls.Add(txtboxDateHire)
        Controls.Add(txtboxAdress)
        Controls.Add(txtboxPhone)
        Controls.Add(txtboxDateBirth)
        Controls.Add(txtboxLastName)
        Controls.Add(txtbosName)
        Controls.Add(btnTA)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private WithEvents txtboxValidation As TextBox
    Private WithEvents btnPassword As Button
    Private WithEvents btnID As Button
    Private WithEvents label1 As Label
    Private WithEvents vacationlbl As Label
    Private WithEvents lblbonus As Label
    Private WithEvents lblsalary As Label
    Private WithEvents lblhours As Label
    Private WithEvents lbldth As Label
    Private WithEvents lblemail As Label
    Private WithEvents lblphone As Label
    Private WithEvents lbladress As Label
    Private WithEvents lblgender As Label
    Private WithEvents lblbrth As Label
    Private WithEvents lblpass As Label
    Private WithEvents lblastnm As Label
    Private WithEvents lblname As Label
    Private WithEvents btnTB As Button
    Private WithEvents txtboxEmail As TextBox
    Private WithEvents txtboxPosition As TextBox
    Private WithEvents txtboxVacation As TextBox
    Private WithEvents txtboxBonus As TextBox
    Private WithEvents txtboxSalary As TextBox
    Private WithEvents txtboxHourspr As TextBox
    Private WithEvents txtboxGender As TextBox
    Private WithEvents txtboxDateHire As TextBox
    Private WithEvents txtboxAdress As TextBox
    Private WithEvents txtboxPhone As TextBox
    Private WithEvents txtboxDateBirth As TextBox
    Private WithEvents txtboxLastName As TextBox
    Private WithEvents txtbosName As TextBox
    Private WithEvents btnTA As Button
End Class
