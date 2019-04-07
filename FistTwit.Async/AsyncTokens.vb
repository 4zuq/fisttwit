Public Class AsyncTokens

    Public Sub New(ByVal t As OauthTokens)
        Account = New Account(t)
        Blocks = New Blocks(t)
        DirectMessages = New DirectMessages(t)
        Favorites = New Favorites(t)
        FriendShips = New FriendShips(t)
        Geo = New Geo(t)
        Help = New Help(t)
        Lists = New Lists(t)
        SavedSearches = New SavedSearches(t)
        Search = New Search(t)
        Statuses = New Statuses(t)
        Timeline = New Timeline(t)
        Trends = New Trends(t)
        Users = New Users(t)
    End Sub

    Public ReadOnly Account As Account

    Public ReadOnly Blocks As Blocks

    Public ReadOnly DirectMessages As DirectMessages

    Public ReadOnly Favorites As Favorites

    Public ReadOnly FriendShips As FriendShips

    Public ReadOnly Geo As Geo

    Public ReadOnly Help As Help

    Public ReadOnly Lists As Lists

    Public ReadOnly SavedSearches As SavedSearches

    Public ReadOnly Search As Search

    Public ReadOnly Statuses As Statuses

    Public ReadOnly Timeline As Timeline

    Public ReadOnly Trends As Trends

    Public ReadOnly Users As Users
End Class
