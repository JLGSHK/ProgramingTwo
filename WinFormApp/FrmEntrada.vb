Public Class FrmEntrada
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        If (MostrarRadListView.Items.Count() <= 9) Then
#Region "Logica"
            Dim numEntrada As Integer = NumRadMaskedEditBox.Value
            contador = contador + 1
            If (numEntrada = 0) Then
                MessageBox.Show(Me, "Debe ingresar un valor diferente a cero (0) ")
                Return
            End If

            If (esPar(numEntrada)) Then
                'par
                If (esPositivo(numEntrada)) Then
                    MostrarRadListView.Items.Add(String.Format("{1} - El {0} es Par y Positivo", numEntrada, contador))
                Else
                    '-
                    MostrarRadListView.Items.Add(String.Format("{1} -El {0} es Par y Negativo", numEntrada, contador))
                End If
            Else
                'impar
                If (esPositivo(numEntrada)) Then
                    '+
                    MostrarRadListView.Items.Add(String.Format("{1} -El {0} es Impar y Positivo", numEntrada, contador))
                Else
                    '-
                    MostrarRadListView.Items.Add(String.Format("{1} -El {0} es Impar y Negativo", numEntrada, contador))
                End If
            End If
#End Region
        Else
            MessageBox.Show(Me, "Limite de numeros requeridos 10")
        End If

    End Sub

    Private Function esPar(ByVal num As Integer) As Boolean
        If (num Mod 2 = 0) Then
            Return True
        End If
        Return False
    End Function

    Private Function esPositivo(ByVal num As Integer) As Boolean
        If (num > 0) Then
            Return True
        End If
        Return False
    End Function

    Private Sub FrmEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim contador As Integer = 0

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        MostrarRadListView.Items.Clear()
        contador = 0
    End Sub
End Class