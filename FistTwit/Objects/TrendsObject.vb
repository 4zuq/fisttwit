Imports System.Runtime.Serialization

Public Class TrendsPlaceObjectList
    Inherits List(Of TrendsPlaceObject)
End Class

<DataContract>
Public Class TrendsPlaceObject

    Public Function AsOf() As DateTime
        Return DatetimeParser.ParseForTrends(as_of)
    End Function

    Public ReadOnly Property CreatedAt As DateTime
        Get
            Return DatetimeParser.ParseForTrends(created_at)
        End Get
    End Property

    <DataMember(Name:="as_of")>
    Private Property as_of As String

    <DataMember(Name:="created_at")>
    Private Property created_at As String

    <DataMember(Name:="trends")>
    Public Property Trends As List(Of TrendsPlace)

    <DataMember(Name:="locations")>
    Public Property Locations As List(Of TrendLocation)
End Class

<DataContract>
Public Class TrendsPlace

    <DataMember(Name:="events")>
    Public Property Events As String

    <DataMember(Name:="name")>
    Public Property Name As String

    <DataMember(Name:="promoted_content")>
    Public Property PromotedContent As String

    <DataMember(Name:="query")>
    Public Property Query As String

    <DataMember(Name:="url")>
    Public Property Url As String
End Class

<DataContract>
Public Class TrendLocation

    <DataMember(Name:="name")>
    Public Property Name As String

    <DataMember(Name:="woeid")>
    Public Property Woeid As Decimal?
End Class

<DataContract>
Public Class TrendsObject

    <DataMember(Name:="country")>
    Public Property Country As String

    <DataMember(Name:="countryCode")>
    Public Property CountryCode As String

    <DataMember(Name:="name")>
    Public Property Name As String

    <DataMember(Name:="parentid")>
    Public Property ParentId As Decimal?

    <DataMember(Name:="placeType")>
    Public Property PlaceType As PlaceTypeObject

    <DataMember(Name:="url")>
    Public Property Url As String

    <DataMember(Name:="woeid")>
    Public Property Woeid As Decimal?

End Class

Public Class TrendsObjectList
    Inherits List(Of TrendsObject)
End Class

<DataContract>
Public Class PlaceTypeObject

    <DataMember(Name:="code")>
    Public Property Code As Decimal?

    <DataMember(Name:="name")>
    Public Property Name As String
End Class