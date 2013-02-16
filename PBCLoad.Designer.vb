<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PBCLoad
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PBCMake = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PS1 = New System.Windows.Forms.Label()
        Me.PS2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Confirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PBCMake
        '
        Me.PBCMake.Enabled = False
        Me.PBCMake.Location = New System.Drawing.Point(167, 217)
        Me.PBCMake.Name = "PBCMake"
        Me.PBCMake.Size = New System.Drawing.Size(105, 33)
        Me.PBCMake.TabIndex = 0
        Me.PBCMake.Text = "没有加密卡？"
        Me.PBCMake.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "加密卡编号"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(111, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 21)
        Me.TextBox1.TabIndex = 2
        '
        'PS1
        '
        Me.PS1.AutoSize = True
        Me.PS1.Location = New System.Drawing.Point(109, 100)
        Me.PS1.Name = "PS1"
        Me.PS1.Size = New System.Drawing.Size(17, 12)
        Me.PS1.TabIndex = 3
        Me.PS1.Text = "00"
        '
        'PS2
        '
        Me.PS2.AutoSize = True
        Me.PS2.Location = New System.Drawing.Point(140, 100)
        Me.PS2.Name = "PS2"
        Me.PS2.Size = New System.Drawing.Size(17, 12)
        Me.PS2.TabIndex = 4
        Me.PS2.Text = "00"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(101, 115)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(71, 21)
        Me.TextBox2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "请查询您的加密卡的以下数码"
        '
        'Confirm
        '
        Me.Confirm.Location = New System.Drawing.Point(101, 142)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(71, 32)
        Me.Confirm.TabIndex = 7
        Me.Confirm.Text = "确认"
        Me.Confirm.UseVisualStyleBackColor = True
        '
        'PBCLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Confirm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.PS2)
        Me.Controls.Add(Me.PS1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBCMake)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PBCLoad"
        Me.Text = "载入加密卡"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PBCMake As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PS1 As System.Windows.Forms.Label
    Friend WithEvents PS2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Confirm As System.Windows.Forms.Button
End Class
