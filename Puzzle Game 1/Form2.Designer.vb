<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        PasswordInput = New TextBox()
        UsernameInput = New TextBox()
        UsernamLabel = New Label()
        Button1 = New Button()
        Label3 = New Label()
        Timer1 = New Timer(components)
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PasswordInput
        ' 
        PasswordInput.BackColor = Color.LightGray
        PasswordInput.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordInput.Location = New Point(705, 224)
        PasswordInput.Name = "PasswordInput"
        PasswordInput.Size = New Size(190, 39)
        PasswordInput.TabIndex = 0
        ' 
        ' UsernameInput
        ' 
        UsernameInput.BackColor = Color.LightGray
        UsernameInput.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UsernameInput.Location = New Point(705, 87)
        UsernameInput.Name = "UsernameInput"
        UsernameInput.Size = New Size(190, 39)
        UsernameInput.TabIndex = 1
        ' 
        ' UsernamLabel
        ' 
        UsernamLabel.AutoSize = True
        UsernamLabel.Location = New Point(280, 56)
        UsernamLabel.Name = "UsernamLabel"
        UsernamLabel.Size = New Size(0, 15)
        UsernamLabel.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightGray
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.TopLeft
        Button1.Location = New Point(669, 281)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(262, 44)
        Button1.TabIndex = 4
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(404, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 5
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 20
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(669, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(262, 42)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(669, 148)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(262, 44)
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1584, 861)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(UsernamLabel)
        Controls.Add(UsernameInput)
        Controls.Add(PasswordInput)
        Name = "Form2"
        Text = "Login"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PasswordInput As TextBox
    Friend WithEvents UsernameInput As TextBox
    Friend WithEvents UsernamLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
