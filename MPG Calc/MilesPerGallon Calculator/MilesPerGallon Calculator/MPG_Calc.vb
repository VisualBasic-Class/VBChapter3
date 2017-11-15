Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decGallons As Decimal
        Dim decMilesOnFull As Decimal
        Dim decMPG As Decimal

        lblMPGDisplay.Text = String.Empty
        Try
            decMPG = CDec(txtGallons.Text) /
                CDec(txtMilesOnFull.Text)
            lblMPGDisplay.Text = decMPG.ToString()
        Catch
            MessageBox.Show("All input must be valid numeric values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGallons.Clear()
        txtMilesOnFull.Clear()
        lblMPGDisplay.Text = String.Empty
    End Sub
End Class
