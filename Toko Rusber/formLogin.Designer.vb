<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
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
        Me.txtbxUsername = New System.Windows.Forms.TextBox()
        Me.txtbxPassword = New System.Windows.Forms.MaskedTextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtbxUsername
        '
        Me.txtbxUsername.Location = New System.Drawing.Point(231, 91)
        Me.txtbxUsername.Name = "txtbxUsername"
        Me.txtbxUsername.Size = New System.Drawing.Size(213, 22)
        Me.txtbxUsername.TabIndex = 0
        '
        'txtbxPassword
        '
        Me.txtbxPassword.Location = New System.Drawing.Point(231, 148)
        Me.txtbxPassword.Name = "txtbxPassword"
        Me.txtbxPassword.Size = New System.Drawing.Size(213, 22)
        Me.txtbxPassword.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(385, 215)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(178, 50)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 404)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtbxPassword)
        Me.Controls.Add(Me.txtbxUsername)
        Me.MaximizeBox = False
        Me.Name = "formLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbxUsername As TextBox
    Friend WithEvents txtbxPassword As MaskedTextBox
    Friend WithEvents btnLogin As Button
End Class
