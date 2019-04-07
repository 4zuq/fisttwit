Public Class DirectMessages
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get DirectMessages.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function DirectMessages(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of DMObjectList)
        Return New ResponseObject(Of DMObjectList)(TwitterAccess.GETAccess(EndPoints.Direct_Messages, token, parameter))
    End Function

    ''' <summary>
    ''' Get Sent of directMessages.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Sent(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of DMObjectList)
        Return New ResponseObject(Of DMObjectList)(TwitterAccess.GETAccess(EndPoints.Direct_Messages_Sent, token, parameter))
    End Function

    ''' <summary>
    ''' Get DMObject of Id.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Show(ByVal parameter As RequestParam) As ResponseObject(Of DMObject)
        If IsNothing(parameter) Then
            parameter = New RequestParam
        End If
        Return New ResponseObject(Of DMObject)(TwitterAccess.GETAccess(EndPoints.Direct_Messsages_Show, token, parameter))
    End Function

    ''' <summary>
    ''' Destroy the DM.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Destroy(ByVal parameter As RequestParam) As ResponseObject(Of DMObject)
        If IsNothing(parameter) Then
            parameter = New RequestParam
        End If
        Return New ResponseObject(Of DMObject)(TwitterAccess.POSTAccess(EndPoints.Direct_Messages_Destroy, token, parameter))
    End Function

    ''' <summary>
    ''' Create a new DM.
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Create(ByVal parameter As RequestParam) As ResponseObject(Of DMObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        parameter("text") = TwitterAccess.UrlEncode(parameter("text"))
        Return New ResponseObject(Of DMObject)(TwitterAccess.POSTAccess(EndPoints.Direct_Messages_New, token, parameter))
    End Function

End Class