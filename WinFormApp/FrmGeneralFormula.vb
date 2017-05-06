Public Class FrmGeneralFormula
    Private Sub CalcularRadButton_Click(sender As Object, e As EventArgs) Handles CalcularRadButton.Click
        Dim _a As Integer = ARadMaskedEditBox.Value
        Dim _b As Integer = BRadMaskedEditBox.Value
        Dim _c As Integer = CRadMaskedEditBox.Value

        If (_a = 0 And _b = 0 And _c = 0) Then
            MessageBox.Show(Me, "Debe ingresar valores", "Resultado")
            Return

        End If

        Dim raiz = Math.Sqrt(Math.Pow(_b, 2) + (-4 * _a * _c))
        Dim division = 2 * _a
        'x1 = +
        'x2 = -
        Dim x1 As Double = ((-(_b)) + raiz) / division
        Dim x2 As Double = ((-(_b)) - raiz) / division
        MessageBox.Show(String.Format("X1 = {0} -- x2={1}", x1, x2))
    End Sub
End Class