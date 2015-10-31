Imports System.Data.OleDb
Public Class Main
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ChoongFoo\Documents\GitHub\VB.N-Aissgnment\Membership.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da As New OleDbDataAdapter
    Dim ds, ds1 As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim Sql As String
    Dim totalRec, CurRec As Integer

    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        con.Open()
        Sql = "Select * from Members order by MemberID"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "MembersData")
        totalRec = ds.Tables("MembersData").Rows.Count
        CurRec = 0
        Call Filldata()
    End Sub

    Public Sub Filldata()
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
        CurRec = 0
        Call Filldata()
    End Sub

    Private Sub previous_btn_Click(sender As Object, e As EventArgs) Handles previous_btn.Click
        If CurRec <= 0 Then
            MsgBox("You have reach the first field.", MsgBoxStyle.Critical)
        Else
            CurRec = CurRec - 1
            Call Filldata()
        End If
    End Sub

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        If CurRec >= totalRec - 1 Then
            MsgBox("You have reach the Last field.", MsgBoxStyle.Critical)
        Else
            CurRec = CurRec + 1
            Call Filldata()
        End If
    End Sub

    Private Sub last_btn_Click(sender As Object, e As EventArgs) Handles last_btn.Click
        If CurRec >= totalRec - 1 Then
            MsgBox("At Last Record", MsgBoxStyle.Critical)
        Else
            CurRec = totalRec - 1
            Call Filldata()
        End If
    End Sub

    Private Sub remove_btn_Click(sender As Object, e As EventArgs) Handles remove_btn.Click
        If Role.Text <> "Administrator" Then
            MsgBox("This operation is only allow for Administrator", MsgBoxStyle.Critical)
            Exit Sub
        End If
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
        Form1.memberID_txt.Text = memberID_txt.Text
        Form1.Show()

    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click

        inChargeBy_lbl.Text = Role.Text

        memberID_txt.Clear()
        firstName_txt.Clear()
        lastName_txt.Clear()
        membershipIDTypes_cbbox.ResetText()
        contactNum_txt.Clear()
        emailAdd_txt.Clear()
        status_cbbox.ResetText()

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
        If save_btn.Text = "&Save" Then
            Sql = "insert into Members values ('"
            Sql = Sql & memberID_txt.Text & "','"
            Sql = Sql & firstName_txt.Text & "','"
            Sql = Sql & lastName_txt.Text & "','"
            Sql = Sql & membershipIDTypes_cbbox.Text & "','"
            Sql = Sql & contactNum_txt.Text & "','"
            Sql = Sql & emailAdd_txt.Text & "','"
            Sql = Sql & status_cbbox.Text & "','"
            Sql = Sql & inChargeBy_lbl.Text & "')"

            If firstName_txt.Text = "" Or lastName_txt.Text = "" Or membershipIDTypes_cbbox.Text = "" Or contactNum_txt.Text = "" Or emailAdd_txt.Text = "" Or status_cbbox.Text = "" Then
                MsgBox("Please fill in all the column.")
                Exit Sub
            End If
            cmd = New OleDbCommand(Sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("New member detail is added!")
            cancel_btn.PerformClick()

        Else
            Sql = "UPDATE Members SET"
            Sql = Sql & "[FirstName] = '" & firstName_txt.Text & "',"
            Sql = Sql & "[LastName] = '" & lastName_txt.Text & "',"
            Sql = Sql & "[MembershipID] = '" & membershipIDTypes_cbbox.Text & "',"
            Sql = Sql & "[ContactNumber] = '" & contactNum_txt.Text & "',"
            Sql = Sql & "[E-mailAddress] = '" & emailAdd_txt.Text & "',"
            Sql = Sql & "[Status] = '" & status_cbbox.Text & "' Where [MemberID] = " & "'" & memberID_txt.Text & "'"

            If firstName_txt.Text = "" Or lastName_txt.Text = "" Or membershipIDTypes_cbbox.Text = "" Or contactNum_txt.Text = "" Or emailAdd_txt.Text = "" Or status_cbbox.Text = "" Then
                MsgBox("Please fill in all the column.")
            Else
                Dim y As String
                y = MsgBox("Confirmation", MsgBoxStyle.YesNo)
                If y = vbYes Then
                    cmd = New OleDbCommand(Sql, con)
                    cmd.ExecuteNonQuery()
                    cancel_btn.PerformClick()


                Else
                    MsgBox("Updata is cancelled.")

                End If
            End If
        End If

    End Sub

    Private Sub status_cbbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles status_cbbox.SelectedIndexChanged

    End Sub

    Private Sub edit_btn_Click(sender As Object, e As EventArgs) Handles edit_btn.Click

        If Role.Text <> "Administrator" Then
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

    Private Sub membershipIDTypes_cbbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles membershipIDTypes_cbbox.SelectedIndexChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer_DateAndTime.Tick
        currentDate_lbl.Text = Date.Now.ToString("dd-MM-yyyy")
        currentTime_lbl.Text = TimeOfDay
    End Sub

    Private Sub record_lbl_Click(sender As Object, e As EventArgs) Handles record_lbl.Click

    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
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
        Dim i As Integer

        Sql = "Select * from Members"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds1, "SearchMember")
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

        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles timer_SaveOrUpdate.Tick

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles ECM_lbl.Click

    End Sub

    Private Sub inChargeBy_txt_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Role.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub logOut_btn_Click(sender As Object, e As EventArgs) Handles logOut_btn.Click
        Dim y As String
        y = MsgBox("Log-out confirmation.", MsgBoxStyle.YesNo)
        If y = vbYes Then
            Application.Restart()
        End If

    End Sub

    Private Sub inChargeBy_lbl_Click(sender As Object, e As EventArgs) Handles inChargeBy_lbl.Click

    End Sub
End Class