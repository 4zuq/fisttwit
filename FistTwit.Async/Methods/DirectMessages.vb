Public Class DirectMessages
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get DirectMessages.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function DirectMessages(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of DMObjectList))
        Return Await Task.Run(Function() token.DirectMessages.DirectMessages(parameter))
    End Function

    ''' <summary>
    ''' Get Sent of directMessages.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Sent(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of DMObjectList))
        Return Await Task.Run(Function() token.DirectMessages.Sent(parameter))
    End Function

    ''' <summary>
    ''' Get DMObject of Id.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Show(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of DMObject))
        Return Await Task.Run(Function() token.DirectMessages.Show(parameter))
    End Function

    ''' <summary>
    ''' Destroy the DM.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Destroy(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of DMObject))
        Return Await Task.Run(Function() token.DirectMessages.Destroy(parameter))
    End Function

    ''' <summary>
    ''' Create a new DM.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Create(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of DMObject))
        Return Await Task.Run(Function() token.DirectMessages.Create(parameter))
    End Function

End Class