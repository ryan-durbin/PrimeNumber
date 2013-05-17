<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrimeNumber
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
        Me.lowerBoundryLabel = New System.Windows.Forms.Label()
        Me.upperBoundryLabel = New System.Windows.Forms.Label()
        Me.primeNumbersLabel = New System.Windows.Forms.Label()
        Me.calculatePrimesButton = New System.Windows.Forms.Button()
        Me.lowerBoundryTextBox = New System.Windows.Forms.TextBox()
        Me.upperBoundryTextBox = New System.Windows.Forms.TextBox()
        Me.primeNumbersListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lowerBoundryLabel
        '
        Me.lowerBoundryLabel.AutoSize = True
        Me.lowerBoundryLabel.Location = New System.Drawing.Point(12, 45)
        Me.lowerBoundryLabel.Name = "lowerBoundryLabel"
        Me.lowerBoundryLabel.Size = New System.Drawing.Size(78, 13)
        Me.lowerBoundryLabel.TabIndex = 0
        Me.lowerBoundryLabel.Text = "Lower Boundry"
        '
        'upperBoundryLabel
        '
        Me.upperBoundryLabel.AutoSize = True
        Me.upperBoundryLabel.Location = New System.Drawing.Point(12, 19)
        Me.upperBoundryLabel.Name = "upperBoundryLabel"
        Me.upperBoundryLabel.Size = New System.Drawing.Size(78, 13)
        Me.upperBoundryLabel.TabIndex = 1
        Me.upperBoundryLabel.Text = "Upper Boundry"
        '
        'primeNumbersLabel
        '
        Me.primeNumbersLabel.AutoSize = True
        Me.primeNumbersLabel.Location = New System.Drawing.Point(12, 84)
        Me.primeNumbersLabel.Name = "primeNumbersLabel"
        Me.primeNumbersLabel.Size = New System.Drawing.Size(78, 13)
        Me.primeNumbersLabel.TabIndex = 2
        Me.primeNumbersLabel.Text = "Prime Numbers"
        '
        'calculatePrimesButton
        '
        Me.calculatePrimesButton.Location = New System.Drawing.Point(89, 392)
        Me.calculatePrimesButton.Name = "calculatePrimesButton"
        Me.calculatePrimesButton.Size = New System.Drawing.Size(107, 23)
        Me.calculatePrimesButton.TabIndex = 3
        Me.calculatePrimesButton.Text = "Calculate Primes"
        Me.calculatePrimesButton.UseVisualStyleBackColor = True
        '
        'lowerBoundryTextBox
        '
        Me.lowerBoundryTextBox.Location = New System.Drawing.Point(96, 42)
        Me.lowerBoundryTextBox.Name = "lowerBoundryTextBox"
        Me.lowerBoundryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.lowerBoundryTextBox.TabIndex = 4
        '
        'upperBoundryTextBox
        '
        Me.upperBoundryTextBox.Location = New System.Drawing.Point(96, 16)
        Me.upperBoundryTextBox.Name = "upperBoundryTextBox"
        Me.upperBoundryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.upperBoundryTextBox.TabIndex = 5
        '
        'primeNumbersListBox
        '
        Me.primeNumbersListBox.FormattingEnabled = True
        Me.primeNumbersListBox.Location = New System.Drawing.Point(12, 100)
        Me.primeNumbersListBox.Name = "primeNumbersListBox"
        Me.primeNumbersListBox.Size = New System.Drawing.Size(190, 277)
        Me.primeNumbersListBox.TabIndex = 6
        '
        'PrimeNumber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 427)
        Me.Controls.Add(Me.primeNumbersListBox)
        Me.Controls.Add(Me.upperBoundryTextBox)
        Me.Controls.Add(Me.lowerBoundryTextBox)
        Me.Controls.Add(Me.calculatePrimesButton)
        Me.Controls.Add(Me.primeNumbersLabel)
        Me.Controls.Add(Me.upperBoundryLabel)
        Me.Controls.Add(Me.lowerBoundryLabel)
        Me.Name = "PrimeNumber"
        Me.Text = "Prime Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lowerBoundryLabel As System.Windows.Forms.Label
    Friend WithEvents upperBoundryLabel As System.Windows.Forms.Label
    Friend WithEvents primeNumbersLabel As System.Windows.Forms.Label
    Friend WithEvents calculatePrimesButton As System.Windows.Forms.Button
    Friend WithEvents lowerBoundryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents upperBoundryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents primeNumbersListBox As System.Windows.Forms.ListBox

End Class
