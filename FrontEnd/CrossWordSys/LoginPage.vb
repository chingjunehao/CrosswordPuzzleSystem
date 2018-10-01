Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Linq
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class LoginPage
   
    Private Sub exit_lbl_Click(sender As Object, e As EventArgs) Handles exit_lbl.Click
        MainFrame.Dispose()
    End Sub

    Private Sub submit_lbl_Click(sender As Object, e As EventArgs) Handles submit_lbl.Click
        Dim data = New JObject()
        data.Add("username", New JValue(loginid_txtbox.Text))
        data.Add("password", New JValue(password_txtbox.Text))
        Dim en = Encoding.UTF8.GetBytes(data.ToString())
        Dim Result As String = MainFrame.SendRequest(New Uri(MainFrame.UniversalLink + "api/user_login"), en, "application/json", "POST")
        Dim Valid As Boolean = False
        If Result.Equals("you are in") Then
            Valid = True
            MainFrame.UserName = loginid_txtbox.Text
        End If

        If (Valid = True) Then
            Dim userList = MainFrame.GetJSON(MainFrame.UniversalLink + "api/user")("data")
            Dim account_type As String = ""
            For i = 0 To userList.Count() - 1
                If (userList(i)("username") = (loginid_txtbox.Text)) Then
                    MainFrame.UserID = userList(i)("id")
                    account_type = MainFrame.GetJSON(MainFrame.UniversalLink + "api/user-type/" + CStr(MainFrame.UserID))("data")("userType")
                    If (account_type = "parent") Then
                        MainFrame.UserSpecialID = MainFrame.GetJSON(MainFrame.UniversalLink + "api/userid-parent/" + CStr(MainFrame.UserID))("data")(0)("id")
                    Else
                        Dim TempB = MainFrame.GetJSON(MainFrame.UniversalLink + "api/" + account_type + "/" + CStr(MainFrame.UserID))("data")
                        MainFrame.UserSpecialID = TempB(0)("id")
                    End If
                End If
            Next
            Select Case account_type
                Case "student"
                    MainInterStudent.Show()
                Case "teacher"
                    MainInterTeacher.Show()
                Case "parent"
                    MainInterParent.Show()
                Case "admin"
                    MainInterAdmin.Show()
            End Select
            Me.Dispose()
        Else
            Dim x = MsgBox("Username and password not match!")
        End If
    End Sub
End Class
