﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 50)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Payment ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Member ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 119)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Membership ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 152)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Date of Entry:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 189)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 24)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Logged By:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 222)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Description:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 261)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 24)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Amount Due:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 298)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 24)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Amount Paid:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 335)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 24)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Payment Date:"
        '
        'paymentID_txt
        '
        Me.paymentID_txt.Enabled = False
        Me.paymentID_txt.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentID_txt.Location = New System.Drawing.Point(179, 57)
        Me.paymentID_txt.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.paymentID_txt.Name = "paymentID_txt"
        Me.paymentID_txt.Size = New System.Drawing.Size(89, 20)
        Me.paymentID_txt.TabIndex = 16
        '
        'loggedBy_lbl
        '
        Me.loggedBy_lbl.AutoSize = True
        Me.loggedBy_lbl.Font = New System.Drawing.Font("Agency FB", 13.84615!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loggedBy_lbl.Location = New System.Drawing.Point(127, 187)
        Me.loggedBy_lbl.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.loggedBy_lbl.Name = "loggedBy_lbl"
        Me.loggedBy_lbl.Size = New System.Drawing.Size(55, 24)
        Me.loggedBy_lbl.TabIndex = 14
        Me.loggedBy_lbl.Text = """Name"""
        '
        'amountDue_txt
        '
        Me.amountDue_txt.Enabled = False
        Me.amountDue_txt.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountDue_txt.Location = New System.Drawing.Point(131, 268)
        Me.amountDue_txt.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.amountDue_txt.Name = "amountDue_txt"
        Me.amountDue_txt.Size = New System.Drawing.Size(137, 20)
        Me.amountDue_txt.TabIndex = 16
        '
        'amountPaid_txt
        '
        Me.amountPaid_txt.Enabled = False
        Me.amountPaid_txt.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountPaid_txt.Location = New System.Drawing.Point(131, 304)
        Me.amountPaid_txt.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.amountPaid_txt.Name = "amountPaid_txt"
        Me.amountPaid_txt.Size = New System.Drawing.Size(137, 20)
        Me.amountPaid_txt.TabIndex = 16
        '
        'paymentDate_txt
        '
        Me.paymentDate_txt.Enabled = False
        Me.paymentDate_txt.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentDate_txt.Location = New System.Drawing.Point(131, 341)
        Me.paymentDate_txt.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.paymentDate_txt.Name = "paymentDate_txt"
        Me.paymentDate_txt.Size = New System.Drawing.Size(137, 20)
        Me.paymentDate_txt.TabIndex = 16
        '
        'save_btn
        '
        Me.save_btn.Enabled = False
        Me.save_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.Location = New System.Drawing.Point(223, 447)
        Me.save_btn.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(64, 31)
        Me.save_btn.TabIndex = 17
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'edit_btn
        '
        Me.edit_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_btn.Location = New System.Drawing.Point(8, 447)
        Me.edit_btn.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.edit_btn.Name = "edit_btn"
        Me.edit_btn.Size = New System.Drawing.Size(64, 31)
        Me.edit_btn.TabIndex = 17
        Me.edit_btn.Text = "Edit"
        Me.edit_btn.UseVisualStyleBackColor = True
        '
        'memberID_txt
        '
        Me.memberID_txt.Enabled = False
        Me.memberID_txt.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.memberID_txt.Location = New System.Drawing.Point(179, 89)
        Me.memberID_txt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.memberID_txt.Name = "memberID_txt"
        Me.memberID_txt.Size = New System.Drawing.Size(89, 20)
        Me.memberID_txt.TabIndex = 18
        '
        'ECM_lbl
        '
        Me.ECM_lbl.AutoSize = True
        Me.ECM_lbl.Font = New System.Drawing.Font("Agency FB", 13.84615!)
        Me.ECM_lbl.Location = New System.Drawing.Point(133, 89)
        Me.ECM_lbl.Name = "ECM_lbl"
        Me.ECM_lbl.Size = New System.Drawing.Size(35, 24)
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
        Me.membershipIDTypes_cbbox.Location = New System.Drawing.Point(131, 123)
        Me.membershipIDTypes_cbbox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.membershipIDTypes_cbbox.Name = "membershipIDTypes_cbbox"
        Me.membershipIDTypes_cbbox.Size = New System.Drawing.Size(137, 23)
        Me.membershipIDTypes_cbbox.TabIndex = 32
        '
        'DateOE_txt
        '
        Me.DateOE_txt.Enabled = False
        Me.DateOE_txt.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOE_txt.Location = New System.Drawing.Point(131, 159)
        Me.DateOE_txt.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.DateOE_txt.Name = "DateOE_txt"
        Me.DateOE_txt.Size = New System.Drawing.Size(137, 20)
        Me.DateOE_txt.TabIndex = 33
        '
        'add_btn
        '
        Me.add_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_btn.Location = New System.Drawing.Point(78, 447)
        Me.add_btn.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(64, 31)
        Me.add_btn.TabIndex = 34
        Me.add_btn.Text = "Add"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'delete_btn
        '
        Me.delete_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.Location = New System.Drawing.Point(151, 447)
        Me.delete_btn.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(64, 31)
        Me.delete_btn.TabIndex = 36
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'last_btn
        '
        Me.last_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.last_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_btn.Location = New System.Drawing.Point(201, 404)
        Me.last_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.last_btn.Name = "last_btn"
        Me.last_btn.Size = New System.Drawing.Size(29, 33)
        Me.last_btn.TabIndex = 37
        Me.last_btn.Text = ">>"
        Me.last_btn.UseVisualStyleBackColor = True
        '
        'next_btn
        '
        Me.next_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.next_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.next_btn.Location = New System.Drawing.Point(153, 404)
        Me.next_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(29, 33)
        Me.next_btn.TabIndex = 38
        Me.next_btn.Text = ">"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'previous_btn
        '
        Me.previous_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.previous_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previous_btn.Location = New System.Drawing.Point(105, 404)
        Me.previous_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.previous_btn.Name = "previous_btn"
        Me.previous_btn.Size = New System.Drawing.Size(29, 33)
        Me.previous_btn.TabIndex = 39
        Me.previous_btn.Text = "<"
        Me.previous_btn.UseVisualStyleBackColor = True
        '
        'first_btn
        '
        Me.first_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.first_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_btn.Location = New System.Drawing.Point(57, 404)
        Me.first_btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.first_btn.Name = "first_btn"
        Me.first_btn.Size = New System.Drawing.Size(29, 33)
        Me.first_btn.TabIndex = 40
        Me.first_btn.Text = "<<"
        Me.first_btn.UseVisualStyleBackColor = True
        '
        'PM_lbl
        '
        Me.PM_lbl.AutoSize = True
        Me.PM_lbl.Font = New System.Drawing.Font("Agency FB", 13.84615!)
        Me.PM_lbl.Location = New System.Drawing.Point(133, 57)
        Me.PM_lbl.Name = "PM_lbl"
        Me.PM_lbl.Size = New System.Drawing.Size(27, 24)
        Me.PM_lbl.TabIndex = 41
        Me.PM_lbl.Text = "PM"
        '
        'record_lbl
        '
        Me.record_lbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.record_lbl.AutoSize = True
        Me.record_lbl.Location = New System.Drawing.Point(130, 379)
        Me.record_lbl.Name = "record_lbl"
        Me.record_lbl.Size = New System.Drawing.Size(67, 13)
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
        Me.description_cbbox.Location = New System.Drawing.Point(131, 226)
        Me.description_cbbox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.description_cbbox.Name = "description_cbbox"
        Me.description_cbbox.Size = New System.Drawing.Size(137, 23)
        Me.description_cbbox.TabIndex = 43
        '
        'cancel_btn
        '
        Me.cancel_btn.Enabled = False
        Me.cancel_btn.Font = New System.Drawing.Font("Arial Narrow", 7.912088!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_btn.Location = New System.Drawing.Point(240, 404)
        Me.cancel_btn.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(46, 33)
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
        Me.currentTime_lbl.Location = New System.Drawing.Point(230, 19)
        Me.currentTime_lbl.Name = "currentTime_lbl"
        Me.currentTime_lbl.Size = New System.Drawing.Size(30, 13)
        Me.currentTime_lbl.TabIndex = 46
        Me.currentTime_lbl.Text = "Time"
        '
        'currentDate_lbl
        '
        Me.currentDate_lbl.AutoSize = True
        Me.currentDate_lbl.Location = New System.Drawing.Point(166, 19)
        Me.currentDate_lbl.Name = "currentDate_lbl"
        Me.currentDate_lbl.Size = New System.Drawing.Size(30, 13)
        Me.currentDate_lbl.TabIndex = 45
        Me.currentDate_lbl.Text = "Date"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(209, 379)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "*Inclusive GST"
        '
        'PInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 497)
        Me.Controls.Add(Me.Label10)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
