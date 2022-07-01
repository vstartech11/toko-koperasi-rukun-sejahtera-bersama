Imports System.Data.SqlClient
Public Class formAnggota
    Sub awal()
        txtbxAlamat.Text = vbNullString
        txtbxHubAhli.Text = vbNullString
        txtbxNama.Text = vbNullString
        txtbxNamaAhli.Text = vbNullString
        txtbxNik.Text = vbNullString
        txtbxPekerjaan.Text = vbNullString
        txtbxTelp.Text = vbNullString
        cmbxKelamin.SelectedIndex = 0
        txtbxTelp.Enabled = False
        txtbxPekerjaan.Enabled = False
        txtbxNik.Enabled = False
        txtbxNamaAhli.Enabled = False
        txtbxNama.Enabled = False
        txtbxHubAhli.Enabled = False
        txtbxAlamat.Enabled = False
        cmbxKelamin.Enabled = False
        lblTanggal.Text = Date.Now.ToString("yyyy-MM-dd")
        lblNomor.Text = "KRB00000"
        lblNomor.Visible = True
        lblTanggal.Visible = True
        rdoHapus.Checked = False
        rdoTambah.Checked = False
        rdoUbah.Checked = False
        cmbxStatus.Enabled = False
        Call getCombo()
        Call getData()
    End Sub
    Sub getCombo()
        cmbxStatus.Items.Clear()
        Call koneksi()
        Cmd = New SqlCommand("select distinct status from tblAnggota", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            cmbxStatus.Items.Add(Rd.Item(0).ToString)
        Loop
        Conn.Close()
    End Sub
    Sub getData()
        Call koneksi()
        Da = New SqlDataAdapter("select * from tblAnggota", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tblAnggota")
        dgv.DataSource = (Ds.Tables("tblAnggota"))
        Conn.Close()
    End Sub
    Sub getNomor()
        Call koneksi()
        Cmd = New SqlCommand("select top 1 right(noAnggota,5)+1 as noAnggota from tblAnggota order by noAnggota desc", Conn)
        Rd = Cmd.ExecuteReader
        If Rd.Read Then
            Select Case Rd!noAnggota
                Case Is <= 9
                    lblNomor.Text = "KRB0000" & Rd!noAnggota
                Case Is <= 99
                    lblNomor.Text = "KRB000" & Rd!noAnggota
                Case Is <= 999
                    lblNomor.Text = "KRB00" & Rd!noAnggota
                Case Is <= 9999
                    lblNomor.Text = "KRB" & Rd!noAnggota
            End Select
        End If
        Conn.Close()
    End Sub
    Private Sub rdoTambah_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTambah.CheckedChanged
        If rdoTambah.Checked = True Then
            getNomor()
            txtbxAlamat.Enabled = True
            txtbxHubAhli.Enabled = True
            txtbxNama.Enabled = True
            txtbxNamaAhli.Enabled = True
            txtbxNik.Enabled = True
            txtbxPekerjaan.Enabled = True
            btnSimpan.Enabled = True
            cmbxKelamin.Enabled = True
            btnSimpan.Text = "TAMBAH"
            txtbxTelp.Enabled = True
        Else
            Call awal()
        End If
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

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If rdoTambah.Checked = True Then
            If txtbxAlamat.Text = vbNullString Or txtbxHubAhli.Text = vbNullString Or txtbxNama.Text = vbNullString Or txtbxNamaAhli.Text = vbNullString Or txtbxNik.Text = vbNullString Or txtbxPekerjaan.Text = vbNullString Or cmbxKelamin.Text = vbNullString Or lblNomor.Text = "KRB00000" Then
                MsgBox("Semua kolom wajib diisi !", MsgBoxStyle.Information)
            Else
                Call koneksi()
                Cmd = New SqlCommand("insert into tblAnggota values('" & lblNomor.Text & "','" & txtbxNama.Text & "','" & lblTanggal.Text & "','" & txtbxNik.Text & "','" & txtbxAlamat.Text & "','" & cmbxKelamin.Text & "','" & txtbxPekerjaan.Text & "','" & txtbxTelp.Text & "','" & txtbxNamaAhli.Text & "','" & txtbxHubAhli.Text & "','" & cmbxStatus.Text & "')", Conn)
                Cmd.ExecuteNonQuery()
                Conn.Close()
                Call koneksi()
                Cmd = New SqlCommand("insert into tblDSimpanan values('" & lblNomor.Text & "','0','0','0','0')", Conn)
                Cmd.ExecuteNonQuery()
                Conn.Close()
                Call koneksi()
                Cmd = New SqlCommand("Insert into tblHutang values('" & lblNomor.Text & "','0','" & Date.Now.ToString("yyyy-MM-dd") & "')", Conn)
                Cmd.ExecuteNonQuery()
                Conn.Close()
                MsgBox("Sukses memasukkan " + txtbxNama.Text, MsgBoxStyle.Information)
                Call awal()
            End If
        ElseIf rdoHapus.Checked = True Then
            If lblNomor.Text = "KRB00000" Then
                MsgBox("Data tidak valid ! Silahkan pilih dari daftar", MsgBoxStyle.Information)
            Else
                If (MsgBox("Yakin menghapus " + txtbxNama.Text + " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                    Call koneksi()
                    Cmd = New SqlCommand("delete from tblAnggota where noAnggota='" & lblNomor.Text & "'", Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Sukses menghapus " + txtbxNama.Text, MsgBoxStyle.Information)
                    Conn.Close()
                End If
                Call awal()
            End If
        ElseIf rdoUbah.Checked = True Then
            If txtbxAlamat.Text = vbNullString Or txtbxHubAhli.Text = vbNullString Or txtbxNama.Text = vbNullString Or txtbxNamaAhli.Text = vbNullString Or txtbxNik.Text = vbNullString Or txtbxPekerjaan.Text = vbNullString Or cmbxKelamin.Text = vbNullString Or lblNomor.Text = "KRB00000" Then
                MsgBox("Semua kolom wajib diisi !", MsgBoxStyle.Information)
            Else
                Call koneksi()
                Cmd = New SqlCommand("update tblAnggota set nama='" & txtbxNama.Text & "',nikKtp='" & txtbxNik.Text & "',alamat='" & txtbxAlamat.Text & "',jKelamin='" & cmbxKelamin.Text & "',pekerjaan='" & txtbxPekerjaan.Text & "',telp='" & txtbxTelp.Text & "',namaAhli='" & txtbxNamaAhli.Text & "',hubAhli='" & txtbxHubAhli.Text & "',status='" & cmbxStatus.Text & "' where noAnggota='" & lblNomor.Text & "'", Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Sukses mengubah " + txtbxNama.Text, MsgBoxStyle.Information)
                Conn.Close()
                Call awal()
            End If
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If rdoHapus.Checked = True Or rdoUbah.Checked = True Then
            lblNomor.Text = dgv.Rows(e.RowIndex).Cells(0).Value.ToString
            txtbxNama.Text = dgv.Rows(e.RowIndex).Cells(1).Value.ToString
            lblTanggal.Text = dgv.Rows(e.RowIndex).Cells(2).Value.ToString
            txtbxNik.Text = dgv.Rows(e.RowIndex).Cells(3).Value.ToString
            txtbxAlamat.Text = dgv.Rows(e.RowIndex).Cells(4).Value.ToString
            cmbxKelamin.Text = dgv.Rows(e.RowIndex).Cells(5).Value.ToString
            txtbxPekerjaan.Text = dgv.Rows(e.RowIndex).Cells(6).Value.ToString
            txtbxTelp.Text = dgv.Rows(e.RowIndex).Cells(7).Value.ToString
            txtbxNamaAhli.Text = dgv.Rows(e.RowIndex).Cells(8).Value.ToString
            txtbxHubAhli.Text = dgv.Rows(e.RowIndex).Cells(9).Value.ToString
            cmbxStatus.Text = dgv.Rows(e.RowIndex).Cells(10).Value.ToString

            txtbxTelp.Enabled = True
            txtbxPekerjaan.Enabled = True
            txtbxNik.Enabled = True
            txtbxNamaAhli.Enabled = True
            txtbxNama.Enabled = True
            txtbxHubAhli.Enabled = True
            txtbxAlamat.Enabled = True
            cmbxKelamin.Enabled = True
            cmbxStatus.Enabled = True
        End If
    End Sub

End Class