<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPares1A200
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
        Me.NumeroEncontradoLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumerosRadListView = New Telerik.WinControls.UI.RadListView()
        Me.GenerarNumeroRadButton = New Telerik.WinControls.UI.RadButton()
        CType(Me.NumerosRadListView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenerarNumeroRadButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumeroEncontradoLabel
        '
        Me.NumeroEncontradoLabel.AutoSize = True
        Me.NumeroEncontradoLabel.Location = New System.Drawing.Point(571, 136)
        Me.NumeroEncontradoLabel.Name = "NumeroEncontradoLabel"
        Me.NumeroEncontradoLabel.Size = New System.Drawing.Size(51, 17)
        Me.NumeroEncontradoLabel.TabIndex = 9
        Me.NumeroEncontradoLabel.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(346, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cantidad de números encontrado"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(373, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 38)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Resultado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumerosRadListView
        '
        Me.NumerosRadListView.Location = New System.Drawing.Point(-6, 81)
        Me.NumerosRadListView.Name = "NumerosRadListView"
        Me.NumerosRadListView.Size = New System.Drawing.Size(346, 546)
        Me.NumerosRadListView.TabIndex = 6
        Me.NumerosRadListView.Text = "RadListView1"
        '
        'GenerarNumeroRadButton
        '
        Me.GenerarNumeroRadButton.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerarNumeroRadButton.Location = New System.Drawing.Point(12, 12)
        Me.GenerarNumeroRadButton.Name = "GenerarNumeroRadButton"
        Me.GenerarNumeroRadButton.Size = New System.Drawing.Size(672, 47)
        Me.GenerarNumeroRadButton.TabIndex = 5
        Me.GenerarNumeroRadButton.Text = "Click para Generar numeros pares desde 1 al 200, incluyendo el 200"
        '
        'FrmPares1A200
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
        Me.Name = "FrmPares1A200"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Números pares del 1 al 200"
        CType(Me.NumerosRadListView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenerarNumeroRadButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumeroEncontradoLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NumerosRadListView As Telerik.WinControls.UI.RadListView
    Friend WithEvents GenerarNumeroRadButton As Telerik.WinControls.UI.RadButton
End Class
