<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        PanelMain = New Panel()
        Divider = New Label()
        btnDiv = New Button()
        btnMul = New Button()
        btnSub = New Button()
        btnAdd = New Button()
        txtResult = New TextBox()
        txtNum2 = New TextBox()
        txtNum1 = New TextBox()
        LabelResult = New Label()
        LabelRate = New Label()
        LabelArea = New Label()
        LabelSection = New Label()
        LabelTitle = New Label()
        PictureLogo = New PictureBox()
        PanelMain.SuspendLayout()
        CType(PictureLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        '===============================
        ' PANEL MAIN (Dark Neon Theme)
        '===============================
        PanelMain.BackColor = Color.FromArgb(18, 18, 18)
        PanelMain.BorderStyle = BorderStyle.FixedSingle
        PanelMain.Controls.Add(PictureLogo)
        PanelMain.Controls.Add(Divider)
        PanelMain.Controls.Add(btnDiv)
        PanelMain.Controls.Add(btnMul)
        PanelMain.Controls.Add(btnSub)
        PanelMain.Controls.Add(btnAdd)
        PanelMain.Controls.Add(txtResult)
        PanelMain.Controls.Add(txtNum2)
        PanelMain.Controls.Add(txtNum1)
        PanelMain.Controls.Add(LabelResult)
        PanelMain.Controls.Add(LabelRate)
        PanelMain.Controls.Add(LabelArea)
        PanelMain.Controls.Add(LabelSection)
        PanelMain.Controls.Add(LabelTitle)
        PanelMain.Location = New Point(20, 20)
        PanelMain.Name = "PanelMain"
        PanelMain.Size = New Size(910, 520)
        PanelMain.TabIndex = 0

        '===============================
        ' LOGO
        '===============================
        PictureLogo.Image = CType(resources.GetObject("LogoImage"), Image)
        PictureLogo.SizeMode = PictureBoxSizeMode.Zoom
        PictureLogo.Location = New Point(30, 20)
        PictureLogo.Size = New Size(120, 120)
        PictureLogo.BackColor = Color.Transparent

        '===============================
        ' TITLE
        '===============================
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("Segoe UI", 26.0!, FontStyle.Bold)
        LabelTitle.ForeColor = Color.FromArgb(255, 85, 85)
        LabelTitle.Location = New Point(180, 35)
        LabelTitle.Text = "Tattoo Price Calculator"

        '===============================
        ' SECTION SUBTITLE
        '===============================
        LabelSection.AutoSize = True
        LabelSection.Font = New Font("Segoe UI", 12.0!, FontStyle.Italic)
        LabelSection.ForeColor = Color.Gray
        LabelSection.Location = New Point(185, 95)
        LabelSection.Text = "Premium Studio Calculation Module"

        '===============================
        ' LABELS + INPUTS
        '===============================
        LabelArea.AutoSize = True
        LabelArea.Font = New Font("Segoe UI", 13.0!, FontStyle.Bold)
        LabelArea.ForeColor = Color.White
        LabelArea.Location = New Point(150, 170)
        LabelArea.Text = "Area (cm²)"

        txtNum1.BackColor = Color.FromArgb(35, 35, 35)
        txtNum1.BorderStyle = BorderStyle.FixedSingle
        txtNum1.Font = New Font("Segoe UI", 12.0!)
        txtNum1.ForeColor = Color.White
        txtNum1.Location = New Point(300, 165)
        txtNum1.Size = New Size(420, 34)

        LabelRate.AutoSize = True
        LabelRate.Font = New Font("Segoe UI", 13.0!, FontStyle.Bold)
        LabelRate.ForeColor = Color.White
        LabelRate.Location = New Point(150, 230)
        LabelRate.Text = "Rate per cm²"

        txtNum2.BackColor = Color.FromArgb(35, 35, 35)
        txtNum2.BorderStyle = BorderStyle.FixedSingle
        txtNum2.Font = New Font("Segoe UI", 12.0!)
        txtNum2.ForeColor = Color.White
        txtNum2.Location = New Point(300, 225)
        txtNum2.Size = New Size(420, 34)

        LabelResult.AutoSize = True
        LabelResult.Font = New Font("Segoe UI", 13.0!, FontStyle.Bold)
        LabelResult.ForeColor = Color.White
        LabelResult.Location = New Point(150, 290)
        LabelResult.Text = "Result"

        txtResult.BackColor = Color.FromArgb(30, 30, 30)
        txtResult.BorderStyle = BorderStyle.FixedSingle
        txtResult.Font = New Font("Segoe UI", 12.0!)
        txtResult.ForeColor = Color.FromArgb(255, 105, 105)
        txtResult.Location = New Point(300, 285)
        txtResult.ReadOnly = True
        txtResult.Size = New Size(420, 34)

        '===============================
        ' DIVIDER
        '===============================
        Divider.BorderStyle = BorderStyle.Fixed3D
        Divider.Location = New Point(120, 335)
        Divider.Size = New Size(660, 2)

        '===============================
        ' BUTTONS (Neon Red Buttons)
        '===============================
        Dim neonBack As Color = Color.FromArgb(255, 60, 60)

        btnAdd.BackColor = neonBack
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(130, 360)
        btnAdd.Size = New Size(150, 48)
        btnAdd.Text = "Add (+)"

        btnSub.BackColor = neonBack
        btnSub.FlatStyle = FlatStyle.Flat
        btnSub.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        btnSub.ForeColor = Color.White
        btnSub.Location = New Point(300, 360)
        btnSub.Size = New Size(150, 48)
        btnSub.Text = "Subtract (-)"

        btnMul.BackColor = neonBack
        btnMul.FlatStyle = FlatStyle.Flat
        btnMul.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        btnMul.ForeColor = Color.White
        btnMul.Location = New Point(470, 360)
        btnMul.Size = New Size(150, 48)
        btnMul.Text = "Multiply (×)"

        btnDiv.BackColor = neonBack
        btnDiv.FlatStyle = FlatStyle.Flat
        btnDiv.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        btnDiv.ForeColor = Color.White
        btnDiv.Location = New Point(640, 360)
        btnDiv.Size = New Size(150, 48)
        btnDiv.Text = "Divide (÷)"

        '===============================
        ' FORM DEFAULT SETTINGS
        '===============================
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(950, 560)
        Controls.Add(PanelMain)
        Name = "Form2"
        Text = "Tattoo Calculator"

        PanelMain.ResumeLayout(False)
        PanelMain.PerformLayout()
        CType(PictureLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelSection As Label
    Friend WithEvents LabelArea As Label
    Friend WithEvents LabelRate As Label
    Friend WithEvents LabelResult As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents btnMul As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents Divider As Label
    Friend WithEvents PictureLogo As PictureBox
End Class
