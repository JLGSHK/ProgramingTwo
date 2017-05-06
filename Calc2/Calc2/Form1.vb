Imports Telerik.WinControls.UI

Public Class Form1
    Dim pares As ArrayList = New ArrayList()
    Dim impares As ArrayList = New ArrayList()

    Function ValidarEntrada(valor As Boolean) As Boolean
        If valor > 0 Then
            Return True
        End If
        Return False
    End Function

    Private Sub BtnProcess_Click(sender As Object, e As EventArgs) Handles BtnProcess.Click
        Dim valor As Integer
        For Each control As Control In Me.Controls

            If TypeOf control Is RadMaskedEditBox Then
                If DirectCast(control, RadMaskedEditBox).Value > 0 Then
                    valor = DirectCast(control, RadMaskedEditBox).Value
                    If valor Mod 2 = 0 Then
                        pares.Add(valor)
                    Else
                        impares.Add(valor)
                    End If
                End If
            End If
        Next

        Dim SumaPares As Integer
        Dim resultSumaPares As String = String.Empty

        For Each val As Integer In pares
            SumaPares += val
            resultSumaPares += val.ToString() + " "
        Next

        Dim SumaImpares As Integer
        Dim resultSumaImpares As String = String.Empty

        For Each val As Integer In impares
            SumaImpares += val
            resultSumaImpares += val.ToString() + " "

        Next

        Dim promedioPares As Double

        If pares.Count > 0 Then
            promedioPares = SumaPares / pares.Count
            LbPares.Text = resultSumaPares.ToString() + " = " + SumaPares.ToString()
        End If

        Dim promedioImpares As Double

        If impares.Count > 0 Then
            promedioImpares = SumaImpares / impares.Count
            LbImpares.Text = resultSumaImpares.ToString() + " = " + SumaImpares.ToString()
        End If
        LbPromedio.Text = ((SumaPares + SumaImpares) / 2).ToString()
        LbCantidadPares.Text = String.Format("Son: {0}", pares.Count)
        LbCantidadImpares.Text = String.Format("Son: {0}", impares.Count)

    End Sub
End Class