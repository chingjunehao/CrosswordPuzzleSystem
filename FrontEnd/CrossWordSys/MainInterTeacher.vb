Imports System.Net
Imports System.IO
Imports System.Linq
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class MainInterTeacher
    Dim ClassList

    Private Sub MainInterStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        avatar_picbox.Image = avatar_picbox.InitialImage
        Call UpdateData()
    End Sub

    Private Sub UpdateData()
        ClassList = MainFrame.GetJSON(MainFrame.UniversalLink + "api/class")("data")
        classroom_box.Items.Clear()
        For i = 0 To ClassList.Count() - 1
            If (ClassList(i)("teacherId") = MainFrame.UserID) Then
                classroom_box.Items.Add(ClassList(i)("classname"))
            End If
        Next

        subtitle_lbl.Text = "Welcome back, " + MainFrame.UserName + "!"
        Dim APPList = MainFrame.GetJSON(MainFrame.UniversalLink + "api/appointment")("data")
        Dim SmallestDate As Date = Nothing
        Dim StudentName As String = ""
        For i = 0 To APPList.Count() - 1
            If (APPList(i)("teacherId") = MainFrame.UserSpecialID) And Not (APPList(i)("studentId").ToString() = "") Then
                If (SmallestDate = Nothing) Then
                    StudentName = MainFrame.GetJSON(MainFrame.UniversalLink + "api/student-info/" + CStr(APPList(i)("studentId")))("data")("username")
                    SmallestDate = Date.ParseExact(APPList(i)("appointmentdate"), "dd/MM/yy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
                Else
                    If (SmallestDate > Date.ParseExact(APPList(i)("appointmentdate"), "dd/MM/yy", System.Globalization.DateTimeFormatInfo.InvariantInfo)) Then
                        SmallestDate = Date.ParseExact(APPList(i)("appointmentdate"), "dd/MM/yy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
                        StudentName = MainFrame.GetJSON(MainFrame.UniversalLink + "api/student-info/" + CStr(APPList(i)("studentId")))("data")("username")
                    End If
                End If
            End If
        Next
        student_lbl.Text = StudentName
        date_lbl.Text = SmallestDate.ToShortDateString()
    End Sub

    Private Sub enter_cmd_Click(sender As Object, e As EventArgs) Handles enter_cmd.Click
        If (classroom_box.SelectedItem() <> "") Then
            For i = 0 To ClassList.Count() - 1
                If (ClassList(i)("classname") = classroom_box.SelectedItem()) Then
                    MainFrame.ClassID = ClassList(i)("id")
                End If
            Next
            ClassInterTeacher.Show()
            Me.Dispose()
        End If
    End Sub
    Private Sub refresh_lbl_Click(sender As Object, e As EventArgs) Handles refresh_lbl.Click
        Call UpdateData()
    End Sub
    Private Sub exit_lbl_Click(sender As Object, e As EventArgs) Handles exit_lbl.Click
        quitmenu_ctx.Show(MousePosition)
    End Sub
    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click
        If sender.ToString = "Sign out" Then
            Me.Dispose()
            LoginPage.Show()
        ElseIf sender.ToString = "Exit" Then
            MainFrame.Dispose()
        End If
    End Sub

    Private Sub manager_cmd_Click(sender As Object, e As EventArgs) Handles manager_cmd.Click
        AppointmentInterTeacher.Show()
        Me.Hide()
    End Sub
End Class