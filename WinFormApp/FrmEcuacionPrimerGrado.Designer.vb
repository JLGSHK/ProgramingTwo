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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadMaskedEditBox1 = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadMaskedEditBox2 = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadMaskedEditBox3 = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadMaskedEditBox4 = New Telerik.WinControls.UI.RadMaskedEditBox()
        CType(Me.RadMaskedEditBox1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadMaskedEditBox2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadMaskedEditBox3,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadMaskedEditBox4,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(131, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "+"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(204, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "="
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(163, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Resultado"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'RadMaskedEditBox1
        '
        Me.RadMaskedEditBox1.Location = New System.Drawing.Point(12, 10)
        Me.RadMaskedEditBox1.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.RadMaskedEditBox1.Name = "RadMaskedEditBox1"
        Me.RadMaskedEditBox1.Size = New System.Drawing.Size(45, 24)
        Me.RadMaskedEditBox1.TabIndex = 0
        Me.RadMaskedEditBox1.TabStop = false
        Me.RadMaskedEditBox1.Text = "0"
        '
        'RadMaskedEditBox2
        '
        Me.RadMaskedEditBox2.Location = New System.Drawing.Point(63, 12)
        Me.RadMaskedEditBox2.Name = "RadMaskedEditBox2"
        Me.RadMaskedEditBox2.Size = New System.Drawing.Size(45, 24)
        Me.RadMaskedEditBox2.TabIndex = 1
        Me.RadMaskedEditBox2.TabStop = false
        '
        'RadMaskedEditBox3
        '
        Me.RadMaskedEditBox3.Location = New System.Drawing.Point(153, 12)
        Me.RadMaskedEditBox3.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.RadMaskedEditBox3.Name = "RadMaskedEditBox3"
        Me.RadMaskedEditBox3.Size = New System.Drawing.Size(45, 24)
        Me.RadMaskedEditBox3.TabIndex = 3
        Me.RadMaskedEditBox3.TabStop = false
        Me.RadMaskedEditBox3.Text = "0"
        '
        'RadMaskedEditBox4
        '
        Me.RadMaskedEditBox4.Location = New System.Drawing.Point(226, 12)
        Me.RadMaskedEditBox4.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.RadMaskedEditBox4.Name = "RadMaskedEditBox4"
        Me.RadMaskedEditBox4.Size = New System.Drawing.Size(55, 24)
        Me.RadMaskedEditBox4.TabIndex = 5
        Me.RadMaskedEditBox4.TabStop = false
        Me.RadMaskedEditBox4.Text = "0"
        '
        'FrmEcuacionPrimerGrado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 113)
        Me.Controls.Add(Me.RadMaskedEditBox4)
        Me.Controls.Add(Me.RadMaskedEditBox3)
        Me.Controls.Add(Me.RadMaskedEditBox2)
        Me.Controls.Add(Me.RadMaskedEditBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmEcuacionPrimerGrado"
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ecuación de Primer Grado"
        CType(Me.RadMaskedEditBox1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadMaskedEditBox2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadMaskedEditBox3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadMaskedEditBox4,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RadMaskedEditBox1 As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadMaskedEditBox2 As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadMaskedEditBox3 As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadMaskedEditBox4 As Telerik.WinControls.UI.RadMaskedEditBox
End Class
