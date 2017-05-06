Public Class Form1
    Dim lista As ArrayList = New ArrayList()
    Dim listaNegativo As ArrayList = New ArrayList()
    Dim acuNegativo As Integer = 0
    Dim acuPositivo As Integer = 0
    Dim sumaNegativo As Integer = 0
    Dim sumaPositivo As Integer = 0

    Function ValidarNumero(valor As Integer) As Boolean

        If (lista.Count = 0) Then
            Return False
        Else
            For Each dato As Integer In lista
                If (dato = valor) Then
                    Return True
                End If
            Next
            Return False
        End If

        Return False
    End Function

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim random As Random = New Random()
        Dim valor As Integer = 0
        ' For i As Integer = 5 To 19
        '     valor = random.Next(5, 19)
        '    lista.Add(valor)
        'Next

        While lista.Count <= 15

            valor = random.Next(1, 200)
            If (ValidarNumero(valor) = False) Then
                lista.Add(valor)
            End If

        End While

        For i As Integer = 0 To 6
            acuNegativo = lista.Item(i) * -1
            lista.RemoveAt(i)
            listaNegativo.Add(acuNegativo)
            RadListViewNegativos.Items.Add(acuNegativo.ToString())
            sumaNegativo += acuNegativo
        Next

        lista.Sort()
        For i As Integer = 0 To 7
            acuPositivo = lista.Item(i)
            RadListViewPositivo.Items.Add(acuPositivo)
            sumaPositivo += acuPositivo
        Next

        RadLabelNegativos.Text = String.Format("Son {0}", listaNegativo.Count)
        RadLabelPositivos.Text = String.Format("Son {0}", lista.Count)
        RadLabelSumaNegativo.Text = String.Format("{0}", sumaNegativo.ToString())
        RadLabelSumaPositivos.Text = String.Format("{0}", sumaPositivo.ToString())

        Dim convertirApositivo = sumaNegativo * -1
        Dim convertirAnegativo = sumaPositivo * -1
        LabelConvertir.Text = String.Format("{0} ===== {1}", convertirApositivo, convertirAnegativo)
        Dim acuRestado As Integer = (convertirApositivo - (-convertirAnegativo))
        LabelResta.Text = String.Format("{0}", acuRestado)

        Dim porciento As Double = 0
        porciento = ((acuRestado * 8) / 100) + acuRestado
        LabelPorCiento.Text = String.Format("{0}", porciento)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadLabelNegativos.Text = String.Empty
        RadLabelPositivos.Text = String.Empty
        RadLabelSumaNegativo.Text = String.Empty
        RadLabelSumaPositivos.Text = String.Empty
        LabelConvertir.Text = String.Empty
        LabelResta.Text = String.Empty
        LabelPorCiento.Text = String.Empty
    End Sub
End Class