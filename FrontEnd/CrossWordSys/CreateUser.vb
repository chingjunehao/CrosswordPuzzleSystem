Imports System.IO
Imports System.Text
Imports System.Linq
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class CreateUser
    Dim StudentJSON

    Private Sub UpdateData()
        StudentJSON = MainFrame.GetJSON(MainFrame.UniversalLink + "api/student")("data")
        For i = 0 To StudentJSON.Count() - 1
            student_box.Items.Add(StudentJSON(i)("username"))
        Next
    End Sub

    Private Sub CreateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call UpdateData()
    End Sub

    Private Function GetStudentID(Name As String) As Integer
        For i = 0 To StudentJSON.Count() - 1
            If (StudentJSON(i)("username") = Name) Then
                Dim TempR = MainFrame.GetJSON(MainFrame.UniversalLink + "api/student/" + CStr(StudentJSON(i)("id")))("data")
                Return TempR(0)("id")
            End If
        Next
        Return -1
    End Function

    Private Sub type_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles type_box.SelectedIndexChanged
        If (type_box.SelectedItem.ToString() = "Parent") Then
            student_box.Enabled = True
        Else
            student_box.Enabled = False
        End If
    End Sub

    Private Sub createUser_Cmd_Click(sender As Object, e As EventArgs) Handles createUser_Cmd.Click
        Dim data = New JObject()
        data.Add("username", New JValue(username_txt.Text))
        data.Add("password", New JValue(password_txt.Text))
        data.Add("email", New JValue(email_txt.Text))
        If (type_box.SelectedItem.ToString() = "Parent") Then
            data.Add("childrenId", New JValue(GetStudentID(student_box.SelectedItem)))
        End If

        Dim en = Encoding.UTF8.GetBytes(data.ToString())
        Dim result_post = MainFrame.SendRequest(New Uri(MainFrame.UniversalLink + "api/" + type_box.SelectedItem.ToString().ToLower()), en, "application/json", "POST")
        Dim x = MsgBox("User created!")

    End Sub
End Class