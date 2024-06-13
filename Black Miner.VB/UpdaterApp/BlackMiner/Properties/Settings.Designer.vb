Imports System
Imports System.CodeDom.Compiler
Imports System.Configuration
Imports System.Runtime.CompilerServices

Namespace BlackMiner.Properties
	' Token: 0x02000004 RID: 4
	<CompilerGenerated()>
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")>
	Friend NotInheritable Partial Class Settings
		Inherits ApplicationSettingsBase

		' Token: 0x17000009 RID: 9
		' (get) Token: 0x0600000E RID: 14 RVA: 0x00002196 File Offset: 0x00000396
		Public Shared ReadOnly Property [Default] As Settings
			Get
				Return Settings.defaultInstance
			End Get
		End Property

		' Token: 0x04000004 RID: 4
		Private Shared defaultInstance As Settings = CType(SettingsBase.Synchronized(New Settings()), Settings)
	End Class
End Namespace
