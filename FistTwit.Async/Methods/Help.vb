Public Class Help
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get configuration
    ''' </summary>
    Public Async Function Configuration() As Task(Of ResponseObject(Of HelpConfigurationObject))
        Return Await Task.Run(Function() token.Help.Configuration)
    End Function

    ''' <summary>
    ''' Get languages
    ''' </summary>
    Public Async Function Languages() As Task(Of ResponseObject(Of LanguageObjectList))
        Return Await Task.Run(Function() token.Help.Languages)
    End Function

    ''' <summary>
    ''' Get Privacy policy
    ''' </summary>
    Public Async Function Privacy() As Task(Of ResponseObject(Of PrivacyPolicyObject))
        Return Await Task.Run(Function() token.Help.Privacy)
    End Function

    ''' <summary>
    ''' Get tos
    ''' </summary>
    Public Async Function Tos() As Task(Of ResponseObject(Of TosObject))
        Return Await Task.Run(Function() token.Help.Tos)
    End Function
End Class