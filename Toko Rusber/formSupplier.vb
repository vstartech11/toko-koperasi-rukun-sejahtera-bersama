Imports System.Data.SqlClient
Public Class formSupplier
    Sub awal()
        Call tampilGrid()
        rdoHapus.Checked = False
        rdoTambah.Checked = False
        rdoUbah.Checked = False
        txtbxAlamat.Enabled = False
        txtbxNama.Enabled = False
        txtbxTelp.Enabled = False
        btnSimpan.Enabled = False
        btnSimpan.Text = vbNullString
        txtbxAlamat.Text = vbNullString
        txtbxNama.Text = vbNullString
        txtbxTelp.Text = vbNullString
        lblId.Text = "0"
    End Sub
    Sub tampilGrid()
        Call koneksi()
        Da = New SqlDataAdapter("select * from tblSupplier", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tblSupplier")
        dgvSupplier.DataSource = (Ds.Tables("tblSupplier"))
        Conn.Close()
    End Sub

    Private Sub formSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If rdoTambah.Checked = True Then
            If (txtbxNama.Text = vbNullString) Or (txtbxAlamat.Text = vbNullString) Or (txtbxTelp.Text = vbNullString) Or lblId.Text = "0" Then
                MsgBox("Semua kolom wajib diisi !", MsgBoxStyle.Information)
            Else
                Call koneksi()
                Cmd = New SqlCommand("insert into tblSupplier(namaSupplier, alamat, telp) values('" & txtbxNama.Text & "','" & txtbxAlamat.Text & "','" & txtbxTelp.Text & "')", Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Sukses memasukkan " + txtbxNama.Text, MsgBoxStyle.Information)
                Conn.Close()
                Call awal
            End If
        ElseIf rdoUbah.Checked = True Then
            If (txtbxNama.Text = vbNullString) Or (txtbxAlamat.Text = vbNullString) Or (txtbxTelp.Text = vbNullString) Or lblId.Text = "0" Then
                MsgBox("Silahkan pilih data dari daftar !", MsgBoxStyle.Information)
            Else
                Call koneksi()
                Cmd = New SqlCommand("update tblSupplier set namaSupplier='" & txtbxNama.Text & "',alamat='" & txtbxAlamat.Text & "',telp='" & txtbxTelp.Text & "' where id='" & lblId.Text & "'", Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Skses mengubah " + txtbxNama.Text, MsgBoxStyle.Information)
                Conn.Close()
                Call awal()
            End If
        ElseIf rdoHapus.Checked = True Then
            If lblId.Text = "0" Then
                MsgBox("Data tidak valid ! Silahkan pilih data dari daftar !", MsgBoxStyle.Information)
            Else
                Call koneksi()
                Cmd = New SqlCommand("delete from tblSupplier where id='" & lblId.Text & "'", Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Sukses menghapus " + txtbxNama.Text, MsgBoxStyle.Information)
                Conn.Close()
                Call awal()
            End If
        End If
    End Sub

    Private Sub rdoTambah_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTambah.CheckedChanged
        If rdoTambah.Checked = True Then
            txtbxAlamat.Enabled = True
            txtbxNama.Enabled = True
            txtbxTelp.Enabled = True
            btnSimpan.Enabled = True
            btnSimpan.Text = "TAMBAH"
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

    Private Sub dgvSupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplier.CellClick
        If rdoHapus.Checked = True Or rdoUbah.Checked = True Then
            lblId.Text = dgvSupplier.Rows(e.RowIndex).Cells(0).Value.ToString
            txtbxNama.Text = dgvSupplier.Rows(e.RowIndex).Cells(1).Value.ToString
            txtbxAlamat.Text = dgvSupplier.Rows(e.RowIndex).Cells(2).Value.ToString
            txtbxTelp.Text = dgvSupplier.Rows(e.RowIndex).Cells(3).Value.ToString

            txtbxNama.Enabled = True
            txtbxAlamat.Enabled = True
            txtbxTelp.Enabled = True
        End If
    End Sub

    Private Sub txtbxTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxTelp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class