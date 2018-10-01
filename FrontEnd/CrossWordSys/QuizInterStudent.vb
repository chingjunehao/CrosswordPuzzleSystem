Imports System.Net
Imports System.IO
Imports System.Linq
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class QuizInterStudent
    Dim Result
    Dim Score
    Dim quizid As New List(Of String)()

    Private Sub GenerateQuiz(QuizNumber As Integer)
        Const ObjectYIncre As Integer = 83

        For i = 0 To QuizNumber - 1
            quizid.Add(Result(i)("id"))
            'Group box
            Dim quizBox = New System.Windows.Forms.GroupBox()
            Me.Panel1.Controls.Add(quizBox)
            quizBox.ForeColor = System.Drawing.Color.White
            quizBox.Location = New System.Drawing.Point(6, 3 + ObjectYIncre * i)
            quizBox.Name = "quizbox-" + CStr(i)
            quizBox.Size = New System.Drawing.Size(574, 83)
            quizBox.Text = "Quiz #" + CStr(i + 1)
            'start button
            Dim startBtn = New System.Windows.Forms.Button()
            quizBox.Controls.Add(startBtn)
            startBtn.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            startBtn.ForeColor = System.Drawing.Color.Gray
            startBtn.Location = New System.Drawing.Point(429, 2)
            startBtn.Name = "start-" + CStr(i)
            startBtn.Size = New System.Drawing.Size(140, 32)
            startBtn.Text = "Start Quiz"
            startBtn.UseVisualStyleBackColor = True
            AddHandler startBtn.Click, AddressOf StartQuiz
            'total score label
            Dim totalLabel = New System.Windows.Forms.Label()
            quizBox.Controls.Add(totalLabel)
            totalLabel.BackColor = System.Drawing.Color.Gainsboro
            totalLabel.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            totalLabel.ForeColor = System.Drawing.Color.Gray
            totalLabel.Location = New System.Drawing.Point(6, 35)
            totalLabel.Name = "ttlscore-" + CStr(i)
            totalLabel.Size = New System.Drawing.Size(177, 35)
            totalLabel.Text = "Total Score"
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

            Dim tempScore As Integer = 0
            For n = 0 To Score.Count() - 1
                If (Score(n)("questId") = Result(i)("id")) And (Score(n)("studentId") = MainFrame.UserSpecialID) Then
                    tempScore = Score(n)("score")
                End If
            Next

            scoreLabel.Text = tempScore
            scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub QuizInterStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        avatar_picbox.Image = avatar_picbox.InitialImage
        Call UpdateData()
    End Sub

    Private Sub UpdateData()
        Result = MainFrame.GetJSON(MainFrame.UniversalLink + "api/question-classId/" + CStr(MainFrame.ClassID))("data")
        Score = MainFrame.GetJSON(MainFrame.UniversalLink + "api/results")("data")
        subtitle_lbl.Text = MainFrame.GetJSON(MainFrame.UniversalLink + "api/class/" + CStr(MainFrame.ClassID))("data")(0)("classname")

        Dim Count As Integer = 0
        Dim tempAvg As Integer = 0
        For n = 0 To Score.Count() - 1
            If (Score(n)("studentId") = MainFrame.UserSpecialID) Then
                tempAvg += Score(n)("score")
                Count += 1
            End If
        Next

        average_lbl.Text = CStr(tempAvg / Count)
        GenerateQuiz(Result.Count)
    End Sub

    Private Sub StartQuiz(sender As Object, e As EventArgs)
        For i = 0 To quizid.Count() - 1
            If (DirectCast(sender, Button).Name = "start-" + CStr(i)) Then
                MainFrame.QuizID = quizid(i)
                Exit For
            End If
        Next
        Me.Dispose()
        CrossWordInter.Show()
    End Sub

    Private Sub GotoClass_Click(sender As Object, e As EventArgs) Handles classtab_cmd.Click
        ClassInterStudent.Show()
        Me.Dispose()
    End Sub

    Private Sub back_cmd_Click(sender As Object, e As EventArgs) Handles back_cmd.Click
        MainInterStudent.Show()
        Me.Dispose()
    End Sub

End Class