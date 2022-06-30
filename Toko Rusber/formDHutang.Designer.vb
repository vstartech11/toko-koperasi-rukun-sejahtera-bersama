<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDHutang
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
        Me.dgvHutang = New System.Windows.Forms.DataGridView()
        Me.txtbxCari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblJHutang = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        CType(Me.dgvHutang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHutang
        '
        Me.dgvHutang.AllowUserToAddRows = False
        Me.dgvHutang.AllowUserToDeleteRows = False
        Me.dgvHutang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHutang.Location = New System.Drawing.Point(73, 78)
        Me.dgvHutang.Name = "dgvHutang"
        Me.dgvHutang.ReadOnly = True
        Me.dgvHutang.RowHeadersWidth = 51
        Me.dgvHutang.RowTemplate.Height = 24
        Me.dgvHutang.Size = New System.Drawing.Size(810, 180)
        Me.dgvHutang.TabIndex = 0
        '
        'txtbxCari
        '
        Me.txtbxCari.Location = New System.Drawing.Point(187, 277)
        Me.txtbxCari.Name = "txtbxCari"
        Me.txtbxCari.Size = New System.Drawing.Size(149, 22)
        Me.txtbxCari.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cari Nama"
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(370, 272)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(66, 33)
        Me.btnCari.TabIndex = 3
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Anggota"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(211, 323)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(0, 16)
        Me.lblNama.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah Hutang"
        '
        'lblJHutang
        '
        Me.lblJHutang.AutoSize = True
        Me.lblJHutang.Location = New System.Drawing.Point(211, 360)
        Me.lblJHutang.Name = "lblJHutang"
        Me.lblJHutang.Size = New System.Drawing.Size(0, 16)
        Me.lblJHutang.TabIndex = 2
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(370, 337)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(112, 62)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'formDHutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 484)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.lblJHutang)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbxCari)
        Me.Controls.Add(Me.dgvHutang)
        Me.Name = "formDHutang"
        Me.Text = "formDHutang"
        CType(Me.dgvHutang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvHutang As DataGridView
    Friend WithEvents txtbxCari As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblJHutang As Label
    Friend WithEvents btnHapus As Button
End Class
