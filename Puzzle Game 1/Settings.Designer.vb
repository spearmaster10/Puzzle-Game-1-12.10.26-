<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Back = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Back
        ' 
        Back.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Back.BackgroundImage = My.Resources.Resources.Back_True
        Back.BackgroundImageLayout = ImageLayout.Stretch
        Back.Cursor = Cursors.Hand
        Back.Dock = DockStyle.Fill
        Back.Location = New Point(325, 319)
        Back.Margin = New Padding(0)
        Back.Name = "Back"
        Back.Size = New Size(132, 43)
        Back.TabIndex = 0
        Back.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 41.4540825F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 16.9642849F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 41.5816345F))
        TableLayoutPanel1.Controls.Add(Back, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 77.61557F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.4622869F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 11.6788321F))
        TableLayoutPanel1.Size = New Size(784, 411)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Updated_Controls1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(784, 411)
        Controls.Add(TableLayoutPanel1)
        DoubleBuffered = True
        Name = "Settings"
        Text = "Settings"
        WindowState = FormWindowState.Maximized
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Back As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
