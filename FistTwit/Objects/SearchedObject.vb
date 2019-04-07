Imports System.Runtime.Serialization

<DataContract>
Public Class SearchedObject

    ''' <summary>
    ''' results of query
    ''' </summary>
    <DataMember(Name:="statuses")>
    Public Property Statuses As StatusObjectList

    ''' <summary>
    ''' the metadata of query
    ''' </summary>
    <DataMember(Name:="search_metadata")>
    Public Property MetaData As SearchMetadata

End Class

<DataContract>
Public Class SearchMetadata

    ''' <summary>
    ''' Maxid
    ''' </summary>
    <DataMember(Name:="max_id")>
    Public Property MaxId As Decimal

    ''' <summary>
    ''' SinceId
    ''' </summary>
    <DataMember(Name:="since_id")>
    Public Property SinceId As Decimal

    ''' <summary>
    ''' The count of statuses
    ''' </summary>
    <DataMember(Name:="count")>
    Public Property Count As Decimal?

    ''' <summary>
    ''' Completed_in
    ''' </summary>
    <DataMember(Name:="completed_in")>
    Public Property CompletedIn As Decimal?

    ''' <summary>
    ''' The searched query
    ''' </summary>
    <DataMember(Name:="query")>
    Public Property Query As String
End Class