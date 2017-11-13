<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomChargeCalc
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
        Me.lblHotelName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDateToday = New System.Windows.Forms.Label()
        Me.lblTimeToday = New System.Windows.Forms.Label()
        Me.boxRoomInfo = New System.Windows.Forms.GroupBox()
        Me.txtNightlyCharge = New System.Windows.Forms.TextBox()
        Me.lblNightlyCharge = New System.Windows.Forms.Label()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.lblNights = New System.Windows.Forms.Label()
        Me.boxAddCharges = New System.Windows.Forms.GroupBox()
        Me.txtMisc = New System.Windows.Forms.TextBox()
        Me.lblMisc = New System.Windows.Forms.Label()
        Me.txtRoomService = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.lblRoomService = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRoomCharges = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.boxTotalCharges = New System.Windows.Forms.GroupBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblAddCharges = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.boxRoomInfo.SuspendLayout()
        Me.boxAddCharges.SuspendLayout()
        Me.boxTotalCharges.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHotelName
        '
        Me.lblHotelName.AutoSize = True
        Me.lblHotelName.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHotelName.Location = New System.Drawing.Point(149, 9)
        Me.lblHotelName.Name = "lblHotelName"
        Me.lblHotelName.Size = New System.Drawing.Size(187, 24)
        Me.lblHotelName.TabIndex = 0
        Me.lblHotelName.Text = "Highlander Hotel"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(110, 71)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(73, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Today's Date:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(150, 111)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(33, 13)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Time:"
        '
        'lblDateToday
        '
        Me.lblDateToday.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDateToday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateToday.Location = New System.Drawing.Point(189, 65)
        Me.lblDateToday.Name = "lblDateToday"
        Me.lblDateToday.Size = New System.Drawing.Size(198, 25)
        Me.lblDateToday.TabIndex = 3
        Me.lblDateToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeToday
        '
        Me.lblTimeToday.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTimeToday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTimeToday.Location = New System.Drawing.Point(189, 105)
        Me.lblTimeToday.Name = "lblTimeToday"
        Me.lblTimeToday.Size = New System.Drawing.Size(198, 25)
        Me.lblTimeToday.TabIndex = 4
        Me.lblTimeToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'boxRoomInfo
        '
        Me.boxRoomInfo.Controls.Add(Me.txtNightlyCharge)
        Me.boxRoomInfo.Controls.Add(Me.lblNightlyCharge)
        Me.boxRoomInfo.Controls.Add(Me.txtNights)
        Me.boxRoomInfo.Controls.Add(Me.lblNights)
        Me.boxRoomInfo.Location = New System.Drawing.Point(12, 158)
        Me.boxRoomInfo.Name = "boxRoomInfo"
        Me.boxRoomInfo.Size = New System.Drawing.Size(218, 115)
        Me.boxRoomInfo.TabIndex = 5
        Me.boxRoomInfo.TabStop = False
        Me.boxRoomInfo.Text = "Room Information"
        '
        'txtNightlyCharge
        '
        Me.txtNightlyCharge.Location = New System.Drawing.Point(101, 71)
        Me.txtNightlyCharge.Name = "txtNightlyCharge"
        Me.txtNightlyCharge.Size = New System.Drawing.Size(73, 20)
        Me.txtNightlyCharge.TabIndex = 10
        '
        'lblNightlyCharge
        '
        Me.lblNightlyCharge.AutoSize = True
        Me.lblNightlyCharge.Location = New System.Drawing.Point(16, 74)
        Me.lblNightlyCharge.Name = "lblNightlyCharge"
        Me.lblNightlyCharge.Size = New System.Drawing.Size(79, 13)
        Me.lblNightlyCharge.TabIndex = 10
        Me.lblNightlyCharge.Text = "Nightly Charge:"
        '
        'txtNights
        '
        Me.txtNights.Location = New System.Drawing.Point(101, 37)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(73, 20)
        Me.txtNights.TabIndex = 9
        '
        'lblNights
        '
        Me.lblNights.AutoSize = True
        Me.lblNights.Location = New System.Drawing.Point(55, 40)
        Me.lblNights.Name = "lblNights"
        Me.lblNights.Size = New System.Drawing.Size(40, 13)
        Me.lblNights.TabIndex = 11
        Me.lblNights.Text = "Nights:"
        '
        'boxAddCharges
        '
        Me.boxAddCharges.Controls.Add(Me.txtMisc)
        Me.boxAddCharges.Controls.Add(Me.lblMisc)
        Me.boxAddCharges.Controls.Add(Me.txtRoomService)
        Me.boxAddCharges.Controls.Add(Me.lblTelephone)
        Me.boxAddCharges.Controls.Add(Me.txtTelephone)
        Me.boxAddCharges.Controls.Add(Me.lblRoomService)
        Me.boxAddCharges.Location = New System.Drawing.Point(248, 158)
        Me.boxAddCharges.Name = "boxAddCharges"
        Me.boxAddCharges.Size = New System.Drawing.Size(218, 115)
        Me.boxAddCharges.TabIndex = 6
        Me.boxAddCharges.TabStop = False
        Me.boxAddCharges.Text = "Additional Charges"
        '
        'txtMisc
        '
        Me.txtMisc.Location = New System.Drawing.Point(98, 80)
        Me.txtMisc.Name = "txtMisc"
        Me.txtMisc.Size = New System.Drawing.Size(87, 20)
        Me.txtMisc.TabIndex = 11
        '
        'lblMisc
        '
        Me.lblMisc.AutoSize = True
        Me.lblMisc.Location = New System.Drawing.Point(57, 86)
        Me.lblMisc.Name = "lblMisc"
        Me.lblMisc.Size = New System.Drawing.Size(35, 13)
        Me.lblMisc.TabIndex = 7
        Me.lblMisc.Text = "Misc.:"
        '
        'txtRoomService
        '
        Me.txtRoomService.Location = New System.Drawing.Point(98, 28)
        Me.txtRoomService.Name = "txtRoomService"
        Me.txtRoomService.Size = New System.Drawing.Size(87, 20)
        Me.txtRoomService.TabIndex = 8
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(31, 57)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(61, 13)
        Me.lblTelephone.TabIndex = 8
        Me.lblTelephone.Text = "Telephone:"
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(98, 54)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(87, 20)
        Me.txtTelephone.TabIndex = 7
        '
        'lblRoomService
        '
        Me.lblRoomService.AutoSize = True
        Me.lblRoomService.Location = New System.Drawing.Point(15, 31)
        Me.lblRoomService.Name = "lblRoomService"
        Me.lblRoomService.Size = New System.Drawing.Size(77, 13)
        Me.lblRoomService.TabIndex = 9
        Me.lblRoomService.Text = "Room Service:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Additional Charges:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tax:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Subtotal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Room Charges:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(66, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Total Charges:"
        '
        'lblRoomCharges
        '
        Me.lblRoomCharges.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblRoomCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomCharges.Location = New System.Drawing.Point(160, 16)
        Me.lblRoomCharges.Name = "lblRoomCharges"
        Me.lblRoomCharges.Size = New System.Drawing.Size(127, 23)
        Me.lblRoomCharges.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(161, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 19
        '
        'boxTotalCharges
        '
        Me.boxTotalCharges.Controls.Add(Me.lblTax)
        Me.boxTotalCharges.Controls.Add(Me.Label6)
        Me.boxTotalCharges.Controls.Add(Me.lblAddCharges)
        Me.boxTotalCharges.Controls.Add(Me.Label8)
        Me.boxTotalCharges.Controls.Add(Me.Label4)
        Me.boxTotalCharges.Controls.Add(Me.Label3)
        Me.boxTotalCharges.Controls.Add(Me.Label5)
        Me.boxTotalCharges.Controls.Add(Me.lblSubtotal)
        Me.boxTotalCharges.Controls.Add(Me.lblTotal)
        Me.boxTotalCharges.Controls.Add(Me.lblRoomCharges)
        Me.boxTotalCharges.Controls.Add(Me.Label2)
        Me.boxTotalCharges.Location = New System.Drawing.Point(88, 287)
        Me.boxTotalCharges.Name = "boxTotalCharges"
        Me.boxTotalCharges.Size = New System.Drawing.Size(330, 190)
        Me.boxTotalCharges.TabIndex = 7
        Me.boxTotalCharges.TabStop = False
        Me.boxTotalCharges.Text = "Total Charges"
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(160, 120)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(127, 23)
        Me.lblTax.TabIndex = 23
        '
        'lblAddCharges
        '
        Me.lblAddCharges.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAddCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddCharges.Location = New System.Drawing.Point(160, 51)
        Me.lblAddCharges.Name = "lblAddCharges"
        Me.lblAddCharges.Size = New System.Drawing.Size(127, 23)
        Me.lblAddCharges.TabIndex = 20
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(160, 87)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(127, 23)
        Me.lblSubtotal.TabIndex = 22
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(160, 153)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(127, 23)
        Me.lblTotal.TabIndex = 21
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(88, 520)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(112, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate Charges"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(219, 520)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(321, 520)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStatus.Location = New System.Drawing.Point(12, 555)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(454, 23)
        Me.lblStatus.TabIndex = 11
        '
        'RoomChargeCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(478, 587)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.boxTotalCharges)
        Me.Controls.Add(Me.boxAddCharges)
        Me.Controls.Add(Me.boxRoomInfo)
        Me.Controls.Add(Me.lblTimeToday)
        Me.Controls.Add(Me.lblDateToday)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblHotelName)
        Me.Name = "RoomChargeCalc"
        Me.Text = "Room Charge Calculator"
        Me.boxRoomInfo.ResumeLayout(False)
        Me.boxRoomInfo.PerformLayout()
        Me.boxAddCharges.ResumeLayout(False)
        Me.boxAddCharges.PerformLayout()
        Me.boxTotalCharges.ResumeLayout(False)
        Me.boxTotalCharges.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHotelName As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDateToday As System.Windows.Forms.Label
    Friend WithEvents lblTimeToday As System.Windows.Forms.Label
    Friend WithEvents boxRoomInfo As System.Windows.Forms.GroupBox
    Friend WithEvents boxAddCharges As System.Windows.Forms.GroupBox
    Friend WithEvents txtNightlyCharge As System.Windows.Forms.TextBox
    Friend WithEvents lblNightlyCharge As System.Windows.Forms.Label
    Friend WithEvents txtNights As System.Windows.Forms.TextBox
    Friend WithEvents lblNights As System.Windows.Forms.Label
    Friend WithEvents txtMisc As System.Windows.Forms.TextBox
    Friend WithEvents lblMisc As System.Windows.Forms.Label
    Friend WithEvents txtRoomService As System.Windows.Forms.TextBox
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents lblRoomService As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblRoomCharges As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents boxTotalCharges As System.Windows.Forms.GroupBox
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblAddCharges As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label

End Class
