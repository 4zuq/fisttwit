Imports System.Runtime.Serialization.Json
Imports System.IO
Imports System.Text
Imports System.Net

Public Class ResponseObject(Of T)
    Private parser As New DataContractJsonSerializer(GetType(T))

    Public Sub New(ByVal s As WebResponse)
        ResponsedText = New StreamReader(s.GetResponseStream, Text.Encoding.UTF8).ReadToEnd
        ResponseCode = CType(s, HttpWebResponse).StatusCode
        If Not String.IsNullOrEmpty(ResponsedText) Then
            'Parse
            Objects = CType(parser.ReadObject(New MemoryStream(Encoding.UTF8.GetBytes(ResponsedText))), T)
        End If
        'Headers Check
        RateLimitHeadersAdd(s.Headers)
    End Sub

    Private Sub RateLimitHeadersAdd(h As WebHeaderCollection)
        If h.AllKeys.Contains("x-rate-limit-limit") Then RateLimitHeaders.XRateLimitLimit = h("x-rate-limit-limit")
        If h.AllKeys.Contains("x-rate-limit-remaining") Then RateLimitHeaders.XRateLimitRemaining = h("x-rate-limit-remaining")
        If h.AllKeys.Contains("x-rate-limit-reset") Then RateLimitHeaders.xlr = h("x-rate-limit-reset")
    End Sub

    ''' <summary>
    ''' The json of responsed.
    ''' </summary>
    Public Property ResponsedText As String

    ''' <summary>
    ''' The object of parsed data.
    ''' </summary>
    Public Property Objects As T

    ''' <summary>
    ''' The number of http status.
    ''' </summary>
    Public Property ResponseCode As Decimal?

    ''' <summary>
    ''' The headers of responsed.
    ''' </summary>
    Public Property RateLimitHeaders As RateLimitHeaders = New RateLimitHeaders
End Class

Public Class RateLimitHeaders

    Public Property XRateLimitLimit As Decimal?

    Public Property XRateLimitRemaining As Decimal?

    Public Function XRateLimitReset() As DateTime
        Return New DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(xlr).ToLocalTime
    End Function

    Friend Property xlr As Decimal?
End Class