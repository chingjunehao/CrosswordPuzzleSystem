<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WritePost
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.post_cmd = New System.Windows.Forms.Button()
        Me.content_txt = New System.Windows.Forms.RichTextBox()
        Me.title_txt = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.post_cmd)
        Me.GroupBox2.Controls.Add(Me.content_txt)
        Me.GroupBox2.Controls.Add(Me.title_txt)
        Me.GroupBox2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox2.Size = New System.Drawing.Size(360, 337)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Write new post"
        '
        'post_cmd
        '
        Me.post_cmd.ForeColor = System.Drawing.Color.DimGray
        Me.post_cmd.Location = New System.Drawing.Point(13, 291)
        Me.post_cmd.Name = "post_cmd"
        Me.post_cmd.Size = New System.Drawing.Size(334, 33)
        Me.post_cmd.TabIndex = 2
        Me.post_cmd.Text = "Post"
        Me.post_cmd.UseVisualStyleBackColor = True
        '
        'content_txt
        '
        Me.content_txt.Location = New System.Drawing.Point(13, 76)
        Me.content_txt.Name = "content_txt"
        Me.content_txt.Size = New System.Drawing.Size(334, 209)
        Me.content_txt.TabIndex = 1
        Me.content_txt.Text = ""
        '
        'title_txt
        '
        Me.title_txt.Location = New System.Drawing.Point(13, 38)
        Me.title_txt.Name = "title_txt"
        Me.title_txt.Size = New System.Drawing.Size(334, 32)
        Me.title_txt.TabIndex = 0
        '
        'WritePost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "WritePost"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents post_cmd As System.Windows.Forms.Button
    Friend WithEvents content_txt As System.Windows.Forms.RichTextBox
    Friend WithEvents title_txt As System.Windows.Forms.TextBox
End Class
