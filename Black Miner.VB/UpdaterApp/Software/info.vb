Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace Software
	' Token: 0x0200000D RID: 13
	Public Partial Class info
		Inherits Form

		' Token: 0x06000085 RID: 133 RVA: 0x00020BDA File Offset: 0x0001EDDA
		Public Sub New()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000086 RID: 134 RVA: 0x00020BE8 File Offset: 0x0001EDE8
		Private Sub info_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000087 RID: 135 RVA: 0x00020BEA File Offset: 0x0001EDEA
		Private Sub button1_Click(sender As Object, e As EventArgs)
			Process.Start(New ProcessStartInfo() With { .FileName = "https://t.me/CrackerWalletBot", .UseShellExecute = True })
		End Sub
	End Class
End Namespace
