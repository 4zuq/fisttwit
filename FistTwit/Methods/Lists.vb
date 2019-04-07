Imports System.Text

Public Class Lists
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Return the UserListObjectList of selected
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function List(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of ListObjectList)
        Return New ResponseObject(Of ListObjectList)(TwitterAccess.GETAccess(EndPoints.Lists_List, token, parameter))
    End Function

    ''' <summary>
    ''' Get statuses of selected list 
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Statuses(ByVal parameter As RequestParam) As ResponseObject(Of StatusObjectList)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of StatusObjectList)(TwitterAccess.GETAccess(EndPoints.Lists_Statuses, token, parameter))
    End Function

    ''' <summary>
    ''' Delete selected member of the list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function MembersDestroy(ByVal parameter As RequestParam) As ResponseObject(Of String)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of String)(TwitterAccess.POSTAccess(EndPoints.Lists_Members_Destroy, token, parameter))
    End Function

    ''' <summary>
    ''' Show the Memberships of the user
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Memberships(ByVal parameter As RequestParam) As ResponseObject(Of ListObjectWithCursorList)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of ListObjectWithCursorList)(TwitterAccess.GETAccess(EndPoints.Lists_Memberships, token, parameter))
    End Function

    ''' <summary>
    ''' Show the Ownerships of the user
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function OwnerShips(ByVal parameter As RequestParam) As ResponseObject(Of ListObjectWithCursorList)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of ListObjectWithCursorList)(TwitterAccess.GETAccess(EndPoints.Lists_Ownerships, token, parameter))
    End Function

    ''' <summary>
    ''' Get subscribers
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Subscribers(ByVal parameter As RequestParam) As ResponseObject(Of UserObjectListWithCursor)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of UserObjectListWithCursor)(TwitterAccess.GETAccess(EndPoints.Lists_Subscribers, token, parameter))
    End Function

    ''' <summary>
    ''' Make a subscriber
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function SubscribersCreate(ByVal parameter As RequestParam) As ResponseObject(Of ListObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of ListObject)(TwitterAccess.POSTAccess(EndPoints.Lists_Subscribers_Create, token, parameter))
    End Function

    ''' <summary>
    ''' If the user is subscriber, will return userobject
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function SubscribersShow(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of UserObject)(TwitterAccess.GETAccess(EndPoints.Lists_Subscribers_Show, token, parameter))
    End Function

    ''' <summary>
    ''' Unread the list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function SubscribersDestroy(ByVal parameter As RequestParam) As ResponseObject(Of ListObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of ListObject)(TwitterAccess.POSTAccess(EndPoints.Lists_Subscribers_Destroy, token, parameter))
    End Function

    ''' <summary>
    ''' Add members to the selected list
    ''' </summary>
    ''' <param name="ScreenNames">ScreenNames</param>
    ''' <param name="parameter">Parameters</param>
    Public Function MembersCreateAll(ByVal ScreenNames As String(), ByVal parameter As RequestParam) As ResponseObject(Of ListObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        If Not parameter.ContainsKey("screen_name") Then
            If Not IsNothing(ScreenNames) Then
                Throw New ArgumentException("ScreenNames")
            Else
                Dim sb As New StringBuilder()
                For Each v As String In ScreenNames
                    If String.IsNullOrEmpty(sb.ToString) Then
                        sb.Append(v)
                    Else
                        sb.Append("," & v)
                    End If
                Next
                parameter("screen_name") = sb.ToString
            End If
        End If
        Return New ResponseObject(Of ListObject)(TwitterAccess.POSTAccess(EndPoints.Lists_Members_Create_All, token, parameter))
    End Function

    ''' <summary>
    ''' Add members to the selected list
    ''' </summary>
    ''' <param name="Ids">Ids</param>
    ''' <param name="parameter">Parameters</param>
    Public Function MembersCreateAll(ByVal Ids As Decimal(), ByVal parameter As RequestParam) As ResponseObject(Of ListObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        If Not parameter.ContainsKey("user_id") Then
            If IsNothing(Ids) Then
                Throw New ArgumentException("Ids")
            Else
                Dim sb As New StringBuilder()
                For Each v As Decimal In Ids
                    If String.IsNullOrEmpty(sb.ToString) Then
                        sb.Append(v.ToString)
                    Else
                        sb.Append("," & v.ToString)
                    End If
                Next
                parameter("user_id") = sb.ToString
            End If
        End If
        Return New ResponseObject(Of ListObject)(TwitterAccess.POSTAccess(EndPoints.Lists_Members_Create_All, token, parameter))
    End Function

    ''' <summary>
    ''' Destroy members from the selected list
    ''' </summary>
    ''' <param name="ScreenNames">ScreenNames</param>
    ''' <param name="parameter">Parameters</param>
    Public Function MembersDestroyAll(ByVal ScreenNames As String(), ByVal parameter As RequestParam) As ResponseObject(Of ListObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        If Not parameter.ContainsKey("screen_name") Then
            If Not IsNothing(ScreenNames) Then
                Throw New ArgumentException("ScreenNames")
            Else
                Dim sb As New StringBuilder()
                For Each v As String In ScreenNames
                    If String.IsNullOrEmpty(sb.ToString) Then
                        sb.Append(v)
                    Else
                        sb.Append("," & v)
                    End If
                Next
                parameter("screen_name") = sb.ToString
            End If
        End If
        Return New ResponseObject(Of ListObject)(TwitterAccess.POSTAccess(EndPoints.Lists_Members_Destroy_All, token, parameter))
    End Function

    ''' <summary>
    ''' Destroy members from the selected list
    ''' </summary>
    ''' <param name="Ids">Ids</param>
    ''' <param name="parameter">Parameters</param>
    Public Function MembersDestroyAll(ByVal Ids As Decimal(), ByVal parameter As RequestParam) As ResponseObject(Of ListObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        If Not parameter.ContainsKey("user_id") Then
            If IsNothing(Ids) Then
                Throw New ArgumentException("Ids")
            Else
                Dim sb As New StringBuilder()
                For Each v As Decimal In Ids
                    If String.IsNullOrEmpty(sb.ToString) Then
                        sb.Append(v.ToString)
                    Else
                        sb.Append("," & v.ToString)
                    End If
                Next
                parameter("user_id") = sb.ToString
            End If
        End If
        Return New ResponseObject(Of ListObject)(TwitterAccess.POSTAccess(EndPoints.Lists_Members_Destroy_All, token, parameter))
    End Function

    ''' <summary>
    ''' Destroy members from the selected list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function MembersDestroyAll(ByVal parameter As RequestParam) As ResponseObject(Of ListObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of ListObject)(TwitterAccess.POSTAccess(EndPoints.Lists_Members_Destroy_All, token, parameter))
    End Function

    ''' <summary>
    ''' Add members to the selected list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function MembersCreateAll(ByVal parameter As RequestParam) As ResponseObject(Of ListObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of ListObject)(TwitterAccess.POSTAccess(EndPoints.Lists_Members_Create_All, token, parameter))
    End Function

    ''' <summary>
    ''' If selected user is a member of the list, will return UserObject
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function MembersShow(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of UserObject)(TwitterAccess.GETAccess(EndPoints.Lists_Members_Show, token, parameter))
    End Function

    ''' <summary>
    ''' Get members of the list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Members(ByVal parameter As RequestParam) As ResponseObject(Of UserObjectListWithCursor)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of UserObjectListWithCursor)(TwitterAccess.GETAccess(EndPoints.Lists_Members, token, parameter))
    End Function

    ''' <summary>
    ''' Add a member to the list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function MembersCreate(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of UserObject)(TwitterAccess.POSTAccess(EndPoints.Lists_Members_Create, token, parameter))
    End Function

    ''' <summary>
    ''' Destroy the selected list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Destroy(ByVal parameter As RequestParam) As ResponseObject(Of ListObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of ListObject)(TwitterAccess.POSTAccess(EndPoints.Lists_Destroy, token, parameter))
    End Function

    ''' <summary>
    ''' Update the selected list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Update(ByVal parameter As RequestParam) As ResponseObject(Of ListObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of ListObject)(TwitterAccess.POSTAccess(EndPoints.Lists_Update, token, parameter))
    End Function

    ''' <summary>
    ''' Create the new list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Create(ByVal parameter As RequestParam) As ResponseObject(Of ListObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of ListObject)(TwitterAccess.POSTAccess(EndPoints.Lists_Create, token, parameter))
    End Function

    ''' <summary>
    ''' Show the selected list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Show(ByVal parameter As RequestParam) As ResponseObject(Of ListObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of ListObject)(TwitterAccess.GETAccess(EndPoints.Lists_Show, token, parameter))
    End Function

    ''' <summary>
    ''' Show the subscriptions that is reading
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Subscriptions(ByVal parameter As RequestParam) As ResponseObject(Of ListObjectWithCursorList)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of ListObjectWithCursorList)(TwitterAccess.GETAccess(EndPoints.Lists_Subscriptions, token, parameter))
    End Function
End Class