Namespace Software
	' Token: 0x0200000D RID: 13
	Public Partial Class info
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000088 RID: 136 RVA: 0x00020C09 File Offset: 0x0001EE09
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000089 RID: 137 RVA: 0x00020C28 File Offset: 0x0001EE28
		Private Sub InitializeComponent()
			Me.label1 = New Global.System.Windows.Forms.Label()
			Me.label2 = New Global.System.Windows.Forms.Label()
			Me.label3 = New Global.System.Windows.Forms.Label()
			Me.label4 = New Global.System.Windows.Forms.Label()
			Me.label5 = New Global.System.Windows.Forms.Label()
			Me.label6 = New Global.System.Windows.Forms.Label()
			Me.label7 = New Global.System.Windows.Forms.Label()
			Me.label8 = New Global.System.Windows.Forms.Label()
			Me.label9 = New Global.System.Windows.Forms.Label()
			Me.label10 = New Global.System.Windows.Forms.Label()
			Me.button1 = New Global.System.Windows.Forms.Button()
			MyBase.SuspendLayout()
			Me.label1.AutoSize = True
			Me.label1.Font = New Global.System.Drawing.Font("Segoe UI", 12F, Global.System.Drawing.FontStyle.Bold)
			Me.label1.Location = New Global.System.Drawing.Point(10, 8)
			Me.label1.Name = "label1"
			Me.label1.Size = New Global.System.Drawing.Size(300, 21)
			Me.label1.TabIndex = 0
			Me.label1.Text = "You have activated the FREE trial key!!"
			Me.label2.AutoSize = True
			Me.label2.Font = New Global.System.Drawing.Font("Segoe UI", 12F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic)
			Me.label2.Location = New Global.System.Drawing.Point(10, 36)
			Me.label2.Name = "label2"
			Me.label2.Size = New Global.System.Drawing.Size(330, 42)
			Me.label2.TabIndex = 1
			Me.label2.Text = "What's the difference between Free verison " & vbCrLf & "and Full version !?"
			Me.label3.AutoSize = True
			Me.label3.Font = New Global.System.Drawing.Font("Segoe UI", 9.75F, Global.System.Drawing.FontStyle.Bold)
			Me.label3.Location = New Global.System.Drawing.Point(75, 82)
			Me.label3.Name = "label3"
			Me.label3.Size = New Global.System.Drawing.Size(174, 187)
			Me.label3.TabIndex = 2
			Me.label3.Text = "FREE VERSION:" & vbCrLf & "  1 blockchain (Bitcoin) " & vbCrLf & "  600,000 checks per day " & vbCrLf & "  No Withdrawals " & vbCrLf & "  No Updates" & vbCrLf & vbCrLf & "FULL VERSION:" & vbCrLf & "  6 blockchains" & vbCrLf & "  60,000,000 checks per day" & vbCrLf & "  Withdrawals" & vbCrLf & "  Updates"
			Me.label4.AutoSize = True
			Me.label4.Font = New Global.System.Drawing.Font("Segoe UI", 9.75F, Global.System.Drawing.FontStyle.Bold)
			Me.label4.ForeColor = Global.System.Drawing.Color.Maroon
			Me.label4.Location = New Global.System.Drawing.Point(68, 97)
			Me.label4.Name = "label4"
			Me.label4.Size = New Global.System.Drawing.Size(17, 68)
			Me.label4.TabIndex = 3
			Me.label4.Text = "X" & vbCrLf & "X" & vbCrLf & "X" & vbCrLf & "X" & vbCrLf
			Me.label5.AutoSize = True
			Me.label5.Font = New Global.System.Drawing.Font("Segoe UI", 9.75F, Global.System.Drawing.FontStyle.Bold)
			Me.label5.ForeColor = Global.System.Drawing.Color.DarkGreen
			Me.label5.Location = New Global.System.Drawing.Point(68, 185)
			Me.label5.Name = "label5"
			Me.label5.Size = New Global.System.Drawing.Size(19, 68)
			Me.label5.TabIndex = 4
			Me.label5.Text = "✓" & vbCrLf & "✓" & vbCrLf & "✓" & vbCrLf & "✓"
			Me.label6.AutoSize = True
			Me.label6.Font = New Global.System.Drawing.Font("Segoe UI", 12F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic)
			Me.label6.Location = New Global.System.Drawing.Point(10, 257)
			Me.label6.Name = "label6"
			Me.label6.Size = New Global.System.Drawing.Size(299, 21)
			Me.label6.TabIndex = 5
			Me.label6.Text = "How does FREE version found look like?"
			Me.label7.AutoSize = True
			Me.label7.Font = New Global.System.Drawing.Font("Segoe UI", 12F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic)
			Me.label7.Location = New Global.System.Drawing.Point(10, 304)
			Me.label7.Name = "label7"
			Me.label7.Size = New Global.System.Drawing.Size(301, 21)
			Me.label7.TabIndex = 6
			Me.label7.Text = "How does FULL version found look like?"
			Me.label8.AutoSize = True
			Me.label8.Font = New Global.System.Drawing.Font("Segoe UI", 12F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Underline)
			Me.label8.ForeColor = Global.System.Drawing.Color.FromArgb(0, 192, 0)
			Me.label8.Location = New Global.System.Drawing.Point(10, 275)
			Me.label8.Name = "label8"
			Me.label8.Size = New Global.System.Drawing.Size(247, 21)
			Me.label8.TabIndex = 7
			Me.label8.Text = "btc 0.01339 = 883.74$ | LOCKED"
			Me.label9.AutoSize = True
			Me.label9.Font = New Global.System.Drawing.Font("Segoe UI", 12F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Underline)
			Me.label9.ForeColor = Global.System.Drawing.Color.FromArgb(0, 192, 0)
			Me.label9.Location = New Global.System.Drawing.Point(10, 322)
			Me.label9.Name = "label9"
			Me.label9.Size = New Global.System.Drawing.Size(356, 21)
			Me.label9.TabIndex = 8
			Me.label9.Text = "btc 0.01339 = 883.74$ | chain offer person yea"
			Me.label10.AutoSize = True
			Me.label10.Font = New Global.System.Drawing.Font("Segoe UI Black", 14F, Global.System.Drawing.FontStyle.Bold)
			Me.label10.ForeColor = Global.System.Drawing.Color.Red
			Me.label10.Location = New Global.System.Drawing.Point(37, 359)
			Me.label10.Name = "label10"
			Me.label10.Size = New Global.System.Drawing.Size(219, 25)
			Me.label10.TabIndex = 9
			Me.label10.Text = "WANT FULL VERSION?"
			Me.button1.BackColor = Global.System.Drawing.Color.DarkTurquoise
			Me.button1.Font = New Global.System.Drawing.Font("Segoe UI", 9.75F, Global.System.Drawing.FontStyle.Bold)
			Me.button1.Location = New Global.System.Drawing.Point(75, 391)
			Me.button1.Name = "button1"
			Me.button1.Size = New Global.System.Drawing.Size(112, 26)
			Me.button1.TabIndex = 10
			Me.button1.Text = "CONTACT US"
			Me.button1.UseVisualStyleBackColor = False
			AddHandler Me.button1.Click, AddressOf Me.button1_Click
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(309, 441)
			MyBase.Controls.Add(Me.button1)
			MyBase.Controls.Add(Me.label10)
			MyBase.Controls.Add(Me.label9)
			MyBase.Controls.Add(Me.label8)
			MyBase.Controls.Add(Me.label7)
			MyBase.Controls.Add(Me.label6)
			MyBase.Controls.Add(Me.label5)
			MyBase.Controls.Add(Me.label4)
			MyBase.Controls.Add(Me.label2)
			MyBase.Controls.Add(Me.label1)
			MyBase.Controls.Add(Me.label3)
			MyBase.MaximizeBox = False
			MyBase.Name = "info"
			MyBase.ShowIcon = False
			Me.Text = "info"
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040000CD RID: 205
		Private components As Global.System.ComponentModel.IContainer

		' Token: 0x040000CE RID: 206
		Private label1 As Global.System.Windows.Forms.Label

		' Token: 0x040000CF RID: 207
		Private label2 As Global.System.Windows.Forms.Label

		' Token: 0x040000D0 RID: 208
		Private label3 As Global.System.Windows.Forms.Label

		' Token: 0x040000D1 RID: 209
		Private label4 As Global.System.Windows.Forms.Label

		' Token: 0x040000D2 RID: 210
		Private label5 As Global.System.Windows.Forms.Label

		' Token: 0x040000D3 RID: 211
		Private label6 As Global.System.Windows.Forms.Label

		' Token: 0x040000D4 RID: 212
		Private label7 As Global.System.Windows.Forms.Label

		' Token: 0x040000D5 RID: 213
		Private label8 As Global.System.Windows.Forms.Label

		' Token: 0x040000D6 RID: 214
		Private label9 As Global.System.Windows.Forms.Label

		' Token: 0x040000D7 RID: 215
		Private label10 As Global.System.Windows.Forms.Label

		' Token: 0x040000D8 RID: 216
		Private button1 As Global.System.Windows.Forms.Button
	End Class
End Namespace
