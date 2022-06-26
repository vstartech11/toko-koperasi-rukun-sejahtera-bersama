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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLogin))
        Me.txtbxUsername = New System.Windows.Forms.TextBox()
        Me.txtbxPassword = New System.Windows.Forms.MaskedTextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtbxUsername
        '
        Me.txtbxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxUsername.Location = New System.Drawing.Point(218, 65)
        Me.txtbxUsername.Name = "txtbxUsername"
        Me.txtbxUsername.Size = New System.Drawing.Size(213, 34)
        Me.txtbxUsername.TabIndex = 0
        '
        'txtbxPassword
        '
        Me.txtbxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxPassword.Location = New System.Drawing.Point(218, 122)
        Me.txtbxPassword.Name = "txtbxPassword"
        Me.txtbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbxPassword.Size = New System.Drawing.Size(213, 34)
        Me.txtbxPassword.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Location = New System.Drawing.Point(454, 159)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(111, 77)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtbxPassword)
        Me.Panel1.Controls.Add(Me.txtbxUsername)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 258)
        Me.Panel1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(311, 39)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "HALAMAN LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USERNAME"
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), System.Drawing.Image)
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHome.Location = New System.Drawing.Point(574, 3)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(48, 44)
        Me.btnHome.TabIndex = 4
        Me.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(634, 307)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "formLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formLogin"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbxUsername As TextBox
    Friend WithEvents txtbxPassword As MaskedTextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHome As Button
End Class
