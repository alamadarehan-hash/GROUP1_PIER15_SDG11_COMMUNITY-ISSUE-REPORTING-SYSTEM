Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvMyReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMyReports.ReadOnly = True
        txtSearch.Text = "Search..."
        RefreshMyReports("")
    End Sub

    Public Sub RefreshMyReports(searchKeyword As String)
        Dim dt As New DataTable()
        Dim query As String = "SELECT ReportID, Issue, Category, Location, Status, Priority, ReportDate FROM Reports"

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
                        MessageBox.Show("Error loading reports data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End Try
                End Using
            End Using
        End Using

        dgvMyReports.DataSource = dt
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text <> "Search..." Then
            RefreshMyReports(txtSearch.Text.Trim())
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
            RefreshMyReports("")
        End If
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form5.StartPosition = FormStartPosition.Manual
        Form5.Location = Me.Location
        Form5.Size = Me.Size
        Form5.WindowState = Me.WindowState
        Form5.RefreshAdminPanel("")
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Form4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

End Class