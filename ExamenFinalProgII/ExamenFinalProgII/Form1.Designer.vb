<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadListViewNegativos = New Telerik.WinControls.UI.RadListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadListViewPositivo = New Telerik.WinControls.UI.RadListView()
        Me.RadLabelNegativos = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabelPositivos = New Telerik.WinControls.UI.RadLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadLabelSumaNegativo = New Telerik.WinControls.UI.RadLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadLabelSumaPositivos = New Telerik.WinControls.UI.RadLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelConvertir = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelResta = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelPorCiento = New System.Windows.Forms.Label()
        CType(Me.RadButton1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadListViewNegativos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadListViewPositivo,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabelNegativos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabelPositivos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabelSumaNegativo,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RadLabelSumaPositivos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'RadButton1
        '
        Me.RadButton1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.RadButton1.Location = New System.Drawing.Point(12, 12)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(704, 91)
        Me.RadButton1.TabIndex = 0
        Me.RadButton1.Text = "Procesar Operación"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Negativos:"
        '
        'RadListViewNegativos
        '
        Me.RadListViewNegativos.Location = New System.Drawing.Point(13, 188)
        Me.RadListViewNegativos.Name = "RadListViewNegativos"
        Me.RadListViewNegativos.Size = New System.Drawing.Size(197, 257)
        Me.RadListViewNegativos.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(247, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Positivos:"
        '
        'RadListViewPositivo
        '
        Me.RadListViewPositivo.Location = New System.Drawing.Point(253, 188)
        Me.RadListViewPositivo.Name = "RadListViewPositivo"
        Me.RadListViewPositivo.Size = New System.Drawing.Size(178, 257)
        Me.RadListViewPositivo.TabIndex = 3
        '
        'RadLabelNegativos
        '
        Me.RadLabelNegativos.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.RadLabelNegativos.Location = New System.Drawing.Point(18, 468)
        Me.RadLabelNegativos.Name = "RadLabelNegativos"
        Me.RadLabelNegativos.Size = New System.Drawing.Size(126, 35)
        Me.RadLabelNegativos.TabIndex = 4
        Me.RadLabelNegativos.Text = "RadLabel1"
        '
        'RadLabelPositivos
        '
        Me.RadLabelPositivos.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.RadLabelPositivos.Location = New System.Drawing.Point(253, 468)
        Me.RadLabelPositivos.Name = "RadLabelPositivos"
        Me.RadLabelPositivos.Size = New System.Drawing.Size(126, 35)
        Me.RadLabelPositivos.TabIndex = 4
        Me.RadLabelPositivos.Text = "RadLabel1"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(501, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Suma Negativos"
        '
        'RadLabelSumaNegativo
        '
        Me.RadLabelSumaNegativo.Location = New System.Drawing.Point(506, 230)
        Me.RadLabelSumaNegativo.Name = "RadLabelSumaNegativo"
        Me.RadLabelSumaNegativo.Size = New System.Drawing.Size(72, 22)
        Me.RadLabelSumaNegativo.TabIndex = 6
        Me.RadLabelSumaNegativo.Text = "RadLabel1"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(501, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Suma Positivos"
        '
        'RadLabelSumaPositivos
        '
        Me.RadLabelSumaPositivos.Location = New System.Drawing.Point(506, 323)
        Me.RadLabelSumaPositivos.Name = "RadLabelSumaPositivos"
        Me.RadLabelSumaPositivos.Size = New System.Drawing.Size(72, 22)
        Me.RadLabelSumaPositivos.TabIndex = 6
        Me.RadLabelSumaPositivos.Text = "RadLabel1"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(501, 363)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Convertir"
        '
        'LabelConvertir
        '
        Me.LabelConvertir.AutoSize = true
        Me.LabelConvertir.Location = New System.Drawing.Point(506, 410)
        Me.LabelConvertir.Name = "LabelConvertir"
        Me.LabelConvertir.Size = New System.Drawing.Size(51, 17)
        Me.LabelConvertir.TabIndex = 7
        Me.LabelConvertir.Text = "Label6"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(501, 445)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Resta"
        '
        'LabelResta
        '
        Me.LabelResta.AutoSize = true
        Me.LabelResta.Location = New System.Drawing.Point(506, 486)
        Me.LabelResta.Name = "LabelResta"
        Me.LabelResta.Size = New System.Drawing.Size(51, 17)
        Me.LabelResta.TabIndex = 7
        Me.LabelResta.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(501, 527)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 29)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "8% Del Restado"
        '
        'LabelPorCiento
        '
        Me.LabelPorCiento.AutoSize = true
        Me.LabelPorCiento.Location = New System.Drawing.Point(506, 568)
        Me.LabelPorCiento.Name = "LabelPorCiento"
        Me.LabelPorCiento.Size = New System.Drawing.Size(51, 17)
        Me.LabelPorCiento.TabIndex = 7
        Me.LabelPorCiento.Text = "Label6"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 608)
        Me.Controls.Add(Me.LabelPorCiento)
        Me.Controls.Add(Me.LabelResta)
        Me.Controls.Add(Me.LabelConvertir)
        Me.Controls.Add(Me.RadLabelSumaPositivos)
        Me.Controls.Add(Me.RadLabelSumaNegativo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RadLabelPositivos)
        Me.Controls.Add(Me.RadLabelNegativos)
        Me.Controls.Add(Me.RadListViewPositivo)
        Me.Controls.Add(Me.RadListViewNegativos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Examen Final"
        CType(Me.RadButton1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadListViewNegativos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadListViewPositivo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabelNegativos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabelPositivos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabelSumaNegativo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadLabelSumaPositivos,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label1 As Label
    Friend WithEvents RadListViewNegativos As Telerik.WinControls.UI.RadListView
    Friend WithEvents Label2 As Label
    Friend WithEvents RadListViewPositivo As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadLabelNegativos As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabelPositivos As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents RadLabelSumaNegativo As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents RadLabelSumaPositivos As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelConvertir As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelResta As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelPorCiento As Label
End Class
