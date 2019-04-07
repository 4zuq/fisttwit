Imports System.Runtime.Serialization

<DataContract>
Public Class HelpConfigurationObject

    <DataMember(Name:="characters_reserved_per_media")>
    Public Property CharactersReservedPerMedia As Decimal?

    <DataMember(Name:="max_media_per_upload")>
    Public Property MaxMediaPerUpload As Decimal?

    <DataMember(Name:="non_username_paths")>
    Public Property NonUsernamePaths As String()

    <DataMember(Name:="photo_size_limit")>
    Public Property PhotoSizeLimit As Decimal?

    <DataMember(Name:="photo_sizes")>
    Public Property PhotoSizes As MediaEntityKinds

    <DataMember(Name:="short_url_length_https")>
    Public Property ShortUrlLengthHttps As Decimal?

    <DataMember(Name:="short_url_length")>
    Public Property ShortUrlLength As Decimal?
End Class

<DataContract>
Public Class LanguageObject

    <DataMember(Name:="name")>
    Public Property Name As String

    <DataMember(Name:="code")>
    Public Property Code As Decimal?

    <DataMember(Name:="status")>
    Public Property Status As String
End Class

Public Class LanguageObjectList
    Inherits List(Of LanguageObject)
End Class

<DataContract>
Public Class PrivacyPolicyObject

    <DataMember(Name:="privacy")>
    Public Property Privacy As String
End Class

<DataContract>
Public Class TosObject

    <DataMember(Name:="tos")>
    Public Property Tos As String
End Class