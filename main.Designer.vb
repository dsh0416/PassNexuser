<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PassNexuser
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PassNexuser))
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.SourcePass = New System.Windows.Forms.Label()
        Me.SoftInput = New System.Windows.Forms.Label()
        Me.ProName = New System.Windows.Forms.ComboBox()
        Me.PassNum = New System.Windows.Forms.NumericUpDown()
        Me.LoopLevel = New System.Windows.Forms.Label()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.HashMake = New System.Windows.Forms.Timer(Me.components)
        Me.Complete = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.参数设置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PBCApply = New System.Windows.Forms.ToolStripMenuItem()
        Me.基准测试ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.调试模式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.注册ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.输入注册码ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.申请注册资格ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查看帮助文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NIGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.版本更新ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PBCStatus = New System.Windows.Forms.Label()
        Me.PBCShow = New System.Windows.Forms.Label()
        Me.ButtonOut = New System.Windows.Forms.Button()
        Me.OutKey = New System.Windows.Forms.Timer(Me.components)
        Me.Outkey2 = New System.Windows.Forms.Timer(Me.components)
        Me.PassLength = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SourceText = New System.Windows.Forms.TextBox()
        Me.Reg = New System.Windows.Forms.Label()
        Me.PassText = New System.Windows.Forms.TextBox()
        CType(Me.PassNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PassLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GenerateButton
        '
        Me.GenerateButton.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GenerateButton.Image = Global.PassNexuser.My.Resources.Resources.GEN
        Me.GenerateButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.GenerateButton.Location = New System.Drawing.Point(167, 173)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(115, 119)
        Me.GenerateButton.TabIndex = 1
        Me.GenerateButton.Text = "生成"
        Me.GenerateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'SourcePass
        '
        Me.SourcePass.AutoSize = True
        Me.SourcePass.BackColor = System.Drawing.Color.Transparent
        Me.SourcePass.Location = New System.Drawing.Point(28, 33)
        Me.SourcePass.Name = "SourcePass"
        Me.SourcePass.Size = New System.Drawing.Size(53, 12)
        Me.SourcePass.TabIndex = 3
        Me.SourcePass.Text = "原始密码"
        '
        'SoftInput
        '
        Me.SoftInput.AutoSize = True
        Me.SoftInput.BackColor = System.Drawing.Color.Transparent
        Me.SoftInput.Location = New System.Drawing.Point(28, 96)
        Me.SoftInput.Name = "SoftInput"
        Me.SoftInput.Size = New System.Drawing.Size(29, 12)
        Me.SoftInput.TabIndex = 5
        Me.SoftInput.Text = "软件"
        '
        'ProName
        '
        Me.ProName.FormattingEnabled = True
        Me.ProName.Location = New System.Drawing.Point(167, 88)
        Me.ProName.Name = "ProName"
        Me.ProName.Size = New System.Drawing.Size(115, 20)
        Me.ProName.TabIndex = 7
        '
        'PassNum
        '
        Me.PassNum.Location = New System.Drawing.Point(167, 117)
        Me.PassNum.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.PassNum.Name = "PassNum"
        Me.PassNum.Size = New System.Drawing.Size(115, 21)
        Me.PassNum.TabIndex = 9
        Me.PassNum.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'LoopLevel
        '
        Me.LoopLevel.AutoSize = True
        Me.LoopLevel.BackColor = System.Drawing.Color.Transparent
        Me.LoopLevel.Location = New System.Drawing.Point(28, 126)
        Me.LoopLevel.Name = "LoopLevel"
        Me.LoopLevel.Size = New System.Drawing.Size(53, 12)
        Me.LoopLevel.TabIndex = 10
        Me.LoopLevel.Text = "加密等级"
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel, Me.ProgressBar1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 350)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(314, 22)
        Me.StatusStrip.TabIndex = 14
        Me.StatusStrip.Text = "StatusStrip"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(31, 17)
        Me.StatusLabel.Text = "就绪"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ProgressBar1.Visible = False
        '
        'HashMake
        '
        Me.HashMake.Interval = 10
        '
        'Complete
        '
        Me.Complete.Interval = 2000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.设置ToolStripMenuItem, Me.注册ToolStripMenuItem, Me.帮助ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(314, 25)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '设置ToolStripMenuItem
        '
        Me.设置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.参数设置ToolStripMenuItem, Me.PBCApply, Me.基准测试ToolStripMenuItem, Me.调试模式ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.设置ToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem"
        Me.设置ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.设置ToolStripMenuItem.Text = "设置"
        '
        '参数设置ToolStripMenuItem
        '
        Me.参数设置ToolStripMenuItem.Image = Global.PassNexuser.My.Resources.Resources.Settings
        Me.参数设置ToolStripMenuItem.Name = "参数设置ToolStripMenuItem"
        Me.参数设置ToolStripMenuItem.Size = New System.Drawing.Size(188, 38)
        Me.参数设置ToolStripMenuItem.Text = "参数设置"
        '
        'PBCApply
        '
        Me.PBCApply.Image = Global.PassNexuser.My.Resources.Resources.LOA
        Me.PBCApply.Name = "PBCApply"
        Me.PBCApply.Size = New System.Drawing.Size(188, 38)
        Me.PBCApply.Text = "载入加密卡"
        '
        '基准测试ToolStripMenuItem
        '
        Me.基准测试ToolStripMenuItem.Image = Global.PassNexuser.My.Resources.Resources.BENCH
        Me.基准测试ToolStripMenuItem.Name = "基准测试ToolStripMenuItem"
        Me.基准测试ToolStripMenuItem.Size = New System.Drawing.Size(188, 38)
        Me.基准测试ToolStripMenuItem.Text = "基准测试"
        '
        '调试模式ToolStripMenuItem
        '
        Me.调试模式ToolStripMenuItem.Enabled = False
        Me.调试模式ToolStripMenuItem.Image = Global.PassNexuser.My.Resources.Resources.DEBUG
        Me.调试模式ToolStripMenuItem.Name = "调试模式ToolStripMenuItem"
        Me.调试模式ToolStripMenuItem.Size = New System.Drawing.Size(188, 38)
        Me.调试模式ToolStripMenuItem.Text = "测试人员调试模式"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Image = Global.PassNexuser.My.Resources.Resources.closeico
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(188, 38)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        '注册ToolStripMenuItem
        '
        Me.注册ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.输入注册码ToolStripMenuItem, Me.申请注册资格ToolStripMenuItem})
        Me.注册ToolStripMenuItem.Name = "注册ToolStripMenuItem"
        Me.注册ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.注册ToolStripMenuItem.Text = "注册"
        '
        '输入注册码ToolStripMenuItem
        '
        Me.输入注册码ToolStripMenuItem.Name = "输入注册码ToolStripMenuItem"
        Me.输入注册码ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.输入注册码ToolStripMenuItem.Text = "输入注册码"
        '
        '申请注册资格ToolStripMenuItem
        '
        Me.申请注册资格ToolStripMenuItem.Name = "申请注册资格ToolStripMenuItem"
        Me.申请注册资格ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.申请注册资格ToolStripMenuItem.Text = "申请注册资格"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.查看帮助文件ToolStripMenuItem, Me.关于ToolStripMenuItem, Me.NIGToolStripMenuItem, Me.版本更新ToolStripMenuItem})
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        '查看帮助文件ToolStripMenuItem
        '
        Me.查看帮助文件ToolStripMenuItem.Image = Global.PassNexuser.My.Resources.Resources.HELP
        Me.查看帮助文件ToolStripMenuItem.Name = "查看帮助文件ToolStripMenuItem"
        Me.查看帮助文件ToolStripMenuItem.Size = New System.Drawing.Size(207, 38)
        Me.查看帮助文件ToolStripMenuItem.Text = "查看帮助文件"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Image = Global.PassNexuser.My.Resources.Resources.About
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(207, 38)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        'NIGToolStripMenuItem
        '
        Me.NIGToolStripMenuItem.Enabled = False
        Me.NIGToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NIGToolStripMenuItem.Image = Global.PassNexuser.My.Resources.Resources.BUG
        Me.NIGToolStripMenuItem.Name = "NIGToolStripMenuItem"
        Me.NIGToolStripMenuItem.Size = New System.Drawing.Size(207, 38)
        Me.NIGToolStripMenuItem.Text = "log抓取（暂停开放）"
        '
        '版本更新ToolStripMenuItem
        '
        Me.版本更新ToolStripMenuItem.Image = Global.PassNexuser.My.Resources.Resources.updateico
        Me.版本更新ToolStripMenuItem.Name = "版本更新ToolStripMenuItem"
        Me.版本更新ToolStripMenuItem.Size = New System.Drawing.Size(207, 38)
        Me.版本更新ToolStripMenuItem.Text = "更新检查"
        '
        'PBCStatus
        '
        Me.PBCStatus.AutoSize = True
        Me.PBCStatus.BackColor = System.Drawing.Color.Transparent
        Me.PBCStatus.Location = New System.Drawing.Point(28, 62)
        Me.PBCStatus.Name = "PBCStatus"
        Me.PBCStatus.Size = New System.Drawing.Size(65, 12)
        Me.PBCStatus.TabIndex = 20
        Me.PBCStatus.Text = "加密卡状态"
        '
        'PBCShow
        '
        Me.PBCShow.AutoSize = True
        Me.PBCShow.BackColor = System.Drawing.Color.Transparent
        Me.PBCShow.Location = New System.Drawing.Point(165, 62)
        Me.PBCShow.Name = "PBCShow"
        Me.PBCShow.Size = New System.Drawing.Size(41, 12)
        Me.PBCShow.TabIndex = 21
        Me.PBCShow.Text = "未装载"
        '
        'ButtonOut
        '
        Me.ButtonOut.Enabled = False
        Me.ButtonOut.Location = New System.Drawing.Point(167, 298)
        Me.ButtonOut.Name = "ButtonOut"
        Me.ButtonOut.Size = New System.Drawing.Size(115, 30)
        Me.ButtonOut.TabIndex = 22
        Me.ButtonOut.Text = "输入到密码框"
        Me.ButtonOut.UseVisualStyleBackColor = True
        '
        'OutKey
        '
        Me.OutKey.Interval = 500
        '
        'Outkey2
        '
        Me.Outkey2.Interval = 1000
        '
        'PassLength
        '
        Me.PassLength.Location = New System.Drawing.Point(167, 144)
        Me.PassLength.Maximum = New Decimal(New Integer() {32, 0, 0, 0})
        Me.PassLength.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.PassLength.Name = "PassLength"
        Me.PassLength.Size = New System.Drawing.Size(115, 21)
        Me.PassLength.TabIndex = 23
        Me.PassLength.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(28, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "密码位数"
        '
        'SourceText
        '
        Me.SourceText.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.SourceText.Location = New System.Drawing.Point(167, 28)
        Me.SourceText.Name = "SourceText"
        Me.SourceText.Size = New System.Drawing.Size(115, 21)
        Me.SourceText.TabIndex = 0
        Me.SourceText.UseSystemPasswordChar = True
        Me.SourceText.WordWrap = False
        '
        'Reg
        '
        Me.Reg.AutoSize = True
        Me.Reg.BackColor = System.Drawing.Color.Transparent
        Me.Reg.Location = New System.Drawing.Point(70, 236)
        Me.Reg.Name = "Reg"
        Me.Reg.Size = New System.Drawing.Size(41, 12)
        Me.Reg.TabIndex = 18
        Me.Reg.Text = "演示版"
        '
        'PassText
        '
        Me.PassText.Location = New System.Drawing.Point(55, 334)
        Me.PassText.Name = "PassText"
        Me.PassText.ReadOnly = True
        Me.PassText.Size = New System.Drawing.Size(204, 21)
        Me.PassText.TabIndex = 2
        Me.PassText.Text = "00000000000000000000000000000000"
        Me.PassText.Visible = False
        '
        'PassNexuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PassNexuser.My.Resources.Resources.eps34962
        Me.ClientSize = New System.Drawing.Size(314, 372)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PassLength)
        Me.Controls.Add(Me.ButtonOut)
        Me.Controls.Add(Me.PBCShow)
        Me.Controls.Add(Me.PBCStatus)
        Me.Controls.Add(Me.Reg)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LoopLevel)
        Me.Controls.Add(Me.PassNum)
        Me.Controls.Add(Me.ProName)
        Me.Controls.Add(Me.SoftInput)
        Me.Controls.Add(Me.SourcePass)
        Me.Controls.Add(Me.PassText)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.SourceText)
        Me.DoubleBuffered = true
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = false
        Me.Name = "PassNexuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PassNexuser(未注册)"
        CType(Me.PassNum,System.ComponentModel.ISupportInitialize).EndInit
        Me.StatusStrip.ResumeLayout(false)
        Me.StatusStrip.PerformLayout
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        CType(Me.PassLength,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents GenerateButton As System.Windows.Forms.Button
    Friend WithEvents SourcePass As System.Windows.Forms.Label
    Friend WithEvents SoftInput As System.Windows.Forms.Label
    Friend WithEvents ProName As System.Windows.Forms.ComboBox
    Friend WithEvents PassNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents LoopLevel As System.Windows.Forms.Label
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents HashMake As System.Windows.Forms.Timer
    Friend WithEvents Complete As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 设置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 参数设置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 调试模式ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 注册ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 输入注册码ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 申请注册资格ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 查看帮助文件ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NIGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 版本更新ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 基准测试ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PBCStatus As System.Windows.Forms.Label
    Friend WithEvents PBCShow As System.Windows.Forms.Label
    Friend WithEvents PBCApply As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonOut As System.Windows.Forms.Button
    Public WithEvents OutKey As System.Windows.Forms.Timer
    Friend WithEvents Outkey2 As System.Windows.Forms.Timer
    Friend WithEvents PassLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SourceText As System.Windows.Forms.TextBox
    Friend WithEvents Reg As System.Windows.Forms.Label
    Friend WithEvents PassText As System.Windows.Forms.TextBox

End Class
