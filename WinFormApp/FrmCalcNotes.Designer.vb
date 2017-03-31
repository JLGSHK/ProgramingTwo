<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCalcNotes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CalcNotesRadButton = New Telerik.WinControls.UI.RadButton()
        Me.RadRadioButtonSwitch = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButtonSimpleIf = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadRadioButtonNested = New Telerik.WinControls.UI.RadRadioButton()
        Me.DisplayErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadSpinEditor2 = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadSpinEditor3 = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadSpinEditor4 = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadSpinEditor5 = New Telerik.WinControls.UI.RadSpinEditor()
        CType(Me.CalcNotesRadButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButtonSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButtonSimpleIf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRadioButtonNested, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RadSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSpinEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSpinEditor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSpinEditor4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSpinEditor5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(551, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calcular Promedio"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Calificación #1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Calificación #2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Calificación #3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Calificación #4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Calificación #5"
        '
        'CalcNotesRadButton
        '
        Me.CalcNotesRadButton.Location = New System.Drawing.Point(398, 202)
        Me.CalcNotesRadButton.Name = "CalcNotesRadButton"
        Me.CalcNotesRadButton.Size = New System.Drawing.Size(137, 77)
        Me.CalcNotesRadButton.TabIndex = 12
        Me.CalcNotesRadButton.Text = "Calcular"
        '
        'RadRadioButtonSwitch
        '
        Me.RadRadioButtonSwitch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RadRadioButtonSwitch.Location = New System.Drawing.Point(6, 27)
        Me.RadRadioButtonSwitch.Name = "RadRadioButtonSwitch"
        Me.RadRadioButtonSwitch.Size = New System.Drawing.Size(142, 22)
        Me.RadRadioButtonSwitch.TabIndex = 0
        Me.RadRadioButtonSwitch.Text = "Calcular con Switch"
        Me.RadRadioButtonSwitch.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'RadRadioButtonSimpleIf
        '
        Me.RadRadioButtonSimpleIf.Location = New System.Drawing.Point(6, 55)
        Me.RadRadioButtonSimpleIf.Name = "RadRadioButtonSimpleIf"
        Me.RadRadioButtonSimpleIf.Size = New System.Drawing.Size(156, 22)
        Me.RadRadioButtonSimpleIf.TabIndex = 1
        Me.RadRadioButtonSimpleIf.TabStop = False
        Me.RadRadioButtonSimpleIf.Text = "Calcular con If Simple"
        '
        'RadRadioButtonNested
        '
        Me.RadRadioButtonNested.Location = New System.Drawing.Point(6, 82)
        Me.RadRadioButtonNested.Name = "RadRadioButtonNested"
        Me.RadRadioButtonNested.Size = New System.Drawing.Size(172, 22)
        Me.RadRadioButtonNested.TabIndex = 2
        Me.RadRadioButtonNested.TabStop = False
        Me.RadRadioButtonNested.Text = "Calcular con If Anidados"
        '
        'DisplayErrorProvider
        '
        Me.DisplayErrorProvider.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadRadioButtonSwitch)
        Me.GroupBox1.Controls.Add(Me.RadRadioButtonNested)
        Me.GroupBox1.Controls.Add(Me.RadRadioButtonSimpleIf)
        Me.GroupBox1.Location = New System.Drawing.Point(333, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 127)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Metodo para Calcular"
        '
        'RadSpinEditor1
        '
        Me.RadSpinEditor1.Location = New System.Drawing.Point(203, 70)
        Me.RadSpinEditor1.Name = "RadSpinEditor1"
        Me.RadSpinEditor1.ShowUpDownButtons = False
        Me.RadSpinEditor1.Size = New System.Drawing.Size(93, 24)
        Me.RadSpinEditor1.TabIndex = 6
        Me.RadSpinEditor1.TabStop = False
        Me.RadSpinEditor1.ThemeName = "ControlDefault"
        '
        'RadSpinEditor2
        '
        Me.RadSpinEditor2.Location = New System.Drawing.Point(203, 112)
        Me.RadSpinEditor2.Name = "RadSpinEditor2"
        Me.RadSpinEditor2.ShowUpDownButtons = False
        Me.RadSpinEditor2.Size = New System.Drawing.Size(93, 24)
        Me.RadSpinEditor2.TabIndex = 7
        Me.RadSpinEditor2.TabStop = False
        Me.RadSpinEditor2.ThemeName = "ControlDefault"
        '
        'RadSpinEditor3
        '
        Me.RadSpinEditor3.Location = New System.Drawing.Point(203, 158)
        Me.RadSpinEditor3.Name = "RadSpinEditor3"
        Me.RadSpinEditor3.ShowUpDownButtons = False
        Me.RadSpinEditor3.Size = New System.Drawing.Size(93, 24)
        Me.RadSpinEditor3.TabIndex = 8
        Me.RadSpinEditor3.TabStop = False
        Me.RadSpinEditor3.ThemeName = "ControlDefault"
        '
        'RadSpinEditor4
        '
        Me.RadSpinEditor4.Location = New System.Drawing.Point(203, 202)
        Me.RadSpinEditor4.Name = "RadSpinEditor4"
        Me.RadSpinEditor4.ShowUpDownButtons = False
        Me.RadSpinEditor4.Size = New System.Drawing.Size(93, 24)
        Me.RadSpinEditor4.TabIndex = 9
        Me.RadSpinEditor4.TabStop = False
        Me.RadSpinEditor4.ThemeName = "ControlDefault"
        '
        'RadSpinEditor5
        '
        Me.RadSpinEditor5.Location = New System.Drawing.Point(203, 251)
        Me.RadSpinEditor5.Name = "RadSpinEditor5"
        Me.RadSpinEditor5.ShowUpDownButtons = False
        Me.RadSpinEditor5.Size = New System.Drawing.Size(93, 24)
        Me.RadSpinEditor5.TabIndex = 10
        Me.RadSpinEditor5.TabStop = False
        Me.RadSpinEditor5.ThemeName = "ControlDefault"
        '
        'FrmCalcNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 293)
        Me.Controls.Add(Me.RadSpinEditor5)
        Me.Controls.Add(Me.RadSpinEditor4)
        Me.Controls.Add(Me.RadSpinEditor3)
        Me.Controls.Add(Me.RadSpinEditor2)
        Me.Controls.Add(Me.RadSpinEditor1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CalcNotesRadButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCalcNotes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcular Promedio"
        CType(Me.CalcNotesRadButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButtonSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButtonSimpleIf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRadioButtonNested, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RadSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSpinEditor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSpinEditor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSpinEditor4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSpinEditor5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CalcNotesRadButton As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadRadioButtonSwitch As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButtonSimpleIf As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadRadioButtonNested As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents DisplayErrorProvider As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadSpinEditor2 As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadSpinEditor5 As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadSpinEditor4 As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadSpinEditor3 As Telerik.WinControls.UI.RadSpinEditor
End Class
