<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOperacionesBasicas
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
        Me.SumaRadRadioButton = New Telerik.WinControls.UI.RadRadioButton()
        Me.RestaRadRadioButton = New Telerik.WinControls.UI.RadRadioButton()
        Me.DivisionRadRadioButton = New Telerik.WinControls.UI.RadRadioButton()
        Me.MultiplicacionRadRadioButton = New Telerik.WinControls.UI.RadRadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Num1RadMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Num2RadMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        CType(Me.SumaRadRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaRadRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DivisionRadRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MultiplicacionRadRadioButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Num1RadMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num2RadMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SumaRadRadioButton
        '
        Me.SumaRadRadioButton.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SumaRadRadioButton.Location = New System.Drawing.Point(21, 21)
        Me.SumaRadRadioButton.Name = "SumaRadRadioButton"
        Me.SumaRadRadioButton.Size = New System.Drawing.Size(56, 22)
        Me.SumaRadRadioButton.TabIndex = 0
        Me.SumaRadRadioButton.Text = "Suma"
        Me.SumaRadRadioButton.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'RestaRadRadioButton
        '
        Me.RestaRadRadioButton.Location = New System.Drawing.Point(21, 49)
        Me.RestaRadRadioButton.Name = "RestaRadRadioButton"
        Me.RestaRadRadioButton.Size = New System.Drawing.Size(55, 22)
        Me.RestaRadRadioButton.TabIndex = 1
        Me.RestaRadRadioButton.TabStop = False
        Me.RestaRadRadioButton.Text = "Resta"
        '
        'DivisionRadRadioButton
        '
        Me.DivisionRadRadioButton.Location = New System.Drawing.Point(123, 21)
        Me.DivisionRadRadioButton.Name = "DivisionRadRadioButton"
        Me.DivisionRadRadioButton.Size = New System.Drawing.Size(70, 22)
        Me.DivisionRadRadioButton.TabIndex = 2
        Me.DivisionRadRadioButton.TabStop = False
        Me.DivisionRadRadioButton.Text = "División"
        '
        'MultiplicacionRadRadioButton
        '
        Me.MultiplicacionRadRadioButton.Location = New System.Drawing.Point(123, 49)
        Me.MultiplicacionRadRadioButton.Name = "MultiplicacionRadRadioButton"
        Me.MultiplicacionRadRadioButton.Size = New System.Drawing.Size(109, 22)
        Me.MultiplicacionRadRadioButton.TabIndex = 3
        Me.MultiplicacionRadRadioButton.TabStop = False
        Me.MultiplicacionRadRadioButton.Text = "Multiplicación"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SumaRadRadioButton)
        Me.GroupBox1.Controls.Add(Me.MultiplicacionRadRadioButton)
        Me.GroupBox1.Controls.Add(Me.RestaRadRadioButton)
        Me.GroupBox1.Controls.Add(Me.DivisionRadRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 90)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operaciones Básicas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Número 2"
        '
        'Num1RadMaskedEditBox
        '
        Me.Num1RadMaskedEditBox.Location = New System.Drawing.Point(88, 117)
        Me.Num1RadMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.Num1RadMaskedEditBox.Name = "Num1RadMaskedEditBox"
        Me.Num1RadMaskedEditBox.Size = New System.Drawing.Size(182, 24)
        Me.Num1RadMaskedEditBox.TabIndex = 2
        Me.Num1RadMaskedEditBox.TabStop = False
        Me.Num1RadMaskedEditBox.Text = "0"
        Me.Num1RadMaskedEditBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Num2RadMaskedEditBox
        '
        Me.Num2RadMaskedEditBox.Location = New System.Drawing.Point(88, 159)
        Me.Num2RadMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.Num2RadMaskedEditBox.Name = "Num2RadMaskedEditBox"
        Me.Num2RadMaskedEditBox.Size = New System.Drawing.Size(182, 24)
        Me.Num2RadMaskedEditBox.TabIndex = 4
        Me.Num2RadMaskedEditBox.TabStop = False
        Me.Num2RadMaskedEditBox.Text = "0"
        Me.Num2RadMaskedEditBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(12, 195)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(258, 46)
        Me.RadButton1.TabIndex = 5
        Me.RadButton1.Text = "="
        '
        'FrmOperacionesBasicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.Num2RadMaskedEditBox)
        Me.Controls.Add(Me.Num1RadMaskedEditBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOperacionesBasicas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operaciones Básicas"
        CType(Me.SumaRadRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaRadRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DivisionRadRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MultiplicacionRadRadioButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Num1RadMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num2RadMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SumaRadRadioButton As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RestaRadRadioButton As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents DivisionRadRadioButton As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents MultiplicacionRadRadioButton As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Num1RadMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Num2RadMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class
