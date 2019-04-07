Public Class Users
    Private token As OauthTokens

    Friend Sub New(ByVal t As OauthTokens)
        token = t
    End Sub

    ''' <summary>
    ''' Lookup
    ''' </summary>
    ''' <param name="ScreenNames">ScreenNames</param>
    Public Async Function Lookup(ByVal ScreenNames As String()) As Task(Of ResponseObject(Of UserObjectList))
        Return Await Task.Run(Function() token.Users.Lookup(ScreenNames))
    End Function

    ''' <summary>
    ''' Lookup
    ''' </summary>
    ''' <param name="Ids">Ids</param>
    Public Async Function Lookup(ByVal Ids As Decimal()) As Task(Of ResponseObject(Of UserObjectList))
        Return Await Task.Run(Function() token.Users.Lookup(Ids))
    End Function

    ''' <summary>
    ''' Return the Userobject of the user
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Show(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObject))
        Return Await Task.Run(Function() token.Users.Show(parameter))
    End Function

    ''' <summary>
    ''' Search the user
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Search(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObjectList))
        Return Await Task.Run(Function() token.Users.Search(parameter))
    End Function

    ''' <summary>
    ''' Contributees
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Contributees(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObjectList))
        Return Await Task.Run(Function() token.Users.Contributees(parameter))
    End Function

    ''' <summary>
    ''' Contributors
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function Contributors(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObjectList))
        Return Await Task.Run(Function() token.Users.Contributors(parameter))
    End Function

    ''' <summary>
    ''' Report spam
    ''' </summary>
    ''' <param name="parameter">Parameters</param>
    Public Async Function ReportSpam(ByVal parameter As RequestParam) As Task(Of ResponseObject(Of UserObjectList))
        Return Await Task.Run(Function() token.Users.ReportSpam(parameter))
    End Function
End Class