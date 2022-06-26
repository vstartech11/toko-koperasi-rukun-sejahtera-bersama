Imports System.Data.SqlClient
Public Class formUbahPass
    Sub awal()
        txtbxPassLama.Text = vbNullString
        txtbxPassBaru.Text = vbNullString
        txtbxKonfirm.Text = vbNullString
        txtbxPassLama.Focus()
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtbxPassLama.Text = vbNullString Or txtbxPassBaru.Text = vbNullString Or txtbxKonfirm.Text = vbNullString Then
            MsgBox("Semua kolom wajib diisi !")
            Call awal()
        Else
            Call koneksi()
            Cmd = New SqlCommand("Select * from tblUser where username='" & formMenu.tlsUsername.Text & "' and password='" & txtbxPassLama.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                If txtbxPassBaru.Text = txtbxKonfirm.Text Then
                    'If Not (txtbxBaru.Text Like "[A-Z,a-z]" And (txtbxBaru.Text >= "0" Or txtbxBaru.Text <= "9")) Then
                    '    MsgBox("Password Harus Diisi huruf dan angka")
                    'Else

                    'End If
                    Call koneksi()
                    Cmd = New SqlCommand("update tblUser set password='" & txtbxPassBaru.Text & "' where username='" & formMenu.tlsUsername.Text & "'", Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Sukses mengubah password")
                    formMenu.awal()
                    Me.Dispose()
                Else
                    MsgBox("Password baru dan konfirmasinya tidak cocok")
                    Call awal()
                End If
            Else
                MsgBox("Password lama anda salah")
                Call awal()
            End If
        End If
    End Sub

    Private Sub formUbahPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal()
    End Sub

End Class