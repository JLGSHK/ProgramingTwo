Public Class FrmOperacionesNumeroFraccionario
    Private Sub FrmOperacionesNumeroFraccionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OperacionLabel.Text = "+"
    End Sub

    Private Sub CheckedChanged(sender As Object, e As EventArgs) Handles MultiplicacionRadioButton.CheckedChanged, RestaRadioButton.CheckedChanged, DivisionRadioButton.CheckedChanged, SumaRadioButton.CheckedChanged
        Dim check As RadioButton = DirectCast(sender, RadioButton)

        Select Case check.Text
            Case "Suma"
                OperacionLabel.Text = "+"
            Case "Resta"
                OperacionLabel.Text = "-"
            Case "Multiplicación"
                OperacionLabel.Text = "*"
            Case "División"
                OperacionLabel.Text = "/"
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numIzquierdo As Integer = NumeradorIzquierdo.Value
        Dim denoIzquierdo As Integer = DenominadorIzquierdo.Value

        Dim numDerecho As Integer = NumeradorDerecho.Value
        Dim denoDerecho As Integer = DenominadorDerecho.Value

        If (numIzquierdo = 0 Or numDerecho = 0) Then
            MessageBox.Show(Me, "Numerador/es no puede/n ser cero")
            Return
        End If
        If (denoIzquierdo = 0 Or denoDerecho = 0) Then
            MessageBox.Show(Me, "Denominador/es no puede/n ser cero")
            Return
        End If

        If (SumaRadioButton.Checked) Then
            Dim resultNumerador = (numIzquierdo * denoDerecho) + (denoIzquierdo * numDerecho)
            Dim resultDenominador = denoIzquierdo * denoDerecho
            MessageBox.Show(Me, String.Format("Resultado Suma {0} / {1}", resultNumerador, resultDenominador), "Resultados")
            'suma
        ElseIf (RestaRadioButton.Checked) Then
            Dim resultNumerador = (numIzquierdo * denoDerecho) - (denoIzquierdo * numDerecho)
            Dim resultDenominador = denoIzquierdo * denoDerecho
            MessageBox.Show(Me, String.Format("Resultado Resta {0} / {1}", resultNumerador, resultDenominador), "Resultados")

            'resta
        ElseIf (MultiplicacionRadioButton.Checked) Then
            Dim resultNumerador = (numIzquierdo * numDerecho)
            Dim resultDenominador = denoIzquierdo * denoDerecho
            MessageBox.Show(Me, String.Format("Resultado {0} / {1}", resultNumerador, resultDenominador), "Resultados")

            'multi
        ElseIf (DivisionRadioButton.Checked) Then
            Dim resultNumerador = (numIzquierdo * denoDerecho)
            Dim resultDenominador = (denoIzquierdo * numDerecho)
            MessageBox.Show(Me, String.Format("Resultado Suma {0} / {1}", resultNumerador, resultDenominador), "Resultados")

        End If

    End Sub
End Class