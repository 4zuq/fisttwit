Public Class Blocks
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' The list of blocks
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function List(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of UserObjectListWithCursor)
        Return New ResponseObject(Of UserObjectListWithCursor)(TwitterAccess.GETAccess(EndPoints.Blocks_List, token, parameter))
    End Function

    ''' <summary>
    ''' The Id list of blocks
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Ids(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of UserIdsList)
        Return New ResponseObject(Of UserIdsList)(TwitterAccess.GETAccess(EndPoints.Blocks_Ids, token, parameter))
    End Function

    ''' <summary>
    ''' Add the user to block list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Create(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of UserObject)(TwitterAccess.POSTAccess(EndPoints.Blocks_Create, token, parameter))
    End Function

    ''' <summary>
    ''' Delete the user from block list
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Destroy(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of UserObject)(TwitterAccess.POSTAccess(EndPoints.Blocks_Destroy, token, parameter))
    End Function
End Class