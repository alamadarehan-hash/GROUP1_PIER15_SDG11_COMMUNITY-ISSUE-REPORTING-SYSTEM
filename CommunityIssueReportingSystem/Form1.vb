Imports System.Drawing.Drawing2D

Public Class Form1

    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = "Username"
        txtPassword.Text = "Password"
        txtPassword.PasswordChar = ControlChars.NullChar

        Me.ActiveControl = Nothing
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
        End If
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            txtUsername.Text = "Username"
        End If
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "*"c
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            txtPassword.Text = "Password"
            txtPassword.PasswordChar = ControlChars.NullChar
        End If
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        If txtPassword.Text <> "Password" Then
            If txtPassword.PasswordChar = "*"c Then
                txtPassword.PasswordChar = ControlChars.NullChar
            Else
                txtPassword.PasswordChar = "*"c
            End If
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text

        If username = "Username" OrElse password = "Password" OrElse String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If AuthenticateUser(username, password) Then
            Form2.StartPosition = FormStartPosition.Manual
            Form2.Location = Me.Location
            Form2.Size = Me.Size
            Form2.WindowState = Me.WindowState

            Form2.RefreshDashboardData()
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtPassword.Text = "Password"
            txtPassword.PasswordChar = ControlChars.NullChar
            txtPassword.Focus()
        End If
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Return (username = "admin" AndAlso password = "password123")
    End Function

    Private Sub lblForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblForgotPassword.LinkClicked
        Dim username As String = txtUsername.Text.Trim()

        If String.IsNullOrEmpty(username) OrElse username = "Username" Then
            MessageBox.Show("Please enter your username first to recover your password.", "Username Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Exit Sub
        End If

        If username = "admin" Then
            MessageBox.Show("Your password is: password123", "Password Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Username not found in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
    End Sub

End Class