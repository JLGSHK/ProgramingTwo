<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntrada
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
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumRadMaskedEditBox = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.MostrarRadListView = New Telerik.WinControls.UI.RadListView()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumRadMaskedEditBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarRadListView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.AutoSize = False
        Me.RadLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(0, 0)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(596, 76)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Determinar si los números ingresador es par o impar, y cuales son positivos y neg" &
    "ativos"
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Número:"
        '
        'NumRadMaskedEditBox
        '
        Me.NumRadMaskedEditBox.Location = New System.Drawing.Point(82, 106)
        Me.NumRadMaskedEditBox.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.NumRadMaskedEditBox.Name = "NumRadMaskedEditBox"
        Me.NumRadMaskedEditBox.Size = New System.Drawing.Size(101, 24)
        Me.NumRadMaskedEditBox.TabIndex = 2
        Me.NumRadMaskedEditBox.TabStop = False
        Me.NumRadMaskedEditBox.Text = "0"
        Me.NumRadMaskedEditBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(16, 148)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(167, 92)
        Me.RadButton1.TabIndex = 1
        Me.RadButton1.Text = "Determinar"
        '
        'MostrarRadListView
        '
        Me.MostrarRadListView.Location = New System.Drawing.Point(212, 106)
        Me.MostrarRadListView.Name = "MostrarRadListView"
        Me.MostrarRadListView.Size = New System.Drawing.Size(372, 230)
        Me.MostrarRadListView.TabIndex = 3
        Me.MostrarRadListView.Text = "RadListView1"
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(16, 247)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(167, 89)
        Me.RadButton2.TabIndex = 4
        Me.RadButton2.Text = "Limpiar Valores"
        '
        'FrmEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 348)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.MostrarRadListView)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.NumRadMaskedEditBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEntrada"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumRadMaskedEditBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarRadListView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents NumRadMaskedEditBox As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents MostrarRadListView As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
End Class
