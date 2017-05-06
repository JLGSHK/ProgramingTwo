<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOperacionesNumeroFraccionario
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
        Me.RestaRadioButton = New System.Windows.Forms.RadioButton()
        Me.DivisionRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplicacionRadioButton = New System.Windows.Forms.RadioButton()
        Me.SumaRadioButton = New System.Windows.Forms.RadioButton()
        Me.NumeradorIzquierdo = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.DenominadorIzquierdo = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.NumeradorDerecho = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.DenominadorDerecho = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OperacionLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumeradorIzquierdo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DenominadorIzquierdo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumeradorDerecho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DenominadorDerecho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RestaRadioButton)
        Me.GroupBox1.Controls.Add(Me.DivisionRadioButton)
        Me.GroupBox1.Controls.Add(Me.MultiplicacionRadioButton)
        Me.GroupBox1.Controls.Add(Me.SumaRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione la operación a realizar"
        '
        'RestaRadioButton
        '
        Me.RestaRadioButton.AutoSize = True
        Me.RestaRadioButton.Location = New System.Drawing.Point(7, 49)
        Me.RestaRadioButton.Name = "RestaRadioButton"
        Me.RestaRadioButton.Size = New System.Drawing.Size(66, 21)
        Me.RestaRadioButton.TabIndex = 1
        Me.RestaRadioButton.Text = "Resta"
        Me.RestaRadioButton.UseVisualStyleBackColor = True
        '
        'DivisionRadioButton
        '
        Me.DivisionRadioButton.AutoSize = True
        Me.DivisionRadioButton.Location = New System.Drawing.Point(180, 49)
        Me.DivisionRadioButton.Name = "DivisionRadioButton"
        Me.DivisionRadioButton.Size = New System.Drawing.Size(78, 21)
        Me.DivisionRadioButton.TabIndex = 3
        Me.DivisionRadioButton.Text = "División"
        Me.DivisionRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplicacionRadioButton
        '
        Me.MultiplicacionRadioButton.AutoSize = True
        Me.MultiplicacionRadioButton.Location = New System.Drawing.Point(180, 21)
        Me.MultiplicacionRadioButton.Name = "MultiplicacionRadioButton"
        Me.MultiplicacionRadioButton.Size = New System.Drawing.Size(113, 21)
        Me.MultiplicacionRadioButton.TabIndex = 2
        Me.MultiplicacionRadioButton.Text = "Multiplicación"
        Me.MultiplicacionRadioButton.UseVisualStyleBackColor = True
        '
        'SumaRadioButton
        '
        Me.SumaRadioButton.AutoSize = True
        Me.SumaRadioButton.Checked = True
        Me.SumaRadioButton.Location = New System.Drawing.Point(7, 22)
        Me.SumaRadioButton.Name = "SumaRadioButton"
        Me.SumaRadioButton.Size = New System.Drawing.Size(65, 21)
        Me.SumaRadioButton.TabIndex = 0
        Me.SumaRadioButton.TabStop = True
        Me.SumaRadioButton.Text = "Suma"
        Me.SumaRadioButton.UseVisualStyleBackColor = True
        '
        'NumeradorIzquierdo
        '
        Me.NumeradorIzquierdo.Location = New System.Drawing.Point(19, 133)
        Me.NumeradorIzquierdo.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.NumeradorIzquierdo.Name = "NumeradorIzquierdo"
        Me.NumeradorIzquierdo.Size = New System.Drawing.Size(65, 24)
        Me.NumeradorIzquierdo.TabIndex = 1
        Me.NumeradorIzquierdo.TabStop = False
        Me.NumeradorIzquierdo.Text = "0"
        Me.NumeradorIzquierdo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DenominadorIzquierdo
        '
        Me.DenominadorIzquierdo.Location = New System.Drawing.Point(20, 201)
        Me.DenominadorIzquierdo.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.DenominadorIzquierdo.Name = "DenominadorIzquierdo"
        Me.DenominadorIzquierdo.Size = New System.Drawing.Size(65, 24)
        Me.DenominadorIzquierdo.TabIndex = 3
        Me.DenominadorIzquierdo.TabStop = False
        Me.DenominadorIzquierdo.Text = "0"
        Me.DenominadorIzquierdo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumeradorDerecho
        '
        Me.NumeradorDerecho.Location = New System.Drawing.Point(192, 133)
        Me.NumeradorDerecho.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.NumeradorDerecho.Name = "NumeradorDerecho"
        Me.NumeradorDerecho.Size = New System.Drawing.Size(65, 24)
        Me.NumeradorDerecho.TabIndex = 5
        Me.NumeradorDerecho.TabStop = False
        Me.NumeradorDerecho.Text = "0"
        Me.NumeradorDerecho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DenominadorDerecho
        '
        Me.DenominadorDerecho.Location = New System.Drawing.Point(192, 201)
        Me.DenominadorDerecho.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.DenominadorDerecho.Name = "DenominadorDerecho"
        Me.DenominadorDerecho.Size = New System.Drawing.Size(65, 24)
        Me.DenominadorDerecho.TabIndex = 7
        Me.DenominadorDerecho.TabStop = False
        Me.DenominadorDerecho.Text = "0"
        Me.DenominadorDerecho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(19, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 41)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "----------"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(191, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 41)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "----------"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OperacionLabel
        '
        Me.OperacionLabel.Location = New System.Drawing.Point(110, 160)
        Me.OperacionLabel.Name = "OperacionLabel"
        Me.OperacionLabel.Size = New System.Drawing.Size(66, 41)
        Me.OperacionLabel.TabIndex = 4
        Me.OperacionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(299, 103)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Resultado"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmOperacionesNumeroFraccionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 384)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OperacionLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DenominadorDerecho)
        Me.Controls.Add(Me.NumeradorDerecho)
        Me.Controls.Add(Me.DenominadorIzquierdo)
        Me.Controls.Add(Me.NumeradorIzquierdo)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOperacionesNumeroFraccionario"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operaciones números fraccionario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumeradorIzquierdo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DenominadorIzquierdo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumeradorDerecho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DenominadorDerecho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RestaRadioButton As RadioButton
    Friend WithEvents SumaRadioButton As RadioButton
    Friend WithEvents DivisionRadioButton As RadioButton
    Friend WithEvents MultiplicacionRadioButton As RadioButton
    Friend WithEvents NumeradorIzquierdo As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents DenominadorIzquierdo As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents NumeradorDerecho As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents DenominadorDerecho As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OperacionLabel As Label
    Friend WithEvents Button1 As Button
End Class
