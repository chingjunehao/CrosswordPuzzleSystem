<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.title_lbl = New System.Windows.Forms.Label()
        Me.maincanvas_lbl = New System.Windows.Forms.Label()
        Me.subtitle_lbl = New System.Windows.Forms.Label()
        Me.version_lbl = New System.Windows.Forms.Label()
        Me.loginid_txtbox = New System.Windows.Forms.TextBox()
        Me.loginid_lbl = New System.Windows.Forms.Label()
        Me.password_lbl = New System.Windows.Forms.Label()
        Me.password_txtbox = New System.Windows.Forms.TextBox()
        Me.submit_lbl = New System.Windows.Forms.Label()
        Me.login_canvas_lbl = New System.Windows.Forms.Label()
        Me.exit_lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'title_lbl
        '
        Me.title_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.title_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.title_lbl.Font = New System.Drawing.Font("Agency FB", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title_lbl.ForeColor = System.Drawing.Color.White
        Me.title_lbl.Location = New System.Drawing.Point(31, 9)
        Me.title_lbl.Margin = New System.Windows.Forms.Padding(0)
        Me.title_lbl.Name = "title_lbl"
        Me.title_lbl.Size = New System.Drawing.Size(341, 65)
        Me.title_lbl.TabIndex = 0
        Me.title_lbl.Text = "CrossWord System"
        '
        'maincanvas_lbl
        '
        Me.maincanvas_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.maincanvas_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.maincanvas_lbl.Location = New System.Drawing.Point(63, 41)
        Me.maincanvas_lbl.Margin = New System.Windows.Forms.Padding(32)
        Me.maincanvas_lbl.Name = "maincanvas_lbl"
        Me.maincanvas_lbl.Size = New System.Drawing.Size(452, 518)
        Me.maincanvas_lbl.TabIndex = 1
        '
        'subtitle_lbl
        '
        Me.subtitle_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.subtitle_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.subtitle_lbl.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtitle_lbl.ForeColor = System.Drawing.Color.White
        Me.subtitle_lbl.Location = New System.Drawing.Point(74, 144)
        Me.subtitle_lbl.Margin = New System.Windows.Forms.Padding(10)
        Me.subtitle_lbl.Name = "subtitle_lbl"
        Me.subtitle_lbl.Padding = New System.Windows.Forms.Padding(10)
        Me.subtitle_lbl.Size = New System.Drawing.Size(428, 70)
        Me.subtitle_lbl.TabIndex = 2
        Me.subtitle_lbl.Text = "Login"
        Me.subtitle_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'version_lbl
        '
        Me.version_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.version_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.version_lbl.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version_lbl.ForeColor = System.Drawing.Color.White
        Me.version_lbl.Location = New System.Drawing.Point(76, 84)
        Me.version_lbl.Margin = New System.Windows.Forms.Padding(10)
        Me.version_lbl.Name = "version_lbl"
        Me.version_lbl.Size = New System.Drawing.Size(296, 40)
        Me.version_lbl.TabIndex = 3
        Me.version_lbl.Text = "Version 1.0.0"
        '
        'loginid_txtbox
        '
        Me.loginid_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loginid_txtbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.loginid_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.loginid_txtbox.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginid_txtbox.ForeColor = System.Drawing.Color.White
        Me.loginid_txtbox.Location = New System.Drawing.Point(223, 249)
        Me.loginid_txtbox.Name = "loginid_txtbox"
        Me.loginid_txtbox.Size = New System.Drawing.Size(279, 39)
        Me.loginid_txtbox.TabIndex = 6
        '
        'loginid_lbl
        '
        Me.loginid_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.loginid_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.loginid_lbl.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginid_lbl.ForeColor = System.Drawing.Color.White
        Me.loginid_lbl.Location = New System.Drawing.Point(74, 249)
        Me.loginid_lbl.Margin = New System.Windows.Forms.Padding(10)
        Me.loginid_lbl.Name = "loginid_lbl"
        Me.loginid_lbl.Size = New System.Drawing.Size(147, 39)
        Me.loginid_lbl.TabIndex = 7
        Me.loginid_lbl.Text = "Login ID: "
        Me.loginid_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'password_lbl
        '
        Me.password_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.password_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.password_lbl.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_lbl.ForeColor = System.Drawing.Color.White
        Me.password_lbl.Location = New System.Drawing.Point(76, 308)
        Me.password_lbl.Margin = New System.Windows.Forms.Padding(10)
        Me.password_lbl.Name = "password_lbl"
        Me.password_lbl.Size = New System.Drawing.Size(145, 39)
        Me.password_lbl.TabIndex = 8
        Me.password_lbl.Text = "Password:"
        Me.password_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'password_txtbox
        '
        Me.password_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.password_txtbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.password_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.password_txtbox.Font = New System.Drawing.Font("Agency FB", 20.25!)
        Me.password_txtbox.ForeColor = System.Drawing.Color.Silver
        Me.password_txtbox.Location = New System.Drawing.Point(223, 308)
        Me.password_txtbox.Name = "password_txtbox"
        Me.password_txtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txtbox.Size = New System.Drawing.Size(279, 39)
        Me.password_txtbox.TabIndex = 9
        '
        'submit_lbl
        '
        Me.submit_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.submit_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.submit_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submit_lbl.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit_lbl.ForeColor = System.Drawing.Color.White
        Me.submit_lbl.Location = New System.Drawing.Point(339, 506)
        Me.submit_lbl.Margin = New System.Windows.Forms.Padding(0)
        Me.submit_lbl.Name = "submit_lbl"
        Me.submit_lbl.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.submit_lbl.Size = New System.Drawing.Size(145, 65)
        Me.submit_lbl.TabIndex = 10
        Me.submit_lbl.Text = "Submit"
        Me.submit_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'login_canvas_lbl
        '
        Me.login_canvas_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.login_canvas_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.login_canvas_lbl.Font = New System.Drawing.Font("Agency FB", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_canvas_lbl.ForeColor = System.Drawing.Color.White
        Me.login_canvas_lbl.Location = New System.Drawing.Point(85, 190)
        Me.login_canvas_lbl.Margin = New System.Windows.Forms.Padding(10)
        Me.login_canvas_lbl.Name = "login_canvas_lbl"
        Me.login_canvas_lbl.Padding = New System.Windows.Forms.Padding(10)
        Me.login_canvas_lbl.Size = New System.Drawing.Size(408, 391)
        Me.login_canvas_lbl.TabIndex = 12
        '
        'exit_lbl
        '
        Me.exit_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.exit_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.exit_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exit_lbl.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_lbl.ForeColor = System.Drawing.Color.White
        Me.exit_lbl.Location = New System.Drawing.Point(433, 53)
        Me.exit_lbl.Margin = New System.Windows.Forms.Padding(0)
        Me.exit_lbl.Name = "exit_lbl"
        Me.exit_lbl.Size = New System.Drawing.Size(69, 34)
        Me.exit_lbl.TabIndex = 13
        Me.exit_lbl.Text = "Exit"
        '
        'LoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(600, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.exit_lbl)
        Me.Controls.Add(Me.subtitle_lbl)
        Me.Controls.Add(Me.submit_lbl)
        Me.Controls.Add(Me.password_txtbox)
        Me.Controls.Add(Me.loginid_txtbox)
        Me.Controls.Add(Me.password_lbl)
        Me.Controls.Add(Me.loginid_lbl)
        Me.Controls.Add(Me.login_canvas_lbl)
        Me.Controls.Add(Me.version_lbl)
        Me.Controls.Add(Me.title_lbl)
        Me.Controls.Add(Me.maincanvas_lbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login - CrossWordSys"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title_lbl As System.Windows.Forms.Label
    Friend WithEvents maincanvas_lbl As System.Windows.Forms.Label
    Friend WithEvents subtitle_lbl As System.Windows.Forms.Label
    Friend WithEvents version_lbl As System.Windows.Forms.Label
    Friend WithEvents loginid_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents loginid_lbl As System.Windows.Forms.Label
    Friend WithEvents password_lbl As System.Windows.Forms.Label
    Friend WithEvents password_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents submit_lbl As System.Windows.Forms.Label
    Friend WithEvents login_canvas_lbl As System.Windows.Forms.Label
    Friend WithEvents exit_lbl As System.Windows.Forms.Label

End Class
