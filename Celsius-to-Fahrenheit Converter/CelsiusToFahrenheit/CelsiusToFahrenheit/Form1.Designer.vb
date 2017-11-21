<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CelsiusToFahrenheit
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
        Me.lblCelsius = New System.Windows.Forms.Label()
        Me.txtCelsius = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCToF = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.StatusStrip()
        Me.SuspendLayout()
        '
        'lblCelsius
        '
        Me.lblCelsius.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelsius.Location = New System.Drawing.Point(59, 59)
        Me.lblCelsius.Name = "lblCelsius"
        Me.lblCelsius.Size = New System.Drawing.Size(162, 23)
        Me.lblCelsius.TabIndex = 0
        Me.lblCelsius.Text = "Enter Temperature (C°):"
        '
        'txtCelsius
        '
        Me.txtCelsius.Location = New System.Drawing.Point(222, 58)
        Me.txtCelsius.Name = "txtCelsius"
        Me.txtCelsius.Size = New System.Drawing.Size(196, 20)
        Me.txtCelsius.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Temperature in Fahrenheit (F°):"
        '
        'lblCToF
        '
        Me.lblCToF.BackColor = System.Drawing.SystemColors.Control
        Me.lblCToF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCToF.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCToF.Location = New System.Drawing.Point(222, 137)
        Me.lblCToF.Name = "lblCToF"
        Me.lblCToF.Size = New System.Drawing.Size(196, 23)
        Me.lblCToF.TabIndex = 3
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(45, 243)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(90, 35)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Begin Conversion"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(176, 243)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 35)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(306, 243)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 35)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblStatus.Location = New System.Drawing.Point(0, 301)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(443, 22)
        Me.lblStatus.TabIndex = 7
        '
        'CelsiusToFahrenheit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(443, 323)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblCToF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCelsius)
        Me.Controls.Add(Me.lblCelsius)
        Me.Name = "CelsiusToFahrenheit"
        Me.Text = "Celsius to Fahrenheit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCelsius As System.Windows.Forms.Label
    Friend WithEvents txtCelsius As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCToF As System.Windows.Forms.Label
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.StatusStrip

End Class
