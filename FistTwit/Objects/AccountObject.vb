Imports System.Runtime.Serialization

<DataContract>
Public Class AccountObject

    <DataMember(Name:="always_use_https")>
    Public Property IsAlwaysUseHttps As Boolean?

    <DataMember(Name:="discoverable_by_email")>
    Public Property IsDiscoverableByEmail As Boolean?

    <DataMember(Name:="geo_enabled")>
    Public Property IsGeoEnabled As Boolean?

    <DataMember(Name:="language")>
    Public Property Language As String

    <DataMember(Name:="protected")>
    Public Property IsProtected As Boolean?

    <DataMember(Name:="screen_name")>
    Public Property ScreenName As String

    <DataMember(Name:="show_all_inline_media")>
    Public Property IsShowAllInlineMedia As Boolean?

    <DataMember(Name:="use_cookie_personalization")>
    Public Property IsUseCookiePersonalization As Boolean?

    <DataMember(Name:="sleep_time")>
    Public Property SleepTime As SleepTimeObject

    <DataMember(Name:="time_zone")>
    Public Property TimeZone As TimeZoneObject
End Class

<DataContract>
Public Class SleepTimeObject

    <DataMember(Name:="enabled")>
    Public Property IsEnabled As Boolean?

    <DataMember(Name:="end_time")>
    Public Property EndTime As String

    <DataMember(Name:="start_time")>
    Public Property StartTime As String
End Class

<DataContract>
Public Class TimeZoneObject

    <DataMember(Name:="name")>
    Public Property Name As String

    <DataMember(Name:="tzinfo_name")>
    Public Property TzinfoName As String

    <DataMember(Name:="utc_offset")>
    Public Property UtcOffset As String
End Class

<DataContract>
Public Class TrendLocationObject

    <DataMember(Name:="country")>
    Public Property Country As String

    <DataMember(Name:="countryCode")>
    Public Property CountryCode As String

    <DataMember(Name:="name")>
    Public Property Name As String

    <DataMember(Name:="parentid")>
    Public Property ParentId As Decimal?

    <DataMember(Name:="url")>
    Public Property Url As String

    <DataMember(Name:="woeid")>
    Public Property Woeid As String

End Class
