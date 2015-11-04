<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PInfo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PInfo))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.paymentID_txt = New System.Windows.Forms.TextBox()
        Me.loggedBy_lbl = New System.Windows.Forms.Label()
        Me.amountDue_txt = New System.Windows.Forms.TextBox()
        Me.amountPaid_txt = New System.Windows.Forms.TextBox()
        Me.paymentDate_txt = New System.Windows.Forms.TextBox()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.edit_btn = New System.Windows.Forms.Button()
        Me.memberID_txt = New System.Windows.Forms.TextBox()
        Me.ECM_lbl = New System.Windows.Forms.Label()
        Me.membershipIDTypes_cbbox = New System.Windows.Forms.ComboBox()
        Me.DateOE_txt = New System.Windows.Forms.TextBox()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.last_btn = New System.Windows.Forms.Button()
        Me.next_btn = New System.Windows.Forms.Button()
        Me.previous_btn = New System.Windows.Forms.Button()
        Me.first_btn = New System.Windows.Forms.Button()
        Me.PM_lbl = New System.Windows.Forms.Label()
        Me.record_lbl = New System.Windows.Forms.Label()
        Me.description_cbbox = New System.Windows.Forms.ComboBox()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.currentTime_lbl = New System.Windows.Forms.Label()
        Me.currentDate_lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 96)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 42)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Payment ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 163)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 42)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Member ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 229)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 42)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Membership ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 292)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 42)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Date of Entry:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 363)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 42)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Logged By:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 427)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 42)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Description:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 502)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 42)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Amount Due:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 573)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 42)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Amount Paid:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 644)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 42)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Payment Date:"
        '
        'paymentID_txt
        '
        Me.paymentID_txt.Enabled = False
        Me.paymentID_txt.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentID_txt.Location = New System.Drawing.Point(358, 110)
        Me.paymentID_txt.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.paymentID_txt.Name = "paymentID_txt"
        Me.paymentID_txt.Size = New System.Drawing.Size(174, 30)
        Me.paymentID_txt.TabIndex = 16
        '
        'loggedBy_lbl
        '
        Me.loggedBy_lbl.AutoSize = True
        Me.loggedBy_lbl.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggedBy_lbl.Location = New System.Drawing.Point(254, 360)
        Me.loggedBy_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.loggedBy_lbl.Name = "loggedBy_lbl"
        Me.loggedBy_lbl.Size = New System.Drawing.Size(100, 42)
        Me.loggedBy_lbl.TabIndex = 14
        Me.loggedBy_lbl.Text = """Name"""
        '
        'amountDue_txt
        '
        Me.amountDue_txt.Enabled = False
        Me.amountDue_txt.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountDue_txt.Location = New System.Drawing.Point(262, 515)
        Me.amountDue_txt.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.amountDue_txt.Name = "amountDue_txt"
        Me.amountDue_txt.Size = New System.Drawing.Size(270, 30)
        Me.amountDue_txt.TabIndex = 16
        '
        'amountPaid_txt
        '
        Me.amountPaid_txt.Enabled = False
        Me.amountPaid_txt.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountPaid_txt.Location = New System.Drawing.Point(262, 585)
        Me.amountPaid_txt.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.amountPaid_txt.Name = "amountPaid_txt"
        Me.amountPaid_txt.Size = New System.Drawing.Size(270, 30)
        Me.amountPaid_txt.TabIndex = 16
        '
        'paymentDate_txt
        '
        Me.paymentDate_txt.Enabled = False
        Me.paymentDate_txt.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentDate_txt.Location = New System.Drawing.Point(262, 656)
        Me.paymentDate_txt.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.paymentDate_txt.Name = "paymentDate_txt"
        Me.paymentDate_txt.Size = New System.Drawing.Size(270, 30)
        Me.paymentDate_txt.TabIndex = 16
        '
        'save_btn
        '
        Me.save_btn.Enabled = False
        Me.save_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.Location = New System.Drawing.Point(446, 860)
        Me.save_btn.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(128, 60)
        Me.save_btn.TabIndex = 17
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'edit_btn
        '
        Me.edit_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_btn.Location = New System.Drawing.Point(16, 860)
        Me.edit_btn.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.edit_btn.Name = "edit_btn"
        Me.edit_btn.Size = New System.Drawing.Size(128, 60)
        Me.edit_btn.TabIndex = 17
        Me.edit_btn.Text = "Edit"
        Me.edit_btn.UseVisualStyleBackColor = True
        '
        'memberID_txt
        '
        Me.memberID_txt.Enabled = False
        Me.memberID_txt.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.memberID_txt.Location = New System.Drawing.Point(358, 171)
        Me.memberID_txt.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.memberID_txt.Name = "memberID_txt"
        Me.memberID_txt.Size = New System.Drawing.Size(174, 30)
        Me.memberID_txt.TabIndex = 18
        '
        'ECM_lbl
        '
        Me.ECM_lbl.AutoSize = True
        Me.ECM_lbl.Font = New System.Drawing.Font("Agency FB", 13.84615!)
        Me.ECM_lbl.Location = New System.Drawing.Point(266, 171)
        Me.ECM_lbl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.ECM_lbl.Name = "ECM_lbl"
        Me.ECM_lbl.Size = New System.Drawing.Size(63, 42)
        Me.ECM_lbl.TabIndex = 31
        Me.ECM_lbl.Text = "GCM"
        '
        'membershipIDTypes_cbbox
        '
        Me.membershipIDTypes_cbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.membershipIDTypes_cbbox.Enabled = False
        Me.membershipIDTypes_cbbox.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.membershipIDTypes_cbbox.FormattingEnabled = True
        Me.membershipIDTypes_cbbox.Items.AddRange(New Object() {"DLX", "NDLX", "WD"})
        Me.membershipIDTypes_cbbox.Location = New System.Drawing.Point(262, 237)
        Me.membershipIDTypes_cbbox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.membershipIDTypes_cbbox.Name = "membershipIDTypes_cbbox"
        Me.membershipIDTypes_cbbox.Size = New System.Drawing.Size(270, 32)
        Me.membershipIDTypes_cbbox.TabIndex = 32
        '
        'DateOE_txt
        '
        Me.DateOE_txt.Enabled = False
        Me.DateOE_txt.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOE_txt.Location = New System.Drawing.Point(262, 306)
        Me.DateOE_txt.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.DateOE_txt.Name = "DateOE_txt"
        Me.DateOE_txt.Size = New System.Drawing.Size(270, 30)
        Me.DateOE_txt.TabIndex = 33
        '
        'add_btn
        '
        Me.add_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_btn.Location = New System.Drawing.Point(156, 860)
        Me.add_btn.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(128, 60)
        Me.add_btn.TabIndex = 34
        Me.add_btn.Text = "Add"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.Location = New System.Drawing.Point(302, 860)
        Me.delete_btn.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(128, 60)
        Me.delete_btn.TabIndex = 36
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'last_btn
        '
        Me.last_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.last_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_btn.Location = New System.Drawing.Point(402, 777)
        Me.last_btn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.last_btn.Name = "last_btn"
        Me.last_btn.Size = New System.Drawing.Size(58, 63)
        Me.last_btn.TabIndex = 37
        Me.last_btn.Text = ">>"
        Me.last_btn.UseVisualStyleBackColor = True
        '
        'next_btn
        '
        Me.next_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.next_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.next_btn.Location = New System.Drawing.Point(306, 777)
        Me.next_btn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(58, 63)
        Me.next_btn.TabIndex = 38
        Me.next_btn.Text = ">"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'previous_btn
        '
        Me.previous_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.previous_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previous_btn.Location = New System.Drawing.Point(210, 777)
        Me.previous_btn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.previous_btn.Name = "previous_btn"
        Me.previous_btn.Size = New System.Drawing.Size(58, 63)
        Me.previous_btn.TabIndex = 39
        Me.previous_btn.Text = "<"
        Me.previous_btn.UseVisualStyleBackColor = True
        '
        'first_btn
        '
        Me.first_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.first_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_btn.Location = New System.Drawing.Point(114, 777)
        Me.first_btn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.first_btn.Name = "first_btn"
        Me.first_btn.Size = New System.Drawing.Size(58, 63)
        Me.first_btn.TabIndex = 40
        Me.first_btn.Text = "<<"
        Me.first_btn.UseVisualStyleBackColor = True
        '
        'PM_lbl
        '
        Me.PM_lbl.AutoSize = True
        Me.PM_lbl.Font = New System.Drawing.Font("Agency FB", 13.84615!)
        Me.PM_lbl.Location = New System.Drawing.Point(266, 110)
        Me.PM_lbl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.PM_lbl.Name = "PM_lbl"
        Me.PM_lbl.Size = New System.Drawing.Size(49, 42)
        Me.PM_lbl.TabIndex = 41
        Me.PM_lbl.Text = "PM"
        '
        'record_lbl
        '
        Me.record_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.record_lbl.AutoSize = True
        Me.record_lbl.Location = New System.Drawing.Point(260, 729)
        Me.record_lbl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.record_lbl.Name = "record_lbl"
        Me.record_lbl.Size = New System.Drawing.Size(133, 25)
        Me.record_lbl.TabIndex = 42
        Me.record_lbl.Text = "Record label"
        Me.record_lbl.Visible = False
        '
        'description_cbbox
        '
        Me.description_cbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.description_cbbox.Enabled = False
        Me.description_cbbox.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description_cbbox.FormattingEnabled = True
        Me.description_cbbox.Items.AddRange(New Object() {"Registration", "MonthlyFee"})
        Me.description_cbbox.Location = New System.Drawing.Point(262, 435)
        Me.description_cbbox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.description_cbbox.Name = "description_cbbox"
        Me.description_cbbox.Size = New System.Drawing.Size(270, 32)
        Me.description_cbbox.TabIndex = 43
        '
        'cancel_btn
        '
        Me.cancel_btn.Enabled = False
        Me.cancel_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_btn.Location = New System.Drawing.Point(480, 777)
        Me.cancel_btn.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(92, 63)
        Me.cancel_btn.TabIndex = 44
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'currentTime_lbl
        '
        Me.currentTime_lbl.AutoSize = True
        Me.currentTime_lbl.Location = New System.Drawing.Point(460, 37)
        Me.currentTime_lbl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.currentTime_lbl.Name = "currentTime_lbl"
        Me.currentTime_lbl.Size = New System.Drawing.Size(59, 25)
        Me.currentTime_lbl.TabIndex = 46
        Me.currentTime_lbl.Text = "Time"
        '
        'currentDate_lbl
        '
        Me.currentDate_lbl.AutoSize = True
        Me.currentDate_lbl.Location = New System.Drawing.Point(332, 37)
        Me.currentDate_lbl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.currentDate_lbl.Name = "currentDate_lbl"
        Me.currentDate_lbl.Size = New System.Drawing.Size(57, 25)
        Me.currentDate_lbl.TabIndex = 45
        Me.currentDate_lbl.Text = "Date"
        '
        'PInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 956)
        Me.Controls.Add(Me.currentTime_lbl)
        Me.Controls.Add(Me.currentDate_lbl)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.description_cbbox)
        Me.Controls.Add(Me.record_lbl)
        Me.Controls.Add(Me.PM_lbl)
        Me.Controls.Add(Me.last_btn)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.previous_btn)
        Me.Controls.Add(Me.first_btn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.add_btn)
        Me.Controls.Add(Me.DateOE_txt)
        Me.Controls.Add(Me.membershipIDTypes_cbbox)
        Me.Controls.Add(Me.ECM_lbl)
        Me.Controls.Add(Me.memberID_txt)
        Me.Controls.Add(Me.edit_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.paymentDate_txt)
        Me.Controls.Add(Me.amountPaid_txt)
        Me.Controls.Add(Me.amountDue_txt)
        Me.Controls.Add(Me.paymentID_txt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.loggedBy_lbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "PInfo"
        Me.Text = "Golf Club Membership Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents paymentID_txt As System.Windows.Forms.TextBox
    Friend WithEvents loggedBy_lbl As System.Windows.Forms.Label
    Friend WithEvents amountDue_txt As System.Windows.Forms.TextBox
    Friend WithEvents amountPaid_txt As System.Windows.Forms.TextBox
    Friend WithEvents paymentDate_txt As System.Windows.Forms.TextBox
    Friend WithEvents save_btn As System.Windows.Forms.Button
    Friend WithEvents edit_btn As System.Windows.Forms.Button
    Friend WithEvents memberID_txt As System.Windows.Forms.TextBox
    Friend WithEvents ECM_lbl As System.Windows.Forms.Label
    Friend WithEvents membershipIDTypes_cbbox As System.Windows.Forms.ComboBox
    Friend WithEvents DateOE_txt As System.Windows.Forms.TextBox
    Friend WithEvents add_btn As System.Windows.Forms.Button
    Friend WithEvents delete_btn As System.Windows.Forms.Button
    Friend WithEvents last_btn As System.Windows.Forms.Button
    Friend WithEvents next_btn As System.Windows.Forms.Button
    Friend WithEvents previous_btn As System.Windows.Forms.Button
    Friend WithEvents first_btn As System.Windows.Forms.Button
    Friend WithEvents PM_lbl As System.Windows.Forms.Label
    Friend WithEvents record_lbl As System.Windows.Forms.Label
    Friend WithEvents description_cbbox As System.Windows.Forms.ComboBox
    Friend WithEvents cancel_btn As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents currentTime_lbl As System.Windows.Forms.Label
    Friend WithEvents currentDate_lbl As System.Windows.Forms.Label
End Class
