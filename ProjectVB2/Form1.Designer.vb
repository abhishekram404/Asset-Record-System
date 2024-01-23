<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        AllocatedResources = New Panel()
        Panel2 = New Panel()
        Label3 = New Label()
        Panel1 = New Panel()
        RichTextBox1 = New RichTextBox()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        PictureBox1 = New PictureBox()
        Panel4 = New Panel()
        PictureBox5 = New PictureBox()
        Button1 = New Button()
        Panel3 = New Panel()
        PictureBox4 = New PictureBox()
        Button2 = New Button()
        Panel5 = New Panel()
        PictureBox6 = New PictureBox()
        Button3 = New Button()
        Panel6 = New Panel()
        PictureBox7 = New PictureBox()
        Button4 = New Button()
        Admin = New Label()
        PictureBox3 = New PictureBox()
        AllocatedResources.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AllocatedResources
        ' 
        AllocatedResources.BackColor = Color.FromArgb(CByte(14), CByte(22), CByte(39))
        AllocatedResources.Controls.Add(Panel2)
        AllocatedResources.Controls.Add(Panel1)
        AllocatedResources.Controls.Add(PictureBox2)
        AllocatedResources.Controls.Add(Label1)
        AllocatedResources.Location = New Point(310, -1)
        AllocatedResources.Name = "AllocatedResources"
        AllocatedResources.Size = New Size(960, 686)
        AllocatedResources.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(31), CByte(41), CByte(65))
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(661, 363)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(271, 225)
        Panel2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(15, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(206, 32)
        Label3.TabIndex = 1
        Label3.Text = "Number of entries"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(31), CByte(41), CByte(65))
        Panel1.Controls.Add(RichTextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(661, 99)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(271, 236)
        Panel1.TabIndex = 0
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.FromArgb(CByte(31), CByte(41), CByte(65))
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.ForeColor = Color.Transparent
        RichTextBox1.Location = New Point(15, 56)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.ShortcutsEnabled = False
        RichTextBox1.Size = New Size(242, 153)
        RichTextBox1.TabIndex = 3
        RichTextBox1.TabStop = False
        RichTextBox1.Text = "As an administrator, you have the capability to add new entries, view existing entries, make modifications to them, and remove unnecessary entries."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(15, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(162, 32)
        Label2.TabIndex = 0
        Label2.Text = "Did you know"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 52)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1600, 1600)
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(29, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(283, 30)
        Label1.TabIndex = 1
        Label1.Text = "Welcome to the Admin Panel"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(60, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(187, 194)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(PictureBox5)
        Panel4.Controls.Add(Button1)
        Panel4.Location = New Point(5, 298)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(299, 69)
        Panel4.TabIndex = 5
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.WhiteSmoke
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(242, 13)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(37, 36)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 10
        PictureBox5.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(5, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(287, 59)
        Button1.TabIndex = 0
        Button1.Text = "Add new Entry"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(PictureBox4)
        Panel3.Controls.Add(Button2)
        Panel3.Location = New Point(5, 389)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(299, 69)
        Panel3.TabIndex = 6
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.White
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(242, 15)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(37, 32)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 9
        PictureBox4.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.ForeColor = Color.FromArgb(CByte(31), CByte(41), CByte(65))
        Button2.Location = New Point(4, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(287, 59)
        Button2.TabIndex = 1
        Button2.Text = "View your Entries"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(PictureBox6)
        Panel5.Controls.Add(Button3)
        Panel5.Location = New Point(5, 483)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(299, 69)
        Panel5.TabIndex = 6
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.White
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(242, 15)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(37, 32)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 11
        PictureBox6.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.Location = New Point(4, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(287, 59)
        Button3.TabIndex = 1
        Button3.Text = "Update existing entries"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(PictureBox7)
        Panel6.Controls.Add(Button4)
        Panel6.Location = New Point(5, 577)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(299, 69)
        Panel6.TabIndex = 6
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.White
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(242, 15)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(37, 32)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 10
        PictureBox7.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.Location = New Point(4, 3)
        Button4.Name = "Button4"
        Button4.Size = New Size(287, 59)
        Button4.TabIndex = 1
        Button4.Text = "Delete from System"
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Admin
        ' 
        Admin.AutoSize = True
        Admin.Font = New Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Admin.ForeColor = SystemColors.ButtonFace
        Admin.Location = New Point(135, 241)
        Admin.Name = "Admin"
        Admin.Size = New Size(54, 18)
        Admin.TabIndex = 7
        Admin.Text = "Admin"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(104, 241)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(25, 18)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(31), CByte(41), CByte(65))
        ClientSize = New Size(1264, 681)
        Controls.Add(PictureBox3)
        Controls.Add(Admin)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(PictureBox1)
        Controls.Add(AllocatedResources)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        AllocatedResources.ResumeLayout(False)
        AllocatedResources.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents AllocatedResources As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Admin As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox

End Class
