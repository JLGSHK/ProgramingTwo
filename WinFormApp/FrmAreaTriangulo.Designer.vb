<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAreaTriangulo
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BaseRadMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.AlturaRadMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        CType(Me.BaseRadMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlturaRadMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Base"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Altura"
        '
        'BaseRadMaskedEditBox
        '
        Me.BaseRadMaskedEditBox.Location = New System.Drawing.Point(96, 25)
        Me.BaseRadMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.BaseRadMaskedEditBox.Name = "BaseRadMaskedEditBox"
        Me.BaseRadMaskedEditBox.Size = New System.Drawing.Size(125, 24)
        Me.BaseRadMaskedEditBox.TabIndex = 2
        Me.BaseRadMaskedEditBox.TabStop = False
        Me.BaseRadMaskedEditBox.Text = "0"
        '
        'AlturaRadMaskedEditBox
        '
        Me.AlturaRadMaskedEditBox.Location = New System.Drawing.Point(96, 62)
        Me.AlturaRadMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.AlturaRadMaskedEditBox.Name = "AlturaRadMaskedEditBox"
        Me.AlturaRadMaskedEditBox.Size = New System.Drawing.Size(125, 24)
        Me.AlturaRadMaskedEditBox.TabIndex = 3
        Me.AlturaRadMaskedEditBox.TabStop = False
        Me.AlturaRadMaskedEditBox.Text = "0"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(13, 107)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(235, 43)
        Me.RadButton1.TabIndex = 4
        Me.RadButton1.Text = "Calcular"
        '
        'FrmAreaTriangulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 173)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.AlturaRadMaskedEditBox)
        Me.Controls.Add(Me.BaseRadMaskedEditBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAreaTriangulo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcular Area de Triangulo"
        CType(Me.BaseRadMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlturaRadMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BaseRadMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents AlturaRadMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class
