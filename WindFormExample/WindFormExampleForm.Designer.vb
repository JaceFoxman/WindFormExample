<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WindFormExampleForm
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Update = New System.Windows.Forms.Button()
        Me.FirstName = New System.Windows.Forms.Label()
        Me.FirstTextBox = New System.Windows.Forms.TextBox()
        Me.LastLabel = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.Age = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ExitButton.Location = New System.Drawing.Point(568, 332)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(220, 106)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Update
        '
        Me.Update.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Update.Location = New System.Drawing.Point(12, 332)
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(220, 97)
        Me.Update.TabIndex = 0
        Me.Update.Text = "U&pdate"
        Me.Update.UseVisualStyleBackColor = False
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Location = New System.Drawing.Point(12, 24)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(86, 20)
        Me.FirstName.TabIndex = 2
        Me.FirstName.Text = "First Name"
        '
        'FirstTextBox
        '
        Me.FirstTextBox.Location = New System.Drawing.Point(104, 21)
        Me.FirstTextBox.Name = "FirstTextBox"
        Me.FirstTextBox.Size = New System.Drawing.Size(128, 26)
        Me.FirstTextBox.TabIndex = 3
        '
        'LastLabel
        '
        Me.LastLabel.Location = New System.Drawing.Point(104, 53)
        Me.LastLabel.Name = "LastLabel"
        Me.LastLabel.Size = New System.Drawing.Size(128, 26)
        Me.LastLabel.TabIndex = 5
        '
        'LastName
        '
        Me.LastName.AutoSize = True
        Me.LastName.Location = New System.Drawing.Point(12, 56)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(86, 20)
        Me.LastName.TabIndex = 4
        Me.LastName.Text = "Last Name"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(104, 85)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(57, 26)
        Me.AgeTextBox.TabIndex = 7
        '
        'Age
        '
        Me.Age.AutoSize = True
        Me.Age.Location = New System.Drawing.Point(60, 88)
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(38, 20)
        Me.Age.TabIndex = 6
        Me.Age.Text = "Age"
        '
        'WindFormExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Me.Age)
        Me.Controls.Add(Me.LastLabel)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.FirstTextBox)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.Update)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "WindFormExampleForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents Update As Button
    Friend WithEvents FirstName As Label
    Friend WithEvents FirstTextBox As TextBox
    Friend WithEvents LastLabel As TextBox
    Friend WithEvents LastName As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents Age As Label
End Class
