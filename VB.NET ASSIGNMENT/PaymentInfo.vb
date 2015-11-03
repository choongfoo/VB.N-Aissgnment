Imports System.Data.OleDb
Public Class PInfo
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & Application.StartupPath & "\Membership.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da As New OleDbDataAdapter
    Dim ds, ds1 As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim Sql, Sql1 As String
    Dim curRec, totalRec As Integer
    Dim amountPayment As Double = 0
    Private Sub PInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Main.Enabled = True
    End Sub

    Private Sub PInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Sql = "Select * from Payment where MemberID ='" & memberID_txt.Text & "'"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "PaymentData")
        totalRec = ds.Tables("PaymentData").Rows.Count
        curRec = 0

        'If has existing payment record, fill data from database
        If totalRec >= 1 Then
            DateOE_txt.Enabled = False
            description_cbbox.Enabled = False
            paymentDate_txt.Enabled = False
            Call Filldata()

        Else
            'If no existing payment record, perform add button
            add_btn.PerformClick()

            save_btn.Enabled = True
            first_btn.Enabled = False
            previous_btn.Enabled = False
            next_btn.Enabled = False
            last_btn.Enabled = False
            add_btn.Enabled = False
            edit_btn.Enabled = False
            delete_btn.Enabled = False
            cancel_btn.Enabled = False
        End If
    End Sub

    Public Sub Filldata()

        If totalRec >= 1 Then
            DateOE_txt.Enabled = False
            description_cbbox.Enabled = False
            paymentDate_txt.Enabled = False
            amountPaid_txt.Enabled = False

            totalRec = ds.Tables("PaymentData").Rows.Count
            paymentID_txt.Text = ds.Tables("PaymentData").Rows(curRec).Item(0)
            memberID_txt.Text = ds.Tables("PaymentData").Rows(curRec).Item(1)
            membershipIDTypes_cbbox.Text = ds.Tables("PaymentData").Rows(curRec).Item(2)
            DateOE_txt.Text = ds.Tables("PaymentData").Rows(curRec).Item(3)
            loggedBy_lbl.Text = ds.Tables("PaymentData").Rows(curRec).Item(4)
            description_cbbox.Text = ds.Tables("PaymentData").Rows(curRec).Item(5)
            amountDue_txt.Text = ds.Tables("PaymentData").Rows(curRec).Item(6)
            amountPaid_txt.Text = ds.Tables("PaymentData").Rows(curRec).Item(7)
            paymentDate_txt.Text = ds.Tables("PaymentData").Rows(curRec).Item(8)
            record_lbl.Visible = True
            record_lbl.Text = curRec + 1 & " / " & totalRec

        Else
            add_btn.PerformClick()

            record_lbl.Text = ""
            save_btn.Enabled = True
            first_btn.Enabled = False
            previous_btn.Enabled = False
            next_btn.Enabled = False
            last_btn.Enabled = False
            add_btn.Enabled = False
            edit_btn.Enabled = False
            delete_btn.Enabled = False
        End If
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        'Save new payment information detail into database
        If save_btn.Text = "Save" Then
            'Sql query for insert record to the database
            Sql = "insert into Payment values ('"
            Sql = Sql & paymentID_txt.Text & "','"
            Sql = Sql & memberID_txt.Text & "','"
            Sql = Sql & membershipIDTypes_cbbox.Text & "','"
            Sql = Sql & DateOE_txt.Text & "','"
            Sql = Sql & loggedBy_lbl.Text & "','"
            Sql = Sql & description_cbbox.Text & "','"
            Sql = Sql & amountDue_txt.Text & "','"
            Sql = Sql & amountPaid_txt.Text & "','"
            Sql = Sql & paymentDate_txt.Text & "')"

            'If the user is not fill in all the record, alert the user and ask for re-fill
            If DateOE_txt.Text = "" Or description_cbbox.Text = "" Or membershipIDTypes_cbbox.Text = "" Or amountPaid_txt.Text = "" Or paymentDate_txt.Text = "" Then
                MsgBox("Please fill in all the column.")
                Exit Sub
            End If

            cmd = New OleDbCommand(Sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("New payment detail is added!")
            cancel_btn.Enabled = True
            cancel_btn.PerformClick()

        Else
            'Sql query for updating record from database
            Sql = "UPDATE Payment SET "
            Sql = Sql & "[DateOfEntry] = '" & DateOE_txt.Text & "',"
            Sql = Sql & "[Description] = '" & description_cbbox.Text & "',"
            Sql = Sql & "[AmountDue] = '" & amountDue_txt.Text & "',"
            Sql = Sql & "[AmountPaid] = '" & amountPaid_txt.Text & "',"
            Sql = Sql & "[PaymentDate] = '" & paymentDate_txt.Text & "' Where [PaymentID] = " & "'" & paymentID_txt.Text & "'"

            'If the user is not fill in all the record, alert the user and ask for re-fill
            If DateOE_txt.Text = "" Or description_cbbox.Text = "" Or membershipIDTypes_cbbox.Text = "" Or amountPaid_txt.Text = "" Or paymentDate_txt.Text = "" Then
                MsgBox("Please fill in all the column.")
                Exit Sub
            End If

            Dim y As String
            y = MsgBox("Update Confirmation", MsgBoxStyle.YesNo)
            If y = vbYes Then
                cmd = New OleDbCommand(Sql, con)
                cmd.ExecuteNonQuery()
                cancel_btn.Enabled = True
                cancel_btn.PerformClick()
                save_btn.Text = "Save"

            Else
                MsgBox("Updata is cancelled.")
            End If
        End If
        save_btn.Enabled = False
        save_btn.Text = "Save"

    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        'Add new payment
        DateOE_txt.Text = Date.Now.ToString("dd-MM-yyyy")
        loggedBy_lbl.Text = Main.nameID.Text
        paymentDate_txt.Text = Date.Now.ToString("dd-MM-yyyy")

        paymentID_txt.Clear()
        description_cbbox.SelectedIndex = -1
        amountDue_txt.Clear()
        amountPaid_txt.Clear()

        'To count the paymentID that is not existing and add it automatically
        Dim newPaymentID As Integer = 1000
        Dim i As Integer
        For i = 0 To totalRec - 1
            If newPaymentID = ds.Tables("PaymentData").Rows(i).Item(0) Then
                newPaymentID += 1
            Else
                Exit For
            End If
        Next
        paymentID_txt.Text = newPaymentID


        DateOE_txt.Enabled = False
        amountPaid_txt.Enabled = False
        paymentDate_txt.Enabled = False



        description_cbbox.Enabled = True
        save_btn.Enabled = True

        cancel_btn.Enabled = True
        add_btn.Enabled = False
        edit_btn.Enabled = False
        delete_btn.Enabled = False
        first_btn.Enabled = False
        previous_btn.Enabled = False
        next_btn.Enabled = False
        last_btn.Enabled = False
    End Sub

    Private Sub edit_btn_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
        'Edit member information detail
        save_btn.Text = "Update"

        DateOE_txt.Enabled = True
        description_cbbox.Enabled = True
        amountPaid_txt.Enabled = True
        paymentDate_txt.Enabled = True
        save_btn.Enabled = True

        cancel_btn.Enabled = True
        edit_btn.Enabled = False
        add_btn.Enabled = False
        delete_btn.Enabled = False
        first_btn.Enabled = False
        previous_btn.Enabled = False
        next_btn.Enabled = False
        last_btn.Enabled = False
    End Sub
    Private Sub first_btn_Click(sender As Object, e As EventArgs) Handles first_btn.Click
        'First record
        curRec = 0
        Call Filldata()
    End Sub
    Private Sub previous_btn_Click(sender As Object, e As EventArgs) Handles previous_btn.Click
        'Previous Record
        If curRec <= 0 Then
            MsgBox("You have reach the first field.", MsgBoxStyle.Critical)
        Else
            curRec = curRec - 1
            Call Filldata()
        End If
    End Sub
    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        'Next record
        If curRec >= totalRec - 1 Then
            MsgBox("You have reach the Last field.", MsgBoxStyle.Critical)
        Else
            curRec = curRec + 1
            Call Filldata()
        End If
    End Sub
    Private Sub last_btn_Click(sender As Object, e As EventArgs) Handles last_btn.Click
        'Last record
        If curRec >= totalRec - 1 Then
            MsgBox("At Last Record", MsgBoxStyle.Critical)
        Else
            curRec = totalRec - 1
            Call Filldata()
        End If
    End Sub
    Private Sub description_cbbox_TextChanged(sender As Object, e As EventArgs) Handles description_cbbox.TextChanged
        'Membership fee type
        If membershipIDTypes_cbbox.Text = "DLX" Then
            If description_cbbox.Text = "Registration" Then
                amountDue_txt.Text = 500
            ElseIf description_cbbox.Text = "MonthlyFee" Then
                amountDue_txt.Text = 120
            End If

        ElseIf membershipIDTypes_cbbox.Text = "NDLX" Then
            If description_cbbox.Text = "Registration" Then
                amountDue_txt.Text = 300
            ElseIf description_cbbox.Text = "MonthlyFee" Then
                amountDue_txt.Text = 100
            End If

        ElseIf membershipIDTypes_cbbox.Text = "WD" Then
            If description_cbbox.Text = "Registration" Then
                amountDue_txt.Text = 180
            ElseIf description_cbbox.Text = "MonthlyFee" Then
                amountDue_txt.Text = 75
            End If
        End If
        amountPaid_txt.Text = amountDue_txt.Text
    End Sub
    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        'Delete payment record
        Sql = "Delete * from Payment where " 'Sql query for deleting record
        Sql = Sql & "PaymentID= '" & paymentID_txt.Text & "'"
        cmd = New OleDbCommand(Sql, con)
        Dim y As String
        y = MsgBox("Confirm deletion", MsgBoxStyle.YesNo)
        If y = vbYes Then
            cmd.ExecuteNonQuery()
            MsgBox("Deleted")
            cancel_btn.Enabled = True
            cancel_btn.PerformClick()
        Else
            MsgBox("Not deleted")
        End If
    End Sub
    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        'To cancel the add and edit operation 
        ds.Clear()
        Sql = "Select * from Payment where MemberID ='" & memberID_txt.Text & "'"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "PaymentData")
        totalRec = ds.Tables("PaymentData").Rows.Count
        curRec = 0


        save_btn.Text = "Save"

        first_btn.Enabled = True
        previous_btn.Enabled = True
        next_btn.Enabled = True
        last_btn.Enabled = True
        add_btn.Enabled = True
        edit_btn.Enabled = True
        delete_btn.Enabled = True

        cancel_btn.Enabled = False
        DateOE_txt.Enabled = False
        description_cbbox.Enabled = False
        amountPaid_txt.Enabled = False
        paymentDate_txt.Enabled = False


        save_btn.Enabled = False

        Call Filldata()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Show current date and time
        currentDate_lbl.Text = Date.Now.ToString("dd-MM-yyyy")
        currentTime_lbl.Text = TimeOfDay
    End Sub
End Class