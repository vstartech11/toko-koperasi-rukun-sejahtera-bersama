<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUbahPass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formUbahPass))
        Me.txtbxPassLama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxPassBaru = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbxKonfirm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtbxPassLama
        '
        Me.txtbxPassLama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxPassLama.Location = New System.Drawing.Point(293, 105)
        Me.txtbxPassLama.Name = "txtbxPassLama"
        Me.txtbxPassLama.Size = New System.Drawing.Size(213, 34)
        Me.txtbxPassLama.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "USERNAME"
        '
        'txtbxPassBaru
        '
        Me.txtbxPassBaru.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxPassBaru.Location = New System.Drawing.Point(293, 168)
        Me.txtbxPassBaru.Name = "txtbxPassBaru"
        Me.txtbxPassBaru.Size = New System.Drawing.Size(213, 34)
        Me.txtbxPassBaru.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(142, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "USERNAME"
        '
        'txtbxKonfirm
        '
        Me.txtbxKonfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxKonfirm.Location = New System.Drawing.Point(293, 240)
        Me.txtbxKonfirm.Name = "txtbxKonfirm"
        Me.txtbxKonfirm.Size = New System.Drawing.Size(213, 34)
        Me.txtbxKonfirm.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "USERNAME"
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSimpan.BackgroundImage = CType(resources.GetObject("btnSimpan.BackgroundImage"), System.Drawing.Image)
        Me.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSimpan.Location = New System.Drawing.Point(567, 298)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(111, 77)
        Me.btnSimpan.TabIndex = 7
        Me.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'formUbahPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.txtbxKonfirm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbxPassBaru)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbxPassLama)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formUbahPass"
        Me.Text = "formUbahPass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbxPassLama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxPassBaru As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxKonfirm As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSimpan As Button
End Class
