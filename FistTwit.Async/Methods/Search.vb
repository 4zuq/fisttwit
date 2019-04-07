Public Class Search
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Search tweets
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Tweets(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of SearchedObject))
        Return Await Task.Run(Function() token.Search.Tweets(parameter))
    End Function
End Class
