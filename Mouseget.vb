Public Class Mouseget

    Private Sub Mouseget_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = True
    End Sub

    Private Sub Mouseget_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        PassNexuser.MouseX = Cursor.Position.X
        PassNexuser.MouseY = Cursor.Position.Y
        PassNexuser.OutKey.Start()
        Me.Close()
    End Sub



    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.Leave
        Label1.Enabled = True
    End Sub

    Private Sub Label1_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.Move
        Label1.Enabled = False
    End Sub
End Class