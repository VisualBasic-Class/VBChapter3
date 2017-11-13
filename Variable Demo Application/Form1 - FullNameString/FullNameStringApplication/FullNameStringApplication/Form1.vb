Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShowName.Click
        ' This declare's a string variable to hold the full name...
        Dim strFullName As String

        ' ...this combine;s the first and last names and assign the
        ' result to strFullName...
        strFullName = txtFirstName.Text & " " & txtLastName.Text

        ' ...and this display's the full name in the lblFullName label.
        lblFullNameString.Text = strFullName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This clears TextBox controls and the Label...
        txtFirstName.Clear()
        txtLastName.Clear()
        lblFullNameString.Text = String.Empty

        ' ... and this set's focus to txtFirstName.
        txtFirstName.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExitApp.Click
        Me.Close()
    End Sub
End Class
