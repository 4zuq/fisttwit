Public Class Search
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Search tweets
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Tweets(ByVal parameter As RequestParam) As ResponseObject(Of SearchedObject)
        If IsNothing(parameter) Then
            parameter = New RequestParam
        End If
        parameter("q") = TwitterAccess.UrlEncode(parameter("q"))
        Return New ResponseObject(Of SearchedObject)(TwitterAccess.GETAccess(EndPoints.Search_Tweets, token, parameter))
    End Function
End Class