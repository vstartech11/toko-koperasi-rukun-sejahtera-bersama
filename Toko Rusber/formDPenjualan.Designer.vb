<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDPenjualan
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
        Me.dgvDPenjualan = New System.Windows.Forms.DataGridView()
        Me.txtbxCari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvDPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDPenjualan
        '
        Me.dgvDPenjualan.AllowUserToAddRows = False
        Me.dgvDPenjualan.AllowUserToDeleteRows = False
        Me.dgvDPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDPenjualan.Location = New System.Drawing.Point(51, 93)
        Me.dgvDPenjualan.Name = "dgvDPenjualan"
        Me.dgvDPenjualan.ReadOnly = True
        Me.dgvDPenjualan.RowHeadersWidth = 51
        Me.dgvDPenjualan.RowTemplate.Height = 24
        Me.dgvDPenjualan.Size = New System.Drawing.Size(1015, 201)
        Me.dgvDPenjualan.TabIndex = 0
        '
        'txtbxCari
        '
        Me.txtbxCari.Location = New System.Drawing.Point(856, 61)
        Me.txtbxCari.Name = "txtbxCari"
        Me.txtbxCari.Size = New System.Drawing.Size(184, 22)
        Me.txtbxCari.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(801, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cari :"
        '
        'formDPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 596)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbxCari)
        Me.Controls.Add(Me.dgvDPenjualan)
        Me.Name = "formDPenjualan"
        Me.Text = "Detail Penjualan"
        CType(Me.dgvDPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDPenjualan As DataGridView
    Friend WithEvents txtbxCari As TextBox
    Friend WithEvents Label1 As Label
End Class
