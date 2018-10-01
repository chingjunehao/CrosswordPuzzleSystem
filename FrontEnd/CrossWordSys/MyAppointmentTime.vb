Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Linq
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class MyAppointmentTime
    Dim Result
    Dim dateList As New List(Of String)()

    Private Sub GenerateTime(TimeNumber As Integer)
        Const ObjectYIncre As Integer = 35

        For i = 0 To TimeNumber - 1
            'Yeah you
            Dim timeLabel = New System.Windows.Forms.Label()
            Me.Panel1.Controls.Add(timeLabel)
            timeLabel.BackColor = System.Drawing.Color.Silver
            timeLabel.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            timeLabel.ForeColor = System.Drawing.Color.DimGray
            timeLabel.Location = New System.Drawing.Point(3, 5 + ObjectYIncre * i)
            timeLabel.Name = "datetime-" + CStr(i)
            timeLabel.Size = New System.Drawing.Size(300, 30)
            timeLabel.Text = dateList(i)
            timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Next
    End Sub

    Private Sub UpdateData()
        Me.Panel1.Controls.Clear()
        dateList.Clear()
        Result = MainFrame.GetJSON(MainFrame.UniversalLink + "api/appointment")("data")
        For i = 0 To Result.Count() - 1
            If Not (Result(i)("studentId").ToString() = "") Then
                Continue For
            End If
            If (Result(i)("teacherId") = MainFrame.UserSpecialID) Then
                dateList.Add(Result(i)("appointmentdate"))
            End If
        Next
        GenerateTime(dateList.Count)
    End Sub

    Private Sub MyAppointmentTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateData()
    End Sub

    Private Sub addtime_cmd_Click(sender As Object, e As EventArgs) Handles addtime_cmd.Click
        Dim data = New JObject()
        data.Add("appointmenttitle", New JValue(""))
        data.Add("appointmentdesc", New JValue(""))
        data.Add("appointmentdate", New JValue(DateTimePicker1.Value.ToShortDateString()))
        data.Add("teacherId", New JValue(MainFrame.UserSpecialID))

        Dim en = Encoding.UTF8.GetBytes(data.ToString())
        Dim result_post = MainFrame.SendRequest(New Uri(MainFrame.UniversalLink + "api/appointment"), en, "application/json", "POST")
        Dim x = MsgBox("Date added!")
        Call UpdateData()
    End Sub
End Class