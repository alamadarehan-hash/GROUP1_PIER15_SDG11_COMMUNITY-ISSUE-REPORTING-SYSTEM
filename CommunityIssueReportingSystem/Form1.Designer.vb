<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblHeader = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        lblSubHeader = New Label()
        Label7 = New Label()
        Label8 = New Label()
        lblWelcome = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        lblUsername = New Label()
        pbLogo = New PictureBox()
        pbSKLogo = New PictureBox()
        lblPassword = New Label()
        btnHide = New Button()
        lblLoginToAccount = New Label()
        cboRemember = New CheckBox()
        lblForgotPassword = New LinkLabel()
        ImageList1 = New ImageList(components)
        lblFooter = New Label()
        Label14 = New Label()
        lblBackground = New Label()
        pbEarth = New PictureBox()
        btnLogin = New Button()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbSKLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbEarth, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHeader
        ' 
        lblHeader.AutoSize = True
        lblHeader.BackColor = SystemColors.ControlDarkDark
        lblHeader.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeader.ForeColor = Color.White
        lblHeader.Location = New Point(101, 101)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(325, 248)
        lblHeader.TabIndex = 1
        lblHeader.Text = "COMMUNITY" & vbCrLf & "ISSUE" & vbCrLf & "REPORTING" & vbCrLf & "SYSTEM" & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlDarkDark
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(73, 92)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 41)
        Label3.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlDarkDark
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(73, 133)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 41)
        Label4.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ControlDarkDark
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(73, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 41)
        Label5.TabIndex = 4
        ' 
        ' lblSubHeader
        ' 
        lblSubHeader.AutoSize = True
        lblSubHeader.BackColor = SystemColors.ControlDarkDark
        lblSubHeader.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubHeader.ForeColor = Color.White
        lblSubHeader.Location = New Point(101, 384)
        lblSubHeader.Name = "lblSubHeader"
        lblSubHeader.Size = New Size(258, 124)
        lblSubHeader.TabIndex = 5
        lblSubHeader.Text = "Together, we build a" & vbCrLf & "better and accountable " & vbCrLf & "community" & vbCrLf & vbCrLf
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ControlDarkDark
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(73, 256)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 23)
        Label7.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ControlDarkDark
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(73, 279)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 23)
        Label8.TabIndex = 7
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.Location = New Point(1154, 116)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(363, 62)
        lblWelcome.TabIndex = 8
        lblWelcome.Text = "Welcome Back!"
        ' 
        ' txtUsername
        ' 
        txtUsername.AcceptsReturn = True
        txtUsername.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtUsername.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = SystemColors.WindowFrame
        txtUsername.Location = New Point(1169, 342)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(564, 43)
        txtUsername.TabIndex = 9
        txtUsername.Text = "Enter your Username"
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtPassword.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = SystemColors.WindowFrame
        txtPassword.ImeMode = ImeMode.Off
        txtPassword.Location = New Point(1169, 481)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(564, 43)
        txtPassword.TabIndex = 15
        txtPassword.Text = "Enter Your Password"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(1169, 298)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(117, 31)
        lblUsername.TabIndex = 16
        lblUsername.Text = "Username"
        ' 
        ' pbLogo
        ' 
        pbLogo.BackColor = SystemColors.ControlDarkDark
        pbLogo.BackgroundImageLayout = ImageLayout.None
        pbLogo.BorderStyle = BorderStyle.FixedSingle
        pbLogo.ErrorImage = Nothing
        pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), Image)
        pbLogo.Location = New Point(254, 593)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(200, 171)
        pbLogo.SizeMode = PictureBoxSizeMode.Zoom
        pbLogo.TabIndex = 18
        pbLogo.TabStop = False
        ' 
        ' pbSKLogo
        ' 
        pbSKLogo.BackColor = SystemColors.ControlDarkDark
        pbSKLogo.BackgroundImageLayout = ImageLayout.None
        pbSKLogo.BorderStyle = BorderStyle.FixedSingle
        pbSKLogo.ErrorImage = Nothing
        pbSKLogo.Image = CType(resources.GetObject("pbSKLogo.Image"), Image)
        pbSKLogo.Location = New Point(449, 593)
        pbSKLogo.Name = "pbSKLogo"
        pbSKLogo.Size = New Size(200, 171)
        pbSKLogo.SizeMode = PictureBoxSizeMode.Zoom
        pbSKLogo.TabIndex = 19
        pbSKLogo.TabStop = False
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(1169, 447)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(110, 31)
        lblPassword.TabIndex = 20
        lblPassword.Text = "Password"
        ' 
        ' btnHide
        ' 
        btnHide.BackColor = Color.White
        btnHide.BackgroundImage = My.Resources.Resources.eye
        btnHide.BackgroundImageLayout = ImageLayout.Zoom
        btnHide.FlatStyle = FlatStyle.Popup
        btnHide.ForeColor = SystemColors.Window
        btnHide.Location = New Point(1685, 493)
        btnHide.Name = "btnHide"
        btnHide.Size = New Size(39, 30)
        btnHide.TabIndex = 23
        btnHide.UseVisualStyleBackColor = False
        ' 
        ' lblLoginToAccount
        ' 
        lblLoginToAccount.AutoSize = True
        lblLoginToAccount.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLoginToAccount.ForeColor = SystemColors.ControlDarkDark
        lblLoginToAccount.Location = New Point(1169, 193)
        lblLoginToAccount.Name = "lblLoginToAccount"
        lblLoginToAccount.Size = New Size(307, 31)
        lblLoginToAccount.TabIndex = 24
        lblLoginToAccount.Text = "Please Login to your account"
        ' 
        ' cboRemember
        ' 
        cboRemember.AutoSize = True
        cboRemember.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboRemember.Location = New Point(1169, 586)
        cboRemember.Name = "cboRemember"
        cboRemember.Size = New Size(185, 35)
        cboRemember.TabIndex = 27
        cboRemember.Text = "Remember me"
        cboRemember.UseVisualStyleBackColor = True
        ' 
        ' lblForgotPassword
        ' 
        lblForgotPassword.AutoSize = True
        lblForgotPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblForgotPassword.Location = New Point(1491, 593)
        lblForgotPassword.Name = "lblForgotPassword"
        lblForgotPassword.Size = New Size(156, 28)
        lblForgotPassword.TabIndex = 28
        lblForgotPassword.TabStop = True
        lblForgotPassword.Text = "Forget Password"
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' lblFooter
        ' 
        lblFooter.AutoSize = True
        lblFooter.BackColor = SystemColors.ControlDarkDark
        lblFooter.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFooter.ForeColor = SystemColors.Window
        lblFooter.Location = New Point(168, 831)
        lblFooter.Name = "lblFooter"
        lblFooter.Size = New Size(191, 56)
        lblFooter.TabIndex = 30
        lblFooter.Text = "SUSTAINABLE CITIES" & vbCrLf & "AND COMMUNITIES"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = SystemColors.ControlDarkDark
        Label14.ForeColor = SystemColors.Window
        Label14.Location = New Point(37, 683)
        Label14.Name = "Label14"
        Label14.Size = New Size(0, 20)
        Label14.TabIndex = 31
        ' 
        ' lblBackground
        ' 
        lblBackground.BackColor = SystemColors.ControlDarkDark
        lblBackground.ForeColor = SystemColors.ControlText
        lblBackground.Location = New Point(-1, -9)
        lblBackground.Name = "lblBackground"
        lblBackground.Size = New Size(927, 1056)
        lblBackground.TabIndex = 0
        ' 
        ' pbEarth
        ' 
        pbEarth.BackColor = SystemColors.ButtonShadow
        pbEarth.BackgroundImageLayout = ImageLayout.Zoom
        pbEarth.BorderStyle = BorderStyle.FixedSingle
        pbEarth.Image = CType(resources.GetObject("pbEarth.Image"), Image)
        pbEarth.Location = New Point(101, 825)
        pbEarth.Name = "pbEarth"
        pbEarth.Size = New Size(61, 62)
        pbEarth.SizeMode = PictureBoxSizeMode.Zoom
        pbEarth.TabIndex = 32
        pbEarth.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.MenuHighlight
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = SystemColors.Window
        btnLogin.Location = New Point(1169, 683)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(478, 83)
        btnLogin.TabIndex = 33
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1902, 1033)
        Controls.Add(btnLogin)
        Controls.Add(pbEarth)
        Controls.Add(Label14)
        Controls.Add(lblFooter)
        Controls.Add(lblForgotPassword)
        Controls.Add(cboRemember)
        Controls.Add(lblLoginToAccount)
        Controls.Add(btnHide)
        Controls.Add(lblPassword)
        Controls.Add(pbSKLogo)
        Controls.Add(pbLogo)
        Controls.Add(lblUsername)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblWelcome)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(lblSubHeader)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(lblHeader)
        Controls.Add(lblBackground)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Form1"
        Text = "Register"
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(pbSKLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(pbEarth, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblHeader As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSubHeader As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents pbSKLogo As PictureBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnHide As Button
    Friend WithEvents lblLoginToAccount As Label
    Friend WithEvents cboRemember As CheckBox
    Friend WithEvents lblForgotPassword As LinkLabel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lblFooter As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblBackground As Label
    Friend WithEvents pbEarth As PictureBox
    Friend WithEvents btnLogin As Button

End Class
