<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstimate
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
        Me.components = New System.ComponentModel.Container()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblCarSalePrice = New System.Windows.Forms.Label()
        Me.lblAccessoriesAndFinish = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblSalesTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTradeIn = New System.Windows.Forms.Label()
        Me.lblAmountDue = New System.Windows.Forms.Label()
        Me.grpAccessories = New System.Windows.Forms.GroupBox()
        Me.chkCompNav = New System.Windows.Forms.CheckBox()
        Me.chkLeather = New System.Windows.Forms.CheckBox()
        Me.chkStereo = New System.Windows.Forms.CheckBox()
        Me.grpCarExteriorFinish = New System.Windows.Forms.GroupBox()
        Me.radCustomDetail = New System.Windows.Forms.RadioButton()
        Me.radPearlized = New System.Windows.Forms.RadioButton()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtSalePrice = New System.Windows.Forms.TextBox()
        Me.txtTradeIn = New System.Windows.Forms.TextBox()
        Me.lblAccessoriesOutput = New System.Windows.Forms.Label()
        Me.lblSubtotalOutput = New System.Windows.Forms.Label()
        Me.lblSalesTaxOutput = New System.Windows.Forms.Label()
        Me.lblTotalOutput = New System.Windows.Forms.Label()
        Me.lblAmountDueOutput = New System.Windows.Forms.Label()
        Me.hsbInterestRate = New System.Windows.Forms.HScrollBar()
        Me.hsbYears = New System.Windows.Forms.HScrollBar()
        Me.grpFinance = New System.Windows.Forms.GroupBox()
        Me.lblNoOfYearsOutput = New System.Windows.Forms.Label()
        Me.lblInterestRateOutput = New System.Windows.Forms.Label()
        Me.lblMonthlyPaymentOutput = New System.Windows.Forms.Label()
        Me.lblMontlyPayment = New System.Windows.Forms.Label()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.lblNoOfYears = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.ctxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcceptQuoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpAccessories.SuspendLayout()
        Me.grpCarExteriorFinish.SuspendLayout()
        Me.grpFinance.SuspendLayout()
        Me.ctxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(48, 37)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(85, 13)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "C&ustomer Name:"
        '
        'lblCarSalePrice
        '
        Me.lblCarSalePrice.AutoSize = True
        Me.lblCarSalePrice.Location = New System.Drawing.Point(49, 75)
        Me.lblCarSalePrice.Name = "lblCarSalePrice"
        Me.lblCarSalePrice.Size = New System.Drawing.Size(84, 13)
        Me.lblCarSalePrice.TabIndex = 2
        Me.lblCarSalePrice.Text = "C&ar's Sale Price:"
        '
        'lblAccessoriesAndFinish
        '
        Me.lblAccessoriesAndFinish.AutoSize = True
        Me.lblAccessoriesAndFinish.Location = New System.Drawing.Point(27, 116)
        Me.lblAccessoriesAndFinish.Name = "lblAccessoriesAndFinish"
        Me.lblAccessoriesAndFinish.Size = New System.Drawing.Size(106, 13)
        Me.lblAccessoriesAndFinish.TabIndex = 4
        Me.lblAccessoriesAndFinish.Text = "Accessories && Finish:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(84, 157)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.lblSubtotal.TabIndex = 6
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblSalesTax
        '
        Me.lblSalesTax.AutoSize = True
        Me.lblSalesTax.Location = New System.Drawing.Point(50, 198)
        Me.lblSalesTax.Name = "lblSalesTax"
        Me.lblSalesTax.Size = New System.Drawing.Size(83, 13)
        Me.lblSalesTax.TabIndex = 8
        Me.lblSalesTax.Text = "Sales Tax(12%):"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(99, 239)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total:"
        '
        'lblTradeIn
        '
        Me.lblTradeIn.AutoSize = True
        Me.lblTradeIn.Location = New System.Drawing.Point(32, 273)
        Me.lblTradeIn.Name = "lblTradeIn"
        Me.lblTradeIn.Size = New System.Drawing.Size(101, 13)
        Me.lblTradeIn.TabIndex = 12
        Me.lblTradeIn.Text = "T&rade-in Allowance:"
        '
        'lblAmountDue
        '
        Me.lblAmountDue.AutoSize = True
        Me.lblAmountDue.Location = New System.Drawing.Point(64, 318)
        Me.lblAmountDue.Name = "lblAmountDue"
        Me.lblAmountDue.Size = New System.Drawing.Size(69, 13)
        Me.lblAmountDue.TabIndex = 14
        Me.lblAmountDue.Text = "Amount Due:"
        '
        'grpAccessories
        '
        Me.grpAccessories.Controls.Add(Me.chkCompNav)
        Me.grpAccessories.Controls.Add(Me.chkLeather)
        Me.grpAccessories.Controls.Add(Me.chkStereo)
        Me.grpAccessories.Location = New System.Drawing.Point(295, 31)
        Me.grpAccessories.Name = "grpAccessories"
        Me.grpAccessories.Size = New System.Drawing.Size(200, 139)
        Me.grpAccessories.TabIndex = 16
        Me.grpAccessories.TabStop = False
        Me.grpAccessories.Text = "Accessories"
        '
        'chkCompNav
        '
        Me.chkCompNav.AutoSize = True
        Me.chkCompNav.Location = New System.Drawing.Point(24, 104)
        Me.chkCompNav.Name = "chkCompNav"
        Me.chkCompNav.Size = New System.Drawing.Size(125, 17)
        Me.chkCompNav.TabIndex = 2
        Me.chkCompNav.Text = "Computer &Navigation"
        Me.chkCompNav.UseVisualStyleBackColor = True
        '
        'chkLeather
        '
        Me.chkLeather.AutoSize = True
        Me.chkLeather.Location = New System.Drawing.Point(24, 67)
        Me.chkLeather.Name = "chkLeather"
        Me.chkLeather.Size = New System.Drawing.Size(97, 17)
        Me.chkLeather.TabIndex = 1
        Me.chkLeather.Text = "Leather &Interior"
        Me.chkLeather.UseVisualStyleBackColor = True
        '
        'chkStereo
        '
        Me.chkStereo.AutoSize = True
        Me.chkStereo.Location = New System.Drawing.Point(24, 30)
        Me.chkStereo.Name = "chkStereo"
        Me.chkStereo.Size = New System.Drawing.Size(94, 17)
        Me.chkStereo.TabIndex = 0
        Me.chkStereo.Text = "&Stereo System"
        Me.chkStereo.UseVisualStyleBackColor = True
        '
        'grpCarExteriorFinish
        '
        Me.grpCarExteriorFinish.Controls.Add(Me.radCustomDetail)
        Me.grpCarExteriorFinish.Controls.Add(Me.radPearlized)
        Me.grpCarExteriorFinish.Controls.Add(Me.radStandard)
        Me.grpCarExteriorFinish.Location = New System.Drawing.Point(295, 199)
        Me.grpCarExteriorFinish.Name = "grpCarExteriorFinish"
        Me.grpCarExteriorFinish.Size = New System.Drawing.Size(200, 121)
        Me.grpCarExteriorFinish.TabIndex = 17
        Me.grpCarExteriorFinish.TabStop = False
        Me.grpCarExteriorFinish.Text = "Car Exterior Finish"
        '
        'radCustomDetail
        '
        Me.radCustomDetail.AutoSize = True
        Me.radCustomDetail.Location = New System.Drawing.Point(24, 85)
        Me.radCustomDetail.Name = "radCustomDetail"
        Me.radCustomDetail.Size = New System.Drawing.Size(123, 17)
        Me.radCustomDetail.TabIndex = 2
        Me.radCustomDetail.Text = "Customized &Detailing"
        Me.radCustomDetail.UseVisualStyleBackColor = True
        '
        'radPearlized
        '
        Me.radPearlized.AutoSize = True
        Me.radPearlized.Location = New System.Drawing.Point(24, 52)
        Me.radPearlized.Name = "radPearlized"
        Me.radPearlized.Size = New System.Drawing.Size(68, 17)
        Me.radPearlized.TabIndex = 1
        Me.radPearlized.Text = "Pearli&zed"
        Me.radPearlized.UseVisualStyleBackColor = True
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Checked = True
        Me.radStandard.Location = New System.Drawing.Point(24, 19)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(68, 17)
        Me.radStandard.TabIndex = 0
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "S&tandard"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(178, 30)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerName.TabIndex = 1
        '
        'txtSalePrice
        '
        Me.txtSalePrice.Location = New System.Drawing.Point(178, 68)
        Me.txtSalePrice.Name = "txtSalePrice"
        Me.txtSalePrice.Size = New System.Drawing.Size(100, 20)
        Me.txtSalePrice.TabIndex = 3
        Me.txtSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTradeIn
        '
        Me.txtTradeIn.Location = New System.Drawing.Point(178, 270)
        Me.txtTradeIn.Name = "txtTradeIn"
        Me.txtTradeIn.Size = New System.Drawing.Size(100, 20)
        Me.txtTradeIn.TabIndex = 13
        Me.txtTradeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAccessoriesOutput
        '
        Me.lblAccessoriesOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAccessoriesOutput.Location = New System.Drawing.Point(178, 106)
        Me.lblAccessoriesOutput.Name = "lblAccessoriesOutput"
        Me.lblAccessoriesOutput.Size = New System.Drawing.Size(100, 23)
        Me.lblAccessoriesOutput.TabIndex = 5
        Me.lblAccessoriesOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubtotalOutput
        '
        Me.lblSubtotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotalOutput.Location = New System.Drawing.Point(178, 147)
        Me.lblSubtotalOutput.Name = "lblSubtotalOutput"
        Me.lblSubtotalOutput.Size = New System.Drawing.Size(100, 23)
        Me.lblSubtotalOutput.TabIndex = 7
        Me.lblSubtotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSalesTaxOutput
        '
        Me.lblSalesTaxOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalesTaxOutput.Location = New System.Drawing.Point(178, 188)
        Me.lblSalesTaxOutput.Name = "lblSalesTaxOutput"
        Me.lblSalesTaxOutput.Size = New System.Drawing.Size(100, 23)
        Me.lblSalesTaxOutput.TabIndex = 9
        Me.lblSalesTaxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalOutput
        '
        Me.lblTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalOutput.Location = New System.Drawing.Point(178, 229)
        Me.lblTotalOutput.Name = "lblTotalOutput"
        Me.lblTotalOutput.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalOutput.TabIndex = 11
        Me.lblTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAmountDueOutput
        '
        Me.lblAmountDueOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmountDueOutput.Location = New System.Drawing.Point(178, 308)
        Me.lblAmountDueOutput.Name = "lblAmountDueOutput"
        Me.lblAmountDueOutput.Size = New System.Drawing.Size(100, 23)
        Me.lblAmountDueOutput.TabIndex = 15
        Me.lblAmountDueOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'hsbInterestRate
        '
        Me.hsbInterestRate.LargeChange = 25
        Me.hsbInterestRate.Location = New System.Drawing.Point(187, 96)
        Me.hsbInterestRate.Maximum = 2524
        Me.hsbInterestRate.Name = "hsbInterestRate"
        Me.hsbInterestRate.Size = New System.Drawing.Size(80, 17)
        Me.hsbInterestRate.TabIndex = 21
        '
        'hsbYears
        '
        Me.hsbYears.LargeChange = 3
        Me.hsbYears.Location = New System.Drawing.Point(44, 96)
        Me.hsbYears.Maximum = 12
        Me.hsbYears.Minimum = 1
        Me.hsbYears.Name = "hsbYears"
        Me.hsbYears.Size = New System.Drawing.Size(80, 17)
        Me.hsbYears.TabIndex = 22
        Me.hsbYears.Value = 1
        '
        'grpFinance
        '
        Me.grpFinance.Controls.Add(Me.lblNoOfYearsOutput)
        Me.grpFinance.Controls.Add(Me.lblInterestRateOutput)
        Me.grpFinance.Controls.Add(Me.lblMonthlyPaymentOutput)
        Me.grpFinance.Controls.Add(Me.lblMontlyPayment)
        Me.grpFinance.Controls.Add(Me.lblInterestRate)
        Me.grpFinance.Controls.Add(Me.lblNoOfYears)
        Me.grpFinance.Controls.Add(Me.hsbYears)
        Me.grpFinance.Controls.Add(Me.hsbInterestRate)
        Me.grpFinance.Enabled = False
        Me.grpFinance.Location = New System.Drawing.Point(22, 367)
        Me.grpFinance.Name = "grpFinance"
        Me.grpFinance.Size = New System.Drawing.Size(473, 134)
        Me.grpFinance.TabIndex = 23
        Me.grpFinance.TabStop = False
        Me.grpFinance.Text = "Finance"
        '
        'lblNoOfYearsOutput
        '
        Me.lblNoOfYearsOutput.AutoSize = True
        Me.lblNoOfYearsOutput.Location = New System.Drawing.Point(55, 60)
        Me.lblNoOfYearsOutput.Name = "lblNoOfYearsOutput"
        Me.lblNoOfYearsOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblNoOfYearsOutput.TabIndex = 28
        '
        'lblInterestRateOutput
        '
        Me.lblInterestRateOutput.AutoSize = True
        Me.lblInterestRateOutput.Location = New System.Drawing.Point(190, 61)
        Me.lblInterestRateOutput.Name = "lblInterestRateOutput"
        Me.lblInterestRateOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblInterestRateOutput.TabIndex = 27
        '
        'lblMonthlyPaymentOutput
        '
        Me.lblMonthlyPaymentOutput.AutoSize = True
        Me.lblMonthlyPaymentOutput.Location = New System.Drawing.Point(325, 59)
        Me.lblMonthlyPaymentOutput.Name = "lblMonthlyPaymentOutput"
        Me.lblMonthlyPaymentOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblMonthlyPaymentOutput.TabIndex = 26
        '
        'lblMontlyPayment
        '
        Me.lblMontlyPayment.AutoSize = True
        Me.lblMontlyPayment.Location = New System.Drawing.Point(318, 31)
        Me.lblMontlyPayment.Name = "lblMontlyPayment"
        Me.lblMontlyPayment.Size = New System.Drawing.Size(88, 13)
        Me.lblMontlyPayment.TabIndex = 25
        Me.lblMontlyPayment.Text = "Monthly Payment"
        '
        'lblInterestRate
        '
        Me.lblInterestRate.AutoSize = True
        Me.lblInterestRate.Location = New System.Drawing.Point(184, 31)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(68, 13)
        Me.lblInterestRate.TabIndex = 24
        Me.lblInterestRate.Text = "Interest Rate"
        '
        'lblNoOfYears
        '
        Me.lblNoOfYears.AutoSize = True
        Me.lblNoOfYears.Location = New System.Drawing.Point(52, 31)
        Me.lblNoOfYears.Name = "lblNoOfYears"
        Me.lblNoOfYears.Size = New System.Drawing.Size(68, 13)
        Me.lblNoOfYears.TabIndex = 23
        Me.lblNoOfYears.Text = "No. Of Years"
        '
        'lblLine
        '
        Me.lblLine.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblLine.Location = New System.Drawing.Point(22, 349)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(473, 3)
        Me.lblLine.TabIndex = 24
        '
        'ctxMenu
        '
        Me.ctxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.AcceptQuoteToolStripMenuItem, Me.ClearToolStripMenuItem, Me.SummaryToolStripMenuItem})
        Me.ctxMenu.Name = "ContextMenuStrip1"
        Me.ctxMenu.Size = New System.Drawing.Size(153, 114)
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Enabled = False
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.CalculateToolStripMenuItem.Text = "Calculate"
        '
        'AcceptQuoteToolStripMenuItem
        '
        Me.AcceptQuoteToolStripMenuItem.Enabled = False
        Me.AcceptQuoteToolStripMenuItem.Name = "AcceptQuoteToolStripMenuItem"
        Me.AcceptQuoteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AcceptQuoteToolStripMenuItem.Text = "Accept Quote"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Enabled = False
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SummaryToolStripMenuItem.Text = "Summary"
        '
        'frmEstimate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 509)
        Me.ContextMenuStrip = Me.ctxMenu
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.grpFinance)
        Me.Controls.Add(Me.lblAmountDueOutput)
        Me.Controls.Add(Me.lblTotalOutput)
        Me.Controls.Add(Me.lblSalesTaxOutput)
        Me.Controls.Add(Me.lblSubtotalOutput)
        Me.Controls.Add(Me.lblAccessoriesOutput)
        Me.Controls.Add(Me.txtTradeIn)
        Me.Controls.Add(Me.txtSalePrice)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.grpCarExteriorFinish)
        Me.Controls.Add(Me.grpAccessories)
        Me.Controls.Add(Me.lblAmountDue)
        Me.Controls.Add(Me.lblTradeIn)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSalesTax)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lblAccessoriesAndFinish)
        Me.Controls.Add(Me.lblCarSalePrice)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Name = "frmEstimate"
        Me.Text = "VB Auto Centre - Estimate"
        Me.grpAccessories.ResumeLayout(False)
        Me.grpAccessories.PerformLayout()
        Me.grpCarExteriorFinish.ResumeLayout(False)
        Me.grpCarExteriorFinish.PerformLayout()
        Me.grpFinance.ResumeLayout(False)
        Me.grpFinance.PerformLayout()
        Me.ctxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents lblCarSalePrice As System.Windows.Forms.Label
    Friend WithEvents lblAccessoriesAndFinish As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblSalesTax As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTradeIn As System.Windows.Forms.Label
    Friend WithEvents lblAmountDue As System.Windows.Forms.Label
    Friend WithEvents grpAccessories As System.Windows.Forms.GroupBox
    Friend WithEvents chkCompNav As System.Windows.Forms.CheckBox
    Friend WithEvents chkLeather As System.Windows.Forms.CheckBox
    Friend WithEvents chkStereo As System.Windows.Forms.CheckBox
    Friend WithEvents grpCarExteriorFinish As System.Windows.Forms.GroupBox
    Friend WithEvents radCustomDetail As System.Windows.Forms.RadioButton
    Friend WithEvents radPearlized As System.Windows.Forms.RadioButton
    Friend WithEvents radStandard As System.Windows.Forms.RadioButton
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents txtSalePrice As System.Windows.Forms.TextBox
    Friend WithEvents txtTradeIn As System.Windows.Forms.TextBox
    Friend WithEvents lblAccessoriesOutput As System.Windows.Forms.Label
    Friend WithEvents lblSubtotalOutput As System.Windows.Forms.Label
    Friend WithEvents lblSalesTaxOutput As System.Windows.Forms.Label
    Friend WithEvents lblTotalOutput As System.Windows.Forms.Label
    Friend WithEvents lblAmountDueOutput As System.Windows.Forms.Label
    Friend WithEvents hsbInterestRate As System.Windows.Forms.HScrollBar
    Friend WithEvents hsbYears As System.Windows.Forms.HScrollBar
    Friend WithEvents grpFinance As System.Windows.Forms.GroupBox
    Friend WithEvents lblMontlyPayment As System.Windows.Forms.Label
    Friend WithEvents lblInterestRate As System.Windows.Forms.Label
    Friend WithEvents lblNoOfYears As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents ctxMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CalculateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcceptQuoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblMonthlyPaymentOutput As System.Windows.Forms.Label
    Friend WithEvents lblNoOfYearsOutput As System.Windows.Forms.Label
    Friend WithEvents lblInterestRateOutput As System.Windows.Forms.Label
End Class
