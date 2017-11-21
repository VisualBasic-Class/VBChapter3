<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_StadiumSeating
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
        Me.txtClassC = New System.Windows.Forms.TextBox()
        Me.txtClassB = New System.Windows.Forms.TextBox()
        Me.txtClassA = New System.Windows.Forms.TextBox()
        Me.lblClassC = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumberSeats = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblCRevenue = New System.Windows.Forms.Label()
        Me.lblBRevenue = New System.Windows.Forms.Label()
        Me.lblARevenue = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblClassCRev = New System.Windows.Forms.Label()
        Me.lblClassBRev = New System.Windows.Forms.Label()
        Me.lblClassARev = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.StatusStrip()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtClassC)
        Me.GroupBox1.Controls.Add(Me.txtClassB)
        Me.GroupBox1.Controls.Add(Me.txtClassA)
        Me.GroupBox1.Controls.Add(Me.lblClassC)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblNumberSeats)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets Sold"
        '
        'txtClassC
        '
        Me.txtClassC.Location = New System.Drawing.Point(79, 136)
        Me.txtClassC.Name = "txtClassC"
        Me.txtClassC.Size = New System.Drawing.Size(100, 20)
        Me.txtClassC.TabIndex = 6
        '
        'txtClassB
        '
        Me.txtClassB.Location = New System.Drawing.Point(79, 100)
        Me.txtClassB.Name = "txtClassB"
        Me.txtClassB.Size = New System.Drawing.Size(100, 20)
        Me.txtClassB.TabIndex = 5
        '
        'txtClassA
        '
        Me.txtClassA.Location = New System.Drawing.Point(79, 67)
        Me.txtClassA.Name = "txtClassA"
        Me.txtClassA.Size = New System.Drawing.Size(100, 20)
        Me.txtClassA.TabIndex = 4
        '
        'lblClassC
        '
        Me.lblClassC.AutoSize = True
        Me.lblClassC.Location = New System.Drawing.Point(27, 139)
        Me.lblClassC.Name = "lblClassC"
        Me.lblClassC.Size = New System.Drawing.Size(45, 13)
        Me.lblClassC.TabIndex = 3
        Me.lblClassC.Text = "Class C:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Class B:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Class A:"
        '
        'lblNumberSeats
        '
        Me.lblNumberSeats.Location = New System.Drawing.Point(18, 28)
        Me.lblNumberSeats.Name = "lblNumberSeats"
        Me.lblNumberSeats.Size = New System.Drawing.Size(175, 35)
        Me.lblNumberSeats.TabIndex = 0
        Me.lblNumberSeats.Text = "Enter the number of tickets sold for each class of seats:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalRevenue)
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.lblCRevenue)
        Me.GroupBox2.Controls.Add(Me.lblBRevenue)
        Me.GroupBox2.Controls.Add(Me.lblARevenue)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblClassCRev)
        Me.GroupBox2.Controls.Add(Me.lblClassBRev)
        Me.GroupBox2.Controls.Add(Me.lblClassARev)
        Me.GroupBox2.Location = New System.Drawing.Point(259, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(243, 175)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Revenue Generated"
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalRevenue.Location = New System.Drawing.Point(93, 142)
        Me.lblTotalRevenue.Name = "lblTotalRevenue"
        Me.lblTotalRevenue.Size = New System.Drawing.Size(133, 18)
        Me.lblTotalRevenue.TabIndex = 8
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(6, 143)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(81, 13)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total Revenue:"
        '
        'lblCRevenue
        '
        Me.lblCRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCRevenue.Location = New System.Drawing.Point(103, 92)
        Me.lblCRevenue.Name = "lblCRevenue"
        Me.lblCRevenue.Size = New System.Drawing.Size(113, 18)
        Me.lblCRevenue.TabIndex = 6
        '
        'lblBRevenue
        '
        Me.lblBRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBRevenue.Location = New System.Drawing.Point(103, 58)
        Me.lblBRevenue.Name = "lblBRevenue"
        Me.lblBRevenue.Size = New System.Drawing.Size(113, 18)
        Me.lblBRevenue.TabIndex = 5
        '
        'lblARevenue
        '
        Me.lblARevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblARevenue.Location = New System.Drawing.Point(103, 27)
        Me.lblARevenue.Name = "lblARevenue"
        Me.lblARevenue.Size = New System.Drawing.Size(113, 18)
        Me.lblARevenue.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(100, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 3
        '
        'lblClassCRev
        '
        Me.lblClassCRev.AutoSize = True
        Me.lblClassCRev.Location = New System.Drawing.Point(42, 92)
        Me.lblClassCRev.Name = "lblClassCRev"
        Me.lblClassCRev.Size = New System.Drawing.Size(45, 13)
        Me.lblClassCRev.TabIndex = 2
        Me.lblClassCRev.Text = "Class C:"
        '
        'lblClassBRev
        '
        Me.lblClassBRev.AutoSize = True
        Me.lblClassBRev.Location = New System.Drawing.Point(42, 63)
        Me.lblClassBRev.Name = "lblClassBRev"
        Me.lblClassBRev.Size = New System.Drawing.Size(45, 13)
        Me.lblClassBRev.TabIndex = 1
        Me.lblClassBRev.Text = "Class B:"
        '
        'lblClassARev
        '
        Me.lblClassARev.AutoSize = True
        Me.lblClassARev.Location = New System.Drawing.Point(42, 33)
        Me.lblClassARev.Name = "lblClassARev"
        Me.lblClassARev.Size = New System.Drawing.Size(45, 13)
        Me.lblClassARev.TabIndex = 0
        Me.lblClassARev.Text = "Class A:"
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(0, 301)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(514, 22)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "StatusStrip1"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(65, 246)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(118, 35)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate Revenue"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(212, 246)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 35)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(327, 246)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form_StadiumSeating
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 323)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_StadiumSeating"
        Me.Text = "Stadium Seating Revenue"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtClassC As System.Windows.Forms.TextBox
    Friend WithEvents txtClassB As System.Windows.Forms.TextBox
    Friend WithEvents txtClassA As System.Windows.Forms.TextBox
    Friend WithEvents lblClassC As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNumberSeats As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblClassCRev As System.Windows.Forms.Label
    Friend WithEvents lblClassBRev As System.Windows.Forms.Label
    Friend WithEvents lblClassARev As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblCRevenue As System.Windows.Forms.Label
    Friend WithEvents lblBRevenue As System.Windows.Forms.Label
    Friend WithEvents lblARevenue As System.Windows.Forms.Label
    Friend WithEvents lblTotalRevenue As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
