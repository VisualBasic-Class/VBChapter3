Public Class AvgScoreCalc
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtScore1.Clear()
        txtScore2.Clear()
        txtScore3.Clear()
        txtScore4.Clear()
        txtScore5.Clear()
        lblAvgDisplay.Text = String.Empty
    End Sub

    Private Sub btnCalcAverage_Click(sender As Object, e As EventArgs) Handles btnCalcAverage.Click
        Dim decScore1 As Decimal
        Dim decScore2 As Decimal
        Dim decScore3 As Decimal
        Dim decScore4 As Decimal
        Dim decScore5 As Decimal
        Dim decAverage As Decimal

        ' This gives the variables above the correct values.
        decScore1 = CDec(txtScore1.Text)
        decScore2 = CDec(txtScore2.Text)
        decScore3 = CDec(txtScore3.Text)
        decScore4 = CDec(txtScore4.Text)
        decScore5 = CDec(txtScore5.Text)

        ' This deals with the actual performing of the function and puts the answer into lblAvgDisplay.
        decAverage = (decScore1 + decScore2 + decScore3 + decScore4 + decScore5) / 5
        lblAvgDisplay.Text = decAverage
    End Sub
End Class
