Public Class SavedSearches
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get list of saved searches
    ''' </summary>
    Public Async Function List() As Task(Of ResponseObject(Of SavedSearchesObjectList))
        Return Await Task.Run(Function() token.SavedSearches.List)
    End Function

    ''' <summary>
    ''' Get SavedSearchesObject of selected list
    ''' </summary>
    ''' <param name="Id">Id</param>
    Public Async Function ShowId(ByVal Id As Decimal) As Task(Of ResponseObject(Of SavedSearchesObject))
        Return Await Task.Run(Function() token.SavedSearches.ShowId(Id))
    End Function

    ''' <summary>
    ''' Create the new savedsearches
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Create(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of SavedSearchesObject))
        Return Await Task.Run(Function() token.SavedSearches.Create(parameter))
    End Function

    ''' <summary>
    ''' Destroy object of id
    ''' </summary>
    ''' <param name="Id">Id</param>
    Public Async Function Destroy(ByVal Id As Decimal) As Task(Of ResponseObject(Of SavedSearchesObject))
        Return Await Task.Run(Function() token.SavedSearches.Destroy(Id))
    End Function
End Class