Imports System.Runtime.Serialization

<DataContract>
Public Class DMObject

    Public ReadOnly Property CreatedAt As DateTime
        Get
            Return DatetimeParser.Parse(cat)
        End Get
    End Property

    <DataMember(Name:="created_at")>
    Private Property cat As String

    ''' <summary>
    ''' Gets id.
    ''' </summary>
    <DataMember(Name:="id")>
    Public Property Id As Decimal

    ''' <summary>
    ''' Gets UserObject of recipient.
    ''' </summary>
    <DataMember(Name:="recipient")>
    Public Property Recipient As UserObject

    ''' <summary>
    ''' Gets UserObject of sender.
    ''' </summary>
    <DataMember(Name:="sender")>
    Public Property Sender As UserObject

    ''' <summary>
    ''' Gets the text of dm.
    ''' </summary>
    <DataMember(Name:="text")>
    Public Property Text As String

    ''' <summary>
    ''' Get Entities
    ''' </summary>
    <DataMember(Name:="entities")>
    Public Property Entities As EntitiesObject
End Class

Public Class DMObjectList
    Inherits List(Of DMObject)
End Class
