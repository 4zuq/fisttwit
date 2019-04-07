Public Class Geo
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' PlaceId
    ''' </summary>
    ''' <param name="PlaceId">PlaceId</param>
    Public Async Function Id(ByVal PlaceId As Decimal) As Task(Of ResponseObject(Of PlacesObject))
        Return Await Task.Run(Function() token.Geo.Id(PlaceId))
    End Function

    ''' <summary>
    ''' Get Reverse Geo code
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function ReverseGeocode(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of QueryResultGeoObject))
        Return Await Task.Run(Function() token.Geo.ReverseGeocode(parameter))
    End Function

    ''' <summary>
    ''' Search the selected geo
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Search(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of QueryResultGeoObject))
        Return Await Task.Run(Function() token.Geo.Search(parameter))
    End Function

    ''' <summary>
    ''' Similar Places
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function SimilarPlaces(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of QueryResultGeoObject))
        Return Await Task.Run(Function() token.Geo.SimilarPlaces(parameter))
    End Function
End Class