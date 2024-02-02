<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAssetForm
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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        Button1 = New Button()
        SubmitNewAssetButton = New Button()
        Panel6 = New Panel()
        NumericUpDown1 = New NumericUpDown()
        Label6 = New Label()
        Panel5 = New Panel()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        Panel4 = New Panel()
        RichTextBox1 = New RichTextBox()
        Label4 = New Label()
        Panel3 = New Panel()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Panel1.SuspendLayout()
        Panel6.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(SubmitNewAssetButton)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(764, 492)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(391, 410)
        Button1.Name = "Button1"
        Button1.Size = New Size(184, 56)
        Button1.TabIndex = 7
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' SubmitNewAssetButton
        ' 
        SubmitNewAssetButton.BackColor = Color.FromArgb(CByte(82), CByte(148), CByte(226))
        SubmitNewAssetButton.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SubmitNewAssetButton.ForeColor = Color.White
        SubmitNewAssetButton.Location = New Point(581, 410)
        SubmitNewAssetButton.Name = "SubmitNewAssetButton"
        SubmitNewAssetButton.Size = New Size(167, 56)
        SubmitNewAssetButton.TabIndex = 6
        SubmitNewAssetButton.Text = "Add asset"
        SubmitNewAssetButton.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(NumericUpDown1)
        Panel6.Controls.Add(Label6)
        Panel6.Location = New Point(17, 292)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(357, 82)
        Panel6.TabIndex = 5
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Font = New Font("Segoe UI", 14F)
        NumericUpDown1.Location = New Point(3, 40)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(351, 39)
        NumericUpDown1.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(3, 6)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 23)
        Label6.TabIndex = 2
        Label6.Text = "Asset worth (Nrs.)"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(DateTimePicker1)
        Panel5.Controls.Add(Label5)
        Panel5.Location = New Point(17, 393)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(357, 82)
        Panel5.TabIndex = 4
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 12F)
        DateTimePicker1.Location = New Point(3, 39)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(351, 34)
        DateTimePicker1.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(3, 6)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 23)
        Label5.TabIndex = 2
        Label5.Text = "Purchase date"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(RichTextBox1)
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(391, 85)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(357, 319)
        Panel4.TabIndex = 3
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.FixedSingle
        RichTextBox1.Location = New Point(3, 37)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(351, 267)
        RichTextBox1.TabIndex = 3
        RichTextBox1.Text = ""
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(3, 6)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 23)
        Label4.TabIndex = 2
        Label4.Text = "Description"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(ComboBox1)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(17, 191)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(357, 82)
        Panel3.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 14F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Uncategorized", "Computer hardware", "Furniture", "Electronic equipment", "Vehicle", "Machinery", "Office supplies"})
        ComboBox1.Location = New Point(3, 37)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(351, 39)
        ComboBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(3, 6)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 23)
        Label3.TabIndex = 2
        Label3.Text = "Asset type"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Location = New Point(17, 85)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(357, 82)
        Panel2.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(3, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 23)
        Label2.TabIndex = 2
        Label2.Text = "Asset name"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 14F)
        TextBox1.Location = New Point(3, 36)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Asset name"
        TextBox1.Size = New Size(351, 39)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(17, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 41)
        Label1.TabIndex = 0
        Label1.Text = "Add new asset"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' AddAssetForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(82), CByte(148), CByte(226))
        ClientSize = New Size(789, 522)
        Controls.Add(Panel1)
        Name = "AddAssetForm"
        Text = "AddAssetForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Panel6 As Panel
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents SubmitNewAssetButton As Button
    Friend WithEvents Button1 As Button
End Class
