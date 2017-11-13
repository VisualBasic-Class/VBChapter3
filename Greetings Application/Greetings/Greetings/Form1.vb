Public Class Form1

    Private Sub lblGreeting_Click(sender As Object, e As EventArgs) Handles lblGreeting.Click
        Dim strName As String

        strName = txtUserName.Text

        lblGreeting.Text = strName
    End Sub

    Private Sub btnShowGreeting_Click(sender As Object, e As EventArgs) Handles btnShowGreeting.Click
        Dim strName As String

        strName = txtUserName.Text

        lblGreeting.Text = "Hi, " + strName + "!"

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged

    End Sub

    Private Sub lblEnterName_Click(sender As Object, e As EventArgs) Handles lblEnterName.Click

    End Sub
End Class
