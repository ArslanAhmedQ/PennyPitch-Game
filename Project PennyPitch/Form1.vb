'Group Members: Arslan, Ravnik, Oindrilla
'Project: Chap 08, Ex 15 (advanced)
'Penny Pitch
'January 02-17, 2014


Public Class Home

    'This application simulates the penny pitch game. When New Game is clicked, it randomly marks a 5 x 5 board 
    'of 25 buttons w/prizes of puzzle, game, ball, poster, and doll. Each prize appears on 3 randomly chosen 
    'squares so that 15 squares contain prizes. Clicking Toss Pennies simulates ten pennies being randomly 
    'pitched onto the board. Each penny is rep. by an "x" character on a square. If all of the squares say Ball 
    'or any other prize in them are covered by a penny, the player wins a that prize. Clicking Toss Pennies 
    'shows where the ten pennies landed and displays a list of the prizes won or "No prizes".
    '

    'Opens New Game Window
    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGame.Click
        PennyPitch.Show()
        Me.Hide()
    End Sub
    Private Sub NewGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewGameToolStripMenuItem.Click
        PennyPitch.Show()
        Me.Hide()
    End Sub

    'Opens Instructions Window
    Private Sub btnInstructions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstructions.Click
        Instructions.Show()
        Me.Hide()
    End Sub
    Private Sub InstructionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstructionsToolStripMenuItem.Click
        Instructions.Show()
        Me.Hide()
    End Sub

    'Closes game application completely 
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Shows Message Box for help
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        MessageBox.Show("This program application is created and developed by " _
                        & vbCrLf & "Arslan" & vbCrLf & "Oindrilla" & vbCrLf & "Ravnik" & vbCrLf & vbCrLf & _
                        "Please contact us at support@pennypitch.com", "Help")

    End Sub

    'Disables the New game button until the name is inputed in the textbox.
    Private Sub txtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged
        btnNewGame.Enabled = True
        NewGameToolStripMenuItem.Enabled = True
    End Sub
End Class

