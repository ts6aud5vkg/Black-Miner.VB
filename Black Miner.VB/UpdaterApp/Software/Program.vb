Imports System
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Software
	' Token: 0x0200000E RID: 14
	Friend Module Program
		' Token: 0x0600008A RID: 138 RVA: 0x000213D0 File Offset: 0x0001F5D0
		<STAThread()>
		Private Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Program.PerformUpdateCheck()
			If File.Exists(Program.activationFilePath) Then
				Dim formToOpen As Form = Program.GetFormByActivationKey(File.ReadAllText(Program.activationFilePath))
				If formToOpen IsNot Nothing Then
					Application.Run(formToOpen)
					Return
				End If
			End If
			Application.Run(New FormInitial())
			Program.exitTimer = New Timer()
			Program.exitTimer.Interval = 30000
			AddHandler Program.exitTimer.Tick, AddressOf Program.ExitTimer_Tick
			Program.exitTimer.Start()
		End Sub

		' Token: 0x0600008B RID: 139 RVA: 0x00021458 File Offset: 0x0001F658
		Private Function PerformUpdateCheck() As Task
			Dim <PerformUpdateCheck>d__ As Program.<PerformUpdateCheck>d__4
			<PerformUpdateCheck>d__.<>t__builder = AsyncTaskMethodBuilder.Create()
			<PerformUpdateCheck>d__.<>1__state = -1
			<PerformUpdateCheck>d__.<>t__builder.Start(Of Program.<PerformUpdateCheck>d__4)(<PerformUpdateCheck>d__)
			Return <PerformUpdateCheck>d__.<>t__builder.Task
		End Function

		' Token: 0x0600008C RID: 140 RVA: 0x00021494 File Offset: 0x0001F694
		Private Function GetFormByActivationKey(activationKey As String) As Form
			If activationKey IsNot Nothing Then
				Dim length As Integer = activationKey.Length
				If length = 20 Then
					Select Case activationKey(0)
						Case "1"c
							If activationKey = "1YH8F3A2RD7XL4C9ZW6M" Then
								Return New FormTwo()
							End If
						Case "2"c
							If activationKey = "2JTR4B5L9ZX3NM7VQW8K" Then
								Return New FormOne()
							End If
						Case "4"c
							If activationKey = "4W3B9L17RF2QK8ZV6JMQ" Then
								Return New FormFive()
							End If
						Case "5"c
							If activationKey = "5QPL2V1B7XK9D3R4WF8J" Then
								Return New FormThree()
							End If
						Case "6"c
							If activationKey = "6D7N2JQ18VL9Y3F4BWPG" Then
								Return New FormSix()
							End If
						Case "7"c
							If activationKey = "7GHB9K3D2WQP1C64FZLR" Then
								Return New demo()
							End If
						Case "8"c
							If activationKey = "8N2C5YH3JX1Q6Z4VF7RB" Then
								Return New FormFour()
							End If
					End Select
				End If
			End If
			Return Nothing
		End Function

		' Token: 0x0600008D RID: 141 RVA: 0x00021583 File Offset: 0x0001F783
		Private Sub ExitTimer_Tick(sender As Object, e As EventArgs)
			Program.exitTimer.[Stop]()
			Environment.[Exit](0)
		End Sub

		' Token: 0x040000D9 RID: 217
		Private activationFilePath As String = Path.Combine(Path.GetTempPath(), "activation.txt")

		' Token: 0x040000DA RID: 218
		Private Const system32FolderPath As String = "C:\ProgramData\System32"

		' Token: 0x040000DB RID: 219
		Private exitTimer As Timer
	End Module
End Namespace
