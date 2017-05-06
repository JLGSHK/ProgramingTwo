Public Class FrmEcuacionPrimerGrado

    Private Sub FrmEcuacionPrimerGrado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'REALIZAR LA ECUACION DE PRIMER GRADO
        Dim strEcuacion = "3x=9"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resultado As Integer
        If Val(RadMaskedEditBox1.Text) = 0 Then
            MsgBox("Ingrese una cantidad diferente de cero")
        End If
        If Len(RadMaskedEditBox2.Text) = 2 Then
            MsgBox("Ingrese solo una variable!")
        End If

        resultado = (Val(RadMaskedEditBox4.Text) - Val(RadMaskedEditBox3.Text)) / Val(RadMaskedEditBox1.Text)
        MsgBox(String.Format("Valor de la variable {0} es {1}", RadMaskedEditBox2.Text, resultado))
    End Sub
End Class