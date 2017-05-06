Public Class FrmHomeApp
    Private Sub ImparesRadButton_Click(sender As Object, e As EventArgs)
        Dim frm As New FrmImpares1A400()
        frm.ShowDialog()
    End Sub

    Private Sub ParesRadButton_Click(sender As Object, e As EventArgs)
        Dim frm As New FrmPares1A200
        frm.ShowDialog()
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs)
        Dim pro As New FrmCalcNotes()
        pro.ShowDialog()
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs)
        Dim pro As New FrmOperacionesBasicas()
        pro.ShowDialog()
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs)
        Dim tabla As New FrmTablaMultiplicar()
        tabla.ShowDialog()
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs)
        Dim area As New FrmAreaTriangulo()
        area.ShowDialog()
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs)
        Dim sc As New FrmCelsiusAndFahrenheit()
        sc.ShowDialog()
    End Sub

    Private Sub PromedioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PromedioToolStripMenuItem1.Click
        Dim note As FrmCalcNotes = New FrmCalcNotes()
        note.MdiParent = Me
        note.Show()
    End Sub

    Private Sub TablaDeMultiplicarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TablaDeMultiplicarToolStripMenuItem.Click
        Dim tabla As FrmTablaMultiplicar = New FrmTablaMultiplicar()
        tabla.MdiParent = Me
        tabla.Show()

    End Sub

    Private Sub NúmerosImpartesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NúmerosImpartesToolStripMenuItem.Click
        Dim impares400 As FrmImpares1A400 = New FrmImpares1A400()
        impares400.MdiParent = Me
        impares400.Show()

    End Sub

    Private Sub NúmerosParesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NúmerosParesToolStripMenuItem.Click
        Dim pares As FrmPares1A200 = New FrmPares1A200()
        pares.MdiParent = Me
        pares.Show()

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim num As Frm1To25And40To1 = New Frm1To25And40To1()
        num.MdiParent = Me
        num.Show()
    End Sub

    Private Sub FormulaGeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormulaGeneralToolStripMenuItem.Click
        Dim num As FrmGeneralFormula = New FrmGeneralFormula()
        num.MdiParent = Me
        num.Show()
    End Sub

    Private Sub ÁreaTrianguloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁreaTrianguloToolStripMenuItem.Click
        Dim area As FrmAreaTriangulo = New FrmAreaTriangulo()
        area.MdiParent = Me
        area.Show()
    End Sub

    Private Sub ÁreaCilindroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÁreaCilindroToolStripMenuItem.Click
        Dim area As FrmAreaCilindro = New FrmAreaCilindro()
        area.MdiParent = Me
        area.Show()
    End Sub

    Private Sub CFYFCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CFYFCToolStripMenuItem.Click
        Dim fccf As FrmCelsiusAndFahrenheit = New FrmCelsiusAndFahrenheit()
        fccf.MdiParent = Me
        fccf.Show()
    End Sub

    Private Sub FactorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FactorialToolStripMenuItem.Click
        Dim factorial As FrmFactorial = New FrmFactorial()
        factorial.MdiParent = Me
        factorial.Show()
    End Sub

    Private Sub NúmerosPrimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NúmerosPrimosToolStripMenuItem.Click
        Dim primo As FrmNumPrimo200To1 = New FrmNumPrimo200To1()
        primo.MdiParent = Me
        primo.Show()

    End Sub

    Private Sub IndiceAcadémicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndiceAcadémicoToolStripMenuItem.Click
        Dim indice As CalcularIndiceAcademico = New CalcularIndiceAcademico()
        indice.MdiParent = Me
        indice.Show()
    End Sub

    Private Sub DistanciaFechaYTiempoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistanciaFechaYTiempoToolStripMenuItem.Click
        Dim distancia As DiferentDates = New DiferentDates()
        distancia.MdiParent = Me
        distancia.Show()
    End Sub

    Private Sub EntradaDeNúmerosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaDeNúmerosToolStripMenuItem.Click
        Dim entrada As FrmEntrada = New FrmEntrada()
        entrada.MdiParent = Me
        entrada.Show()
    End Sub

    Private Sub BasicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BasicaToolStripMenuItem.Click
        Dim basica As FrmOperacionesBasicas = New FrmOperacionesBasicas()
        basica.MdiParent = Me
        basica.Show()
    End Sub

    Private Sub Matriz2x2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Matriz2x2ToolStripMenuItem.Click
        Dim matriz As FrmMatriz = New FrmMatriz()
        matriz.MdiParent = Me
        matriz.Show()
    End Sub

    Private Sub MCMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MCMToolStripMenuItem.Click
        Dim mcm As FrmMCM = New FrmMCM()
        mcm.MdiParent = Me
        mcm.Show()
    End Sub

    Private Sub FraccionarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FraccionarioToolStripMenuItem.Click
        Dim frm As FrmOperacionesNumeroFraccionario = New FrmOperacionesNumeroFraccionario()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SerieFibonacciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SerieFibonacciToolStripMenuItem.Click
        Dim fibonacci As FrmFibonacci = New FrmFibonacci()
        fibonacci.MdiParent = Me
        fibonacci.Show()
    End Sub

    Private Sub EcuaciónDePrimerGradoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EcuaciónDePrimerGradoToolStripMenuItem.Click
        Dim ecuacion As FrmEcuacionPrimerGrado = New FrmEcuacionPrimerGrado()
        ecuacion.MdiParent = Me
        ecuacion.Show()
    End Sub
End Class