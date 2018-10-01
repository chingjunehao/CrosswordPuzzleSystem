<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainInterTeacher
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainInterTeacher))
        Me.main_canvas_lbl = New System.Windows.Forms.Label()
        Me.maincanvas_lbl = New System.Windows.Forms.Label()
        Me.subtitle_lbl = New System.Windows.Forms.Label()
        Me.exit_lbl = New System.Windows.Forms.Label()
        Me.quitmenu_ctx = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.avatarcanvas_lbl = New System.Windows.Forms.Label()
        Me.avatar_picbox = New System.Windows.Forms.PictureBox()
        Me.uptime_timer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.date_lbl = New System.Windows.Forms.Label()
        Me.student_lbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.manager_cmd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.enter_cmd = New System.Windows.Forms.Button()
        Me.classroom_box = New System.Windows.Forms.ComboBox()
        Me.refresh_lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.quitmenu_ctx.SuspendLayout()
        CType(Me.avatar_picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'main_canvas_lbl
        '
        Me.main_canvas_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.main_canvas_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.main_canvas_lbl.Location = New System.Drawing.Point(15, 20)
        Me.main_canvas_lbl.Margin = New System.Windows.Forms.Padding(32)
        Me.main_canvas_lbl.Name = "main_canvas_lbl"
        Me.main_canvas_lbl.Size = New System.Drawing.Size(768, 568)
        Me.main_canvas_lbl.TabIndex = 2
        '
        'maincanvas_lbl
        '
        Me.maincanvas_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.maincanvas_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.maincanvas_lbl.Location = New System.Drawing.Point(15, 20)
        Me.maincanvas_lbl.Margin = New System.Windows.Forms.Padding(32)
        Me.maincanvas_lbl.Name = "maincanvas_lbl"
        Me.maincanvas_lbl.Size = New System.Drawing.Size(768, 568)
        Me.maincanvas_lbl.TabIndex = 2
        '
        'subtitle_lbl
        '
        Me.subtitle_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.subtitle_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.subtitle_lbl.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtitle_lbl.ForeColor = System.Drawing.Color.White
        Me.subtitle_lbl.Location = New System.Drawing.Point(0, 0)
        Me.subtitle_lbl.Margin = New System.Windows.Forms.Padding(10)
        Me.subtitle_lbl.Name = "subtitle_lbl"
        Me.subtitle_lbl.Padding = New System.Windows.Forms.Padding(10)
        Me.subtitle_lbl.Size = New System.Drawing.Size(428, 70)
        Me.subtitle_lbl.TabIndex = 3
        Me.subtitle_lbl.Text = "Welcome back, <User>!"
        Me.subtitle_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'exit_lbl
        '
        Me.exit_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.exit_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.exit_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exit_lbl.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_lbl.ForeColor = System.Drawing.Color.White
        Me.exit_lbl.Location = New System.Drawing.Point(680, 130)
        Me.exit_lbl.Margin = New System.Windows.Forms.Padding(0)
        Me.exit_lbl.Name = "exit_lbl"
        Me.exit_lbl.Size = New System.Drawing.Size(120, 34)
        Me.exit_lbl.TabIndex = 14
        Me.exit_lbl.Text = "Quit"
        '
        'quitmenu_ctx
        '
        Me.quitmenu_ctx.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SignOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.quitmenu_ctx.Name = "quitmenu_ctx"
        Me.quitmenu_ctx.Size = New System.Drawing.Size(119, 48)
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SignOutToolStripMenuItem.Text = "Sign out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'avatarcanvas_lbl
        '
        Me.avatarcanvas_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.avatarcanvas_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.avatarcanvas_lbl.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.avatarcanvas_lbl.ForeColor = System.Drawing.Color.White
        Me.avatarcanvas_lbl.Location = New System.Drawing.Point(680, 0)
        Me.avatarcanvas_lbl.Margin = New System.Windows.Forms.Padding(10)
        Me.avatarcanvas_lbl.Name = "avatarcanvas_lbl"
        Me.avatarcanvas_lbl.Padding = New System.Windows.Forms.Padding(10)
        Me.avatarcanvas_lbl.Size = New System.Drawing.Size(120, 120)
        Me.avatarcanvas_lbl.TabIndex = 16
        Me.avatarcanvas_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'avatar_picbox
        '
        Me.avatar_picbox.InitialImage = CType(resources.GetObject("avatar_picbox.InitialImage"), System.Drawing.Image)
        Me.avatar_picbox.Location = New System.Drawing.Point(691, 10)
        Me.avatar_picbox.Name = "avatar_picbox"
        Me.avatar_picbox.Size = New System.Drawing.Size(100, 100)
        Me.avatar_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.avatar_picbox.TabIndex = 17
        Me.avatar_picbox.TabStop = False
        '
        'uptime_timer
        '
        Me.uptime_timer.Enabled = True
        Me.uptime_timer.Interval = 1000
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.manager_cmd)
        Me.GroupBox2.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(24, 278)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox2.Size = New System.Drawing.Size(636, 255)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Appointment manager"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.date_lbl)
        Me.GroupBox3.Controls.Add(Me.student_lbl)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(13, 90)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(610, 152)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Next appointment"
        '
        'date_lbl
        '
        Me.date_lbl.BackColor = System.Drawing.Color.Silver
        Me.date_lbl.ForeColor = System.Drawing.Color.DimGray
        Me.date_lbl.Location = New System.Drawing.Point(201, 92)
        Me.date_lbl.Name = "date_lbl"
        Me.date_lbl.Size = New System.Drawing.Size(403, 40)
        Me.date_lbl.TabIndex = 3
        Me.date_lbl.Text = "<Date and Time>"
        Me.date_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'student_lbl
        '
        Me.student_lbl.BackColor = System.Drawing.Color.Silver
        Me.student_lbl.ForeColor = System.Drawing.Color.DimGray
        Me.student_lbl.Location = New System.Drawing.Point(201, 45)
        Me.student_lbl.Name = "student_lbl"
        Me.student_lbl.Size = New System.Drawing.Size(403, 40)
        Me.student_lbl.TabIndex = 2
        Me.student_lbl.Text = "<Student Name>"
        Me.student_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(15, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 40)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Date Time"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(15, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 40)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Student Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'manager_cmd
        '
        Me.manager_cmd.ForeColor = System.Drawing.Color.Gray
        Me.manager_cmd.Location = New System.Drawing.Point(9, 45)
        Me.manager_cmd.Name = "manager_cmd"
        Me.manager_cmd.Size = New System.Drawing.Size(617, 39)
        Me.manager_cmd.TabIndex = 21
        Me.manager_cmd.Text = "Open manager"
        Me.manager_cmd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.enter_cmd)
        Me.GroupBox1.Controls.Add(Me.classroom_box)
        Me.GroupBox1.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(24, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Size = New System.Drawing.Size(636, 130)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "My classroom"
        '
        'enter_cmd
        '
        Me.enter_cmd.ForeColor = System.Drawing.Color.Gray
        Me.enter_cmd.Location = New System.Drawing.Point(9, 84)
        Me.enter_cmd.Name = "enter_cmd"
        Me.enter_cmd.Size = New System.Drawing.Size(617, 39)
        Me.enter_cmd.TabIndex = 21
        Me.enter_cmd.Text = "Enter"
        Me.enter_cmd.UseVisualStyleBackColor = True
        '
        'classroom_box
        '
        Me.classroom_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.classroom_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.classroom_box.Font = New System.Drawing.Font("Agency FB", 20.25!)
        Me.classroom_box.FormattingEnabled = True
        Me.classroom_box.Location = New System.Drawing.Point(9, 38)
        Me.classroom_box.Name = "classroom_box"
        Me.classroom_box.Size = New System.Drawing.Size(617, 40)
        Me.classroom_box.TabIndex = 20
        '
        'refresh_lbl
        '
        Me.refresh_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.refresh_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.refresh_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refresh_lbl.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_lbl.ForeColor = System.Drawing.Color.White
        Me.refresh_lbl.Location = New System.Drawing.Point(680, 172)
        Me.refresh_lbl.Margin = New System.Windows.Forms.Padding(0)
        Me.refresh_lbl.Name = "refresh_lbl"
        Me.refresh_lbl.Size = New System.Drawing.Size(120, 34)
        Me.refresh_lbl.TabIndex = 36
        Me.refresh_lbl.Text = "Refresh"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(10)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10)
        Me.Label1.Size = New System.Drawing.Size(636, 50)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "This is a lecturer account"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainInterTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.refresh_lbl)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.avatar_picbox)
        Me.Controls.Add(Me.avatarcanvas_lbl)
        Me.Controls.Add(Me.exit_lbl)
        Me.Controls.Add(Me.subtitle_lbl)
        Me.Controls.Add(Me.maincanvas_lbl)
        Me.Controls.Add(Me.main_canvas_lbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainInterTeacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentInterMain"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.quitmenu_ctx.ResumeLayout(False)
        CType(Me.avatar_picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main_canvas_lbl As System.Windows.Forms.Label
    Friend WithEvents maincanvas_lbl As System.Windows.Forms.Label
    Friend WithEvents subtitle_lbl As System.Windows.Forms.Label
    Friend WithEvents exit_lbl As System.Windows.Forms.Label
    Friend WithEvents quitmenu_ctx As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SignOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents avatarcanvas_lbl As System.Windows.Forms.Label
    Friend WithEvents avatar_picbox As System.Windows.Forms.PictureBox
    Friend WithEvents uptime_timer As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents date_lbl As System.Windows.Forms.Label
    Friend WithEvents student_lbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents manager_cmd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents enter_cmd As System.Windows.Forms.Button
    Friend WithEvents classroom_box As System.Windows.Forms.ComboBox
    Friend WithEvents refresh_lbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
