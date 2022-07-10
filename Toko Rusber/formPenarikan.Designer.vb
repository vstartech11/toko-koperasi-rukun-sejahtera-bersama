<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPenarikan
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
        Me.dgvPenarikan = New System.Windows.Forms.DataGridView()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblSimpanan = New System.Windows.Forms.Label()
        Me.txtbxPenarikan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbxCari = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.dgvPenarikan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPenarikan
        '
        Me.dgvPenarikan.AllowUserToAddRows = False
        Me.dgvPenarikan.AllowUserToDeleteRows = False
        Me.dgvPenarikan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPenarikan.Location = New System.Drawing.Point(145, 82)
        Me.dgvPenarikan.Name = "dgvPenarikan"
        Me.dgvPenarikan.ReadOnly = True
        Me.dgvPenarikan.RowHeadersWidth = 51
        Me.dgvPenarikan.RowTemplate.Height = 24
        Me.dgvPenarikan.Size = New System.Drawing.Size(933, 256)
        Me.dgvPenarikan.TabIndex = 0
        '
        'lblId
        '
        Me.lblId.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(520, 368)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(51, 16)
        Me.lblId.TabIndex = 4
        Me.lblId.Text = "P00000"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(371, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID PENARIKAN"
        '
        'txtbxId
        '
        Me.txtbxId.Location = New System.Drawing.Point(523, 402)
        Me.txtbxId.Name = "txtbxId"
        Me.txtbxId.Size = New System.Drawing.Size(151, 22)
        Me.txtbxId.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(371, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID Anggota"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(736, 449)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(142, 72)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "CARI"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(371, 449)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Anggota"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(373, 489)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Simpanan Sukarela"
        '
        'lblNama
        '
        Me.lblNama.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(520, 449)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(0, 16)
        Me.lblNama.TabIndex = 3
        '
        'lblSimpanan
        '
        Me.lblSimpanan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSimpanan.AutoSize = True
        Me.lblSimpanan.Location = New System.Drawing.Point(520, 489)
        Me.lblSimpanan.Name = "lblSimpanan"
        Me.lblSimpanan.Size = New System.Drawing.Size(14, 16)
        Me.lblSimpanan.TabIndex = 3
        Me.lblSimpanan.Text = "0"
        '
        'txtbxPenarikan
        '
        Me.txtbxPenarikan.Location = New System.Drawing.Point(523, 529)
        Me.txtbxPenarikan.Name = "txtbxPenarikan"
        Me.txtbxPenarikan.Size = New System.Drawing.Size(100, 22)
        Me.txtbxPenarikan.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(371, 532)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Jumlah Ditarik"
        '
        'txtbxCari
        '
        Me.txtbxCari.Location = New System.Drawing.Point(907, 54)
        Me.txtbxCari.Name = "txtbxCari"
        Me.txtbxCari.Size = New System.Drawing.Size(138, 22)
        Me.txtbxCari.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(824, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Cari nama"
        '
        'formPenarikan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 589)
        Me.Controls.Add(Me.txtbxCari)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtbxPenarikan)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtbxId)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSimpanan)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvPenarikan)
        Me.Name = "formPenarikan"
        Me.Text = "formPenarikan"
        CType(Me.dgvPenarikan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPenarikan As DataGridView
    Friend WithEvents lblId As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblSimpanan As Label
    Friend WithEvents txtbxPenarikan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbxCari As TextBox
    Friend WithEvents Label13 As Label
End Class
