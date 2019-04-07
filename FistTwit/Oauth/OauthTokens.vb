Imports System.IO

Public Class OauthTokens

    ''' <summary>
    ''' ConsumerKey
    ''' </summary>
    Public Property ConsumerKey As String

    ''' <summary>
    ''' ConsumerSecret
    ''' </summary>
    Public Property ConsumerSecret As String

    ''' <summary>
    ''' AccessToken
    ''' </summary>
    Public Property AccessToken As String

    ''' <summary>
    ''' AccessTokenSecret
    ''' </summary>
    Public Property AccessTokenSecret As String

    ''' <summary>
    ''' UserId
    ''' </summary>
    Public Property UserId As Decimal

    ''' <summary>
    ''' ScreenName
    ''' </summary>
    Public Property ScreenName As String

#Region "API Functions"
    ''' <summary>
    ''' Get account functions
    ''' </summary>
    Public ReadOnly Account As New Account(Me)

    ''' <summary>
    ''' Get blocks functions
    ''' </summary>
    Public ReadOnly Blocks As New Blocks(Me)

    ''' <summary>
    ''' Get directmessages functions
    ''' </summary>
    Public ReadOnly DirectMessages As New DirectMessages(Me)

    ''' <summary>
    ''' Get favorites functions
    ''' </summary>
    Public ReadOnly Favorites As New Favorites(Me)

    ''' <summary>
    ''' Get friendships functions
    ''' </summary>
    Public ReadOnly FriendShips As New FriendShips(Me)

    ''' <summary>
    ''' Get geo functions
    ''' </summary>
    Public ReadOnly Geo As New Geo(Me)

    ''' <summary>
    ''' Get help functions
    ''' </summary>
    Public ReadOnly Help As New Help(Me)

    ''' <summary>
    ''' Get lists functions
    ''' </summary>
    Public ReadOnly Lists As New Lists(Me)

    ''' <summary>
    ''' Get savedsearches functions
    ''' </summary>
    Public ReadOnly SavedSearches As New SavedSearches(Me)

    ''' <summary>
    ''' Get search functions
    ''' </summary>
    Public ReadOnly Search As New Search(Me)

    ''' <summary>
    ''' Get statuses functions
    ''' </summary>
    Public ReadOnly Statuses As New Statuses(Me)

    ''' <summary>
    ''' Get timeline functions
    ''' </summary>
    Public ReadOnly Timeline As New Timeline(Me)

    ''' <summary>
    ''' Get trends functions
    ''' </summary>
    Public ReadOnly Trends As New Trends(Me)

    ''' <summary>
    ''' Get users functions
    ''' </summary>
    Public ReadOnly Users As New Users(Me)
#End Region

    ''' <summary>
    ''' Get the request token with included consumerkey and secret
    ''' </summary>
    ''' <param name="callbackurl">callback url(if you won't put it, this will use oob mode.)</param>
    Public Function GetRequestToken(Optional ByVal callbackurl As String = Nothing) As OauthAccess
        If IsNothing(Me) Or _
String.IsNullOrEmpty(Me.ConsumerKey) Or _
String.IsNullOrEmpty(Me.ConsumerSecret) Then
            Throw New ArgumentException("Oauth")
        End If
        If String.IsNullOrEmpty(callbackurl) Then callbackurl = "oob"
        Dim dic As New RequestParam
        dic.Add("oauth_callback", callbackurl)
        Return New OauthAccess(New StreamReader(TwitterAccess.POSTAccess(EndPoints.Oauth_request_token, Me, dic).GetResponseStream).ReadToEnd, Me)
    End Function
End Class
