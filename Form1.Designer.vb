<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Panel1 = New Panel()
        Button1 = New Button()
        Label3 = New Label()
        PasswordPanel = New Panel()
        MaskedTextBox1 = New MaskedTextBox()
        Label2 = New Label()
        UsernamePanel = New Panel()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Login = New Label()
        Panel1.SuspendLayout()
        PasswordPanel.SuspendLayout()
        UsernamePanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(246), CByte(247), CByte(248))
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PasswordPanel)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(UsernamePanel)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Login)
        Panel1.Location = New Point(229, 54)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(20)
        Panel1.Size = New Size(365, 396)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(58), CByte(134), CByte(255))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(30, 304)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(5)
        Button1.Size = New Size(298, 49)
        Button1.TabIndex = 6
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(8), CByte(20))
        Label3.Location = New Point(30, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 23)
        Label3.TabIndex = 5
        Label3.Text = "Password"
        ' 
        ' PasswordPanel
        ' 
        PasswordPanel.BackColor = Color.White
        PasswordPanel.BorderStyle = BorderStyle.FixedSingle
        PasswordPanel.Controls.Add(MaskedTextBox1)
        PasswordPanel.Location = New Point(30, 241)
        PasswordPanel.Name = "PasswordPanel"
        PasswordPanel.Padding = New Padding(5)
        PasswordPanel.Size = New Size(298, 39)
        PasswordPanel.TabIndex = 4
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.BorderStyle = BorderStyle.None
        MaskedTextBox1.Dock = DockStyle.Fill
        MaskedTextBox1.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        MaskedTextBox1.Location = New Point(5, 5)
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.PasswordChar = "*"c
        MaskedTextBox1.Size = New Size(286, 29)
        MaskedTextBox1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(8), CByte(20))
        Label2.Location = New Point(32, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 23)
        Label2.TabIndex = 3
        Label2.Text = "Username"
        ' 
        ' UsernamePanel
        ' 
        UsernamePanel.BackColor = Color.White
        UsernamePanel.BorderStyle = BorderStyle.FixedSingle
        UsernamePanel.Controls.Add(TextBox1)
        UsernamePanel.Location = New Point(30, 154)
        UsernamePanel.Name = "UsernamePanel"
        UsernamePanel.Padding = New Padding(5)
        UsernamePanel.Size = New Size(298, 39)
        UsernamePanel.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Font = New Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(5, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "someone@example.com"
        TextBox1.Size = New Size(286, 29)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(65), CByte(90), CByte(119))
        Label1.Location = New Point(30, 69)
        Label1.MaximumSize = New Size(300, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 40)
        Label1.TabIndex = 1
        Label1.Text = "After logging in, you'll be able to access all the features of our Asset Record System"
        ' 
        ' Login
        ' 
        Login.AutoSize = True
        Login.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Login.ForeColor = Color.FromArgb(CByte(43), CByte(45), CByte(66))
        Login.Location = New Point(23, 20)
        Login.Name = "Login"
        Login.Size = New Size(89, 37)
        Login.TabIndex = 0
        Login.Text = "Login"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(58), CByte(134), CByte(255))
        ClientSize = New Size(800, 501)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        PasswordPanel.ResumeLayout(False)
        PasswordPanel.PerformLayout()
        UsernamePanel.ResumeLayout(False)
        UsernamePanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Login As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UsernamePanel As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordPanel As Panel
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Button1 As Button
End Class
