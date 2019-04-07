Imports System.Runtime.Serialization
Imports System.Globalization
Imports System.Runtime.Serialization.Json
Imports System.IO
Imports System.Text

Namespace StreamObjects

    <DataContract>
    Public Class IdObj

        <DataMember(Name:="id")>
        Public Property Id As Decimal?

        <DataMember(Name:="user_id")>
        Public Property UserId As Decimal?
    End Class

    <DataContract>
    Public Class DeletedStatusObject

        <DataMember(Name:="status")>
        Public Property Status As IdObj

    End Class

    <DataContract>
    Public Class ScrubGeoObject

        <DataMember(Name:="user_id")>
        Public Property UserId As Decimal?

        <DataMember(Name:="up_to_status_id")>
        Public Property UpToStatusId As Long?
    End Class

    <DataContract>
    Public Class LimitObject

        <DataMember(Name:="track")>
        Public Property Track As Decimal?
    End Class

    <DataContract>
    Public Class StatusWithheldObject

        <DataMember(Name:="id")>
        Public Property Id As Decimal?

        <DataMember(Name:="user_id")>
        Public Property UserId As Decimal?

        <DataMember(Name:="withheld_in_countries")>
        Public Property WithheldInCountries As String()
    End Class

    <DataContract>
    Public Class UserWithheldObject

        <DataMember(Name:="id")>
        Public Property Id As Decimal?

        <DataMember(Name:="withheld_in_countries")>
        Public Property WithheldInCountries As String()
    End Class

    <DataContract>
    Public Class DisconnectObject

        <DataMember(Name:="code")>
        Public Property Code As Decimal?

        <DataMember(Name:="stream_name")>
        Public Property StreamName As String

        <DataMember(Name:="reason")>
        Public Property Reason As String
    End Class

    <DataContract>
    Public Class WarningObject

        <DataMember(Name:="code")>
        Public Property Code As Decimal?

        <DataMember(Name:="message")>
        Public Property Message As String

        <DataMember(Name:="percent_full")>
        Public Property PercentFull As Decimal?
    End Class

    <DataContract>
    Public Class FriendsIdObject

        <DataMember(Name:="friends")>
        Public Property Friends As Decimal()
    End Class

    <DataContract>
    Public Class EventsObject(Of T)

        Public Function CreatedAt() As DateTime
            Const Format As String = "ddd MMM dd HH:mm:ss zzzz yyyy"
            Return DateTime.ParseExact(cat, Format, CultureInfo.InvariantCulture)
        End Function

        <DataMember(Name:="target")>
        Public Property Target As UserObject

        <DataMember(Name:="source")>
        Public Property Source As UserObject

        <DataMember(Name:="created_at")>
        Private Property cat As String

        <DataMember(Name:="event")>
        Public Property Events As String

        <DataMember(Name:="target_object")>
        Public Property TargetObject As T

    End Class
End Namespace