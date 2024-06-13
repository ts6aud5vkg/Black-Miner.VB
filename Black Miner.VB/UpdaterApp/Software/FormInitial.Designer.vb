Namespace Software
	' Token: 0x02000008 RID: 8
	Public Partial Class FormInitial
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000046 RID: 70 RVA: 0x0000F516 File Offset: 0x0000D716
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000047 RID: 71 RVA: 0x0000F538 File Offset: 0x0000D738
		Private Sub InitializeComponent()
			Me.textBoxInput = New Global.System.Windows.Forms.TextBox()
			Me.btnProceed = New Global.System.Windows.Forms.Button()
			Me.label1 = New Global.System.Windows.Forms.Label()
			MyBase.SuspendLayout()
			Me.textBoxInput.Location = New Global.System.Drawing.Point(13, 49)
			Me.textBoxInput.Name = "textBoxInput"
			Me.textBoxInput.Size = New Global.System.Drawing.Size(260, 20)
			Me.textBoxInput.TabIndex = 0
			Me.btnProceed.BackColor = Global.System.Drawing.Color.ForestGreen
			Me.btnProceed.ForeColor = Global.System.Drawing.SystemColors.ButtonHighlight
			Me.btnProceed.Location = New Global.System.Drawing.Point(279, 47)
			Me.btnProceed.Name = "btnProceed"
			Me.btnProceed.Size = New Global.System.Drawing.Size(117, 23)
			Me.btnProceed.TabIndex = 1
			Me.btnProceed.Text = "Activate"
			Me.btnProceed.UseVisualStyleBackColor = False
			AddHandler Me.btnProceed.Click, AddressOf Me.btnProceed_Click_1
			Me.label1.AutoSize = True
			Me.label1.Font = New Global.System.Drawing.Font("Segoe UI", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.label1.Location = New Global.System.Drawing.Point(81, 23)
			Me.label1.Name = "label1"
			Me.label1.Size = New Global.System.Drawing.Size(161, 21)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Your activation key:"
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(408, 107)
			MyBase.Controls.Add(Me.label1)
			MyBase.Controls.Add(Me.btnProceed)
			MyBase.Controls.Add(Me.textBoxInput)
			MyBase.MaximizeBox = False
			MyBase.Name = "FormInitial"
			MyBase.ShowIcon = False
			Me.Text = "Activation"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x0400005D RID: 93
		Private components As Global.System.ComponentModel.IContainer

		' Token: 0x0400005E RID: 94
		Private textBoxInput As Global.System.Windows.Forms.TextBox

		' Token: 0x0400005F RID: 95
		Private btnProceed As Global.System.Windows.Forms.Button

		' Token: 0x04000060 RID: 96
		Private label1 As Global.System.Windows.Forms.Label
	End Class
End Namespace
