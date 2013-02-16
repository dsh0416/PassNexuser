Public Class PassNexuser
    Public PBCode As String = 0
    Public ProNameV As String = " "
    Public MouseX As Integer
    Public MouseY As Integer
    Private Declare Function SetCursorPos Lib "user32" (ByVal x As Integer, ByVal y As Integer) As Integer '这个是设置鼠标的位置!
    Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer) '定义鼠标事件
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Public Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Public Const MOUSEEVENTF_MIDDLEUP = &H40
    Public Const MOUSEEVENTF_RIGHTDOWN = &H8
    Public Const MOUSEEVENTF_RIGHTUP = &H10
    Public Const MOUSEEVENTF_MOVE = &H1
    Private Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As pointapi) As Integer
    Public Loading As Boolean = False
    Public Softs As Integer = 0

    Private Structure pointapi
        Dim x As Integer
        Dim y As Integer
    End Structure

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateButton.Click
        If ProName.Items.Contains(ProName.Text) = False And ProName.Text <> "" Then
            ProName.Items.Add(ProName.Text)
            Dim fFile1 As New IO.FileInfo("Softs.txt")
            fFile1.Delete()
            Dim sr As IO.StreamWriter = New IO.StreamWriter("Softs.txt ", False, System.Text.Encoding.Default)
            With sr
                .WriteLine(ProName.Items.Count - 1)
            End With
            For i = 0 To ProName.Items.Count - 1
                With sr
                    .WriteLine(ProName.Items.Item(i))
                End With
            Next

            sr.Close()
        End If

        If PassNum.Value >= 100000 Then '检验是否计算花费大量时间
            If MsgBox("较高的加密等级需要大量时间运算，是否继续？", vbOKCancel) = MsgBoxResult.Ok Then '用户确认计算
                StatusLabel.Text = "运算中"
                HashMake.Enabled = True
            End If
        Else '不需要长时间计算
            StatusLabel.Text = "运算中"
            HashMake.Enabled = True

        End If
    End Sub

    Private Sub LinkLabel1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim Inputa As String
        Inputa = InputBox("这是一个彩蛋")
        If Inputa = "KeyGen" Then
            KeyGen.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HashMake.Tick
        ProgressBar1.Visible = True
        Dim source As String = SourceText.Text
        Dim hashbase As String
        Dim ProVal As String = " " + ProName.Text
        Dim HashPro As String = getMd5Hash(ProVal)
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = PassNum.Value
        source = source + HashPro + PBCode
        hashbase = getMd5Hash(source)
        Dim strArrayChar() As Char
        For i As Integer = 1 To PassNum.Value
            hashbase = getMd5Hash(hashbase)
            hashbase = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(hashbase))
            '将加密结果再通过BASE64算法
            ProgressBar1.Value = ProgressBar1.Value + 1
            strArrayChar = hashbase.ToCharArray()
            hashbase = ""
            For j As Integer = 0 To (CInt(PassLength.Value) - 1)
                hashbase += strArrayChar(j)
            Next
            '按位数，切割BASE64成为有损BASE64'切割BASE64成为有损BASE64
        Next
        PassText.Text = hashbase
        StatusLabel.Text = "运算完毕"
        ButtonOut.Enabled = True
        Complete.Enabled = True
        HashMake.Enabled = False
    End Sub

    Private Sub Complete_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Complete.Tick
        StatusLabel.Text = "就绪"
        Complete.Enabled = False
        ProgressBar1.Visible = False
    End Sub

    Private Sub 申请注册资格ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 申请注册资格ToolStripMenuItem.Click
        RegAsk.Visible = True
    End Sub

    Private Sub 输入注册码ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 输入注册码ToolStripMenuItem.Click
        RegEnt.Visible = True
    End Sub

    Private Sub PassNexuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''校验注册
        'Dim SourceText As String = Application.StartupPath()
        'Dim ProName As String = "PassNexuser"
        'Dim source As String = SourceText + ProName
        'Dim PassNum As Integer = 2
        'Dim hashbase As String = getMd5Hash(source)
        'For i As Integer = 1 To PassNum
        'source = hashbase + ProName
        'hashbase = getMd5Hash(source)
        'Next
        'Dim hash As String = hashbase
        ''生成多次加密的MD5值 hash
        'Dim strData As String = hash
        'Dim strArrayChar() As Char
        'strArrayChar = strData.ToCharArray()
        'Dim str1 As String = strArrayChar(0)
        'str1 = str1.ToUpper
        'strArrayChar(0) = str1
        'Dim str2 As String = strArrayChar(1)
        'str2 = str2.ToUpper
        'strArrayChar(1) = str2
        'Dim str4 As String = strArrayChar(3)
        'str4 = str4.ToUpper
        'strArrayChar(3) = str4
        'Dim str7 As String = strArrayChar(6)
        'str7 = str7.ToUpper
        'strArrayChar(6) = str7
        'Dim str9 As String = strArrayChar(8)
        'str9 = str9.ToUpper
        'strArrayChar(8) = str9
        'Dim hash12 As String = strArrayChar(0) + strArrayChar(1) + strArrayChar(2) + strArrayChar(3) + strArrayChar(4) + strArrayChar(5) + strArrayChar(6) + strArrayChar(7) + strArrayChar(8) + strArrayChar(9) + strArrayChar(10) + strArrayChar(11)
        ''生成只有12位其中1、2、4、7、9为大写的有损hash值 hash12

        'source = hash12 + "Reg"
        'For i As Integer = 1 To 2222
        'hashbase = getMd5Hash(source)
        'Next
        'Dim regis As String = hashbase

        'Dim r As IO.StreamReader
        'r = New IO.StreamReader("reg.txt", System.Text.Encoding.GetEncoding("GB2312"))
        'Dim Regr = (r.ReadLine)
        'r.Close()
        ''完成注册
        'If Regr = regis Then
        If Loading = False Then
            Me.Visible = False
            SplashScreen.Visible = True
            Loading = True
        End If
        Reg.Visible = True
        调试模式ToolStripMenuItem.Enabled = True
        调试模式ToolStripMenuItem.Text = "调试模式"
        注册ToolStripMenuItem.Visible = False
        Me.Text = "PassNexuser"



        Dim r As IO.StreamReader
        r = New IO.StreamReader("Softs.txt", System.Text.Encoding.GetEncoding("GB2312"))
        Softs = (r.ReadLine)
        Dim soft(Val(Softs)) As String
        For i = 0 To Val(Softs)
            ProName.Items.Add(r.ReadLine.ToString)
        Next

        'End If
        ''注册成功
    End Sub
    Private Sub 调试模式ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 调试模式ToolStripMenuItem.Click
        If 调试模式ToolStripMenuItem.Enabled = False Then
            MsgBox("只有注册用户才能使用该功能")
        Else
            Debuger.Visible = True
        End If
    End Sub

    Private Sub 参数设置ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 参数设置ToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub NIGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NIGToolStripMenuItem.Click
        Bug.Visible = True
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub 关于ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于ToolStripMenuItem.Click
        AboutBox.Visible = True
    End Sub

    Private Sub 查看帮助文件ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 查看帮助文件ToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Resources\help.chm")
    End Sub

    Private Sub 版本更新ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 版本更新ToolStripMenuItem.Click
        Updater.Visible = True
    End Sub

    Private Sub 基准测试ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 基准测试ToolStripMenuItem.Click
        BenchMark.Visible = True
    End Sub

    Private Sub PBCApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCApply.Click
        PBCLoad.Visible = True
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOut.Click
        Mouseget.Show()
        ButtonOut.Enabled = False
    End Sub

    Private Sub OutKey_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutKey.Tick
        SetCursorPos(Me.MouseX, Me.MouseY)
        mouse_event(MOUSEEVENTF_LEFTDOWN Or MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        Outkey2.Enabled = True
        OutKey.Enabled = False
    End Sub

    Private Sub Outkey2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Outkey2.Tick
        Call SendKeys.Send(PassText.Text.ToString)
        Outkey2.Enabled = False
    End Sub

    Private Sub Reg_Click(sender As Object, e As EventArgs) Handles Reg.Click
        Dim east As String = InputBox("一个彩蛋")
        If east = "vispass" Then PassText.Visible = Not (PassText.Visible)
    End Sub
End Class
