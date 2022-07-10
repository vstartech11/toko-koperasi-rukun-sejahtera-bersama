Imports System.Data.SqlClient
Public Class formDataBarang
    Sub awal()
        rdoHapus.Checked = False
        rdoTambah.Checked = False
        rdoUbah.Checked = False
        txtbxBarcode.Enabled = False
        txtbxJualAnggota.Enabled = False
        txtbxJualBon.Enabled = False
        txtbxJualUmum.Enabled = False
        txtbxModal.Enabled = False
        txtbxNama.Enabled = False
        txtbxStok.Enabled = False
        cmbxKategori.Enabled = False
        btnSimpan.Enabled = False
        btnSimpan.Text = vbNullString
        txtbxBarcode.Text = vbNullString
        txtbxJualAnggota.Text = vbNullString
        txtbxJualBon.Text = vbNullString
        txtbxJualUmum.Text = vbNullString
        txtbxModal.Text = vbNullString
        txtbxNama.Text = vbNullString
        txtbxStok.Text = vbNullString
        cmbxKategori.Text = vbNullString
        btnSimpan.Text = vbNullString
        Call getData()
        Call getCombo()
    End Sub
    Sub getCombo()
        cmbxKategori.Items.Clear()
        Call koneksi()
        Cmd = New SqlCommand("select distinct kategori from tblBarang", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            cmbxKategori.Items.Add(Rd.Item(0).ToString)
        Loop
        Conn.Close()
    End Sub
    Sub getData()
        Call koneksi()
        Da = New SqlDataAdapter("Select * from tblBarang", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tblBarang")
        dgvBarang.DataSource = (Ds.Tables("tblBarang"))
        Conn.Close()
    End Sub
    Private Sub rdoTambah_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTambah.CheckedChanged
        If rdoTambah.Checked = True Then
            txtbxStok.Enabled = True
            txtbxNama.Enabled = True
            txtbxModal.Enabled = True
            txtbxJualUmum.Enabled = True
            txtbxJualBon.Enabled = True
            txtbxJualAnggota.Enabled = True
            txtbxBarcode.Enabled = True
            cmbxKategori.Enabled = True
            btnSimpan.Enabled = True
            btnSimpan.Text = "TAMBAH"
        Else
            Call awal()
        End If

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If rdoHapus.Checked = True Then
            If txtbxBarcode.Text = vbNullString Then
                MsgBox("Tidak Valid, silahkan pilih data !", MsgBoxStyle.Information)
            Else
                If (MsgBox("Yakin menghapus data " + txtbxNama.Text + " ? karena barang sudah memiliki transaksi", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                    Call koneksi()
                    Cmd = New SqlCommand("delete from tblBarang where barcode='" & txtbxBarcode.Text & "'", Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Sukses menghapus data " + txtbxNama.Text, MsgBoxStyle.Information)
                    Conn.Close()
                    Call awal()
                End If
            End If
        ElseIf rdoTambah.Checked = True Then
            If txtbxBarcode.Text = vbNullString Or txtbxJualAnggota.Text = vbNullString Or txtbxJualBon.Text = vbNullString Or txtbxJualUmum.Text = vbNullString Or txtbxModal.Text = vbNullString Or txtbxNama.Text = vbNullString Or txtbxStok.Text = vbNullString Or cmbxKategori.Text = vbNullString Then
                MsgBox("Semua kolom wajib di isi !!!")
            Else
                Call koneksi()
                Cmd = New SqlCommand("select * from tblBarang where barcode='" & txtbxBarcode.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                If Rd.HasRows Then
                    MsgBox("Data dengan barcode " + txtbxBarcode.Text + " telah terdaftar !")
                    Conn.Close()
                Else
                    Call koneksi()
                    Cmd = New SqlCommand("insert into tblBarang values('" & txtbxBarcode.Text & "','" & txtbxNama.Text & "','" & cmbxKategori.Text & "','" & txtbxStok.Text & "','" & txtbxModal.Text & "','" & txtbxJualUmum.Text & "','" & txtbxJualAnggota.Text & "','" & txtbxJualBon.Text & "')", Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Sukses menambahkan " + txtbxNama.Text)
                    Conn.Close()
                    Call awal()
                End If

            End If
        ElseIf rdoUbah.Checked = True Then
            If txtbxBarcode.Text = vbNullString Or txtbxJualAnggota.Text = vbNullString Or txtbxJualBon.Text = vbNullString Or txtbxJualUmum.Text = vbNullString Or txtbxModal.Text = vbNullString Or txtbxNama.Text = vbNullString Or txtbxStok.Text = vbNullString Or cmbxKategori.Text = vbNullString Then
                MsgBox("Semua kolom wajib di isi !!!")
            Else
                Call koneksi()
                Cmd = New SqlCommand("update tblBarang set namaBarang='" & txtbxNama.Text & "',kategori='" & cmbxKategori.Text & "',stockBarang='" & txtbxStok.Text & "',hargaModal='" & txtbxModal.Text & "',hJualUmum='" & txtbxJualUmum.Text & "',hJualAnggota='" & txtbxJualAnggota.Text & "',hBonAnggota='" & txtbxJualBon.Text & "' where barcode='" & txtbxBarcode.Text & "'", Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Sukses mengubah data " + txtbxNama.Text)
                Conn.Close()
                Call awal()
            End If
        End If
    End Sub

    Private Sub formDataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal()
    End Sub

    Private Sub rdoUbah_CheckedChanged(sender As Object, e As EventArgs) Handles rdoUbah.CheckedChanged
        If rdoUbah.Checked = True Then
            MsgBox("Silahkan pilih data dari daftar !", MsgBoxStyle.Information)
        Else
            Call awal()
        End If
    End Sub

    Private Sub rdoHapus_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHapus.CheckedChanged
        If rdoHapus.Checked = True Then
            MsgBox("Silahkan pilih data dari daftar !", MsgBoxStyle.Information)
        Else
            Call awal()
        End If
    End Sub

    Private Sub dgvBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBarang.CellClick
        If rdoHapus.Checked = True Or rdoUbah.Checked = True Then
            txtbxBarcode.Text = dgvBarang.Rows(e.RowIndex).Cells(0).Value.ToString
            txtbxNama.Text = dgvBarang.Rows(e.RowIndex).Cells(1).Value.ToString
            cmbxKategori.Text = dgvBarang.Rows(e.RowIndex).Cells(2).Value.ToString
            txtbxStok.Text = dgvBarang.Rows(e.RowIndex).Cells(3).Value.ToString
            txtbxModal.Text = dgvBarang.Rows(e.RowIndex).Cells(4).Value.ToString
            txtbxJualUmum.Text = dgvBarang.Rows(e.RowIndex).Cells(5).Value.ToString
            txtbxJualAnggota.Text = dgvBarang.Rows(e.RowIndex).Cells(6).Value.ToString
            txtbxJualBon.Text = dgvBarang.Rows(e.RowIndex).Cells(7).Value.ToString
            btnSimpan.Enabled = True
            If rdoHapus.Checked = True Then
                btnSimpan.Text = "HAPUS"
            ElseIf rdoUbah.Checked = True Then
                btnSimpan.Text = "SIMPAN"
                txtbxNama.Enabled = True
                txtbxStok.Enabled = True
                txtbxModal.Enabled = True
                txtbxJualUmum.Enabled = True
                txtbxJualBon.Enabled = True
                txtbxJualAnggota.Enabled = True
                txtbxBarcode.Enabled = False
                cmbxKategori.Enabled = True
            End If
        Else
            MsgBox("Silahkan pilih opsi tambah/ubah/hapus !")
            Call awal()
        End If

    End Sub

    Private Sub txtbxCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxCari.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtbxCari.Text = vbNullString Then
                Call getData()
            Else
                Call koneksi()
                Da = New SqlDataAdapter("Select * from tblBarang where namaBarang like '%" & txtbxCari.Text & "%' or barcode like '%" & txtbxCari.Text & "%'", Conn)
                Ds = New DataSet
                Ds.Clear()
                Da.Fill(Ds, "tblBarang")
                dgvBarang.DataSource = (Ds.Tables("tblBarang"))
                Conn.Close()
            End If
        End If
    End Sub
End Class