<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuizInterTeacher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuizInterTeacher))
        Me.main_canvas_lbl = New System.Windows.Forms.Label()
        Me.subtitle_lbl = New System.Windows.Forms.Label()
        Me.classtab_cmd = New System.Windows.Forms.Label()
        Me.quitmenu_ctx = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.avatarcanvas_lbl = New System.Windows.Forms.Label()
        Me.avatar_picbox = New System.Windows.Forms.PictureBox()
        Me.uptime_timer = New System.Windows.Forms.Timer(Me.components)
        Me.back_cmd = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.average_lbl = New System.Windows.Forms.Label()
        Me.aaa = New System.Windows.Forms.Label()
        Me.uploadquiz_cmd = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.quitmenu_ctx.SuspendLayout()
        CType(Me.avatar_picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'main_canvas_lbl
        '
        Me.main_canvas_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.main_canvas_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.main_canvas_lbl.Location = New System.Drawing.Point(14, 16)
        Me.main_canvas_lbl.Margin = New System.Windows.Forms.Padding(32)
        Me.main_canvas_lbl.Name = "main_canvas_lbl"
        Me.main_canvas_lbl.Size = New System.Drawing.Size(768, 568)
        Me.main_canvas_lbl.TabIndex = 2
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
        Me.subtitle_lbl.Text = "Classroom: <ClassName>"
        Me.subtitle_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'classtab_cmd
        '
        Me.classtab_cmd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.classtab_cmd.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.classtab_cmd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.classtab_cmd.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.classtab_cmd.ForeColor = System.Drawing.Color.White
        Me.classtab_cmd.Location = New System.Drawing.Point(680, 130)
        Me.classtab_cmd.Margin = New System.Windows.Forms.Padding(0)
        Me.classtab_cmd.Name = "classtab_cmd"
        Me.classtab_cmd.Size = New System.Drawing.Size(120, 34)
        Me.classtab_cmd.TabIndex = 14
        Me.classtab_cmd.Text = "Class Tab"
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
        'back_cmd
        '
        Me.back_cmd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.back_cmd.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.back_cmd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back_cmd.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_cmd.ForeColor = System.Drawing.Color.White
        Me.back_cmd.Location = New System.Drawing.Point(680, 173)
        Me.back_cmd.Margin = New System.Windows.Forms.Padding(0)
        Me.back_cmd.Name = "back_cmd"
        Me.back_cmd.Size = New System.Drawing.Size(120, 34)
        Me.back_cmd.TabIndex = 19
        Me.back_cmd.Text = "Back"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(32, 179)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox2.Size = New System.Drawing.Size(635, 388)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Class Quiz"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Location = New System.Drawing.Point(13, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(609, 344)
        Me.Panel1.TabIndex = 36
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.average_lbl)
        Me.GroupBox5.Controls.Add(Me.aaa)
        Me.GroupBox5.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(32, 83)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox5.Size = New System.Drawing.Size(635, 90)
        Me.GroupBox5.TabIndex = 44
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Average Performance"
        '
        'average_lbl
        '
        Me.average_lbl.BackColor = System.Drawing.Color.Silver
        Me.average_lbl.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.average_lbl.ForeColor = System.Drawing.Color.DimGray
        Me.average_lbl.Location = New System.Drawing.Point(196, 42)
        Me.average_lbl.Name = "average_lbl"
        Me.average_lbl.Size = New System.Drawing.Size(429, 35)
        Me.average_lbl.TabIndex = 42
        Me.average_lbl.Text = "<Scored>/<Total>"
        Me.average_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aaa
        '
        Me.aaa.BackColor = System.Drawing.Color.Gainsboro
        Me.aaa.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aaa.ForeColor = System.Drawing.Color.Gray
        Me.aaa.Location = New System.Drawing.Point(13, 42)
        Me.aaa.Name = "aaa"
        Me.aaa.Size = New System.Drawing.Size(177, 35)
        Me.aaa.TabIndex = 42
        Me.aaa.Text = "Average Score"
        Me.aaa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'uploadquiz_cmd
        '
        Me.uploadquiz_cmd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.uploadquiz_cmd.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.uploadquiz_cmd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.uploadquiz_cmd.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uploadquiz_cmd.ForeColor = System.Drawing.Color.White
        Me.uploadquiz_cmd.Location = New System.Drawing.Point(438, 36)
        Me.uploadquiz_cmd.Margin = New System.Windows.Forms.Padding(0)
        Me.uploadquiz_cmd.Name = "uploadquiz_cmd"
        Me.uploadquiz_cmd.Size = New System.Drawing.Size(229, 34)
        Me.uploadquiz_cmd.TabIndex = 45
        Me.uploadquiz_cmd.Text = "Upload new quiz"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'QuizInterTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.uploadquiz_cmd)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.back_cmd)
        Me.Controls.Add(Me.avatar_picbox)
        Me.Controls.Add(Me.avatarcanvas_lbl)
        Me.Controls.Add(Me.classtab_cmd)
        Me.Controls.Add(Me.subtitle_lbl)
        Me.Controls.Add(Me.main_canvas_lbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QuizInterTeacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentInterMain"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.quitmenu_ctx.ResumeLayout(False)
        CType(Me.avatar_picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main_canvas_lbl As System.Windows.Forms.Label
    Friend WithEvents subtitle_lbl As System.Windows.Forms.Label
    Friend WithEvents classtab_cmd As System.Windows.Forms.Label
    Friend WithEvents quitmenu_ctx As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SignOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents avatarcanvas_lbl As System.Windows.Forms.Label
    Friend WithEvents avatar_picbox As System.Windows.Forms.PictureBox
    Friend WithEvents uptime_timer As System.Windows.Forms.Timer
    Friend WithEvents back_cmd As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents average_lbl As System.Windows.Forms.Label
    Friend WithEvents aaa As System.Windows.Forms.Label
    Friend WithEvents uploadquiz_cmd As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
