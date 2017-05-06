<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGeneralFormula
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ARadMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.BRadMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.CRadMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CalcularRadButton = New Telerik.WinControls.UI.RadButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARadMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BRadMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRadMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalcularRadButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WinFormApp.My.Resources.Resources.formula
        Me.PictureBox1.Location = New System.Drawing.Point(12, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Formula General"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(321, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese los valores A,B y C"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ARadMaskedEditBox
        '
        Me.ARadMaskedEditBox.Location = New System.Drawing.Point(73, 234)
        Me.ARadMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.ARadMaskedEditBox.Name = "ARadMaskedEditBox"
        Me.ARadMaskedEditBox.Size = New System.Drawing.Size(48, 24)
        Me.ARadMaskedEditBox.TabIndex = 5
        Me.ARadMaskedEditBox.TabStop = False
        Me.ARadMaskedEditBox.Text = "0"
        Me.ARadMaskedEditBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BRadMaskedEditBox
        '
        Me.BRadMaskedEditBox.Location = New System.Drawing.Point(127, 234)
        Me.BRadMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.BRadMaskedEditBox.Name = "BRadMaskedEditBox"
        Me.BRadMaskedEditBox.Size = New System.Drawing.Size(48, 24)
        Me.BRadMaskedEditBox.TabIndex = 6
        Me.BRadMaskedEditBox.TabStop = False
        Me.BRadMaskedEditBox.Text = "0"
        Me.BRadMaskedEditBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CRadMaskedEditBox
        '
        Me.CRadMaskedEditBox.Location = New System.Drawing.Point(181, 234)
        Me.CRadMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.CRadMaskedEditBox.Name = "CRadMaskedEditBox"
        Me.CRadMaskedEditBox.Size = New System.Drawing.Size(48, 24)
        Me.CRadMaskedEditBox.TabIndex = 8
        Me.CRadMaskedEditBox.TabStop = False
        Me.CRadMaskedEditBox.Text = "0"
        Me.CRadMaskedEditBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "A"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(142, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "B"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(198, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "C"
        '
        'CalcularRadButton
        '
        Me.CalcularRadButton.Location = New System.Drawing.Point(73, 280)
        Me.CalcularRadButton.Name = "CalcularRadButton"
        Me.CalcularRadButton.Size = New System.Drawing.Size(156, 69)
        Me.CalcularRadButton.TabIndex = 0
        Me.CalcularRadButton.Text = "Calcular"
        '
        'FrmGeneralFormula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 361)
        Me.Controls.Add(Me.CalcularRadButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BRadMaskedEditBox)
        Me.Controls.Add(Me.ARadMaskedEditBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CRadMaskedEditBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGeneralFormula"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formula General"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARadMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BRadMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRadMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalcularRadButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ARadMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents BRadMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents CRadMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CalcularRadButton As Telerik.WinControls.UI.RadButton
End Class
