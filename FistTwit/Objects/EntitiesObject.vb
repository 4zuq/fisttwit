Imports System.Runtime.Serialization

<DataContract>
Public Class EntitiesObject

    <DataMember(Name:="media")>
    Public Property Media As MediaEntity()

    <DataMember(Name:="urls")>
    Public Property Urls As UrlEntity()

    <DataMember(Name:="user_mentions")>
    Public Property UserMentions As UserMentionsEntity()

    <DataMember(Name:="hashtags")>
    Public Property HashTags As HastTagsEntity()

    <DataMember(Name:="symbols")>
    Public Property Symbols As SymbolsEntity()
End Class

<DataContract>
Public Class MediaEntity

    <DataMember(Name:="id")>
    Public Property Id As Decimal?

    <DataMember(Name:="media_url")>
    Public Property MediaUrl As String

    <DataMember(Name:="media_url_https")>
    Public Property MediaUrlHttps As String

    <DataMember(Name:="url")>
    Public Property Url As String

    <DataMember(Name:="display_url")>
    Public Property DisplayUrl As String

    <DataMember(Name:="expanded_url")>
    Public Property ExpandedUrl As String

    <DataMember(Name:="type")>
    Public Property Type As String

    <DataMember(Name:="sizes")>
    Public Property Sizes As MediaEntityKinds
End Class

<DataContract>
Public Class MediaEntitySizes

    <DataMember(Name:="w")>
    Public Property W As Decimal?

    <DataMember(Name:="h")>
    Public Property H As Decimal?

    <DataMember(Name:="resize")>
    Public Property Resize As String
End Class

<DataContract>
Public Class MediaEntityKinds

    <DataMember(Name:="medium")>
    Public Property Medium As MediaEntitySizes

    <DataMember(Name:="thumb")>
    Public Property Thumb As MediaEntitySizes

    <DataMember(Name:="small")>
    Public Property Small As MediaEntitySizes

    <DataMember(Name:="large")>
    Public Property Large As MediaEntitySizes
End Class

<DataContract>
Public Class UrlEntity

    <DataMember(Name:="url")>
    Public Property Url As String

    <DataMember(Name:="display_url")>
    Public Property DisplayUrl As String

    <DataMember(Name:="expanded_url")>
    Public Property ExpandedUrl As String

    <DataMember(Name:="indices")>
    Public Property Indices As Decimal()
End Class

<DataContract>
Public Class UserMentionsEntity

    <DataMember(Name:="id")>
    Public Property Id As Decimal?

    <DataMember(Name:="screen_name")>
    Public Property ScreenName As String

    <DataMember(Name:="name")>
    Public Property Name As String

    <DataMember(Name:="indices")>
    Public Property Indices As Decimal()
End Class

<DataContract>
Public Class HastTagsEntity

    <DataMember(Name:="text")>
    Public Property Text As String

    <DataMember(Name:="indices")>
    Public Property Indices As Decimal()
End Class

<DataContract>
Public Class SymbolsEntity

    <DataMember(Name:="text")>
    Public Property Text As String

    <DataMember(Name:="indices")>
    Public Property Indices As Decimal()
End Class
