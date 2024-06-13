Namespace BlackMiner
	' Token: 0x02000002 RID: 2
	Public Partial Class Form1
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000002 RID: 2 RVA: 0x0000205E File Offset: 0x0000025E
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000003 RID: 3 RVA: 0x0000207D File Offset: 0x0000027D
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(800, 450)
			Me.Text = "Form1"
		End Sub

		' Token: 0x04000001 RID: 1
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
