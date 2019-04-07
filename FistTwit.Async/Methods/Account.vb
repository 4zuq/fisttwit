Public Class Account
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get Settings
    ''' </summary>
    Public Async Function Settings() As Task(Of ResponseObject(Of AccountObject))
        Return Await Task.Run(Function() token.Account.Settings())
    End Function

    ''' <summary>
    ''' POST Settings
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Settings(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of AccountObject))
        Return Await Task.Run(Function() token.Account.Settings(parameter))
    End Function

    ''' <summary>
    ''' VerifyCredentials
    ''' </summary>
    Public Async Function VerifyCredentials() As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Account.VerifyCredentials)
    End Function

    ''' <summary>
    ''' Update Profile
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function UpdateProfile(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Account.UpdateProfile(parameter))
    End Function

    ''' <summary>
    ''' Update Profile of colors
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function UpdateProfileColors(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Account.UpdateProfileColors(parameter))
    End Function

    ''' <summary>
    ''' Update background image of profile
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function UpdateProfileBackgroundImage(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Account.UpdateProfileBackgroundImage(parameter))
    End Function

    ''' <summary>
    ''' Update Profile image
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function UpdateProfileImage(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Account.UpdateProfileImage(parameter))
    End Function

    ''' <summary>
    ''' Remove image of profile banner
    ''' </summary>
    Public Async Function RemoveProfileBanner() As Task(Of ResponseObject(Of String))
        Return Await Task.Run(Function() token.Account.RemoveProfileBanner)
    End Function

    ''' <summary>
    ''' Update image of profile banner
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function UpdateProfileBanner(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of String))
        Return Await Task.Run(Function() token.Account.UpdateProfileBanner(parameter))
    End Function

    ''' <summary>
    ''' Get RateLimitStatus
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function RateLimitStatus(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of RateLimitObjectList))
        Return Await Task.Run(Function() token.Account.RateLimitStatus(parameter))
    End Function
End Class
