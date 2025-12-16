<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PanelMain = New Panel()
        PictureLogo = New PictureBox()
        LabelSubtitle = New Label()
        chkShowPassword = New CheckBox()
        chkRemember = New CheckBox()
        Divider = New Label()
        LinkCreateAccount = New LinkLabel()
        LinkForgot = New LinkLabel()
        btnLogin = New Button()
        txtPassword = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        LabelPassword = New Label()
        LabelEmail = New Label()
        LabelName = New Label()
        LabelTitle = New Label()
        PanelMain.SuspendLayout()
        CType(PictureLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelMain
        ' 
        PanelMain.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        PanelMain.BorderStyle = BorderStyle.FixedSingle
        PanelMain.Controls.Add(PictureLogo)
        PanelMain.Controls.Add(LabelSubtitle)
        PanelMain.Controls.Add(chkShowPassword)
        PanelMain.Controls.Add(chkRemember)
        PanelMain.Controls.Add(Divider)
        PanelMain.Controls.Add(LinkCreateAccount)
        PanelMain.Controls.Add(LinkForgot)
        PanelMain.Controls.Add(btnLogin)
        PanelMain.Controls.Add(txtPassword)
        PanelMain.Controls.Add(txtEmail)
        PanelMain.Controls.Add(txtName)
        PanelMain.Controls.Add(LabelPassword)
        PanelMain.Controls.Add(LabelEmail)
        PanelMain.Controls.Add(LabelName)
        PanelMain.Controls.Add(LabelTitle)
        PanelMain.Location = New Point(302, 12)
        PanelMain.Name = "PanelMain"
        PanelMain.Padding = New Padding(25)
        PanelMain.Size = New Size(480, 597)
        PanelMain.TabIndex = 0
        ' 
        ' PictureLogo
        ' 
        PictureLogo.BackgroundImage = CType(resources.GetObject("PictureLogo.BackgroundImage"), Image)
        PictureLogo.BackgroundImageLayout = ImageLayout.Stretch
        PictureLogo.Location = New Point(174, 12)
        PictureLogo.Name = "PictureLogo"
        PictureLogo.Size = New Size(114, 99)
        PictureLogo.SizeMode = PictureBoxSizeMode.Zoom
        PictureLogo.TabIndex = 0
        PictureLogo.TabStop = False
        ' 
        ' LabelSubtitle
        ' 
        LabelSubtitle.Font = New Font("Segoe UI", 11F, FontStyle.Italic)
        LabelSubtitle.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(180))
        LabelSubtitle.Location = New Point(25, 175)
        LabelSubtitle.Name = "LabelSubtitle"
        LabelSubtitle.Size = New Size(430, 30)
        LabelSubtitle.TabIndex = 1
        LabelSubtitle.Text = "Artist Login Portal"
        LabelSubtitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Font = New Font("Segoe UI", 10F)
        chkShowPassword.ForeColor = Color.Gainsboro
        chkShowPassword.Location = New Point(177, 455)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(148, 27)
        chkShowPassword.TabIndex = 2
        chkShowPassword.Text = "Show Password"
        ' 
        ' chkRemember
        ' 
        chkRemember.AutoSize = True
        chkRemember.Font = New Font("Segoe UI", 10F)
        chkRemember.ForeColor = Color.Gainsboro
        chkRemember.Location = New Point(25, 455)
        chkRemember.Name = "chkRemember"
        chkRemember.Size = New Size(144, 27)
        chkRemember.TabIndex = 3
        chkRemember.Text = "Remember Me"
        ' 
        ' Divider
        ' 
        Divider.BorderStyle = BorderStyle.Fixed3D
        Divider.Location = New Point(50, 535)
        Divider.Name = "Divider"
        Divider.Size = New Size(360, 2)
        Divider.TabIndex = 4
        ' 
        ' LinkCreateAccount
        ' 
        LinkCreateAccount.AutoSize = True
        LinkCreateAccount.Font = New Font("Segoe UI", 10F)
        LinkCreateAccount.LinkColor = Color.FromArgb(CByte(255), CByte(0), CByte(80))
        LinkCreateAccount.Location = New Point(128, 547)
        LinkCreateAccount.Name = "LinkCreateAccount"
        LinkCreateAccount.Size = New Size(197, 23)
        LinkCreateAccount.TabIndex = 5
        LinkCreateAccount.TabStop = True
        LinkCreateAccount.Text = "Create New Artist Profile"
        ' 
        ' LinkForgot
        ' 
        LinkForgot.AutoSize = True
        LinkForgot.Font = New Font("Segoe UI", 10F)
        LinkForgot.LinkColor = Color.FromArgb(CByte(255), CByte(120), CByte(150))
        LinkForgot.Location = New Point(331, 459)
        LinkForgot.Name = "LinkForgot"
        LinkForgot.Size = New Size(143, 23)
        LinkForgot.TabIndex = 6
        LinkForgot.TabStop = True
        LinkForgot.Text = "Forgot Password?"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(255), CByte(0), CByte(80))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 12F)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(145, 488)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(180, 43)
        btnLogin.TabIndex = 7
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 11F)
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(50, 403)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(360, 32)
        txtPassword.TabIndex = 8
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 11F)
        txtEmail.ForeColor = Color.White
        txtEmail.Location = New Point(50, 326)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(360, 32)
        txtEmail.TabIndex = 9
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Segoe UI", 11F)
        txtName.ForeColor = Color.White
        txtName.Location = New Point(50, 248)
        txtName.Name = "txtName"
        txtName.Size = New Size(360, 32)
        txtName.TabIndex = 10
        ' 
        ' LabelPassword
        ' 
        LabelPassword.Font = New Font("Segoe UI Semibold", 11F)
        LabelPassword.ForeColor = Color.White
        LabelPassword.Location = New Point(50, 370)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New Size(100, 30)
        LabelPassword.TabIndex = 11
        LabelPassword.Text = "Password"
        ' 
        ' LabelEmail
        ' 
        LabelEmail.Font = New Font("Segoe UI Semibold", 11F)
        LabelEmail.ForeColor = Color.White
        LabelEmail.Location = New Point(50, 293)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(100, 30)
        LabelEmail.TabIndex = 12
        LabelEmail.Text = "Email"
        ' 
        ' LabelName
        ' 
        LabelName.Font = New Font("Segoe UI Semibold", 11F)
        LabelName.ForeColor = Color.White
        LabelName.Location = New Point(50, 215)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(100, 30)
        LabelName.TabIndex = 13
        LabelName.Text = "Artist Name"
        ' 
        ' LabelTitle
        ' 
        LabelTitle.Font = New Font("Segoe UI Black", 22F, FontStyle.Bold)
        LabelTitle.ForeColor = Color.FromArgb(CByte(255), CByte(0), CByte(80))
        LabelTitle.Location = New Point(25, 125)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(430, 50)
        LabelTitle.TabIndex = 14
        LabelTitle.Text = "INKFURY TATTOO STUDIO"
        LabelTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1089, 620)
        Controls.Add(PanelMain)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tattoo Studio Login"
        PanelMain.ResumeLayout(False)
        PanelMain.PerformLayout()
        CType(PictureLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents PictureLogo As PictureBox
    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelSubtitle As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents chkRemember As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents LinkForgot As LinkLabel
    Friend WithEvents Divider As Label
    Friend WithEvents LinkCreateAccount As LinkLabel

End Class
