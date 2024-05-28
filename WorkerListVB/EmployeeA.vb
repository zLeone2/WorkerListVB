Interface IWorker
    Property salary As Double
    Property employeeID As String
    Function IDCreator(ByVal name As String, ByVal lastname As String) As String
End Interface

Public Class EmployeeA
    Implements IWorker

    Public Property Salary As Double Implements IWorker.salary
    Public Property EmployeeID As String Implements IWorker.employeeID

    Public Function IDCreator(ByVal name As String, ByVal lastname As String) As String Implements IWorker.IDCreator
        Dim letterN As Char = Char.ToUpper(name(0))
        Dim letterLN As Char = Char.ToUpper(lastname(0))
        Return $"{letterN} {letterLN}" & New Random().Next(1000, 10000).ToString() & "A"
    End Function

    Private _name As String
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _lastname As String
    Public Property Lastname As String
        Get
            Return _lastname
        End Get
        Set(ByVal value As String)
            _lastname = value
        End Set
    End Property

    Private _password As String
    Public WriteOnly Property Password As String
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Private _age As Integer
    Public ReadOnly Property Age As Integer
        Get
            Return _age
        End Get
    End Property

    Private _gender As String
    Public Property Gender As String
        Get
            Return _gender
        End Get
        Set(ByVal value As String)
            _gender = value
        End Set
    End Property

    Private _adress As String
    Public Property Adress As String
        Get
            Return _adress
        End Get
        Set(ByVal value As String)
            _adress = value
        End Set
    End Property

    Private _phonenumber As String
    Public Property Phonenumber As String
        Get
            Return _phonenumber
        End Get
        Set(ByVal value As String)
            _phonenumber = value
        End Set
    End Property

    Private _email As String
    Public Property Email As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Private _dateofbirth As DateTime
    Public Property DateofBirth As DateTime
        Get
            Return _dateofbirth
        End Get
        Set(ByVal value As DateTime)
            _dateofbirth = value
        End Set
    End Property

    Private _dateofhire As DateTime
    Public Property Dateofhire As DateTime
        Get
            Return _dateofhire
        End Get
        Set(ByVal value As DateTime)
            _dateofhire = value
        End Set
    End Property

    Private _hoursperweek As Double
    Public Property Hoursperweek As Double
        Get
            Return _hoursperweek
        End Get
        Set(ByVal value As Double)
            _hoursperweek = value
        End Set
    End Property

    Public Sub New(ByVal name As String, ByVal lastname As String, ByVal employeeID As String, ByVal dateofbirth As DateTime, ByVal age As Integer, ByVal gender As String, ByVal adress As String, ByVal phonenumber As String, ByVal email As String, ByVal password As String, ByVal dateofhire As DateTime, ByVal salary As Double, ByVal hoursperweek As Double)
        Me.Name = name
        Me.Lastname = lastname
        Me.Password = password
        Me.EmployeeID = employeeID
        Me.Salary = salary
        Me._age = age
        Me.Gender = gender
        Me.Adress = adress
        Me.Phonenumber = phonenumber
        Me.Email = email
        Me.DateofBirth = dateofbirth
        Me.Dateofhire = dateofhire
        Me.Hoursperweek = hoursperweek
    End Sub

    Public Sub New()

    End Sub
End Class
