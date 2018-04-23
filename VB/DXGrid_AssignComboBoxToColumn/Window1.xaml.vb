Imports System.Collections.ObjectModel
Imports System.Windows

Namespace DXGrid_AssignComboBoxToColumn
    Partial Public Class Window1
        Inherits Window

        Public Sub New()
            InitializeComponent()
            Me.DataContext = New MyViewModel()
        End Sub
    End Class
    Public Class MyViewModel
        Public Sub New()
            CreateList()
        End Sub

        Public Property PersonList() As ObservableCollection(Of Person)
        Public Property TypeList() As ObservableCollection(Of ProductType)
        Private Sub CreateList()
            PersonList = New ObservableCollection(Of Person)()
            For i As Integer = 0 To 19
                Dim p As New Person(i)
                PersonList.Add(p)
            Next i
            TypeList = New ObservableCollection(Of ProductType)()
            For i As Integer = 0 To 2
                TypeList.Add(New ProductType(i))
            Next i
        End Sub
    End Class
    Public Class Person
        Public Sub New(ByVal i As Integer)
            ProductName = "FirstName" & i

            UnitPrice = i
            Type = 0
        End Sub

        Public Property ProductName() As String

        Public Property Type() As Integer

        Public Property UnitPrice() As Integer
    End Class

    Public Class ProductType
        Public Sub New(ByVal i As Integer)
            Id = i
            TypeName = "Type" & i
        End Sub
        Public Property Id() As Integer
        Public Property TypeName() As String
    End Class
End Namespace
