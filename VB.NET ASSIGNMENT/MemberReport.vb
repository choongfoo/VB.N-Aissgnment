Public Class MemberReport

    Private Sub MemberReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.DataSet.Members)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub SpecificToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub FdfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem.Click

    End Sub
    Private Sub ToolStripMenuItem_TextChanged(sender As Object, e As EventArgs) Handles ToolStripMenuItem.TextChanged
        Dim search As String = ToolStripMenuItem.Text


        MembersTableAdapter.FillByMemberID(DataSet.Members, search, search, search)
        Me.ReportViewer1.RefreshReport()
        If ToolStripMenuItem.Text = "" Then
            Me.MembersTableAdapter.Fill(Me.DataSet.Members)

            Me.ReportViewer1.RefreshReport()
        End If
    End Sub
End Class