Imports System.Data.SqlClient
Module moduleKoneksi
    Public Da As SqlDataAdapter
    Public Rd As SqlDataReader
    Public Ds As DataSet
    Public Str As String
    Public Cmd As SqlCommand
    Public Conn As SqlConnection

    Sub koneksi()
        Str = "Data Source=localhost\SQLEXPRESS;Initial Catalog=dbKoperasi;Persist Security Info=True;User ID=bintang;Password=441840"
        Conn = New SqlConnection(Str)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
