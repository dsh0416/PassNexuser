Public Class RegAsk

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("http://c6h8o7.blogbus.com/logs/188834759.html")
    End Sub

    Private Sub RegAsk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        TextBox1.Text = hash12
    End Sub
End Class