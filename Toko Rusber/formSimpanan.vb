Imports System.Data.SqlClient
Public Class formSimpanan
    Sub awal()
        Call getData()
        dtpTanggal.CustomFormat = "yyyy-MM-dd"
        txtbxIDAnggota.Enabled = False
        txtbxJumlah.Enabled = False
        cmbxJenis.Enabled = False
        dtpTanggal.Value = Today
        dtpTanggal.Enabled = False
        lblId.Text = "S00000"
        txtbxJumlah.Text = vbNullString
        txtbxIDAnggota.Text = vbNullString
        cmbxJenis.Text = vbNullString
        btnSimpan.Text = "TAMBAH"
        btnSimpan.Enabled = True
    End Sub
    Sub getData()
        Call koneksi()
        Da = New SqlDataAdapter("select tblSimpanan.idSimpanan,tblSimpanan.tanggal,tblAnggota.nama,tblSimpanan.jenisSimpanan,tblSimpanan.jumlah from tblSimpanan join tblAnggota on tblAnggota.noAnggota=tblSimpanan.noAnggota", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tblSimpanan")
        DataGridView1.DataSource = (Ds.Tables("tblSimpanan"))
        Conn.Close()
    End Sub
    Sub getID()
        Call koneksi()
        Cmd = New SqlCommand("select top 1 right(idSimpanan,5)+1 as n from tblSimpanan order by idSimpanan desc", Conn)
        Rd = Cmd.ExecuteReader
        If Rd.Read Then
            Select Case Rd!n
                Case Is <= 9
                    lblId.Text = "S0000" & Rd!n
                Case Is <= 99
                    lblId.Text = "S000" & Rd!n
                Case Is <= 999
                    lblId.Text = "S00" & Rd!n
                Case Is <= 9999
                    lblId.Text = "S" & Rd!n
            End Select
        End If
        Conn.Close()
    End Sub
    Private Sub formSimpanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If btnSimpan.Text = "TAMBAH" Then
            txtbxIDAnggota.Enabled = True
            txtbxJumlah.Enabled = True
            cmbxJenis.Enabled = True
            dtpTanggal.Enabled = True
            btnSimpan.Text = "SIMPAN"
            Call getID()
        End If
    End Sub

    Private Sub cmbxJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxJenis.SelectedIndexChanged
        If txtbxIDAnggota.Text = vbNullString Then
        Else
            Call koneksi()
            Cmd = New SqlCommand("Select nama from tblAnggota where noAnggota='" & txtbxIDAnggota.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            If Rd.Read Then
                Conn.Close()
                Call koneksi()
                Cmd = New SqlCommand("select jenisSimpanan,left(tanggal,7) from tblSimpanan where noAnggota='" & txtbxIDAnggota.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                If Rd.HasRows Then
                    If cmbxJenis.Text = "POKOK" Then
                        Do While Rd.Read
                            If Rd.Item(0).ToString = "POKOK" Then
                                MsgBox("Simpanan Pokok Telah Ada !")
                                Call awal()
                            Else
                                txtbxJumlah.Focus()
                            End If
                        Loop
                    ElseIf cmbxJenis.Text = "WAJIB" Then
                        Do While Rd.Read
                            If Rd.Item(0).ToString = "WAJIB" And Rd.Item(1).ToString = Date.Now.ToString("yyyy-MM") Then
                                MsgBox("Simpanan Wajib Telah Ada !")
                                Call awal()
                            Else
                                txtbxJumlah.Focus()
                            End If
                        Loop
                    End If
                End If

            Else
                MsgBox("ID Anggota tidak terdaftar !!!")
                txtbxIDAnggota.Text = vbNullString
                txtbxIDAnggota.Focus()
                cmbxJenis.ResetText()
            End If
        End If
    End Sub
End Class