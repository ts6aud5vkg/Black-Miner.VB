Imports System
Imports System.CodeDom.Compiler
Imports System.Configuration
Imports System.Runtime.CompilerServices

Namespace Black_Miner.Properties
	' Token: 0x02000004 RID: 4
	<CompilerGenerated()>
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")>
	Friend NotInheritable Partial Class Settings
		Inherits ApplicationSettingsBase

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x06000008 RID: 8 RVA: 0x000021FB File Offset: 0x000003FB
		Public Shared ReadOnly Property [Default] As Settings
			Get
				Return Settings.defaultInstance
			End Get
		End Property

		' Token: 0x04000004 RID: 4
		Private Shared defaultInstance As Settings = CType(SettingsBase.Synchronized(New Settings()), Settings)
	End Class
End Namespace
