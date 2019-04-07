Public Class Statuses
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get Retweets of id.
    ''' </summary>
    ''' <param name="Id">The id of status</param>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Retweets(ByVal Id As Decimal, Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of StatusObjectList))
        Return Await Task.Run(Function() token.Statuses.Retweets(Id, parameter))
    End Function

    ''' <summary>
    ''' Get the tweet of id.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Show(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of StatusObject))
        Return Await Task.Run(Function() token.Statuses.Show(parameter))
    End Function

    ''' <summary>
    ''' Delete the tweet.
    ''' </summary>
    ''' <param name="Id">The id of status</param>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Destroy(ByVal Id As Decimal, Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of StatusObject))
        Return Await Task.Run(Function() token.Statuses.Destroy(Id, parameter))
    End Function

    ''' <summary>
    ''' Post a tweet.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Update(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of StatusObject))
        Return Await Task.Run(Function() token.Statuses.Update(parameter))
    End Function

    ''' <summary>
    ''' Retweet a status.
    ''' </summary>
    ''' <param name="Id">The id of tweet</param>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Retweet(ByVal Id As Decimal, Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of StatusObject))
        Return Await Task.Run(Function() token.Statuses.Retweet(Id, parameter))
    End Function

    ''' <summary>
    ''' Get oembed object
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Oembed(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of OembedObject))
        Return Await Task.Run(Function() token.Statuses.Oembed(parameter))
    End Function

    ''' <summary>
    ''' Get oembed object
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function RetweetersIds(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of RetweetersObject))
        Return Await Task.Run(Function() token.Statuses.RetweetersIds(parameter))
    End Function

    ''' <summary>
    ''' Update With media
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function UpdateWithMedia(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of StatusObject))
        Return Await Task.Run(Function() token.Statuses.UpdateWithMedia(parameter))
    End Function
End Class
