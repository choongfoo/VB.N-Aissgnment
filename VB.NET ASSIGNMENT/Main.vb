Imports System.Data.OleDb
Public Class Main
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & Application.StartupPath & "\Membership.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da As New OleDbDataAdapter
    Dim ds, ds1 As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim Sql As String
    Dim totalRec, CurRec As Integer
    Dim ButtonCheck As Boolean
 
    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ButtonCheck = False Then
            Login.Close()
        End If
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fill the record database where Members table and ascending order by MemberID 
        ButtonCheck = False
        con.Open()
        Sql = "Select * from Members order by MemberID"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "MembersData")
        totalRec = ds.Tables("MembersData").Rows.Count
        CurRec = 0
        Call Filldata()
    End Sub

    Public Sub Filldata() 'Fill in the record from the database
        memberID_txt.Text = ds.Tables("MembersData").Rows(CurRec).Item(0)
        firstName_txt.Text = ds.Tables("MembersData").Rows(CurRec).Item(1)
        lastName_txt.Text = ds.Tables("MembersData").Rows(CurRec).Item(2)
        membershipIDTypes_cbbox.Text = ds.Tables("MembersData").Rows(CurRec).Item(3)
        contactNum_txt.Text = ds.Tables("MembersData").Rows(CurRec).Item(4)
        emailAdd_txt.Text = ds.Tables("MembersData").Rows(CurRec).Item(5)
        status_cbbox.Text = ds.Tables("MembersData").Rows(CurRec).Item(6)
        inChargeBy_lbl.Text = ds.Tables("MembersData").Rows(CurRec).Item(7)
        record_lbl.Text = CurRec + 1 & " / " & totalRec
    End Sub

    Private Sub first_btn_Click(sender As Object, e As EventArgs) Handles first_btn.Click
        'First record
        CurRec = 0
        Call Filldata()
    End Sub

    Private Sub previous_btn_Click(sender As Object, e As EventArgs) Handles previous_btn.Click
        'Previous record
        If CurRec <= 0 Then
            MsgBox("You have reach the first field.", MsgBoxStyle.Critical)
        Else
            CurRec = CurRec - 1
            Call Filldata()
        End If
    End Sub

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        'Next record
        If CurRec >= totalRec - 1 Then
            MsgBox("You have reach the Last field.", MsgBoxStyle.Critical)
        Else
            CurRec = CurRec + 1
            Call Filldata()
        End If
    End Sub

    Private Sub last_btn_Click(sender As Object, e As EventArgs) Handles last_btn.Click
        'Last record
        If CurRec >= totalRec - 1 Then
            MsgBox("At Last Record", MsgBoxStyle.Critical)
        Else
            CurRec = totalRec - 1
            Call Filldata()
        End If
    End Sub

    Private Sub remove_btn_Click(sender As Object, e As EventArgs) Handles remove_btn.Click
        'Remove member
        If Role.Text <> "Administrator" Then 'If the user is not administrator, disable this operation
            MsgBox("This operation is only allow for Administrator", MsgBoxStyle.Critical)
            Exit Sub
        End If
        'Sql query for deleting record
        Sql = "Delete * from Members where "
        Sql = Sql & "MemberID= '" & memberID_txt.Text & "'"
        cmd = New OleDbCommand(Sql, con)
        Dim y As String
        y = MsgBox("Confirm deletion", MsgBoxStyle.YesNo)
        If y = vbYes Then
            cmd.ExecuteNonQuery()
            MsgBox("Deleted")
            cancel_btn.PerformClick()
        Else
            MsgBox("Not deleted")
        End If

    End Sub
    Private Sub paymentInfo_btn_Click(sender As Object, e As EventArgs) Handles paymentInfo_btn.Click
        'Open payment info
        PInfo.memberID_txt.Text = memberID_txt.Text
        PInfo.membershipIDTypes_cbbox.Text = membershipIDTypes_cbbox.Text
        PInfo.Show()
        Me.Enabled = False
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        'Add new member
        inChargeBy_lbl.Text = Role.Text

        memberID_txt.Clear()
        firstName_txt.Clear()
        lastName_txt.Clear()
        membershipIDTypes_cbbox.SelectedIndex = -1
        contactNum_txt.Clear()
        emailAdd_txt.Clear()
        status_cbbox.SelectedIndex = -1

        'To count the memberID that is not existing and add it automatically
        Dim newMemberID As Integer = 1000
        Dim i As Integer
        For i = 0 To totalRec - 1
            If newMemberID = ds.Tables("MembersData").Rows(i).Item(0) Then
                newMemberID += 1
            Else
                Exit For
            End If
        Next
        memberID_txt.Text = newMemberID

        cancel_btn.Enabled = True
        save_btn.Enabled = True
        firstName_txt.Enabled = True
        lastName_txt.Enabled = True
        membershipIDTypes_cbbox.Enabled = True
        contactNum_txt.Enabled = True
        emailAdd_txt.Enabled = True
        status_cbbox.Enabled = True

        logOut_btn.Enabled = False
        add_btn.Enabled = False
        remove_btn.Enabled = False
        edit_btn.Enabled = False
        search_btn.Enabled = False
        first_btn.Enabled = False
        previous_btn.Enabled = False
        next_btn.Enabled = False
        last_btn.Enabled = False
        search_txt.Enabled = False
        paymentInfo_btn.Enabled = False
    End Sub
    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        'Save new member information detail into database
        If save_btn.Text = "Save" Then
            'Sql query for insert record to the database
            Sql = "insert into Members values ('"
            Sql = Sql & memberID_txt.Text & "','"
            Sql = Sql & firstName_txt.Text & "','"
            Sql = Sql & lastName_txt.Text & "','"
            Sql = Sql & membershipIDTypes_cbbox.Text & "','"
            Sql = Sql & contactNum_txt.Text & "','"
            Sql = Sql & emailAdd_txt.Text & "','"
            Sql = Sql & status_cbbox.Text & "','"
            Sql = Sql & inChargeBy_lbl.Text & "')"

            'If the user is not fill in all the record, alert the user and ask for re-fill
            If firstName_txt.Text = "" Or lastName_txt.Text = "" Or membershipIDTypes_cbbox.Text = "" Or contactNum_txt.Text = "" Or emailAdd_txt.Text = "" Or status_cbbox.Text = "" Then
                MsgBox("Please fill in all the column.")
                Exit Sub
            End If
            cmd = New OleDbCommand(Sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("New member detail is added!")
            cancel_btn.PerformClick()

        Else
            'Sql query for updating record from database
            Sql = "UPDATE Members SET"
            Sql = Sql & "[FirstName] = '" & firstName_txt.Text & "',"
            Sql = Sql & "[LastName] = '" & lastName_txt.Text & "',"
            Sql = Sql & "[MembershipID] = '" & membershipIDTypes_cbbox.Text & "',"
            Sql = Sql & "[ContactNumber] = '" & contactNum_txt.Text & "',"
            Sql = Sql & "[EmailAddress] = '" & emailAdd_txt.Text & "',"
            Sql = Sql & "[Status] = '" & status_cbbox.Text & "' Where [MemberID] = " & "'" & memberID_txt.Text & "'"

            'If the user is not fill in all the record, alert the user and ask for re-fill
            If firstName_txt.Text = "" Or lastName_txt.Text = "" Or membershipIDTypes_cbbox.Text = "" Or contactNum_txt.Text = "" Or emailAdd_txt.Text = "" Or status_cbbox.Text = "" Then
                MsgBox("Please fill in all the column.")
            Else
                Dim y As String
                y = MsgBox("Update Confirmation", MsgBoxStyle.YesNo)
                If y = vbYes Then
                    cmd = New OleDbCommand(Sql, con)
                    cmd.ExecuteNonQuery()
                    cancel_btn.PerformClick()
                    save_btn.Text = "Save"
                Else
                    MsgBox("Updata is cancelled.")
                End If
            End If
        End If
    End Sub
    Private Sub edit_btn_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
        'Edit member information detail
        If Role.Text <> "Administrator" Then 'If the user is not administrator, disable this operation
            MsgBox("This operation is only allow for Administrator", MsgBoxStyle.Critical)
            Exit Sub
        End If

        save_btn.Text = "Update"

        firstName_txt.Enabled = True
        lastName_txt.Enabled = True
        membershipIDTypes_cbbox.Enabled = True
        contactNum_txt.Enabled = True
        emailAdd_txt.Enabled = True
        status_cbbox.Enabled = True

        cancel_btn.Enabled = True
        save_btn.Enabled = True
        add_btn.Enabled = False
        remove_btn.Enabled = False
        edit_btn.Enabled = False
        search_btn.Enabled = False
        first_btn.Enabled = False
        previous_btn.Enabled = False
        next_btn.Enabled = False
        last_btn.Enabled = False
        search_txt.Enabled = False
        paymentInfo_btn.Enabled = False
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer_DateAndTime.Tick
        'Show the current date and time
        currentDate_lbl.Text = Date.Now.ToString("dd-MM-yyyy")
        currentTime_lbl.Text = TimeOfDay
    End Sub
    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        'To cancel the add and edit operation 
        ds.Clear()
        Sql = "Select * from Members order by MemberID"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "MembersData")
        totalRec = ds.Tables("MembersData").Rows.Count
        CurRec = 0
        Call Filldata()

        firstName_txt.Enabled = False
        lastName_txt.Enabled = False
        membershipIDTypes_cbbox.Enabled = False
        contactNum_txt.Enabled = False
        emailAdd_txt.Enabled = False
        status_cbbox.Enabled = False

        logOut_btn.Enabled = True
        cancel_btn.Enabled = False
        save_btn.Enabled = False
        add_btn.Enabled = True
        remove_btn.Enabled = True
        edit_btn.Enabled = True
        search_btn.Enabled = True
        first_btn.Enabled = True
        previous_btn.Enabled = True
        next_btn.Enabled = True
        last_btn.Enabled = True
        search_txt.Enabled = True
        paymentInfo_btn.Enabled = True
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        'To search the record order by MemberID
        Dim i As Integer
        If search_btn.Text = "Search" Then
            Sql = "Select * from Members"
            da = New OleDbDataAdapter(Sql, con)
            da.Fill(ds1, "SearchMember")
            'To verify the user key in value with the existing MemberID to find out the record
            For i = 0 To totalRec - 1
                If search_txt.Text = ds1.Tables("SearchMember").Rows(i).Item(0).ToString Then
                    memberID_txt.Text = search_txt.Text
                    Exit For
                End If
            Next

            If search_txt.Text <> memberID_txt.Text Then
                MsgBox("Unable to find data")
            Else
                ds1.Clear()

                Sql = "select * from Members where MemberID = '" & memberID_txt.Text & "'"
                da = New OleDbDataAdapter(Sql, con)
                da.Fill(ds1, "SearchMember")

                memberID_txt.Text = ds1.Tables("SearchMember").Rows(0).Item(0)
                firstName_txt.Text = ds1.Tables("SearchMember").Rows(0).Item(1)
                lastName_txt.Text = ds1.Tables("SearchMember").Rows(0).Item(2)
                membershipIDTypes_cbbox.Text = ds1.Tables("SearchMember").Rows(0).Item(3)
                contactNum_txt.Text = ds1.Tables("SearchMember").Rows(0).Item(4)
                emailAdd_txt.Text = ds1.Tables("SearchMember").Rows(0).Item(5)
                status_cbbox.Text = ds1.Tables("SearchMember").Rows(0).Item(6)
                inChargeBy_lbl.Text = ds1.Tables("SearchMember").Rows(0).Item(7)
                record_lbl.Text = "1" & " / " & "1"

                search_btn.Text = "Back"
            End If
        Else
            ds.Clear()
            Sql = "Select * from Members order by MemberID"
            da = New OleDbDataAdapter(Sql, con)
            da.Fill(ds, "MembersData")
            totalRec = ds.Tables("MembersData").Rows.Count
            CurRec = 0
            search_btn.Text = "Search"
            Call Filldata()
        End If
    End Sub
    Private Sub logOut_btn_Click(sender As Object, e As EventArgs) Handles logOut_btn.Click
        'Staff logout
        Dim y As String
        y = MsgBox("Logout confirmation.", MsgBoxStyle.YesNo)
        If y = vbYes Then
            ButtonCheck = True
            Application.Restart()
        End If

    End Sub
    Private Sub report_btn_Click(sender As Object, e As EventArgs) Handles report_btn.Click
        'To show the member and payment report
        MemberReport.Show()
        PaymentReport.Show()
    End Sub
End Class