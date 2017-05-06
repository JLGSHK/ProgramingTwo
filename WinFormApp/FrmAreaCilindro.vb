Public Class FrmAreaCilindro
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        '1 radio 2 altura
        Dim radio As Integer = RadMaskedEditBox1.Value
        Dim altura As Integer = RadMaskedEditBox2.Value

        Dim resultado As Double

        resultado = 2 * Math.PI * radio * (radio * altura)

        MessageBox.Show(Me, String.Format("El Área del Cilindro es: {0:N} metros 2", resultado), "Resultado")

    End Sub
End Class