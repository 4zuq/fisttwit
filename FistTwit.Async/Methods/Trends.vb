Public Class Trends
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get trends of selected place
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Place(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of TrendsPlaceObjectList))
        Return Await Task.Run(Function() token.Trends.Place(parameter))
    End Function

    ''' <summary>
    ''' Get trends of available
    ''' </summary>
    Public Async Function Available() As Task(Of ResponseObject(Of TrendsObjectList))
        Return Await Task.Run(Function() token.Trends.Available())
    End Function

    ''' <summary>
    ''' Get trends of closest
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Closest(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of TrendsObjectList))
        Return Await Task.Run(Function() token.Trends.Closest(parameter))
    End Function
End Class