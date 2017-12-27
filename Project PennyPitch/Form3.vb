'Group Members: Arslan, Ravnik, Oindrilla
'Project: Chap 08, Ex 15 (advanced)
'Penny Pitch
'January 02-17, 2014

Imports System.IO
Public Class PennyPitch
    'This application simulates the penny pitch game. When New Game is clicked, it randomly marks a 5 x 5 board 
    'of 25 buttons w/prizes of puzzle, game, ball, poster, and doll. Each prize appears on 3 randomly chosen 
    'squares so that 15 squares contain prizes. Clicking Toss Pennies simulates ten pennies being randomly 
    'pitched onto the board. Each penny is rep. by an "x" character on a square. If all of the squares say Ball 
    'or any other prize in them are covered by a penny, the player wins a that prize. Clicking Toss Pennies 
    'shows where the ten pennies landed and displays a list of the prizes won or "No prizes".
    '
    'pre: Player enters name and chooses Instructions or New Game. When, Toss Pennies is clicked, the player tosses 
    'the ten pennies at random from clicking the toss pennies button.
    'post: Each penny is rep. by an "x" character. If all the squares say a one specific prize from the prizes:
    'ball, poster, or doll then it will display a list of the prizes won or "No prizes".
    '


    Public names As String = Nothing

    Dim winScores As Integer
    'post:Opens Home window
    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        Home.Show()
        Me.Hide()
    End Sub

    'Post: Prompts the user to exit or enter a high score. 
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        PromptHighScore.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuitGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitGame.Click
        PromptHighScore.Show()
        Me.Hide()
    End Sub

    'Post: Shows the player's name in lblName
    Private Sub PennyPitch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        names = Home.txtUserName.Text
        Me.lblName.Text = names
    End Sub

    Dim randomBtn As Integer

    Dim prizeTypes() As String = {"puzzle", "ball", "game", "poster", "doll"}
    'pre: button text must be string
    'post: outputs buttons labelled with each of the five prizes three times, enables users ability to toss pennies to win a poster
    Private Sub btnNewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewGame.Click
        Dim btnArray() As Button = {Me.Button1, Me.Button2, Me.Button3, Me.Button4, Me.Button5, Me.Button6, Me.Button7, Me.Button8, Me.Button9, Me.Button10, Me.Button11, Me.Button12, Me.Button13, Me.Button14, Me.Button15, Me.Button16, Me.Button17, Me.Button18, Me.Button19, Me.Button20, Me.Button21, Me.Button22, Me.Button23, Me.Button24, Me.Button25}
        For clearTimes As Integer = 0 To 24
            If btnArray(clearTimes).Text <> Nothing Then
                btnArray(clearTimes).Text = Nothing
            End If
        Next
        For prizeTypeOutput As Integer = 0 To 4
            For outputTimes As Integer = 0 To 3
                randomBtn = Int(24 * Rnd())
                btnArray(randomBtn).Text = prizeTypes(prizeTypeOutput)
            Next
        Next
        btnTossPennies.Enabled = True
    End Sub
    '
    'pre: Player enters name and chooses Instructions or New Game. When, Toss Pennies is clicked, the player tosses 
    'the ten pennies at random from clicking the toss pennies button.
    'post: Each penny is rep. by an "x" character. If all the squares say a one specific prize from the prizes:
    'ball, poster, or doll then it will display a list of the prizes won or "No prizes".
    '
    Private Sub btnTossPennies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTossPennies.Click
        Dim winOrLoose As Integer = Int(2 * Rnd())
        Dim btnArray() As Button = {Me.Button1, Me.Button2, Me.Button3, Me.Button4, Me.Button5, Me.Button6, Me.Button7, Me.Button8, Me.Button9, Me.Button10, Me.Button11, Me.Button12, Me.Button13, Me.Button14, Me.Button15, Me.Button16, Me.Button17, Me.Button18, Me.Button19, Me.Button20, Me.Button21, Me.Button22, Me.Button23, Me.Button24, Me.Button25}
        Dim clearString As String
        Dim puzzleCount As Integer
        Dim ballCount As Integer
        Dim gameCount As Integer
        Dim posterCount As Integer
        Dim dollCount As Integer

        For clearTimes As Integer = 0 To 24                    'clears past results everytime button is clicked so that
            clearString = btnArray(clearTimes).Text             'can try to test their luck for winning a prize again
            If clearString.IndexOf("x") > -1 Then               'and again
                btnArray(clearTimes).Text = clearString.Replace("x", "")
            End If
        Next

        If winOrLoose = 1 Then                                  'additional if statement added to improve probability of gaining a prize
            Dim wintimes As Integer = Int(3 * Rnd() + 1)        'out of 5 tries, during the time of winning depending on their luck they may
            Dim prizewon As Integer                             'win 2 or 3 prizes so long it is within the range of 9 pennies using a random  
            If wintimes = 1 Then                                'button
                prizewon = Int(4 * Rnd())
                For outputTimes As Integer = 0 To 24
                    If btnArray(outputTimes).Text = prizeTypes(prizewon) Then
                        btnArray(outputTimes).Text = btnArray(outputTimes).Text & " " & "x"
                    End If
                Next outputTimes
                For restCoinOutput As Integer = 0 To 6
                    randomBtn = Int(24 * Rnd())
                    btnArray(randomBtn).Text = btnArray(randomBtn).Text & " " & "x"
                Next

            ElseIf wintimes = 2 Then
                prizewon = Int(4 * Rnd())
                For outputTimes As Integer = 0 To 24
                    If btnArray(outputTimes).Text = prizeTypes(prizewon) Then
                        btnArray(outputTimes).Text = btnArray(outputTimes).Text & " " & "x"
                    End If
                Next outputTimes
                prizewon = Int(4 * Rnd())
                For secondOutputTimes As Integer = 0 To 24
                    If btnArray(secondOutputTimes).Text = prizeTypes(prizewon) Then
                        btnArray(secondOutputTimes).Text = btnArray(secondOutputTimes).Text & " " & "x"
                    End If
                Next secondOutputTimes
                For restCoinOutput As Integer = 0 To 3
                    randomBtn = Int(24 * Rnd())
                    btnArray(randomBtn).Text = btnArray(randomBtn).Text & " " & "x"
                Next

            ElseIf wintimes = 3 Then
                prizewon = Int(4 * Rnd())
                For outputTimes As Integer = 0 To 24
                    If btnArray(outputTimes).Text = prizeTypes(prizewon) Then
                        btnArray(outputTimes).Text = btnArray(outputTimes).Text & " " & "x"
                    End If
                Next outputTimes
                prizewon = Int(4 * Rnd())
                For secondOutputTimes As Integer = 0 To 24
                    If btnArray(secondOutputTimes).Text = prizeTypes(prizewon) Then
                        btnArray(secondOutputTimes).Text = btnArray(secondOutputTimes).Text & " " & "x"
                    End If
                Next secondOutputTimes
                prizewon = Int(4 * Rnd())
                For thirdOutputTimes As Integer = 0 To 24
                    If btnArray(thirdOutputTimes).Text = prizeTypes(prizewon) Then
                        btnArray(thirdOutputTimes).Text = btnArray(thirdOutputTimes).Text & " " & "x"
                    End If
                Next thirdOutputTimes
            End If

        Else
            For coinOutput As Integer = 0 To 9                                  'outputs 10 random numbers which represent
                randomBtn = Int(24 * Rnd())                                     'button that will have the pennies placed on them
                btnArray(randomBtn).Text = btnArray(randomBtn).Text & " " & "x" 'a counter representing the prizes has one added
            Next coinOutput                                                     'to it once a penny lands on it once.
        End If

        puzzleCount = 0 'resets all past amount of times the player landed a coin on a button carrying a prize
        ballCount = 0
        gameCount = 0
        posterCount = 0
        dollCount = 0

        For scoring As Integer = 0 To 24                                                     'searches through the twenty four buttons for the buttons 
            Dim checkString As String = btnArray(scoring).Text                               'containing a coin, if the button with the coin contained 
            If checkString.Contains(prizeTypes(0)) And checkString.Contains("x") Then    'a prize then the prize counter for the specific prize
                puzzleCount += 1                                                             'increased by one
            End If
            If checkString.Contains(prizeTypes(1)) And checkString.Contains("x") Then
                ballCount += 1
            End If
            If checkString.Contains(prizeTypes(2)) And checkString.Contains("x") Then
                gameCount += 1
            End If
            If checkString.Contains(prizeTypes(3)) And checkString.Contains("x") Then
                posterCount += 1
            End If
            If checkString.Contains(prizeTypes(4)) And checkString.Contains("x") Then
                dollCount += 1
            End If
        Next scoring

        Me.Label1.Text = "Prizes Won:"
        If puzzleCount >= 3 Then                                   'there are three buttons per prize, if the prize is won all three buttons contain
            Me.Label1.Text = Me.Label1.Text & " " & prizeTypes(0) 'a coin represted by x, the numbers of buttons for the prize with coins is 
            winScores += 1                                        'represented by the prizeCount variables, if the count is equivalent to three
        End If                                                    'the number of prizes won represented by the winScores value is updated with
        If ballCount >= 3 Then                                     'one being added to it, the prize is then outputed in a label, if none of the 
            Me.Label1.Text = Me.Label1.Text & " " & prizeTypes(1) 'counters equal to three then the label outputted would show none of the prizes 
            winScores += 1                                        'were won
        End If
        If gameCount >= 3 Then
            Me.Label1.Text = Me.Label1.Text & " " & prizeTypes(2)
            winScores += 1
        End If
        If posterCount >= 3 Then
            Me.Label1.Text = Me.Label1.Text & " " & prizeTypes(3)
            winScores += 1
        End If
        If dollCount >= 3 Then
            Me.Label1.Text = Me.Label1.Text & " " & prizeTypes(4)
            winScores += 1
        End If
        If puzzleCount <> 3 Then
            If ballCount <> 3 Then
                If gameCount <> 3 Then
                    If posterCount <> 3 Then
                        If dollCount <> 3 Then
                            Me.Label1.Text = Me.Label1.Text & " no prizes"
                        End If
                    End If
                End If
            End If
        End If


        


        Dim highscores As New FileStream("highscores.txt", FileMode.Append, FileAccess.Write)  'creates a file for gathering highscores
        Dim textFile As New StreamWriter(highscores)
        textFile.WriteLine(names & vbTab & vbTab & winScores)
        textFile.Close()
        highscores.Close()
    End Sub

    'toss pennies disabled until new game button is pressed
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnTossPennies.Enabled = False

    End Sub
End Class





