Imports Telerik.WinControls.UI

Public Class FrmCalcNotes

    Private Sub CalcNotesRadButton_Click(sender As Object, e As EventArgs) Handles CalcNotesRadButton.Click
        CalculateAverage(RadRadioButtonSwitch)
        CalculateAverage(RadRadioButtonSimpleIf)
        CalculateAverage(RadRadioButtonNested)
    End Sub

    Private Sub CalculateAverage(ByRef radioButton As RadRadioButton)
        If (radioButton.IsChecked) Then
            Select Case radioButton.Name
                Case "RadRadioButtonSwitch"
                    ValidateNotesWithSelectCase()

                Case "RadRadioButtonSimpleIf"
                    ValidateNotesWithSimpleIf()

                Case "RadRadioButtonNested"
                    ValidateNotesWithIfNested()
                Case Else
                    MessageBox.Show("Debe seleccionar un metodo para procesar las calificaciones")
            End Select

        End If
    End Sub

    Private Sub ValidateNotesWithSelectCase()
        Select Case GetResultNotes()
            Case 90 To 100
                MessageBox.Show($"Resultado de calificacion A")
            Case 80 To 89
                MessageBox.Show($"Resultado de calificacion B")
            Case 70 To 79
                MessageBox.Show($"Resultado de calificacion C")
            Case 0 To 69
                MessageBox.Show($"Resultado de calificacion F")
        End Select
    End Sub

#Region "ValidateNotes"
    Private Sub ValidateNotesWithSimpleIf()
        Dim result As Int32 = GetResultNotes()

        If (result >= 90 And result <= 100) Then
            MessageBox.Show($"Resultado de calificacion A")
        End If
        If (result >= 80 And result <= 89) Then
            MessageBox.Show($"Resultado de calificacion B")
        End If
        If (result >= 70 And result <= 79) Then
            MessageBox.Show($"Resultado de calificacion C")
        End If
        If (result >= 0 And result <= 69) Then
            MessageBox.Show($"Resultado de calificacion F")
        End If
    End Sub
    Private Sub ValidateNotesWithIfNested()
        Dim result As Int32 = GetResultNotes()

        If (result >= 90 And result <= 100) Then
            MessageBox.Show($"Resultado de calificacion A")
        ElseIf (result >= 80 And result <= 89) Then
            MessageBox.Show($"Resultado de calificacion B")
        ElseIf (result >= 70 And result <= 79) Then
            MessageBox.Show($"Resultado de calificacion C")
        ElseIf (result >= 0 And result <= 69) Then
            MessageBox.Show($"Resultado de calificacion F")
        End If
    End Sub
    Private Function GetResultNotes() As Decimal
        Dim result, n1, n2, n3, n4, n5 As Int32
        n1 = RadSpinEditor1.Value
        n2 = RadSpinEditor2.Value
        n3 = RadSpinEditor3.Value
        n4 = RadSpinEditor4.Value
        n5 = RadSpinEditor5.Value
        result = n1 + n2 + n3 + n4 + n5
        Return (result / 5)
    End Function
#End Region

End Class