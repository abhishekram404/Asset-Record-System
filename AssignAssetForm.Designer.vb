﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignAssetForm
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
        AssignButton = New Button()
        Panel6 = New Panel()
        NotesField = New RichTextBox()
        Label7 = New Label()
        Panel5 = New Panel()
        ReturnDateField = New DateTimePicker()
        Label6 = New Label()
        Panel4 = New Panel()
        AssignmentDateField = New DateTimePicker()
        Label5 = New Label()
        Panel2 = New Panel()
        SelectUserDropdown = New ComboBox()
        Label4 = New Label()
        Panel3 = New Panel()
        SelectAssetDropdown = New ComboBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(CancelButton)
        Panel1.Controls.Add(AssignButton)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(699, 455)
        Panel1.TabIndex = 0
        ' 
        ' CancelButton
        ' 
        CancelButton.BackColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        CancelButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CancelButton.ForeColor = Color.Black
        CancelButton.Location = New Point(366, 374)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(135, 56)
        CancelButton.TabIndex = 10
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = False
        ' 
        ' AssignButton
        ' 
        AssignButton.BackColor = Color.FromArgb(CByte(82), CByte(148), CByte(226))
        AssignButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        AssignButton.ForeColor = Color.White
        AssignButton.Location = New Point(507, 374)
        AssignButton.Name = "AssignButton"
        AssignButton.Size = New Size(171, 56)
        AssignButton.TabIndex = 9
        AssignButton.Text = "Assign"
        AssignButton.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(NotesField)
        Panel6.Controls.Add(Label7)
        Panel6.Location = New Point(366, 70)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(311, 284)
        Panel6.TabIndex = 8
        ' 
        ' NotesField
        ' 
        NotesField.BorderStyle = BorderStyle.FixedSingle
        NotesField.Location = New Point(3, 37)
        NotesField.Name = "NotesField"
        NotesField.Size = New Size(305, 244)
        NotesField.TabIndex = 3
        NotesField.Text = ""
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.Location = New Point(3, 6)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 23)
        Label7.TabIndex = 2
        Label7.Text = "Notes"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(ReturnDateField)
        Panel5.Controls.Add(Label6)
        Panel5.Location = New Point(18, 360)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(327, 77)
        Panel5.TabIndex = 7
        ' 
        ' ReturnDateField
        ' 
        ReturnDateField.Font = New Font("Segoe UI", 12F)
        ReturnDateField.Location = New Point(3, 36)
        ReturnDateField.Name = "ReturnDateField"
        ReturnDateField.Size = New Size(321, 34)
        ReturnDateField.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(3, 6)
        Label6.Name = "Label6"
        Label6.Size = New Size(176, 23)
        Label6.TabIndex = 2
        Label6.Text = "Estimated return date"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(AssignmentDateField)
        Panel4.Controls.Add(Label5)
        Panel4.Location = New Point(18, 277)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(327, 77)
        Panel4.TabIndex = 6
        ' 
        ' AssignmentDateField
        ' 
        AssignmentDateField.Font = New Font("Segoe UI", 12F)
        AssignmentDateField.Location = New Point(3, 36)
        AssignmentDateField.Name = "AssignmentDateField"
        AssignmentDateField.Size = New Size(321, 34)
        AssignmentDateField.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(3, 6)
        Label5.Name = "Label5"
        Label5.Size = New Size(138, 23)
        Label5.TabIndex = 2
        Label5.Text = "Assignment date"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(SelectUserDropdown)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(18, 189)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(327, 82)
        Panel2.TabIndex = 5
        ' 
        ' SelectUserDropdown
        ' 
        SelectUserDropdown.Font = New Font("Segoe UI", 14F)
        SelectUserDropdown.FormattingEnabled = True
        SelectUserDropdown.Location = New Point(3, 37)
        SelectUserDropdown.Name = "SelectUserDropdown"
        SelectUserDropdown.Size = New Size(321, 39)
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
        ' Panel3
        ' 
        Panel3.Controls.Add(SelectAssetDropdown)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(18, 101)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(327, 82)
        Panel3.TabIndex = 4
        ' 
        ' SelectAssetDropdown
        ' 
        SelectAssetDropdown.Font = New Font("Segoe UI", 14F)
        SelectAssetDropdown.FormattingEnabled = True
        SelectAssetDropdown.Location = New Point(3, 37)
        SelectAssetDropdown.Name = "SelectAssetDropdown"
        SelectAssetDropdown.Size = New Size(321, 39)
        SelectAssetDropdown.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(3, 6)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 23)
        Label3.TabIndex = 2
        Label3.Text = "Select asset"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(15, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(311, 25)
        Label2.TabIndex = 3
        Label2.Text = "You can assign an asset to any user."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(189, 41)
        Label1.TabIndex = 2
        Label1.Text = "Assign asset"
        ' 
        ' AssignAssetForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(82), CByte(148), CByte(226))
        ClientSize = New Size(724, 479)
        Controls.Add(Panel1)
        Name = "AssignAssetForm"
        Text = "AssignAsset"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SelectAssetDropdown As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SelectUserDropdown As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ReturnDateField As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents AssignmentDateField As DateTimePicker
    Friend WithEvents Panel6 As Panel
    Friend WithEvents NotesField As RichTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents AssignButton As Button
End Class
