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
        PasswordInput = New TextBox()
        UsernameInput = New TextBox()
        UsernamLabel = New Label()
        Button1 = New Button()
        Label3 = New Label()
        Timer1 = New Timer(components)
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PasswordInput
        ' 
        PasswordInput.BackColor = Color.LightGray
        PasswordInput.Dock = DockStyle.Fill
        PasswordInput.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordInput.Location = New Point(261, 227)
        PasswordInput.Margin = New Padding(0)
        PasswordInput.Name = "PasswordInput"
        PasswordInput.Size = New Size(261, 39)
        PasswordInput.TabIndex = 0
        ' 
        ' UsernameInput
        ' 
        UsernameInput.BackColor = Color.LightGray
        UsernameInput.Dock = DockStyle.Fill
        UsernameInput.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UsernameInput.Location = New Point(261, 89)
        UsernameInput.Margin = New Padding(0)
        UsernameInput.Name = "UsernameInput"
        UsernameInput.Size = New Size(261, 39)
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
        Button1.BackgroundImage = My.Resources.Resources._Continue
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Cursor = Cursors.Hand
        Button1.Dock = DockStyle.Fill
        Button1.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ImageAlign = ContentAlignment.TopLeft
        Button1.Location = New Point(261, 304)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(261, 50)
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
        PictureBox1.BackgroundImage = My.Resources.Resources.Password1
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(261, 36)
        PictureBox1.Margin = New Padding(0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(261, 39)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.Password
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Location = New Point(261, 178)
        PictureBox2.Margin = New Padding(0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(261, 39)
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(PictureBox1, 1, 1)
        TableLayoutPanel1.Controls.Add(PictureBox2, 1, 5)
        TableLayoutPanel1.Controls.Add(Button1, 1, 9)
        TableLayoutPanel1.Controls.Add(UsernameInput, 1, 3)
        TableLayoutPanel1.Controls.Add(PasswordInput, 1, 7)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 11
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090908F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.975669F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 3.649635F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.3819952F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.090908F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.975669F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 2.676399F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.3819952F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 6.082725F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.6520681F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.8953772F))
        TableLayoutPanel1.Size = New Size(784, 411)
        TableLayoutPanel1.TabIndex = 8
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        BackgroundImage = My.Resources.Resources.Full_Bachground
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(784, 411)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Label3)
        Controls.Add(UsernamLabel)
        DoubleBuffered = True
        Name = "Form2"
        Text = "Login"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
