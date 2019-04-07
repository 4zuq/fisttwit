Imports System.Text
Imports System.IO

Public Class OauthAccess
    Private Auth As OauthTokens

    Friend Sub New(ByVal str As String, ByVal oauth As OauthTokens)
        Auth = oauth
        If String.IsNullOrEmpty(str) Then Exit Sub
        Dim s As String() = str.Split("&")
        For Each v As String In s
            If v.StartsWith("oauth_token=") Then
                Oauth_token = v.Replace("oauth_token=", "")
            ElseIf v.StartsWith("oauth_token_secret=") Then
                Oauth_token_secret = v.Replace("oauth_token_secret=", "")
            End If
        Next
    End Sub

    ''' <summary>
    ''' Gets Authorizeuri.
    ''' </summary>
    ''' <param name="force_login">Forces the user to enter.</param>
    Public Function GetAuthorizeUri(Optional ByVal force_login As Boolean = False) As Uri
        Dim value As New StringBuilder(EndPoints.Oauth_Authorize)
        value.Append(String.Format("?oauth_token={0}", Oauth_token))
        If force_login Then value.Append("&force_login=true")
        Return New Uri(value.ToString)
    End Function

    ''' <summary>
    ''' Gets AccessToken(OauthToken).
    ''' </summary>
    ''' <param name="verifier">Verifier(Hint: if you use PIN mode, you must put PIN value.)</param>
    Public Function GetAccessToken(ByVal verifier As String) As OauthTokens
        If String.IsNullOrEmpty(verifier) Then
            Throw New ArgumentException("verifier")
        End If
        Dim dic As SortedRequestParam = _
            TwitterAccess.GenerateBaseDictionary(Auth, "POST", EndPoints.Oauth_Access_token, Me.Oauth_token)
        dic.Add("oauth_verifier", verifier)
        dic.Add("oauth_signature", TwitterAccess.GenerateOauthSignature(Auth, "POST", EndPoints.Oauth_Access_token, dic))
        Dim d As New RequestParam
        For Each v As KeyValuePair(Of String, Object) In dic
            d.Add(v.Key, v.Value)
        Next
        Dim s As String() = New StreamReader(TwitterAccess.POSTAccess(EndPoints.Oauth_Access_token, Auth, d).GetResponseStream).ReadToEnd.Split("&")
        Dim ot As New OauthTokens
        ot = Auth
        For Each v As String In s
            If v.StartsWith("oauth_token=") Then
                ot.AccessToken = v.Replace("oauth_token=", "")
            ElseIf v.StartsWith("oauth_token_secret=") Then
                ot.AccessTokenSecret = v.Replace("oauth_token_secret=", "")
            ElseIf v.StartsWith("user_id=") Then
                ot.UserId = Decimal.Parse(v.Replace("user_id=", ""))
            ElseIf v.StartsWith("screen_name=") Then
                ot.ScreenName = v.Replace("screen_name=", "")
            End If
        Next
        Return ot
    End Function

    ''' <summary>
    ''' OauthToken
    ''' </summary>
    Public Property Oauth_token As String

    ''' <summary>
    ''' OauthTokenSecret
    ''' </summary>
    Public Property Oauth_token_secret As String

End Class
