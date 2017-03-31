Public Class FrmPares1A200

    Public cantidadNumero As Int32
    Private Sub GenerarNumeroRadButton_Click(sender As Object, e As EventArgs) Handles GenerarNumeroRadButton.Click
        ResetearValores()
        For i As Integer = 1 To 200
            If (i Mod 2.0 = 0 Or i = 1) Then
                NumerosRadListView.Items.Add(i.ToString())
                cantidadNumero += 1
            End If
        Next
        NumeroEncontradoLabel.Text = cantidadNumero.ToString()
    End Sub
    Private Sub ResetearValores()
        NumerosRadListView.Items.Clear()
        NumeroEncontradoLabel.Text = String.Empty
        cantidadNumero = 0
    End Sub

    Private Sub FrmPares1A200_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumeroEncontradoLabel.Text = String.Empty
    End Sub
End Class