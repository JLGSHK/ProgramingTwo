Public Class FrmFactorial
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click

        Dim factorial As Integer = NumFactRadMaskedEditBox.Value

        If (factorial <= 0) Then
            MessageBox.Show(Me, "Debe ingresar un valor mayor que cero", "Información")
            Return
        End If
        Dim result As Integer = 1
        If (MostrarFactorialListView.Items.Count() > 0) Then
            MostrarFactorialListView.Items.Clear()
        End If
        MostrarFactorialListView.Items.Add("Resultado Factorial")
        For i As Integer = 1 To factorial
            result = result * i
            MostrarFactorialListView.Items.Add(result.ToString())
        Next
    End Sub
End Class