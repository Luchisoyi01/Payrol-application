Public Class Form1
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        NameTextBox.Clear()
        HoursWorkedTextBox.Clear()
        PayRateTextBox.Clear()
        GrossPayTextBox.Clear()
        NameTextBox.Focus()
    End Sub
    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        Dim Hoursdecimal, PayRatedecimal, GrosspayDecimal As Decimal
        If IsNumeric(HoursWorkedTextBox.Text) = False OrElse (Decimal.Parse(HoursWorkedTextBox.Text, Globalization.NumberStyles.Number)
            <= 0D Or Decimal.Parse(HoursWorkedTextBox.Text, Globalization.NumberStyles.Number) > 60D) Then
            'Hours must be numeric and within allowable range
            MessageBox.Show("Hours worked must be a number between 0 and 60", "Hours Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            HoursWorkedTextBox.Focus()
        ElseIf IsNumeric(PayRateTextBox.Text) = False OrElse Decimal.Parse(PayRateTextBox.Text, Globalization.NumberStyles.Currency) <= 0D Then
            MessageBox.Show("Pay rate worked must be a number and greater than zero.", "Pay Rate Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PayRateTextBox.Focus()
        Else
            Hoursdecimal = Decimal.Parse(HoursWorkedTextBox.Text, Globalization.NumberStyles.Number)
            PayRatedecimal = Decimal.Parse(PayRateTextBox.Text, Globalization.NumberStyles.Currency)
        End If
        If HoursDecimal <= 40D Then  'pay only regular time
            GrossPayDecimal = Decimal.Round(HoursDecimal * PayRateDecimal, 2)
        Else  'pay regular + overtime
            GrossPayDecimal = Decimal.Round((40D * PayRateDecimal) _
                        + ((HoursDecimal - 40D) * PayRateDecimal * 1.5D), 2)
        End If
        If HourlyRadioButton.Checked Then
            GrosspayDecimal = PayRatedecimal * Hoursdecimal
        End If
        If SalaryRadioButton.Checked Then
            GrosspayDecimal = 800 + (PayRatedecimal * Hoursdecimal)
        End If
        GrossPayTextBox.Text = GrosspayDecimal.ToString("C")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
