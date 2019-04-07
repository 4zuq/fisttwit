Public Class Timeline
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get HomeTimeline.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function HomeTimeline(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of StatusObjectList))
        Return Await Task.Run(Function() token.Timeline.HomeTimeline(parameter))
    End Function

    ''' <summary>
    ''' Get Mentions.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Mentions(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of StatusObjectList))
        Return Await Task.Run(Function() token.Timeline.Mentions(parameter))
    End Function

    ''' <summary>
    ''' Get Usertimeline.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function UserTimeline(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of StatusObjectList))
        Return Await Task.Run(Function() token.Timeline.UserTimeline(parameter))
    End Function

    ''' <summary>
    ''' Get Retweets of me
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function RetweetsOfMe(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of StatusObjectList))
        Return Await Task.Run(Function() token.Timeline.RetweetsOfMe(parameter))
    End Function
End Class