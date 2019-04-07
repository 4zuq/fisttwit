Imports System.Globalization

Friend Module DatetimeParser
    Friend Function Parse(ByVal str As String) As DateTime
        Const Format As String = "ddd MMM dd HH:mm:ss zzzz yyyy"
        If String.IsNullOrEmpty(str) Then Return New DateTime()
        Return DateTime.ParseExact(str, Format, CultureInfo.InvariantCulture)
    End Function

    Friend Function ParseForTrends(ByVal str As String) As DateTime
        Const Format As String = "yyyy-MM-ddTHH:mm:ssZ"
        If String.IsNullOrEmpty(str) Then Return New DateTime()
        Return DateTime.ParseExact(str, Format, CultureInfo.InvariantCulture)
    End Function
End Module
