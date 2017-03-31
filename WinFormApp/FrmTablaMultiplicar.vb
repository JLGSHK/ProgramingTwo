Public Class FrmTablaMultiplicar
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim numero As Int32
        Dim format As String
        numero = NumeroRadMaskedEditBox.Value
        If (numero <= 0) Then
            MessageBox.Show("Debe ingresar un numero mayor que cero")
            Return
        End If
        If (numero > 12) Then
            MessageBox.Show("Debe ingresar un numero menor")
            Return
        End If
        TablaRadListView.Items.Clear()
        For i As Integer = 1 To 12

            format = String.Format("{0} x {1} = {2}", numero, i, (i * numero))
            TablaRadListView.Items.Add(format)
        Next
    End Sub
End Class