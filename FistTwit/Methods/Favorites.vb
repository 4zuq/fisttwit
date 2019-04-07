Public Class Favorites
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Get list of favorites
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function List(Optional ByVal parameter As RequestParam = Nothing) As ResponseObject(Of StatusObjectList)
        Return New ResponseObject(Of StatusObjectList)(TwitterAccess.GETAccess(EndPoints.Favorites_List, token, parameter))
    End Function

    ''' <summary>
    ''' Delete the tweet from favorites list
    ''' </summary>
    ''' <param name="Id">Id</param>
    Public Function Destroy(ByVal Id As Decimal) As ResponseObject(Of StatusObject)
        If IsNothing(Id) Then
            Throw New ArgumentException("Id")
        End If
        Dim dic As New RequestParam
        dic.Add("id", Id.ToString)
        Return New ResponseObject(Of StatusObject)(TwitterAccess.POSTAccess(EndPoints.Favorites_Destroy, token, dic))
    End Function

    ''' <summary>
    ''' Add the tweet to favorites list
    ''' </summary>
    ''' <param name="Id">Id</param>
    Public Function Create(ByVal Id As Decimal) As ResponseObject(Of StatusObject)
        If IsNothing(Id) Then
            Throw New ArgumentException("Id")
        End If
        Dim dic As New RequestParam
        dic.Add("id", Id.ToString)
        Return New ResponseObject(Of StatusObject)(TwitterAccess.POSTAccess(EndPoints.Favorite_Create, token, dic))
    End Function
End Class