Public Class formMenu
    Sub awal()
        tlsNama.Text = vbNullString
        tlsStatus.Text = vbNullString

        LOGINToolStripMenuItem.Visible = True
        LOGOUTToolStripMenuItem.Visible = False
        UBAHPASSWORDToolStripMenuItem.Visible = False
        DATAANGGOTAToolStripMenuItem.Visible = False
        DATABARANGToolStripMenuItem.Visible = False
        DATATRANSAKSIToolStripMenuItem.Visible = False
        DATAKEUANGANToolStripMenuItem.Visible = False

    End Sub
    Private Sub formMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal()
        formLogin.ShowDialog()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Call awal()
        formLogin.ShowDialog()
    End Sub
End Class
