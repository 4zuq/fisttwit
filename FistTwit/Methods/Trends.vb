Public Class Trends
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get trends of selected place
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Place(ByVal parameter As RequestParam) As ResponseObject(Of TrendsPlaceObjectList)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of TrendsPlaceObjectList)(TwitterAccess.GETAccess(EndPoints.Trends_Place, token, parameter))
    End Function

    ''' <summary>
    ''' Get trends of available
    ''' </summary>
    Public Function Available() As ResponseObject(Of TrendsObjectList)
        Return New ResponseObject(Of TrendsObjectList)(TwitterAccess.GETAccess(EndPoints.Trends_Available, token))
    End Function

    ''' <summary>
    ''' Get trends of closest
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Closest(ByVal parameter As RequestParam) As ResponseObject(Of TrendsObjectList)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of TrendsObjectList)(TwitterAccess.GETAccess(EndPoints.Trends_Closest, token, parameter))
    End Function
End Class