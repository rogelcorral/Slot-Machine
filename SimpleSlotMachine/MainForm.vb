'   Rogel SJ Corral
'   3 June 2019


Option Explicit On

Public Class MainForm

    '   Variables
    Dim intWin As Integer = 0
    Dim intNum1 As Integer
    Dim intNum2 As Integer
    Dim intNum3 As Integer
    Dim playerCredit As Integer = 20

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        Application.Exit()

    End Sub

    Sub PlayLoopingBackgroundSoundFile()
        My.Computer.Audio.Play("D:\title-screen.wav",
        AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub btnPull_Click(sender As Object, e As EventArgs) Handles btnPull.Click

        '   populate the slots wtih random numbers
        playerCredit = playerCredit - 1
        intNum1 = Int(9 * Rnd() + 1)
        intNum2 = Int(9 * Rnd() + 1)
        intNum3 = Int(9 * Rnd() + 1)

        lbSlot1.Text = intNum1
        lbSlot2.Text = intNum2
        lbSlot3.Text = intNum3

        If playerCredit = 0 Then
            btnPull.Enabled = False
            btnReset.Enabled = True
            btnReset.Focus()
        End If

        If intNum1 = 1 And intNum2 = 1 And intNum3 = 1 Then

                intWin = intWin + 3

        ElseIf intNum1 = 2 And intNum2 = 2 And intNum3 = 2 Then

                intWin = intWin + 3

        ElseIf intNum1 = 3 And intNum2 = 3 And intNum3 = 3 Then

                intWin = intWin + 3

        ElseIf intNum1 = 4 And intNum2 = 4 And intNum3 = 4 Then

                intWin = intWin + 3

        ElseIf intNum1 = 5 And intNum2 = 5 And intNum3 = 5 Then

                intWin = intWin + 3

        ElseIf intNum1 = 6 And intNum2 = 6 And intNum3 = 6 Then

                intWin = intWin + 3

        ElseIf intNum1 = 7 And intNum2 = 7 And intNum3 = 7 Then

            intWin = intWin + 50

        ElseIf intNum1 = 8 And intNum2 = 8 And intNum3 = 8 Then

                intWin = intWin + 3

        ElseIf intNum1 = 9 And intNum2 = 9 And intNum3 = 9 Then

            intWin = intWin + 3

        End If

        displayWinnings()

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        playerCredit = 20
        lbCredits.Text = playerCredit
        intWin = 0
        lbResultText.Text = String.Empty

        lbSlot1.Text = "-"
        lbSlot2.Text = "-"
        lbSlot3.Text = "-"

        PlayLoopingBackgroundSoundFile()
    End Sub

    Private Sub displayWinnings()
        lbResultText.Text = "$ " & intWin
        lbCredits.Text = playerCredit
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Randomize()
        playerCredit = 20
        lbCredits.Text = playerCredit
        intWin = 0

        lbSlot1.Text = "-"
        lbSlot2.Text = "-"
        lbSlot3.Text = "-"
        lbResultText.Text = String.Empty

        btnPull.Enabled = True
        btnPull.Select()

    End Sub
End Class
