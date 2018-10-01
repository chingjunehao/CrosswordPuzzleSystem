Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Linq
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class WritePost

    Private Sub post_cmd_Click(sender As Object, e As EventArgs) Handles post_cmd.Click
        Dim data = New JObject()
        data.Add("posttitle", New JValue(title_txt.Text))
        data.Add("postdescription", New JValue(content_txt.Text))
        data.Add("postdate", New JValue(""))
        data.Add("userId", New JValue(MainFrame.UserID))
        data.Add("classId", New JValue(MainFrame.ClassID))

        Dim en = Encoding.UTF8.GetBytes(data.ToString())
        Dim result_post = MainFrame.SendRequest(New Uri(MainFrame.UniversalLink + "api/classpost"), en, "application/json", "POST")
        Dim x = MsgBox("Posted!")
        Me.Dispose()
        Call ClassInterTeacher.UpdateData()
    End Sub
End Class