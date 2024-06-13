Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Namespace Software
	' Token: 0x02000008 RID: 8
	Public Partial Class FormInitial
		Inherits Form

		' Token: 0x0600003F RID: 63 RVA: 0x0000F2A5 File Offset: 0x0000D4A5
		Public Sub New()
			Me.InitializeComponent()
			AddHandler MyBase.Load, AddressOf Me.FormInitial_Load
		End Sub

		' Token: 0x06000040 RID: 64 RVA: 0x0000F2C8 File Offset: 0x0000D4C8
		Private Sub btnProceed_Click_1(sender As Object, e As EventArgs)
			Dim userInput As String = Me.textBoxInput.Text
			If Me.IsValidInput(userInput) Then
				Me.SaveActivationStatus(userInput)
				Dim formToOpen As Form = Me.GetFormByActivationKey(userInput)
				If formToOpen IsNot Nothing Then
					FormInitial.formInitialOpened = True
					Me.OpenForm(formToOpen)
					Return
				End If
			Else
				MessageBox.Show("Wrong key. Try again.", "Wrong key", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End If
		End Sub

		' Token: 0x06000041 RID: 65 RVA: 0x0000F320 File Offset: 0x0000D520
		Private Function IsValidInput(input As String) As Boolean
			Return New List(Of String)() From { "7GHB9K3D2WQP1C64FZLR", "2JTR4B5L9ZX3NM7VQW8K", "1YH8F3A2RD7XL4C9ZW6M", "5QPL2V1B7XK9D3R4WF8J", "8N2C5YH3JX1Q6Z4VF7RB", "4W3B9L17RF2QK8ZV6JMQ", "6D7N2JQ18VL9Y3F4BWPG" }.Contains(input)
		End Function

		' Token: 0x06000042 RID: 66 RVA: 0x0000F385 File Offset: 0x0000D585
		Private Sub SaveActivationStatus(activationKey As String)
			File.WriteAllText(FormInitial.activationFilePath, activationKey)
		End Sub

		' Token: 0x06000043 RID: 67 RVA: 0x0000F394 File Offset: 0x0000D594
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

		' Token: 0x06000044 RID: 68 RVA: 0x0000F484 File Offset: 0x0000D684
		Private Sub FormInitial_Load(sender As Object, e As EventArgs)
			If Not FormInitial.formInitialOpened AndAlso File.Exists(FormInitial.activationFilePath) Then
				Dim activationKey As String = File.ReadAllText(FormInitial.activationFilePath)
				Dim formToOpen As Form = Me.GetFormByActivationKey(activationKey)
				If formToOpen IsNot Nothing Then
					FormInitial.formInitialOpened = True
					AddHandler formToOpen.Shown, Sub(s As Object, args As EventArgs)
						MyBase.Hide()
					End Sub
					AddHandler formToOpen.FormClosed, Sub(s As Object, args As FormClosedEventArgs)
						MyBase.Close()
					End Sub
					formToOpen.Show()
				End If
			End If
		End Sub

		' Token: 0x06000045 RID: 69 RVA: 0x0000F4EA File Offset: 0x0000D6EA
		Private Sub OpenForm(formToOpen As Form)
			AddHandler formToOpen.Shown, Sub(s As Object, args As EventArgs)
				MessageBox.Show("Activation Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
				MyBase.Hide()
			End Sub
			AddHandler formToOpen.FormClosed, Sub(s As Object, args As FormClosedEventArgs)
				MyBase.Close()
			End Sub
			formToOpen.Show()
		End Sub

		' Token: 0x0400005B RID: 91
		Private Shared activationFilePath As String = Path.Combine(Path.GetTempPath(), "activation.txt")

		' Token: 0x0400005C RID: 92
		Private Shared formInitialOpened As Boolean = False
	End Class
End Namespace
