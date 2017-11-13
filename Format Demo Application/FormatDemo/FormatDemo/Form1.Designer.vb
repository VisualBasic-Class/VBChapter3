<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormatDemo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLongTime = New System.Windows.Forms.Button()
        Me.btnShortTime = New System.Windows.Forms.Button()
        Me.btnLongDate = New System.Windows.Forms.Button()
        Me.btnShortDate = New System.Windows.Forms.Button()
        Me.btnFullDateTime = New System.Windows.Forms.Button()
        Me.btnPercent = New System.Windows.Forms.Button()
        Me.btnCurrency = New System.Windows.Forms.Button()
        Me.btnExponent = New System.Windows.Forms.Button()
        Me.btnFixedPoint = New System.Windows.Forms.Button()
        Me.btnNumberFormat = New System.Windows.Forms.Button()
        Me.lblFormatted = New System.Windows.Forms.Label()
        Me.lblNumberOrDate = New System.Windows.Forms.Label()
        Me.txtUserEntry = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLongTime)
        Me.GroupBox1.Controls.Add(Me.btnShortTime)
        Me.GroupBox1.Controls.Add(Me.btnLongDate)
        Me.GroupBox1.Controls.Add(Me.btnShortDate)
        Me.GroupBox1.Controls.Add(Me.btnFullDateTime)
        Me.GroupBox1.Controls.Add(Me.btnPercent)
        Me.GroupBox1.Controls.Add(Me.btnCurrency)
        Me.GroupBox1.Controls.Add(Me.btnExponent)
        Me.GroupBox1.Controls.Add(Me.btnFixedPoint)
        Me.GroupBox1.Controls.Add(Me.btnNumberFormat)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 213)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a format:"
        '
        'btnLongTime
        '
        Me.btnLongTime.Location = New System.Drawing.Point(256, 119)
        Me.btnLongTime.Name = "btnLongTime"
        Me.btnLongTime.Size = New System.Drawing.Size(132, 23)
        Me.btnLongTime.TabIndex = 13
        Me.btnLongTime.Text = "Long time (T)"
        Me.btnLongTime.UseVisualStyleBackColor = True
        '
        'btnShortTime
        '
        Me.btnShortTime.Location = New System.Drawing.Point(256, 90)
        Me.btnShortTime.Name = "btnShortTime"
        Me.btnShortTime.Size = New System.Drawing.Size(132, 23)
        Me.btnShortTime.TabIndex = 12
        Me.btnShortTime.Text = "Short time (t)"
        Me.btnShortTime.UseVisualStyleBackColor = True
        '
        'btnLongDate
        '
        Me.btnLongDate.Location = New System.Drawing.Point(256, 61)
        Me.btnLongDate.Name = "btnLongDate"
        Me.btnLongDate.Size = New System.Drawing.Size(132, 23)
        Me.btnLongDate.TabIndex = 11
        Me.btnLongDate.Text = "Long date (D)"
        Me.btnLongDate.UseVisualStyleBackColor = True
        '
        'btnShortDate
        '
        Me.btnShortDate.Location = New System.Drawing.Point(256, 32)
        Me.btnShortDate.Name = "btnShortDate"
        Me.btnShortDate.Size = New System.Drawing.Size(132, 23)
        Me.btnShortDate.TabIndex = 10
        Me.btnShortDate.Text = "Short date (d)"
        Me.btnShortDate.UseVisualStyleBackColor = True
        '
        'btnFullDateTime
        '
        Me.btnFullDateTime.Location = New System.Drawing.Point(256, 148)
        Me.btnFullDateTime.Name = "btnFullDateTime"
        Me.btnFullDateTime.Size = New System.Drawing.Size(132, 23)
        Me.btnFullDateTime.TabIndex = 9
        Me.btnFullDateTime.Text = "Full date/time (F)"
        Me.btnFullDateTime.UseVisualStyleBackColor = True
        '
        'btnPercent
        '
        Me.btnPercent.Location = New System.Drawing.Point(57, 148)
        Me.btnPercent.Name = "btnPercent"
        Me.btnPercent.Size = New System.Drawing.Size(132, 23)
        Me.btnPercent.TabIndex = 4
        Me.btnPercent.Text = "Percent format (p)"
        Me.btnPercent.UseVisualStyleBackColor = True
        '
        'btnCurrency
        '
        Me.btnCurrency.Location = New System.Drawing.Point(57, 119)
        Me.btnCurrency.Name = "btnCurrency"
        Me.btnCurrency.Size = New System.Drawing.Size(132, 23)
        Me.btnCurrency.TabIndex = 3
        Me.btnCurrency.Text = "Currency format (c)"
        Me.btnCurrency.UseVisualStyleBackColor = True
        '
        'btnExponent
        '
        Me.btnExponent.Location = New System.Drawing.Point(57, 90)
        Me.btnExponent.Name = "btnExponent"
        Me.btnExponent.Size = New System.Drawing.Size(132, 23)
        Me.btnExponent.TabIndex = 2
        Me.btnExponent.Text = "Exponential format (e)"
        Me.btnExponent.UseVisualStyleBackColor = True
        '
        'btnFixedPoint
        '
        Me.btnFixedPoint.Location = New System.Drawing.Point(57, 61)
        Me.btnFixedPoint.Name = "btnFixedPoint"
        Me.btnFixedPoint.Size = New System.Drawing.Size(132, 23)
        Me.btnFixedPoint.TabIndex = 1
        Me.btnFixedPoint.Text = "Fixed-Point format (f)"
        Me.btnFixedPoint.UseVisualStyleBackColor = True
        '
        'btnNumberFormat
        '
        Me.btnNumberFormat.Location = New System.Drawing.Point(57, 32)
        Me.btnNumberFormat.Name = "btnNumberFormat"
        Me.btnNumberFormat.Size = New System.Drawing.Size(132, 23)
        Me.btnNumberFormat.TabIndex = 0
        Me.btnNumberFormat.Text = "Number format (n)"
        Me.btnNumberFormat.UseVisualStyleBackColor = True
        '
        'lblFormatted
        '
        Me.lblFormatted.AutoSize = True
        Me.lblFormatted.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormatted.Location = New System.Drawing.Point(87, 108)
        Me.lblFormatted.Name = "lblFormatted"
        Me.lblFormatted.Size = New System.Drawing.Size(78, 16)
        Me.lblFormatted.TabIndex = 1
        Me.lblFormatted.Text = "Formatted:"
        '
        'lblNumberOrDate
        '
        Me.lblNumberOrDate.AutoSize = True
        Me.lblNumberOrDate.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOrDate.Location = New System.Drawing.Point(4, 27)
        Me.lblNumberOrDate.Name = "lblNumberOrDate"
        Me.lblNumberOrDate.Size = New System.Drawing.Size(161, 16)
        Me.lblNumberOrDate.TabIndex = 2
        Me.lblNumberOrDate.Text = "Enter a number or date:"
        '
        'txtUserEntry
        '
        Me.txtUserEntry.Location = New System.Drawing.Point(171, 27)
        Me.txtUserEntry.Name = "txtUserEntry"
        Me.txtUserEntry.Size = New System.Drawing.Size(264, 20)
        Me.txtUserEntry.TabIndex = 3
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.Control
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(172, 101)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(263, 30)
        Me.lblResult.TabIndex = 4
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormatDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(463, 448)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtUserEntry)
        Me.Controls.Add(Me.lblNumberOrDate)
        Me.Controls.Add(Me.lblFormatted)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormatDemo"
        Me.Text = "Format Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFormatted As System.Windows.Forms.Label
    Friend WithEvents lblNumberOrDate As System.Windows.Forms.Label
    Friend WithEvents txtUserEntry As System.Windows.Forms.TextBox
    Friend WithEvents btnLongTime As System.Windows.Forms.Button
    Friend WithEvents btnShortTime As System.Windows.Forms.Button
    Friend WithEvents btnLongDate As System.Windows.Forms.Button
    Friend WithEvents btnShortDate As System.Windows.Forms.Button
    Friend WithEvents btnFullDateTime As System.Windows.Forms.Button
    Friend WithEvents btnPercent As System.Windows.Forms.Button
    Friend WithEvents btnCurrency As System.Windows.Forms.Button
    Friend WithEvents btnExponent As System.Windows.Forms.Button
    Friend WithEvents btnFixedPoint As System.Windows.Forms.Button
    Friend WithEvents btnNumberFormat As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
