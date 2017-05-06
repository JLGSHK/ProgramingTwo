Public Class FrmMatriz
    Dim matrizB(1, 1) As Integer
    Dim matrizA(1, 1) As Integer

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        matrizA(0, 0) = AX0.Value
        matrizA(0, 1) = AX1.Value
        matrizA(1, 0) = AZ0.Value
        matrizA(1, 1) = AZ1.Value

        matrizB(0, 0) = BX0.Value
        matrizB(0, 1) = BX1.Value
        matrizB(1, 0) = BZ0.Value
        matrizB(1, 1) = BZ1.Value

        Dim resultSuma As Integer = 0
        Dim resultResta As Integer = 0
        Dim resultMultiplicacion As Integer = 0
        Dim ma As Integer = 0
        Dim mb As Integer = 0

        For i As Integer = 0 To 1
            For j As Integer = 0 To 1
                'MessageBox.Show(String.Format("Matriz A {0} --- {1} -- {2}", matrizA(i, j), i, j))
                ma = matrizA(i, j)
                mb = matrizB(i, j)

                resultSuma = ma + mb
                resultResta = ma - mb
                resultMultiplicacion = ma * mb

                EstablecerResultadoSuma(resultSuma, i, j)
                EstablecerResultadoResta(resultResta, i, j)
                EstablecerResultadoMultiplicacion(resultMultiplicacion, i, j)

            Next
        Next

    End Sub

    Private Sub FrmMatriz_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EstablecerResultadoSuma(num As Integer, i As Integer, j As Integer)

        If (i = 0 And j = 0) Then
            RSX0.Value = num
        ElseIf (i = 0 And j = 1) Then
            RSX1.Value = num
        ElseIf (i = 1 And j = 0) Then
            RSZ0.Value = num
        ElseIf (i = 1 And j = 1) Then
            RSZ1.Value = num
        End If
    End Sub
    Private Sub EstablecerResultadoResta(num As Integer, i As Integer, j As Integer)

        If (i = 0 And j = 0) Then
            RRX0.Value = num
        ElseIf (i = 0 And j = 1) Then
            RRX1.Value = num
        ElseIf (i = 1 And j = 0) Then
            RRZ0.Value = num
        ElseIf (i = 1 And j = 1) Then
            RRZ1.Value = num
        End If
    End Sub
    Private Sub EstablecerResultadoMultiplicacion(num As Integer, i As Integer, j As Integer)

        If (i = 0 And j = 0) Then
            RMX0.Value = num
        ElseIf (i = 0 And j = 1) Then
            RMX1.Value = num
        ElseIf (i = 1 And j = 0) Then
            RMZ0.Value = num
        ElseIf (i = 1 And j = 1) Then
            RMZ1.Value = num
        End If
    End Sub
End Class