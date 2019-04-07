Public Class Geo
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' PlaceId
    ''' </summary>
    ''' <param name="PlaceId">PlaceId</param>
    Public Function Id(ByVal PlaceId As Decimal) As ResponseObject(Of PlacesObject)
        If IsNothing(PlaceId) Then
            Throw New ArgumentException("PlaceId")
        End If
        Return New ResponseObject(Of PlacesObject)(TwitterAccess.GETAccess(String.Format(EndPoints.Geo_Id_PlaceId, PlaceId.ToString), token))
    End Function

    ''' <summary>
    ''' Get Reverse Geo code
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function ReverseGeocode(ByVal parameter As RequestParam) As ResponseObject(Of QueryResultGeoObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of QueryResultGeoObject)(TwitterAccess.GETAccess(EndPoints.Geo_Reverse_Geocode, token, parameter))
    End Function

    ''' <summary>
    ''' Search the selected geo
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Search(ByVal parameter As RequestParam) As ResponseObject(Of QueryResultGeoObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of QueryResultGeoObject)(TwitterAccess.GETAccess(EndPoints.Geo_Search, token, parameter))
    End Function

    ''' <summary>
    ''' Similar Places
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function SimilarPlaces(ByVal parameter As RequestParam) As ResponseObject(Of QueryResultGeoObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of QueryResultGeoObject)(TwitterAccess.GETAccess(EndPoints.Geo_Search, token, parameter))
    End Function
End Class