'############################################################################################
'######                             Unique Random Numbers                               #####
'######                                 Danri He 11A                                    #####
'######                                 January 8th 2014                                #####
'######                                 Mr. V / ICS3U                                   #####


Public Class Form1
    Dim userInput, numberOne, numberTwo, numberThree, loopCounter As Integer    'declares variables as type integer
    Public uniquePattern, newInput As Boolean    'declares variables as type boolean
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Do While userInput <= 3      'validates that the required input is greater than three
            userInput = Val(InputBox("Please input a number greater than three.", "Number Input"))
            If userInput <= 3 Then
                MessageBox.Show("Please make sure the number is greater than three.", "Input Message")  'display message to the user
            End If
        Loop
    End Sub

    Private Sub btnGenerate_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerate.Click
        Randomize()     'randomize function
        uniquePattern = False       'sets uniquePattern equal to False
        loopCounter = 0     'sets loopCounter equal to zero
        newInput = False    'sets newInput equal to False
        Do While uniquePattern = False  'execute loop while uniquePattern is equal to false
            Do Until numberOne <> numberTwo And numberOne <> numberThree And numberTwo <> numberThree   'execute loop until criteria is met
                numberOne = Int(userInput * Rnd() + 1)  'generates a random number
                numberTwo = Int(userInput * Rnd() + 1)  'generates a random number
                numberThree = Int(userInput * Rnd() + 1)    'generates a random number
                Me.lblNumber1.Text = numberOne  'sets the text of lblNumber1 equal to the number specified
                Me.lblNumber2.Text = numberTwo  'sets the text of lblNumber2 equal to the number specified
                Me.lblNumber3.Text = numberThree    'sets the text of lblNumber3 equal to the number specified
                loopCounter += 1    'increases the loop counter by 1
            Loop
            If numberTwo <> numberOne And numberOne <> numberThree And numberTwo <> numberThree Then    'if the criteria is met:
                uniquePattern = True    'set uniquePattern equal to True
            End If
        Loop

        If uniquePattern = True Then    'if uniquePattern is equal to True
            Me.lblMessage.Text = loopCounter & " loop iterations were needed to generate three unique numbers." 'displays a message to the user
            Me.btnGenerate.Enabled = False  'disables the btnGenerate
        End If
    End Sub

    Private Sub InputNewNumberToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InputNewNumberToolStripMenuItem.Click
        userInput = 0
        Do While userInput <= 3      'validates that the required input is greater than three
            userInput = Val(InputBox("Please input a number greater than three.", "Number Input"))
            If userInput <= 3 Then
                MessageBox.Show("Please make sure the number is greater than three.", "Input Message")  'display message to the user
            End If
        Loop
        If userInput > 3 Then   'is userInput is validated, then newInput is set to True
            newInput = True
        End If
        If newInput = True Then
            loopCounter = 0
            Me.btnGenerate.Enabled = True
        End If
    End Sub
End Class
