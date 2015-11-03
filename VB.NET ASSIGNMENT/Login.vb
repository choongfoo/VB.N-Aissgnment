Imports System.Data.OleDb
Public Class Login
    Dim ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & Application.StartupPath & "\Membership.accdb"
    Dim con As New OleDbConnection(ConString)
    Dim da As OleDbDataAdapter
    Dim ds1, ds2, ds3 As New DataSet
    Dim totalRec As Integer
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'To access the staff detail
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
        'Verify the username and password with the existing staff detail
        Dim Sql As String = "select * from Credentials where Username='" & username_cbbox.Text & "'"
        Dim da As New OleDbDataAdapter(Sql, con)

        Dim staffrole As String
        Dim loginstaff As String

        da.Fill(ds2, "UserPassword") 'Call user password
        da.Fill(ds3, "StaffName") 'Call user ID

        'If the user not fill in all the column
        If password_txt.Text = "" Or username_cbbox.Text = "" Then
            MsgBox("Please fill in all the column.")
            Exit Sub
        End If

        If password_txt.Text = ds2.Tables("UserPassword").Rows(0).Item(1).ToString Then
            MsgBox("Welcome " & username_cbbox.Text & "!!")

            loginstaff = ds3.Tables("StaffName").Rows(0).Item(0).ToString
            staffrole = ds3.Tables("StaffName").Rows(0).Item(2).ToString

            Main.nameID.Text = loginstaff
            Main.Role.Text = staffrole
            PInfo.loggedBy_lbl.Text = loginstaff

            Me.Hide()
            Main.Show()
            username_cbbox.Text = ""
            password_txt.Text = ""

        Else
            MsgBox("Password incorrect.")
            password_txt.Text = ""
        End If
    End Sub

    Private Sub quit_btn_Click(sender As Object, e As EventArgs) Handles quit_btn.Click
        'Quit system
        Dim y As String
        y = MsgBox("Quit comfirmation.", MsgBoxStyle.YesNo)
        If y = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub password_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles password_txt.KeyPress
        'Press "Enter" to perform login button 
        If (Asc(e.KeyChar) = 13) Then
            login_btn.PerformClick()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Show current date and time
        currentDate_lbl.Text = Date.Now.ToString("dd-MM-yyyy")
        currentTime_lbl.Text = TimeOfDay
    End Sub
End Class
