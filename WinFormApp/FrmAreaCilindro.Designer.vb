<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAreaCilindro
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadMaskedEditBox1 = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadMaskedEditBox2 = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadMaskedEditBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMaskedEditBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Radio"
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(352, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Calcular el área del cilindro"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Altura"
        '
        'RadMaskedEditBox1
        '
        Me.RadMaskedEditBox1.Location = New System.Drawing.Point(108, 64)
        Me.RadMaskedEditBox1.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.RadMaskedEditBox1.Name = "RadMaskedEditBox1"
        Me.RadMaskedEditBox1.Size = New System.Drawing.Size(156, 24)
        Me.RadMaskedEditBox1.TabIndex = 3
        Me.RadMaskedEditBox1.TabStop = False
        Me.RadMaskedEditBox1.Text = "0"
        '
        'RadMaskedEditBox2
        '
        Me.RadMaskedEditBox2.Location = New System.Drawing.Point(107, 100)
        Me.RadMaskedEditBox2.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.RadMaskedEditBox2.Name = "RadMaskedEditBox2"
        Me.RadMaskedEditBox2.Size = New System.Drawing.Size(156, 24)
        Me.RadMaskedEditBox2.TabIndex = 4
        Me.RadMaskedEditBox2.TabStop = False
        Me.RadMaskedEditBox2.Text = "0"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(12, 175)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(328, 53)
        Me.RadButton1.TabIndex = 5
        Me.RadButton1.Text = "Calcular Área Cilindro"
        '
        'FrmAreaCilindro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 251)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadMaskedEditBox2)
        Me.Controls.Add(Me.RadMaskedEditBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAreaCilindro"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area Cilindro"
        CType(Me.RadMaskedEditBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadMaskedEditBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadMaskedEditBox1 As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadMaskedEditBox2 As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class
