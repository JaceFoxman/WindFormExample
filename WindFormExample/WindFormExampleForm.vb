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
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Sub SetCase()
        If UpperRadioButton.Checked = True Then
            Me.Text = FirstTextBox.Text & " " & LastLabel.Text
        ElseIf LowerRadioButton.Checked = True Then
            Me.Text = $"{LastLabel.Text},{FirstTextBox.Text}"
        Else
            MsgBox($"oh no, no case selected")
        End If
    End Sub

    Sub SetFormat()
        If FirstLastRadioButton.Checked = True Then
            Me.Text = UCase(FirstTextBox.Text & " " & LastLabel.Text)
        ElseIf LastFirstRadioButton.Checked = True Then
            Me.Text = LCase(FirstTextBox.Text & " " & LastLabel.Text)
        Else
            MsgBox($"oh no, no format selected")
        End If
    End Sub
    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        'Me.Text = "Forms Are Cool"
        'Me.Text = StrReverse(Me.Text)
        SetCase()
        SetFormat()
        SetDefaults()
    End Sub

    Private Sub WindFormExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

End Class
