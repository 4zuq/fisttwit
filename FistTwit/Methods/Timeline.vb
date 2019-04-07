Public Class Timeline
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get HomeTimeline.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function HomeTimeline(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of StatusObjectList)
        Return New ResponseObject(Of StatusObjectList)(TwitterAccess.GETAccess(EndPoints.Statuses_HomeTL, token, parameter))
    End Function

    ''' <summary>
    ''' Get Mentions.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Mentions(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of StatusObjectList)
        Return New ResponseObject(Of StatusObjectList)(TwitterAccess.GETAccess(EndPoints.Statuses_Mentions, token, parameter))
    End Function

    ''' <summary>
    ''' Get Usertimeline.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function UserTimeline(ByVal parameter As RequestParam) As ResponseObject(Of StatusObjectList)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of StatusObjectList)(TwitterAccess.GETAccess(EndPoints.Statuses_UserTL, token, parameter))
    End Function

    ''' <summary>
    ''' Get Retweets of me
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function RetweetsOfMe(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of StatusObjectList)
        Return New ResponseObject(Of StatusObjectList)(TwitterAccess.GETAccess(EndPoints.Statuses_Retweets_of_me, token, parameter))
    End Function
End Class