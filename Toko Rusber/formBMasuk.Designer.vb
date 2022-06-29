<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBMasuk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formBMasuk))
        Me.dgvBMasuk = New System.Windows.Forms.DataGridView()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.txtbxNama = New System.Windows.Forms.TextBox()
        Me.txtbxBarcode = New System.Windows.Forms.TextBox()
        Me.txtbxHarga = New System.Windows.Forms.TextBox()
        Me.txtbxJumlah = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnCetak = New System.Windows.Forms.Button()
        CType(Me.dgvBMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBMasuk
        '
        Me.dgvBMasuk.AllowUserToAddRows = False
        Me.dgvBMasuk.AllowUserToDeleteRows = False
        Me.dgvBMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBMasuk.Location = New System.Drawing.Point(80, 82)
        Me.dgvBMasuk.Name = "dgvBMasuk"
        Me.dgvBMasuk.ReadOnly = True
        Me.dgvBMasuk.RowHeadersWidth = 51
        Me.dgvBMasuk.RowTemplate.Height = 24
        Me.dgvBMasuk.Size = New System.Drawing.Size(1010, 250)
        Me.dgvBMasuk.TabIndex = 0
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(596, 408)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(132, 92)
        Me.btnSimpan.TabIndex = 1
        Me.btnSimpan.Text = "TAMBAH"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 375)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kode Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 408)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 441)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Barcode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 471)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Harga Beli"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 505)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Jumlah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 538)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(243, 538)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(38, 16)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = "Total"
        '
        'lblKode
        '
        Me.lblKode.AutoSize = True
        Me.lblKode.Location = New System.Drawing.Point(243, 375)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(38, 16)
        Me.lblKode.TabIndex = 2
        Me.lblKode.Text = "Total"
        '
        'txtbxNama
        '
        Me.txtbxNama.Location = New System.Drawing.Point(246, 405)
        Me.txtbxNama.Name = "txtbxNama"
        Me.txtbxNama.Size = New System.Drawing.Size(192, 22)
        Me.txtbxNama.TabIndex = 3
        '
        'txtbxBarcode
        '
        Me.txtbxBarcode.Location = New System.Drawing.Point(246, 438)
        Me.txtbxBarcode.Name = "txtbxBarcode"
        Me.txtbxBarcode.Size = New System.Drawing.Size(192, 22)
        Me.txtbxBarcode.TabIndex = 3
        '
        'txtbxHarga
        '
        Me.txtbxHarga.Location = New System.Drawing.Point(246, 466)
        Me.txtbxHarga.Name = "txtbxHarga"
        Me.txtbxHarga.Size = New System.Drawing.Size(81, 22)
        Me.txtbxHarga.TabIndex = 3
        '
        'txtbxJumlah
        '
        Me.txtbxJumlah.Location = New System.Drawing.Point(246, 502)
        Me.txtbxJumlah.Name = "txtbxJumlah"
        Me.txtbxJumlah.Size = New System.Drawing.Size(81, 22)
        Me.txtbxJumlah.TabIndex = 3
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(289, 375)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(38, 16)
        Me.lblId.TabIndex = 2
        Me.lblId.Text = "Total"
        Me.lblId.Visible = False
        '
        'lblJumlah
        '
        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.Location = New System.Drawing.Point(333, 375)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(14, 16)
        Me.lblJumlah.TabIndex = 2
        Me.lblJumlah.Text = "0"
        Me.lblJumlah.Visible = False
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "Rekap Barang Masuk"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.ShowIcon = False
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(991, 38)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(87, 38)
        Me.btnCetak.TabIndex = 4
        Me.btnCetak.Text = "CETAK"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'formBMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 649)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.txtbxJumlah)
        Me.Controls.Add(Me.txtbxHarga)
        Me.Controls.Add(Me.txtbxBarcode)
        Me.Controls.Add(Me.txtbxNama)
        Me.Controls.Add(Me.lblJumlah)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblKode)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.dgvBMasuk)
        Me.Name = "formBMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formBMasuk"
        CType(Me.dgvBMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBMasuk As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblKode As Label
    Friend WithEvents txtbxNama As TextBox
    Friend WithEvents txtbxBarcode As TextBox
    Friend WithEvents txtbxHarga As TextBox
    Friend WithEvents txtbxJumlah As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnCetak As Button
End Class
