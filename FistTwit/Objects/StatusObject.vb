Imports System.Runtime.Serialization
Imports System.Globalization

<DataContract>
Public Class StatusObject

    Public ReadOnly Property CreatedAt As DateTime
        Get
            Return DatetimeParser.Parse(cat)
        End Get
    End Property


    ''' <summary>
    ''' Gets date of created tweet
    ''' </summary>
    <DataMember(Name:="created_at")>
    Private Property cat As String

    ''' <summary>
    ''' if it is favorited, it will returns true.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(name:="favorited")>
    Public Property IsFavorited As Boolean

    ''' <summary>
    ''' Gets count of favorited in this tweet.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="favorited_count")>
    Public Property FavoritedCount As Decimal?

    ''' <summary>
    ''' Gets status id.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="id")>
    Public Property Id As Long

    ''' <summary>
    ''' Gets a screen name of reply-to.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="in_reply_to_screen_name")>
    Public Property InReplyToScreenName As String

    ''' <summary>
    ''' Gets user id of reply-to.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="in_reply_to_user_id")>
    Public Property InReplyToUserId As Decimal?

    ''' <summary>
    ''' Gets count of retweeted.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="retweet_count")>
    Public Property RetweetCount As Decimal?

    ''' <summary>
    ''' if you retweeted it, it will returns true.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="retweeted")>
    Public Property IsRetweeted As Boolean

    ''' <summary>
    ''' if it is retweeted tweet, it will returns the original tweet.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="retweeted_status")>
    Public Property RetweetedStatus As StatusObject

    ''' <summary>
    ''' Gets the source of this tweet.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="source")>
    Public Property Source As String

    ''' <summary>
    ''' Gets text of this tweet.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="text")>
    Public Property Text As String

    ''' <summary>
    ''' Gets UserObject of author of this tweet.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="user")>
    Public Property User As UserObject

    ''' <summary>
    ''' Get Entities
    ''' </summary>
    <DataMember(Name:="entities")>
    Public Property Entities As EntitiesObject

    ''' <summary>
    ''' Current user rt
    ''' </summary>
    <DataMember(Name:="current_user_retweet")>
    Public Property CurrentUserRetweet As StatusObject
End Class

Public Class StatusObjectList
    Inherits List(Of StatusObject)

    <DataMember(Name:="previous_cursor")>
    Public Property PreviousCursor As Decimal?

    <DataMember(Name:="next_cursor")>
    Public Property NextCursor As Decimal?
End Class
