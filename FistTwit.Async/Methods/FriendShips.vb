Public Class FriendShips
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get Noretweets_ids
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function NoRetweets(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of List(Of Decimal)))
        Return Await Task.Run(Function() token.FriendShips.NoRetweets(parameter))
    End Function

    ''' <summary>
    ''' Get the friend list of ids.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function FriendsIds(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of UserIdsList))
        Return Await Task.Run(Function() token.FriendShips.FriendsIds(parameter))
    End Function

    ''' <summary>
    ''' Get the friend list of userobject.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function FriendsList(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of UserObjectListWithCursor))
        Return Await Task.Run(Function() token.FriendShips.FriendsList(parameter))
    End Function

    ''' <summary>
    ''' Get the followers list of ids.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function FollowersIds(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of UserIdsList))
        Return Await Task.Run(Function() token.FriendShips.FollowersIds(parameter))
    End Function

    ''' <summary>
    ''' Get the friend list of userobject.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function FollowersList(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of UserObjectListWithCursor))
        Return Await Task.Run(Function() token.FriendShips.FollowersList(parameter))
    End Function

    ''' <summary>
    ''' Lookup users.
    ''' </summary>
    ''' <param name="ScreenNames">ScreenNames</param>
    Public Async Function Lookup(ByVal ScreenNames As String()) As Task(Of ResponseObject(Of FriendsLookupObjectList))
        Return Await Task.Run(Function() token.FriendShips.Lookup(ScreenNames))
    End Function

    ''' <summary>
    ''' Lookup users.
    ''' </summary>
    ''' <param name="Ids">Ids</param>
    Public Async Function Lookup(ByVal Ids As Decimal()) As Task(Of ResponseObject(Of FriendsLookupObjectList))
        Return Await Task.Run(Function() token.FriendShips.Lookup(Ids))
    End Function

    ''' <summary>
    ''' Get IDs for every user who has a pending request to follow the authenticating user.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Incoming(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of UserIdsList))
        Return Await Task.Run(Function() token.FriendShips.Incoming(parameter))
    End Function

    ''' <summary>
    ''' Get IDs for every protected user for whom the authenticating user has a pending follow request.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Outgoing(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of UserIdsList))
        Return Await Task.Run(Function() token.FriendShips.Outgoing(parameter))
    End Function

    ''' <summary>
    ''' Follow the user.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Create(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.FriendShips.Create(parameter))
    End Function

    ''' <summary>
    ''' Unfollow the user
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Destroy(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.FriendShips.Destroy(parameter))
    End Function

    ''' <summary>
    ''' Update
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Update(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of FriendRelationObject))
        Return Await Task.Run(Function() token.FriendShips.Update(parameter))
    End Function

    ''' <summary>
    ''' Show
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Show(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of FriendRelationObject))
        Return Await Task.Run(Function() token.FriendShips.Show(parameter))
    End Function
End Class
