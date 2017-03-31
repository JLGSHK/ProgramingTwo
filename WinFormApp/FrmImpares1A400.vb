Imports System.Linq
Imports System.Collections.Generic
Imports System.Collections

Public Class FrmImpares1A400
    Public cantidadNumero As Int32
    Private Sub GenerarNumeroRadButton_Click(sender As Object, e As EventArgs) Handles GenerarNumeroRadButton.Click
        ResetearValores()
        For i As Integer = 1 To 400
            If (i Mod 2.0 <> 0 Or i = 400) Then
                NumerosRadListView.Items.Add(i.ToString())
                cantidadNumero += 1
            End If
        Next
        NumeroEncontradoLabel.Text = cantidadNumero.ToString()
    End Sub

    Private Sub FrmImpares1A400_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumeroEncontradoLabel.Text = String.Empty
    End Sub

    Private Sub ResetearValores()
        NumerosRadListView.Items.Clear()
        NumeroEncontradoLabel.Text = String.Empty
        cantidadNumero = 0
    End Sub
End Class