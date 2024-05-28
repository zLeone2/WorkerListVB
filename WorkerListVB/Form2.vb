Imports System.IO
Imports System.Text

Partial Public Class Form2
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private idgenerate As String
    Private ages As Integer
    Public employeesA As String()
    Public employeesB As String()
    Private decitionmaking As Boolean

    Private Sub btnTA_Click(sender As Object, e As EventArgs) Handles btnTA.Click
        txtboxValidation.Text = String.Empty

        If String.IsNullOrWhiteSpace(idgenerate) OrElse String.IsNullOrWhiteSpace(Generatepassword()) Then
            Return
        End If

        Select Case txtBoxCounter()
            Case 4
                txtboxValidation.Text = "Employee successfully added"

                Try
                    getAge(Convert.ToDateTime(txtboxDateBirth.Text))
                    Dim employeeA As New EmployeeA(txtbosName.Text, txtboxLastName.Text, idgenerate, Convert.ToDateTime(txtboxDateBirth.Text), ages, txtboxGender.Text, txtboxAdress.Text, txtboxPhone.Text, txtboxEmail.Text, Generatepassword(), Convert.ToDateTime(txtboxDateHire.Text), Convert.ToDouble(txtboxSalary.Text), Convert.ToDouble(txtboxHourspr.Text))
                    employeesA = New String() {employeeA.Name, employeeA.Lastname, employeeA.EmployeeID, employeeA.DateofBirth.ToString("dd-MM-yyyy"), employeeA.Age.ToString(), employeeA.Gender, employeeA.Adress, employeeA.Phonenumber, employeeA.Email, employeeA.Dateofhire.ToString("dd-MM-yyyy"), employeeA.Salary.ToString(), employeeA.Hoursperweek.ToString()}

                    WriteTextToFile("C:\Users\Roberto\source\repos\WorkerListVB\WorkerListVB\ListEmployeeA.txt", employeesA)
                Catch ex As Exception
                    txtboxValidation.Text = ex.Message
                End Try

            Case > 4
                txtboxValidation.Text = "Missing Information"
            Case < 4
                txtboxValidation.Text = "Too much Information for a Type A employee"
        End Select
    End Sub

    Private Sub btnTB_Click(sender As Object, e As EventArgs) Handles btnTB.Click
        txtboxValidation.Text = String.Empty

        If String.IsNullOrWhiteSpace(idgenerate) OrElse String.IsNullOrWhiteSpace(Generatepassword()) Then
            Return
        End If

        Decisionmaking()

        Select Case txtBoxCounter()
            Case 1
                txtboxValidation.Text = "Employee successfully added"
                Try
                    getAge(Convert.ToDateTime(txtboxDateBirth.Text))
                    Dim employeeB As New EmployeeB(txtbosName.Text, txtboxLastName.Text, idgenerate, Convert.ToDateTime(txtboxDateBirth.Text).Date, ages, txtboxGender.Text, txtboxAdress.Text, txtboxPhone.Text, txtboxEmail.Text, Generatepassword(), Convert.ToDateTime(txtboxDateHire.Text).Date, Convert.ToDouble(txtboxSalary.Text), Convert.ToDouble(txtboxHourspr.Text), Convert.ToDecimal(txtboxBonus.Text), Convert.ToInt32(txtboxVacation.Text), txtboxPosition.Text, decitionmaking)
                    employeesB = New String() {employeeB.Name, employeeB.Lastname, employeeB.EmployeeID, employeeB.DateofBirth.ToString("dd-MM-yyyy"), employeeB.Age.ToString(), employeeB.Gender, employeeB.Adress, employeeB.Phonenumber, employeeB.Email, employeeB.Dateofhire.ToString("dd-MM-yyyy"), employeeB.Salary.ToString(), employeeB.Hoursperweek.ToString(), employeeB.Bonus.ToString(), employeeB.Vacationdays.ToString(), employeeB.Position, employeeB.DecisionMakingAuthority.ToString()}

                    WriteTextToFile("C:\Users\Roberto\source\repos\WorkerListVB\WorkerListVB\ListEmployeeB.txt", employeesB)
                Catch ex As Exception
                    txtboxValidation.Text = ex.StackTrace
                End Try

            Case > 1
                txtboxValidation.Text = "Missing Information"
        End Select
    End Sub

    Private Function txtBoxCounter() As Integer
        Dim counter As Integer = 0
        Dim emptyboxcounter As Integer = 0

        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                counter += 1
                If String.IsNullOrWhiteSpace(CType(control, TextBox).Text) Then
                    emptyboxcounter += 1
                End If
            End If
        Next

        Return emptyboxcounter
    End Function

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        Generatepassword()
    End Sub

    Private Function Generatepassword() As String
        Const uppercaseLetters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Const lowercaseLetters As String = "abcdefghijklmnopqrstuvwxyz"
        Const numbers As String = "0123456789"
        Const symbols As String = "!@#$%^&*()-_=+<>?"

        Dim allCharacters As String = uppercaseLetters & lowercaseLetters & numbers & symbols
        Dim password As New StringBuilder()

        For i As Integer = 0 To 9
            Dim index As Integer = New Random().Next(allCharacters.Length)
            password.Append(allCharacters(index))
        Next

        Return password.ToString()
    End Function

    Private Sub btnID_Click(sender As Object, e As EventArgs) Handles btnID.Click
        idgenerate = New EmployeeA().IDCreator(txtbosName.Text, txtboxLastName.Text)
    End Sub

    Private Sub getAge([date] As DateTime)
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - [date].Year

        If [date] > today.AddYears(-age) Then
            age -= 1
        End If

        ages = age
    End Sub

    Private Sub WriteTextToFile(filePath As String, employees As String())
        Dim linea As String = String.Join(",", employees)

        Try
            Using sw As New StreamWriter(filePath, True)
                sw.WriteLine(linea)
            End Using
        Catch ex As UnauthorizedAccessException
            Console.WriteLine($"Error de permisos: {ex.Message}")
        Catch ex As DirectoryNotFoundException
            Console.WriteLine($"Directorio no encontrado: {ex.Message}")
        Catch ex As IOException
            Console.WriteLine($"Error de E/S: {ex.Message}")
        Catch ex As Exception
            Console.WriteLine($"Ocurrió un error: {ex.Message}")
        End Try
    End Sub

    Private Sub Decisionmaking()
        Select Case txtboxPosition.Text
            Case "HR", "Accounter"
                decitionmaking = False
            Case "Manager", "Assistent Manager"
                decitionmaking = True
            Case Else
                txtboxPosition.Text = "Position not recognized"
        End Select
    End Sub
End Class