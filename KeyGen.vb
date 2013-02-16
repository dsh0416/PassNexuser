Public Class KeyGen

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Hash12 As String = TextBox1.Text
        Dim source As String = hash12 + "Reg"
        Dim hashbase As String = ""
        For i As Integer = 1 To 2222
            hashbase = getMd5Hash(source)
        Next

        Dim regis As String = hashbase
        TextBox2.Text = regis
    End Sub
End Class