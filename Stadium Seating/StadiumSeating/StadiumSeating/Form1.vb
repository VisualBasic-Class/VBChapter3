Public Class Form_StadiumSeating

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblClassA As Double
        Dim dblClassB As Double
        Dim dblClassC As Double
        Dim dblTotalRevenue As Double

        Try
            ' Calculate the Class A revenue.
            dblClassA = CDbl(txtClassA.Text) *
                15
            lblARevenue.Text = dblClassA.ToString("c")

            ' Calculate the Class B revenue.
            dblClassB = CDbl(txtClassB.Text) *
                12
            lblBRevenue.Text = dblClassB.ToString("c")

            ' Calculate the Class C revenue.
            dblClassC = CDbl(txtClassC.Text) *
                9
            lblCRevenue.Text = dblClassC.ToString("c")

            'Calculate the total revenue from each class and in general.
            dblTotalRevenue = CDbl(txtClassA.Text) *
                (txtClassB.Text) *
                (txtClassC.Text)
            lblTotalRevenue.Text = dblTotalRevenue.ToString("c")
        Catch
            ' Error message:
            lblStatus.Text = "Error: Can't calculate. Please check all input and make sure they are valid numeric values."
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear all text boxes.
        txtClassA.Clear()
        txtClassB.Clear()
        txtClassC.Clear()

        ' Clear all labels and strings.
        lblARevenue.Text = String.Empty
        lblBRevenue.Text = String.Empty
        lblCRevenue.Text = String.Empty
        lblTotalRevenue.Text = String.Empty

        ' Reset the focus to the first field.
        txtClassA.Focus()
    End Sub
End Class
