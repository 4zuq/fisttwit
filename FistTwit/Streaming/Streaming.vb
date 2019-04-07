Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Xml
Imports System.Xml.XPath
Imports FistTwit
Imports System.Runtime.Serialization.Json
Imports System.Net

Namespace TwitterStreaming
    Public Class Streaming
        Private CanDoing As Boolean
        Private SelectedKind As StreamingKind
        Private oauth As OauthTokens
        Private param As RequestParam
        Private sr As StreamReader
        Private wa As System.Net.HttpWebRequest
        'Streaming
        Private ReadOnly Stream_Statuses_Sample As String = "https://stream.twitter.com/1.1/statuses/sample.json"
        Private ReadOnly Stream_User As String = "https://userstream.twitter.com/1.1/user.json"
        Private ReadOnly Stream_Filter As String = "https://stream.twitter.com/1.1/statuses/filter.json"
#Region "Delegates"
        Public Delegate Sub TwitterStreamCallbackCb(data As Object)
#End Region

#Region "Callbacks"
        Private cb As TwitterStreamCallbackCb
#End Region

        Public Sub New(ByVal scb As TwitterStreamCallbackCb)
            cb = scb
        End Sub

        ''' <summary>
        ''' Start UserStream
        ''' </summary>
        ''' <param name="token">OauthToken</param>
        ''' <param name="Kind">The kind of streaming</param>
        ''' <param name="Parameters">Parameters</param>
        Public Sub StartStream(ByVal token As OauthTokens, ByVal Kind As StreamingKind, Optional ByVal Parameters As RequestParam = Nothing)
            Try
                If IsNothing(token) Then
                    Throw New ArgumentException("Token")
                End If
                If CanDoing Then
                    Throw New ArgumentException("Streaming is already opening!")
                End If
                CanDoing = True
                SelectedKind = Kind
                oauth = token
                param = Parameters
                Dim t As New Thread(AddressOf DoStreaming)
                t.Start()
            Catch ex As WebException
                Console.WriteLine("Status Code : " & (CType(ex.Response, HttpWebResponse).StatusCode))
            End Try
        End Sub

        ''' <summary>
        ''' Stop UserStream
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub StopStream()
            CanDoing = False
        End Sub

        Private Sub DoStreaming()
            Dim sd As SortedRequestParam
            If SelectedKind = StreamingKind.Filter Then
                sd = TwitterAccess.IntoSortedDictionary(oauth, "POST", GetEndPoint, param)
            Else
                sd = TwitterAccess.IntoSortedDictionary(oauth, "GET", GetEndPoint, param)
            End If
            Dim parameter As String = TwitterAccess.GetParsedDictionary(sd)
            wa = CType(System.Net.WebRequest.Create(GetEndPoint() & "?" & parameter),  _
System.Net.HttpWebRequest)
            If SelectedKind = StreamingKind.Filter Then
                wa.Method = "POST"
            Else
                wa.Method = "GET"
            End If
            sr = New StreamReader(wa.GetResponse().GetResponseStream(), Encoding.UTF8)
            While CanDoing
                Dim str As String = sr.ReadLine
                If str.Length > 0 Then
                    UserStreamThrow(str)
                End If
            End While
            wa.Abort()
            sr.Close()
            sr.Dispose()
        End Sub

        Private Sub UserStreamThrow(ByVal str As String)
            If String.IsNullOrWhiteSpace(str) Then Exit Sub
            Dim p As ParseClass = CType(New DataContractJsonSerializer(GetType(ParseClass)).ReadObject _
                (New MemoryStream(Encoding.UTF8.GetBytes(str))), ParseClass)
            If Not String.IsNullOrEmpty(p.Description) Then
                'UserObject
                cb.Invoke(CType(New DataContractJsonSerializer(GetType(UserObject)).ReadObject _
                          (New MemoryStream(Encoding.UTF8.GetBytes(str))), UserObject))
            ElseIf Not String.IsNullOrEmpty(p.Text) Then
                'StatusObject
                cb.Invoke(CType(New DataContractJsonSerializer(GetType(StatusObject)).ReadObject _
                          (New MemoryStream(Encoding.UTF8.GetBytes(str))), StatusObject))
            ElseIf Not IsNothing(p.Sender) Then
                'DMobj
                cb.Invoke(CType(New DataContractJsonSerializer(GetType(DMObject)).ReadObject _
          (New MemoryStream(Encoding.UTF8.GetBytes(str))), DMObject))
            ElseIf Not IsNothing(p.Delete) Then
                cb.Invoke(p.Delete)
            ElseIf Not IsNothing(p.ScrubGeo) Then
                cb.Invoke(p.ScrubGeo)
            ElseIf Not IsNothing(p.Limit) Then
                cb.Invoke(p.Limit)
            ElseIf Not IsNothing(p.StatusWithheld) Then
                cb.Invoke(p.StatusWithheld)
            ElseIf Not IsNothing(p.UserWithHeld) Then
                cb.Invoke(p.UserWithHeld)
            ElseIf Not IsNothing(p.Disconnect) Then
                cb.Invoke(p.Disconnect)
            ElseIf Not IsNothing(p.Warning) Then
                cb.Invoke(p.Warning)
            ElseIf Not IsNothing(p.Friends) Then
                cb.Invoke(CType(New DataContractJsonSerializer(GetType(StreamObjects.FriendsIdObject)).ReadObject _
                          (New MemoryStream(Encoding.UTF8.GetBytes(str))), StreamObjects.FriendsIdObject))
            ElseIf Not String.IsNullOrEmpty(p.Events) Then
                If p.Events Like "*favorite*" Then
                    cb.Invoke(CType(New DataContractJsonSerializer(GetType(StreamObjects.EventsObject(Of StatusObject))).ReadObject _
                        (New MemoryStream(Encoding.UTF8.GetBytes(str))), StreamObjects.EventsObject(Of StatusObject)))
                ElseIf p.Events Like "*list*" Then
                    cb.Invoke(CType(New DataContractJsonSerializer(GetType(StreamObjects.EventsObject(Of ListObject))).ReadObject _
                        (New MemoryStream(Encoding.UTF8.GetBytes(str))), StreamObjects.EventsObject(Of ListObject)))
                Else
                    cb.Invoke(CType(New DataContractJsonSerializer(GetType(StreamObjects.EventsObject(Of String))).ReadObject _
                        (New MemoryStream(Encoding.UTF8.GetBytes(str))), StreamObjects.EventsObject(Of String)))
                End If
            End If
        End Sub

        Private Function GetEndPoint() As String
            If SelectedKind = StreamingKind.Sample Then
                Return Stream_Statuses_Sample
            ElseIf SelectedKind = StreamingKind.User Then
                Return Stream_User
            ElseIf SelectedKind = StreamingKind.Filter Then
                Return Stream_Filter
            End If
            Return Nothing
        End Function

    End Class

    Public Enum StreamingKind
        Sample
        Filter
        User
    End Enum
End Namespace
