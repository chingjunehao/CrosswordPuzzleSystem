Imports System.Net
Imports System.IO
Imports System.Linq
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class AppointmentInterStudent
    Dim Result
    Dim DateList As New List(Of String)()
    Dim TeacherList As New List(Of String)()
    Dim ClassList
    Dim LecturerList
    Dim lecturerDateList

    Private Sub GenerateAppointment(AppNumber As Integer)
        Const ObjectYIncre As Integer = 111

        For i = 0 To AppNumber - 1
            'Group box
            Dim R = 0
            Dim G = 0
            Dim B = 0
            Dim appBox = New System.Windows.Forms.GroupBox()
            Me.Panel1.Controls.Add(appBox)
            appBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(R, Byte), Integer), CType(CType(G, Byte), Integer), CType(CType(B, Byte), Integer))
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
            lectLabel.Text = "Lecturer"
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
            'Lecturer content
            Dim lecContent = New System.Windows.Forms.Label()
            appBox.Controls.Add(lecContent)
            lecContent.BackColor = System.Drawing.Color.Silver
            lecContent.ForeColor = System.Drawing.Color.DimGray
            lecContent.Location = New System.Drawing.Point(132, 35)
            lecContent.Name = "lectname_" + CStr(i)
            lecContent.Size = New System.Drawing.Size(436, 30)
            lecContent.Text = TeacherList(i)
            lecContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.datetime_box.Items.Clear()
        DateList.Clear()
        TeacherList.Clear()
        Result = MainFrame.GetJSON(MainFrame.UniversalLink + "api/appointment")("data")
        For i = 0 To Result.Count() - 1
            If (Result(i)("studentId").ToString() = "") Then
                Continue For
            End If
            If (Result(i)("studentId") = MainFrame.UserSpecialID) Then
                DateList.Add(Result(i)("appointmentdate"))
                Dim TeacherName = MainFrame.GetJSON(MainFrame.UniversalLink + "api/teacher-info/" + CStr(Result(i)("teacherId")))("data")("username")
                TeacherList.Add(TeacherName)
            End If
        Next
        GenerateAppointment(DateList.Count())

        ClassList = MainFrame.GetJSON(MainFrame.UniversalLink + "api/classmember/" + CStr(MainFrame.UserID))("data")
        LecturerList = MainFrame.GetJSON(MainFrame.UniversalLink + "api/teacher")("data")
        For i = 0 To ClassList.Count() - 1
            For j = 0 To LecturerList.Count() - 1
                If (ClassList(i)("teacherId") = LecturerList(j)("id")) Then
                    lecturer_box.Items.Add(LecturerList(j)("username"))
                End If
            Next
        Next
    End Sub

    'Picking lecturer and load datetime
    Private Sub lecturer_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lecturer_box.SelectedIndexChanged
        Me.datetime_box.Items.Clear()
        Dim selectedID As String = ""
        For i = 0 To LecturerList.Count() - 1
            If (lecturer_box.SelectedItem() = LecturerList(i)("username")) Then
                selectedID = CStr(LecturerList(i)("id"))
            End If
        Next
        Dim realID = MainFrame.GetJSON(MainFrame.UniversalLink + "api/teacher/" + selectedID)("data")(0)("id")
        lecturerDateList = MainFrame.GetJSON(MainFrame.UniversalLink + "api/available-appointment/" + CStr(realID))("data")
        For i = 0 To lecturerDateList.Count() - 1
            Me.datetime_box.Items.Add(lecturerDateList(i)("appointmentdate"))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim data = New JObject()
        data.Add("userId", New JValue(MainFrame.UserSpecialID))
        Dim appID As String = ""
        For i = 0 To lecturerDateList.Count() - 1
            If (lecturerDateList(i)("appointmentdate") = datetime_box.SelectedItem()) Then
                appID = CStr(lecturerDateList(i)("id"))
            End If
        Next
        data.Add("appointmentId", New JValue(appID))

        Dim en = Encoding.UTF8.GetBytes(data.ToString())
        Dim result_post = MainFrame.SendRequest(New Uri(MainFrame.UniversalLink + "api/book-appointment"), en, "application/json", "POST")
        Dim x = MsgBox("Appointment booked!")
        Call UpdateData()
    End Sub

    Private Sub AppointmentInterStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        avatar_picbox.Image = avatar_picbox.InitialImage
        UpdateData()
    End Sub

    Private Sub refresh_lbl_Click(sender As Object, e As EventArgs) Handles refresh_lbl.Click
        UpdateData()
    End Sub

    Private Sub back_lbl_Click(sender As Object, e As EventArgs) Handles back_lbl.Click
        MainInterStudent.Show()
        Me.Dispose()
    End Sub
End Class