<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCelsiusAndFahrenheit
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FtoCRadioButton = New System.Windows.Forms.RadioButton()
        Me.CtoFRadioButton = New System.Windows.Forms.RadioButton()
        Me.NumRadMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.ConvertirRadButton = New Telerik.WinControls.UI.RadButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumRadMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConvertirRadButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CtoFRadioButton)
        Me.GroupBox1.Controls.Add(Me.FtoCRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecciona"
        '
        'FtoCRadioButton
        '
        Me.FtoCRadioButton.AutoSize = True
        Me.FtoCRadioButton.Location = New System.Drawing.Point(22, 57)
        Me.FtoCRadioButton.Name = "FtoCRadioButton"
        Me.FtoCRadioButton.Size = New System.Drawing.Size(158, 21)
        Me.FtoCRadioButton.TabIndex = 0
        Me.FtoCRadioButton.TabStop = True
        Me.FtoCRadioButton.Text = "Fahrenheit a Celsius"
        Me.FtoCRadioButton.UseVisualStyleBackColor = True
        '
        'CtoFRadioButton
        '
        Me.CtoFRadioButton.AutoSize = True
        Me.CtoFRadioButton.Checked = True
        Me.CtoFRadioButton.Location = New System.Drawing.Point(22, 30)
        Me.CtoFRadioButton.Name = "CtoFRadioButton"
        Me.CtoFRadioButton.Size = New System.Drawing.Size(158, 21)
        Me.CtoFRadioButton.TabIndex = 0
        Me.CtoFRadioButton.TabStop = True
        Me.CtoFRadioButton.Text = "Celsius a Fahrenheit"
        Me.CtoFRadioButton.UseVisualStyleBackColor = True
        '
        'NumRadMaskedEditBox
        '
        Me.NumRadMaskedEditBox.Location = New System.Drawing.Point(12, 137)
        Me.NumRadMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.NumRadMaskedEditBox.Name = "NumRadMaskedEditBox"
        Me.NumRadMaskedEditBox.Size = New System.Drawing.Size(151, 24)
        Me.NumRadMaskedEditBox.TabIndex = 1
        Me.NumRadMaskedEditBox.TabStop = False
        Me.NumRadMaskedEditBox.Text = "0"
        '
        'ConvertirRadButton
        '
        Me.ConvertirRadButton.Location = New System.Drawing.Point(173, 137)
        Me.ConvertirRadButton.Name = "ConvertirRadButton"
        Me.ConvertirRadButton.Size = New System.Drawing.Size(137, 30)
        Me.ConvertirRadButton.TabIndex = 2
        Me.ConvertirRadButton.Text = "Convertir"
        '
        'FrmCelsiusAndFahrenheit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 185)
        Me.Controls.Add(Me.ConvertirRadButton)
        Me.Controls.Add(Me.NumRadMaskedEditBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCelsiusAndFahrenheit"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convertirdor Celsius - Fahrenheit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumRadMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConvertirRadButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CtoFRadioButton As RadioButton
    Friend WithEvents FtoCRadioButton As RadioButton
    Friend WithEvents NumRadMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents ConvertirRadButton As Telerik.WinControls.UI.RadButton
End Class
