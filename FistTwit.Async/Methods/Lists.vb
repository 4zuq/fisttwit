Public Class Lists
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Return the UserListObjectList of selected
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function List(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of ListObjectList))
        Return Await Task.Run(Function() token.Lists.List(parameter))
    End Function

    ''' <summary>
    ''' Get statuses of selected list 
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Statuses(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of StatusObjectList))
        Return Await Task.Run(Function() token.Lists.Statuses(parameter))
    End Function

    ''' <summary>
    ''' Delete selected member of the list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function MembersDestroy(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of String))
        Return Await Task.Run(Function() token.Lists.MembersDestroy(parameter))
    End Function

    ''' <summary>
    ''' Show the Memberships of the user
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Memberships(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of ListObjectWithCursorList))
        Return Await Task.Run(Function() token.Lists.Memberships(parameter))
    End Function

    ''' <summary>
    ''' Show the Ownerships of the user
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function OwnerShips(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of ListObjectWithCursorList))
        Return Await Task.Run(Function() token.Lists.OwnerShips(parameter))
    End Function

    ''' <summary>
    ''' Get subscribers
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Subscribers(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObjectListWithCursor))
        Return Await Task.Run(Function() token.Lists.Subscribers(parameter))
    End Function

    ''' <summary>
    ''' Make a subscriber
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function SubscribersCreate(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of ListObject))
        Return Await Task.Run(Function() token.Lists.SubscribersCreate(parameter))
    End Function

    ''' <summary>
    ''' If the user is subscriber, will return userobject
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function SubscribersShow(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Lists.SubscribersShow(parameter))
    End Function

    ''' <summary>
    ''' Unread the list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function SubscribersDestroy(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of ListObject))
        Return Await Task.Run(Function() token.Lists.SubscribersDestroy(parameter))
    End Function

    ''' <summary>
    ''' Add members to the selected list
    ''' </summary>
    ''' <param name="ScreenNames">ScreenNames</param>
    ''' <param name="parameter">Parameters</param>
    Public Async Function MembersCreateAll(ByVal ScreenNames As String(), ByVal parameter As RequestParam) As Task(Of ResponseObject(Of ListObject))
        Return Await Task.Run(Function() token.Lists.MembersCreateAll(ScreenNames, parameter))
    End Function

    ''' <summary>
    ''' Add members to the selected list
    ''' </summary>
    ''' <param name="Ids">Ids</param>
    ''' <param name="parameter">Parameters</param>
    Public Async Function MembersCreateAll(ByVal Ids As Decimal(), ByVal parameter As RequestParam) As Task(Of ResponseObject(Of ListObject))
        Return Await Task.Run(Function() token.Lists.MembersCreateAll(Ids, parameter))
    End Function

    ''' <summary>
    ''' Destroy members from the selected list
    ''' </summary>
    ''' <param name="ScreenNames">ScreenNames</param>
    ''' <param name="parameter">Parameters</param>
    Public Async Function MembersDestroyAll(ByVal ScreenNames As String(), ByVal parameter As RequestParam) As Task(Of ResponseObject(Of ListObject))
        Return Await Task.Run(Function() token.Lists.MembersDestroyAll(ScreenNames, parameter))
    End Function

    ''' <summary>
    ''' Destroy members from the selected list
    ''' </summary>
    ''' <param name="Ids">Ids</param>
    ''' <param name="parameter">Parameters</param>
    Public Async Function MembersDestroyAll(ByVal Ids As Decimal(), ByVal parameter As RequestParam) As Task(Of ResponseObject(Of ListObject))
        Return Await Task.Run(Function() token.Lists.MembersDestroyAll(Ids, parameter))
    End Function

    ''' <summary>
    ''' If selected user is a member of the list, will return UserObject
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function MembersShow(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Lists.MembersShow(parameter))
    End Function

    ''' <summary>
    ''' Get members of the list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Members(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObjectListWithCursor))
        Return Await Task.Run(Function() token.Lists.Members(parameter))
    End Function

    ''' <summary>
    ''' Add a member to the list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function MembersCreate(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Lists.MembersCreate(parameter))
    End Function

    ''' <summary>
    ''' Destroy the selected list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Destroy(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of ListObject))
        Return Await Task.Run(Function() token.Lists.Destroy(parameter))
    End Function

    ''' <summary>
    ''' Update the selected list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Update(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of ListObject))
        Return Await Task.Run(Function() token.Lists.Update(parameter))
    End Function

    ''' <summary>
    ''' Create the new list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Create(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of ListObject))
        Return Await Task.Run(Function() token.Lists.Create(parameter))
    End Function

    ''' <summary>
    ''' Show the selected list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Show(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of ListObject))
        Return Await Task.Run(Function() token.Lists.Show(parameter))
    End Function

    ''' <summary>
    ''' Show the subscriptions that is reading
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Subscriptions(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of ListObjectWithCursorList))
        Return Await Task.Run(Function() token.Lists.Subscriptions(parameter))
    End Function
End Class