Public Class formDateString

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtboxDayOfWeek.TextChanged

    End Sub

    Private Sub btnExitApp_Click(sender As Object, e As EventArgs) Handles btnExitApp.Click
        Me.Close()
    End Sub

    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click

        ' This will concatenate the input and build the date string.
        lblDateString.Text = txtboxDayOfWeek.Text & ", " &
            txtboxMonth.Text & " " &
            txtboxDayOfMonth.Text & ", " &
            txtboxYear.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' This will clear the text boxes and lblDateString.
        txtboxDayOfWeek.Clear()
        txtboxMonth.Clear()
        txtboxDayOfMonth.Clear()
        txtboxYear.Clear()
        lblDateString.Text = String.Empty
    End Sub
End Class
