Imports System.Net
Imports System.IO
Imports System.Linq
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class QuizInterTeacher
    Dim Result
    Dim Score
    Dim quizid As New List(Of String)()

    Private Sub GenerateQuiz(QuizNumber As Integer)
        Const ObjectYIncre As Integer = 83

        For i = 0 To QuizNumber - 1
            'Group box
            quizid.Add(Result(i)("id"))
            Dim quizBox = New System.Windows.Forms.GroupBox()
            Me.Panel1.Controls.Add(quizBox)
            quizBox.ForeColor = System.Drawing.Color.White
            quizBox.Location = New System.Drawing.Point(6, 3 + ObjectYIncre * i)
            quizBox.Name = "quizbox-" + CStr(i)
            quizBox.Size = New System.Drawing.Size(574, 83)
            quizBox.Text = "Quiz #" + CStr(i + 1)
            'Show Button
            Dim showBtn = New System.Windows.Forms.Button()
            quizBox.Controls.Add(showBtn)
            showBtn.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            showBtn.ForeColor = System.Drawing.Color.Gray
            showBtn.Location = New System.Drawing.Point(469, 0)
            showBtn.Name = "show-" + CStr(i)
            showBtn.Size = New System.Drawing.Size(100, 32)
            showBtn.Text = "Show Result"
            showBtn.UseVisualStyleBackColor = True
            AddHandler showBtn.Click, AddressOf ShowDetail
            'total score label
            Dim totalLabel = New System.Windows.Forms.Label()
            quizBox.Controls.Add(totalLabel)
            totalLabel.BackColor = System.Drawing.Color.Gainsboro
            totalLabel.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            totalLabel.ForeColor = System.Drawing.Color.Gray
            totalLabel.Location = New System.Drawing.Point(6, 35)
            totalLabel.Name = "ttlscore-" + CStr(i)
            totalLabel.Size = New System.Drawing.Size(177, 35)
            totalLabel.Text = "Average Score"
            totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            'score label
            Dim scoreLabel = New System.Windows.Forms.Label()
            quizBox.Controls.Add(scoreLabel)
            scoreLabel.BackColor = System.Drawing.Color.Silver
            scoreLabel.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            scoreLabel.ForeColor = System.Drawing.Color.DimGray
            scoreLabel.Location = New System.Drawing.Point(189, 35)
            scoreLabel.Name = "score-" + CStr(i)
            scoreLabel.Size = New System.Drawing.Size(379, 35)

            Dim Count As Integer = 0
            Dim tempScore As Integer = 0
            For n = 0 To Score.Count() - 1
                If (Score(n)("questId") = Result(i)("id")) Then
                    tempScore += Score(n)("score")
                    Count += 1
                End If
            Next

            scoreLabel.Text = CStr(tempScore / Count)
            scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub QuizInterTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        avatar_picbox.Image = avatar_picbox.InitialImage
        Call UpdateData()
    End Sub

    Private Sub UpdateData()
        Result = MainFrame.GetJSON(MainFrame.UniversalLink + "api/question-classId/" + CStr(MainFrame.ClassID))("data")
        Score = MainFrame.GetJSON(MainFrame.UniversalLink + "api/results")("data")
        subtitle_lbl.Text = MainFrame.GetJSON(MainFrame.UniversalLink + "api/class/" + CStr(MainFrame.ClassID))("data")(0)("classname")

        Dim Count As Integer = 0
        Dim tempAvg As Integer = 0
        For n = 0 To Result.Count() - 1
            For m = 0 To Score.Count() - 1
                If (Result(n)("id") = Score(m)("questId")) Then
                    tempAvg += Score(m)("score")
                    Count += 1
                End If
            Next
        Next

        average_lbl.Text = CStr(tempAvg / Count)
        GenerateQuiz(Result.Count)
    End Sub

    Private Sub ShowDetail(sender As Object, e As EventArgs)
        Dim Subtitle As New List(Of String)
        Dim Contents As New List(Of String)
        Dim Title As String = ""

        For i = 0 To quizid.Count - 1
            If (DirectCast(sender, Button).Name = "show-" + CStr(i)) Then
                For m = 0 To Score.Count() - 1
                    If (Score(m)("questId") = quizid(i)) Then
                        Dim tempName = MainFrame.GetJSON(MainFrame.UniversalLink + "api/student-info/" + CStr(Score(m)("studentId")))("data")("username")
                        Subtitle.Add(tempName)
                        Contents.Add("Score: " + CStr(Score(m)("score")))
                    End If
                Next
                Title = "Result of quiz: " + CStr(quizid(i))
            End If
        Next

        PopUpTemplate.GetValue(Title, Subtitle, Contents)
        PopUpTemplate.Show()
        Me.UpdateData()
    End Sub

    Private Sub GotoClass_Click(sender As Object, e As EventArgs) Handles classtab_cmd.Click
        ClassInterTeacher.Show()
        Me.Dispose()
    End Sub

    Private Sub back_cmd_Click(sender As Object, e As EventArgs) Handles back_cmd.Click
        MainInterTeacher.Show()
        Me.Hide()
    End Sub

    Private Sub uploadquiz_cmd_Click(sender As Object, e As EventArgs) Handles uploadquiz_cmd.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim filepath As String = OpenFileDialog1.FileName()
        Dim fileReader As String = My.Computer.FileSystem.ReadAllText(filepath)
        Dim data = New JObject()
        data.Add("csv", New JValue(fileReader))
        data.Add("teacherId", New JValue(MainFrame.UserID))
        data.Add("classId", New JValue(MainFrame.ClassID))
        data.Add("subjectId", New JValue(1))
        Dim a = MsgBox(data.ToString())
        Dim en = Encoding.UTF8.GetBytes(data.ToString())
        Dim result_post = MainFrame.SendRequest(New Uri(MainFrame.UniversalLink + "api/question"), en, "application/json", "POST")
        Dim x = MsgBox("Quiz uploaded!")
        Call UpdateData()
    End Sub
End Class