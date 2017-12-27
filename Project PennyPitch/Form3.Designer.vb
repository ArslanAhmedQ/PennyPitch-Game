<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PennyPitch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNamePrompt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTossPennies = New System.Windows.Forms.Button()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnQuitGame = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(32, 36)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(500, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.NewGameToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ExitToolStripMenuItem.Text = "Quit Game"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(274, 41)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 13)
        Me.lblName.TabIndex = 2
        '
        'lblNamePrompt
        '
        Me.lblNamePrompt.AutoSize = True
        Me.lblNamePrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamePrompt.Location = New System.Drawing.Point(192, 41)
        Me.lblNamePrompt.Name = "lblNamePrompt"
        Me.lblNamePrompt.Size = New System.Drawing.Size(82, 13)
        Me.lblNamePrompt.TabIndex = 3
        Me.lblNamePrompt.Text = "Player Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Prizes won:"
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(347, 236)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(61, 20)
        Me.Button21.TabIndex = 54
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Location = New System.Drawing.Point(347, 210)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(61, 20)
        Me.Button22.TabIndex = 53
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Location = New System.Drawing.Point(347, 184)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(61, 20)
        Me.Button23.TabIndex = 52
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(347, 156)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(61, 20)
        Me.Button24.TabIndex = 51
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.Location = New System.Drawing.Point(347, 130)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(61, 20)
        Me.Button25.TabIndex = 50
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(280, 236)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(61, 20)
        Me.Button16.TabIndex = 49
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(280, 210)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(61, 20)
        Me.Button17.TabIndex = 48
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(280, 184)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(61, 20)
        Me.Button18.TabIndex = 47
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(280, 156)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(61, 20)
        Me.Button19.TabIndex = 46
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(280, 130)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(61, 20)
        Me.Button20.TabIndex = 45
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(213, 236)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(61, 20)
        Me.Button11.TabIndex = 44
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(213, 210)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(61, 20)
        Me.Button12.TabIndex = 43
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(213, 184)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(61, 20)
        Me.Button13.TabIndex = 42
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(213, 156)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(61, 20)
        Me.Button14.TabIndex = 41
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(213, 130)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(61, 20)
        Me.Button15.TabIndex = 40
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(146, 236)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(61, 20)
        Me.Button6.TabIndex = 39
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(146, 210)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(61, 20)
        Me.Button7.TabIndex = 38
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(146, 184)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(61, 20)
        Me.Button8.TabIndex = 37
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(146, 156)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(61, 20)
        Me.Button9.TabIndex = 36
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(146, 130)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(61, 20)
        Me.Button10.TabIndex = 35
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(79, 236)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(61, 20)
        Me.Button5.TabIndex = 34
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(79, 210)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(61, 20)
        Me.Button4.TabIndex = 33
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(79, 184)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(61, 20)
        Me.Button3.TabIndex = 32
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(79, 156)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 20)
        Me.Button2.TabIndex = 31
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(79, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 20)
        Me.Button1.TabIndex = 30
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTossPennies
        '
        Me.btnTossPennies.Location = New System.Drawing.Point(320, 104)
        Me.btnTossPennies.Name = "btnTossPennies"
        Me.btnTossPennies.Size = New System.Drawing.Size(88, 20)
        Me.btnTossPennies.TabIndex = 29
        Me.btnTossPennies.Text = "Toss Pennies"
        Me.btnTossPennies.UseVisualStyleBackColor = True
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(79, 104)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(74, 20)
        Me.btnNewGame.TabIndex = 28
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'btnQuitGame
        '
        Me.btnQuitGame.Location = New System.Drawing.Point(365, 41)
        Me.btnQuitGame.Name = "btnQuitGame"
        Me.btnQuitGame.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitGame.TabIndex = 56
        Me.btnQuitGame.Text = "Quit Game"
        Me.btnQuitGame.UseVisualStyleBackColor = True
        '
        'PennyPitch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(500, 338)
        Me.Controls.Add(Me.btnQuitGame)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnTossPennies)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.lblNamePrompt)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PennyPitch"
        Me.Text = "Penny Pitch"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblNamePrompt As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnTossPennies As System.Windows.Forms.Button
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents btnQuitGame As System.Windows.Forms.Button
End Class
