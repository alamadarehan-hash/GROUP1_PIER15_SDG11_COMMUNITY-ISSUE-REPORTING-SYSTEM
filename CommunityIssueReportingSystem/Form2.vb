Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvRecentReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecentReports.ReadOnly = True
        RefreshDashboardData()
    End Sub

    Public Sub RefreshDashboardData()
        Dim dt As New DataTable()
        Dim query As String = "SELECT ReportID, Issue, Location, Status, Priority, ReportDate FROM Reports ORDER BY ReportDate DESC"

        Using conn As SqlConnection = GetConnection()
            Using da As New SqlDataAdapter(query, conn)
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    MessageBox.Show("Error loading dashboard data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            End Using
        End Using

        dgvRecentReports.DataSource = dt

        Dim totalReports As Integer = dt.Rows.Count
        Dim totalPending As Integer = 0
        Dim totalInProgress As Integer = 0
        Dim totalResolved As Integer = 0
        Dim recentActivitiesCount As Integer = 0

        For Each row As DataRow In dt.Rows
            Dim status As String = row("Status").ToString()
            If status = "Pending" Then totalPending += 1
            If status = "In Progress" Then totalInProgress += 1
            If status = "Resolved" Then totalResolved += 1

            If status = "In Progress" OrElse status = "Resolved" Then
                recentActivitiesCount += 1
            End If
        Next

        lblTotalReports.Text = totalReports.ToString()
        lblPendings.Text = totalPending.ToString()
        lblinProgress.Text = totalInProgress.ToString()
        lblResolved.Text = totalResolved.ToString()
        lblRecentActivities.Text = recentActivitiesCount.ToString()

        stChart.Series.Clear()
        Dim mainSeries = stChart.Series.Add("Report Status")
        mainSeries.ChartType = DataVisualization.Charting.SeriesChartType.Pie

        If totalPending > 0 Then mainSeries.Points.AddXY("Pending", totalPending)
        If totalInProgress > 0 Then mainSeries.Points.AddXY("In Progress", totalInProgress)
        If totalResolved > 0 Then mainSeries.Points.AddXY("Resolved", totalResolved)
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form5.StartPosition = FormStartPosition.Manual
        Form5.Location = Me.Location
        Form5.Size = Me.Size
        Form5.WindowState = Me.WindowState
        Form5.RefreshAdminPanel("")
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub FlowLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles Statistic.Paint
    End Sub

    Private Sub StatisticChart_Click(sender As Object, e As EventArgs) Handles stChart.Click
    End Sub

End Class