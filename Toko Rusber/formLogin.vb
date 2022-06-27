Imports System.Data.SqlClient
Public Class formLogin
    Sub buka()
        formMenu.tlsUsername.Text = Rd.Item(0).ToString
        formMenu.tlsNama.Text = Rd.Item(1).ToString
        formMenu.tlsStatus.Text = Rd.Item(3).ToString
        If formMenu.tlsStatus.Text.Equals("ADMIN") Then
            formMenu.DATAToolStripMenuItem.Visible = True
            formMenu.DATAKEUANGANToolStripMenuItem.Visible = True
            formMenu.DATATRANSAKSIToolStripMenuItem.Visible = True
            formMenu.DATAANGGOTAToolStripMenuItem.Visible = True
            formMenu.UBAHPASSWORDToolStripMenuItem.Visible = True
            formMenu.KELOLAAKUNToolStripMenuItem.Visible = True
            formMenu.DATAHUTANGToolStripMenuItem.Visible = True
            formMenu.DATASIMPANANANGGOTAToolStripMenuItem.Visible = True
            formMenu.DATASUPPLIERToolStripMenuItem.Visible = True
            formMenu.BARANGKELUARToolStripMenuItem.Visible = True
            formMenu.BARANGMASUKToolStripMenuItem.Visible = True
            formMenu.PENJUALANToolStripMenuItem.Visible = True
            formMenu.REKAPKASToolStripMenuItem.Visible = True
            Call koneksi()
            Cmd = New SqlCommand("update tblUser set lastLogin='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "' where username='" & Rd.Item(0).ToString & "'", Conn)
            Cmd.ExecuteNonQuery()
        ElseIf formMenu.tlsStatus.Text.Equals("CASHIER") Then
            formMenu.DATATRANSAKSIToolStripMenuItem.Visible = True
            formMenu.PENJUALANToolStripMenuItem.Visible = True
            formMenu.DATAKEUANGANToolStripMenuItem.Visible = True
            formMenu.REKAPKASToolStripMenuItem.Visible = True
            Call koneksi()
            Cmd = New SqlCommand("update tblUser set lastLogin='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "' where username='" & Rd.Item(0).ToString & "'", Conn)
            Cmd.ExecuteNonQuery()
        Else
            MsgBox("STATUS AKUN TIDAK SESUAI")

        End If

        formMenu.LOGINToolStripMenuItem.Visible = False
        formMenu.LOGOUTToolStripMenuItem.Visible = True

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtbxUsername.Text = vbNullString Or txtbxPassword.Text = vbNullString Then
            MsgBox("Silahkan isi kolom username dan password")
        Else
            Call koneksi()
            Cmd = New SqlCommand("select * from tblUser where username='" & txtbxUsername.Text & "' and password='" & txtbxPassword.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                MsgBox("Berhasil login ...", MsgBoxStyle.Information)
                Call buka()
                Me.Dispose()
                Conn.Close()
            Else
                MsgBox("Username atau Password salah !!!")
                txtbxUsername.ResetText()
                txtbxPassword.ResetText()
                txtbxUsername.Focus()
            End If
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Dispose()
    End Sub

    Private Sub txtbxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtbxUsername.Text = vbNullString Or txtbxPassword.Text = vbNullString Then
                MsgBox("Silahkan isi kolom username dan password")
            Else
                Call koneksi()
                Cmd = New SqlCommand("select * from tblUser where username='" & txtbxUsername.Text & "' and password='" & txtbxPassword.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    MsgBox("Berhasil login ...", MsgBoxStyle.Information)
                    Call buka()
                    Me.Dispose()
                    Conn.Close()
                Else
                    MsgBox("Username atau Password salah !!!")
                    txtbxUsername.ResetText()
                    txtbxPassword.ResetText()
                    txtbxUsername.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtbxUsername.Focus()
    End Sub
End Class