Imports System.Runtime.Serialization

<DataContract>
Public Class OembedObject

    ''' <summary>
    ''' HTML
    ''' </summary>
    <DataMember(Name:="html")>
    Public Property HTML As String

    ''' <summary>
    ''' Author's name
    ''' </summary>
    <DataMember(Name:="author_name")>
    Public Property AuthorName As String

    ''' <summary>
    ''' ProviderUrl
    ''' </summary>
    <DataMember(Name:="provider_url")>
    Public Property ProviderUrl As String

    ''' <summary>
    ''' Url
    ''' </summary>
    <DataMember(Name:="url")>
    Public Property Url As Uri

    ''' <summary>
    ''' ProviderName
    ''' </summary>
    <DataMember(Name:="provider_name")>
    Public Property ProviderName As String


    ''' <summary>
    ''' Version
    ''' </summary>
    <DataMember(Name:="version")>
    Public Property Version As Decimal

    ''' <summary>
    ''' Type
    ''' </summary>
    <DataMember(Name:="type")>
    Public Property Type As String

    ''' <summary>
    ''' height
    ''' </summary>
    <DataMember(Name:="height")>
    Public Property Height As Decimal?

    ''' <summary>
    ''' CacheAge
    ''' </summary>
    <DataMember(Name:="cache_age")>
    Public Property CacheAge As Decimal

    ''' <summary>
    ''' Author's url
    ''' </summary>
    <DataMember(Name:="author_url")>
    Public Property AuthorUrl As Uri

    ''' <summary>
    ''' Width
    ''' </summary>
    <DataMember(Name:="width")>
    Public Property Width As Decimal?
End Class
