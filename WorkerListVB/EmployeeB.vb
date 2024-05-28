Friend Class EmployeeB
    Inherits EmployeeA
    Implements IWorker

    Public Property Bonus As Decimal
    Public Property Vacationdays As Integer
    Public Property Position As String
    Public Property DecisionMakingAuthority As Boolean

    Public Sub New(name As String, lastname As String, employeeID As String, dateofbirth As DateTime, age As Integer, gender As String, adress As String, phonenumber As String, email As String, password As String, dateofhire As DateTime, salary As Double, hoursperweek As Double, bonus As Decimal, vacationdays As Integer, position As String, decisionMakingAuthority As Boolean)
        MyBase.New(name, lastname, employeeID, dateofbirth, age, gender, adress, phonenumber, email, password, dateofhire, salary, hoursperweek)
        Me.Bonus = bonus
        Me.Vacationdays = vacationdays
        Me.Position = position
        Me.DecisionMakingAuthority = decisionMakingAuthority
    End Sub
End Class