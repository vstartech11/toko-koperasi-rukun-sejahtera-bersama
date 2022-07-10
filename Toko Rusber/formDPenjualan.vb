Imports System.Data.SqlClient
Public Class formDPenjualan
    Sub awal()
        Call getData()

    End Sub
    Sub getData()
        Call koneksi()
        Da = New SqlDataAdapter("Select * from tblDPenjualan", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tblDPenjualan")
        dgvDPenjualan.DataSource = (Ds.Tables("tblDPenjualan"))
        Conn.Close()
    End Sub
    Private Sub formDPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal()
    End Sub

    Private Sub txtbxCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxCari.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtbxCari.Text = vbNullString Then
                Call getData()
            Else
                Call koneksi()
                Da = New SqlDataAdapter("kosong", Conn)
                Ds = New DataSet
                Ds.Clear()
                Da.Fill(Ds, "kosong")
                dgvDPenjualan.DataSource = (Ds.Tables("kosong"))
                Conn.Close()
            End If
        End If
    End Sub
End Class