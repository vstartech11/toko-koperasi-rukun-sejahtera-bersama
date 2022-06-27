<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSupplier
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
        Me.dgvSupplier = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoUbah = New System.Windows.Forms.RadioButton()
        Me.rdoTambah = New System.Windows.Forms.RadioButton()
        Me.txtbxNama = New System.Windows.Forms.TextBox()
        Me.txtbxAlamat = New System.Windows.Forms.TextBox()
        Me.txtbxTelp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.rdoHapus = New System.Windows.Forms.RadioButton()
        Me.lblId = New System.Windows.Forms.Label()
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSupplier
        '
        Me.dgvSupplier.AllowUserToAddRows = False
        Me.dgvSupplier.AllowUserToDeleteRows = False
        Me.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSupplier.Location = New System.Drawing.Point(106, 68)
        Me.dgvSupplier.Name = "dgvSupplier"
        Me.dgvSupplier.ReadOnly = True
        Me.dgvSupplier.RowHeadersWidth = 51
        Me.dgvSupplier.RowTemplate.Height = 24
        Me.dgvSupplier.Size = New System.Drawing.Size(640, 165)
        Me.dgvSupplier.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoHapus)
        Me.GroupBox1.Controls.Add(Me.rdoUbah)
        Me.GroupBox1.Controls.Add(Me.rdoTambah)
        Me.GroupBox1.Location = New System.Drawing.Point(85, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 119)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
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
        'txtbxNama
        '
        Me.txtbxNama.Location = New System.Drawing.Point(419, 268)
        Me.txtbxNama.Name = "txtbxNama"
        Me.txtbxNama.Size = New System.Drawing.Size(300, 22)
        Me.txtbxNama.TabIndex = 2
        '
        'txtbxAlamat
        '
        Me.txtbxAlamat.Location = New System.Drawing.Point(419, 314)
        Me.txtbxAlamat.Multiline = True
        Me.txtbxAlamat.Name = "txtbxAlamat"
        Me.txtbxAlamat.Size = New System.Drawing.Size(300, 68)
        Me.txtbxAlamat.TabIndex = 3
        '
        'txtbxTelp
        '
        Me.txtbxTelp.Location = New System.Drawing.Point(419, 409)
        Me.txtbxTelp.Name = "txtbxTelp"
        Me.txtbxTelp.Size = New System.Drawing.Size(300, 22)
        Me.txtbxTelp.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(303, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nama Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(303, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "No Telp"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(640, 475)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(106, 55)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
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
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(306, 457)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(14, 16)
        Me.lblId.TabIndex = 7
        Me.lblId.Text = "0"
        Me.lblId.Visible = False
        '
        'formSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 560)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbxTelp)
        Me.Controls.Add(Me.txtbxAlamat)
        Me.Controls.Add(Me.txtbxNama)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvSupplier)
        Me.Name = "formSupplier"
        Me.Text = "formSupplier"
        CType(Me.dgvSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSupplier As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoUbah As RadioButton
    Friend WithEvents rdoTambah As RadioButton
    Friend WithEvents txtbxNama As TextBox
    Friend WithEvents txtbxAlamat As TextBox
    Friend WithEvents txtbxTelp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents rdoHapus As RadioButton
    Friend WithEvents lblId As Label
End Class
