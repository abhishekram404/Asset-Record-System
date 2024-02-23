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
        SplitContainer1 = New SplitContainer()
        Label4 = New Label()
        RegisterUserButton = New Button()
        LogoutButton = New Button()
        AccessManagementButton = New Button()
        Label3 = New Label()
        AddNewAssetButton = New Button()
        Label2 = New Label()
        AssignAssetButton = New Button()
        AuthenticatedUsername = New Label()
        PictureBox1 = New PictureBox()
        AssignmentTable = New DataGridView()
        DashboardUsersTable = New DataGridView()
        DashboardAssetsTable = New DataGridView()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        Panel1 = New Panel()
        AssignedAssetsNumber = New Label()
        Label5 = New Label()
        Panel2 = New Panel()
        TotalAssetsNumber = New Label()
        Label11 = New Label()
        Panel3 = New Panel()
        TotalUsersNumber = New Label()
        Label13 = New Label()
        DatabaseHelperBindingSource = New BindingSource(components)
        EditUserButton = New Button()
        DeleteUserButton = New Button()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(AssignmentTable, ComponentModel.ISupportInitialize).BeginInit()
        CType(DashboardUsersTable, ComponentModel.ISupportInitialize).BeginInit()
        CType(DashboardAssetsTable, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel4.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DatabaseHelperBindingSource, ComponentModel.ISupportInitialize).BeginInit()
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
        SplitContainer1.Panel1.Controls.Add(Label4)
        SplitContainer1.Panel1.Controls.Add(RegisterUserButton)
        SplitContainer1.Panel1.Controls.Add(LogoutButton)
        SplitContainer1.Panel1.Controls.Add(AccessManagementButton)
        SplitContainer1.Panel1.Controls.Add(Label3)
        SplitContainer1.Panel1.Controls.Add(AddNewAssetButton)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(AssignAssetButton)
        SplitContainer1.Panel1.Controls.Add(AuthenticatedUsername)
        SplitContainer1.Panel1.Controls.Add(PictureBox1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(DeleteUserButton)
        SplitContainer1.Panel2.Controls.Add(EditUserButton)
        SplitContainer1.Panel2.Controls.Add(AssignmentTable)
        SplitContainer1.Panel2.Controls.Add(DashboardUsersTable)
        SplitContainer1.Panel2.Controls.Add(DashboardAssetsTable)
        SplitContainer1.Panel2.Controls.Add(FlowLayoutPanel4)
        SplitContainer1.Size = New Size(1126, 782)
        SplitContainer1.SplitterDistance = 245
        SplitContainer1.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 10F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(63, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 23)
        Label4.TabIndex = 9
        Label4.Text = "Logged in as"
        ' 
        ' RegisterUserButton
        ' 
        RegisterUserButton.BackColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        RegisterUserButton.Font = New Font("Segoe UI", 12F)
        RegisterUserButton.Location = New Point(12, 414)
        RegisterUserButton.Name = "RegisterUserButton"
        RegisterUserButton.Size = New Size(221, 49)
        RegisterUserButton.TabIndex = 8
        RegisterUserButton.Text = "Register user"
        RegisterUserButton.UseVisualStyleBackColor = False
        ' 
        ' LogoutButton
        ' 
        LogoutButton.BackColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        LogoutButton.Font = New Font("Segoe UI", 12F)
        LogoutButton.Location = New Point(12, 719)
        LogoutButton.Name = "LogoutButton"
        LogoutButton.Size = New Size(221, 49)
        LogoutButton.TabIndex = 7
        LogoutButton.Text = "Logout"
        LogoutButton.UseVisualStyleBackColor = False
        ' 
        ' AccessManagementButton
        ' 
        AccessManagementButton.BackColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        AccessManagementButton.Font = New Font("Segoe UI", 12F)
        AccessManagementButton.Location = New Point(12, 544)
        AccessManagementButton.Name = "AccessManagementButton"
        AccessManagementButton.Size = New Size(221, 49)
        AccessManagementButton.TabIndex = 6
        AccessManagementButton.Text = "Access Management"
        AccessManagementButton.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(12, 501)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 28)
        Label3.TabIndex = 5
        Label3.Text = "System"
        ' 
        ' AddNewAssetButton
        ' 
        AddNewAssetButton.BackColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        AddNewAssetButton.Font = New Font("Segoe UI", 12F)
        AddNewAssetButton.Location = New Point(12, 359)
        AddNewAssetButton.Name = "AddNewAssetButton"
        AddNewAssetButton.Size = New Size(221, 49)
        AddNewAssetButton.TabIndex = 4
        AddNewAssetButton.Text = "Add new asset"
        AddNewAssetButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(11, 261)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 28)
        Label2.TabIndex = 3
        Label2.Text = "Quick actions"
        ' 
        ' AssignAssetButton
        ' 
        AssignAssetButton.BackColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        AssignAssetButton.Font = New Font("Segoe UI", 12F)
        AssignAssetButton.Location = New Point(11, 304)
        AssignAssetButton.Name = "AssignAssetButton"
        AssignAssetButton.Size = New Size(221, 49)
        AssignAssetButton.TabIndex = 2
        AssignAssetButton.Text = "Assign asset"
        AssignAssetButton.UseVisualStyleBackColor = False
        ' 
        ' AuthenticatedUsername
        ' 
        AuthenticatedUsername.AutoSize = True
        AuthenticatedUsername.BackColor = Color.Transparent
        AuthenticatedUsername.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        AuthenticatedUsername.ForeColor = Color.White
        AuthenticatedUsername.Location = New Point(62, 210)
        AuthenticatedUsername.Name = "AuthenticatedUsername"
        AuthenticatedUsername.Size = New Size(109, 41)
        AuthenticatedUsername.TabIndex = 1
        AuthenticatedUsername.Text = "Admin"
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
        ' AssignmentTable
        ' 
        AssignmentTable.AllowUserToAddRows = False
        AssignmentTable.AllowUserToDeleteRows = False
        AssignmentTable.AllowUserToOrderColumns = True
        AssignmentTable.BackgroundColor = Color.White
        AssignmentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        AssignmentTable.Location = New Point(19, 450)
        AssignmentTable.Name = "AssignmentTable"
        AssignmentTable.ReadOnly = True
        AssignmentTable.RowHeadersWidth = 51
        AssignmentTable.Size = New Size(399, 188)
        AssignmentTable.TabIndex = 7
        ' 
        ' DashboardUsersTable
        ' 
        DashboardUsersTable.AllowUserToAddRows = False
        DashboardUsersTable.AllowUserToDeleteRows = False
        DashboardUsersTable.AllowUserToOrderColumns = True
        DashboardUsersTable.BackgroundColor = Color.White
        DashboardUsersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DashboardUsersTable.Location = New Point(438, 239)
        DashboardUsersTable.Name = "DashboardUsersTable"
        DashboardUsersTable.ReadOnly = True
        DashboardUsersTable.RowHeadersWidth = 51
        DashboardUsersTable.Size = New Size(425, 188)
        DashboardUsersTable.TabIndex = 6
        ' 
        ' DashboardAssetsTable
        ' 
        DashboardAssetsTable.AllowUserToAddRows = False
        DashboardAssetsTable.AllowUserToDeleteRows = False
        DashboardAssetsTable.AllowUserToOrderColumns = True
        DashboardAssetsTable.BackgroundColor = Color.White
        DashboardAssetsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DashboardAssetsTable.Location = New Point(19, 239)
        DashboardAssetsTable.Name = "DashboardAssetsTable"
        DashboardAssetsTable.ReadOnly = True
        DashboardAssetsTable.RowHeadersWidth = 51
        DashboardAssetsTable.Size = New Size(399, 188)
        DashboardAssetsTable.TabIndex = 5
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
        Panel1.Controls.Add(AssignedAssetsNumber)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(204, 116)
        Panel1.TabIndex = 0
        ' 
        ' AssignedAssetsNumber
        ' 
        AssignedAssetsNumber.AutoSize = True
        AssignedAssetsNumber.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        AssignedAssetsNumber.ForeColor = Color.White
        AssignedAssetsNumber.Location = New Point(1, 49)
        AssignedAssetsNumber.Name = "AssignedAssetsNumber"
        AssignedAssetsNumber.Size = New Size(92, 54)
        AssignedAssetsNumber.TabIndex = 6
        AssignedAssetsNumber.Text = "129"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F)
        Label5.ForeColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        Label5.Location = New Point(7, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(183, 32)
        Label5.TabIndex = 5
        Label5.Text = "Assigned Assets"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(139), CByte(105))
        Panel2.Controls.Add(TotalAssetsNumber)
        Panel2.Controls.Add(Label11)
        Panel2.Location = New Point(213, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(212, 116)
        Panel2.TabIndex = 1
        ' 
        ' TotalAssetsNumber
        ' 
        TotalAssetsNumber.AutoSize = True
        TotalAssetsNumber.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        TotalAssetsNumber.ForeColor = Color.White
        TotalAssetsNumber.Location = New Point(1, 49)
        TotalAssetsNumber.Name = "TotalAssetsNumber"
        TotalAssetsNumber.Size = New Size(115, 54)
        TotalAssetsNumber.TabIndex = 6
        TotalAssetsNumber.Text = "1432"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 14F)
        Label11.ForeColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        Label11.Location = New Point(7, 17)
        Label11.Name = "Label11"
        Label11.Size = New Size(138, 32)
        Label11.TabIndex = 5
        Label11.Text = "Total Assets"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(71), CByte(69), CByte(84))
        Panel3.Controls.Add(TotalUsersNumber)
        Panel3.Controls.Add(Label13)
        Panel3.Location = New Point(431, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(214, 116)
        Panel3.TabIndex = 7
        ' 
        ' TotalUsersNumber
        ' 
        TotalUsersNumber.AutoSize = True
        TotalUsersNumber.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        TotalUsersNumber.ForeColor = Color.White
        TotalUsersNumber.Location = New Point(1, 49)
        TotalUsersNumber.Name = "TotalUsersNumber"
        TotalUsersNumber.Size = New Size(69, 54)
        TotalUsersNumber.TabIndex = 6
        TotalUsersNumber.Text = "25"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 14F)
        Label13.ForeColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        Label13.Location = New Point(7, 17)
        Label13.Name = "Label13"
        Label13.Size = New Size(129, 32)
        Label13.TabIndex = 5
        Label13.Text = "Total Users"
        ' 
        ' DatabaseHelperBindingSource
        ' 
        DatabaseHelperBindingSource.DataSource = GetType(DatabaseHelper)
        ' 
        ' EditUserButton
        ' 
        EditUserButton.BackColor = Color.FromArgb(CByte(227), CByte(224), CByte(243))
        EditUserButton.Font = New Font("Segoe UI", 12F)
        EditUserButton.Location = New Point(19, 719)
        EditUserButton.Name = "EditUserButton"
        EditUserButton.Size = New Size(145, 49)
        EditUserButton.TabIndex = 8
        EditUserButton.Text = "Edit user"
        EditUserButton.UseVisualStyleBackColor = False
        ' 
        ' DeleteUserButton
        ' 
        DeleteUserButton.BackColor = Color.Red
        DeleteUserButton.Font = New Font("Segoe UI", 12F)
        DeleteUserButton.ForeColor = Color.White
        DeleteUserButton.Location = New Point(170, 719)
        DeleteUserButton.Name = "DeleteUserButton"
        DeleteUserButton.Size = New Size(145, 49)
        DeleteUserButton.TabIndex = 9
        DeleteUserButton.Text = "Delete user"
        DeleteUserButton.UseVisualStyleBackColor = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
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
        CType(AssignmentTable, ComponentModel.ISupportInitialize).EndInit()
        CType(DashboardUsersTable, ComponentModel.ISupportInitialize).EndInit()
        CType(DashboardAssetsTable, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel4.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DatabaseHelperBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents AssignAssetButton As Button
    Friend WithEvents AuthenticatedUsername As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AddNewAssetButton As Button
    Friend WithEvents LogoutButton As Button
    Friend WithEvents AccessManagementButton As Button
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents AssignedAssetsNumber As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TotalAssetsNumber As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TotalUsersNumber As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents RegisterUserButton As Button
    Friend WithEvents DashboardAssetsTable As DataGridView
    Friend WithEvents DashboardUsersTable As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents DatabaseHelperBindingSource As BindingSource
    Friend WithEvents AssignmentTable As DataGridView
    Friend WithEvents DeleteUserButton As Button
    Friend WithEvents EditUserButton As Button
End Class
