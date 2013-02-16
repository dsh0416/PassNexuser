Public Class Debuger

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("删除将会回到未注册状态直到重新输入注册码，确定吗", vbOKCancel) = MsgBoxResult.Ok Then '用户确认删除
            Dim fFile1 As New IO.FileInfo("reg.txt")
            fFile1.Delete()
            Dim w As IO.StreamWriter
            w = IO.File.CreateText("reg.txt")
            w.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BenchMark.Show()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PBCLoad.Show()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim time1 As Integer = Now.Hour * 3600000 + Now.Minute * 60000 + Now.Second * 1000 + Now.Millisecond
        Dim source As String = "123456"
        Dim hashbase As String
        Dim ProVal As String = " " + "QQ"
        Dim HashPro As String = getMd5Hash(ProVal)
        source = source + HashPro + PassNexuser.PBCode
        hashbase = getMd5Hash(source)
        Dim strArrayChar() As Char
        For i As Integer = 1 To CInt(TextBox1.Text)
            hashbase = getMd5Hash(hashbase)
            hashbase = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(hashbase))
            '将加密结果再通过BASE64算法
            strArrayChar = hashbase.ToCharArray()
            hashbase = strArrayChar(0) + strArrayChar(1) + strArrayChar(2) + strArrayChar(3) + strArrayChar(4) + strArrayChar(5) + strArrayChar(6) + strArrayChar(7) + strArrayChar(8) + strArrayChar(9) + strArrayChar(10) + strArrayChar(11)
            '切割BASE64成为有损BASE64
        Next
        Dim time2 As Integer = Now.Hour * 3600000 + Now.Minute * 60000 + Now.Second * 1000 + Now.Millisecond
        Label6.Text = time2 - time1
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Updater.Show()
    End Sub
End Class