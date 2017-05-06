Public Class FrmFibonacci
    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim p As Decimal = 0
        Dim s As Decimal = 1
        Dim result As Decimal
        FibonacciRadListView.Items.Clear()
        For i = 1 To 100
            result = p + s
            FibonacciRadListView.Items.Add(result)
            p = s
            s = result

        Next
    End Sub
End Class