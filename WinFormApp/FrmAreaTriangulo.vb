Public Class FrmAreaTriangulo
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim base As Decimal = BaseRadMaskedEditBox.Value
        Dim altura As Decimal = AlturaRadMaskedEditBox.Value
        Dim Area As Decimal

        Area = (base * altura) / 2
        MessageBox.Show(String.Format("El area {0} cm2", Area))

    End Sub
End Class