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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Panel1 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox4 = New PictureBox()
        TextBox3 = New TextBox()
        Panel4 = New Panel()
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
        PictureBox1.Location = New Point(163, 50)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(110, 110)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(180, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 31)
        Label1.TabIndex = 1
        Label1.Text = "Login"
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 14F)
        TextBox1.Location = New Point(53, 10)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Username"
        TextBox1.Size = New Size(272, 32)
        TextBox1.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(48, 242)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(328, 53)
        Panel1.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(47, 53)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(2, 1)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(44, 49)
        PictureBox4.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.None
        TextBox3.Font = New Font("Segoe UI", 14F)
        TextBox3.Location = New Point(106, 326)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Password"
        TextBox3.Size = New Size(266, 32)
        TextBox3.TabIndex = 5
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(PictureBox4)
        Panel4.Location = New Point(48, 314)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(328, 54)
        Panel4.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(248), CByte(255))
        ClientSize = New Size(436, 542)
        Controls.Add(TextBox3)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel4)
        Name = "Form1"
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel4 As Panel

End Class
