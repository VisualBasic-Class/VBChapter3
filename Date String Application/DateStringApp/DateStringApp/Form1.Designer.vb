<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDateString
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
        Me.txtboxDayOfWeek = New System.Windows.Forms.TextBox()
        Me.txtboxMonth = New System.Windows.Forms.TextBox()
        Me.txtboxDayOfMonth = New System.Windows.Forms.TextBox()
        Me.txtboxYear = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDateString = New System.Windows.Forms.Label()
        Me.btnShowDate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExitApp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtboxDayOfWeek
        '
        Me.txtboxDayOfWeek.Location = New System.Drawing.Point(207, 39)
        Me.txtboxDayOfWeek.Name = "txtboxDayOfWeek"
        Me.txtboxDayOfWeek.Size = New System.Drawing.Size(100, 20)
        Me.txtboxDayOfWeek.TabIndex = 0
        '
        'txtboxMonth
        '
        Me.txtboxMonth.Location = New System.Drawing.Point(207, 79)
        Me.txtboxMonth.Name = "txtboxMonth"
        Me.txtboxMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtboxMonth.TabIndex = 1
        '
        'txtboxDayOfMonth
        '
        Me.txtboxDayOfMonth.Location = New System.Drawing.Point(207, 113)
        Me.txtboxDayOfMonth.Name = "txtboxDayOfMonth"
        Me.txtboxDayOfMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtboxDayOfMonth.TabIndex = 2
        '
        'txtboxYear
        '
        Me.txtboxYear.Location = New System.Drawing.Point(207, 151)
        Me.txtboxYear.Name = "txtboxYear"
        Me.txtboxYear.Size = New System.Drawing.Size(100, 20)
        Me.txtboxYear.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter the day of the week:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter the month:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Enter the day of the month:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(98, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Enter the year:"
        '
        'lblDateString
        '
        Me.lblDateString.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateString.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateString.Location = New System.Drawing.Point(50, 198)
        Me.lblDateString.Name = "lblDateString"
        Me.lblDateString.Size = New System.Drawing.Size(241, 36)
        Me.lblDateString.TabIndex = 8
        Me.lblDateString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnShowDate
        '
        Me.btnShowDate.Location = New System.Drawing.Point(15, 258)
        Me.btnShowDate.Name = "btnShowDate"
        Me.btnShowDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnShowDate.Size = New System.Drawing.Size(75, 23)
        Me.btnShowDate.TabIndex = 9
        Me.btnShowDate.Text = "Show Date"
        Me.btnShowDate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(130, 258)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExitApp
        '
        Me.btnExitApp.Location = New System.Drawing.Point(246, 258)
        Me.btnExitApp.Name = "btnExitApp"
        Me.btnExitApp.Size = New System.Drawing.Size(75, 23)
        Me.btnExitApp.TabIndex = 11
        Me.btnExitApp.Text = "Exit"
        Me.btnExitApp.UseVisualStyleBackColor = True
        '
        'formDateString
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 308)
        Me.Controls.Add(Me.btnExitApp)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowDate)
        Me.Controls.Add(Me.lblDateString)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtboxYear)
        Me.Controls.Add(Me.txtboxDayOfMonth)
        Me.Controls.Add(Me.txtboxMonth)
        Me.Controls.Add(Me.txtboxDayOfWeek)
        Me.Name = "formDateString"
        Me.Text = "Date String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtboxDayOfWeek As System.Windows.Forms.TextBox
    Friend WithEvents txtboxMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtboxDayOfMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtboxYear As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDateString As System.Windows.Forms.Label
    Friend WithEvents btnShowDate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExitApp As System.Windows.Forms.Button

End Class
