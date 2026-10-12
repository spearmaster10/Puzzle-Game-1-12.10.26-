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
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PlayBtn
        ' 
        PlayBtn.Cursor = Cursors.Hand
        PlayBtn.Image = CType(resources.GetObject("PlayBtn.Image"), Image)
        PlayBtn.Location = New Point(667, 159)
        PlayBtn.Name = "PlayBtn"
        PlayBtn.Size = New Size(266, 73)
        PlayBtn.TabIndex = 1
        PlayBtn.UseVisualStyleBackColor = True
        ' 
        ' ControlsBtn
        ' 
        ControlsBtn.BackgroundImage = My.Resources.Resources.True_Controls_Name
        ControlsBtn.BackgroundImageLayout = ImageLayout.Stretch
        ControlsBtn.Cursor = Cursors.Hand
        ControlsBtn.Location = New Point(534, 258)
        ControlsBtn.Name = "ControlsBtn"
        ControlsBtn.Size = New Size(532, 77)
        ControlsBtn.TabIndex = 2
        ControlsBtn.UseVisualStyleBackColor = True
        ' 
        ' ExitBtn
        ' 
        ExitBtn.Cursor = Cursors.Hand
        ExitBtn.Image = CType(resources.GetObject("ExitBtn.Image"), Image)
        ExitBtn.Location = New Point(667, 359)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(247, 71)
        ExitBtn.TabIndex = 3
        ExitBtn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(470, 64)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(660, 77)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 20
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = My.Resources.Resources.Full_Bachground
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1584, 861)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1584, 861)
        Controls.Add(PictureBox1)
        Controls.Add(ExitBtn)
        Controls.Add(ControlsBtn)
        Controls.Add(PlayBtn)
        Controls.Add(PictureBox2)
        Name = "Form4"
        Text = "Form4"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PlayBtn As Button
    Friend WithEvents ControlsBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
End Class
