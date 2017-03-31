<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImpares1A400
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GenerarNumeroRadButton = New Telerik.WinControls.UI.RadButton()
        Me.NumerosRadListView = New Telerik.WinControls.UI.RadListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumeroEncontradoLabel = New System.Windows.Forms.Label()
        CType(Me.GenerarNumeroRadButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumerosRadListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GenerarNumeroRadButton
        '
        Me.GenerarNumeroRadButton.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerarNumeroRadButton.Location = New System.Drawing.Point(13, 13)
        Me.GenerarNumeroRadButton.Name = "GenerarNumeroRadButton"
        Me.GenerarNumeroRadButton.Size = New System.Drawing.Size(672, 47)
        Me.GenerarNumeroRadButton.TabIndex = 0
        Me.GenerarNumeroRadButton.Text = "Click para Generar numeros impares desde 1 al 400, incluyendo el 400"
        '
        'NumerosRadListView
        '
        Me.NumerosRadListView.Location = New System.Drawing.Point(13, 93)
        Me.NumerosRadListView.Name = "NumerosRadListView"
        Me.NumerosRadListView.Size = New System.Drawing.Size(346, 546)
        Me.NumerosRadListView.TabIndex = 1
        Me.NumerosRadListView.Text = "RadListView1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(392, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Resultado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(365, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad de números encontrado"
        '
        'NumeroEncontradoLabel
        '
        Me.NumeroEncontradoLabel.AutoSize = True
        Me.NumeroEncontradoLabel.Location = New System.Drawing.Point(590, 148)
        Me.NumeroEncontradoLabel.Name = "NumeroEncontradoLabel"
        Me.NumeroEncontradoLabel.Size = New System.Drawing.Size(51, 17)
        Me.NumeroEncontradoLabel.TabIndex = 4
        Me.NumeroEncontradoLabel.Text = "Label3"
        '
        'FrmImpares1A400
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 651)
        Me.Controls.Add(Me.NumeroEncontradoLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumerosRadListView)
        Me.Controls.Add(Me.GenerarNumeroRadButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImpares1A400"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Números impares 1 al 400"
        CType(Me.GenerarNumeroRadButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumerosRadListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GenerarNumeroRadButton As Telerik.WinControls.UI.RadButton
    Friend WithEvents NumerosRadListView As Telerik.WinControls.UI.RadListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumeroEncontradoLabel As Label
End Class
