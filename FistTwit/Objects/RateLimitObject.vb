Imports System.Runtime.Serialization

<DataContract>
Public Class RateLimitObject

    <DataMember(Name:="remaining")>
    Public Property Remaining As Decimal?

    <DataMember(Name:="reset")>
    Private Property rst As String

    Public Function Reset() As DateTime
        Return New DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(rst).ToLocalTime
    End Function

    <DataMember(Name:="limit")>
    Public Property Limit As Decimal?
End Class

<DataContract>
Public Class RateLimitObjectList

    <DataMember(Name:="resources")>
    Public Property Resources As RateLimitObjectKinds
End Class

<DataContract>
Public Class RateLimitObjectKinds

    <DataMember(Name:="account")>
    Public Property Account As RateLimitObjects.Account

    <DataMember(Name:="lists")>
    Public Property Lists As RateLimitObjects.Lists

    <DataMember(Name:="application")>
    Public Property Application As RateLimitObjects.Application

    <DataMember(Name:="friendships")>
    Public Property FriendShips As RateLimitObjects.FriendShips

    <DataMember(Name:="blocks")>
    Public Property Blocks As RateLimitObjects.Blocks

    <DataMember(Name:="geo")>
    Public Property Geo As RateLimitObjects.Geo

    <DataMember(Name:="users")>
    Public Property Users As RateLimitObjects.Users

    <DataMember(Name:="followers")>
    Public Property Followers As RateLimitObjects.Followers

    <DataMember(Name:="statuses")>
    Public Property Statuses As RateLimitObjects.Statuses

    <DataMember(Name:="help")>
    Public Property Help As RateLimitObjects.Help

    <DataMember(Name:="friends")>
    Public Property Friends As RateLimitObjects.Friends

    <DataMember(Name:="direct_messages")>
    Public Property DirectMessages As RateLimitObjects.DirectMessages

    <DataMember(Name:="favorites")>
    Public Property Favorites As RateLimitObjects.Favorites

    <DataMember(Name:="saved_searches")>
    Public Property SavedSearches As RateLimitObjects.SavedSearches

    <DataMember(Name:="search")>
    Public Property Search As RateLimitObjects.Search

    <DataMember(Name:="trends")>
    Public Property Trends As RateLimitObjects.Trends
End Class


Namespace RateLimitObjects

    <DataContract>
    Public Class Account

        <DataMember(Name:="/account/settings")>
        Public Property Settings As RateLimitObject

        <DataMember(Name:="/account/verify_credentials")>
        Public Property VerifyCredentials As RateLimitObject
    End Class

    <DataContract>
    Public Class Lists

        <DataMember(Name:="/lists/subscribers")>
        Public Property Subscribers As RateLimitObject

        <DataMember(Name:="/lists/list")>
        Public Property List As RateLimitObject

        <DataMember(Name:="/lists/memberships")>
        Public Property Memberships As RateLimitObject

        <DataMember(Name:="/lists/ownerships")>
        Public Property Ownerships As RateLimitObject

        <DataMember(Name:="/lists/subscriptions")>
        Public Property Subscriptions As RateLimitObject

        <DataMember(Name:="/lists/members")>
        Public Property Members As RateLimitObject

        <DataMember(Name:="/lists/subscribers/show")>
        Public Property SubscribersShow As RateLimitObject

        <DataMember(Name:="/lists/statuses")>
        Public Property Statuses As RateLimitObject

        <DataMember(Name:="/lists/members/show")>
        Public Property MembersShow As RateLimitObject

        <DataMember(Name:="/lists/show")>
        Public Property Show As RateLimitObject
    End Class

    <DataContract>
    Public Class Application

        <DataMember(Name:="/application/rate_limit_status")>
        Public Property RateLimitStatus As RateLimitObject
    End Class

    <DataContract>
    Public Class FriendShips

        <DataMember(Name:="/friendships/incoming")>
        Public Property Incoming As RateLimitObject

        <DataMember(Name:="/friendships/lookup")>
        Public Property Lookup As RateLimitObject

        <DataMember(Name:="/friendships/outgoing")>
        Public Property Outgoing As RateLimitObject

        <DataMember(Name:="/friendships/no_retweets/ids")>
        Public Property NoRetweetsIds As RateLimitObject

        <DataMember(Name:="/friendships/show")>
        Public Property Show As RateLimitObject
    End Class

    <DataContract>
    Public Class Blocks

        <DataMember(Name:="/blocks/ids")>
        Public Property Ids As RateLimitObject

        <DataMember(Name:="/blocks/list")>
        Public Property List As RateLimitObject
    End Class

    <DataContract>
    Public Class Geo

        <DataMember(Name:="/geo/similar_places")>
        Public Property SimilarPlaces As RateLimitObject

        <DataMember(Name:="/geo/search")>
        Public Property Search As RateLimitObject

        <DataMember(Name:="/geo/reverse_geocode")>
        Public Property ReverseGeocode As RateLimitObject

        <DataMember(Name:="/geo/id/:place_id")>
        Public Property IdPlaceId As RateLimitObject
    End Class

    <DataContract>
    Public Class Users

        <DataMember(Name:="/users/profile_banner")>
        Public Property ProfileBanner As RateLimitObject

        <DataMember(Name:="/users/suggestions/:slug/members")>
        Public Property SuggestionsSlugMembers As RateLimitObject

        <DataMember(Name:="/users/show/:id")>
        Public Property ShowId As RateLimitObject

        <DataMember(Name:="/users/suggestions")>
        Public Property Suggestions As RateLimitObject

        <DataMember(Name:="/users/lookup")>
        Public Property Lookup As RateLimitObject

        <DataMember(Name:="/users/search")>
        Public Property Search As RateLimitObject

        <DataMember(Name:="/users/contributors")>
        Public Property Contributors As RateLimitObject

        <DataMember(Name:="/users/contributees")>
        Public Property Contributees As RateLimitObject

        <DataMember(Name:="/users/suggestions/:slug")>
        Public Property SuggestionsSlug As RateLimitObject
    End Class

    <DataContract>
    Public Class Followers

        <DataMember(Name:="/followers/list")>
        Public Property List As RateLimitObject

        <DataMember(Name:="/followers/ids")>
        Public Property Ids As RateLimitObject
    End Class

    <DataContract>
    Public Class Statuses

        <DataMember(Name:="/statuses/mentions_timeline")>
        Public Property MentionsTimeline As RateLimitObject

        <DataMember(Name:="/statuses/show/:id")>
        Public Property ShowId As RateLimitObject

        <DataMember(Name:="/statuses/oembed")>
        Public Property Oembed As RateLimitObject

        <DataMember(Name:="/statuses/retweeters/ids")>
        Public Property RetweetersIds As RateLimitObject

        <DataMember(Name:="/statuses/home_timeline")>
        Public Property HomeTimeline As RateLimitObject

        <DataMember(Name:="/statuses/user_timeline")>
        Public Property UserTimeline As RateLimitObject

        <DataMember(Name:="/statuses/retweets/:id")>
        Public Property RetweetsIds As RateLimitObject

        <DataMember(Name:="/statuses/retweets_of_me")>
        Public Property RetweetsOfMe As RateLimitObject
    End Class

    <DataContract>
    Public Class Help

        <DataMember(Name:="/help/privacy")>
        Public Property Privacy As RateLimitObject

        <DataMember(Name:="/help/tos")>
        Public Property Tos As RateLimitObject

        <DataMember(Name:="/help/configuration")>
        Public Property Configuration As RateLimitObject

        <DataMember(Name:="/help/languages")>
        Public Property Languages As RateLimitObject
    End Class

    <DataContract>
    Public Class Friends

        <DataMember(Name:="/friends/ids")>
        Public Property Ids As RateLimitObject

        <DataMember(Name:="friends/list")>
        Public Property List As RateLimitObject
    End Class

    <DataContract>
    Public Class DirectMessages

        <DataMember(Name:="/direct_messages/show")>
        Public Property Show As RateLimitObject

        <DataMember(Name:="/direct_messages/sent_and_received")>
        Public Property SentAndReceived As RateLimitObject

        <DataMember(Name:="/direct_messages/sent")>
        Public Property Sent As RateLimitObject

        <DataMember(Name:="/direct_messages")>
        Public Property DirectMessages As RateLimitObject
    End Class

    <DataContract>
    Public Class Favorites

        <DataMember(Name:="/favorites/list")>
        Public Property List As RateLimitObject
    End Class

    <DataContract>
    Public Class SavedSearches

        <DataMember(Name:="/saved_searches/destroy/:id")>
        Public Property DestroyId As RateLimitObject

        <DataMember(Name:="/saved_searches/list")>
        Public Property List As RateLimitObject

        <DataMember(Name:="/saved_searches/show/:id")>
        Public Property ShowId As RateLimitObject
    End Class

    <DataContract>
    Public Class Search

        <DataMember(Name:="/search/tweets")>
        Public Property Tweets As RateLimitObject
    End Class

    <DataContract>
    Public Class Trends

        <DataMember(Name:="/trends/available")>
        Public Property Available As RateLimitObject

        <DataMember(Name:="/trends/place")>
        Public Property Place As RateLimitObject

        <DataMember(Name:="/trends/closest")>
        Public Property Closest As RateLimitObject
    End Class
End Namespace
