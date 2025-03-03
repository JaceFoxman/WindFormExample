'Jason Permann
'Spring 2025
'RCET2265
'Win Form Exaple
'
Option Strict On
Option Explicit On
Option Compare Text

Public Class WindFormExampleForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        'Me.Text = "Forms Are Cool"
        Me.Text = StrReverse(Me.Text)
    End Sub
End Class
