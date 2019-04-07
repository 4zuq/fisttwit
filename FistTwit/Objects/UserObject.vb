Imports System.Runtime.Serialization
Imports System.Globalization

<DataContract>
Public Class UserObject

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
    ''' Gets description.
    ''' </summary>
    <DataMember(Name:="description")>
    Public Property Description As String

    ''' <summary>
    ''' Gets count of favorites of the user.
    ''' </summary>
    <DataMember(Name:="favourites_count")>
    Public Property FavoritesCount As Decimal?

    ''' <summary>
    ''' Gets of exist follow_request_sent.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="follow_request_sent")>
    Public Property IsFollowRequestSent As Boolean?

    ''' <summary>
    ''' Gets count of followers.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="followers_count")>
    Public Property FollowersCount As Decimal?

    ''' <summary>
    ''' if you followed the user, it will returns true.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="following")>
    Public Property IsFollowing As Boolean?

    ''' <summary>
    ''' Gets count of friends.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="friends_count")>
    Public Property FriendsCount As Decimal?

    ''' <summary>
    ''' Gets user id.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="id")>
    Public Property Id As Decimal

    ''' <summary>
    ''' Gets location.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="location")>
    Public Property Location As String

    ''' <summary>
    ''' Gets user name.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="name")>
    Public Property Name As String

    ''' <summary>
    ''' Gets a image of the user.(http's')
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="profile_image_url_https")>
    Public Property ProfileImageUrlHttps As String

    ''' <summary>
    ''' if the user is protected, it will returns true.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="protected")>
    Public Property IsProtected As Boolean

    ''' <summary>
    ''' Gets of screen name.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="screen_name")>
    Public Property ScreenName As String

    ''' <summary>
    ''' Gets count of all statuses.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="statuses_count")>
    Public Property StatusesCount As Decimal?

    ''' <summary>
    ''' Gets url if the user has a link.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(Name:="url")>
    Public Property Url As String

    ''' <summary>
    ''' if the user is listed, it will returns count of listed.
    ''' </summary>
    ''' <remarks></remarks>
    <DataMember(name:="listed_count")>
    Public Property ListedCount As Decimal?

    ''' <summary>
    ''' if the user is verified account, it will returns true.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <DataMember(Name:="verified")>
    Public Property IsVerified As Boolean

    ''' <summary>
    ''' StatusObject of latest tweet
    ''' </summary>
    <DataMember(Name:="status")>
    Public Property Status As StatusObject

    ''' <summary>
    ''' Get Entities
    ''' </summary>
    <DataMember(Name:="entities")>
    Public Property Entities As EntitiesObject
End Class

Public Class UserObjectList
    Inherits List(Of UserObject)
End Class

<DataContract>
Public Class UserObjectListWithCursor

    <DataMember(Name:="previous_cursor")>
    Public Property PreviousCursor As Decimal?

    <DataMember(Name:="next_cursor")>
    Public Property NextCursor As Decimal?

    <DataMember(Name:="users")>
    Public Property Users As List(Of UserObject)
End Class