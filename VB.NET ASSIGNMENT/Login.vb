Imports System.Data.OleDb
Public Class Login
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ChoongFoo\Documents\APU\Semester 4\VBN Assignment\Membership.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da As OleDbDataAdapter
    Dim ds1, ds2 As New DataSet
    Dim totalRec As Integer
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim Sql As String = "select * from Credentials"
        Dim da As New OleDbDataAdapter(Sql, con)
        da.Fill(ds1, "staffLogin")
        totalRec = ds1.Tables("staffLogin").Rows.Count - 1
        username_cbbox.Items.Clear()
        For i = 0 To totalRec
            username_cbbox.Items.Add(ds1.Tables("stafflogin").Rows(i).Item(0))
        Next
    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim Sql As String = "select * from Credentials where Username='" & username_cbbox.Text & "'"
        Dim da As New OleDbDataAdapter(Sql, con)
        da.Fill(ds2, "UserPassword")
        If password_txt.Text = ds2.Tables("UserPassword").Rows(0).Item(1).ToString Then
            MsgBox("Valid User")
            Main.Show()
        Else
            MsgBox("Invalid User")
        End If
    End Sub

    Private Sub quit_btn_Click(sender As Object, e As EventArgs) Handles quit_btn.Click
        Me.Close()
    End Sub

    Private Sub password_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password_txt.KeyPress
        If (Asc(e.KeyChar) = 13) Then
            login_btn.PerformClick()
        End If
    End Sub

    Private Sub password_txt_TextChanged(sender As Object, e As EventArgs) Handles password_txt.TextChanged

    End Sub
End Class
