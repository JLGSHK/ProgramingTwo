<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTablaMultiplicar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumeroRadMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.TablaRadListView = New Telerik.WinControls.UI.RadListView()
        CType(Me.NumeroRadMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaRadListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero"
        '
        'NumeroRadMaskedEditBox
        '
        Me.NumeroRadMaskedEditBox.Location = New System.Drawing.Point(17, 51)
        Me.NumeroRadMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.NumeroRadMaskedEditBox.Name = "NumeroRadMaskedEditBox"
        Me.NumeroRadMaskedEditBox.Size = New System.Drawing.Size(130, 24)
        Me.NumeroRadMaskedEditBox.TabIndex = 1
        Me.NumeroRadMaskedEditBox.TabStop = False
        Me.NumeroRadMaskedEditBox.Text = "0"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(153, 21)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(151, 54)
        Me.RadButton1.TabIndex = 2
        Me.RadButton1.Text = "Generar Tabla"
        '
        'TablaRadListView
        '
        Me.TablaRadListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablaRadListView.Location = New System.Drawing.Point(17, 95)
        Me.TablaRadListView.Name = "TablaRadListView"
        Me.TablaRadListView.Size = New System.Drawing.Size(287, 366)
        Me.TablaRadListView.TabIndex = 3
        Me.TablaRadListView.Text = "RadListView1"
        '
        'FrmTablaMultiplicar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 476)
        Me.Controls.Add(Me.TablaRadListView)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.NumeroRadMaskedEditBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTablaMultiplicar"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabla de multiplicar"
        CType(Me.NumeroRadMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaRadListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NumeroRadMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents TablaRadListView As Telerik.WinControls.UI.RadListView
End Class
