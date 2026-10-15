<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        PlayBtn = New Button()
        ControlsBtn = New Button()
        ExitBtn = New Button()
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' PlayBtn
        ' 
        PlayBtn.BackgroundImage = CType(resources.GetObject("PlayBtn.BackgroundImage"), Image)
        PlayBtn.BackgroundImageLayout = ImageLayout.Stretch
        PlayBtn.Cursor = Cursors.Hand
        PlayBtn.Dock = DockStyle.Fill
        PlayBtn.Location = New Point(87, 0)
        PlayBtn.Margin = New Padding(0)
        PlayBtn.Name = "PlayBtn"
        PlayBtn.Size = New Size(122, 43)
        PlayBtn.TabIndex = 1
        PlayBtn.UseVisualStyleBackColor = True
        ' 
        ' ControlsBtn
        ' 
        ControlsBtn.BackgroundImage = My.Resources.Resources.True_Controls_Name
        ControlsBtn.BackgroundImageLayout = ImageLayout.Stretch
        ControlsBtn.Cursor = Cursors.Hand
        ControlsBtn.Dock = DockStyle.Fill
        ControlsBtn.Location = New Point(239, 200)
        ControlsBtn.Margin = New Padding(0)
        ControlsBtn.Name = "ControlsBtn"
        ControlsBtn.Size = New Size(302, 46)
        ControlsBtn.TabIndex = 2
        ControlsBtn.UseVisualStyleBackColor = True
        ' 
        ' ExitBtn
        ' 
        ExitBtn.BackgroundImage = CType(resources.GetObject("ExitBtn.BackgroundImage"), Image)
        ExitBtn.BackgroundImageLayout = ImageLayout.Stretch
        ExitBtn.Cursor = Cursors.Hand
        ExitBtn.Dock = DockStyle.Fill
        ExitBtn.Location = New Point(93, 0)
        ExitBtn.Margin = New Padding(0)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(113, 44)
        ExitBtn.TabIndex = 3
        ExitBtn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(239, 32)
        PictureBox1.Margin = New Padding(0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(302, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 20
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.4846935F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 38.52041F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.9948978F))
        TableLayoutPanel1.Controls.Add(PictureBox1, 1, 1)
        TableLayoutPanel1.Controls.Add(ControlsBtn, 1, 5)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 1, 3)
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 1, 7)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Margin = New Padding(0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 9
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 8.029197F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.4087591F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.8686132F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.705596F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 4.86618F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.435523F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 4.622871F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.948905F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 24.8175182F))
        TableLayoutPanel1.Size = New Size(784, 411)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 29.1187744F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.6130257F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.2682F))
        TableLayoutPanel2.Controls.Add(PlayBtn, 1, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(239, 138)
        TableLayoutPanel2.Margin = New Padding(0)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(302, 43)
        TableLayoutPanel2.TabIndex = 5
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 3
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 31.034483F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 37.5478935F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 31.4176254F))
        TableLayoutPanel3.Controls.Add(ExitBtn, 1, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(239, 264)
        TableLayoutPanel3.Margin = New Padding(0)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Size = New Size(302, 44)
        TableLayoutPanel3.TabIndex = 6
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        BackgroundImage = My.Resources.Resources.Full_Bachground
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(784, 411)
        Controls.Add(TableLayoutPanel1)
        DoubleBuffered = True
        Name = "Form4"
        Text = "Form4"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents PlayBtn As Button
    Friend WithEvents ControlsBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
End Class
