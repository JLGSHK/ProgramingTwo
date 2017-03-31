Public Class FrmCelsiusAndFahrenheit

    Const NUM As Int32 = 32

    Private Sub ConvertirRadButton_Click(sender As Object, e As EventArgs) Handles ConvertirRadButton.Click
        If (CtoFRadioButton.Checked) Then
            CelsiusToFahrenheit()
        End If

        If (FtoCRadioButton.Checked) Then
            FahrenheitToCelsius()
        End If

    End Sub

    Private Sub CelsiusToFahrenheit()
        Dim Fahrenheit As Decimal
        Dim Celsius As Decimal
        Celsius = NumRadMaskedEditBox.Value
        Fahrenheit = Celsius * (9 / 5) + NUM
        MessageBox.Show(String.Format("{0} Fahrenheit", Fahrenheit))
    End Sub

    Private Sub FahrenheitToCelsius()
        Dim Fahrenheit As Decimal = NumRadMaskedEditBox.Value
        Dim Celsius As Decimal
        Celsius = (Fahrenheit - 32) * (5 / 9)
        MessageBox.Show(String.Format("{0} Celsius", Celsius))
    End Sub
End Class