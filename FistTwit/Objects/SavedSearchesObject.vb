Imports System.Runtime.Serialization

<DataContract>
Public Class SavedSearchesObject

    Public ReadOnly Property CreatedAt As DateTime
        Get
            Return DatetimeParser.Parse(cat)
        End Get
    End Property

    <DataMember(Name:="created_at")>
    Public Property cat As String

    <DataMember(Name:="id")>
    Public Property Id As Decimal?

    <DataMember(Name:="name")>
    Public Property Name As String

    <DataMember(Name:="position")>
    Public Property Position As String

    <DataMember(Name:="query")>
    Public Property Query As String

End Class

Public Class SavedSearchesObjectList
    Inherits List(Of SavedSearchesObject)
End Class