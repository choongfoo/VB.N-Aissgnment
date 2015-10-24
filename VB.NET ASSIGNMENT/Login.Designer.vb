<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.username_cbbox = New System.Windows.Forms.ComboBox()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.quit_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 28.08791!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(561, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Golf Club Membership Management System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 22.15385!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(168, 165)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 36)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 22.15385!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(168, 216)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 36)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Password:"
        '
        'password_txt
        '
        Me.password_txt.Location = New System.Drawing.Point(305, 227)
        Me.password_txt.Margin = New System.Windows.Forms.Padding(2)
        Me.password_txt.Multiline = True
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txt.Size = New System.Drawing.Size(192, 21)
        Me.password_txt.TabIndex = 1
        '
        'LoginBtn
        '
        Me.LoginBtn.Location = New System.Drawing.Point(221, 411)
        Me.LoginBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(103, 44)
        Me.LoginBtn.TabIndex = 2
        Me.LoginBtn.Text = "&Login"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(344, 411)
        Me.ExitBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(103, 44)
        Me.ExitBtn.TabIndex = 2
        Me.ExitBtn.Text = "E&xit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'username_cbbox
        '
        Me.username_cbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.username_cbbox.FormattingEnabled = True
        Me.username_cbbox.Location = New System.Drawing.Point(305, 176)
        Me.username_cbbox.Name = "username_cbbox"
        Me.username_cbbox.Size = New System.Drawing.Size(192, 21)
        Me.username_cbbox.TabIndex = 4
        '
        'login_btn
        '
        Me.login_btn.Location = New System.Drawing.Point(198, 277)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(106, 46)
        Me.login_btn.TabIndex = 5
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = True
        '
        'quit_btn
        '
        Me.quit_btn.Location = New System.Drawing.Point(391, 277)
        Me.quit_btn.Name = "quit_btn"
        Me.quit_btn.Size = New System.Drawing.Size(106, 46)
        Me.quit_btn.TabIndex = 6
        Me.quit_btn.Text = "Quit"
        Me.quit_btn.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 385)
        Me.Controls.Add(Me.quit_btn)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.username_cbbox)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Login"
        Me.Text = "Golf Club Membership Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents password_txt As System.Windows.Forms.TextBox
    Friend WithEvents LoginBtn As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents username_cbbox As System.Windows.Forms.ComboBox
    Friend WithEvents login_btn As System.Windows.Forms.Button
    Friend WithEvents quit_btn As System.Windows.Forms.Button

End Class
