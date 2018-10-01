Imports System.Net
Imports System.IO
Imports System.Linq
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class CrossWordInter
    Dim puzzleAnswer As New List(Of List(Of Char))()
    Dim puzzleReply As New List(Of List(Of Char))()
    Dim puzzleOriginal As New List(Of List(Of Char))()
    Dim puzzleButton As New List(Of List(Of TextBox))()

    Private Sub GeneratePuzzle(puzzle As List(Of List(Of Char)))
        Const offset As Integer = 30
        Dim SizeY As Integer = puzzle.Count
        Me.Panel1.Controls.Clear()
        For i = 0 To SizeY - 1
            Dim SizeX As Integer = puzzle(i).Count
            Dim ButtonRow As New List(Of TextBox)()
            For j = 0 To SizeX - 1
                Dim puzzleBox = New System.Windows.Forms.TextBox()
                ButtonRow.Add(puzzleBox)

                puzzleBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                puzzleBox.Location = New System.Drawing.Point(3 + offset * j, 3 + offset * i)
                puzzleBox.MaxLength = 1
                puzzleBox.Name = CStr(i) + "-" + CStr(j)
                puzzleBox.Size = New System.Drawing.Size(27, 27)
                puzzleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
                If Not (puzzle(i)(j).Equals("#"c)) Then
                    Me.Panel1.Controls.Add(puzzleBox)
                    AddHandler puzzleBox.TextChanged, AddressOf FillInAnswer
                End If

                If Not (puzzle(i)(j).Equals("*"c)) Then
                    puzzleBox.Text = puzzle(i)(j)
                    puzzleBox.Enabled = False
                End If
            Next
            puzzleButton.Add(ButtonRow)
        Next
    End Sub

    Private Sub GenerateQuestion(questions As List(Of String))
        Dim questCount As Integer = questions.Count
        questbox_txt.Text = ""
        For i = 0 To questCount - 1
            questbox_txt.Text += questions(i) + vbCrLf + vbCrLf
        Next
    End Sub

    Sub ReadQuizFile(path As String)
        puzzleAnswer.Clear()
        puzzleReply.Clear()
        puzzleOriginal.Clear()
        puzzleButton.Clear()

        Dim ReadQuiz As Byte = 0
        Dim QuizQuest As New List(Of String)()

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(path)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    Dim QuizRow As New List(Of Char)()
                    Dim OriginalRow As New List(Of Char)()
                    For Each currentField In currentRow
                        '=====Read logic here=====
                        If (ReadQuiz < 2) Then
                            If currentField.Equals("~") Then
                                ReadQuiz += 1
                                Exit For
                            End If
                            QuizRow.Add(currentField)
                            OriginalRow.Add(currentField)
                        ElseIf (ReadQuiz = 2) Then
                            If currentField.Equals("") Then
                                Continue For
                            End If
                            QuizQuest.Add(currentField)
                        End If
                        '=========================
                    Next
                    If (ReadQuiz = 0) Then
                        puzzleReply.Add(QuizRow)
                        puzzleOriginal.Add(OriginalRow)
                    ElseIf (ReadQuiz = 1) Then
                        If (QuizRow.Count > 0) Then
                            puzzleAnswer.Add(QuizRow)
                        End If
                    End If

                Catch ex As Microsoft.VisualBasic.
                            FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using

        Call GeneratePuzzle(puzzleOriginal)
        Call GenerateQuestion(QuizQuest)

    End Sub

    Private Sub CrossWordInter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        avatar_picbox.Image = avatar_picbox.InitialImage
        subtitle_lbl.Text = "Cross Word Puzzle"
        Dim QuestFileName As String = MainFrame.GetJSON(MainFrame.UniversalLink + "api/question/" + CStr(MainFrame.QuizID))("data")(0)("questfilename")
        My.Computer.Network.DownloadFile(MainFrame.UniversalLink + "uploadQuestion/" + QuestFileName, My.Application.Info.DirectoryPath + "\Temp.csv")
        Call ReadQuizFile(My.Application.Info.DirectoryPath + "\Temp.csv")
    End Sub

    Private Sub FillInAnswer(sender As Object, e As EventArgs)
        For i = 0 To puzzleReply.Count - 1
            Dim Row As List(Of Char) = puzzleReply(i)
            For j = 0 To Row.Count - 1
                If (DirectCast(sender, TextBox).Name = CStr(i) + "-" + CStr(j)) Then
                    Row(j) = DirectCast(sender, TextBox).Text
                End If
            Next
        Next
    End Sub

    Private Sub back_cmd_Click(sender As Object, e As EventArgs) Handles back_cmd.Click
        My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "\Temp.csv")
        QuizInterStudent.Show()
        Me.Dispose()
    End Sub

    Private Sub submit_cmd_Click(sender As Object, e As EventArgs) Handles submit_cmd.Click
        Dim totalscore As Integer = 0
        Dim gainedscore As Integer = 0
        For i = 0 To puzzleReply.Count - 1
            Dim Row As List(Of Char) = puzzleReply(i)
            For j = 0 To Row.Count - 1
                If (puzzleAnswer(i)(j) = puzzleOriginal(i)(j)) Then
                    Continue For
                Else
                    totalscore += 1
                    If (puzzleAnswer(i)(j) = puzzleReply(i)(j)) Then
                        puzzleButton(i)(j).BackColor = Color.Lime
                        gainedscore += 1
                    Else
                        puzzleButton(i)(j).BackColor = Color.IndianRed
                    End If
                End If
            Next
        Next
        Me.Panel1.Enabled = False
        submit_cmd.Visible = False
        Dim finalScore As Integer = CInt((gainedscore / totalscore) * 100)

        Dim data = New JObject()
        data.Add("score", New JValue(finalScore))
        data.Add("timespent", New JValue(0))
        data.Add("questId", New JValue(MainFrame.QuizID))
        data.Add("studentId", New JValue(MainFrame.UserSpecialID))

        Dim en = Encoding.UTF8.GetBytes(data.ToString())
        Dim result_post = MainFrame.SendRequest(New Uri(MainFrame.UniversalLink + "api/results"), en, "application/json", "POST")
        Dim x = MsgBox("Quiz submitted!")

    End Sub

End Class