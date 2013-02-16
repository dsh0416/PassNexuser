Public NotInheritable Class SplashScreen

    'TODO: 可轻松将此窗体设置为应用程序的初始屏幕，方法是转到
    '  “项目设计器”的“应用程序”选项卡(“项目”菜单下的“属性”)。


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <> 100 Then
            ProgressBar1.Value += 10
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Close()
    End Sub
End Class
