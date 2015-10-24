Imports System.Data.OleDb
Public Class Main
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ChoongFoo\Documents\APU\Semester 4\VBN Assignment\Membership.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim Sql As String
    Dim totalRec, CurRec As Integer
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Sql = "Select * from Members"
        da = New OleDbDataAdapter(Sql, con)
        da.Fill(ds, "Members")
        totalRec = ds.Tables("Members").Rows.Count
        CurRec = 0
        Call Filldata()
    End Sub

    Public Sub Filldata()
        memberID_txt.Text = ds.Tables("Members").Rows(CurRec).Item(0)
        firstName_txt.Text = ds.Tables("Members").Rows(CurRec).Item(1)
        lastName_txt.Text = ds.Tables("Members").Rows(CurRec).Item(2)
        membershipIDTypes_cbbox.Text = ds.Tables("Members").Rows(CurRec).Item(3)
        contactNum_txt.Text = ds.Tables("Members").Rows(CurRec).Item(4)
        emailAdd_txt.Text = ds.Tables("Members").Rows(CurRec).Item(5)
        status_cbbox.Text = ds.Tables("Members").Rows(CurRec).Item(6)
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
        Sql = "Delete * from Members where "
        Sql = Sql & "MemberID=" & memberID_txt.Text
        cmd = New OleDbCommand(Sql, con)
        Dim y As String
        y = MsgBox("Confirm deletion", MsgBoxStyle.YesNo)
        If y = vbYes Then
            cmd.ExecuteNonQuery()
            MsgBox("Deleted")
        Else
            MsgBox("Not deleted")
        End If
    End Sub

    Private Sub paymentInfo_btn_Click(sender As Object, e As EventArgs) Handles paymentInfo_btn.Click
        Form1.memberID_txt.Text = memberID_txt.Text
        Form1.Show()

    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        memberID_txt.Clear()
        firstName_txt.Clear()
        lastName_txt.Clear()
        membershipIDTypes_cbbox.ResetText()
        contactNum_txt.Clear()
        emailAdd_txt.Clear()
        status_cbbox.ResetText()
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Sql = "insert into Members values ("
        Sql = Sql & memberID_txt.Text & ",'"
        Sql = Sql & firstName_txt.Text & "','"
        Sql = Sql & lastName_txt.Text & "','"
        Sql = Sql & membershipIDTypes_cbbox.Text & "','"
        Sql = Sql & contactNum_txt.Text & "','"
        Sql = Sql & emailAdd_txt.Text & "','"
        Sql = Sql & status_cbbox.Text & "')"
        cmd = New OleDbCommand(Sql, con)
        cmd.ExecuteNonQuery()
        MsgBox("New member detail is added!")
    End Sub

    Private Sub status_cbbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles status_cbbox.SelectedIndexChanged

    End Sub
End Class