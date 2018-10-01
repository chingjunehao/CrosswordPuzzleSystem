Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Linq
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class MainFrame
    Public UserID As Integer
    Public UserSpecialID As Integer
    Public UserName As String
    Public ClassID As Integer
    Public QuizID As Integer
    Public UniversalLink As String = "https://thawing-headland-69427.herokuapp.com/"

    Public Function SendRequest(uri As Uri, jsonDataBytes As Byte(), contentType As String, method As String) As String
        Dim req As WebRequest = WebRequest.Create(uri)
        req.ContentType = contentType
        req.Method = method
        req.ContentLength = jsonDataBytes.Length

        Dim stream = req.GetRequestStream()
        stream.Write(jsonDataBytes, 0, jsonDataBytes.Length)
        stream.Close()

        Dim response = req.GetResponse().GetResponseStream()

        Dim reader As New StreamReader(response)
        Dim res = reader.ReadToEnd()
        reader.Close()
        response.Close()

        Return res
    End Function

    Public Function GetJSON(url As String)
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader

        Try
            request = DirectCast(WebRequest.Create(url), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()
            rawresp = "{data:" + rawresp + "}"

            Dim Result As JObject = JObject.Parse(rawresp)
            Return Result
        Catch e As Exception
            Return "Error"
        End Try
    End Function

    Private Sub MainFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ftext As String = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\.env")
        If (ftext = "NODE_ENV=production") Then
            UniversalLink = "https://thawing-headland-69427.herokuapp.com/"
        ElseIf (ftext = "NODE_ENV=development") Then
            UniversalLink = "http://localhost:5000/"
        End If

        Me.Hide()
        LoginPage.Show()
    End Sub
End Class