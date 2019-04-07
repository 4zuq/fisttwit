Public Class Help
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get configuration
    ''' </summary>
    Public Function Configuration() As ResponseObject(Of HelpConfigurationObject)
        Return New ResponseObject(Of HelpConfigurationObject)(TwitterAccess.GETAccess(EndPoints.Help_Configuration, token))
    End Function

    ''' <summary>
    ''' Get languages
    ''' </summary>
    Public Function Languages() As ResponseObject(Of LanguageObjectList)
        Return New ResponseObject(Of LanguageObjectList)(TwitterAccess.GETAccess(EndPoints.Help_Languages, token))
    End Function

    ''' <summary>
    ''' Get Privacy policy
    ''' </summary>
    Public Function Privacy() As ResponseObject(Of PrivacyPolicyObject)
        Return New ResponseObject(Of PrivacyPolicyObject)(TwitterAccess.GETAccess(EndPoints.Help_Privacy, token))
    End Function

    ''' <summary>
    ''' Get tos
    ''' </summary>
    Public Function Tos() As ResponseObject(Of TosObject)
        Return New ResponseObject(Of TosObject)(TwitterAccess.GETAccess(EndPoints.Help_Tos, token))
    End Function
End Class