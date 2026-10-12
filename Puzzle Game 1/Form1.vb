Imports System.Formats.Asn1.AsnWriter
Imports System.IO
Imports System.Numerics
Imports System.Reflection.Emit
Imports System.Text.RegularExpressions
Imports Windows.Win32.System

Public Class form1
    Public Current_Directory As String = Regex.Split(Directory.GetCurrentDirectory, pattern:="bin")(0)
    Public Time As Decimal = 0
    Public Restarts As Integer = 0
    Public Movement As Integer = 0
    Public Current_Level As Integer
    'remember find a way to check what the lasdt closed forem was so setting can switch between that and a level
    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
        Form2.Show()
    End Sub

End Class
