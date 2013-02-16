<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBack = New System.Windows.Forms.Button()
        Me.DBack = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FOpa = New System.Windows.Forms.NumericUpDown()
        Me.PicLoad = New System.Windows.Forms.OpenFileDialog()
        CType(Me.FOpa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "背景图片"
        '
        'LBack
        '
        Me.LBack.Location = New System.Drawing.Point(85, 11)
        Me.LBack.Name = "LBack"
        Me.LBack.Size = New System.Drawing.Size(45, 33)
        Me.LBack.TabIndex = 3
        Me.LBack.Text = "读取"
        Me.LBack.UseVisualStyleBackColor = True
        '
        'DBack
        '
        Me.DBack.Location = New System.Drawing.Point(130, 11)
        Me.DBack.Name = "DBack"
        Me.DBack.Size = New System.Drawing.Size(49, 33)
        Me.DBack.TabIndex = 4
        Me.DBack.Text = "默认"
        Me.DBack.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(63, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 29)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "窗口透明度"
        '
        'FOpa
        '
        Me.FOpa.Location = New System.Drawing.Point(92, 50)
        Me.FOpa.Minimum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.FOpa.Name = "FOpa"
        Me.FOpa.Size = New System.Drawing.Size(87, 21)
        Me.FOpa.TabIndex = 11
        Me.FOpa.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(198, 116)
        Me.Controls.Add(Me.FOpa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DBack)
        Me.Controls.Add(Me.LBack)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.Text = "参数设置"
        CType(Me.FOpa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBack As System.Windows.Forms.Button
    Friend WithEvents DBack As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FOpa As System.Windows.Forms.NumericUpDown
    Friend WithEvents PicLoad As System.Windows.Forms.OpenFileDialog
End Class
