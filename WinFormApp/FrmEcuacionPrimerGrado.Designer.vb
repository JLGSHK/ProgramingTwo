<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEcuacionPrimerGrado
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
        Me.Num1RadMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Num2RadMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        CType(Me.Num1RadMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num2RadMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X"
        '
        'Num1RadMaskedEditBox
        '
        Me.Num1RadMaskedEditBox.Location = New System.Drawing.Point(35, 29)
        Me.Num1RadMaskedEditBox.Name = "Num1RadMaskedEditBox"
        Me.Num1RadMaskedEditBox.Size = New System.Drawing.Size(41, 24)
        Me.Num1RadMaskedEditBox.TabIndex = 1
        Me.Num1RadMaskedEditBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "="
        '
        'Num2RadMaskedEditBox
        '
        Me.Num2RadMaskedEditBox.Location = New System.Drawing.Point(128, 29)
        Me.Num2RadMaskedEditBox.Name = "Num2RadMaskedEditBox"
        Me.Num2RadMaskedEditBox.Size = New System.Drawing.Size(41, 24)
        Me.Num2RadMaskedEditBox.TabIndex = 1
        Me.Num2RadMaskedEditBox.TabStop = False
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(186, 29)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(108, 27)
        Me.RadButton1.TabIndex = 3
        Me.RadButton1.Text = "Generar"
        '
        'FrmEcuacionPrimerGrado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 91)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Num2RadMaskedEditBox)
        Me.Controls.Add(Me.Num1RadMaskedEditBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEcuacionPrimerGrado"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ecuación Primer Grado"
        CType(Me.Num1RadMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num2RadMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Num1RadMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Num2RadMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class
