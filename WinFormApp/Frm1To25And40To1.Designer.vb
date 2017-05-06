<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm1To25And40To1
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
        Me.MostrarRadButton = New Telerik.WinControls.UI.RadButton()
        Me.ListarNumeroListBox = New System.Windows.Forms.ListBox()
        Me.BorrarRadButton = New Telerik.WinControls.UI.RadButton()
        CType(Me.MostrarRadButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BorrarRadButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MostrarRadButton
        '
        Me.MostrarRadButton.Location = New System.Drawing.Point(13, 30)
        Me.MostrarRadButton.Name = "MostrarRadButton"
        Me.MostrarRadButton.Size = New System.Drawing.Size(348, 41)
        Me.MostrarRadButton.TabIndex = 0
        Me.MostrarRadButton.Text = "Mostrar Información"
        '
        'ListarNumeroListBox
        '
        Me.ListarNumeroListBox.FormattingEnabled = True
        Me.ListarNumeroListBox.ItemHeight = 16
        Me.ListarNumeroListBox.Location = New System.Drawing.Point(13, 135)
        Me.ListarNumeroListBox.Name = "ListarNumeroListBox"
        Me.ListarNumeroListBox.Size = New System.Drawing.Size(348, 308)
        Me.ListarNumeroListBox.TabIndex = 2
        '
        'BorrarRadButton
        '
        Me.BorrarRadButton.Location = New System.Drawing.Point(13, 77)
        Me.BorrarRadButton.Name = "BorrarRadButton"
        Me.BorrarRadButton.Size = New System.Drawing.Size(348, 41)
        Me.BorrarRadButton.TabIndex = 1
        Me.BorrarRadButton.Text = "Borrar Información"
        '
        'Frm1To25And40To1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 463)
        Me.Controls.Add(Me.ListarNumeroListBox)
        Me.Controls.Add(Me.BorrarRadButton)
        Me.Controls.Add(Me.MostrarRadButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm1To25And40To1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contar desde 1 al 25 y del 40 al 1"
        CType(Me.MostrarRadButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BorrarRadButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MostrarRadButton As Telerik.WinControls.UI.RadButton
    Friend WithEvents ListarNumeroListBox As ListBox
    Friend WithEvents BorrarRadButton As Telerik.WinControls.UI.RadButton
End Class
