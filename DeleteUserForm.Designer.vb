<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteUserForm
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
        Panel2 = New Panel()
        SelectUserDropdown = New ComboBox()
        Label4 = New Label()
        DeleteUserButton = New Button()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(SelectUserDropdown)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(12, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(280, 82)
        Panel2.TabIndex = 6
        ' 
        ' SelectUserDropdown
        ' 
        SelectUserDropdown.Font = New Font("Segoe UI", 14F)
        SelectUserDropdown.FormattingEnabled = True
        SelectUserDropdown.Location = New Point(3, 37)
        SelectUserDropdown.Name = "SelectUserDropdown"
        SelectUserDropdown.Size = New Size(274, 39)
        SelectUserDropdown.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(3, 6)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 23)
        Label4.TabIndex = 2
        Label4.Text = "Select user"
        ' 
        ' DeleteUserButton
        ' 
        DeleteUserButton.BackColor = Color.Red
        DeleteUserButton.Font = New Font("Segoe UI", 12F)
        DeleteUserButton.ForeColor = Color.White
        DeleteUserButton.Location = New Point(15, 109)
        DeleteUserButton.Name = "DeleteUserButton"
        DeleteUserButton.Size = New Size(274, 49)
        DeleteUserButton.TabIndex = 10
        DeleteUserButton.Text = "Delete user"
        DeleteUserButton.UseVisualStyleBackColor = False
        ' 
        ' DeleteUserForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(304, 181)
        Controls.Add(DeleteUserButton)
        Controls.Add(Panel2)
        Name = "DeleteUserForm"
        Text = "DeleteUserForm"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents SelectUserDropdown As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DeleteUserButton As Button
End Class
