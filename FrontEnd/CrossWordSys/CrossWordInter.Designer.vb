<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrossWordInter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrossWordInter))
        Me.main_canvas_lbl = New System.Windows.Forms.Label()
        Me.maincanvas_lbl = New System.Windows.Forms.Label()
        Me.subtitle_lbl = New System.Windows.Forms.Label()
        Me.quitmenu_ctx = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.avatarcanvas_lbl = New System.Windows.Forms.Label()
        Me.avatar_picbox = New System.Windows.Forms.PictureBox()
        Me.submit_cmd = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.questbox_txt = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.back_cmd = New System.Windows.Forms.Label()
        Me.quitmenu_ctx.SuspendLayout()
        CType(Me.avatar_picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
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
        Me.subtitle_lbl.Text = "Quiz: <QuizName>"
        Me.subtitle_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'submit_cmd
        '
        Me.submit_cmd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.submit_cmd.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.submit_cmd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submit_cmd.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit_cmd.ForeColor = System.Drawing.Color.White
        Me.submit_cmd.Location = New System.Drawing.Point(680, 174)
        Me.submit_cmd.Margin = New System.Windows.Forms.Padding(0)
        Me.submit_cmd.Name = "submit_cmd"
        Me.submit_cmd.Size = New System.Drawing.Size(120, 34)
        Me.submit_cmd.TabIndex = 24
        Me.submit_cmd.Text = "Submit"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.questbox_txt)
        Me.GroupBox5.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(28, 414)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox5.Size = New System.Drawing.Size(632, 163)
        Me.GroupBox5.TabIndex = 45
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Questions"
        '
        'questbox_txt
        '
        Me.questbox_txt.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questbox_txt.Location = New System.Drawing.Point(13, 30)
        Me.questbox_txt.Name = "questbox_txt"
        Me.questbox_txt.Size = New System.Drawing.Size(606, 120)
        Me.questbox_txt.TabIndex = 0
        Me.questbox_txt.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(28, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Size = New System.Drawing.Size(632, 325)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Puzzle"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(13, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(606, 282)
        Me.Panel1.TabIndex = 0
        '
        'back_cmd
        '
        Me.back_cmd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.back_cmd.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.back_cmd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back_cmd.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_cmd.ForeColor = System.Drawing.Color.White
        Me.back_cmd.Location = New System.Drawing.Point(680, 130)
        Me.back_cmd.Margin = New System.Windows.Forms.Padding(0)
        Me.back_cmd.Name = "back_cmd"
        Me.back_cmd.Size = New System.Drawing.Size(120, 34)
        Me.back_cmd.TabIndex = 47
        Me.back_cmd.Text = "Back"
        '
        'CrossWordInter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.back_cmd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.submit_cmd)
        Me.Controls.Add(Me.avatar_picbox)
        Me.Controls.Add(Me.avatarcanvas_lbl)
        Me.Controls.Add(Me.subtitle_lbl)
        Me.Controls.Add(Me.maincanvas_lbl)
        Me.Controls.Add(Me.main_canvas_lbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CrossWordInter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentInterMain"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.quitmenu_ctx.ResumeLayout(False)
        CType(Me.avatar_picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main_canvas_lbl As System.Windows.Forms.Label
    Friend WithEvents maincanvas_lbl As System.Windows.Forms.Label
    Friend WithEvents subtitle_lbl As System.Windows.Forms.Label
    Friend WithEvents quitmenu_ctx As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SignOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents avatarcanvas_lbl As System.Windows.Forms.Label
    Friend WithEvents avatar_picbox As System.Windows.Forms.PictureBox
    Friend WithEvents submit_cmd As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents questbox_txt As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents back_cmd As System.Windows.Forms.Label
End Class
