Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices

Namespace Black_Miner.Properties
	' Token: 0x02000003 RID: 3
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
	<DebuggerNonUserCode()>
	<CompilerGenerated()>
	Friend Class Resources
		' Token: 0x06000004 RID: 4 RVA: 0x000021B8 File Offset: 0x000003B8
		Friend Sub New()
		End Sub

		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000005 RID: 5 RVA: 0x000021C0 File Offset: 0x000003C0
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Shared ReadOnly Property ResourceManager As ResourceManager
			Get
				If Resources.resourceMan Is Nothing Then
					Resources.resourceMan = New ResourceManager("Black_Miner.Properties.Resources", GetType(Resources).Assembly)
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000006 RID: 6 RVA: 0x000021EC File Offset: 0x000003EC
		' (set) Token: 0x06000007 RID: 7 RVA: 0x000021F3 File Offset: 0x000003F3
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Shared Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x04000002 RID: 2
		Private Shared resourceMan As ResourceManager

		' Token: 0x04000003 RID: 3
		Private Shared resourceCulture As CultureInfo
	End Class
End Namespace
