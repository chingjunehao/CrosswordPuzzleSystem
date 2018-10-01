Public Class PopUpTemplate
    Dim EXP_TITLES As List(Of String) = New List(Of String)
    Dim EXP_CONTENTS As List(Of String) = New List(Of String)

    Private Sub GenerateItem(titles As List(Of String), contents As List(Of String))
        If (titles.Count <> contents.Count) Then
            Dim x = MsgBox("Passing value error!")
            Exit Sub
        End If

        Dim ItemNumber As Integer = titles.Count
        Const ObjectYIncre As Integer = 85

        For i = 0 To ItemNumber - 1
            'Group box
            Dim itemBox = New System.Windows.Forms.GroupBox()
            Me.Controls.Add(itemBox)
            itemBox.Cursor = System.Windows.Forms.Cursors.Default
            itemBox.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            itemBox.ForeColor = System.Drawing.Color.White
            itemBox.Location = New System.Drawing.Point(12, 12 + ObjectYIncre * i)
            itemBox.Name = "item-" + CStr(i)
            itemBox.Size = New System.Drawing.Size(280, 85)
            itemBox.Text = titles(i)
            'Content
            Dim contentBox = New System.Windows.Forms.RichTextBox()
            itemBox.Controls.Add(contentBox)
            contentBox.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            contentBox.Location = New System.Drawing.Point(7, 29)
            contentBox.Name = "content-" + CStr(i)
            contentBox.Size = New System.Drawing.Size(267, 50)
            contentBox.Text = contents(i)
            AddHandler contentBox.GotFocus, AddressOf RTB_GotFocus
        Next
    End Sub

    Private Sub RTB_GotFocus(sender As Object, e As EventArgs)
        DirectCast(sender, RichTextBox).Enabled = False
        DirectCast(sender, RichTextBox).Enabled = True
    End Sub

    Public Sub GetValue(title As String, titles As List(Of String), contents As List(Of String))
        Me.Controls.Clear()
        Me.Text = title
        Call GenerateItem(titles, contents)
    End Sub

    Private Sub PopUpTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'EXP_TITLES.Add("Class: Mathematics")
        'EXP_TITLES.Add("Class: English Language")
        'EXP_TITLES.Add("Class: Chinese Language")
        'EXP_TITLES.Add("Class: Malay Language")
        'EXP_TITLES.Add("Class: Force Physics")
        'EXP_CONTENTS.Add("Lecturer: JuneSee" + vbCrLf + "Student number: 32")
        'EXP_CONTENTS.Add("Lecturer: JuneSee" + vbCrLf + "Student number: 20")
        'EXP_CONTENTS.Add("Lecturer: JuneSee" + vbCrLf + "Student number: 16")
        'EXP_CONTENTS.Add("Lecturer: JuneSee" + vbCrLf + "Student number: 45")
        'EXP_CONTENTS.Add("Lecturer: JuneSee" + vbCrLf + "Student number: 5")
        'Call GenerateItem(EXP_TITLES, EXP_CONTENTS)

    End Sub
End Class