Imports System.Text.RegularExpressions
Module GetUpdate
    Public Function GetCode(ByVal _URL As String) As String
        Try
            Dim req As Net.HttpWebRequest = Net.WebRequest.Create(_URL)
            Dim res As Net.HttpWebResponse = req.GetResponse()
            Dim strm As IO.StreamReader = New IO.StreamReader(res.GetResponseStream(), System.Text.Encoding.Default)
            Return strm.ReadToEnd
        Catch ex As Exception
            Return ""
        End Try
    End Function


End Module
