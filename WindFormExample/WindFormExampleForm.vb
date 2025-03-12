'Jason Permann
'Spring 2025
'RCET2265
'Win Form Exaple
'
Option Strict On
Option Explicit On
Option Compare Text

Public Class WindFormExampleForm
    Sub SetDefaults()
        FirstTextBox.Text = ""
        LastLabel.Text = ""
        AgeTextBox.Text = ""
        UpperRadioButton.Checked = True
        FirstLastRadioButton.Checked = True
        ReverseCheckBox.Checked = False
        WhiteSpaceCheckBox.Checked = False
        RandomCheckBox.Checked = False
        FirstTextBox.Focus()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Sub SetCase()
        If FirstLastRadioButton.Checked = True Then
            FirstTextBox.Text = UCase(FirstTextBox.Text)
            LastLabel.Text = UCase(LastLabel.Text)

        ElseIf LastFirstRadioButton.Checked = True Then
            FirstTextBox.Text = LCase(FirstTextBox.Text)
            LastLabel.Text = LCase(LastLabel.Text)
        Else
            MsgBox($"oh no, no case selected")
        End If

    End Sub

    Sub ReverseString()
        If ReverseCheckBox.Checked Then
            Me.Text = StrReverse(Me.Text)
        End If
    End Sub

    Sub RemoveWhiteSpace()
        If WhiteSpaceCheckBox.Checked Then
            Me.Text = Replace(Me.Text, " ", "")
        End If
    End Sub
    Sub Scramble()
        Dim first As String = FirstTextBox.Text
        Dim firstLetters(Len(FirstTextBox.Text)) As String
        Dim second As String = LastLabel.Text
        Dim secondLetters(Len(LastLabel.Text)) As String

        For i = 0 To Len(first) - 1
            Console.WriteLine($"The {i} letter is: {first(i)}")
        Next

        For i = 0 To Len(second) - 1
            Console.WriteLine($"The {i} letter is: {second(i)}")
        Next

        If RandomCheckBox.Checked Then

        End If
    End Sub

    Function RNG(Min As Integer, Max As Integer) As Integer
        Dim randomNumber As Single
        Randomize()
        randomNumber = Rnd()
        randomNumber *= Max + Min
        randomNumber += Min
        Return CInt(randomNumber)
    End Function

    Function UserInputIsVaild() As Boolean
        Dim valid As Boolean = True
        Dim message As String
        If IsNumeric(AgeTextBox.Text) = False Then
            valid = False
            AgeTextBox.Focus()
            message &= "Please enter a valid age." & vbNewLine
        End If

        If LastLabel.Text = "" Then
            valid = False
            LastLabel.Focus()
            message &= "Last Name is required." & vbNewLine
        End If

        If FirstTextBox.Text = "" Then
            valid = False
            FirstTextBox.Focus()
            message &= "First Name is required." & vbNewLine
        End If

        If Not valid Then
            MsgBox(message, MsgBoxStyle.Exclamation, "User Input Fail!!")
        End If

        Return valid
    End Function

    Sub AddToList(thisString As String)
        DataListBox.Items.Add(thisString)
    End Sub

    Sub RemoveFromList(thisString As String)
        DataListBox.Items.Remove(thisString)
    End Sub

    Sub SetFormat()
        If UpperRadioButton.Checked = True Then
            Me.Text = FirstTextBox.Text & " " & LastLabel.Text
        ElseIf LowerRadioButton.Checked = True Then
            Me.Text = $"{LastLabel.Text},{FirstTextBox.Text}"
        Else
            MsgBox($"oh no, no format selected")
        End If
    End Sub
    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        'Me.Text = "Forms Are Cool"
        If UserInputIsVaild() Then
            Scramble()
            SetCase()
            SetFormat()
            ReverseString()
            RemoveWhiteSpace()
            AddToList(Me.Text)
            SetDefaults()
        End If
    End Sub

    Private Sub WindFormExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

    Private Sub DataListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataListBox.SelectedIndexChanged
        Me.Text = DataListBox.SelectedIndex.ToString
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        Console.WriteLine($" The index item {DataListBox.SelectedIndex} is {DataListBox.SelectedItem}!")
        DataListBox.Items.RemoveAt(DataListBox.SelectedIndex)
    End Sub
End Class
