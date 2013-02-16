<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PBCMaker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PBCMaker))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBCNumber = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintPreview = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Line1 = New System.Windows.Forms.Label()
        Me.Line2 = New System.Windows.Forms.Label()
        Me.Line3 = New System.Windows.Forms.Label()
        Me.Line4 = New System.Windows.Forms.Label()
        Me.Line5 = New System.Windows.Forms.Label()
        Me.Line6 = New System.Windows.Forms.Label()
        Me.Line7 = New System.Windows.Forms.Label()
        Me.Line8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "加密卡编号"
        '
        'PBCNumber
        '
        Me.PBCNumber.AutoSize = True
        Me.PBCNumber.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.PBCNumber.Location = New System.Drawing.Point(265, 9)
        Me.PBCNumber.Name = "PBCNumber"
        Me.PBCNumber.Size = New System.Drawing.Size(84, 14)
        Me.PBCNumber.TabIndex = 1
        Me.PBCNumber.Text = "00000000000"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(231, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "打印"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintPreview
        '
        Me.PrintPreview.DocumentName = "document"
        Me.PrintPreview.Form = Me
        Me.PrintPreview.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintPreview.PrinterSettings = CType(resources.GetObject("PrintPreview.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintPreview.PrintFileName = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(371, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = " A      B      C      D      E      F      G      H "
        '
        'Line1
        '
        Me.Line1.AutoSize = True
        Me.Line1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Line1.Location = New System.Drawing.Point(-2, 22)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(21, 14)
        Me.Line1.TabIndex = 4
        Me.Line1.Text = " 1"
        '
        'Line2
        '
        Me.Line2.AutoSize = True
        Me.Line2.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Line2.Location = New System.Drawing.Point(-2, 44)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(21, 14)
        Me.Line2.TabIndex = 5
        Me.Line2.Text = " 2"
        '
        'Line3
        '
        Me.Line3.AutoSize = True
        Me.Line3.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Line3.Location = New System.Drawing.Point(-2, 65)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(21, 14)
        Me.Line3.TabIndex = 6
        Me.Line3.Text = " 3"
        '
        'Line4
        '
        Me.Line4.AutoSize = True
        Me.Line4.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Line4.Location = New System.Drawing.Point(-2, 86)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(21, 14)
        Me.Line4.TabIndex = 7
        Me.Line4.Text = " 4"
        '
        'Line5
        '
        Me.Line5.AutoSize = True
        Me.Line5.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Line5.Location = New System.Drawing.Point(-2, 108)
        Me.Line5.Name = "Line5"
        Me.Line5.Size = New System.Drawing.Size(21, 14)
        Me.Line5.TabIndex = 8
        Me.Line5.Text = " 5"
        '
        'Line6
        '
        Me.Line6.AutoSize = True
        Me.Line6.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Line6.Location = New System.Drawing.Point(-2, 130)
        Me.Line6.Name = "Line6"
        Me.Line6.Size = New System.Drawing.Size(21, 14)
        Me.Line6.TabIndex = 9
        Me.Line6.Text = " 6"
        '
        'Line7
        '
        Me.Line7.AutoSize = True
        Me.Line7.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Line7.Location = New System.Drawing.Point(-2, 154)
        Me.Line7.Name = "Line7"
        Me.Line7.Size = New System.Drawing.Size(21, 14)
        Me.Line7.TabIndex = 10
        Me.Line7.Text = " 7"
        '
        'Line8
        '
        Me.Line8.AutoSize = True
        Me.Line8.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Line8.Location = New System.Drawing.Point(-2, 174)
        Me.Line8.Name = "Line8"
        Me.Line8.Size = New System.Drawing.Size(21, 14)
        Me.Line8.TabIndex = 11
        Me.Line8.Text = " 8"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Line8)
        Me.Panel1.Controls.Add(Me.Line7)
        Me.Panel1.Controls.Add(Me.Line6)
        Me.Panel1.Controls.Add(Me.Line5)
        Me.Panel1.Controls.Add(Me.Line4)
        Me.Panel1.Controls.Add(Me.Line3)
        Me.Panel1.Controls.Add(Me.Line2)
        Me.Panel1.Controls.Add(Me.Line1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(54, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 191)
        Me.Panel1.TabIndex = 12
        '
        'PBCMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 296)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PBCNumber)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PBCMaker"
        Me.Text = "生成加密卡"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PBCNumber As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintPreview As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Line8 As System.Windows.Forms.Label
    Friend WithEvents Line7 As System.Windows.Forms.Label
    Friend WithEvents Line6 As System.Windows.Forms.Label
    Friend WithEvents Line5 As System.Windows.Forms.Label
    Friend WithEvents Line4 As System.Windows.Forms.Label
    Friend WithEvents Line3 As System.Windows.Forms.Label
    Friend WithEvents Line2 As System.Windows.Forms.Label
    Friend WithEvents Line1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
