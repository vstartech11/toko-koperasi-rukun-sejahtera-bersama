Imports System.Data.SqlClient
Public Class formAkun
    Sub getData()
        Call koneksi()
        Da = New SqlDataAdapter("select * from tblUser", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tblUser")
        dgvAkun.DataSource = (Ds.Tables("tblUser"))
        Conn.Close()
    End Sub
    Sub getCombo()
        cmbxStatus.Items.Clear()
        Call koneksi()
        Cmd = New SqlCommand("select distinct status from tblUser", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            cmbxStatus.Items.Add(Rd.Item(0).ToString)
        Loop
        Conn.Close()
    End Sub
    Sub awal()
        Call getCombo()
        Call getData()
        txtbxNama.Enabled = False
        txtbxPass.Enabled = False
        txtbxUsername.Enabled = False
        cmbxStatus.Enabled = False
        btnSimpan.Enabled = False
        btnSimpan.Text = vbNullString
        txtbxNama.Text = vbNullString
        txtbxPass.Text = vbNullString
        cmbxStatus.Text = vbNullString
        txtbxUsername.Text = vbNullString
        rdoHapus.Checked = False
        rdoTambah.Checked = False
        rdoUbah.Checked = False
        cmbxStatus.MaxLength = 7
    End Sub
    Private Sub formAkun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal()
    End Sub

    Private Sub rdoTambah_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTambah.CheckedChanged
        If rdoTambah.Checked = True Then
            txtbxNama.Enabled = True
            txtbxPass.Enabled = True
            txtbxUsername.Enabled = True
            cmbxStatus.Enabled = True
            btnSimpan.Enabled = True
            btnSimpan.Text = "TAMBAH"
            txtbxUsername.Focus()
            MsgBox("Pastikan Username Belum Terdaftar !")
        Else
            Call awal()
        End If
    End Sub

    Private Sub rdoUbah_CheckedChanged(sender As Object, e As EventArgs) Handles rdoUbah.CheckedChanged
        If rdoUbah.Checked = True Then
            MsgBox("Silahkan Pilih Dari Daftar Akun", MsgBoxStyle.Information)
            dgvAkun.Focus()
        Else
            Call awal()
        End If
    End Sub

    Private Sub rdoHapus_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHapus.CheckedChanged
        If rdoHapus.Checked = True Then
            MsgBox("Silahkan Pilih Dari Daftar Akun", MsgBoxStyle.Information)
            dgvAkun.Focus()
        Else
            Call awal()
        End If
    End Sub

    Private Sub dgvAkun_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAkun.CellClick
        If rdoUbah.Checked = True Or rdoHapus.Checked = True Then
            txtbxUsername.Text = dgvAkun.Rows(e.RowIndex).Cells(0).Value.ToString
            txtbxNama.Text = dgvAkun.Rows(e.RowIndex).Cells(1).Value.ToString
            txtbxPass.Text = dgvAkun.Rows(e.RowIndex).Cells(2).Value.ToString
            cmbxStatus.Text = dgvAkun.Rows(e.RowIndex).Cells(3).Value.ToString
            If rdoHapus.Checked = True Then
                btnSimpan.Enabled = True
                btnSimpan.Text = "HAPUS"
            ElseIf rdoUbah.Checked = True Then
                btnSimpan.Enabled = True
                btnSimpan.Text = "SIMPAN"
                txtbxNama.Enabled = True
                txtbxPass.Enabled = True
                txtbxUsername.Enabled = True
                cmbxStatus.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If rdoHapus.Checked = True Then
            If (MsgBox("Yakin menghapus " + txtbxNama.Text + " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                Call koneksi()
                Cmd = New SqlCommand("delete from tblUser where username='" & txtbxUsername.Text & "'", Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Sukses menghapus " + txtbxNama.Text, MsgBoxStyle.Information)
                Conn.Close()
                Call awal()
            End If
        ElseIf rdoTambah.Checked = True Then
            If txtbxNama.Text = vbNullString Or txtbxPass.Text = vbNullString Or txtbxUsername.Text = vbNullString Or cmbxStatus.Text = vbNullString Then
                MsgBox("Silahkan isi semua kolom !!!", MsgBoxStyle.Information)
            Else
                Call koneksi()
                Cmd = New SqlCommand("insert into tblUser values('" & txtbxUsername.Text & "','" & txtbxNama.Text & "','" & txtbxPass.Text & "','" & cmbxStatus.Text & "')", Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Sukses menambahkan " + txtbxNama.Text, MsgBoxStyle.Information)
                Conn.Close()
                Call awal()
            End If
        ElseIf rdoUbah.Checked = True Then
            If txtbxNama.Text = vbNullString Or txtbxPass.Text = vbNullString Or txtbxUsername.Text = vbNullString Or cmbxStatus.Text = vbNullString Then
                MsgBox("Silahkan isi semua kolom !!!", MsgBoxStyle.Information)
            Else
                Call koneksi()
                Cmd = New SqlCommand("update tblUser set nama='" & txtbxNama.Text & "',password='" & txtbxPass.Text & "',status='" & cmbxStatus.Text & "' where username='" & txtbxUsername.Text & "'", Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Sukses mengubah " + txtbxNama.Text, MsgBoxStyle.Information)
                Conn.Close()
                Call awal()
            End If
        End If
    End Sub
End Class