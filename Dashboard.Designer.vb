﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        SplitContainer1 = New SplitContainer()
        Button4 = New Button()
        Button3 = New Button()
        Label3 = New Label()
        Button2 = New Button()
        Label2 = New Label()
        Button1 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        Panel1 = New Panel()
        Label9 = New Label()
        Label5 = New Label()
        Panel2 = New Panel()
        Label10 = New Label()
        Label11 = New Label()
        Panel3 = New Panel()
        Label12 = New Label()
        Label13 = New Label()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel4.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Location = New Point(1, 1)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.BackColor = Color.FromArgb(CByte(82), CByte(148), CByte(226))
        SplitContainer1.Panel1.Controls.Add(Button4)
        SplitContainer1.Panel1.Controls.Add(Button3)
        SplitContainer1.Panel1.Controls.Add(Label3)
        SplitContainer1.Panel1.Controls.Add(Button2)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(Button1)
        SplitContainer1.Panel1.Controls.Add(Label1)
        SplitContainer1.Panel1.Controls.Add(PictureBox1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(FlowLayoutPanel4)
        SplitContainer1.Size = New Size(1126, 782)
        SplitContainer1.SplitterDistance = 245
        SplitContainer1.TabIndex = 1
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        Button4.Font = New Font("Segoe UI", 12.0F)
        Button4.Location = New Point(12, 719)
        Button4.Name = "Button4"
        Button4.Size = New Size(221, 49)
        Button4.TabIndex = 7
        Button4.Text = "Logout"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        Button3.Font = New Font("Segoe UI", 12.0F)
        Button3.Location = New Point(12, 489)
        Button3.Name = "Button3"
        Button3.Size = New Size(221, 49)
        Button3.TabIndex = 6
        Button3.Text = "Access Management"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(12, 446)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 28)
        Label3.TabIndex = 5
        Label3.Text = "System"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        Button2.Font = New Font("Segoe UI", 12.0F)
        Button2.Location = New Point(12, 367)
        Button2.Name = "Button2"
        Button2.Size = New Size(221, 49)
        Button2.TabIndex = 4
        Button2.Text = "View entries"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(11, 261)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 28)
        Label2.TabIndex = 3
        Label2.Text = "Quick actions"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        Button1.Font = New Font("Segoe UI", 12.0F)
        Button1.Location = New Point(11, 304)
        Button1.Name = "Button1"
        Button1.Size = New Size(221, 49)
        Button1.TabIndex = 2
        Button1.Text = "Add new entry"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(62, 191)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 41)
        Label1.TabIndex = 1
        Label1.Text = "Admin"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(54, 41)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 126)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.Controls.Add(Panel1)
        FlowLayoutPanel4.Controls.Add(Panel2)
        FlowLayoutPanel4.Controls.Add(Panel3)
        FlowLayoutPanel4.Location = New Point(19, 21)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(844, 123)
        FlowLayoutPanel4.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(131), CByte(255))
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(181, 116)
        Panel1.TabIndex = 0
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(1, 49)
        Label9.Name = "Label9"
        Label9.Size = New Size(92, 54)
        Label9.TabIndex = 6
        Label9.Text = "129"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.0F)
        Label5.ForeColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        Label5.Location = New Point(7, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(158, 32)
        Label5.TabIndex = 5
        Label5.Text = "Active entries"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(139), CByte(105))
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label11)
        Panel2.Location = New Point(190, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(196, 116)
        Panel2.TabIndex = 1
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(1, 49)
        Label10.Name = "Label10"
        Label10.Size = New Size(115, 54)
        Label10.TabIndex = 6
        Label10.Text = "1432"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 14.0F)
        Label11.ForeColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        Label11.Location = New Point(7, 17)
        Label11.Name = "Label11"
        Label11.Size = New Size(120, 32)
        Label11.TabIndex = 5
        Label11.Text = "All entries"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(71), CByte(69), CByte(84))
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(Label13)
        Panel3.Location = New Point(392, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(214, 116)
        Panel3.TabIndex = 7
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        Label12.ForeColor = Color.White
        Label12.Location = New Point(1, 49)
        Label12.Name = "Label12"
        Label12.Size = New Size(46, 54)
        Label12.TabIndex = 6
        Label12.Text = "2"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 14.0F)
        Label13.ForeColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        Label13.Location = New Point(7, 17)
        Label13.Name = "Label13"
        Label13.Size = New Size(193, 32)
        Label13.TabIndex = 5
        Label13.Text = "Authorized users"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1125, 781)
        Controls.Add(SplitContainer1)
        Name = "Dashboard"
        Text = "Dashboard"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel4.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class