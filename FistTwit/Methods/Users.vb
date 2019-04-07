Imports System.Text

Public Class Users
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Lookup
    ''' </summary>
    ''' <param name="ScreenNames">ScreenNames</param>
    Public Function Lookup(ByVal ScreenNames As String()) As ResponseObject(Of UserObjectList)
        If IsNothing(ScreenNames) Then
            Throw New ArgumentException("ScreenNames")
        End If
        Dim dic As New RequestParam
        Dim sb As New StringBuilder
        For Each v As String In ScreenNames
            If String.IsNullOrEmpty(sb.ToString) Then
                sb.Append(v)
            Else
                sb.Append("," & v)
            End If
        Next
        dic.Add("screen_name", TwitterAccess.UrlEncode(sb.ToString))
        Return Lookup(dic)
    End Function

    ''' <summary>
    ''' Lookup
    ''' </summary>
    ''' <param name="Ids">Ids</param>
    Public Function Lookup(ByVal Ids As Decimal()) As ResponseObject(Of UserObjectList)
        If IsNothing(Ids) Then
            Throw New ArgumentException("IDs")
        End If
        Dim dic As New RequestParam
        Dim sb As New StringBuilder
        For Each v As Decimal In Ids
            If String.IsNullOrEmpty(sb.ToString) Then
                sb.Append(v.ToString)
            Else
                sb.Append("," & v.ToString)
            End If
        Next
        dic.Add("user_id", TwitterAccess.UrlEncode(sb.ToString))
        Return Lookup(dic)
    End Function

    Private Function Lookup(ByVal parameter As RequestParam) As ResponseObject(Of UserObjectList)
        Return New ResponseObject(Of UserObjectList)(TwitterAccess.GETAccess(EndPoints.Users_Lookup, token, parameter))
    End Function

    ''' <summary>
    ''' Return the Userobject of the user
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Show(ByVal parameter As RequestParam) As ResponseObject(Of UserObject)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of UserObject)(TwitterAccess.GETAccess(EndPoints.Users_Show, token, parameter))
    End Function

    ''' <summary>
    ''' Search the user
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Search(ByVal parameter As RequestParam) As ResponseObject(Of UserObjectList)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of UserObjectList)(TwitterAccess.GETAccess(EndPoints.Users_Search, token, parameter))
    End Function

    ''' <summary>
    ''' Contributees
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Contributees(ByVal parameter As RequestParam) As ResponseObject(Of UserObjectList)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of UserObjectList)(TwitterAccess.GETAccess(EndPoints.Users_Contributees, token, parameter))
    End Function

    ''' <summary>
    ''' Contributors
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function Contributors(ByVal parameter As RequestParam) As ResponseObject(Of UserObjectList)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of UserObjectList)(TwitterAccess.GETAccess(EndPoints.Users_Contributors, token, parameter))
    End Function

    ''' <summary>
    ''' Report spam
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Function ReportSpam(ByVal parameter As RequestParam) As ResponseObject(Of UserObjectList)
        If IsNothing(parameter) Then
            Throw New ArgumentException("parameter")
        End If
        Return New ResponseObject(Of UserObjectList)(TwitterAccess.POSTAccess(EndPoints.Users_Report_Spam, token, parameter))
    End Function
End Class