<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formAnggota
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoHapus = New System.Windows.Forms.RadioButton()
        Me.rdoUbah = New System.Windows.Forms.RadioButton()
        Me.rdoTambah = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblNomor = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.cmbxKelamin = New System.Windows.Forms.ComboBox()
        Me.txtbxNama = New System.Windows.Forms.TextBox()
        Me.txtbxNik = New System.Windows.Forms.TextBox()
        Me.txtbxAlamat = New System.Windows.Forms.TextBox()
        Me.txtbxPekerjaan = New System.Windows.Forms.TextBox()
        Me.txtbxNamaAhli = New System.Windows.Forms.TextBox()
        Me.txtbxHubAhli = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtbxTelp = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbxStatus = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtbxCari = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbxPenjamin = New System.Windows.Forms.ComboBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(35, 67)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidth = 51
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(969, 303)
        Me.dgv.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(314, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 46)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DAFTAR ANGGOTA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoHapus)
        Me.GroupBox1.Controls.Add(Me.rdoUbah)
        Me.GroupBox1.Controls.Add(Me.rdoTambah)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 399)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 119)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'rdoHapus
        '
        Me.rdoHapus.AutoSize = True
        Me.rdoHapus.Location = New System.Drawing.Point(21, 88)
        Me.rdoHapus.Name = "rdoHapus"
        Me.rdoHapus.Size = New System.Drawing.Size(68, 20)
        Me.rdoHapus.TabIndex = 2
        Me.rdoHapus.TabStop = True
        Me.rdoHapus.Text = "Hapus"
        Me.rdoHapus.UseVisualStyleBackColor = True
        '
        'rdoUbah
        '
        Me.rdoUbah.AutoSize = True
        Me.rdoUbah.Location = New System.Drawing.Point(21, 61)
        Me.rdoUbah.Name = "rdoUbah"
        Me.rdoUbah.Size = New System.Drawing.Size(61, 20)
        Me.rdoUbah.TabIndex = 1
        Me.rdoUbah.TabStop = True
        Me.rdoUbah.Text = "Ubah"
        Me.rdoUbah.UseVisualStyleBackColor = True
        '
        'rdoTambah
        '
        Me.rdoTambah.AutoSize = True
        Me.rdoTambah.Location = New System.Drawing.Point(21, 34)
        Me.rdoTambah.Name = "rdoTambah"
        Me.rdoTambah.Size = New System.Drawing.Size(79, 20)
        Me.rdoTambah.TabIndex = 0
        Me.rdoTambah.TabStop = True
        Me.rdoTambah.Text = "Tambah"
        Me.rdoTambah.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 411)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nomor Anggota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 437)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(211, 464)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Masuk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(211, 490)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "NIK KTP"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(211, 526)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(211, 579)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Jenis Kelamin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(211, 612)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Pekerjaan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(211, 682)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Nama Ahli Waris"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(211, 727)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 16)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Hubungan Ahli Waris"
        '
        'lblNomor
        '
        Me.lblNomor.AutoSize = True
        Me.lblNomor.Location = New System.Drawing.Point(371, 411)
        Me.lblNomor.Name = "lblNomor"
        Me.lblNomor.Size = New System.Drawing.Size(69, 16)
        Me.lblNomor.TabIndex = 3
        Me.lblNomor.Text = "KRB00000"
        Me.lblNomor.Visible = False
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Location = New System.Drawing.Point(371, 464)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(0, 16)
        Me.lblTanggal.TabIndex = 3
        Me.lblTanggal.Visible = False
        '
        'cmbxKelamin
        '
        Me.cmbxKelamin.FormattingEnabled = True
        Me.cmbxKelamin.Items.AddRange(New Object() {"Pilih", "Laki-Laki", "Perempuan"})
        Me.cmbxKelamin.Location = New System.Drawing.Point(374, 579)
        Me.cmbxKelamin.Name = "cmbxKelamin"
        Me.cmbxKelamin.Size = New System.Drawing.Size(136, 24)
        Me.cmbxKelamin.TabIndex = 6
        '
        'txtbxNama
        '
        Me.txtbxNama.Location = New System.Drawing.Point(374, 437)
        Me.txtbxNama.Name = "txtbxNama"
        Me.txtbxNama.Size = New System.Drawing.Size(255, 22)
        Me.txtbxNama.TabIndex = 3
        '
        'txtbxNik
        '
        Me.txtbxNik.Location = New System.Drawing.Point(374, 487)
        Me.txtbxNik.Name = "txtbxNik"
        Me.txtbxNik.Size = New System.Drawing.Size(255, 22)
        Me.txtbxNik.TabIndex = 4
        '
        'txtbxAlamat
        '
        Me.txtbxAlamat.Location = New System.Drawing.Point(374, 519)
        Me.txtbxAlamat.Multiline = True
        Me.txtbxAlamat.Name = "txtbxAlamat"
        Me.txtbxAlamat.Size = New System.Drawing.Size(255, 54)
        Me.txtbxAlamat.TabIndex = 5
        '
        'txtbxPekerjaan
        '
        Me.txtbxPekerjaan.Location = New System.Drawing.Point(374, 609)
        Me.txtbxPekerjaan.Name = "txtbxPekerjaan"
        Me.txtbxPekerjaan.Size = New System.Drawing.Size(255, 22)
        Me.txtbxPekerjaan.TabIndex = 7
        '
        'txtbxNamaAhli
        '
        Me.txtbxNamaAhli.Location = New System.Drawing.Point(374, 676)
        Me.txtbxNamaAhli.Name = "txtbxNamaAhli"
        Me.txtbxNamaAhli.Size = New System.Drawing.Size(255, 22)
        Me.txtbxNamaAhli.TabIndex = 8
        '
        'txtbxHubAhli
        '
        Me.txtbxHubAhli.Location = New System.Drawing.Point(374, 721)
        Me.txtbxHubAhli.Name = "txtbxHubAhli"
        Me.txtbxHubAhli.Size = New System.Drawing.Size(255, 22)
        Me.txtbxHubAhli.TabIndex = 9
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(817, 590)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(140, 93)
        Me.btnSimpan.TabIndex = 10
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(211, 649)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Nomor Telp"
        '
        'txtbxTelp
        '
        Me.txtbxTelp.Location = New System.Drawing.Point(374, 646)
        Me.txtbxTelp.Name = "txtbxTelp"
        Me.txtbxTelp.Size = New System.Drawing.Size(255, 22)
        Me.txtbxTelp.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(654, 437)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 16)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Status"
        '
        'cmbxStatus
        '
        Me.cmbxStatus.FormattingEnabled = True
        Me.cmbxStatus.Items.AddRange(New Object() {"Pilih", "Laki-Laki", "Perempuan"})
        Me.cmbxStatus.Location = New System.Drawing.Point(719, 432)
        Me.cmbxStatus.Name = "cmbxStatus"
        Me.cmbxStatus.Size = New System.Drawing.Size(136, 24)
        Me.cmbxStatus.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(746, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 16)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Cari nama"
        '
        'txtbxCari
        '
        Me.txtbxCari.Location = New System.Drawing.Point(829, 39)
        Me.txtbxCari.Name = "txtbxCari"
        Me.txtbxCari.Size = New System.Drawing.Size(138, 22)
        Me.txtbxCari.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(654, 487)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Penjamin"
        '
        'cmbxPenjamin
        '
        Me.cmbxPenjamin.FormattingEnabled = True
        Me.cmbxPenjamin.Items.AddRange(New Object() {"Pilih", "Laki-Laki", "Perempuan"})
        Me.cmbxPenjamin.Location = New System.Drawing.Point(723, 482)
        Me.cmbxPenjamin.Name = "cmbxPenjamin"
        Me.cmbxPenjamin.Size = New System.Drawing.Size(202, 24)
        Me.cmbxPenjamin.TabIndex = 14
        '
        'formAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 755)
        Me.Controls.Add(Me.cmbxPenjamin)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtbxCari)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtbxHubAhli)
        Me.Controls.Add(Me.txtbxNamaAhli)
        Me.Controls.Add(Me.txtbxTelp)
        Me.Controls.Add(Me.txtbxPekerjaan)
        Me.Controls.Add(Me.txtbxAlamat)
        Me.Controls.Add(Me.txtbxNik)
        Me.Controls.Add(Me.txtbxNama)
        Me.Controls.Add(Me.cmbxStatus)
        Me.Controls.Add(Me.cmbxKelamin)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTanggal)
        Me.Controls.Add(Me.lblNomor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv)
        Me.Name = "formAnggota"
        Me.Text = "formAnggota"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoHapus As RadioButton
    Friend WithEvents rdoUbah As RadioButton
    Friend WithEvents rdoTambah As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblNomor As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents cmbxKelamin As ComboBox
    Friend WithEvents txtbxNama As TextBox
    Friend WithEvents txtbxNik As TextBox
    Friend WithEvents txtbxAlamat As TextBox
    Friend WithEvents txtbxPekerjaan As TextBox
    Friend WithEvents txtbxNamaAhli As TextBox
    Friend WithEvents txtbxHubAhli As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txtbxTelp As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbxStatus As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtbxCari As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmbxPenjamin As ComboBox
End Class
