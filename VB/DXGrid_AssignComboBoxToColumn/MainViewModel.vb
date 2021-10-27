Imports System.Collections.Generic
Imports System.Linq

Namespace DXGrid_AssignComboBoxToColumn

    Public Class Person

        Public Property ProductName As String

        Public Property Type As Integer

        Public Property UnitPrice As Integer

        Public Sub New(ByVal i As Integer)
            ProductName = "FirstName" & i
            UnitPrice = i
            Type = 0
        End Sub
    End Class

    Public Class ProductType

        Public Property Id As Integer

        Public Property TypeName As String

        Public Sub New(ByVal i As Integer)
            Id = i
            TypeName = "Type" & i
        End Sub
    End Class

    Public Class MyViewModel

        Public Property PersonList As List(Of Person)

        Public Property TypeList As List(Of ProductType)

        Public Sub New()
            PersonList = New List(Of Person)(GetPersonData(20))
            TypeList = New List(Of ProductType)(GetTypeData(3))
        End Sub

        Private Shared Function GetPersonData(ByVal count As Integer) As IEnumerable(Of Person)
            Return Enumerable.Range(0, count).[Select](Function(x) New Person(x))
        End Function

        Private Shared Function GetTypeData(ByVal count As Integer) As IEnumerable(Of ProductType)
            Return Enumerable.Range(0, count).[Select](Function(x) New ProductType(x))
        End Function
    End Class
End Namespace
