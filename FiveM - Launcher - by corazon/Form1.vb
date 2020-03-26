Imports Microsoft.VisualBasic.FileIO
Imports Microsoft.Win32
Imports System
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Net.WebClient
Imports System.Net


Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Shell("Explorer.exe fivem://connect/127.0.0.1:30120")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Shell("Explorer.exe https://discord.gg/BWcENUB")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Shell("Explorer.exe https://twitter.com/Discord_OPFR")
    End Sub
End Class

