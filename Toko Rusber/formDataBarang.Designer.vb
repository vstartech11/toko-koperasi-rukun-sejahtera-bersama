<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDataBarang
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
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoHapus = New System.Windows.Forms.RadioButton()
        Me.rdoUbah = New System.Windows.Forms.RadioButton()
        Me.rdoTambah = New System.Windows.Forms.RadioButton()
        Me.txtbxBarcode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbxNama = New System.Windows.Forms.TextBox()
        Me.txtbxStok = New System.Windows.Forms.TextBox()
        Me.txtbxModal = New System.Windows.Forms.TextBox()
        Me.txtbxJualUmum = New System.Windows.Forms.TextBox()
        Me.txtbxJualAnggota = New System.Windows.Forms.TextBox()
        Me.txtbxJualBon = New System.Windows.Forms.TextBox()
        Me.cmbxKategori = New System.Windows.Forms.ComboBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBarang
        '
        Me.dgvBarang.AllowUserToAddRows = False
        Me.dgvBarang.AllowUserToDeleteRows = False
        Me.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBarang.Location = New System.Drawing.Point(86, 56)
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.ReadOnly = True
        Me.dgvBarang.RowHeadersWidth = 51
        Me.dgvBarang.RowTemplate.Height = 24
        Me.dgvBarang.Size = New System.Drawing.Size(1031, 210)
        Me.dgvBarang.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoHapus)
        Me.GroupBox1.Controls.Add(Me.rdoUbah)
        Me.GroupBox1.Controls.Add(Me.rdoTambah)
        Me.GroupBox1.Location = New System.Drawing.Point(86, 307)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 119)
        Me.GroupBox1.TabIndex = 3
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
        'txtbxBarcode
        '
        Me.txtbxBarcode.Location = New System.Drawing.Point(408, 323)
        Me.txtbxBarcode.Name = "txtbxBarcode"
        Me.txtbxBarcode.Size = New System.Drawing.Size(172, 22)
        Me.txtbxBarcode.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(257, 326)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Barcode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(257, 386)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kategori"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 410)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Stok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 438)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Harga Modal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(257, 467)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Harga Jual Umum"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(257, 495)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 16)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Harga Jual Anggota"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(257, 532)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Harga Jual Bon"
        '
        'txtbxNama
        '
        Me.txtbxNama.Location = New System.Drawing.Point(408, 353)
        Me.txtbxNama.Name = "txtbxNama"
        Me.txtbxNama.Size = New System.Drawing.Size(172, 22)
        Me.txtbxNama.TabIndex = 4
        '
        'txtbxStok
        '
        Me.txtbxStok.Location = New System.Drawing.Point(408, 407)
        Me.txtbxStok.Name = "txtbxStok"
        Me.txtbxStok.Size = New System.Drawing.Size(172, 22)
        Me.txtbxStok.TabIndex = 4
        '
        'txtbxModal
        '
        Me.txtbxModal.Location = New System.Drawing.Point(408, 435)
        Me.txtbxModal.Name = "txtbxModal"
        Me.txtbxModal.Size = New System.Drawing.Size(172, 22)
        Me.txtbxModal.TabIndex = 4
        '
        'txtbxJualUmum
        '
        Me.txtbxJualUmum.Location = New System.Drawing.Point(408, 464)
        Me.txtbxJualUmum.Name = "txtbxJualUmum"
        Me.txtbxJualUmum.Size = New System.Drawing.Size(172, 22)
        Me.txtbxJualUmum.TabIndex = 4
        '
        'txtbxJualAnggota
        '
        Me.txtbxJualAnggota.Location = New System.Drawing.Point(408, 492)
        Me.txtbxJualAnggota.Name = "txtbxJualAnggota"
        Me.txtbxJualAnggota.Size = New System.Drawing.Size(172, 22)
        Me.txtbxJualAnggota.TabIndex = 4
        '
        'txtbxJualBon
        '
        Me.txtbxJualBon.Location = New System.Drawing.Point(408, 529)
        Me.txtbxJualBon.Name = "txtbxJualBon"
        Me.txtbxJualBon.Size = New System.Drawing.Size(172, 22)
        Me.txtbxJualBon.TabIndex = 4
        '
        'cmbxKategori
        '
        Me.cmbxKategori.FormattingEnabled = True
        Me.cmbxKategori.Location = New System.Drawing.Point(408, 382)
        Me.cmbxKategori.Name = "cmbxKategori"
        Me.cmbxKategori.Size = New System.Drawing.Size(121, 24)
        Me.cmbxKategori.TabIndex = 6
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(675, 433)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(133, 115)
        Me.btnSimpan.TabIndex = 7
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'formDataBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 581)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.cmbxKategori)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbxJualBon)
        Me.Controls.Add(Me.txtbxJualAnggota)
        Me.Controls.Add(Me.txtbxJualUmum)
        Me.Controls.Add(Me.txtbxModal)
        Me.Controls.Add(Me.txtbxStok)
        Me.Controls.Add(Me.txtbxNama)
        Me.Controls.Add(Me.txtbxBarcode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvBarang)
        Me.Name = "formDataBarang"
        Me.Text = "formDataBarang"
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBarang As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoHapus As RadioButton
    Friend WithEvents rdoUbah As RadioButton
    Friend WithEvents rdoTambah As RadioButton
    Friend WithEvents txtbxBarcode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbxNama As TextBox
    Friend WithEvents txtbxStok As TextBox
    Friend WithEvents txtbxModal As TextBox
    Friend WithEvents txtbxJualUmum As TextBox
    Friend WithEvents txtbxJualAnggota As TextBox
    Friend WithEvents txtbxJualBon As TextBox
    Friend WithEvents cmbxKategori As ComboBox
    Friend WithEvents btnSimpan As Button
End Class
