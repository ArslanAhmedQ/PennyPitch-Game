'Group Members: Arslan, Ravnik, Oindrilla
'Project: Chap 08, Ex 15 (advanced)
'Penny Pitch
'January 02-17, 2014


Imports System.IO
Public Class HighScore

    'This application simulates the penny pitch game. When New Game is clicked, it randomly marks a 5 x 5 board 
    'of 25 buttons w/prizes of puzzle, game, ball, poster, and doll. Each prize appears on 3 randomly chosen 
    'squares so that 15 squares contain prizes. Clicking Toss Pennies simulates ten pennies being randomly 
    'pitched onto the board. Each penny is rep. by an "x" character on a square. If all of the squares say Ball 
    'or any other prize in them are covered by a penny, the player wins a that prize. Clicking Toss Pennies 
    'shows where the ten pennies landed and displays a list of the prizes won or "No prizes".
    '

    Dim streamer As IO.StreamReader

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()   'Closes game application completely
    End Sub

    Private Sub HighScore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Home.Show()  'Opens Home Window
        'Dim sortString As String

        ' Dim highscores() As String

        'Dim Lines() As String = IO.File.ReadAllLines("highscores.txt")
        ' For x As Integer = 0 To Lines.GetUpperBound(0) Step 2
        'ReDim Preserve highscores(x / 2)
        ' highscores(x / 2) = Lines(x + 1) & "~" & Lines(x)
        'Next

        'Array.Sort(highscores)
        ' Array.Reverse(highscores)

        'For Each Element As String In highscores
        'lstHighScore.Items.Add _
        '(Strings.Right(Element, Len(Element) - InStr(Element, "~")) _
        '& " " & Strings.Left(Element, InStr(Element, "~") - 1) & vbCrLf)
        'Next

        Dim numLines As Integer = IO.File.ReadAllLines("highscores.txt").Length 'add highscore values 
        lstHighScore.Items.Clear()                                      'from text file into listbox
        lstHighScore.Items.Add("Names" & vbTab & vbTab & "Number of Prizes")
        streamer = IO.File.OpenText("highscores.txt")
        Dim mystring() As String = streamer.ReadToEnd.Split(vbNewLine)
        lstHighScore.Items.AddRange(mystring)

        'Dim myArr() As String = lstHighScore.Items.OfType(Of String)().ToArray()     'we are still working on it
        'For sort As Integer = 0 To (myArr.Length - 1)                                 ' code use for sorting
        'Do While sort <> myArr.Length
        'Dim string3 As String = myArr(sort)
        'Dim string4 As String = myArr(sort + 1)
        'Dim string1 As String = Integer.Parse(string3)
        'Dim string2 As String = Integer.Parse(string4)
        'If CInt(string1) < CInt(string2) Then
        'sortString = myArr(sort)
        'myArr(sort) = myArr(sort + 1)
        'End If
        'Loop
        'Next
        'For addItems As Integer = 0 To (myArr.Length - 1)
        'lstHighScore.Items.Add(myArr(addItems))
        'Next
    End Sub

End Class