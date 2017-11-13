<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleCalc
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
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.lblNumberOne = New System.Windows.Forms.Label()
        Me.lblOperation = New System.Windows.Forms.Label()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnExponentiate = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnModulous = New System.Windows.Forms.Button()
        Me.lblNumber2 = New System.Windows.Forms.Label()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.lblResultText = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExitApp = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblGreyLine = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNumber1
        '
        Me.txtNumber1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumber1.Location = New System.Drawing.Point(134, 35)
        Me.txtNumber1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(255, 26)
        Me.txtNumber1.TabIndex = 0
        '
        'lblNumberOne
        '
        Me.lblNumberOne.AutoSize = True
        Me.lblNumberOne.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOne.Location = New System.Drawing.Point(35, 35)
        Me.lblNumberOne.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumberOne.Name = "lblNumberOne"
        Me.lblNumberOne.Size = New System.Drawing.Size(90, 19)
        Me.lblNumberOne.TabIndex = 1
        Me.lblNumberOne.Text = "Number 1:"
        '
        'lblOperation
        '
        Me.lblOperation.AutoSize = True
        Me.lblOperation.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperation.Location = New System.Drawing.Point(36, 99)
        Me.lblOperation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOperation.Name = "lblOperation"
        Me.lblOperation.Size = New System.Drawing.Size(89, 19)
        Me.lblOperation.TabIndex = 2
        Me.lblOperation.Text = "Operation:"
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(210, 99)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(48, 37)
        Me.btnSubtract.TabIndex = 4
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(286, 99)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(48, 37)
        Me.btnMultiply.TabIndex = 5
        Me.btnMultiply.Text = "x"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnExponentiate
        '
        Me.btnExponentiate.Location = New System.Drawing.Point(210, 161)
        Me.btnExponentiate.Name = "btnExponentiate"
        Me.btnExponentiate.Size = New System.Drawing.Size(48, 39)
        Me.btnExponentiate.TabIndex = 7
        Me.btnExponentiate.Text = "^"
        Me.btnExponentiate.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(134, 161)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(48, 39)
        Me.btnDivide.TabIndex = 8
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnModulous
        '
        Me.btnModulous.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModulous.Location = New System.Drawing.Point(286, 162)
        Me.btnModulous.Name = "btnModulous"
        Me.btnModulous.Size = New System.Drawing.Size(48, 39)
        Me.btnModulous.TabIndex = 9
        Me.btnModulous.Text = "MOD"
        Me.btnModulous.UseVisualStyleBackColor = True
        '
        'lblNumber2
        '
        Me.lblNumber2.AutoSize = True
        Me.lblNumber2.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber2.Location = New System.Drawing.Point(35, 229)
        Me.lblNumber2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumber2.Name = "lblNumber2"
        Me.lblNumber2.Size = New System.Drawing.Size(90, 19)
        Me.lblNumber2.TabIndex = 10
        Me.lblNumber2.Text = "Number 2:"
        '
        'txtNumber2
        '
        Me.txtNumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumber2.Location = New System.Drawing.Point(134, 229)
        Me.txtNumber2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(255, 26)
        Me.txtNumber2.TabIndex = 11
        '
        'lblResultText
        '
        Me.lblResultText.AutoSize = True
        Me.lblResultText.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultText.Location = New System.Drawing.Point(35, 320)
        Me.lblResultText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResultText.Name = "lblResultText"
        Me.lblResultText.Size = New System.Drawing.Size(74, 20)
        Me.lblResultText.TabIndex = 12
        Me.lblResultText.Text = "Result: "
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(134, 99)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(48, 37)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(43, 390)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 27)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExitApp
        '
        Me.btnExitApp.Location = New System.Drawing.Point(286, 390)
        Me.btnExitApp.Name = "btnExitApp"
        Me.btnExitApp.Size = New System.Drawing.Size(103, 27)
        Me.btnExitApp.TabIndex = 15
        Me.btnExitApp.Text = "Exit"
        Me.btnExitApp.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(134, 320)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(255, 25)
        Me.lblResult.TabIndex = 16
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGreyLine
        '
        Me.lblGreyLine.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblGreyLine.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblGreyLine.Location = New System.Drawing.Point(12, 288)
        Me.lblGreyLine.Name = "lblGreyLine"
        Me.lblGreyLine.Size = New System.Drawing.Size(402, 10)
        Me.lblGreyLine.TabIndex = 17
        Me.lblGreyLine.UseMnemonic = False
        '
        'SimpleCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(426, 443)
        Me.Controls.Add(Me.lblGreyLine)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExitApp)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblResultText)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.lblNumber2)
        Me.Controls.Add(Me.btnModulous)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnExponentiate)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblOperation)
        Me.Controls.Add(Me.lblNumberOne)
        Me.Controls.Add(Me.txtNumber1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SimpleCalc"
        Me.Text = "Simple Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumber1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNumberOne As System.Windows.Forms.Label
    Friend WithEvents lblOperation As System.Windows.Forms.Label
    Friend WithEvents btnSubtract As System.Windows.Forms.Button
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents btnExponentiate As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnModulous As System.Windows.Forms.Button
    Friend WithEvents lblNumber2 As System.Windows.Forms.Label
    Friend WithEvents txtNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents lblResultText As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExitApp As System.Windows.Forms.Button

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This button will clear each of the text boxes.
        txtNumber1.Clear()

        txtNumber2.Clear()

        lblResult.Text = ""
    End Sub
    Private Sub btnExitApp_Click(sender As Object, e As EventArgs) Handles btnExitApp.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' This event handler performs addition.
        Dim dblResult As Double

        lblOperation.Text = " + "

        dblResult = CDbl(txtNumber1.Text) + CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        ' This event handler performs subtraction.
        Dim dblResult As Double

        lblOperation.Text = " - "

        dblResult = CDbl(txtNumber1.Text) - CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        ' This event handler performs multiplication.
        Dim dblResult As Double

        lblOperation.Text = " * "

        dblResult = CDbl(txtNumber1.Text) * CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        ' This event handler performs division.
        Dim dblResult As Double

        lblOperation.Text = " / "

        dblResult = CDbl(txtNumber1.Text) / CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnExponentiate_Click(sender As Object, e As EventArgs) Handles btnExponentiate.Click
        ' This event handler will exponentiate Number1 by Number2.
        Dim dblResult As Double

        lblOperation.Text = " ^ "

        dblResult = CDbl(txtNumber1.Text) ^ CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnModulous_Click(sender As Object, e As EventArgs) Handles btnModulous.Click
        ' This event handler does the modulous math function.
        Dim dblResult As Double

        lblOperation.Text = " Mod "

        dblResult = CDbl(txtNumber1.Text) Mod CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)
    End Sub
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblGreyLine As System.Windows.Forms.Label

    Private Sub SimpleCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
