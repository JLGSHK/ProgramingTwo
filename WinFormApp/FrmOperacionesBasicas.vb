Public Class FrmOperacionesBasicas
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click

        If (SumaRadRadioButton.IsChecked) Then
            Procesar(1)
        ElseIf (RestaRadRadioButton.IsChecked) Then
            Procesar(2)
        ElseIf (DivisionRadRadioButton.IsChecked) Then
            Procesar(3)
        ElseIf (MultiplicacionRadRadioButton.IsChecked) Then
            Procesar(4)
        End If
    End Sub
    Private Sub Procesar(ByVal operacion As Int32)
        Dim num1 As Int32 = Num1RadMaskedEditBox.Value
        Dim num2 As Int32 = Num2RadMaskedEditBox.Value

        Select Case (operacion)
            Case 1 'suma
                Dim result = num1 + num2
                MessageBox.Show(String.Format("{0} + {1} = {2}", num1, num2, result), "Resultado")
            Case 2 'resta
                Dim result = num1 - num2
                MessageBox.Show(String.Format("{0} - {1} = {2}", num1, num2, result), "Resultado")
            Case 3 'division
                Dim result = num1 / num2
                MessageBox.Show(String.Format("{0} / {1} = {2}", num1, num2, result), "Resultado")
            Case 4 'multiplicacion
                Dim result = num1 * num2
                MessageBox.Show(String.Format("{0} x {1} = {2}", num1, num2, result), "Resultado")

        End Select
    End Sub
End Class