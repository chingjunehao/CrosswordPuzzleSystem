<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateUser
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.email_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.student_box = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.type_box = New System.Windows.Forms.ComboBox()
        Me.username_txt = New System.Windows.Forms.TextBox()
        Me.createUser_Cmd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.email_txt)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.password_txt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.student_box)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.type_box)
        Me.GroupBox1.Controls.Add(Me.username_txt)
        Me.GroupBox1.Controls.Add(Me.createUser_Cmd)
        Me.GroupBox1.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Size = New System.Drawing.Size(360, 328)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New user"
        '
        'email_txt
        '
        Me.email_txt.Location = New System.Drawing.Point(113, 135)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(234, 39)
        Me.email_txt.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(14, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 39)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Email"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'password_txt
        '
        Me.password_txt.Location = New System.Drawing.Point(113, 90)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.Size = New System.Drawing.Size(234, 39)
        Me.password_txt.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Gainsboro
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(13, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 39)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Password"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'student_box
        '
        Me.student_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.student_box.Enabled = False
        Me.student_box.FormattingEnabled = True
        Me.student_box.Location = New System.Drawing.Point(114, 232)
        Me.student_box.Name = "student_box"
        Me.student_box.Size = New System.Drawing.Size(234, 40)
        Me.student_box.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(14, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 39)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Student"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(14, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 39)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(13, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 39)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'type_box
        '
        Me.type_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.type_box.FormattingEnabled = True
        Me.type_box.Items.AddRange(New Object() {"Student", "Teacher", "Parent"})
        Me.type_box.Location = New System.Drawing.Point(113, 184)
        Me.type_box.Name = "type_box"
        Me.type_box.Size = New System.Drawing.Size(234, 40)
        Me.type_box.TabIndex = 35
        '
        'username_txt
        '
        Me.username_txt.Location = New System.Drawing.Point(113, 45)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.Size = New System.Drawing.Size(234, 39)
        Me.username_txt.TabIndex = 34
        '
        'createUser_Cmd
        '
        Me.createUser_Cmd.ForeColor = System.Drawing.Color.Gray
        Me.createUser_Cmd.Location = New System.Drawing.Point(13, 278)
        Me.createUser_Cmd.Name = "createUser_Cmd"
        Me.createUser_Cmd.Size = New System.Drawing.Size(334, 39)
        Me.createUser_Cmd.TabIndex = 32
        Me.createUser_Cmd.Text = "Create User"
        Me.createUser_Cmd.UseVisualStyleBackColor = True
        '
        'CreateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 351)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CreateUser"
        Me.Text = "New user"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents type_box As System.Windows.Forms.ComboBox
    Friend WithEvents username_txt As System.Windows.Forms.TextBox
    Friend WithEvents createUser_Cmd As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents student_box As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents password_txt As System.Windows.Forms.TextBox
    Friend WithEvents email_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
