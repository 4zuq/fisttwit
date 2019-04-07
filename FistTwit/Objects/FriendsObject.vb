Imports System.Runtime.Serialization


<DataContract>
Public Class UserIdsList

    ''' <summary>
    ''' The list of ids.
    ''' </summary>
    <DataMember(Name:="ids")>
    Public Property Ids As List(Of Decimal)

    ''' <summary>
    ''' Previous_cursor
    ''' </summary>
    <DataMember(Name:="previous_cursor")>
    Public Property PreviousCursor As Decimal?

    ''' <summary>
    ''' NextCursor
    ''' </summary>
    <DataMember(Name:="next_cursor")>
    Public Property NextCursor As Decimal?
End Class

<DataContract>
Public Class FriendsLookupObject

    ''' <summary>
    ''' The name
    ''' </summary>
    <DataMember(Name:="name")>
    Public Property Name As String

    ''' <summary>
    ''' The id
    ''' </summary>
    <DataMember(Name:="id")>
    Public Property Id As Decimal

    ''' <summary>
    ''' The conditions of the user
    ''' </summary>
    <DataMember(Name:="connections")>
    Public Property Connections As String()

    ''' <summary>
    ''' ScreenName
    ''' </summary>
    <DataMember(Name:="screen_name")>
    Public Property ScreenName As String
End Class

Public Class FriendsLookupObjectList
    Inherits List(Of FriendsLookupObject)
End Class