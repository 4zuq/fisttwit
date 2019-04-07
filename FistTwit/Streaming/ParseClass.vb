Imports System.Runtime.Serialization
Imports System.Globalization

<DataContract>
Friend Class ParseClass

    ''' <summary>
    ''' DeleteObj
    ''' </summary>
    <DataMember(Name:="delete")>
    Friend Property Delete As StreamObjects.DeletedStatusObject

    ''' <summary>
    ''' ScrubGeo
    ''' </summary>
    <DataMember(Name:="scrub_geo")>
    Friend Property ScrubGeo As StreamObjects.ScrubGeoObject

    ''' <summary>
    ''' Limit
    ''' </summary>
    <DataMember(Name:="limit")>
    Friend Property Limit As StreamObjects.LimitObject

    ''' <summary>
    ''' StatusWithHeld
    ''' </summary>
    <DataMember(Name:="status_withheld")>
    Friend Property StatusWithheld As StreamObjects.StatusWithheldObject

    ''' <summary>
    ''' UserWithHeld
    ''' </summary>
    <DataMember(Name:="user_withheld")>
    Friend Property UserWithHeld As StreamObjects.UserWithheldObject

    ''' <summary>
    ''' Disconnect
    ''' </summary>
    <DataMember(Name:="disconnect")>
    Friend Property Disconnect As StreamObjects.DisconnectObject

    ''' <summary>
    ''' Warning
    ''' </summary>
    <DataMember(Name:="warning")>
    Friend Property Warning As StreamObjects.WarningObject

    ''' <summary>
    ''' Friends
    ''' </summary>
    <DataMember(Name:="friends")>
    Friend Property Friends As Decimal()

    ''' <summary>
    ''' Event
    ''' </summary>
    <DataMember(Name:="event")>
    Friend Property Events As String

    ''' <summary>
    ''' DMObj
    ''' </summary>
    <DataMember(Name:="sender")>
    Friend Property Sender As UserObject

    ''' <summary>
    ''' Statusobj
    ''' </summary>
    <DataMember(Name:="text")>
    Friend Property Text As String

    ''' <summary>
    ''' UserObj
    ''' </summary>
    <DataMember(Name:="description")>
    Friend Property Description As String

End Class
