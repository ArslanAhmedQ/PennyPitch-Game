<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighScore
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
        Me.lstHighScore = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstHighScore
        '
        Me.lstHighScore.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lstHighScore.FormattingEnabled = True
        Me.lstHighScore.Location = New System.Drawing.Point(46, 21)
        Me.lstHighScore.Name = "lstHighScore"
        Me.lstHighScore.Size = New System.Drawing.Size(269, 251)
        Me.lstHighScore.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(148, 294)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'HighScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(387, 340)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lstHighScore)
        Me.Name = "HighScore"
        Me.Text = "High Scores"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstHighScore As System.Windows.Forms.ListBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
