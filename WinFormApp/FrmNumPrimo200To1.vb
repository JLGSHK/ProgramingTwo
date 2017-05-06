Public Class FrmNumPrimo200To1
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim contador As Integer = 200
        If (MostrarRadListView.Items.Count() > 0) Then
            MostrarRadListView.Items.Clear()
        End If
        While (contador > 1)
            If (contador Mod 2 <> 0 Or contador = 2) Then
                MostrarRadListView.Items.Add(contador.ToString())
            End If
            contador = contador - 1
        End While
    End Sub
End Class