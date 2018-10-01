Public Class MainInterTemplate
    Dim logintime As DateTime

    Private Sub exit_lbl_Click(sender As Object, e As EventArgs) Handles exit_lbl.Click
        quitmenu_ctx.Show(MousePosition)
    End Sub

    Private Sub StudentInterMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        avatar_picbox.Image = avatar_picbox.InitialImage
        logintime = DateTime.Now
    End Sub

    Private Sub uptime_timer_Tick(sender As Object, e As EventArgs) Handles uptime_timer.Tick
        'Time flows
        Dim uptime_time() As Short = {(DateTime.Now - logintime).Hours,
                                      (DateTime.Now - logintime).Minutes,
                                      (DateTime.Now - logintime).Seconds}

        Dim uptime_message As String = ""
        For Each n In uptime_time
            If n < 10 Then
                uptime_message += "0" + CStr(n)
            Else
                uptime_message += CStr(n)
            End If
            uptime_message += ":"
        Next

        uptime_lbl.Text = "Uptime: " + uptime_message.Substring(0, uptime_message.Length - 1)
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