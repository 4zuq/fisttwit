Public Class Favorites
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get list of favorites
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function List(Optional ByVal parameter As RequestParam = Nothing) As Task(Of ResponseObject(Of StatusObjectList))
        Return Await Task.Run(Function() token.Favorites.List(parameter))
    End Function

    ''' <summary>
    ''' Delete the tweet from favorites list
    ''' </summary>
    ''' <param name="Id">Id</param>
    Public Async Function Destroy(ByVal Id As Decimal) As Task(Of ResponseObject(Of StatusObject))
        Return Await Task.Run(Function() token.Favorites.Destroy(Id))
    End Function

    ''' <summary>
    ''' Add the tweet to favorites list
    ''' </summary>
    ''' <param name="Id">Id</param>
    Public Async Function Create(ByVal Id As Decimal) As Task(Of ResponseObject(Of StatusObject))
        Return Await Task.Run(Function() token.Favorites.Create(Id))
    End Function
End Class