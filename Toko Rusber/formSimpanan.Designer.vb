<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSimpanan
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtbxIDAnggota = New System.Windows.Forms.TextBox()
        Me.cmbxJenis = New System.Windows.Forms.ComboBox()
        Me.txtbxJumlah = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(348, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(563, 259)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(383, 379)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID SIMPANAN"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(383, 412)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(383, 442)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ID Anggota"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(383, 480)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Jenis Simpanan"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(383, 512)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Jumlah"
        '
        'lblId
        '
        Me.lblId.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(532, 379)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(51, 16)
        Me.lblId.TabIndex = 2
        Me.lblId.Text = "S00000"
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggal.Location = New System.Drawing.Point(535, 407)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(113, 22)
        Me.dtpTanggal.TabIndex = 3
        Me.dtpTanggal.Value = New Date(2022, 6, 30, 8, 12, 21, 0)
        '
        'txtbxIDAnggota
        '
        Me.txtbxIDAnggota.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtbxIDAnggota.Location = New System.Drawing.Point(535, 439)
        Me.txtbxIDAnggota.Name = "txtbxIDAnggota"
        Me.txtbxIDAnggota.Size = New System.Drawing.Size(163, 22)
        Me.txtbxIDAnggota.TabIndex = 4
        '
        'cmbxJenis
        '
        Me.cmbxJenis.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbxJenis.FormattingEnabled = True
        Me.cmbxJenis.Items.AddRange(New Object() {"POKOK", "SUKARELA", "WAJIB"})
        Me.cmbxJenis.Location = New System.Drawing.Point(535, 477)
        Me.cmbxJenis.Name = "cmbxJenis"
        Me.cmbxJenis.Size = New System.Drawing.Size(126, 24)
        Me.cmbxJenis.Sorted = True
        Me.cmbxJenis.TabIndex = 5
        '
        'txtbxJumlah
        '
        Me.txtbxJumlah.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtbxJumlah.Location = New System.Drawing.Point(535, 509)
        Me.txtbxJumlah.Name = "txtbxJumlah"
        Me.txtbxJumlah.Size = New System.Drawing.Size(126, 22)
        Me.txtbxJumlah.TabIndex = 6
        '
        'btnSimpan
        '
        Me.btnSimpan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSimpan.Location = New System.Drawing.Point(766, 446)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(145, 85)
        Me.btnSimpan.TabIndex = 7
        Me.btnSimpan.Text = "SIMPAN"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'formSimpanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 673)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtbxJumlah)
        Me.Controls.Add(Me.cmbxJenis)
        Me.Controls.Add(Me.txtbxIDAnggota)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.MinimizeBox = False
        Me.Name = "formSimpanan"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formSimpanan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblId As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents txtbxIDAnggota As TextBox
    Friend WithEvents cmbxJenis As ComboBox
    Friend WithEvents txtbxJumlah As TextBox
    Friend WithEvents btnSimpan As Button
End Class
