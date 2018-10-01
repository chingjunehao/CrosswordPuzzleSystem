Imports System.Net
Imports System.IO
Imports System.Linq
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class AppointmentInterTeacher
    Dim Result
    Dim StudentList As New List(Of String)()
    Dim DateList As New List(Of String)()

    Private Sub GenerateAppointment(AppNumber As Integer)
        Const ObjectYIncre As Integer = 111

        For i = 0 To AppNumber - 1
            'Group box
            Dim appBox = New System.Windows.Forms.GroupBox()
            Me.Panel1.Controls.Add(appBox)
            appBox.ForeColor = System.Drawing.Color.White
            appBox.Location = New System.Drawing.Point(6, 3 + ObjectYIncre * i)
            appBox.Name = "appbox-" + CStr(i)
            appBox.Size = New System.Drawing.Size(574, 111)
            appBox.Text = "#" + CStr(i + 1)

            'Lecturer label
            Dim lectLabel = New System.Windows.Forms.Label()
            appBox.Controls.Add(lectLabel)
            lectLabel.BackColor = System.Drawing.Color.Gainsboro
            lectLabel.ForeColor = System.Drawing.Color.Gray
            lectLabel.Location = New System.Drawing.Point(16, 35)
            lectLabel.Name = "leclbl-" + CStr(i)
            lectLabel.Size = New System.Drawing.Size(110, 30)
            lectLabel.Text = "Student"
            lectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            'Datetime label
            Dim dateLabel = New System.Windows.Forms.Label()
            appBox.Controls.Add(dateLabel)
            dateLabel.BackColor = System.Drawing.Color.Gainsboro
            dateLabel.ForeColor = System.Drawing.Color.Gray
            dateLabel.Location = New System.Drawing.Point(16, 70)
            dateLabel.Name = "datelbl-" + CStr(i)
            dateLabel.Size = New System.Drawing.Size(110, 30)
            dateLabel.Text = "Date Time"
            dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            'Student content
            Dim stuContent = New System.Windows.Forms.Label()
            appBox.Controls.Add(stuContent)
            stuContent.BackColor = System.Drawing.Color.Silver
            stuContent.ForeColor = System.Drawing.Color.DimGray
            stuContent.Location = New System.Drawing.Point(132, 35)
            stuContent.Name = "studname_" + CStr(i)
            stuContent.Size = New System.Drawing.Size(436, 30)
            stuContent.Text = StudentList(i)
            stuContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            'Datetime content
            Dim dateContent = New System.Windows.Forms.Label()
            appBox.Controls.Add(dateContent)
            dateContent.BackColor = System.Drawing.Color.Silver
            dateContent.ForeColor = System.Drawing.Color.DimGray
            dateContent.Location = New System.Drawing.Point(132, 70)
            dateContent.Name = "datetime_" + CStr(i)
            dateContent.Size = New System.Drawing.Size(436, 30)
            dateContent.Text = DateList(i)
            dateContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub UpdateData()
        Me.Panel1.Controls.Clear()
        StudentList.Clear()
        DateList.Clear()
        Result = MainFrame.GetJSON(MainFrame.UniversalLink + "api/appointment")("data")
        For i = 0 To Result.Count() - 1
            If (Result(i)("studentId").ToString() = "") Then
                Continue For
            End If
            If (Result(i)("teacherId") = MainFrame.UserSpecialID) Then
                DateList.Add(Result(i)("appointmentdate"))
                Dim StudentName = MainFrame.GetJSON(MainFrame.UniversalLink + "api/student-info/" + CStr(Result(i)("studentId")))("data")("username")
                StudentList.Add(StudentName)
            End If
        Next
        GenerateAppointment(DateList.Count())
    End Sub

    Private Sub AppointmentInterTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        avatar_picbox.Image = avatar_picbox.InitialImage
        UpdateData()
    End Sub

    Private Sub refresh_lbl_Click(sender As Object, e As EventArgs) Handles refresh_lbl.Click
        UpdateData()
    End Sub

    Private Sub back_lbl_Click(sender As Object, e As EventArgs) Handles back_lbl.Click
        MainInterTeacher.Show()
        Me.Dispose()
    End Sub

    Private Sub ShowMyTime(sender As Object, e As EventArgs) Handles MyTime_cmd.Click
        MyAppointmentTime.Show()
        UpdateData()
    End Sub
End Class