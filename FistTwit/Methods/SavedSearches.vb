Public Class SavedSearches
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get list of saved searches
    ''' </summary>
    Public Function List() As ResponseObject(Of SavedSearchesObjectList)
        Return New ResponseObject(Of SavedSearchesObjectList)(TwitterAccess.GETAccess(EndPoints.Saved_Searches_List, token))
    End Function

    ''' <summary>
    ''' Get SavedSearchesObject of selected list
    ''' </summary>
    ''' <param name="Id">Id</param>
    Public Function ShowId(ByVal Id As Decimal) As ResponseObject(Of SavedSearchesObject)
        Return New ResponseObject(Of SavedSearchesObject)(TwitterAccess.GETAccess(String.Format(EndPoints.Saved_Searches_Show_Id, Id.ToString), token))
    End Function

    ''' <summary>
    ''' Create the new savedsearches
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Create(ByVal parameter As RequestParam) As ResponseObject(Of SavedSearchesObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of SavedSearchesObject)(TwitterAccess.POSTAccess(EndPoints.Saved_Searches_Create, token, parameter))
    End Function

    ''' <summary>
    ''' Destroy object of id
    ''' </summary>
    ''' <param name="Id">Id</param>
    Public Function Destroy(ByVal Id As Decimal) As ResponseObject(Of SavedSearchesObject)
        Return New ResponseObject(Of SavedSearchesObject)(TwitterAccess.GETAccess(String.Format(EndPoints.Saved_Searches_Destroy_Id, Id.ToString), token))
    End Function
End Class