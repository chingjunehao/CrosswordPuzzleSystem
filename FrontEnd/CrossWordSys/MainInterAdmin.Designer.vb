<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainInterAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainInterAdmin))
        Me.main_canvas_lbl = New System.Windows.Forms.Label()
        Me.maincanvas_lbl = New System.Windows.Forms.Label()
        Me.subtitle_lbl = New System.Windows.Forms.Label()
        Me.exit_lbl = New System.Windows.Forms.Label()
        Me.quitmenu_ctx = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.avatarcanvas_lbl = New System.Windows.Forms.Label()
        Me.avatar_picbox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.createClass_Cmd = New System.Windows.Forms.Button()
        Me.createUser_cmd = New System.Windows.Forms.Button()
        Me.addClass_cmd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.parent_lbl = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.teacher_lbl = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.student_lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.classnumber_lbl = New System.Windows.Forms.Label()
        Me.refresh_lbl = New System.Windows.Forms.Label()
        Me.quitmenu_ctx.SuspendLayout()
        CType(Me.avatar_picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.maincanvas_lbl.Location = New System.Drawing.Point(5, 20)
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.createClass_Cmd)
        Me.GroupBox1.Controls.Add(Me.createUser_cmd)
        Me.GroupBox1.Controls.Add(Me.addClass_cmd)
        Me.GroupBox1.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(25, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Size = New System.Drawing.Size(635, 136)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data control"
        '
        'createClass_Cmd
        '
        Me.createClass_Cmd.ForeColor = System.Drawing.Color.Gray
        Me.createClass_Cmd.Location = New System.Drawing.Point(409, 85)
        Me.createClass_Cmd.Name = "createClass_Cmd"
        Me.createClass_Cmd.Size = New System.Drawing.Size(213, 39)
        Me.createClass_Cmd.TabIndex = 32
        Me.createClass_Cmd.Text = "Create Class"
        Me.createClass_Cmd.UseVisualStyleBackColor = True
        '
        'createUser_cmd
        '
        Me.createUser_cmd.ForeColor = System.Drawing.Color.Gray
        Me.createUser_cmd.Location = New System.Drawing.Point(13, 40)
        Me.createUser_cmd.Name = "createUser_cmd"
        Me.createUser_cmd.Size = New System.Drawing.Size(609, 39)
        Me.createUser_cmd.TabIndex = 31
        Me.createUser_cmd.Text = "Create User"
        Me.createUser_cmd.UseVisualStyleBackColor = True
        '
        'addClass_cmd
        '
        Me.addClass_cmd.ForeColor = System.Drawing.Color.Gray
        Me.addClass_cmd.Location = New System.Drawing.Point(13, 85)
        Me.addClass_cmd.Name = "addClass_cmd"
        Me.addClass_cmd.Size = New System.Drawing.Size(390, 39)
        Me.addClass_cmd.TabIndex = 30
        Me.addClass_cmd.Text = "Add user to class"
        Me.addClass_cmd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.parent_lbl)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.teacher_lbl)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.student_lbl)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.classnumber_lbl)
        Me.GroupBox2.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(25, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox2.Size = New System.Drawing.Size(635, 231)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User summary"
        '
        'parent_lbl
        '
        Me.parent_lbl.BackColor = System.Drawing.Color.Silver
        Me.parent_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.parent_lbl.ForeColor = System.Drawing.Color.DimGray
        Me.parent_lbl.Location = New System.Drawing.Point(181, 180)
        Me.parent_lbl.Name = "parent_lbl"
        Me.parent_lbl.Size = New System.Drawing.Size(441, 40)
        Me.parent_lbl.TabIndex = 12
        Me.parent_lbl.Text = "<Online>/<Total>"
        Me.parent_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Gainsboro
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(13, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 40)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Parent"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'teacher_lbl
        '
        Me.teacher_lbl.BackColor = System.Drawing.Color.Silver
        Me.teacher_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.teacher_lbl.ForeColor = System.Drawing.Color.DimGray
        Me.teacher_lbl.Location = New System.Drawing.Point(181, 134)
        Me.teacher_lbl.Name = "teacher_lbl"
        Me.teacher_lbl.Size = New System.Drawing.Size(441, 40)
        Me.teacher_lbl.TabIndex = 10
        Me.teacher_lbl.Text = "<Online>/<Total>"
        Me.teacher_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gainsboro
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(13, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 40)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Teacher"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'student_lbl
        '
        Me.student_lbl.BackColor = System.Drawing.Color.Silver
        Me.student_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.student_lbl.ForeColor = System.Drawing.Color.DimGray
        Me.student_lbl.Location = New System.Drawing.Point(181, 88)
        Me.student_lbl.Name = "student_lbl"
        Me.student_lbl.Size = New System.Drawing.Size(441, 40)
        Me.student_lbl.TabIndex = 8
        Me.student_lbl.Text = "<Online>/<Total>"
        Me.student_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(13, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 40)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Student"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(13, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 40)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Class Number"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'classnumber_lbl
        '
        Me.classnumber_lbl.BackColor = System.Drawing.Color.Silver
        Me.classnumber_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.classnumber_lbl.ForeColor = System.Drawing.Color.DimGray
        Me.classnumber_lbl.Location = New System.Drawing.Point(181, 42)
        Me.classnumber_lbl.Name = "classnumber_lbl"
        Me.classnumber_lbl.Size = New System.Drawing.Size(441, 40)
        Me.classnumber_lbl.TabIndex = 4
        Me.classnumber_lbl.Text = "<Online>/<Total>"
        Me.classnumber_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'refresh_lbl
        '
        Me.refresh_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.refresh_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.refresh_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refresh_lbl.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_lbl.ForeColor = System.Drawing.Color.White
        Me.refresh_lbl.Location = New System.Drawing.Point(680, 171)
        Me.refresh_lbl.Margin = New System.Windows.Forms.Padding(0)
        Me.refresh_lbl.Name = "refresh_lbl"
        Me.refresh_lbl.Size = New System.Drawing.Size(120, 34)
        Me.refresh_lbl.TabIndex = 34
        Me.refresh_lbl.Text = "Refresh"
        '
        'MainInterAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.refresh_lbl)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.avatar_picbox)
        Me.Controls.Add(Me.avatarcanvas_lbl)
        Me.Controls.Add(Me.exit_lbl)
        Me.Controls.Add(Me.subtitle_lbl)
        Me.Controls.Add(Me.maincanvas_lbl)
        Me.Controls.Add(Me.main_canvas_lbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainInterAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentInterMain"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.quitmenu_ctx.ResumeLayout(False)
        CType(Me.avatar_picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents addClass_cmd As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents classnumber_lbl As System.Windows.Forms.Label
    Friend WithEvents parent_lbl As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents teacher_lbl As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents student_lbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents refresh_lbl As System.Windows.Forms.Label
    Friend WithEvents createUser_cmd As System.Windows.Forms.Button
    Friend WithEvents createClass_Cmd As System.Windows.Forms.Button
End Class
