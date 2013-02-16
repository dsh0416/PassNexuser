Public Class RegEnt

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fFile1 As New IO.FileInfo("reg.txt")
        fFile1.Delete()
        Dim sr As IO.StreamWriter = New IO.StreamWriter("reg.txt ", False, System.Text.Encoding.Default)
        With sr
            .WriteLine(TextBox1.Text)
        End With
        sr.Close()
        Application.Exit()
    End Sub
End Class