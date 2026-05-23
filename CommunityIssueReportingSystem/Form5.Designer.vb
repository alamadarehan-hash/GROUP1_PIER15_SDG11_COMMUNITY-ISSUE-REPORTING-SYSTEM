<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Panel1 = New Panel()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label13 = New Label()
        PictureBox3 = New PictureBox()
        Button5 = New Button()
        txtSearch = New TextBox()
        dgvAdminPanel = New DataGridView()
        btnUpdate = New Button()
        btnDelete = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAdminPanel, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DimGray
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(292, 1040)
        Panel1.TabIndex = 3
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Blue
        PictureBox5.BackgroundImageLayout = ImageLayout.None
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(56, 341)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(32, 32)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 41
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.DimGray
        PictureBox4.BackgroundImageLayout = ImageLayout.None
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(56, 274)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(32, 32)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 40
        PictureBox4.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.DimGray
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(56, 209)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(32, 32)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 39
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.DimGray
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(56, 144)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(32, 32)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Blue
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button4.ForeColor = Color.GhostWhite
        Button4.Location = New Point(3, 326)
        Button4.Name = "Button4"
        Button4.Size = New Size(288, 59)
        Button4.TabIndex = 38
        Button4.Text = "Admin"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DimGray
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button3.ForeColor = Color.GhostWhite
        Button3.Location = New Point(3, 261)
        Button3.Name = "Button3"
        Button3.Size = New Size(288, 59)
        Button3.TabIndex = 37
        Button3.Text = "View Reports"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DimGray
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button2.ForeColor = Color.GhostWhite
        Button2.Location = New Point(3, 196)
        Button2.Name = "Button2"
        Button2.Size = New Size(288, 59)
        Button2.TabIndex = 36
        Button2.Text = "Submit Report"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DimGray
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.GhostWhite
        Button1.Location = New Point(-7, 131)
        Button1.Name = "Button1"
        Button1.Size = New Size(306, 59)
        Button1.TabIndex = 35
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = SystemColors.ControlDarkDark
        Label13.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = SystemColors.Window
        Label13.Location = New Point(79, 29)
        Label13.Name = "Label13"
        Label13.Size = New Size(166, 56)
        Label13.TabIndex = 34
        Label13.Text = "Community Issue" & vbCrLf & "Reporting System"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ButtonShadow
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(12, 26)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(61, 62)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 33
        PictureBox3.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Navy
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Location = New Point(292, 1)
        Button5.Name = "Button5"
        Button5.Size = New Size(1614, 74)
        Button5.TabIndex = 4
        Button5.Text = "Admin Panel"
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.None
        txtSearch.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = Color.DimGray
        txtSearch.Location = New Point(322, 155)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(1531, 36)
        txtSearch.TabIndex = 6
        txtSearch.Text = "Search..."
        ' 
        ' dgvAdminPanel
        ' 
        dgvAdminPanel.AllowUserToAddRows = False
        dgvAdminPanel.AllowUserToDeleteRows = False
        dgvAdminPanel.AllowUserToOrderColumns = True
        dgvAdminPanel.AllowUserToResizeColumns = False
        dgvAdminPanel.AllowUserToResizeRows = False
        dgvAdminPanel.BorderStyle = BorderStyle.None
        dgvAdminPanel.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvAdminPanel.ColumnHeadersHeight = 40
        dgvAdminPanel.EnableHeadersVisualStyles = False
        dgvAdminPanel.Location = New Point(322, 203)
        dgvAdminPanel.Name = "dgvAdminPanel"
        dgvAdminPanel.RowHeadersVisible = False
        dgvAdminPanel.RowHeadersWidth = 51
        dgvAdminPanel.Size = New Size(1531, 708)
        dgvAdminPanel.TabIndex = 8
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.DarkGray
        btnUpdate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(366, 944)
        btnUpdate.Margin = New Padding(2)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(169, 66)
        btnUpdate.TabIndex = 9
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.IndianRed
        btnDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(561, 944)
        btnDelete.Margin = New Padding(2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(169, 66)
        btnDelete.TabIndex = 10
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1906, 1037)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(dgvAdminPanel)
        Controls.Add(txtSearch)
        Controls.Add(Button5)
        Controls.Add(Panel1)
        Name = "Form5"
        Text = "Form5"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvAdminPanel, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dgvAdminPanel As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
End Class
