Public Class Frm1To25And40To1
    Private Sub Frm1To25And40To1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MostrarRadButton_Click(sender As Object, e As EventArgs) Handles MostrarRadButton.Click
        'Mostrar los numero desde 1 - 25 y 40 - 1
        If (ListarNumeroListBox.Items.Count() > 0) Then
            ListarNumeroListBox.Items.Clear()
        End If
        ListarNumeroListBox.Items.Add("===== 1 A 25 =====")
        For i As Integer = 1 To 25
            ListarNumeroListBox.Items.Add(String.Format("{0}", i.ToString()))
        Next
        ListarNumeroListBox.Items.Add("===== 40 A 1 =====")
        Dim num As Integer = 40
        While (num >= 1)
            ListarNumeroListBox.Items.Add(String.Format("{0}", num.ToString()))
            num = num - 1

        End While
    End Sub

    Private Sub BorrarRadButton_Click(sender As Object, e As EventArgs) Handles BorrarRadButton.Click
        If (ListarNumeroListBox.Items.Count() > 0) Then
            ListarNumeroListBox.Items.Clear()
        End If
    End Sub
End Class