Public Class PBCLoad
    Public PS11 As Integer
    Public PS12 As Integer
    Public PS21 As Integer
    Public PS22 As Integer
    Public CON1 As Integer
    Public CON2 As Integer
    Public CONa As String
    Public CONb As String

    Private Sub PBCMake_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCMake.Click
        PBCMaker.Show()
    End Sub

    Private Sub PBCLoad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If PassNexuser.Text = "PassNexuser" Then
        PBCMake.Enabled = True
        'End If


        Randomize()
        PS11 = CInt(Int((8 * Rnd()) + 1))
        Randomize()
        PS12 = CInt(Int((8 * Rnd()) + 1))
        Randomize()
        PS21 = CInt(Int((8 * Rnd()) + 1))
        Randomize()
        PS22 = CInt(Int((8 * Rnd()) + 1))
        Dim PS11s As String = "A"
        Dim PS21s As String = "A"

        If PS11 = 1 Then PS11s = "A"
        If PS11 = 2 Then PS11s = "B"
        If PS11 = 3 Then PS11s = "C"
        If PS11 = 4 Then PS11s = "D"
        If PS11 = 5 Then PS11s = "E"
        If PS11 = 6 Then PS11s = "F"
        If PS11 = 7 Then PS11s = "G"
        If PS11 = 8 Then PS11s = "H"

        If PS21 = 1 Then PS21s = "A"
        If PS21 = 2 Then PS21s = "B"
        If PS21 = 3 Then PS21s = "C"
        If PS21 = 4 Then PS21s = "D"
        If PS21 = 5 Then PS21s = "E"
        If PS21 = 6 Then PS21s = "F"
        If PS21 = 7 Then PS21s = "G"
        If PS21 = 8 Then PS21s = "H"

        Dim PSV1 As String = PS11s & PS12
        Dim PSV2 As String = PS21s & PS22

        PS1.Text = PSV1
        PS2.Text = PSV2
    End Sub

    Private Sub Confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Confirm.Click
        Dim pbcid As String = TextBox1.Text
        Dim Serial As String = pbcid
        Dim ProName As String = "PBC1"
        Dim source As String = Serial + ProName
        Dim PassNum As Integer = 2
        Dim hashbase As String = getMd5Hash(source)
        For i As Integer = 1 To PassNum
            source = hashbase + ProName
            hashbase = getMd5Hash(source)
        Next
        Dim hash1 As String = hashbase

        ProName = "PBC2"
        source = Serial + ProName
        PassNum = 2
        hashbase = getMd5Hash(source)
        For i As Integer = 1 To PassNum
            source = hashbase + ProName
            hashbase = getMd5Hash(source)
        Next
        Dim hash2 As String = hashbase

        ProName = "PBC3"
        source = Serial + ProName
        PassNum = 2
        hashbase = getMd5Hash(source)
        For i As Integer = 1 To PassNum
            source = hashbase + ProName
            hashbase = getMd5Hash(source)
        Next
        Dim hash3 As String = hashbase

        ProName = "PBC4"
        source = Serial + ProName
        PassNum = 2
        hashbase = getMd5Hash(source)
        For i As Integer = 1 To PassNum
            source = hashbase + ProName
            hashbase = getMd5Hash(source)
        Next
        Dim hash4 As String = hashbase

        ProName = "PBC5"
        source = Serial + ProName
        PassNum = 2
        hashbase = getMd5Hash(source)
        For i As Integer = 1 To PassNum
            source = hashbase + ProName
            hashbase = getMd5Hash(source)
        Next
        Dim hash5 As String = hashbase

        ProName = "PBC6"
        source = Serial + ProName
        PassNum = 2
        hashbase = getMd5Hash(source)
        For i As Integer = 1 To PassNum
            source = hashbase + ProName
            hashbase = getMd5Hash(source)
        Next
        Dim hash6 As String = hashbase

        '生成密码组数据


        Dim strData As String = hash1
        Dim strArrayChar() As Char
        strArrayChar = strData.ToCharArray()

        Dim strData2 As String = hash2
        Dim strArrayChar2() As Char
        strArrayChar2 = strData2.ToCharArray()

        Dim strData3 As String = hash3
        Dim strArrayChar3() As Char
        strArrayChar3 = strData3.ToCharArray()

        Dim strData4 As String = hash4
        Dim strArrayChar4() As Char
        strArrayChar4 = strData4.ToCharArray()

        Dim strData5 As String = hash5
        Dim strArrayChar5() As Char
        strArrayChar5 = strData5.ToCharArray()

        Dim strData6 As String = hash6
        Dim strArrayChar6() As Char
        strArrayChar6 = strData6.ToCharArray()
        '拆分数据

        For i As Integer = 0 To 31
            Select Case strArrayChar(i)
                Case "0"
                    strArrayChar(i) = "g"
                Case "1"
                    strArrayChar(i) = "h"
                Case "2"
                    strArrayChar(i) = "j"
                Case "3"
                    strArrayChar(i) = "k"
                Case "4"
                    strArrayChar(i) = "m"
                Case "5"
                    strArrayChar(i) = "n"
                Case "6"
                    strArrayChar(i) = "p"
                Case "7"
                    strArrayChar(i) = "q"
                Case "8"
                    strArrayChar(i) = "r"
                Case "9"
                    strArrayChar(i) = "s"
            End Select
        Next

        For i As Integer = 0 To 31
            Select Case strArrayChar2(i)
                Case "0"
                    strArrayChar2(i) = "g"
                Case "1"
                    strArrayChar2(i) = "h"
                Case "2"
                    strArrayChar2(i) = "j"
                Case "3"
                    strArrayChar2(i) = "k"
                Case "4"
                    strArrayChar2(i) = "m"
                Case "5"
                    strArrayChar2(i) = "n"
                Case "6"
                    strArrayChar2(i) = "p"
                Case "7"
                    strArrayChar2(i) = "q"
                Case "8"
                    strArrayChar2(i) = "r"
                Case "9"
                    strArrayChar2(i) = "s"
            End Select
        Next
        For i As Integer = 0 To 31
            Select Case strArrayChar3(i)
                Case "0"
                    strArrayChar3(i) = "g"
                Case "1"
                    strArrayChar3(i) = "h"
                Case "2"
                    strArrayChar3(i) = "j"
                Case "3"
                    strArrayChar3(i) = "k"
                Case "4"
                    strArrayChar3(i) = "m"
                Case "5"
                    strArrayChar3(i) = "n"
                Case "6"
                    strArrayChar3(i) = "p"
                Case "7"
                    strArrayChar3(i) = "q"
                Case "8"
                    strArrayChar3(i) = "r"
                Case "9"
                    strArrayChar3(i) = "s"
            End Select
        Next

        For i As Integer = 0 To 31
            Select Case strArrayChar4(i)
                Case "0"
                    strArrayChar4(i) = "g"
                Case "1"
                    strArrayChar4(i) = "h"
                Case "2"
                    strArrayChar4(i) = "j"
                Case "3"
                    strArrayChar4(i) = "k"
                Case "4"
                    strArrayChar4(i) = "m"
                Case "5"
                    strArrayChar4(i) = "n"
                Case "6"
                    strArrayChar4(i) = "p"
                Case "7"
                    strArrayChar4(i) = "q"
                Case "8"
                    strArrayChar4(i) = "r"
                Case "9"
                    strArrayChar4(i) = "s"
            End Select
        Next

        For i As Integer = 0 To 31
            Select Case strArrayChar5(i)
                Case "0"
                    strArrayChar5(i) = "g"
                Case "1"
                    strArrayChar5(i) = "h"
                Case "2"
                    strArrayChar5(i) = "j"
                Case "3"
                    strArrayChar5(i) = "k"
                Case "4"
                    strArrayChar5(i) = "m"
                Case "5"
                    strArrayChar5(i) = "n"
                Case "6"
                    strArrayChar5(i) = "p"
                Case "7"
                    strArrayChar5(i) = "q"
                Case "8"
                    strArrayChar5(i) = "r"
                Case "9"
                    strArrayChar5(i) = "s"
            End Select
        Next

        For i As Integer = 0 To 31
            Select Case strArrayChar6(i)
                Case "0"
                    strArrayChar6(i) = "g"
                Case "1"
                    strArrayChar6(i) = "h"
                Case "2"
                    strArrayChar6(i) = "j"
                Case "3"
                    strArrayChar6(i) = "k"
                Case "4"
                    strArrayChar6(i) = "m"
                Case "5"
                    strArrayChar6(i) = "n"
                Case "6"
                    strArrayChar6(i) = "p"
                Case "7"
                    strArrayChar6(i) = "q"
                Case "8"
                    strArrayChar6(i) = "r"
                Case "9"
                    strArrayChar6(i) = "s"
            End Select
        Next
        '预处理数据防止ilo等混淆字母，处理掉数字

        For i As Integer = 0 To 31
            strArrayChar(i) = UCase(strArrayChar(i))
            strArrayChar2(i) = UCase(strArrayChar2(i))
            strArrayChar3(i) = UCase(strArrayChar3(i))
            strArrayChar4(i) = UCase(strArrayChar4(i))
            strArrayChar5(i) = UCase(strArrayChar5(i))
            strArrayChar6(i) = UCase(strArrayChar6(i))
        Next

        If PS12 <= 4 Then
            CON1 = ((PS12 - 1) * 8) + (PS11 - 1)
            CONa = strArrayChar(CON1) & strArrayChar2(CON1) & strArrayChar3(CON1)
        Else
            CON1 = ((PS12 - 5) * 8) + (PS11 - 1)
            CONa = strArrayChar4(CON1) & strArrayChar5(CON1) & strArrayChar6(CON1)
        End If
        If PS22 <= 4 Then
            CON2 = ((PS22 - 1) * 8) + (PS21 - 1)
            CONb = strArrayChar(CON2) & strArrayChar2(CON2) & strArrayChar3(CON2)
        Else
            CON2 = ((PS22 - 5) * 8) + (PS21 - 1)
            CONb = strArrayChar4(CON2) & strArrayChar5(CON2) & strArrayChar6(CON2)
        End If
        Dim Finale As String = CONa & CONb
        If TextBox2.Text = Finale Then
            MsgBox("验证通过")
            PassNexuser.PBCode = TextBox1.Text
            PassNexuser.PBCShow.Text = "已装载" & TextBox1.Text
            Me.Close()
        Else
            MsgBox("您输入的数据有误")
            Me.Close()
        End If
    End Sub
End Class