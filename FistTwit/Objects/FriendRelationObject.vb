Imports System.Runtime.Serialization

<DataContract>
Public Class FriendRelationObject

    <DataMember(Name:="relationship")>
    Public Property RelationShip As String

End Class

<DataContract>
Public Class FriendRelation

    <DataMember(Name:="target")>
    Public Property Target As RelationTarget

    <DataMember(Name:="source")>
    Public Property Source As RelationSource
End Class

<DataContract>
Public Class RelationTarget

    ''' <summary>
    ''' Id
    ''' </summary>
    <DataMember(Name:="id")>
    Public Property Id As Decimal

    ''' <summary>
    ''' if you followed by this user, will return true
    ''' </summary>
    <DataMember(Name:="followed_by")>
    Public Property IsFollowedBy As Boolean

    ''' <summary>
    ''' if you following this user, will return true
    ''' </summary>
    <DataMember(Name:="following")>
    Public Property IsFollowing As Boolean

    ''' <summary>
    ''' ScreenName
    ''' </summary>
    <DataMember(Name:="screen_name")>
    Public Property ScreenName As String

End Class

<DataContract>
Public Class RelationSource

    ''' <summary>
    ''' Id
    ''' </summary>
    <DataMember(Name:="id")>
    Public Property Id As Decimal

    ''' <summary>
    ''' if you followed by this user, will return true
    ''' </summary>
    <DataMember(Name:="followed_by")>
    Public Property IsFollowedBy As Boolean

    ''' <summary>
    ''' if you following this user, will return true
    ''' </summary>
    <DataMember(Name:="following")>
    Public Property IsFollowing As Boolean

    ''' <summary>
    ''' ScreenName
    ''' </summary>
    <DataMember(Name:="screen_name")>
    Public Property ScreenName As String

    <DataMember(Name:="can_dm")>
    Public Property IsCanDm As Boolean?

    <DataMember(Name:="blocking")>
    Public Property IsBlocking As Boolean?

    <DataMember(Name:="all_replies")>
    Public Property IsAllReplies As Boolean?

    <DataMember(Name:="want_retweets")>
    Public Property IsWantRetweets As Boolean?

    <DataMember(Name:="marked_spam")>
    Public Property IsMarkedSpam As Boolean?

    <DataMember(Name:="notifications_enabled")>
    Public Property IsNotificationsEnabled As Boolean?
End Class