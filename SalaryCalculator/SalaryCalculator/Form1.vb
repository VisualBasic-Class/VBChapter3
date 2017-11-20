Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
    Dim decAnnualSalary As Decimal
    Dim intPayPeriods As Integer
    Dim decSalary As Decimal
    lblStatus.Text = String.Empty

    Try
        ' Get the annual salary and number of pay periods.
        decAnnualSalary = CDec(txtAnnualSalary.Text)
        intPayPeriods = CInt(txtPayPeriods.Text)

        ' Calculate the salary per pay period.
        decSalary = decAnnualSalary / intPayPeriods

        ' Display the salary per pay period.
        lblSalary.Text = decSalary.ToString("c")
    Catch
        ' Display an error message.
        lblStatus.Text = "Error: Be sure to enter nonzero numeric values."
    End Try
End Sub