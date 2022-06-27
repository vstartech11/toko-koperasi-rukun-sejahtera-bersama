<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAkun
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
        Me.dgvAkun = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbxPass = New System.Windows.Forms.TextBox()
        Me.cmbxStatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoHapus = New System.Windows.Forms.RadioButton()
        Me.rdoUbah = New System.Windows.Forms.RadioButton()
        Me.rdoTambah = New System.Windows.Forms.RadioButton()
        Me.btnSimpan = New System.Windows.Forms.Button()
        CType(Me.dgvAkun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAkun
        '
        Me.dgvAkun.AllowUserToAddRows = False
        Me.dgvAkun.AllowUserToDeleteRows = False
        Me.dgvAkun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAkun.Location = New System.Drawing.Point(97, 42)
        Me.dgvAkun.Name = "dgvAkun"
        Me.dgvAkun.ReadOnly = True
        Me.dgvAkun.RowHeadersWidth = 51
        Me.dgvAkun.RowTemplate.Height = 24
        Me.dgvAkun.Size = New System.Drawing.Size(625, 240)
        Me.dgvAkun.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(299, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'txtbxUsername
        '
        Me.txtbxUsername.Location = New System.Drawing.Point(397, 305)
        Me.txtbxUsername.MaxLength = 10
        Me.txtbxUsername.Name = "txtbxUsername"
        Me.txtbxUsername.Size = New System.Drawing.Size(158, 22)
        Me.txtbxUsername.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(299, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'txtbxNama
        '
        Me.txtbxNama.Location = New System.Drawing.Point(397, 333)
        Me.txtbxNama.MaxLength = 50
        Me.txtbxNama.Name = "txtbxNama"
        Me.txtbxNama.Size = New System.Drawing.Size(197, 22)
        Me.txtbxNama.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(299, 368)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'txtbxPass
        '
        Me.txtbxPass.Location = New System.Drawing.Point(397, 361)
        Me.txtbxPass.Name = "txtbxPass"
        Me.txtbxPass.Size = New System.Drawing.Size(197, 22)
        Me.txtbxPass.TabIndex = 5
        '
        'cmbxStatus
        '
        Me.cmbxStatus.FormattingEnabled = True
        Me.cmbxStatus.Location = New System.Drawing.Point(397, 390)
        Me.cmbxStatus.Name = "cmbxStatus"
        Me.cmbxStatus.Size = New System.Drawing.Size(117, 24)
        Me.cmbxStatus.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(299, 393)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Status"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoHapus)
        Me.GroupBox1.Controls.Add(Me.rdoUbah)
        Me.GroupBox1.Controls.Add(Me.rdoTambah)
        Me.GroupBox1.Location = New System.Drawing.Point(123, 305)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 119)
        Me.GroupBox1.TabIndex = 4
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
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(621, 361)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(101, 77)
        Me.btnSimpan.TabIndex = 7
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'formAkun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbxStatus)
        Me.Controls.Add(Me.txtbxPass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbxNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbxUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvAkun)
        Me.Name = "formAkun"
        Me.Text = "formAkun"
        CType(Me.dgvAkun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAkun As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbxPass As TextBox
    Friend WithEvents cmbxStatus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoHapus As RadioButton
    Friend WithEvents rdoUbah As RadioButton
    Friend WithEvents rdoTambah As RadioButton
    Friend WithEvents btnSimpan As Button
End Class
