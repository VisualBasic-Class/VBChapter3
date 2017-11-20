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
        Me.lblAnnualSalary = New System.Windows.Forms.Label()
        Me.lblPayPeriods = New System.Windows.Forms.Label()
        Me.lblSalaryText = New System.Windows.Forms.Label()
        Me.txtAnnualSalary = New System.Windows.Forms.TextBox()
        Me.txtPayPeriods = New System.Windows.Forms.TextBox()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.StatusStrip()
        Me.SuspendLayout()
        '
        'lblAnnualSalary
        '
        Me.lblAnnualSalary.AutoSize = True
        Me.lblAnnualSalary.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnualSalary.Location = New System.Drawing.Point(72, 52)
        Me.lblAnnualSalary.Name = "lblAnnualSalary"
        Me.lblAnnualSalary.Size = New System.Drawing.Size(114, 19)
        Me.lblAnnualSalary.TabIndex = 0
        Me.lblAnnualSalary.Text = "Annual salary:"
        '
        'lblPayPeriods
        '
        Me.lblPayPeriods.AutoSize = True
        Me.lblPayPeriods.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayPeriods.Location = New System.Drawing.Point(17, 103)
        Me.lblPayPeriods.Name = "lblPayPeriods"
        Me.lblPayPeriods.Size = New System.Drawing.Size(169, 19)
        Me.lblPayPeriods.TabIndex = 1
        Me.lblPayPeriods.Text = "Pay periods per year:"
        '
        'lblSalaryText
        '
        Me.lblSalaryText.AutoSize = True
        Me.lblSalaryText.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalaryText.Location = New System.Drawing.Point(12, 152)
        Me.lblSalaryText.Name = "lblSalaryText"
        Me.lblSalaryText.Size = New System.Drawing.Size(174, 19)
        Me.lblSalaryText.TabIndex = 2
        Me.lblSalaryText.Text = "Salary per pay period:"
        '
        'txtAnnualSalary
        '
        Me.txtAnnualSalary.Location = New System.Drawing.Point(193, 50)
        Me.txtAnnualSalary.Name = "txtAnnualSalary"
        Me.txtAnnualSalary.Size = New System.Drawing.Size(177, 20)
        Me.txtAnnualSalary.TabIndex = 3
        '
        'txtPayPeriods
        '
        Me.txtPayPeriods.Location = New System.Drawing.Point(192, 102)
        Me.txtPayPeriods.Name = "txtPayPeriods"
        Me.txtPayPeriods.Size = New System.Drawing.Size(177, 20)
        Me.txtPayPeriods.TabIndex = 4
        '
        'lblSalary
        '
        Me.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalary.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalary.Location = New System.Drawing.Point(192, 152)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(174, 19)
        Me.lblSalary.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(134, 223)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(111, 28)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(0, 268)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(382, 22)
        Me.lblStatus.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 290)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.txtPayPeriods)
        Me.Controls.Add(Me.txtAnnualSalary)
        Me.Controls.Add(Me.lblSalaryText)
        Me.Controls.Add(Me.lblPayPeriods)
        Me.Controls.Add(Me.lblAnnualSalary)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAnnualSalary As System.Windows.Forms.Label
    Friend WithEvents lblPayPeriods As System.Windows.Forms.Label
    Friend WithEvents lblSalaryText As System.Windows.Forms.Label
    Friend WithEvents txtAnnualSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtPayPeriods As System.Windows.Forms.TextBox
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.StatusStrip

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
