Public Class BenchMark
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("我们将会花去大约40秒的时间来测试您的基准参数，这主要取决于你的CPU")
        ProgressBar1.Value = 0
        Dim R As Integer = 0
        For t As Integer = 1 To 10
            Dim Time1 As Integer = Now.Hour * 60 * 60 + Now.Minute * 60 + Now.Second
            Dim Time2 As Integer = 0
            Dim hashbase As String = 1234567890
            While (Time2 - Time1 <= 1)
                hashbase = getMd5Hash(hashbase)
                Dim hash As String = hashbase
                '生成多次加密的MD5值 hash
                hash = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(hash))
                '将加密结果再通过BASE64算法
                Dim strData As String = hash
                Dim strArrayChar() As Char
                strArrayChar = strData.ToCharArray()
                Dim hash12 As String = strArrayChar(0) + strArrayChar(1) + strArrayChar(2) + strArrayChar(3) + strArrayChar(4) + strArrayChar(5) + strArrayChar(6) + strArrayChar(7) + strArrayChar(8) + strArrayChar(9) + strArrayChar(10) + strArrayChar(11)
                '切割BASE64成为有损BASE64
                Time2 = Now.Hour * 60 * 60 + Now.Minute * 60 + Now.Second
                R += 1
            End While
            ProgressBar1.Value = ProgressBar1.Value + 1
        Next
        R /= 10
        R = Int(R / 100) * 100
        Dim Output As Integer = R
        MsgBox("推荐加密等级：" & Output & "±100")
    End Sub
End Class