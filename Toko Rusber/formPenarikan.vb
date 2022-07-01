Imports System.Data.SqlClient
Public Class formPenarikan
    Sub awal()
        Call getData()
        Call getID()
    End Sub
    Sub getID()
        Call koneksi()
        Cmd = New SqlCommand("select top 1 right(idPenarikan,5)+1 as n from tblPenarikan order by idPenarikan desc", Conn)
        Rd = Cmd.ExecuteReader
        If Rd.Read Then
            Select Case Rd!n
                Case Is <= 9
                    lblId.Text = "P0000" & Rd!n
                Case Is <= 99
                    lblId.Text = "P000" & Rd!n
                Case Is <= 999
                    lblId.Text = "P00" & Rd!n
                Case Is <= 9999
                    lblId.Text = "P" & Rd!n
            End Select
        End If
        Conn.Close()
    End Sub
    Sub getData()
        Call koneksi()
        Da = New SqlDataAdapter("select tblPenarikan.idPenarikan,tblPenarikan.tanggal,tblAnggota.nama,tblPenarikan.jumlah from tblPenarikan join tblAnggota on tblAnggota.noAnggota=tblPenarikan.noAnggota", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tblPenarikan")
        dgvPenarikan.DataSource = (Ds.Tables("tblPenarikan"))
        Conn.Close()
    End Sub
    Private Sub formPenarikan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If btnSimpan.Text = "CARI" Then
            If txtbxId.Text = "" Or txtbxId.Text = " " Then
                MsgBox("Kolom ID Anggota tidak boleh kosong !")
                txtbxId.Focus()
            Else
                txtbxId.Enabled = False
                btnSimpan.Text = "TARIK"
                Call koneksi()
                Cmd = New SqlCommand("select tblAnggota.nama,tblDSimpanan.tSukarela from tblAnggota join tblDSimpanan on tblAnggota.noAnggota=tblDSimpanan.noAnggota where noAnggota='" & txtbxId.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                If Rd.Read Then
                    lblNama.Text = Rd!nama
                    lblSimpanan.Text = Rd!tSukarela
                End If
            End If
        ElseIf btnSimpan.Text = "TARIK" Then
            If Val(txtbxPenarikan.Text) > Val(lblSimpanan.Text) Then
                MsgBox("Jumlah yang ditarik melebihi simpanan !")
                txtbxPenarikan.Text = ""
                txtbxPenarikan.Focus()
            Else

            End If

        End If

    End Sub
End Class