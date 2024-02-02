<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        UsernameField = New TextBox()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox4 = New PictureBox()
        PasswordField = New TextBox()
        Panel4 = New Panel()
        LoginButton = New Button()
        CancelButton = New Button()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(168, 111)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(110, 116)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(185, 252)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 31)
        Label1.TabIndex = 1
        Label1.Text = "Login"
        ' 
        ' UsernameField
        ' 
        UsernameField.BorderStyle = BorderStyle.None
        UsernameField.Font = New Font("Segoe UI", 14F)
        UsernameField.Location = New Point(53, 10)
        UsernameField.Name = "UsernameField"
        UsernameField.PlaceholderText = "Username"
        UsernameField.Size = New Size(272, 32)
        UsernameField.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(UsernameField)
        Panel1.Location = New Point(49, 316)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(328, 59)
        Panel1.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(47, 59)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(2, 1)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(44, 55)
        PictureBox4.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' PasswordField
        ' 
        PasswordField.BorderStyle = BorderStyle.None
        PasswordField.Font = New Font("Segoe UI", 14F)
        PasswordField.Location = New Point(107, 400)
        PasswordField.Name = "PasswordField"
        PasswordField.PlaceholderText = "Password"
        PasswordField.Size = New Size(266, 32)
        PasswordField.TabIndex = 5
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(PictureBox4)
        Panel4.Location = New Point(49, 388)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(328, 60)
        Panel4.TabIndex = 6
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.FromArgb(CByte(82), CByte(148), CByte(226))
        LoginButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginButton.ForeColor = Color.White
        LoginButton.Location = New Point(49, 478)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(327, 62)
        LoginButton.TabIndex = 7
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' CancelButton
        ' 
        CancelButton.BackColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        CancelButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CancelButton.ForeColor = Color.Black
        CancelButton.Location = New Point(49, 540)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(327, 62)
        CancelButton.TabIndex = 8
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18.2F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(82), CByte(148), CByte(226))
        Label2.Location = New Point(68, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(320, 42)
        Label2.TabIndex = 9
        Label2.Text = "Asset Record System"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(255))
        ClientSize = New Size(441, 648)
        Controls.Add(Label2)
        Controls.Add(CancelButton)
        Controls.Add(LoginButton)
        Controls.Add(PasswordField)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel4)
        Name = "LoginForm"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameField As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PasswordField As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LoginButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Label2 As Label

End Class
