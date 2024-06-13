Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices

Namespace BlackMiner.Properties
	' Token: 0x02000003 RID: 3
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")>
	<DebuggerNonUserCode()>
	<CompilerGenerated()>
	Friend Class Resources
		' Token: 0x06000004 RID: 4 RVA: 0x000020B1 File Offset: 0x000002B1
		Friend Sub New()
		End Sub

		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000005 RID: 5 RVA: 0x000020B9 File Offset: 0x000002B9
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Shared ReadOnly Property ResourceManager As ResourceManager
			Get
				If Resources.resourceMan Is Nothing Then
					Resources.resourceMan = New ResourceManager("BlackMiner.Properties.Resources", GetType(Resources).Assembly)
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000006 RID: 6 RVA: 0x000020E5 File Offset: 0x000002E5
		' (set) Token: 0x06000007 RID: 7 RVA: 0x000020EC File Offset: 0x000002EC
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Shared Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x06000008 RID: 8 RVA: 0x000020F4 File Offset: 0x000002F4
		Friend Shared ReadOnly Property Binance_Smart_Chain As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("Binance Smart Chain", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x06000009 RID: 9 RVA: 0x0000210F File Offset: 0x0000030F
		Friend Shared ReadOnly Property pngegg As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("pngegg", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000A RID: 10 RVA: 0x0000212A File Offset: 0x0000032A
		Friend Shared ReadOnly Property pngegg__1_ As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("pngegg (1)", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000006 RID: 6
		' (get) Token: 0x0600000B RID: 11 RVA: 0x00002145 File Offset: 0x00000345
		Friend Shared ReadOnly Property pngegg__2_ As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("pngegg (2)", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000007 RID: 7
		' (get) Token: 0x0600000C RID: 12 RVA: 0x00002160 File Offset: 0x00000360
		Friend Shared ReadOnly Property pngegg__3_ As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("pngegg (3)", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x17000008 RID: 8
		' (get) Token: 0x0600000D RID: 13 RVA: 0x0000217B File Offset: 0x0000037B
		Friend Shared ReadOnly Property Solana As Bitmap
			Get
				Return CType(Resources.ResourceManager.GetObject("Solana", Resources.resourceCulture), Bitmap)
			End Get
		End Property

		' Token: 0x04000002 RID: 2
		Private Shared resourceMan As ResourceManager

		' Token: 0x04000003 RID: 3
		Private Shared resourceCulture As CultureInfo
	End Class
End Namespace
