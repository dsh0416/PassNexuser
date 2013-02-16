Public Class Settings

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBack.Click
        PassNexuser.BackgroundImage = My.Resources.Resources.eps34962
    End Sub

    Private Sub LBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBack.Click
        PicLoad.ShowDialog()
        PassNexuser.BackgroundImage = Image.FromFile(PicLoad.FileName)
    End Sub

    Private Sub FOpa_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FOpa.ValueChanged
        PassNexuser.Opacity = FOpa.Value / 100
    End Sub

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
End Class