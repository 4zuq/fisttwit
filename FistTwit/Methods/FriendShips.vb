Imports System.Text

Public Class FriendShips
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get Noretweets_ids
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function NoRetweets(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of List(Of Decimal))
        Return New ResponseObject(Of List(Of Decimal))(TwitterAccess.GETAccess(EndPoints.FriendShips_NoRetweets_Ids, token, parameter))
    End Function

    ''' <summary>
    ''' Get the friend list of ids.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function FriendsIds(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of UserIdsList)
        Return New ResponseObject(Of UserIdsList)(TwitterAccess.GETAccess(EndPoints.Friends_Ids, token, parameter))
    End Function

    ''' <summary>
    ''' Get the friend list of userobject.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function FriendsList(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of UserObjectListWithCursor)
        Return New ResponseObject(Of UserObjectListWithCursor)(TwitterAccess.GETAccess(EndPoints.Friend_List, token, parameter))
    End Function

    ''' <summary>
    ''' Get the followers list of ids.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function FollowersIds(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of UserIdsList)
        Return New ResponseObject(Of UserIdsList)(TwitterAccess.GETAccess(EndPoints.Followers_Ids, token, parameter))
    End Function

    ''' <summary>
    ''' Get the friend list of userobject.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function FollowersList(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of UserObjectListWithCursor)
        Return New ResponseObject(Of UserObjectListWithCursor)(TwitterAccess.GETAccess(EndPoints.Followers_Ids, token, parameter))
    End Function

    Private Function Lookup(ByVal parameter As RequestParam) As ResponseObject(Of FriendsLookupObjectList)
        Return New ResponseObject(Of FriendsLookupObjectList)(TwitterAccess.GETAccess(EndPoints.FriendShips_Lookup, token, parameter))
    End Function

    ''' <summary>
    ''' Lookup users.
    ''' </summary>
    ''' <param name="ScreenNames">ScreenNames</param>
    Public Function Lookup(ByVal ScreenNames As String()) As ResponseObject(Of FriendsLookupObjectList)
        If IsNothing(ScreenNames) Then
            Throw New ArgumentException("ScreenNames")
        End If
        Dim dic As New RequestParam
        Dim sb As New StringBuilder
        For Each v As String In ScreenNames
            If String.IsNullOrEmpty(sb.ToString) Then
                sb.Append(v)
            Else
                sb.Append("," & v)
            End If
        Next
        dic.Add("screen_name", TwitterAccess.UrlEncode(sb.ToString))
        Return Lookup(dic)
    End Function

    ''' <summary>
    ''' Lookup users.
    ''' </summary>
    ''' <param name="Ids">Ids</param>
    Public Function Lookup(ByVal Ids As Decimal()) As ResponseObject(Of FriendsLookupObjectList)
        If IsNothing(Ids) Then
            Throw New ArgumentException("IDs")
        End If
        Dim dic As New RequestParam
        Dim sb As New StringBuilder
        For Each v As Decimal In Ids
            If String.IsNullOrEmpty(sb.ToString) Then
                sb.Append(v.ToString)
            Else
                sb.Append("," & v.ToString)
            End If
        Next
        dic.Add("user_id", TwitterAccess.UrlEncode(sb.ToString))
        Return Lookup(dic)
    End Function

    ''' <summary>
    ''' Get IDs for every user who has a pending request to follow the authenticating user.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Incoming(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of UserIdsList)
        Return New ResponseObject(Of UserIdsList)(TwitterAccess.GETAccess(EndPoints.FriendShips_Incoming, token, parameter))
    End Function

    ''' <summary>
    ''' Get IDs for every protected user for whom the authenticating user has a pending follow request.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Outgoing(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of UserIdsList)
        Return New ResponseObject(Of UserIdsList)(TwitterAccess.GETAccess(EndPoints.FriendShips_Outgoing, token, parameter))
    End Function

    ''' <summary>
    ''' Follow the user.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Create(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of UserObject)(TwitterAccess.POSTAccess(EndPoints.FriendShips_Create, token, parameter))
    End Function

    ''' <summary>
    ''' Unfollow the user
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Destroy(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of UserObject)(TwitterAccess.POSTAccess(EndPoints.FriendShips_Destroy, token, parameter))
    End Function

    ''' <summary>
    ''' Update
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Update(ByVal parameter As RequestParam) As ResponseObject(Of FriendRelationObject)
        Return New ResponseObject(Of FriendRelationObject)(TwitterAccess.POSTAccess(EndPoints.FriendShips_Update, token, parameter))
    End Function

    ''' <summary>
    ''' Show
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Show(ByVal parameter As RequestParam) As ResponseObject(Of FriendRelationObject)
        Return New ResponseObject(Of FriendRelationObject)(TwitterAccess.GETAccess(EndPoints.FriendShips_Show, token, parameter))
    End Function
End Class