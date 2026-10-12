<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Level_1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Level_1))
        Player_Shadow = New PictureBox()
        player = New PictureBox()
        Crate_1 = New PictureBox()
        Crate_2 = New PictureBox()
        Wall_2 = New PictureBox()
        wall_1 = New PictureBox()
        wall_3 = New PictureBox()
        Timer1 = New Timer(components)
        Shadow = New PictureBox()
        Win_Block = New PictureBox()
        PictureBox1 = New PictureBox()
        Grid_1 = New TableLayoutPanel()
        DataGridView1 = New DataGridView()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        CType(Player_Shadow, ComponentModel.ISupportInitialize).BeginInit()
        CType(player, ComponentModel.ISupportInitialize).BeginInit()
        CType(Crate_1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Crate_2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Wall_2, ComponentModel.ISupportInitialize).BeginInit()
        CType(wall_1, ComponentModel.ISupportInitialize).BeginInit()
        CType(wall_3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Shadow, ComponentModel.ISupportInitialize).BeginInit()
        CType(Win_Block, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Grid_1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Player_Shadow
        ' 
        Player_Shadow.BackColor = Color.RosyBrown
        Player_Shadow.Dock = DockStyle.Fill
        Player_Shadow.Location = New Point(557, 186)
        Player_Shadow.Name = "Player_Shadow"
        Player_Shadow.Size = New Size(31, 31)
        Player_Shadow.TabIndex = 15
        Player_Shadow.TabStop = False
        Player_Shadow.Visible = False
        ' 
        ' player
        ' 
        player.BackColor = Color.LightGray
        player.BackgroundImage = CType(resources.GetObject("player.BackgroundImage"), Image)
        player.Dock = DockStyle.Fill
        player.ErrorImage = My.Resources.Resources.placeholder
        player.Image = My.Resources.Resources.Snail_Right
        player.InitialImage = My.Resources.Resources.Snail_Right
        player.Location = New Point(0, 0)
        player.Margin = New Padding(0)
        player.Name = "player"
        player.Size = New Size(37, 36)
        player.SizeMode = PictureBoxSizeMode.StretchImage
        player.TabIndex = 14
        player.TabStop = False
        ' 
        ' Crate_1
        ' 
        Crate_1.BackColor = Color.Lime
        Crate_1.Dock = DockStyle.Fill
        Crate_1.Image = My.Resources.Resources.Crate
        Crate_1.Location = New Point(148, 110)
        Crate_1.Margin = New Padding(0)
        Crate_1.Name = "Crate_1"
        Crate_1.Size = New Size(37, 36)
        Crate_1.SizeMode = PictureBoxSizeMode.StretchImage
        Crate_1.TabIndex = 17
        Crate_1.TabStop = False
        ' 
        ' Crate_2
        ' 
        Crate_2.BackColor = Color.Lime
        Crate_2.Dock = DockStyle.Fill
        Crate_2.Image = My.Resources.Resources.Crate
        Crate_2.Location = New Point(185, 110)
        Crate_2.Margin = New Padding(0)
        Crate_2.Name = "Crate_2"
        Crate_2.Size = New Size(36, 36)
        Crate_2.SizeMode = PictureBoxSizeMode.StretchImage
        Crate_2.TabIndex = 16
        Crate_2.TabStop = False
        ' 
        ' Wall_2
        ' 
        Wall_2.BackColor = Color.IndianRed
        Wall_2.Dock = DockStyle.Left
        Wall_2.Location = New Point(0, 0)
        Wall_2.Name = "Wall_2"
        Wall_2.Size = New Size(37, 555)
        Wall_2.TabIndex = 18
        Wall_2.TabStop = False
        ' 
        ' wall_1
        ' 
        wall_1.BackColor = Color.IndianRed
        wall_1.Dock = DockStyle.Top
        wall_1.Location = New Point(37, 0)
        wall_1.Name = "wall_1"
        wall_1.Size = New Size(1073, 37)
        wall_1.TabIndex = 19
        wall_1.TabStop = False
        ' 
        ' wall_3
        ' 
        wall_3.BackColor = Color.IndianRed
        wall_3.Dock = DockStyle.Bottom
        wall_3.Location = New Point(37, 518)
        wall_3.Name = "wall_3"
        wall_3.Size = New Size(1073, 37)
        wall_3.TabIndex = 20
        wall_3.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 20
        ' 
        ' Shadow
        ' 
        Shadow.BackColor = Color.FromArgb(CByte(218), CByte(220), CByte(231))
        Shadow.Dock = DockStyle.Fill
        Shadow.Location = New Point(705, 113)
        Shadow.Name = "Shadow"
        Shadow.Size = New Size(31, 30)
        Shadow.TabIndex = 21
        Shadow.TabStop = False
        Shadow.Visible = False
        ' 
        ' Win_Block
        ' 
        Win_Block.BackColor = Color.Yellow
        Win_Block.Dock = DockStyle.Fill
        Win_Block.Image = My.Resources.Resources.placeholder
        Win_Block.Location = New Point(406, 257)
        Win_Block.Margin = New Padding(0)
        Win_Block.Name = "Win_Block"
        Win_Block.Size = New Size(37, 37)
        Win_Block.SizeMode = PictureBoxSizeMode.StretchImage
        Win_Block.TabIndex = 22
        Win_Block.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.IndianRed
        PictureBox1.Dock = DockStyle.Right
        PictureBox1.Location = New Point(1073, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(37, 481)
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' Grid_1
        ' 
        Grid_1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Grid_1.BackColor = Color.FromArgb(CByte(218), CByte(220), CByte(231))
        Grid_1.ColumnCount = 28
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155585F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.56798387F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 3.57155538F))
        Grid_1.Controls.Add(Crate_1, 4, 3)
        Grid_1.Controls.Add(Win_Block, 11, 7)
        Grid_1.Controls.Add(Crate_2, 5, 3)
        Grid_1.Controls.Add(Shadow, 19, 3)
        Grid_1.Controls.Add(Player_Shadow, 15, 5)
        Grid_1.Controls.Add(DataGridView1, 11, 3)
        Grid_1.Controls.Add(FlowLayoutPanel1, 27, 1)
        Grid_1.Controls.Add(player, 0, 0)
        Grid_1.Dock = DockStyle.Fill
        Grid_1.Location = New Point(37, 37)
        Grid_1.Margin = New Padding(0)
        Grid_1.Name = "Grid_1"
        Grid_1.RowCount = 13
        Grid_1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.69230652F))
        Grid_1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.69230843F))
        Grid_1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.69230843F))
        Grid_1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.692306F))
        Grid_1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.69230843F))
        Grid_1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.69230843F))
        Grid_1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.69230843F))
        Grid_1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.69230843F))
        Grid_1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.69230843F))
        Grid_1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.69230843F))
        Grid_1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.69230843F))
        Grid_1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.69230843F))
        Grid_1.RowStyles.Add(New RowStyle(SizeType.Percent, 7.69230843F))
        Grid_1.Size = New Size(1036, 481)
        Grid_1.TabIndex = 26
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(406, 110)
        DataGridView1.Margin = New Padding(0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(37, 36)
        DataGridView1.TabIndex = 23
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(1001, 39)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(19, 13)
        FlowLayoutPanel1.TabIndex = 24
        ' 
        ' Level_1
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.GradientInactiveCaption
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1110, 555)
        Controls.Add(Grid_1)
        Controls.Add(PictureBox1)
        Controls.Add(wall_3)
        Controls.Add(wall_1)
        Controls.Add(Wall_2)
        Name = "Level_1"
        Text = "Level_1"
        WindowState = FormWindowState.Maximized
        CType(Player_Shadow, ComponentModel.ISupportInitialize).EndInit()
        CType(player, ComponentModel.ISupportInitialize).EndInit()
        CType(Crate_1, ComponentModel.ISupportInitialize).EndInit()
        CType(Crate_2, ComponentModel.ISupportInitialize).EndInit()
        CType(Wall_2, ComponentModel.ISupportInitialize).EndInit()
        CType(wall_1, ComponentModel.ISupportInitialize).EndInit()
        CType(wall_3, ComponentModel.ISupportInitialize).EndInit()
        CType(Shadow, ComponentModel.ISupportInitialize).EndInit()
        CType(Win_Block, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Grid_1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Player_Shadow As PictureBox
    Friend WithEvents player As PictureBox
    Friend WithEvents Crate_1 As PictureBox
    Friend WithEvents Crate_2 As PictureBox
    Friend WithEvents Wall_2 As PictureBox
    Friend WithEvents wall_1 As PictureBox
    Friend WithEvents wall_3 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Shadow As PictureBox
    Friend WithEvents Win_Block As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Grid_1 As TableLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
