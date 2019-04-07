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
    Public Function Retweets(ByVal Id As Decimal, Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of StatusObjectList)
        If IsNothing(Id) Then
            Throw New ArgumentException("Id")
        End If
        Return New ResponseObject(Of StatusObjectList)(TwitterAccess.GETAccess(String.Format(EndPoints.Statuses_Retweets, Id.ToString), token, parameter))
    End Function

    ''' <summary>
    ''' Get the tweet of id.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Show(ByVal parameter As RequestParam) As ResponseObject(Of StatusObject)
        If IsNothing(parameter) Then
            parameter = New RequestParam
        End If
        Return New ResponseObject(Of StatusObject)(TwitterAccess.GETAccess(EndPoints.Statuses_Show, token, parameter))
    End Function

    ''' <summary>
    ''' Delete the tweet.
    ''' </summary>
    ''' <param name="Id">The id of status</param>
    ''' <param name="parameter">Parameters</param>
    Public Function Destroy(ByVal Id As Decimal, Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of StatusObject)
        If IsNothing(Id) Then
            Throw New ArgumentException("Id")
        End If
        Return New ResponseObject(Of StatusObject)(TwitterAccess.POSTAccess(String.Format(EndPoints.Statuses_Destroy, Id.ToString), token, parameter))
    End Function

    ''' <summary>
    ''' Post a tweet.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Update(ByVal parameter As RequestParam) As ResponseObject(Of StatusObject)
        If IsNothing(parameter) Then
            parameter = New RequestParam
        End If
        parameter("status") = TwitterAccess.UrlEncode(parameter("status"))
        Return New ResponseObject(Of StatusObject)(TwitterAccess.POSTAccess(EndPoints.Statuses_Update, token, parameter))
    End Function

    ''' <summary>
    ''' Retweet a status.
    ''' </summary>
    ''' <param name="Id">The id of tweet</param>
    ''' <param name="parameter">Parameters</param>
    Public Function Retweet(ByVal Id As Decimal, Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of StatusObject)
        If IsNothing(Id) Then
            Throw New ArgumentException("Id")
        End If
        Return New ResponseObject(Of StatusObject)(TwitterAccess.POSTAccess(String.Format(EndPoints.Statuses_Retweet, Id.ToString), token, parameter))
    End Function

    ''' <summary>
    ''' Get oembed object
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Oembed(ByVal parameter As RequestParam) As ResponseObject(Of OembedObject)
        If IsNothing(parameter) Then
            parameter = New RequestParam
        End If
        Return New ResponseObject(Of OembedObject)(TwitterAccess.GETAccess(EndPoints.Statuses_Oembed, token, parameter))
    End Function

    ''' <summary>
    ''' Get oembed object
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function RetweetersIds(ByVal parameter As RequestParam) As ResponseObject(Of RetweetersObject)
        If IsNothing(parameter) Then
            parameter = New RequestParam
        End If
        Return New ResponseObject(Of RetweetersObject)(TwitterAccess.GETAccess(EndPoints.Statuses_Retweeters_Ids, token, parameter))
    End Function

    ''' <summary>
    ''' Update With media
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function UpdateWithMedia(ByVal parameter As RequestParam) As ResponseObject(Of StatusObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        If parameter("media[]").GetType.Name = GetType(String).Name Then
            parameter("media[]") = IO.File.ReadAllBytes(parameter("media[]"))
        End If
        Return New ResponseObject(Of StatusObject)(TwitterAccess.MultiPartPOSTAccess(EndPoints.Statuses_Update_With_Media, token, parameter))
    End Function
End Class