# FistTwit  
## Introduction  
A Twitter library that written in visual basic.  
It is easy to use this library.    
## How to use  
### Auth  
```vbnet
Imports FistTwit

Dim token As New OauthTokens() With {
	.ConsumerKey = "YOURCONSUMERKEY", _
	.ConsumerSecret = "YOURCONSUMERSECRET"}
Dim oa As OauthAccess = t.GetRequestToken()
Process.Start(a.GetAuthorizeUri.ToString())
token = oa.GetAccessToken(InputBox("PIN Code"))
```  
```csharp
using FistTwit;

OauthTokens token = new OauthTokens {
	ConsumerKey = "YOURCONSUMERKEY",
	ConsumerSecret = "YOURCONSUMERSECRET"
};
OauthAccess oa = t.GetRequestToken();
Process.Start(oa.GetAuthorizeUri().ToString());
token = oa.GetAccessToken(Interaction.InputBox("PIN Code"));
```  
### Post a tweet  
```vbnet
Imports FistTwit

Dim t As New OauthTokens() With {
	.ConsumerKey = "YOURCONSUMERKEY", _
	.ConsumerSecret = "YOURCONSUMERSECRET", _
	.AccessToken = "ACCESSTOKEN", _
	.AccessTokenSecret = "ACCESSTOKENSECRET"}
Dim r As New RequestParam From {
{"status", "test"}}
Dim o As ResponseObject(Of StatusObject) = t.Statuses.Update(r)
Console.WriteLine(o.Objects.Text) 'test
```  
```csharp
using FistTwit;

OauthTokens token = new OauthTokens {
	ConsumerKey = "YOURCONSUMERKEY",
	ConsumerSecret = "YOURCONSUMERSECRET",
	AccessToken = "ACCESSTOKEN",
	AccessTokenSecret = "ACCESSTOKENSECRET"};
RequestParam r = new RequestParam { {
	"status",
	"test"
} };
ResponseObject(Of StatusObject) = t.Statuses.Update(r);
Console.WriteLine(o.Objects.Tect) //test
```  
### Start UserStream  
```vbnet
Imports FistTwit
Imports FistTwit.TwitterStreaming

Dim t As New OauthTokens() With {
	.ConsumerKey = "YOURCONSUMERKEY", _
	.ConsumerSecret = "YOURCONSUMERSECRET", _
	.AccessToken = "ACCESSTOKEN", _
	.AccessTokenSecret = "ACCESSTOKENSECRET"}
       	Dim s As New Streaming(New Streaming.TwitterStreamCallbackCb(AddressOf testSub))
        s.StartStream(t, StreamingKind.User)

    Sub testSub(ByVal status As Object)
        Console.Write(status.GetType.Name) 'It will Show the type of streaming data
	'example how to use
	If status.GetType = GetType(StatusObject) Then ' Check Type
		Console.Write("text: " & status.Text)
	End If
    End Sub
```  
```csharp
using FistTwit;
using FistTwit.TwitterStreaming;

OauthTokens t = new OauthTokens {
	ConsumerKey = "YOURCONSUMERKEY",
	ConsumerSecret = "YOURCONSUMERSECRET",
	AccessToken = "ACCESSTOKEN",
	AccessTokenSecret = "ACCESSTOKENSECRET"
};
TwitterStreaming.Streaming s = new Streaming(new Streaming.TwitterStreamCallbackCb(testSub));
s.StartStream(t, StreamingKind.User);

public void testSub(object status)
{
	Console.Write(status.GetType.Name); //It will Show the type of streaming data
	//example how to use
	// Check Type
	if (status.GetType == typeof(StatusObject)) {
		Console.Write("text: " + status.Text);
	}
}
```  
###Use Async(.Net 4.5)  
```vbnet
Imports FistTwit
Imports FistTwit.Async

Public Async Sub TestAsync
	Dim t As New OauthTokens() With {
		.ConsumerKey = "YOURCONSUMERKEY", _
		.ConsumerSecret = "YOURCONSUMERSECRET", _
		.AccessToken = "ACCESSTOKEN", _
		.AccessTokenSecret = "ACCESSTOKENSECRET"}
	Dim at As New AsyncTokens(t)
	' For example
	Console.Write((Await at.Account.RateLimitStatus()).Objects.Resources.Account.Settings.Limit)
End Sub
