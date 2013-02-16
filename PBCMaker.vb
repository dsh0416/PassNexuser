Imports System
Imports System.Drawing.Printing


Public Class PBCMaker


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '生成随机种子
        Randomize()
        '生成随机的数字10000000-999999999
        Dim pbcid As Integer = CInt(Int((999999999 * Rnd())))
        PBCNumber.Text = pbcid

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


        Line1.Text = " 1    " + strArrayChar(0) + strArrayChar2(0) + strArrayChar3(0) + "    " + strArrayChar(1) + strArrayChar2(1) + strArrayChar3(1) + "    " + strArrayChar(2) + strArrayChar2(2) + strArrayChar3(2) + "    " + strArrayChar(3) + strArrayChar2(3) + strArrayChar3(3) + "    " + strArrayChar(4) + strArrayChar2(4) + strArrayChar3(4) + "    " + strArrayChar(5) + strArrayChar2(5) + strArrayChar3(5) + "    " + strArrayChar(6) + strArrayChar2(6) + strArrayChar3(6) + "    " + strArrayChar(7) + strArrayChar2(7) + strArrayChar3(7) + "    "
        Line2.Text = " 2    " + strArrayChar(8) + strArrayChar2(8) + strArrayChar3(8) + "    " + strArrayChar(9) + strArrayChar2(9) + strArrayChar3(9) + "    " + strArrayChar(10) + strArrayChar2(10) + strArrayChar3(10) + "    " + strArrayChar(11) + strArrayChar2(11) + strArrayChar3(11) + "    " + strArrayChar(12) + strArrayChar2(12) + strArrayChar3(12) + "    " + strArrayChar(13) + strArrayChar2(13) + strArrayChar3(13) + "    " + strArrayChar(14) + strArrayChar2(14) + strArrayChar3(14) + "    " + strArrayChar(15) + strArrayChar2(15) + strArrayChar3(15) + "    "
        Line3.Text = " 3    " + strArrayChar(16) + strArrayChar2(16) + strArrayChar3(16) + "    " + strArrayChar(17) + strArrayChar2(17) + strArrayChar3(17) + "    " + strArrayChar(18) + strArrayChar2(18) + strArrayChar3(18) + "    " + strArrayChar(19) + strArrayChar2(19) + strArrayChar3(19) + "    " + strArrayChar(20) + strArrayChar2(20) + strArrayChar3(20) + "    " + strArrayChar(21) + strArrayChar2(21) + strArrayChar3(21) + "    " + strArrayChar(22) + strArrayChar2(22) + strArrayChar3(22) + "    " + strArrayChar(23) + strArrayChar2(23) + strArrayChar3(23) + "    "
        Line4.Text = " 4    " + strArrayChar(24) + strArrayChar2(24) + strArrayChar3(24) + "    " + strArrayChar(25) + strArrayChar2(25) + strArrayChar3(25) + "    " + strArrayChar(26) + strArrayChar2(26) + strArrayChar3(26) + "    " + strArrayChar(27) + strArrayChar2(27) + strArrayChar3(27) + "    " + strArrayChar(28) + strArrayChar2(28) + strArrayChar3(28) + "    " + strArrayChar(29) + strArrayChar2(29) + strArrayChar3(29) + "    " + strArrayChar(30) + strArrayChar2(30) + strArrayChar3(30) + "    " + strArrayChar(31) + strArrayChar2(31) + strArrayChar3(31) + "    "
        Line5.Text = " 5    " + strArrayChar4(0) + strArrayChar5(0) + strArrayChar6(0) + "    " + strArrayChar4(1) + strArrayChar5(1) + strArrayChar6(1) + "    " + strArrayChar4(2) + strArrayChar5(2) + strArrayChar6(2) + "    " + strArrayChar4(3) + strArrayChar5(3) + strArrayChar6(3) + "    " + strArrayChar4(4) + strArrayChar5(4) + strArrayChar6(4) + "    " + strArrayChar4(5) + strArrayChar5(5) + strArrayChar6(5) + "    " + strArrayChar4(6) + strArrayChar5(6) + strArrayChar6(6) + "    " + strArrayChar4(7) + strArrayChar5(7) + strArrayChar6(7) + "    "
        Line6.Text = " 6    " + strArrayChar4(8) + strArrayChar5(8) + strArrayChar6(8) + "    " + strArrayChar4(9) + strArrayChar5(9) + strArrayChar6(9) + "    " + strArrayChar4(10) + strArrayChar5(10) + strArrayChar6(10) + "    " + strArrayChar4(11) + strArrayChar5(11) + strArrayChar6(11) + "    " + strArrayChar4(12) + strArrayChar5(12) + strArrayChar6(12) + "    " + strArrayChar4(13) + strArrayChar5(13) + strArrayChar6(13) + "    " + strArrayChar4(14) + strArrayChar5(14) + strArrayChar6(14) + "    " + strArrayChar4(15) + strArrayChar5(15) + strArrayChar6(15) + "    "
        Line7.Text = " 7    " + strArrayChar4(16) + strArrayChar5(16) + strArrayChar6(16) + "    " + strArrayChar4(17) + strArrayChar5(17) + strArrayChar6(17) + "    " + strArrayChar4(18) + strArrayChar5(18) + strArrayChar6(18) + "    " + strArrayChar4(19) + strArrayChar5(19) + strArrayChar6(19) + "    " + strArrayChar4(20) + strArrayChar5(20) + strArrayChar6(20) + "    " + strArrayChar4(21) + strArrayChar5(21) + strArrayChar6(21) + "    " + strArrayChar4(22) + strArrayChar5(22) + strArrayChar6(22) + "    " + strArrayChar4(23) + strArrayChar5(23) + strArrayChar6(23) + "    "
        Line8.Text = " 8    " + strArrayChar4(24) + strArrayChar5(24) + strArrayChar6(24) + "    " + strArrayChar4(25) + strArrayChar5(25) + strArrayChar6(25) + "    " + strArrayChar4(26) + strArrayChar5(26) + strArrayChar6(26) + "    " + strArrayChar4(27) + strArrayChar5(27) + strArrayChar6(27) + "    " + strArrayChar4(28) + strArrayChar5(28) + strArrayChar6(28) + "    " + strArrayChar4(29) + strArrayChar5(29) + strArrayChar6(29) + "    " + strArrayChar4(30) + strArrayChar5(30) + strArrayChar6(30) + "    " + strArrayChar4(31) + strArrayChar5(31) + strArrayChar6(31) + "    "
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintPreview.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
    End Sub

    Private Sub PBCNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PBCNumber.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class