Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPriority.Items.Clear()
        cmbPriority.Items.AddRange(New Object() {"Low", "Medium", "High"})

        ResetFormFields()
    End Sub

    Private Sub ResetFormFields()
        btnCategory.Text = "Category"
        btnDescription.Text = "Description"
        btnLocation.Text = "Location"

        If cmbPriority.Items.Count > 0 Then
            cmbPriority.SelectedIndex = 1
        End If

        PictureBox6.Image = Nothing
        btnUpload.Visible = True
        Label6.Visible = True
    End Sub

    Private Sub txtCategory_Enter(sender As Object, e As EventArgs) Handles btnCategory.Enter
        If btnCategory.Text = "Category" Then
            btnCategory.Text = ""
        End If
    End Sub

    Private Sub txtCategory_Leave(sender As Object, e As EventArgs) Handles btnCategory.Leave
        If String.IsNullOrWhiteSpace(btnCategory.Text) Then
            btnCategory.Text = "Category"
        End If
    End Sub

    Private Sub txtDescription_Enter(sender As Object, e As EventArgs) Handles btnDescription.Enter
        If btnDescription.Text = "Description" Then
            btnDescription.Text = ""
        End If
    End Sub

    Private Sub txtDescription_Leave(sender As Object, e As EventArgs) Handles btnDescription.Leave
        If String.IsNullOrWhiteSpace(btnDescription.Text) Then
            btnDescription.Text = "Description"
        End If
    End Sub

    Private Sub txtLocation_Enter(sender As Object, e As EventArgs) Handles btnLocation.Enter
        If btnLocation.Text = "Location" Then
            btnLocation.Text = ""
        End If
    End Sub

    Private Sub txtLocation_Leave(sender As Object, e As EventArgs) Handles btnLocation.Leave
        If String.IsNullOrWhiteSpace(btnLocation.Text) Then
            btnLocation.Text = "Location"
        End If
    End Sub

    Private Sub ReturnToDashboard()
        Form2.StartPosition = FormStartPosition.Manual
        Form2.Location = Me.Location
        Form2.Size = Me.Size
        Form2.WindowState = Me.WindowState
        Form2.RefreshDashboardData()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSubmitReport.Click
        If btnCategory.Text = "Category" OrElse btnDescription.Text = "Description" OrElse btnLocation.Text = "Location" Then
            MessageBox.Show("Please fill out all fields before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "INSERT INTO Reports (Issue, Category, Location, Priority, Description) VALUES (@Issue, @Category, @Location, @Priority, @Description)"

        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Issue", btnCategory.Text)
                cmd.Parameters.AddWithValue("@Category", btnCategory.Text)
                cmd.Parameters.AddWithValue("@Location", btnLocation.Text)
                cmd.Parameters.AddWithValue("@Priority", cmbPriority.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Description", btnDescription.Text)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Report successfully saved to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Database Error: " & ex.Message, "Execution Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End Using
        End Using

        ResetFormFields()
        ReturnToDashboard()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ResetFormFields()
        ReturnToDashboard()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim ofd As New OpenFileDialog
        ofd.Title = "Select an Image"
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog = DialogResult.OK Then
            Dim fileInfo As New FileInfo(ofd.FileName)
            If fileInfo.Length > 5 * 1024 * 1024 Then
                MessageBox.Show("File size exceeds 5MB.")
                Exit Sub
            End If
            PictureBox6.Image = Image.FromFile(ofd.FileName)
            btnUpload.Visible = False
            Label6.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ResetFormFields()
        ReturnToDashboard()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ResetFormFields()
        Form4.StartPosition = FormStartPosition.Manual
        Form4.Location = Me.Location
        Form4.Size = Me.Size
        Form4.WindowState = Me.WindowState
        Form4.RefreshMyReports("")
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ResetFormFields()
        Form5.StartPosition = FormStartPosition.Manual
        Form5.Location = Me.Location
        Form5.Size = Me.Size
        Form5.WindowState = Me.WindowState
        Form5.RefreshAdminPanel("")
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim ofd As New OpenFileDialog
        ofd.Title = "Select an Image"
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog = DialogResult.OK Then
            Dim fileInfo As New FileInfo(ofd.FileName)
            If fileInfo.Length > 5 * 1024 * 1024 Then
                MessageBox.Show("File size exceeds 5MB.")
                Exit Sub
            End If
            PictureBox6.Image = Image.FromFile(ofd.FileName)
            btnUpload.Visible = False
            Label6.Visible = False
        End If
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub

    Private Sub btnDescription_TextChanged(sender As Object, e As EventArgs) Handles btnDescription.TextChanged
    End Sub

End Class