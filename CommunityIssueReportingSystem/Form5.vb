Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvAdminPanel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        txtSearch.Text = "Search..."
        RefreshAdminPanel("")
    End Sub

    Public Sub RefreshAdminPanel(searchKeyword As String)
        Dim dt As New DataTable()
        Dim query As String = "SELECT ReportID, Issue, Category, Location, Status, Priority, ReportDate, Description FROM Reports"

        If Not String.IsNullOrWhiteSpace(searchKeyword) AndAlso searchKeyword <> "Search..." Then
            query &= " WHERE Issue LIKE @Search OR Category LIKE @Search OR Location LIKE @Search OR Status LIKE @Search"
        End If

        query &= " ORDER BY ReportDate DESC"

        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(query, conn)
                If Not String.IsNullOrWhiteSpace(searchKeyword) AndAlso searchKeyword <> "Search..." Then
                    cmd.Parameters.AddWithValue("@Search", "%" & searchKeyword & "%")
                End If

                Using da As New SqlDataAdapter(cmd)
                    Try
                        da.Fill(dt)
                    Catch ex As Exception
                        MessageBox.Show("Error loading admin records: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                End Using
            End Using
        End Using

        dgvAdminPanel.DataSource = Nothing
        dgvAdminPanel.Columns.Clear()

        dgvAdminPanel.DataSource = dt

        If dgvAdminPanel.Columns.Contains("Status") Then
            Dim textStatusIndex As Integer = dgvAdminPanel.Columns("Status").Index
            dgvAdminPanel.Columns.Remove("Status")

            Dim cmbStatus As New DataGridViewComboBoxColumn()
            cmbStatus.Name = "Status"
            cmbStatus.HeaderText = "Status"
            cmbStatus.DataPropertyName = "Status"
            cmbStatus.Items.AddRange("Pending", "In Progress", "Resolved")
            cmbStatus.FlatStyle = FlatStyle.Flat

            dgvAdminPanel.Columns.Insert(textStatusIndex, cmbStatus)
        End If

        For Each col As DataGridViewColumn In dgvAdminPanel.Columns
            If col.Name <> "Status" Then
                col.ReadOnly = True
            End If
        Next
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text <> "Search..." Then
            RefreshAdminPanel(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        If txtSearch.Text = "Search..." Then
            txtSearch.Text = ""
        End If
    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            txtSearch.Text = "Search..."
            RefreshAdminPanel("")
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvAdminPanel.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a report row to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        dgvAdminPanel.EndEdit()

        Dim reportId As Object = dgvAdminPanel.CurrentRow.Cells("ReportID").Value
        Dim currentStatus As String = dgvAdminPanel.CurrentRow.Cells("Status").Value.ToString().Trim()

        Dim query As String = "UPDATE Reports SET Status = @Status WHERE ReportID = @ReportID"

        Using conn As SqlConnection = GetConnection()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Status", currentStatus)
                cmd.Parameters.AddWithValue("@ReportID", reportId)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Report status successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Failed to save changes: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

        RefreshAdminPanel(txtSearch.Text.Trim())
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvAdminPanel.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a report row to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim confirm = MessageBox.Show("Are you sure you want to permanently delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm <> DialogResult.Yes Then Exit Sub

        Dim reportId = dgvAdminPanel.CurrentRow.Cells("ReportID").Value
        Dim query = "DELETE FROM Reports WHERE ReportID = @ReportID"

        Using conn = GetConnection()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ReportID", reportId)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Record successfully removed from the system.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Failed to delete record: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

        RefreshAdminPanel(txtSearch.Text.Trim())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.StartPosition = FormStartPosition.Manual
        Form2.Location = Me.Location
        Form2.Size = Me.Size
        Form2.WindowState = Me.WindowState
        Form2.RefreshDashboardData()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.StartPosition = FormStartPosition.Manual
        Form3.Location = Me.Location
        Form3.Size = Me.Size
        Form3.WindowState = Me.WindowState
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.StartPosition = FormStartPosition.Manual
        Form4.Location = Me.Location
        Form4.Size = Me.Size
        Form4.WindowState = Me.WindowState
        Form4.RefreshMyReports("")
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Form5_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

End Class