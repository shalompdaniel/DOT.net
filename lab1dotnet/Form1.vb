Public Class Form1

    ' Login button → show message → open Form2
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        MessageBox.Show("Login Successful")

        Dim f As New Form2()
        f.Show()
    End Sub

    ' Optional: Show/Hide Password
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    ' Optional: Links (no error, just placeholders)
    Private Sub LinkForgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkForgot.LinkClicked
        MessageBox.Show("Password recovery is not implemented.")
    End Sub

    Private Sub LinkCreateAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkCreateAccount.LinkClicked
        MessageBox.Show("Account creation is not implemented.")
    End Sub

End Class
