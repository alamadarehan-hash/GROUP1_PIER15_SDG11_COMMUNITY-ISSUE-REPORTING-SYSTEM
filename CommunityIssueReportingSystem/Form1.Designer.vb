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
        lblHeader.Location = New Point(164, 162)
        lblHeader.Margin = New Padding(5, 0, 5, 0)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(525, 404)
        lblHeader.TabIndex = 1
        lblHeader.Text = "COMMUNITY" & vbCrLf & "ISSUE" & vbCrLf & "REPORTING" & vbCrLf & "SYSTEM" & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlDarkDark
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(119, 147)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 65)
        Label3.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlDarkDark
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(119, 213)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 65)
        Label4.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ControlDarkDark
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(119, 278)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 65)
        Label5.TabIndex = 4
        ' 
        ' lblSubHeader
        ' 
        lblSubHeader.AutoSize = True
        lblSubHeader.BackColor = SystemColors.ControlDarkDark
        lblSubHeader.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubHeader.ForeColor = Color.White
        lblSubHeader.Location = New Point(164, 614)
        lblSubHeader.Margin = New Padding(5, 0, 5, 0)
        lblSubHeader.Name = "lblSubHeader"
        lblSubHeader.Size = New Size(412, 200)
        lblSubHeader.TabIndex = 5
        lblSubHeader.Text = "Together, we build a" & vbCrLf & "better and accountable " & vbCrLf & "community" & vbCrLf & vbCrLf
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ControlDarkDark
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(119, 410)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 38)
        Label7.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ControlDarkDark
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(119, 446)
        Label8.Margin = New Padding(5, 0, 5, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 38)
        Label8.TabIndex = 7
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.Location = New Point(1875, 186)
        lblWelcome.Margin = New Padding(5, 0, 5, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(587, 101)
        lblWelcome.TabIndex = 8
        lblWelcome.Text = "Welcome Back!"
        ' 
        ' txtUsername
        ' 
        txtUsername.AcceptsReturn = True
        txtUsername.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtUsername.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = SystemColors.WindowFrame
        txtUsername.Location = New Point(1900, 547)
        txtUsername.Margin = New Padding(5, 5, 5, 5)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(740, 65)
        txtUsername.TabIndex = 9
        txtUsername.Text = "Enter your Username"
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtPassword.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = SystemColors.WindowFrame
        txtPassword.ImeMode = ImeMode.Off
        txtPassword.Location = New Point(1900, 770)
        txtPassword.Margin = New Padding(5, 5, 5, 5)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(740, 65)
        txtPassword.TabIndex = 15
        txtPassword.Text = "Enter Your Password"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(1900, 477)
        lblUsername.Margin = New Padding(5, 0, 5, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(186, 50)
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
        pbLogo.Location = New Point(413, 949)
        pbLogo.Margin = New Padding(5, 5, 5, 5)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(324, 272)
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
        pbSKLogo.Location = New Point(730, 949)
        pbSKLogo.Margin = New Padding(5, 5, 5, 5)
        pbSKLogo.Name = "pbSKLogo"
        pbSKLogo.Size = New Size(324, 272)
        pbSKLogo.SizeMode = PictureBoxSizeMode.Zoom
        pbSKLogo.TabIndex = 19
        pbSKLogo.TabStop = False
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(1900, 715)
        lblPassword.Margin = New Padding(5, 0, 5, 0)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(177, 50)
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
        btnHide.Location = New Point(2595, 781)
        btnHide.Margin = New Padding(5, 5, 5, 5)
        btnHide.Name = "btnHide"
        btnHide.Size = New Size(63, 48)
        btnHide.TabIndex = 23
        btnHide.UseVisualStyleBackColor = False
        ' 
        ' lblLoginToAccount
        ' 
        lblLoginToAccount.AutoSize = True
        lblLoginToAccount.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLoginToAccount.ForeColor = SystemColors.ControlDarkDark
        lblLoginToAccount.Location = New Point(1900, 309)
        lblLoginToAccount.Margin = New Padding(5, 0, 5, 0)
        lblLoginToAccount.Name = "lblLoginToAccount"
        lblLoginToAccount.Size = New Size(495, 50)
        lblLoginToAccount.TabIndex = 24
        lblLoginToAccount.Text = "Please Login to your account"
        ' 
        ' cboRemember
        ' 
        cboRemember.AutoSize = True
        cboRemember.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboRemember.Location = New Point(1900, 938)
        cboRemember.Margin = New Padding(5, 5, 5, 5)
        cboRemember.Name = "cboRemember"
        cboRemember.Size = New Size(292, 54)
        cboRemember.TabIndex = 27
        cboRemember.Text = "Remember me"
        cboRemember.UseVisualStyleBackColor = True
        ' 
        ' lblForgotPassword
        ' 
        lblForgotPassword.AutoSize = True
        lblForgotPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblForgotPassword.Location = New Point(2423, 949)
        lblForgotPassword.Margin = New Padding(5, 0, 5, 0)
        lblForgotPassword.Name = "lblForgotPassword"
        lblForgotPassword.Size = New Size(255, 45)
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
        lblFooter.Location = New Point(273, 1330)
        lblFooter.Margin = New Padding(5, 0, 5, 0)
        lblFooter.Name = "lblFooter"
        lblFooter.Size = New Size(312, 90)
        lblFooter.TabIndex = 30
        lblFooter.Text = "SUSTAINABLE CITIES" & vbCrLf & "AND COMMUNITIES"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = SystemColors.ControlDarkDark
        Label14.ForeColor = SystemColors.Window
        Label14.Location = New Point(60, 1093)
        Label14.Margin = New Padding(5, 0, 5, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(0, 32)
        Label14.TabIndex = 31
        ' 
        ' lblBackground
        ' 
        lblBackground.BackColor = SystemColors.ControlDarkDark
        lblBackground.ForeColor = SystemColors.ControlText
        lblBackground.Location = New Point(-2, -14)
        lblBackground.Margin = New Padding(5, 0, 5, 0)
        lblBackground.Name = "lblBackground"
        lblBackground.Size = New Size(1506, 1690)
        lblBackground.TabIndex = 0
        ' 
        ' pbEarth
        ' 
        pbEarth.BackColor = SystemColors.ButtonShadow
        pbEarth.BackgroundImageLayout = ImageLayout.Zoom
        pbEarth.BorderStyle = BorderStyle.FixedSingle
        pbEarth.Image = CType(resources.GetObject("pbEarth.Image"), Image)
        pbEarth.Location = New Point(164, 1320)
        pbEarth.Margin = New Padding(5, 5, 5, 5)
        pbEarth.Name = "pbEarth"
        pbEarth.Size = New Size(98, 98)
        pbEarth.SizeMode = PictureBoxSizeMode.Zoom
        pbEarth.TabIndex = 32
        pbEarth.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.MenuHighlight
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = SystemColors.Window
        btnLogin.Location = New Point(1900, 1093)
        btnLogin.Margin = New Padding(5, 5, 5, 5)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(777, 133)
        btnLogin.TabIndex = 33
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(2880, 1653)
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
        Margin = New Padding(5, 5, 5, 5)
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
