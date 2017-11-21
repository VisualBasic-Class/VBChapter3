<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvgScoreCalc
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
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.lblScore3 = New System.Windows.Forms.Label()
        Me.lblScore4 = New System.Windows.Forms.Label()
        Me.lblScore5 = New System.Windows.Forms.Label()
        Me.txtScore1 = New System.Windows.Forms.TextBox()
        Me.txtScore2 = New System.Windows.Forms.TextBox()
        Me.txtScore3 = New System.Windows.Forms.TextBox()
        Me.txtScore4 = New System.Windows.Forms.TextBox()
        Me.txtScore5 = New System.Windows.Forms.TextBox()
        Me.btnCalcAverage = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAverageScore = New System.Windows.Forms.Label()
        Me.lblAvgDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblScore1
        '
        Me.lblScore1.AutoSize = True
        Me.lblScore1.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore1.Location = New System.Drawing.Point(38, 21)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(111, 19)
        Me.lblScore1.TabIndex = 0
        Me.lblScore1.Text = "Test Score 1:"
        '
        'lblScore2
        '
        Me.lblScore2.AutoSize = True
        Me.lblScore2.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore2.Location = New System.Drawing.Point(38, 60)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(111, 19)
        Me.lblScore2.TabIndex = 1
        Me.lblScore2.Text = "Test Score 2:"
        '
        'lblScore3
        '
        Me.lblScore3.AutoSize = True
        Me.lblScore3.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore3.Location = New System.Drawing.Point(38, 98)
        Me.lblScore3.Name = "lblScore3"
        Me.lblScore3.Size = New System.Drawing.Size(111, 19)
        Me.lblScore3.TabIndex = 2
        Me.lblScore3.Text = "Test Score 3:"
        '
        'lblScore4
        '
        Me.lblScore4.AutoSize = True
        Me.lblScore4.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore4.Location = New System.Drawing.Point(38, 135)
        Me.lblScore4.Name = "lblScore4"
        Me.lblScore4.Size = New System.Drawing.Size(111, 19)
        Me.lblScore4.TabIndex = 3
        Me.lblScore4.Text = "Test Score 4:"
        '
        'lblScore5
        '
        Me.lblScore5.AutoSize = True
        Me.lblScore5.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore5.Location = New System.Drawing.Point(38, 177)
        Me.lblScore5.Name = "lblScore5"
        Me.lblScore5.Size = New System.Drawing.Size(111, 19)
        Me.lblScore5.TabIndex = 4
        Me.lblScore5.Text = "Test Score 5:"
        '
        'txtScore1
        '
        Me.txtScore1.Location = New System.Drawing.Point(174, 20)
        Me.txtScore1.Name = "txtScore1"
        Me.txtScore1.Size = New System.Drawing.Size(100, 20)
        Me.txtScore1.TabIndex = 5
        '
        'txtScore2
        '
        Me.txtScore2.Location = New System.Drawing.Point(174, 59)
        Me.txtScore2.Name = "txtScore2"
        Me.txtScore2.Size = New System.Drawing.Size(100, 20)
        Me.txtScore2.TabIndex = 6
        '
        'txtScore3
        '
        Me.txtScore3.Location = New System.Drawing.Point(174, 97)
        Me.txtScore3.Name = "txtScore3"
        Me.txtScore3.Size = New System.Drawing.Size(100, 20)
        Me.txtScore3.TabIndex = 7
        '
        'txtScore4
        '
        Me.txtScore4.Location = New System.Drawing.Point(174, 134)
        Me.txtScore4.Name = "txtScore4"
        Me.txtScore4.Size = New System.Drawing.Size(100, 20)
        Me.txtScore4.TabIndex = 8
        '
        'txtScore5
        '
        Me.txtScore5.Location = New System.Drawing.Point(174, 176)
        Me.txtScore5.Name = "txtScore5"
        Me.txtScore5.Size = New System.Drawing.Size(100, 20)
        Me.txtScore5.TabIndex = 9
        '
        'btnCalcAverage
        '
        Me.btnCalcAverage.Location = New System.Drawing.Point(12, 267)
        Me.btnCalcAverage.Name = "btnCalcAverage"
        Me.btnCalcAverage.Size = New System.Drawing.Size(75, 41)
        Me.btnCalcAverage.TabIndex = 10
        Me.btnCalcAverage.Text = "Calculate Average"
        Me.btnCalcAverage.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(117, 267)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 41)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(220, 267)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 41)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAverageScore
        '
        Me.lblAverageScore.AutoSize = True
        Me.lblAverageScore.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageScore.Location = New System.Drawing.Point(10, 228)
        Me.lblAverageScore.Name = "lblAverageScore"
        Me.lblAverageScore.Size = New System.Drawing.Size(111, 16)
        Me.lblAverageScore.TabIndex = 13
        Me.lblAverageScore.Text = "Average Score:"
        '
        'lblAvgDisplay
        '
        Me.lblAvgDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgDisplay.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgDisplay.Location = New System.Drawing.Point(125, 223)
        Me.lblAvgDisplay.Name = "lblAvgDisplay"
        Me.lblAvgDisplay.Size = New System.Drawing.Size(170, 26)
        Me.lblAvgDisplay.TabIndex = 14
        '
        'AvgScoreCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(307, 320)
        Me.Controls.Add(Me.lblAvgDisplay)
        Me.Controls.Add(Me.lblAverageScore)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcAverage)
        Me.Controls.Add(Me.txtScore5)
        Me.Controls.Add(Me.txtScore4)
        Me.Controls.Add(Me.txtScore3)
        Me.Controls.Add(Me.txtScore2)
        Me.Controls.Add(Me.txtScore1)
        Me.Controls.Add(Me.lblScore5)
        Me.Controls.Add(Me.lblScore4)
        Me.Controls.Add(Me.lblScore3)
        Me.Controls.Add(Me.lblScore2)
        Me.Controls.Add(Me.lblScore1)
        Me.Name = "AvgScoreCalc"
        Me.Text = "Average Score Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblScore1 As System.Windows.Forms.Label
    Friend WithEvents lblScore2 As System.Windows.Forms.Label
    Friend WithEvents lblScore3 As System.Windows.Forms.Label
    Friend WithEvents lblScore4 As System.Windows.Forms.Label
    Friend WithEvents lblScore5 As System.Windows.Forms.Label
    Friend WithEvents txtScore1 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore2 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore3 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore4 As System.Windows.Forms.TextBox
    Friend WithEvents txtScore5 As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcAverage As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblAverageScore As System.Windows.Forms.Label
    Friend WithEvents lblAvgDisplay As System.Windows.Forms.Label

End Class
