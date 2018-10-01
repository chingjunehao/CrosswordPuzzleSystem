<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentInterTeacher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppointmentInterTeacher))
        Me.main_canvas_lbl = New System.Windows.Forms.Label()
        Me.maincanvas_lbl = New System.Windows.Forms.Label()
        Me.subtitle_lbl = New System.Windows.Forms.Label()
        Me.back_lbl = New System.Windows.Forms.Label()
        Me.avatarcanvas_lbl = New System.Windows.Forms.Label()
        Me.avatar_picbox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MyTime_cmd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.refresh_lbl = New System.Windows.Forms.Label()
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
        Me.subtitle_lbl.Text = "Appointment Manager"
        Me.subtitle_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'back_lbl
        '
        Me.back_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.back_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.back_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back_lbl.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_lbl.ForeColor = System.Drawing.Color.White
        Me.back_lbl.Location = New System.Drawing.Point(680, 130)
        Me.back_lbl.Margin = New System.Windows.Forms.Padding(0)
        Me.back_lbl.Name = "back_lbl"
        Me.back_lbl.Size = New System.Drawing.Size(120, 34)
        Me.back_lbl.TabIndex = 14
        Me.back_lbl.Text = "Back"
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
        Me.GroupBox1.Controls.Add(Me.MyTime_cmd)
        Me.GroupBox1.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(32, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Size = New System.Drawing.Size(635, 94)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Time Slot"
        '
        'MyTime_cmd
        '
        Me.MyTime_cmd.ForeColor = System.Drawing.Color.Gray
        Me.MyTime_cmd.Location = New System.Drawing.Point(13, 42)
        Me.MyTime_cmd.Name = "MyTime_cmd"
        Me.MyTime_cmd.Size = New System.Drawing.Size(609, 39)
        Me.MyTime_cmd.TabIndex = 30
        Me.MyTime_cmd.Text = "My Time Slot"
        Me.MyTime_cmd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(32, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox2.Size = New System.Drawing.Size(635, 391)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Appointment Request"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Location = New System.Drawing.Point(13, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(609, 348)
        Me.Panel1.TabIndex = 39
        '
        'refresh_lbl
        '
        Me.refresh_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.refresh_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.refresh_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refresh_lbl.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_lbl.ForeColor = System.Drawing.Color.White
        Me.refresh_lbl.Location = New System.Drawing.Point(680, 173)
        Me.refresh_lbl.Margin = New System.Windows.Forms.Padding(0)
        Me.refresh_lbl.Name = "refresh_lbl"
        Me.refresh_lbl.Size = New System.Drawing.Size(120, 34)
        Me.refresh_lbl.TabIndex = 39
        Me.refresh_lbl.Text = "Refresh"
        '
        'AppointmentInterTeacher
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
        Me.Controls.Add(Me.back_lbl)
        Me.Controls.Add(Me.subtitle_lbl)
        Me.Controls.Add(Me.maincanvas_lbl)
        Me.Controls.Add(Me.main_canvas_lbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AppointmentInterTeacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentInterMain"
        Me.TransparencyKey = System.Drawing.Color.Red
        CType(Me.avatar_picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main_canvas_lbl As System.Windows.Forms.Label
    Friend WithEvents maincanvas_lbl As System.Windows.Forms.Label
    Friend WithEvents subtitle_lbl As System.Windows.Forms.Label
    Friend WithEvents back_lbl As System.Windows.Forms.Label
    Friend WithEvents avatarcanvas_lbl As System.Windows.Forms.Label
    Friend WithEvents avatar_picbox As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MyTime_cmd As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents refresh_lbl As System.Windows.Forms.Label
End Class
