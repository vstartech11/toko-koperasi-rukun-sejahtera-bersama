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
        Me.dgvBMasuk = New System.Windows.Forms.DataGridView()
        CType(Me.dgvBMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBMasuk
        '
        Me.dgvBMasuk.AllowUserToAddRows = False
        Me.dgvBMasuk.AllowUserToDeleteRows = False
        Me.dgvBMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBMasuk.Location = New System.Drawing.Point(67, 85)
        Me.dgvBMasuk.Name = "dgvBMasuk"
        Me.dgvBMasuk.ReadOnly = True
        Me.dgvBMasuk.RowHeadersWidth = 51
        Me.dgvBMasuk.RowTemplate.Height = 24
        Me.dgvBMasuk.Size = New System.Drawing.Size(1010, 250)
        Me.dgvBMasuk.TabIndex = 0
        '
        'formBMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 649)
        Me.Controls.Add(Me.dgvBMasuk)
        Me.Name = "formBMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formBMasuk"
        CType(Me.dgvBMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvBMasuk As DataGridView
End Class
