Imports System.Data.SqlClient
Public Class formDHutang
    Dim noAnggota As String
    Sub awal()
        Call getData()
        txtbxCari.Text = vbNullString
        txtbxCari.Enabled = True
        btnCari.Enabled = True
        btnHapus.Enabled = False
        lblJHutang.Text = vbNullString
        lblNama.Text = vbNullString
        noAnggota = vbNullString

    End Sub
    Sub getData()
        Call koneksi()
        Da = New SqlDataAdapter("select tblAnggota.nama,tblHutang.tHutang,tblHutang.tglHutang from tblHutang join tblAnggota on tblAnggota.noAnggota=tblHutang.noAnggota", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "tblHutang")
        dgvHutang.DataSource = (Ds.Tables("tblHutang"))
        Conn.Close()
    End Sub
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtbxCari.Text = vbNullString Or txtbxCari.Text = " " Then
            Call getData()
        Else
            Call koneksi()
            Da = New SqlDataAdapter("select tblAnggota.nama,tblHutang.tHutang,tblHutang.tglHutang from tblHutang join tblAnggota on tblAnggota.noAnggota=tblHutang.noAnggota where tblAnggota.noAnggota like '%" & txtbxCari.Text & "%' OR tblHutang.tglHutang like '%" & txtbxCari.Text & "%'", Conn)
            Ds = New DataSet
            Ds.Clear()
            Da.Fill(Ds, "tblHutang")
            dgvHutang.DataSource = (Ds.Tables("tblHutang"))
            Conn.Close()
        End If
    End Sub

    Private Sub formDHutang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal()
    End Sub

    Private Sub dgvHutang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHutang.CellClick
        btnCari.Enabled = False
        txtbxCari.Enabled = False
        Call koneksi()
        Cmd = New SqlCommand("Select noAnggota from tblAnggota where nama='" & dgvHutang.Rows(e.RowIndex).Cells(0).Value.ToString & "'", Conn)
        Rd = Cmd.ExecuteReader
        If Rd.Read Then
            noAnggota = Rd.Item(0).ToString
            lblNama.Text = dgvHutang.Rows(e.RowIndex).Cells(0).Value.ToString
            lblJHutang.Text = dgvHutang.Rows(e.RowIndex).Cells(1).Value.ToString
            btnHapus.enabled = True
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If (MsgBox("Yakin mereset hutang saudara " + lblNama.Text + " sejumlah " + lblJHutang.Text, MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            Call koneksi()
            Cmd = New SqlCommand("update tblHutang set tHutang='0',tglHutang='" & Date.Now.ToString("yyyy-MM-dd") & "' where noAnggota='" & noAnggota & "'", Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Sukses mereset hutang, trimss")
            Call awal()
        End If
    End Sub
End Class