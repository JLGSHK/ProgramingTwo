<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFactorial
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
        Me.NumFactRadMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.MostrarFactorialListView = New Telerik.WinControls.UI.RadListView()
        CType(Me.NumFactRadMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarFactorialListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Factorial"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Factorial"
        '
        'NumFactRadMaskedEditBox
        '
        Me.NumFactRadMaskedEditBox.Location = New System.Drawing.Point(81, 70)
        Me.NumFactRadMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.NumFactRadMaskedEditBox.Name = "NumFactRadMaskedEditBox"
        Me.NumFactRadMaskedEditBox.Size = New System.Drawing.Size(216, 24)
        Me.NumFactRadMaskedEditBox.TabIndex = 2
        Me.NumFactRadMaskedEditBox.TabStop = False
        Me.NumFactRadMaskedEditBox.Text = "0"
        Me.NumFactRadMaskedEditBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(12, 121)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(285, 51)
        Me.RadButton1.TabIndex = 3
        Me.RadButton1.Text = "Generar Factorial"
        '
        'MostrarFactorialListView
        '
        Me.MostrarFactorialListView.Location = New System.Drawing.Point(12, 191)
        Me.MostrarFactorialListView.Name = "MostrarFactorialListView"
        Me.MostrarFactorialListView.Size = New System.Drawing.Size(285, 298)
        Me.MostrarFactorialListView.TabIndex = 4
        Me.MostrarFactorialListView.Text = "RadListView1"
        '
        'FrmFactorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 501)
        Me.Controls.Add(Me.MostrarFactorialListView)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.NumFactRadMaskedEditBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFactorial"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factorial"
        CType(Me.NumFactRadMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarFactorialListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumFactRadMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents MostrarFactorialListView As Telerik.WinControls.UI.RadListView
End Class
