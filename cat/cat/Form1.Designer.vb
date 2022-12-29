<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GrossPayTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HourlyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SalaryRadioButton = New System.Windows.Forms.RadioButton()
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.HoursWorkedTextBox = New System.Windows.Forms.TextBox()
        Me.PayRateTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'GrossPayTextBox
        '
        Me.GrossPayTextBox.Location = New System.Drawing.Point(163, 239)
        Me.GrossPayTextBox.Name = "GrossPayTextBox"
        Me.GrossPayTextBox.ReadOnly = True
        Me.GrossPayTextBox.Size = New System.Drawing.Size(100, 22)
        Me.GrossPayTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gross Pay:"
        '
        'HourlyRadioButton
        '
        Me.HourlyRadioButton.AutoSize = True
        Me.HourlyRadioButton.Location = New System.Drawing.Point(429, 280)
        Me.HourlyRadioButton.Name = "HourlyRadioButton"
        Me.HourlyRadioButton.Size = New System.Drawing.Size(67, 20)
        Me.HourlyRadioButton.TabIndex = 1
        Me.HourlyRadioButton.TabStop = True
        Me.HourlyRadioButton.Text = "Hourly"
        Me.HourlyRadioButton.UseVisualStyleBackColor = True
        '
        'SalaryRadioButton
        '
        Me.SalaryRadioButton.AutoSize = True
        Me.SalaryRadioButton.Location = New System.Drawing.Point(429, 211)
        Me.SalaryRadioButton.Name = "SalaryRadioButton"
        Me.SalaryRadioButton.Size = New System.Drawing.Size(67, 20)
        Me.SalaryRadioButton.TabIndex = 0
        Me.SalaryRadioButton.TabStop = True
        Me.SalaryRadioButton.Text = "Salary"
        Me.SalaryRadioButton.UseVisualStyleBackColor = True
        '
        'ComputeButton
        '
        Me.ComputeButton.Location = New System.Drawing.Point(27, 364)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(141, 60)
        Me.ComputeButton.TabIndex = 3
        Me.ComputeButton.Text = "&Compute"
        Me.ComputeButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(271, 364)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(141, 60)
        Me.ResetButton.TabIndex = 4
        Me.ResetButton.Text = "&Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(535, 364)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(141, 60)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Hours Worked:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(318, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Pay Rate:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(163, 60)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(451, 22)
        Me.NameTextBox.TabIndex = 3
        '
        'HoursWorkedTextBox
        '
        Me.HoursWorkedTextBox.Location = New System.Drawing.Point(163, 124)
        Me.HoursWorkedTextBox.Name = "HoursWorkedTextBox"
        Me.HoursWorkedTextBox.Size = New System.Drawing.Size(100, 22)
        Me.HoursWorkedTextBox.TabIndex = 4
        '
        'PayRateTextBox
        '
        Me.PayRateTextBox.Location = New System.Drawing.Point(429, 121)
        Me.PayRateTextBox.Name = "PayRateTextBox"
        Me.PayRateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PayRateTextBox.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HoursWorkedTextBox)
        Me.Controls.Add(Me.PayRateTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.GrossPayTextBox)
        Me.Controls.Add(Me.HourlyRadioButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SalaryRadioButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.ComputeButton)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAY ROLL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents HourlyRadioButton As RadioButton
    Friend WithEvents SalaryRadioButton As RadioButton
    Friend WithEvents GrossPayTextBox As TextBox
    Friend WithEvents ComputeButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents HoursWorkedTextBox As TextBox
    Friend WithEvents PayRateTextBox As TextBox
End Class
