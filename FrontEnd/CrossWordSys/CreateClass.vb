Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Linq
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class CreateClass
    Dim lectList

    Private Sub UpdateData()
        lectList = MainFrame.GetJSON(MainFrame.UniversalLink + "api/teacher")("data")
        For i = 0 To lectList.Count() - 1
            lecturer_box.Items.Add(lectList(i)("username"))
        Next
    End Sub

    Private Sub CreateClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call UpdateData()
    End Sub

    Private Function GetTeacherID(Name As String) As Integer
        For i = 0 To lectList.Count() - 1
            If (lectList(i)("username") = Name) Then
                Return lectList(i)("id")
            End If
        Next
        Return -1
    End Function

    Private Sub createUser_Cmd_Click(sender As Object, e As EventArgs) Handles createUser_Cmd.Click
        Dim data = New JObject()
        data.Add("className", New JValue(classname_txt.Text))
        data.Add("teacherId", New JValue(GetTeacherID(lecturer_box.SelectedItem())))

        Dim en = Encoding.UTF8.GetBytes(data.ToString())
        Dim result_post = MainFrame.SendRequest(New Uri(MainFrame.UniversalLink + "api/class"), en, "application/json", "POST")
        Dim x = MsgBox("Class created!")
    End Sub
End Class