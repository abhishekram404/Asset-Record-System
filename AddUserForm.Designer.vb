<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUserForm
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
        Panel1 = New Panel()
        CancelButton = New Button()
        RegisterUserButton = New Button()
        Panel5 = New Panel()
        Label5 = New Label()
        UserAddressField = New TextBox()
        Panel4 = New Panel()
        Label4 = New Label()
        UserPhoneField = New TextBox()
        Panel3 = New Panel()
        Label3 = New Label()
        UserEmailField = New TextBox()
        Panel2 = New Panel()
        Label2 = New Label()
        UserFullnameField = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(CancelButton)
        Panel1.Controls.Add(RegisterUserButton)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(348, 512)
        Panel1.TabIndex = 0
        ' 
        ' CancelButton
        ' 
        CancelButton.BackColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        CancelButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CancelButton.ForeColor = Color.Black
        CancelButton.Location = New Point(14, 437)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(153, 56)
        CancelButton.TabIndex = 8
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = False
        ' 
        ' RegisterUserButton
        ' 
        RegisterUserButton.BackColor = Color.FromArgb(CByte(82), CByte(148), CByte(226))
        RegisterUserButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RegisterUserButton.ForeColor = Color.White
        RegisterUserButton.Location = New Point(173, 437)
        RegisterUserButton.Name = "RegisterUserButton"
        RegisterUserButton.Size = New Size(161, 56)
        RegisterUserButton.TabIndex = 7
        RegisterUserButton.Text = "Register user"
        RegisterUserButton.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Label5)
        Panel5.Controls.Add(UserAddressField)
        Panel5.Location = New Point(14, 336)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(320, 82)
        Panel5.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(3, 6)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 23)
        Label5.TabIndex = 2
        Label5.Text = "Address"
        ' 
        ' UserAddressField
        ' 
        UserAddressField.BorderStyle = BorderStyle.FixedSingle
        UserAddressField.Font = New Font("Segoe UI", 14F)
        UserAddressField.Location = New Point(3, 36)
        UserAddressField.Name = "UserAddressField"
        UserAddressField.PlaceholderText = " e.g. Balkumari, Lalitpur"
        UserAddressField.Size = New Size(314, 39)
        UserAddressField.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(UserPhoneField)
        Panel4.Location = New Point(14, 248)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(320, 82)
        Panel4.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(3, 6)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 23)
        Label4.TabIndex = 2
        Label4.Text = "Phone number"
        ' 
        ' UserPhoneField
        ' 
        UserPhoneField.BorderStyle = BorderStyle.FixedSingle
        UserPhoneField.Font = New Font("Segoe UI", 14F)
        UserPhoneField.Location = New Point(3, 36)
        UserPhoneField.Name = "UserPhoneField"
        UserPhoneField.PlaceholderText = " e.g. +977 98XXXXXXXX"
        UserPhoneField.Size = New Size(314, 39)
        UserPhoneField.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(UserEmailField)
        Panel3.Location = New Point(14, 160)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(320, 82)
        Panel3.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(3, 6)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 23)
        Label3.TabIndex = 2
        Label3.Text = "Email address"
        ' 
        ' UserEmailField
        ' 
        UserEmailField.BorderStyle = BorderStyle.FixedSingle
        UserEmailField.Font = New Font("Segoe UI", 14F)
        UserEmailField.Location = New Point(3, 36)
        UserEmailField.Name = "UserEmailField"
        UserEmailField.PlaceholderText = " e.g. johndoe@example.com"
        UserEmailField.Size = New Size(314, 39)
        UserEmailField.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(UserFullnameField)
        Panel2.Location = New Point(14, 72)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(320, 82)
        Panel2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(3, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 23)
        Label2.TabIndex = 2
        Label2.Text = "Full name"
        ' 
        ' UserFullnameField
        ' 
        UserFullnameField.BorderStyle = BorderStyle.FixedSingle
        UserFullnameField.Font = New Font("Segoe UI", 14F)
        UserFullnameField.Location = New Point(3, 36)
        UserFullnameField.Name = "UserFullnameField"
        UserFullnameField.PlaceholderText = " e.g. John Doe"
        UserFullnameField.Size = New Size(314, 39)
        UserFullnameField.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(14, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 41)
        Label1.TabIndex = 1
        Label1.Text = "Register new user"
        ' 
        ' AddUserForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(82), CByte(148), CByte(226))
        ClientSize = New Size(372, 536)
        Controls.Add(Panel1)
        Name = "AddUserForm"
        Text = "AddUser"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents UserFullnameField As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents UserAddressField As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents UserPhoneField As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents UserEmailField As TextBox
    Friend WithEvents RegisterUserButton As Button
    Friend WithEvents CancelButton As Button
End Class
