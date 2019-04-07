Imports System.Net
Imports System.Text
Imports System.IO

Namespace TwitterAccess
    Public Module AccessToTwitter

        ''' <summary>
        ''' Access to Twitter with POST.
        ''' </summary>
        ''' <param name="EndPoint">End Point.</param>
        ''' <param name="Oauth">OauthToken</param>
        ''' <param name="Dic">The dictionary of the parameters.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function POSTAccess(ByVal EndPoint As String, ByVal Oauth As OauthTokens, Optional ByVal Dic As RequestParam = Nothing) As WebResponse
            If String.IsNullOrEmpty(EndPoint) Then
                Throw New ArgumentException("EndPoint")
            End If
            If IsNothing(Oauth) Then
                Throw New ArgumentException("Oauth")
            End If
            Dim parameter As String = ""
            Dim sd As New SortedRequestParam
            If Not IsNothing(Dic) Then
                If Dic.ContainsKey("oauth_signature") Then
                    For Each v As KeyValuePair(Of String, Object) In Dic
                        sd.Add(v.Key, v.Value)
                    Next
                Else
                    sd = IntoSortedDictionary(Oauth, "POST", EndPoint, Dic)
                End If
            Else
                sd = IntoSortedDictionary(Oauth, "POST", EndPoint, Dic)
            End If
            parameter = GetParsedDictionary(sd)
            Dim wa As System.Net.HttpWebRequest = _
        CType(System.Net.WebRequest.Create(EndPoint),  _
            System.Net.HttpWebRequest)
            wa.Method = "POST" 'POST
            wa.ContentType = "application/x-www-form-urlencoded"
            wa.ContentLength = Encoding.UTF8.GetByteCount(parameter)
            Dim reqStream As Stream = wa.GetRequestStream()
            reqStream.Write(Encoding.UTF8.GetBytes(parameter), 0, Encoding.UTF8.GetByteCount(parameter))
            reqStream.Close()
            Try
                Return wa.GetResponse()
            Catch ex As WebException
                If ex.Status = System.Net.WebExceptionStatus.ProtocolError Then
                    Return ex.Response()
                Else
                    Throw New Exception(ex.ToString)
                End If
            End Try
        End Function

        ''' <summary>
        ''' Access to Twitter with GET.
        ''' </summary>
        ''' <param name="EndPoint">End Point.</param>
        ''' <param name="Oauth">OauthToken</param>
        ''' <param name="Dic">The dictionary of the parameters.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function GETAccess(ByVal EndPoint As String, ByVal Oauth As OauthTokens, Optional ByVal Dic As RequestParam = Nothing) As WebResponse
            If String.IsNullOrEmpty(EndPoint) Then
                Throw New ArgumentException("EndPoint")
            End If
            If IsNothing(Oauth) Then
                Throw New ArgumentException("Oauth")
            End If
            Dim parameter As String = ""
            Dim sd As SortedRequestParam = IntoSortedDictionary(Oauth, "GET", EndPoint, Dic)
            parameter = GetParsedDictionary(sd)
            Dim wa As System.Net.HttpWebRequest = _
        CType(System.Net.WebRequest.Create(EndPoint & "?" & parameter),  _
            System.Net.HttpWebRequest)
            wa.Method = "GET" 'GET
            wa.ContentType = "application/x-www-form-urlencoded"
            Try
                Return wa.GetResponse()
            Catch ex As WebException
                If ex.Status = System.Net.WebExceptionStatus.ProtocolError Then
                    Return ex.Response()
                Else
                    Throw New Exception(ex.ToString)
                End If
            End Try
        End Function


        Friend Function MultiPartPOSTAccess(ByVal EndPoint As String, ByVal Oauth As OauthTokens, ByVal Dic As RequestParam) As WebResponse
            If String.IsNullOrEmpty(EndPoint) Then
                Throw New ArgumentException("EndPoint")
            End If
            If IsNothing(Oauth) Then
                Throw New ArgumentException("Oauth")
            End If
            If IsNothing(Dic) Then
                Throw New ArgumentException("Dic")
            End If
            Dim sd As SortedRequestParam = GenerateBaseDictionary(Oauth, "POST", EndPoint)
            sd.Add("oauth_signature", UrlEncode(GenerateOauthSignature(Oauth, "POST", EndPoint, sd)))
            Dim boundary As String = "fisttwitboundary"
            Dim wa As System.Net.HttpWebRequest = _
        CType(System.Net.WebRequest.Create(EndPoint),  _
            System.Net.HttpWebRequest)
            wa.Method = "POST"
            wa.ContentType = "multipart/form-data;boundary=" & boundary
            wa.Headers(HttpRequestHeader.Authorization) = String.Format("Oauth {0}", GetOauthPortion(sd))
            Dim pd As New StringBuilder
            Dim KeyInData As String = Nothing
            For Each v As KeyValuePair(Of String, Object) In Dic
                If v.Value.GetType.Name = GetType(Byte()).Name Then
                    KeyInData = v.Key
                Else
                    pd.Append(String.Format("--" & boundary & vbCrLf & _
          "Content-Disposition: form-data; name=""{0}""" _
          & vbCrLf & vbCrLf & v.Value & vbCrLf, v.Key))
                End If
            Next
            pd.Append(String.Format("--" & boundary & vbCrLf & _
        "Content-Type: application/octet-stream" & vbCrLf &
        "Content-Disposition: form-data; name=""{0}""; filename=""{1}""" & vbCrLf & vbCrLf, KeyInData, New Random().Next))
            Dim PostByte As Byte() = Encoding.UTF8.GetBytes(pd.ToString)
            Dim PostEnd As String = vbCrLf & "--" & boundary & "--" & vbCrLf
            Dim PostEndByte As Byte() = Encoding.UTF8.GetBytes(PostEnd)
            Dim PostData As Byte() = CType(Dic(KeyInData), Byte())
            wa.ContentLength = PostByte.Length + PostEndByte.Length + PostData.Length
            Dim reqStream As System.IO.Stream = wa.GetRequestStream()
            reqStream.Write(PostByte, 0, PostByte.Length)
            reqStream.Write(PostData, 0, PostData.Length)
            reqStream.Write(PostEndByte, 0, PostEndByte.Length)
            reqStream.Close()
            Try
                Return wa.GetResponse()
            Catch ex As WebException
                If ex.Status = System.Net.WebExceptionStatus.ProtocolError Then
                    Return ex.Response()
                Else
                    Throw New Exception(ex.ToString)
                End If
            End Try
        End Function

        Private Function GetOauthPortion(ByVal param As SortedRequestParam) As String
            Dim sb As New StringBuilder
            sb.Append(String.Format("oauth_consumer_key={0}, ", param("oauth_consumer_key")))
            sb.Append(String.Format("oauth_nonce={0}, ", param("oauth_nonce")))
            sb.Append(String.Format("oauth_signature={0}, ", param("oauth_signature")))
            sb.Append(String.Format("oauth_signature_method={0}, ", param("oauth_signature_method")))
            sb.Append(String.Format("oauth_timestamp={0}, ", param("oauth_timestamp")))
            sb.Append(String.Format("oauth_token={0}, ", param("oauth_token")))
            sb.Append(String.Format("oauth_version={0}", param("oauth_version")))
            Return sb.ToString
        End Function

        ''' <summary>
        ''' Generate Base Dictionary.
        ''' </summary>
        ''' <param name="oauth">OauthToken</param>
        ''' <param name="HttpMethod">HTTP Method(POST, GET)</param>
        ''' <param name="EndPoint">EndPoint</param>
        ''' <param name="OauthToken">OauthToken(optional)</param>
        Friend Function GenerateBaseDictionary(ByVal oauth As OauthTokens, ByVal HttpMethod As String, ByVal EndPoint As String, Optional ByVal OauthToken As String = Nothing) As SortedRequestParam
            Dim OauthNonce As String = GenerateOauthNonce()
            Dim dic As New SortedRequestParam
            'Append timestamp
            Dim UNIX_EPOCH As New DateTime(1970, 1, 1, 0, 0, 0, 0)
            Dim tstamp As Long = CType((DateTime.Now.ToUniversalTime - UNIX_EPOCH).TotalSeconds, Long)
            'GenerateSignature
            dic.Add("oauth_timestamp", tstamp)
            dic.Add("oauth_nonce", OauthNonce)
            dic.Add("oauth_signature_method", "HMAC-SHA1")
            dic.Add("oauth_consumer_key", oauth.ConsumerKey)
            dic.Add("oauth_version", "1.0")
            If Not IsNothing(OauthToken) Then
                dic.Add("oauth_token", OauthToken)
            ElseIf Not String.IsNullOrEmpty(oauth.AccessToken) Then
                dic.Add("oauth_token", oauth.AccessToken)
            End If
            Return dic
        End Function

        ''' <summary>
        ''' Generate oauth_signature
        ''' </summary>
        ''' <param name="oauth">OauthToken</param>
        ''' <param name="Method">HttpMethod</param>
        ''' <param name="EndPoint">EndPoint</param>
        ''' <param name="sorteddic">SortedDic</param>
        Public Function GenerateOauthSignature(ByVal oauth As OauthTokens, ByVal Method As String, ByVal EndPoint As String, ByVal sorteddic As SortedRequestParam) As String
            If IsNothing(oauth) Then
                Throw New ArgumentException("Oauth")
            End If
            If String.IsNullOrEmpty(Method) Then
                Throw New ArgumentException("Method")
            End If
            If String.IsNullOrEmpty(EndPoint) Then
                Throw New ArgumentException("EndPoint")
            End If
            If IsNothing(sorteddic) Then
                Throw New ArgumentException("SortedDic")
            End If
            If IsNothing(oauth.AccessTokenSecret) Then
                oauth.AccessTokenSecret = ""
            End If
            Dim data As Byte() = Encoding.UTF8.GetBytes _
                                 (String.Format("{0}&{1}&{2}", Method, UrlEncode(EndPoint), UrlEncode(GetParsedDictionary(sorteddic)).Replace("%3F", "")))
            Dim k As String = UrlEncode(oauth.ConsumerSecret) & "&" & UrlEncode(oauth.AccessTokenSecret)
            Dim keyData As Byte() = Encoding.UTF8.GetBytes(k)
            Dim hmac As New System.Security.Cryptography.HMACSHA1(keyData)
            Dim bs As Byte() = hmac.ComputeHash(data)
            hmac.Clear()
            Return Convert.ToBase64String(bs)
        End Function

        ''' <summary>
        ''' Generate Oauth_nonce
        ''' </summary>
        Private Function GenerateOauthNonce() As String
            Dim nonce As String = Guid.NewGuid().ToString
            nonce = nonce.Replace("-", "")
            Return nonce
        End Function

        ''' <summary>
        ''' Return string that parsed dictionary.
        ''' </summary>
        ''' <param name="Dic">Dictionary</param>
        Public Function GetParsedDictionary(ByVal Dic As SortedRequestParam)
            If IsNothing(Dic) Then Return ""
            Dim value As New StringBuilder()
            For Each v As KeyValuePair(Of String, Object) In Dic
                If Not value.ToString = "" Then
                    value.Append("&" & v.Key & "=" & v.Value)
                Else
                    value.Append(v.Key & "=" & v.Value)
                End If
            Next
            If value.ToString = "?" Then Return ""
            Return value.ToString
        End Function


        Public Function IntoSortedDictionary(ByVal oauth As OauthTokens, ByVal HttpMethod As String, ByVal EndPoint As String, ByVal dic As RequestParam) As SortedRequestParam
            Dim d As SortedRequestParam = GenerateBaseDictionary(oauth, HttpMethod, EndPoint)
            If Not IsNothing(dic) Then
                For Each value As KeyValuePair(Of String, Object) In dic
                    d.Add(value.Key, value.Value)
                Next
            End If
            d.Add("oauth_signature", UrlEncode(GenerateOauthSignature(oauth, HttpMethod, EndPoint, d)))
            Return d
        End Function

        Public Function UrlEncode(ByVal str As String) As String
            If String.IsNullOrEmpty(str) Then Return ""
            Dim encodedString As New System.Text.StringBuilder()

            For Each c As Char In str
                If ("0"c <= c AndAlso c <= "9"c) OrElse _
                    ("a"c <= c AndAlso c <= "z"c) OrElse _
                    ("A"c <= c AndAlso c <= "Z"c) OrElse _
                    (0 <= "-._~".IndexOf(c)) Then
                    'if it isn't escape string.
                    encodedString.Append(c)
                Else
                    'if it is escape string.
                    Dim buf As New System.Text.StringBuilder()
                    Dim characterBytes As Byte() = _
                        Encoding.UTF8.GetBytes(c.ToString())
                    For Each b As Byte In characterBytes
                        buf.AppendFormat("%{0:X2}", b)
                    Next
                    encodedString.Append(buf.ToString())
                End If
            Next
            Return encodedString.ToString
        End Function
    End Module

End Namespace
