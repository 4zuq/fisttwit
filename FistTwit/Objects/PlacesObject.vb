Imports System.Runtime.Serialization

<DataContract>
Public Class PlacesObject

    <DataMember(Name:="attributes")>
    Public Property Attributes As AttributesObject

    <DataMember(Name:="bounding_box")>
    Public Property BoundingBox As BoundingBoxObject

    <DataMember(Name:="country")>
    Public Property Country As String

    <DataMember(Name:="country_code")>
    Public Property CountryCode As String

    <DataMember(Name:="full_name")>
    Public Property FullName As String

    <DataMember(Name:="id")>
    Public Property Id As String

    <DataMember(Name:="name")>
    Public Property Name As String

    <DataMember(Name:="place_type")>
    Public Property PlaceType As String

    <DataMember(Name:="url")>
    Public Property Url As String

End Class

<DataContract>
Public Class AttributesObject

    <DataMember(Name:="street_address")>
    Public Property StreetAddress As String
End Class

<DataContract>
Public Class BoundingBoxObject

    <DataMember(Name:="coordinates")>
    Public Property Coordinates As List(Of List(Of Decimal()))

    <DataMember(Name:="type")>
    Public Property Type As String
End Class

<DataContract>
Public Class QueryResultGeoObject

    <DataMember(Name:="query")>
    Public Property Query As GeoQuery

    <DataMember(Name:="result")>
    Public Property Result As List(Of PlacesObject)

End Class

<DataContract>
Public Class GeoQuery

    <DataMember(Name:="url")>
    Public Property Url As String

    <DataMember(Name:="type")>
    Public Property Type As String

    <DataMember(Name:="params")>
    Public Property Params As GeoParams
End Class

<DataContract>
Public Class GeoParams

    <DataMember(Name:="accuracy")>
    Public Property Accuracy As Decimal?

    <DataMember(Name:="coordinates")>
    Public Property Coordinates As BoundingBoxObject

    <DataMember(Name:="granularity")>
    Public Property Granularity As String

    <DataMember(Name:="query")>
    Public Property Query As String

    <DataMember(Name:="autocomplete")>
    Public Property IsAutocomplete As Boolean?

    <DataMember(Name:="trim_place")>
    Public Property IsTrimPlace As Boolean?

    <DataMember(Name:="name")>
    Public Property Name As String
End Class