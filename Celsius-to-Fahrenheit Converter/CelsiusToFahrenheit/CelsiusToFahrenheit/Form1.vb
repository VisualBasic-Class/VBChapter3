Public Class CelsiusToFahrenheit

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decConversion As Decimal

        ' This will perform the conversion.
        Try
            decConversion = 1.8 *
                CDec(txtCelsius.Text) +
                32

            lblCToF.Text = decConversion.ToString("N1") + ("°F")

        Catch ex As Exception
            ' Display the default error message.

            lblStatus.Text = ex.Message
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtCelsius.Clear()
        lblCToF.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
