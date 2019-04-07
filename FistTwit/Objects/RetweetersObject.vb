Imports System.Runtime.Serialization

<DataContract>
Public Class RetweetersObject

    ''' <summary>
    ''' PreviousCursor
    ''' </summary>
    <DataMember(Name:="previous_cursor")>
    Public Property PreviousCursor As Decimal?

    ''' <summary>
    ''' The list of ids
    ''' </summary>
    <DataMember(Name:="ids")>
    Public Property Ids As Decimal()

    ''' <summary>
    ''' NextCursor
    ''' </summary>
    <DataMember(Name:="next_cursor")>
    Public Property NextCursor As Decimal?


End Class
