Public Class Bug

    Private Sub Bug_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("BUG提交工具将会收集您的一些数据，请放心，这些数据无关您的隐私和密码安全，您可以自行查看收集到的数据并决定是否提交")
        Dim Usersay As String = InputBox("请输入您遇到的问题")
        Dim SourceText As String = Application.StartupPath()
        Dim ProName As String = "PassNexuser"
        Dim source As String = SourceText + ProName
        Dim PassNum As Integer = 2
        Dim hashbase As String = getMd5Hash(source)
        For i As Integer = 1 To PassNum
            source = hashbase + ProName
            hashbase = getMd5Hash(source)
        Next
        Dim hash As String = hashbase
        '生成多次加密的MD5值 hash
        Dim strData As String = hash
        Dim strArrayChar() As Char
        strArrayChar = strData.ToCharArray()
        Dim str1 As String = strArrayChar(0)
        str1 = str1.ToUpper
        strArrayChar(0) = str1
        Dim str2 As String = strArrayChar(1)
        str2 = str2.ToUpper
        strArrayChar(1) = str2
        Dim str4 As String = strArrayChar(3)
        str4 = str4.ToUpper
        strArrayChar(3) = str4
        Dim str7 As String = strArrayChar(6)
        str7 = str7.ToUpper
        strArrayChar(6) = str7
        Dim str9 As String = strArrayChar(8)
        str9 = str9.ToUpper
        strArrayChar(8) = str9
        Dim hash12 As String = strArrayChar(0) + strArrayChar(1) + strArrayChar(2) + strArrayChar(3) + strArrayChar(4) + strArrayChar(5) + strArrayChar(6) + strArrayChar(7) + strArrayChar(8) + strArrayChar(9) + strArrayChar(10) + strArrayChar(11)
        '生成只有12位其中1、2、4、7、9为大写的有损hash值 hash12

        source = hash12 + "Reg"
        For i As Integer = 1 To 2222
            hashbase = getMd5Hash(source)
        Next
        Dim regis As String = hashbase


        Dim r As IO.StreamReader
        r = New IO.StreamReader("reg.txt", System.Text.Encoding.GetEncoding("GB2312"))
        Dim Regr = (r.ReadLine)
        r.Close()
        Dim sr As IO.StreamWriter = New IO.StreamWriter("BUG.txt ", False, System.Text.Encoding.Default)
        With sr
            .WriteLine(Usersay)
            .WriteLine(PassNexuser.ProName.Text)
            .WriteLine(PassNexuser.PassNum.Value)
            .WriteLine(PassNexuser.Reg.Visible)
            .WriteLine(Regr)
            .WriteLine(regis)
        End With
        sr.Close()
        System.Diagnostics.Process.Start("Bug.txt")
        System.Diagnostics.Process.Start("http://c6h8o7.blogbus.com/logs/188834660.html")
        MsgBox("请将所打开的文件中的内容回复到所打开的网站中，谢谢")
        Application.Exit()
    End Sub
End Class