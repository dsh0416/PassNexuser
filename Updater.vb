Imports System.Text.RegularExpressions

Public Class Updater
    Private Sub Update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim result As String = New Regex("new_ver"":\d+").Match(GetCode("http://pn.c6h8o7.net/update.txt")).Value.Replace("new_ver"":", "")
        Label4.Text = "Build " & result
        If Label4.Text = Label2.Text Then
            MsgBox("您当前安装的是最新版本")
        Else
            MsgBox("存在更新版本，最新版本版本号为Build " & result)
            System.Diagnostics.Process.Start("http://pn.c6h8o7.net")
        End If
    End Sub
End Class