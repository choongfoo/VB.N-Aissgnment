Public Class PaymentReport

    Private Sub PaymentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.Payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.DataSet.Payment)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        Dim search As String = ToolStripTextBox1.Text


        PaymentTableAdapter.FillByPaymentID(DataSet.Payment, search)
        Me.ReportViewer1.RefreshReport()
        If ToolStripTextBox1.Text = "" Then
            Me.PaymentTableAdapter.Fill(Me.DataSet.Payment)

            Me.ReportViewer1.RefreshReport()
        End If
    End Sub
End Class