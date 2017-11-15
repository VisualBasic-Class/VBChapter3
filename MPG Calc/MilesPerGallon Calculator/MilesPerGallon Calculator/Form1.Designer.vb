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
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.lblMilesOnFull = New System.Windows.Forms.Label()
        Me.txtMilesOnFull = New System.Windows.Forms.TextBox()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.lblMPGDisplay = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGallons
        '
        Me.lblGallons.Location = New System.Drawing.Point(25, 44)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(126, 30)
        Me.lblGallons.TabIndex = 0
        Me.lblGallons.Text = "Gallons of gas your car can hold:"
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(157, 44)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(115, 20)
        Me.txtGallons.TabIndex = 1
        '
        'lblMilesOnFull
        '
        Me.lblMilesOnFull.Location = New System.Drawing.Point(25, 101)
        Me.lblMilesOnFull.Name = "lblMilesOnFull"
        Me.lblMilesOnFull.Size = New System.Drawing.Size(123, 31)
        Me.lblMilesOnFull.TabIndex = 2
        Me.lblMilesOnFull.Text = "Number of miles a full tank can be driven on:"
        '
        'txtMilesOnFull
        '
        Me.txtMilesOnFull.Location = New System.Drawing.Point(157, 101)
        Me.txtMilesOnFull.Name = "txtMilesOnFull"
        Me.txtMilesOnFull.Size = New System.Drawing.Size(115, 20)
        Me.txtMilesOnFull.TabIndex = 3
        '
        'lblMPG
        '
        Me.lblMPG.Location = New System.Drawing.Point(25, 163)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(123, 22)
        Me.lblMPG.TabIndex = 4
        Me.lblMPG.Text = "Miles per gallon (MPG):"
        '
        'lblMPGDisplay
        '
        Me.lblMPGDisplay.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblMPGDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMPGDisplay.Location = New System.Drawing.Point(157, 158)
        Me.lblMPGDisplay.Name = "lblMPGDisplay"
        Me.lblMPGDisplay.Size = New System.Drawing.Size(115, 23)
        Me.lblMPGDisplay.TabIndex = 5
        Me.lblMPGDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(15, 217)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 40)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate MPG"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(115, 217)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 40)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(216, 217)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 40)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(303, 293)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblMPGDisplay)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.txtMilesOnFull)
        Me.Controls.Add(Me.lblMilesOnFull)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.lblGallons)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGallons As System.Windows.Forms.Label
    Friend WithEvents txtGallons As System.Windows.Forms.TextBox
    Friend WithEvents lblMilesOnFull As System.Windows.Forms.Label
    Friend WithEvents txtMilesOnFull As System.Windows.Forms.TextBox
    Friend WithEvents lblMPG As System.Windows.Forms.Label
    Friend WithEvents lblMPGDisplay As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
