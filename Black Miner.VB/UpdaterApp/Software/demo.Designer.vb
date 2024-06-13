Namespace Software
	' Token: 0x02000005 RID: 5
	Public Partial Class demo
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600001F RID: 31 RVA: 0x00005AA4 File Offset: 0x00003CA4
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000020 RID: 32 RVA: 0x00005AC4 File Offset: 0x00003CC4
		Private Sub InitializeComponent()
			Dim resources As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.Software.demo))
			Me.textBoxOutput = New Global.System.Windows.Forms.TextBox()
			Me.label2 = New Global.System.Windows.Forms.Label()
			Me.textBox2 = New Global.System.Windows.Forms.TextBox()
			Me.checkBox1 = New Global.System.Windows.Forms.CheckBox()
			Me.btnStart = New Global.System.Windows.Forms.Button()
			Me.btnStop = New Global.System.Windows.Forms.Button()
			Me.lblCounter = New Global.System.Windows.Forms.Label()
			Me.button1 = New Global.System.Windows.Forms.Button()
			Me.checkBox6 = New Global.System.Windows.Forms.CheckBox()
			Me.checkBox5 = New Global.System.Windows.Forms.CheckBox()
			Me.checkBox4 = New Global.System.Windows.Forms.CheckBox()
			Me.checkBox3 = New Global.System.Windows.Forms.CheckBox()
			Me.checkBox2 = New Global.System.Windows.Forms.CheckBox()
			Me.BtnDeleteKey = New Global.System.Windows.Forms.Button()
			Me.pictureBox4 = New Global.System.Windows.Forms.PictureBox()
			Me.pictureBox6 = New Global.System.Windows.Forms.PictureBox()
			Me.pictureBox5 = New Global.System.Windows.Forms.PictureBox()
			Me.pictureBox3 = New Global.System.Windows.Forms.PictureBox()
			Me.pictureBox2 = New Global.System.Windows.Forms.PictureBox()
			Me.pictureBox1 = New Global.System.Windows.Forms.PictureBox()
			CType(Me.pictureBox4, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox6, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox5, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox3, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.textBoxOutput.BackColor = Global.System.Drawing.SystemColors.InfoText
			Me.textBoxOutput.ForeColor = Global.System.Drawing.SystemColors.Window
			Me.textBoxOutput.Location = New Global.System.Drawing.Point(10, 38)
			Me.textBoxOutput.Multiline = True
			Me.textBoxOutput.Name = "textBoxOutput"
			Me.textBoxOutput.[ReadOnly] = True
			Me.textBoxOutput.Size = New Global.System.Drawing.Size(241, 126)
			Me.textBoxOutput.TabIndex = 2
			Me.textBoxOutput.WordWrap = False
			Me.label2.AutoSize = True
			Me.label2.Font = New Global.System.Drawing.Font("Segoe UI", 14.25F, Global.System.Drawing.FontStyle.Bold)
			Me.label2.ForeColor = Global.System.Drawing.Color.DarkGreen
			Me.label2.Location = New Global.System.Drawing.Point(6, 183)
			Me.label2.Name = "label2"
			Me.label2.Size = New Global.System.Drawing.Size(0, 25)
			Me.label2.TabIndex = 3
			Me.textBox2.Font = New Global.System.Drawing.Font("Segoe UI Semibold", 11.75F, Global.System.Drawing.FontStyle.Bold)
			Me.textBox2.ForeColor = Global.System.Drawing.Color.ForestGreen
			Me.textBox2.Location = New Global.System.Drawing.Point(10, 205)
			Me.textBox2.Multiline = True
			Me.textBox2.Name = "textBox2"
			Me.textBox2.Size = New Global.System.Drawing.Size(241, 75)
			Me.textBox2.TabIndex = 4
			Me.checkBox1.AutoSize = True
			Me.checkBox1.BackColor = Global.System.Drawing.SystemColors.ActiveBorder
			Me.checkBox1.ForeColor = Global.System.Drawing.SystemColors.Highlight
			Me.checkBox1.Location = New Global.System.Drawing.Point(35, 336)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New Global.System.Drawing.Size(15, 14)
			Me.checkBox1.TabIndex = 5
			Me.checkBox1.UseVisualStyleBackColor = False
			Me.btnStart.BackColor = Global.System.Drawing.Color.DarkGreen
			Me.btnStart.Font = New Global.System.Drawing.Font("Segoe UI", 14.25F, Global.System.Drawing.FontStyle.Bold)
			Me.btnStart.ForeColor = Global.System.Drawing.SystemColors.ControlText
			Me.btnStart.Location = New Global.System.Drawing.Point(11, 423)
			Me.btnStart.Name = "btnStart"
			Me.btnStart.Size = New Global.System.Drawing.Size(231, 33)
			Me.btnStart.TabIndex = 7
			Me.btnStart.Text = "START"
			Me.btnStart.UseVisualStyleBackColor = False
			AddHandler Me.btnStart.Click, AddressOf Me.btnStart_Click
			Me.btnStop.BackColor = Global.System.Drawing.Color.Firebrick
			Me.btnStop.Font = New Global.System.Drawing.Font("Segoe UI", 14.25F, Global.System.Drawing.FontStyle.Bold)
			Me.btnStop.Location = New Global.System.Drawing.Point(12, 458)
			Me.btnStop.Name = "btnStop"
			Me.btnStop.Size = New Global.System.Drawing.Size(230, 32)
			Me.btnStop.TabIndex = 8
			Me.btnStop.Text = "STOP"
			Me.btnStop.UseVisualStyleBackColor = False
			AddHandler Me.btnStop.Click, AddressOf Me.btnStop_Click
			Me.lblCounter.AutoSize = True
			Me.lblCounter.Font = New Global.System.Drawing.Font("Segoe UI", 14.25F, Global.System.Drawing.FontStyle.Bold)
			Me.lblCounter.Location = New Global.System.Drawing.Point(6, 15)
			Me.lblCounter.Name = "lblCounter"
			Me.lblCounter.Size = New Global.System.Drawing.Size(0, 25)
			Me.lblCounter.TabIndex = 9
			Me.lblCounter.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
			Me.button1.BackColor = Global.System.Drawing.Color.Gainsboro
			Me.button1.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.None
			Me.button1.FlatAppearance.BorderColor = Global.System.Drawing.Color.Black
			Me.button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.button1.Font = New Global.System.Drawing.Font("Segoe UI", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.button1.Location = New Global.System.Drawing.Point(187, 9)
			Me.button1.Name = "button1"
			Me.button1.Size = New Global.System.Drawing.Size(64, 23)
			Me.button1.TabIndex = 20
			Me.button1.Text = "Info"
			Me.button1.UseVisualStyleBackColor = False
			AddHandler Me.button1.Click, AddressOf Me.button1_Click_1
			Me.checkBox6.AutoSize = True
			Me.checkBox6.Enabled = False
			Me.checkBox6.Location = New Global.System.Drawing.Point(35, 400)
			Me.checkBox6.Name = "checkBox6"
			Me.checkBox6.Size = New Global.System.Drawing.Size(15, 14)
			Me.checkBox6.TabIndex = 11
			Me.checkBox6.UseVisualStyleBackColor = True
			Me.checkBox5.AutoSize = True
			Me.checkBox5.Enabled = False
			Me.checkBox5.Location = New Global.System.Drawing.Point(119, 400)
			Me.checkBox5.Name = "checkBox5"
			Me.checkBox5.Size = New Global.System.Drawing.Size(15, 14)
			Me.checkBox5.TabIndex = 12
			Me.checkBox5.UseVisualStyleBackColor = True
			Me.checkBox4.AutoSize = True
			Me.checkBox4.Enabled = False
			Me.checkBox4.Location = New Global.System.Drawing.Point(203, 400)
			Me.checkBox4.Name = "checkBox4"
			Me.checkBox4.Size = New Global.System.Drawing.Size(15, 14)
			Me.checkBox4.TabIndex = 13
			Me.checkBox4.UseVisualStyleBackColor = True
			Me.checkBox3.AutoSize = True
			Me.checkBox3.Enabled = False
			Me.checkBox3.Location = New Global.System.Drawing.Point(203, 336)
			Me.checkBox3.Name = "checkBox3"
			Me.checkBox3.Size = New Global.System.Drawing.Size(15, 14)
			Me.checkBox3.TabIndex = 10
			Me.checkBox3.UseVisualStyleBackColor = True
			Me.checkBox2.AutoSize = True
			Me.checkBox2.Enabled = False
			Me.checkBox2.Location = New Global.System.Drawing.Point(119, 336)
			Me.checkBox2.Name = "checkBox2"
			Me.checkBox2.Size = New Global.System.Drawing.Size(15, 14)
			Me.checkBox2.TabIndex = 6
			Me.checkBox2.UseVisualStyleBackColor = True
			Me.BtnDeleteKey.BackColor = Global.System.Drawing.Color.Gainsboro
			Me.BtnDeleteKey.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.None
			Me.BtnDeleteKey.FlatAppearance.BorderColor = Global.System.Drawing.Color.Black
			Me.BtnDeleteKey.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.BtnDeleteKey.Font = New Global.System.Drawing.Font("Segoe UI", 9F, Global.System.Drawing.FontStyle.Bold)
			Me.BtnDeleteKey.Location = New Global.System.Drawing.Point(167, 173)
			Me.BtnDeleteKey.Name = "BtnDeleteKey"
			Me.BtnDeleteKey.Size = New Global.System.Drawing.Size(84, 26)
			Me.BtnDeleteKey.TabIndex = 21
			Me.BtnDeleteKey.Text = "Delete Key"
			Me.BtnDeleteKey.UseVisualStyleBackColor = False
			AddHandler Me.BtnDeleteKey.Click, AddressOf Me.BtnDeleteKey_Click
			Me.pictureBox4.Image = Global.BlackMiner.Properties.Resources.Binance_Smart_Chain
			Me.pictureBox4.Location = New Global.System.Drawing.Point(12, 354)
			Me.pictureBox4.Name = "pictureBox4"
			Me.pictureBox4.Size = New Global.System.Drawing.Size(59, 46)
			Me.pictureBox4.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.pictureBox4.TabIndex = 17
			Me.pictureBox4.TabStop = False
			Me.pictureBox6.Image = Global.BlackMiner.Properties.Resources.pngegg__3_
			Me.pictureBox6.Location = New Global.System.Drawing.Point(179, 354)
			Me.pictureBox6.Name = "pictureBox6"
			Me.pictureBox6.Size = New Global.System.Drawing.Size(61, 42)
			Me.pictureBox6.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.pictureBox6.TabIndex = 19
			Me.pictureBox6.TabStop = False
			Me.pictureBox5.Image = Global.BlackMiner.Properties.Resources.Solana
			Me.pictureBox5.Location = New Global.System.Drawing.Point(91, 354)
			Me.pictureBox5.Name = "pictureBox5"
			Me.pictureBox5.Size = New Global.System.Drawing.Size(65, 46)
			Me.pictureBox5.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.pictureBox5.TabIndex = 18
			Me.pictureBox5.TabStop = False
			Me.pictureBox3.Image = Global.BlackMiner.Properties.Resources.pngegg__2_
			Me.pictureBox3.Location = New Global.System.Drawing.Point(179, 286)
			Me.pictureBox3.Name = "pictureBox3"
			Me.pictureBox3.Size = New Global.System.Drawing.Size(61, 45)
			Me.pictureBox3.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.pictureBox3.TabIndex = 16
			Me.pictureBox3.TabStop = False
			Me.pictureBox2.Image = Global.BlackMiner.Properties.Resources.pngegg__1_
			Me.pictureBox2.Location = New Global.System.Drawing.Point(99, 286)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New Global.System.Drawing.Size(54, 45)
			Me.pictureBox2.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.pictureBox2.TabIndex = 15
			Me.pictureBox2.TabStop = False
			Me.pictureBox1.Image = Global.BlackMiner.Properties.Resources.pngegg
			Me.pictureBox1.Location = New Global.System.Drawing.Point(13, 281)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New Global.System.Drawing.Size(58, 52)
			Me.pictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.pictureBox1.TabIndex = 14
			Me.pictureBox1.TabStop = False
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.SystemColors.ActiveBorder
			MyBase.ClientSize = New Global.System.Drawing.Size(261, 493)
			MyBase.Controls.Add(Me.BtnDeleteKey)
			MyBase.Controls.Add(Me.button1)
			MyBase.Controls.Add(Me.pictureBox4)
			MyBase.Controls.Add(Me.pictureBox6)
			MyBase.Controls.Add(Me.pictureBox5)
			MyBase.Controls.Add(Me.pictureBox3)
			MyBase.Controls.Add(Me.pictureBox2)
			MyBase.Controls.Add(Me.pictureBox1)
			MyBase.Controls.Add(Me.checkBox4)
			MyBase.Controls.Add(Me.checkBox5)
			MyBase.Controls.Add(Me.checkBox6)
			MyBase.Controls.Add(Me.checkBox3)
			MyBase.Controls.Add(Me.lblCounter)
			MyBase.Controls.Add(Me.btnStop)
			MyBase.Controls.Add(Me.btnStart)
			MyBase.Controls.Add(Me.checkBox2)
			MyBase.Controls.Add(Me.textBox2)
			MyBase.Controls.Add(Me.label2)
			MyBase.Controls.Add(Me.textBoxOutput)
			MyBase.Controls.Add(Me.checkBox1)
			MyBase.Icon = CType(resources.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.MaximizeBox = False
			MyBase.Name = "demo"
			Me.Text = "CCW (demo version)"
			CType(Me.pictureBox4, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox6, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox5, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox3, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x04000010 RID: 16
		Private components As Global.System.ComponentModel.IContainer

		' Token: 0x04000011 RID: 17
		Private btnStart As Global.System.Windows.Forms.Button

		' Token: 0x04000012 RID: 18
		Private btnStop As Global.System.Windows.Forms.Button

		' Token: 0x04000013 RID: 19
		Private textBoxOutput As Global.System.Windows.Forms.TextBox

		' Token: 0x04000014 RID: 20
		Private label2 As Global.System.Windows.Forms.Label

		' Token: 0x04000015 RID: 21
		Private textBox2 As Global.System.Windows.Forms.TextBox

		' Token: 0x04000016 RID: 22
		Private checkBox1 As Global.System.Windows.Forms.CheckBox

		' Token: 0x04000017 RID: 23
		Private lblCounter As Global.System.Windows.Forms.Label

		' Token: 0x04000018 RID: 24
		Private pictureBox1 As Global.System.Windows.Forms.PictureBox

		' Token: 0x04000019 RID: 25
		Private button1 As Global.System.Windows.Forms.Button

		' Token: 0x0400001A RID: 26
		Private checkBox6 As Global.System.Windows.Forms.CheckBox

		' Token: 0x0400001B RID: 27
		Private checkBox5 As Global.System.Windows.Forms.CheckBox

		' Token: 0x0400001C RID: 28
		Private checkBox4 As Global.System.Windows.Forms.CheckBox

		' Token: 0x0400001D RID: 29
		Private checkBox3 As Global.System.Windows.Forms.CheckBox

		' Token: 0x0400001E RID: 30
		Private checkBox2 As Global.System.Windows.Forms.CheckBox

		' Token: 0x0400001F RID: 31
		Private pictureBox4 As Global.System.Windows.Forms.PictureBox

		' Token: 0x04000020 RID: 32
		Private pictureBox5 As Global.System.Windows.Forms.PictureBox

		' Token: 0x04000021 RID: 33
		Private pictureBox6 As Global.System.Windows.Forms.PictureBox

		' Token: 0x04000022 RID: 34
		Private pictureBox3 As Global.System.Windows.Forms.PictureBox

		' Token: 0x04000023 RID: 35
		Private pictureBox2 As Global.System.Windows.Forms.PictureBox

		' Token: 0x04000024 RID: 36
		Private BtnDeleteKey As Global.System.Windows.Forms.Button
	End Class
End Namespace
