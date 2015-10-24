<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.firstName_txt = New System.Windows.Forms.TextBox()
        Me.memberID_txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'firstName_txt
        '
        Me.firstName_txt.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstName_txt.Location = New System.Drawing.Point(8, 142)
        Me.firstName_txt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.firstName_txt.Name = "firstName_txt"
        Me.firstName_txt.Size = New System.Drawing.Size(270, 20)
        Me.firstName_txt.TabIndex = 12
        '
        'memberID_txt
        '
        Me.memberID_txt.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.memberID_txt.Location = New System.Drawing.Point(7, 99)
        Me.memberID_txt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.memberID_txt.Name = "memberID_txt"
        Me.memberID_txt.Size = New System.Drawing.Size(270, 20)
        Me.memberID_txt.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.firstName_txt)
        Me.Controls.Add(Me.memberID_txt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents firstName_txt As System.Windows.Forms.TextBox
    Friend WithEvents memberID_txt As System.Windows.Forms.TextBox
End Class
