Public Class FrmHomeApp
    Private Sub ImparesRadButton_Click(sender As Object, e As EventArgs) Handles ImparesRadButton.Click
        Dim frm As New FrmImpares1A400()
        frm.ShowDialog()
    End Sub

    Private Sub ParesRadButton_Click(sender As Object, e As EventArgs) Handles ParesRadButton.Click
        Dim frm As New FrmPares1A200
        frm.ShowDialog()
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Dim pro As New FrmCalcNotes()
        pro.ShowDialog()
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        Dim pro As New FrmOperacionesBasicas()
        pro.ShowDialog()
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Dim tabla As New FrmTablaMultiplicar()
        tabla.ShowDialog()
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click
        Dim area As New FrmAreaTriangulo()
        area.ShowDialog()
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        Dim sc As New FrmCelsiusAndFahrenheit()
        sc.ShowDialog()
    End Sub
End Class