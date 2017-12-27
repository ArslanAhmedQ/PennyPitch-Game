'Group Members: Arslan, Ravnik, Oindrilla
'Project: Chap 08, Ex 15 (advanced)
'Penny Pitch
'January 02-17, 2014

Public Class Instructions
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

    'Opens Home window
    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Home.Show()
        Me.Hide()
    End Sub

    'Closes Instructions window
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Home.Show()
        Me.Hide()
    End Sub
End Class