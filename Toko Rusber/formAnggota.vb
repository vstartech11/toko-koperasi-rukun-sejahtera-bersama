Imports System.Data.SqlClient
Public Class formAnggota
    Sub awal()
        lblTanggal.Text = DateTime.Now.ToString("yyyy-MM-dd")
        lblNomor.Text = "KRB00000"
    End Sub
    Private Sub rdoTambah_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTambah.CheckedChanged

    End Sub

    Private Sub rdoUbah_CheckedChanged(sender As Object, e As EventArgs) Handles rdoUbah.CheckedChanged
        If rdoUbah.Checked = True Then
            MsgBox("Silahkan Pilih Data Dari Daftar")
            btnSimpan.Enabled = True
            btnSimpan.Text = "SIMPAN"
        Else
            Call awal()
        End If
    End Sub

    Private Sub rdoHapus_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHapus.CheckedChanged
        If rdoHapus.Checked = True Then
            MsgBox("Silahkan Pilih Data Dari Daftar")
            btnSimpan.Enabled = True
            btnSimpan.Text = "HAPUS"
        Else
            Call awal()
        End If
    End Sub

    Private Sub formAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal()
    End Sub
End Class