Public Class Blocks
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' The list of blocks
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function List(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of UserObjectListWithCursor))
        Return Await Task.Run(Function() token.Blocks.List(parameter))
    End Function

    ''' <summary>
    ''' The Id list of blocks
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Ids(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of UserIdsList))
        Return Await Task.Run(Function() token.Blocks.Ids(parameter))
    End Function

    ''' <summary>
    ''' Add the user to block list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Create(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Blocks.Create(parameter))
    End Function

    ''' <summary>
    ''' Delete the user from block list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Destroy(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Blocks.Destroy(parameter))
    End Function
End Class