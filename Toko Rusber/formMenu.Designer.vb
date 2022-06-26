<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.USERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATAANGGOTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UBAHPASSWORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATABARANGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATASUPPLIERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATATRANSAKSIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BARANGMASUKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BARANGKELUARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PENJUALANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATAKEUANGANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REKAPKASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlsNama = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlsStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlsUsername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USERToolStripMenuItem, Me.DATABARANGToolStripMenuItem, Me.DATATRANSAKSIToolStripMenuItem, Me.DATAKEUANGANToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 1)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(628, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'USERToolStripMenuItem
        '
        Me.USERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATAANGGOTAToolStripMenuItem, Me.LOGINToolStripMenuItem, Me.UBAHPASSWORDToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.USERToolStripMenuItem.Name = "USERToolStripMenuItem"
        Me.USERToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.USERToolStripMenuItem.Text = "AKUN"
        '
        'DATAANGGOTAToolStripMenuItem
        '
        Me.DATAANGGOTAToolStripMenuItem.Name = "DATAANGGOTAToolStripMenuItem"
        Me.DATAANGGOTAToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DATAANGGOTAToolStripMenuItem.Text = "DATA ANGGOTA"
        '
        'LOGINToolStripMenuItem
        '
        Me.LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        Me.LOGINToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LOGINToolStripMenuItem.Text = "LOGIN"
        '
        'UBAHPASSWORDToolStripMenuItem
        '
        Me.UBAHPASSWORDToolStripMenuItem.Name = "UBAHPASSWORDToolStripMenuItem"
        Me.UBAHPASSWORDToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.UBAHPASSWORDToolStripMenuItem.Text = "UBAH PASSWORD"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'DATABARANGToolStripMenuItem
        '
        Me.DATABARANGToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATASUPPLIERToolStripMenuItem})
        Me.DATABARANGToolStripMenuItem.Name = "DATABARANGToolStripMenuItem"
        Me.DATABARANGToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.DATABARANGToolStripMenuItem.Text = "DATA BARANG"
        '
        'DATASUPPLIERToolStripMenuItem
        '
        Me.DATASUPPLIERToolStripMenuItem.Name = "DATASUPPLIERToolStripMenuItem"
        Me.DATASUPPLIERToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.DATASUPPLIERToolStripMenuItem.Text = "DATA SUPPLIER"
        '
        'DATATRANSAKSIToolStripMenuItem
        '
        Me.DATATRANSAKSIToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BARANGMASUKToolStripMenuItem, Me.BARANGKELUARToolStripMenuItem, Me.PENJUALANToolStripMenuItem})
        Me.DATATRANSAKSIToolStripMenuItem.Name = "DATATRANSAKSIToolStripMenuItem"
        Me.DATATRANSAKSIToolStripMenuItem.Size = New System.Drawing.Size(141, 26)
        Me.DATATRANSAKSIToolStripMenuItem.Text = "DATA TRANSAKSI"
        '
        'BARANGMASUKToolStripMenuItem
        '
        Me.BARANGMASUKToolStripMenuItem.Name = "BARANGMASUKToolStripMenuItem"
        Me.BARANGMASUKToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.BARANGMASUKToolStripMenuItem.Text = "BARANG MASUK"
        '
        'BARANGKELUARToolStripMenuItem
        '
        Me.BARANGKELUARToolStripMenuItem.Name = "BARANGKELUARToolStripMenuItem"
        Me.BARANGKELUARToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.BARANGKELUARToolStripMenuItem.Text = "BARANG KELUAR"
        '
        'PENJUALANToolStripMenuItem
        '
        Me.PENJUALANToolStripMenuItem.Name = "PENJUALANToolStripMenuItem"
        Me.PENJUALANToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.PENJUALANToolStripMenuItem.Text = "PENJUALAN"
        '
        'DATAKEUANGANToolStripMenuItem
        '
        Me.DATAKEUANGANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REKAPKASToolStripMenuItem})
        Me.DATAKEUANGANToolStripMenuItem.Name = "DATAKEUANGANToolStripMenuItem"
        Me.DATAKEUANGANToolStripMenuItem.Size = New System.Drawing.Size(143, 26)
        Me.DATAKEUANGANToolStripMenuItem.Text = "DATA KEUANGAN"
        '
        'REKAPKASToolStripMenuItem
        '
        Me.REKAPKASToolStripMenuItem.Name = "REKAPKASToolStripMenuItem"
        Me.REKAPKASToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.REKAPKASToolStripMenuItem.Text = "REKAP KAS"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.tlsUsername, Me.ToolStripStatusLabel1, Me.tlsNama, Me.ToolStripStatusLabel3, Me.tlsStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 281)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(634, 26)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(60, 20)
        Me.ToolStripStatusLabel1.Text = "Nama  :"
        '
        'tlsNama
        '
        Me.tlsNama.Name = "tlsNama"
        Me.tlsNama.Size = New System.Drawing.Size(44, 20)
        Me.tlsNama.Text = "USER"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(60, 20)
        Me.ToolStripStatusLabel3.Text = "Status  :"
        '
        'tlsStatus
        '
        Me.tlsStatus.Name = "tlsStatus"
        Me.tlsStatus.Size = New System.Drawing.Size(68, 20)
        Me.tlsStatus.Text = "CASHIER"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(0, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 258)
        Me.Panel1.TabIndex = 2
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), System.Drawing.Image)
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHome.Location = New System.Drawing.Point(589, 5)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(40, 40)
        Me.btnHome.TabIndex = 5
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(447, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "KOPERASI RUKUN SEJAHTERA BERSAMA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(86, 20)
        Me.ToolStripStatusLabel2.Text = "Username  :"
        '
        'tlsUsername
        '
        Me.tlsUsername.Name = "tlsUsername"
        Me.tlsUsername.Size = New System.Drawing.Size(44, 20)
        Me.tlsUsername.Text = "USER"
        '
        'formMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(634, 307)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formMenu"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TOKO KOPERASI RUKUN SEJAHTERA BERSAMA"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents USERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATAANGGOTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UBAHPASSWORDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATABARANGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATATRANSAKSIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BARANGMASUKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BARANGKELUARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PENJUALANToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATAKEUANGANToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REKAPKASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tlsNama As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents tlsStatus As ToolStripStatusLabel
    Friend WithEvents DATASUPPLIERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents tlsUsername As ToolStripStatusLabel
End Class
