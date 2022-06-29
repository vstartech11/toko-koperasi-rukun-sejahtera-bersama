Public Class formMenu
    Sub awal()
        tlsNama.Text = vbNullString
        tlsStatus.Text = vbNullString
        tlsUsername.Text = vbNullString

        LOGINToolStripMenuItem.Visible = True
        LOGOUTToolStripMenuItem.Visible = False
        UBAHPASSWORDToolStripMenuItem.Visible = False
        BARANGKELUARToolStripMenuItem.Visible = False
        BARANGMASUKToolStripMenuItem.Visible = False
        DATAToolStripMenuItem.Visible = False
        PENJUALANToolStripMenuItem.Visible = False
        DATAKEUANGANToolStripMenuItem.Visible = False
        REKAPKASToolStripMenuItem.Visible = False
        DATATRANSAKSIToolStripMenuItem.Visible = False
        DATAANGGOTAToolStripMenuItem.Visible = False
        DATASUPPLIERToolStripMenuItem.Visible = False
        DATASIMPANANANGGOTAToolStripMenuItem.Visible = False
        DATAHUTANGToolStripMenuItem.Visible = False
        KELOLAAKUNToolStripMenuItem.Visible = False
    End Sub
    Private Sub formMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal()
        formLogin.ShowDialog()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Call awal()
        formLogin.ShowDialog()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Dispose()
    End Sub

    Private Sub LOGINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGINToolStripMenuItem.Click
        formLogin.ShowDialog()
    End Sub

    Private Sub UBAHPASSWORDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UBAHPASSWORDToolStripMenuItem.Click
        formUbahPass.ShowDialog()
    End Sub

    Private Sub DATASUPPLIERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATASUPPLIERToolStripMenuItem.Click
        formSupplier.ShowDialog()
    End Sub

    Private Sub DATAANGGOTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATAANGGOTAToolStripMenuItem.Click
        formAnggota.ShowDialog()
    End Sub

    Private Sub KELOLAAKUNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KELOLAAKUNToolStripMenuItem.Click
        formAkun.ShowDialog()
    End Sub

    Private Sub DATABARANGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATABARANGToolStripMenuItem.Click
        formDataBarang.ShowDialog()
    End Sub

    Private Sub DATASIMPANANANGGOTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATASIMPANANANGGOTAToolStripMenuItem.Click
        formSimpanan.ShowDialog()
    End Sub

    Private Sub BARANGMASUKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BARANGMASUKToolStripMenuItem.Click
        formBMasuk.ShowDialog()
    End Sub

    Private Sub BARANGKELUARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BARANGKELUARToolStripMenuItem.Click
        formDPenjualan.ShowDialog()
    End Sub
End Class
