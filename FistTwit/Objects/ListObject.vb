Imports System.Runtime.Serialization

<DataContract>
Public Class ListObject

    Public ReadOnly Property CreatedAt As DateTime
        Get
            Return DatetimeParser.Parse(cat)
        End Get
    End Property

    <DataMember(Name:="created_at")>
    Private Property cat As String

    <DataMember(Name:="slug")>
    Public Property Slug As String

    <DataMember(Name:="name")>
    Public Property Name As String

    <DataMember(Name:="uri")>
    Public Property Uri As String

    <DataMember(Name:="subscriber_count")>
    Public Property SubscriberCount As Decimal?

    <DataMember(Name:="id")>
    Public Property Id As Decimal?

    <DataMember(Name:="member_count")>
    Public Property MemberCount As Decimal?

    <DataMember(Name:="mode")>
    Public Property Mode As String

    <DataMember(Name:="full_name")>
    Public Property FullName As String

    <DataMember(Name:="description")>
    Public Property Description As String

    <DataMember(Name:="user")>
    Public Property User As UserObject
End Class

Public Class ListObjectList
    Inherits List(Of ListObject)
End Class

<DataContract>
Public Class ListObjectWithCursorList

    <DataMember(Name:="previous_cursor")>
    Public Property PreviousCursor As Decimal?

    <DataMember(Name:="next_cursor")>
    Public Property NextCursor As Decimal?

    <DataMember(Name:="lists")>
    Public Property Lists As ListObjectList
End Class