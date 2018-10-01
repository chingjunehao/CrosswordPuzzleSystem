Imports System.Net
Imports System.IO
Imports System.Linq
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class ClassInterTeacher
    Dim classPost As New List(Of GroupBox)()
    Dim classPostid As New List(Of String)()
    Dim commentTextBar As New List(Of RichTextBox)()
    Dim UserList
    Dim Result
    Dim Reply

    Private Sub GeneratePost(ReplyNumber As Integer)
        Dim index As Integer
        Dim startSize As Integer
        If classPost.Count <= 0 Then
            startSize = 3
            index = 0
        Else
            startSize = 3
            For i = 0 To classPost.Count - 1
                startSize += classPost.ElementAt(i).Size.Height
            Next
            index = classPost.Count
        End If
        Const commentBaseY As Integer = 224
        Const commentYIncre As Integer = 89
        '-----Main group box-----
        Dim newPostGrp = New System.Windows.Forms.GroupBox()
        Me.Panel1.Controls.Add(newPostGrp)
        newPostGrp.ForeColor = System.Drawing.Color.White
        newPostGrp.Location = New System.Drawing.Point(16, startSize)
        newPostGrp.Name = "post-" + CStr(index)
        newPostGrp.Size = New System.Drawing.Size(574, commentBaseY + commentYIncre * ReplyNumber + 6)
        newPostGrp.Text = Result(index)("posttitle")
        classPost.Add(newPostGrp)
        '=====
        'Main post area
        Dim newPost = New System.Windows.Forms.RichTextBox()
        newPostGrp.Controls.Add(newPost)
        newPost.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(95, Byte), Integer))
        newPost.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        newPost.ForeColor = System.Drawing.SystemColors.Window
        newPost.Location = New System.Drawing.Point(6, 32)
        newPost.Name = "text-" + CStr(index)
        newPost.Size = New System.Drawing.Size(562, 144)
        newPost.Text = Result(index)("postdescription")
        'Buttons
        'Post
        Dim newPostBtn = New System.Windows.Forms.Button()
        newPostGrp.Controls.Add(newPostBtn)
        newPostBtn.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        newPostBtn.ForeColor = System.Drawing.Color.Gray
        newPostBtn.Location = New System.Drawing.Point(428, 184)
        newPostBtn.Name = "send-" + CStr(index)
        newPostBtn.Size = New System.Drawing.Size(140, 39)
        newPostBtn.Text = "Post"
        newPostBtn.UseVisualStyleBackColor = True
        AddHandler newPostBtn.Click, AddressOf PostHandler
        'Comment Text bar
        Dim newCommentBox = New System.Windows.Forms.RichTextBox()
        newPostGrp.Controls.Add(newCommentBox)
        newCommentBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(95, Byte), Integer))
        newCommentBox.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        newCommentBox.ForeColor = System.Drawing.SystemColors.Window
        newCommentBox.Location = New System.Drawing.Point(6, 184)
        newCommentBox.Name = "comment-" + CStr(index)
        newCommentBox.Size = New System.Drawing.Size(416, 39)
        newCommentBox.TabIndex = 34
        newCommentBox.Text = ""
        commentTextBar.Add(newCommentBox)
        For i = 0 To ReplyNumber - 1
            'Comment box
            Dim newCommentGrp = New System.Windows.Forms.GroupBox()
            newPostGrp.Controls.Add(newCommentGrp)
            newCommentGrp.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
            newCommentGrp.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            newCommentGrp.ForeColor = System.Drawing.Color.White
            newCommentGrp.Location = New System.Drawing.Point(6, commentBaseY + commentYIncre * i)
            newCommentGrp.Name = "commentgrp-" + CStr(index) + "-" + CStr(i)
            newCommentGrp.Padding = New System.Windows.Forms.Padding(10)
            newCommentGrp.Size = New System.Drawing.Size(562, 89)

            Dim tempName As String = ""
            For k = 0 To UserList.Count() - 1
                If (UserList(k)("id") = Reply(i)("userId")) Then
                    tempName = UserList(k)("username")
                End If
            Next
            newCommentGrp.Text = tempName
            'The comment
            Dim newComment = New System.Windows.Forms.RichTextBox()
            newCommentGrp.Controls.Add(newComment)
            newComment.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(95, Byte), Integer))
            newComment.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            newComment.ForeColor = System.Drawing.SystemColors.Window
            newComment.Location = New System.Drawing.Point(13, 38)
            newComment.Name = "commenttxt-" + CStr(index) + "-" + CStr(i)
            newComment.Size = New System.Drawing.Size(536, 37)
            newComment.Text = Reply(i)("content")
        Next
    End Sub

    Public Sub UpdateData()
        Result = MainFrame.GetJSON(MainFrame.UniversalLink + "api/classpost/" + CStr(MainFrame.ClassID))("data")
        UserList = MainFrame.GetJSON(MainFrame.UniversalLink + "api/user")("data")

        classPost.Clear()
        classPostid.Clear()
        commentTextBar.Clear()
        Me.Panel1.Controls.Clear()
        subtitle_lbl.Text = MainFrame.GetJSON(MainFrame.UniversalLink + "api/class/" + CStr(MainFrame.ClassID))("data")(0)("classname")
        For i = 0 To Result.Count - 1
            classPostid.Add(Result(i)("id"))
            Reply = MainFrame.GetJSON(MainFrame.UniversalLink + "api/comment/" + CStr(Result(i)("id")))("data")
            GeneratePost(Reply.Count())
        Next
    End Sub

    Private Sub PostHandler(sender As Object, e As EventArgs)
        For i = 0 To classPost.Count() - 1
            If (DirectCast(sender, Button).Name = "send-" + CStr(i)) Then
                Dim data = New JObject()
                data.Add("contentText", commentTextBar(i).Text)
                data.Add("commentdate", Date.Today().ToString())
                data.Add("userId", MainFrame.UserID)
                data.Add("classpostId", classPostid(i))

                Dim en = Encoding.UTF8.GetBytes(data.ToString())
                Dim result_post = MainFrame.SendRequest(New Uri(MainFrame.UniversalLink + "api/comments"), en, "application/json", "POST")
                Dim x = MsgBox("Added comment!")
                Call UpdateData()
                Exit For
            End If
        Next
    End Sub

    Private Sub ClassInterTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        avatar_picbox.Image = avatar_picbox.InitialImage
        Call UpdateData()
    End Sub

    Private Sub GotoQuiz_Click(sender As Object, e As EventArgs) Handles quiztab_cmd.Click
        QuizInterTeacher.Show()
        Me.Dispose()
    End Sub

    Private Sub back_cmd_Click(sender As Object, e As EventArgs) Handles back_cmd.Click
        MainInterTeacher.Show()
        Me.Dispose()
    End Sub

    Private Sub CreateNewPost_Click(sender As Object, e As EventArgs) Handles newpost_cmd.Click
        WritePost.Show()
        Call UpdateData()
    End Sub
End Class