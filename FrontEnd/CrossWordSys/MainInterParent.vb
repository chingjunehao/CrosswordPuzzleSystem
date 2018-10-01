Public Class MainInterParent
    Dim Result
    Dim Score
    Dim ClassID
    Dim StudentInfo
    Dim StudentID
    Dim StudentSpecialID
    Dim ClassList

    Private Sub MainInterParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        avatar_picbox.Image = avatar_picbox.InitialImage
        Call UpdateData()
    End Sub

    Private Sub UpdateData()
        StudentInfo = MainFrame.GetJSON(MainFrame.UniversalLink + "api/parent-childreninfo/" + CStr(MainFrame.UserSpecialID))("data")(0)
        Score = MainFrame.GetJSON(MainFrame.UniversalLink + "api/results")("data")
        StudentID = StudentInfo("id")
        StudentSpecialID = MainFrame.GetJSON(MainFrame.UniversalLink + "api/student/" + CStr(StudentID))("data")(0)("id")
        ClassList = MainFrame.GetJSON(MainFrame.UniversalLink + "api/classmember/" + CStr(StudentID))("data")
        classroom_box.Items.Clear()
        For i = 0 To ClassList.Count() - 1
            classroom_box.Items.Add(ClassList(i)("classname"))
        Next

        subtitle_lbl.Text = "Welcome back, " + MainFrame.UserName + "!"
        student_lbl.Text = StudentInfo("username")
    End Sub

    Private Sub classroom_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles classroom_box.SelectedIndexChanged
        Dim ScoreAvg As Integer = 0
        Dim Count As Integer = 0
        For i = 0 To ClassList.Count() - 1
            If (ClassList(i)("classname") = classroom_box.SelectedItem()) Then
                Dim tempClassID = ClassList(i)("id")
                Dim QuestInClass = MainFrame.GetJSON(MainFrame.UniversalLink + "api/question-classId/" + CStr(tempClassID))("data")
                For n = 0 To QuestInClass.Count() - 1
                    For m = 0 To Score.Count() - 1
                        If (QuestInClass(n)("id") = Score(m)("questId")) And (StudentSpecialID = Score(m)("studentId")) Then
                            ScoreAvg += Score(m)("score")
                            Count += 1
                        End If
                    Next
                Next
            End If
        Next
        score_lbl.Text = ScoreAvg / Count
    End Sub

    Private Sub ShowDetail_Click(sender As Object, e As EventArgs) Handles showdetails_cmd.Click
        If Not (classroom_box.SelectedItem() = "") Then
            Dim Subtitle As New List(Of String)
            Dim Contents As New List(Of String)
            Dim Title As String
            Dim Count As Integer = 1
            Title = "All result in " + classroom_box.SelectedItem()
            For i = 0 To ClassList.Count() - 1
                If (ClassList(i)("classname") = classroom_box.SelectedItem()) Then
                    Dim tempClassID = ClassList(i)("id")
                    Dim QuestInClass = MainFrame.GetJSON(MainFrame.UniversalLink + "api/question-classId/" + CStr(tempClassID))("data")
                    For n = 0 To QuestInClass.Count() - 1
                        For m = 0 To Score.Count() - 1
                            If (QuestInClass(n)("id") = Score(m)("questId")) And (StudentSpecialID = Score(m)("studentId")) Then
                                Subtitle.Add("Quiz #" + CStr(Count))
                                Contents.Add("Score: " + CStr(Score(m)("score")))
                                Count += 1
                            End If
                        Next
                    Next
                End If
            Next
            PopUpTemplate.GetValue(Title, Subtitle, Contents)
            PopUpTemplate.Show()
        End If
    End Sub

    'Event
    Private Sub refresh_lbl_click(sender As Object, e As EventArgs) Handles refresh_lbl.Click
        UpdateData()
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

End Class