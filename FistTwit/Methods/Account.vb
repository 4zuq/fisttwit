Public Class Account
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get Settings
    ''' </summary>
    Public Function Settings() As ResponseObject(Of AccountObject)
        Return New ResponseObject(Of AccountObject)(TwitterAccess.GETAccess(EndPoints.Account_Setting, token))
    End Function

    ''' <summary>
    ''' POST Settings
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Settings(ByVal parameter As RequestParam) As ResponseObject(Of AccountObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of AccountObject)(TwitterAccess.POSTAccess(EndPoints.Account_Setting, token, parameter))
    End Function

    ''' <summary>
    ''' VerifyCredentials
    ''' </summary>
    Public Function VerifyCredentials() As ResponseObject(Of UserObject)
        Return New ResponseObject(Of UserObject)(TwitterAccess.GETAccess(EndPoints.Account_Verify_Credentials, token))
    End Function

    ''' <summary>
    ''' Update Profile
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function UpdateProfile(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of UserObject)(TwitterAccess.POSTAccess(EndPoints.Account_Update_Profile, token, parameter))
    End Function

    ''' <summary>
    ''' Update Profile of colors
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function UpdateProfileColors(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of UserObject)(TwitterAccess.POSTAccess(EndPoints.Account_Update_Profile_Colors, token, parameter))
    End Function

    ''' <summary>
    ''' Update background image of profile
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function UpdateProfileBackgroundImage(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        If parameter("image").GetType.Name = GetType(String).Name Then
            parameter("image") = IO.File.ReadAllBytes(parameter("image"))
        End If
        Return New ResponseObject(Of UserObject)(TwitterAccess.MultiPartPOSTAccess(EndPoints.Account_Update_Profile_Background_Image, token, parameter))
    End Function

    ''' <summary>
    ''' Update Profile image
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function UpdateProfileImage(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        If parameter("image").GetType.Name = GetType(String).Name Then
            parameter("image") = IO.File.ReadAllBytes(parameter("image"))
        End If
        Return New ResponseObject(Of UserObject)(TwitterAccess.MultiPartPOSTAccess(EndPoints.Account_Update_Profile_Image, token, parameter))
    End Function

    ''' <summary>
    ''' Remove image of profile banner
    ''' </summary>
    Public Function RemoveProfileBanner() As ResponseObject(Of String)
        Return New ResponseObject(Of String)(TwitterAccess.POSTAccess(EndPoints.Account_Remove_Profile_Banner, token))
    End Function

    ''' <summary>
    ''' Update image of profile banner
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function UpdateProfileBanner(ByVal parameter As RequestParam) As ResponseObject(Of String)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        If parameter.ContainsKey("banner") Then
            If parameter("banner").GetType.Name = GetType(Byte()).Name Then
                parameter("banner") = TwitterAccess.UrlEncode(Convert.ToBase64String(parameter("banner")))
            End If
        End If
        Return New ResponseObject(Of String)(TwitterAccess.POSTAccess(EndPoints.Account_Update_Profile_Banner, token, parameter))
    End Function

    ''' <summary>
    ''' Get RateLimitStatus
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function RateLimitStatus(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of RateLimitObjectList)
        Return New ResponseObject(Of RateLimitObjectList)(TwitterAccess.GETAccess(EndPoints.Application_Rate_Limit_Status, token, parameter))
    End Function
End Class