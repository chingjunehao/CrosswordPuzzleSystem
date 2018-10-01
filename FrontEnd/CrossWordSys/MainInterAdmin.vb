Public Class MainInterAdmin
    Dim ClassJSON
    Dim StudentJSON
    Dim ParentJSON
    Dim TeacherJSON
    'Loader
    Private Sub MainInterAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        avatar_picbox.Image = avatar_picbox.InitialImage
        Call UpdateData()

        AddHandler classnumber_lbl.Click, AddressOf ShowDetail
        AddHandler student_lbl.Click, AddressOf ShowDetail
        AddHandler teacher_lbl.Click, AddressOf ShowDetail
        AddHandler parent_lbl.Click, AddressOf ShowDetail

    End Sub

    'Update
    Private Sub UpdateData()
        ClassJSON = MainFrame.GetJSON(MainFrame.UniversalLink + "api/class")("data")
        StudentJSON = MainFrame.GetJSON(MainFrame.UniversalLink + "api/student")("data")
        ParentJSON = MainFrame.GetJSON(MainFrame.UniversalLink + "api/parent")("data")
        TeacherJSON = MainFrame.GetJSON(MainFrame.UniversalLink + "api/teacher")("data")

        subtitle_lbl.Text = "Welcome back, " + MainFrame.UserName + "!"
        classnumber_lbl.Text = CStr(ClassJSON.Count())
        student_lbl.Text = CStr(StudentJSON.Count())
        teacher_lbl.Text = CStr(TeacherJSON.Count())
        parent_lbl.Text = CStr(ParentJSON.Count())

    End Sub

    'Events
    Private Sub ShowDetail(sender As Object, e As EventArgs)
        Dim Subtitle As New List(Of String)
        Dim Contents As New List(Of String)
        Dim Title As String = ""

        If (DirectCast(sender, Label).Name = "classnumber_lbl") Then
            Title = "Class Data"
            For i = 0 To ClassJSON.Count() - 1
                Dim tempstr As String = ""
                Subtitle.Add(ClassJSON(i)("classname"))
                Dim lectName As String = ""
                For j = 0 To TeacherJSON.Count() - 1
                    If (TeacherJSON(j)("id") = ClassJSON(i)("teacherId")) Then
                        lectName = TeacherJSON(j)("username")
                    End If
                Next
                tempstr += "Lecturer: " + lectName
                Contents.Add(tempstr)
            Next
        ElseIf (DirectCast(sender, Label).Name = "student_lbl") Then
            Title = "Student Data"
            For i = 0 To StudentJSON.Count() - 1
                Dim tempstr As String = ""
                Dim Result = MainFrame.GetJSON("https://thawing-headland-69427.herokuapp.com/api/classmember/" + CStr(StudentJSON(i)("id")))
                Subtitle.Add(StudentJSON(i)("username"))
                tempstr += "Email: " + StudentJSON(i)("email") + vbCrLf
                tempstr += "Class number: " + CStr(Result.Count())
                Contents.Add(tempstr)
            Next
        ElseIf (DirectCast(sender, Label).Name = "teacher_lbl") Then
            Title = "Teacher Data"
            For i = 0 To TeacherJSON.Count() - 1
                Dim tempstr As String = ""
                Subtitle.Add(TeacherJSON(i)("username"))
                tempstr += "Email: " + TeacherJSON(i)("email") + vbCrLf
                Contents.Add(tempstr)
            Next
        ElseIf (DirectCast(sender, Label).Name = "parent_lbl") Then
            Title = "Teacher Data"
            For i = 0 To ParentJSON.Count() - 1
                Dim tempstr As String = ""
                Dim smallID As String = MainFrame.GetJSON("https://thawing-headland-69427.herokuapp.com/api/userid-parent/" + CStr(ParentJSON(i)("id")))("data")(0)("id").ToString()
                Dim studentName As String = MainFrame.GetJSON("https://thawing-headland-69427.herokuapp.com/api/parent-childreninfo/" + smallID)("data")(0)("username")
                Subtitle.Add(ParentJSON(i)("username"))
                tempstr += "Email: " + ParentJSON(i)("email") + vbCrLf
                tempstr += "Student: " + studentName
                Contents.Add(tempstr)
            Next
        End If

        PopUpTemplate.GetValue(Title, Subtitle, Contents)
        PopUpTemplate.Show()
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

    Private Sub createUser_cmd_Click(sender As Object, e As EventArgs) Handles createUser_cmd.Click
        CreateUser.Show()
    End Sub

    Private Sub createClass_cmd_Click(sender As Object, e As EventArgs) Handles createClass_Cmd.Click
        CreateClass.Show()
    End Sub

    Private Sub addClass_cmd_Click(sender As Object, e As EventArgs) Handles addClass_cmd.Click
        AddToClass.Show()
    End Sub
End Class