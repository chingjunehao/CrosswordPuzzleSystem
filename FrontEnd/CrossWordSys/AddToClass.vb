Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Linq
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class AddToClass
    Dim ClassList
    Dim StudentList
    Dim TeacherList

    Private Sub UpdateData()
        ClassList = MainFrame.GetJSON(MainFrame.UniversalLink + "api/class")("data")
        StudentList = MainFrame.GetJSON(MainFrame.UniversalLink + "api/student")("data")
        For i = 0 To ClassList.Count() - 1
            ComboBox1.Items.Add(ClassList(i)("classname"))
        Next
        For i = 0 To StudentList.Count() - 1
            ComboBox2.Items.Add(StudentList(i)("username"))
        Next
    End Sub

    Private Function GetStudentID(Name As String) As Integer
        For i = 0 To StudentList.Count() - 1
            If (StudentList(i)("username") = Name) Then
                Return StudentList(i)("id")
            End If
        Next
        Return -1
    End Function

    Private Function GetClassID(Name As String) As Integer
        For i = 0 To ClassList.Count() - 1
            If (ClassList(i)("classname") = Name) Then
                Return ClassList(i)("id")
            End If
        Next
        Return -1
    End Function

    Private Sub AddToClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call UpdateData()
    End Sub

    Private Sub createUser_Cmd_Click(sender As Object, e As EventArgs) Handles createUser_Cmd.Click
        Dim data = New JObject()
        Dim Temp = GetStudentID(ComboBox2.SelectedItem())
        data.Add("userId", New JValue(Temp))
        data.Add("classId", New JValue(GetClassID(ComboBox1.SelectedItem())))

        Dim en = Encoding.UTF8.GetBytes(data.ToString())
        Dim result_post = MainFrame.SendRequest(New Uri(MainFrame.UniversalLink + "api/classmember"), en, "application/json", "POST")
        Dim x = MsgBox("Student added!")
    End Sub
End Class