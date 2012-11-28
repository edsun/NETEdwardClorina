<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVBAuto
    Inherits NETEdwardClorina.frmBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpSalesPerson = New System.Windows.Forms.GroupBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblDealerCodeOutput = New System.Windows.Forms.Label()
        Me.lblSalesPersonNameOutput = New System.Windows.Forms.Label()
        Me.lblSalesPersonIDOutput = New System.Windows.Forms.Label()
        Me.lblDealerCode = New System.Windows.Forms.Label()
        Me.lblSalesPersonName = New System.Windows.Forms.Label()
        Me.lblSalesPersonID = New System.Windows.Forms.Label()
        Me.grpStockInfo = New System.Windows.Forms.GroupBox()
        Me.btnViewComm = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.cboStockNo = New System.Windows.Forms.ComboBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtCostPrice = New System.Windows.Forms.TextBox()
        Me.txtRetailPrice = New System.Windows.Forms.TextBox()
        Me.lblCommissionOutput = New System.Windows.Forms.Label()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.lblRetailPrice = New System.Windows.Forms.Label()
        Me.lblCostPrice = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblStockNo = New System.Windows.Forms.Label()
        Me.grpSalesPerson.SuspendLayout()
        Me.grpStockInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVBAuto
        '
        Me.lblVBAuto.Location = New System.Drawing.Point(122, 34)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(295, 448)
        '
        'lblBlackBar1
        '
        Me.lblBlackBar1.Location = New System.Drawing.Point(44, 437)
        Me.lblBlackBar1.Size = New System.Drawing.Size(326, 3)
        '
        'lblBlackBar2
        '
        Me.lblBlackBar2.Location = New System.Drawing.Point(44, 453)
        Me.lblBlackBar2.Size = New System.Drawing.Size(245, 3)
        '
        'lblBlackBar3
        '
        Me.lblBlackBar3.Location = New System.Drawing.Point(44, 469)
        Me.lblBlackBar3.Size = New System.Drawing.Size(245, 3)
        '
        'grpSalesPerson
        '
        Me.grpSalesPerson.Controls.Add(Me.btnNext)
        Me.grpSalesPerson.Controls.Add(Me.btnPrevious)
        Me.grpSalesPerson.Controls.Add(Me.lblDealerCodeOutput)
        Me.grpSalesPerson.Controls.Add(Me.lblSalesPersonNameOutput)
        Me.grpSalesPerson.Controls.Add(Me.lblSalesPersonIDOutput)
        Me.grpSalesPerson.Controls.Add(Me.lblDealerCode)
        Me.grpSalesPerson.Controls.Add(Me.lblSalesPersonName)
        Me.grpSalesPerson.Controls.Add(Me.lblSalesPersonID)
        Me.grpSalesPerson.Location = New System.Drawing.Point(26, 75)
        Me.grpSalesPerson.Name = "grpSalesPerson"
        Me.grpSalesPerson.Size = New System.Drawing.Size(340, 136)
        Me.grpSalesPerson.TabIndex = 5
        Me.grpSalesPerson.TabStop = False
        Me.grpSalesPerson.Text = "Sales Person Info"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(238, 107)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(157, 107)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 6
        Me.btnPrevious.Text = "&Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'lblDealerCodeOutput
        '
        Me.lblDealerCodeOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDealerCodeOutput.Location = New System.Drawing.Point(157, 72)
        Me.lblDealerCodeOutput.Name = "lblDealerCodeOutput"
        Me.lblDealerCodeOutput.Size = New System.Drawing.Size(151, 23)
        Me.lblDealerCodeOutput.TabIndex = 5
        Me.lblDealerCodeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSalesPersonNameOutput
        '
        Me.lblSalesPersonNameOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalesPersonNameOutput.Location = New System.Drawing.Point(157, 45)
        Me.lblSalesPersonNameOutput.Name = "lblSalesPersonNameOutput"
        Me.lblSalesPersonNameOutput.Size = New System.Drawing.Size(151, 23)
        Me.lblSalesPersonNameOutput.TabIndex = 4
        Me.lblSalesPersonNameOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSalesPersonIDOutput
        '
        Me.lblSalesPersonIDOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalesPersonIDOutput.Location = New System.Drawing.Point(157, 15)
        Me.lblSalesPersonIDOutput.Name = "lblSalesPersonIDOutput"
        Me.lblSalesPersonIDOutput.Size = New System.Drawing.Size(151, 23)
        Me.lblSalesPersonIDOutput.TabIndex = 3
        Me.lblSalesPersonIDOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDealerCode
        '
        Me.lblDealerCode.AutoSize = True
        Me.lblDealerCode.Location = New System.Drawing.Point(61, 82)
        Me.lblDealerCode.Name = "lblDealerCode"
        Me.lblDealerCode.Size = New System.Drawing.Size(69, 13)
        Me.lblDealerCode.TabIndex = 2
        Me.lblDealerCode.Text = "Dealer Code:"
        '
        'lblSalesPersonName
        '
        Me.lblSalesPersonName.AutoSize = True
        Me.lblSalesPersonName.Location = New System.Drawing.Point(27, 55)
        Me.lblSalesPersonName.Name = "lblSalesPersonName"
        Me.lblSalesPersonName.Size = New System.Drawing.Size(103, 13)
        Me.lblSalesPersonName.TabIndex = 1
        Me.lblSalesPersonName.Text = "Sales Person Name:"
        '
        'lblSalesPersonID
        '
        Me.lblSalesPersonID.AutoSize = True
        Me.lblSalesPersonID.Location = New System.Drawing.Point(44, 25)
        Me.lblSalesPersonID.Name = "lblSalesPersonID"
        Me.lblSalesPersonID.Size = New System.Drawing.Size(86, 13)
        Me.lblSalesPersonID.TabIndex = 0
        Me.lblSalesPersonID.Text = "Sales Person ID:"
        '
        'grpStockInfo
        '
        Me.grpStockInfo.Controls.Add(Me.btnViewComm)
        Me.grpStockInfo.Controls.Add(Me.btnCalculate)
        Me.grpStockInfo.Controls.Add(Me.cboStockNo)
        Me.grpStockInfo.Controls.Add(Me.txtDescription)
        Me.grpStockInfo.Controls.Add(Me.txtCostPrice)
        Me.grpStockInfo.Controls.Add(Me.txtRetailPrice)
        Me.grpStockInfo.Controls.Add(Me.lblCommissionOutput)
        Me.grpStockInfo.Controls.Add(Me.lblCommission)
        Me.grpStockInfo.Controls.Add(Me.lblRetailPrice)
        Me.grpStockInfo.Controls.Add(Me.lblCostPrice)
        Me.grpStockInfo.Controls.Add(Me.lblDescription)
        Me.grpStockInfo.Controls.Add(Me.lblStockNo)
        Me.grpStockInfo.Location = New System.Drawing.Point(26, 217)
        Me.grpStockInfo.Name = "grpStockInfo"
        Me.grpStockInfo.Size = New System.Drawing.Size(340, 200)
        Me.grpStockInfo.TabIndex = 6
        Me.grpStockInfo.TabStop = False
        Me.grpStockInfo.Text = "Stock Information"
        '
        'btnViewComm
        '
        Me.btnViewComm.Location = New System.Drawing.Point(238, 168)
        Me.btnViewComm.Name = "btnViewComm"
        Me.btnViewComm.Size = New System.Drawing.Size(75, 23)
        Me.btnViewComm.TabIndex = 11
        Me.btnViewComm.Text = "View Comm"
        Me.btnViewComm.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(157, 168)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Ca&lculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'cboStockNo
        '
        Me.cboStockNo.FormattingEnabled = True
        Me.cboStockNo.Location = New System.Drawing.Point(157, 24)
        Me.cboStockNo.Name = "cboStockNo"
        Me.cboStockNo.Size = New System.Drawing.Size(156, 21)
        Me.cboStockNo.TabIndex = 9
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(157, 51)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(156, 20)
        Me.txtDescription.TabIndex = 8
        '
        'txtCostPrice
        '
        Me.txtCostPrice.Location = New System.Drawing.Point(157, 77)
        Me.txtCostPrice.Name = "txtCostPrice"
        Me.txtCostPrice.Size = New System.Drawing.Size(156, 20)
        Me.txtCostPrice.TabIndex = 7
        Me.txtCostPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.Location = New System.Drawing.Point(157, 103)
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.Size = New System.Drawing.Size(156, 20)
        Me.txtRetailPrice.TabIndex = 6
        Me.txtRetailPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCommissionOutput
        '
        Me.lblCommissionOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCommissionOutput.Location = New System.Drawing.Point(157, 132)
        Me.lblCommissionOutput.Name = "lblCommissionOutput"
        Me.lblCommissionOutput.Size = New System.Drawing.Size(156, 23)
        Me.lblCommissionOutput.TabIndex = 5
        Me.lblCommissionOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCommission
        '
        Me.lblCommission.AutoSize = True
        Me.lblCommission.Location = New System.Drawing.Point(56, 142)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(65, 13)
        Me.lblCommission.TabIndex = 4
        Me.lblCommission.Text = "Commission:"
        '
        'lblRetailPrice
        '
        Me.lblRetailPrice.AutoSize = True
        Me.lblRetailPrice.Location = New System.Drawing.Point(55, 110)
        Me.lblRetailPrice.Name = "lblRetailPrice"
        Me.lblRetailPrice.Size = New System.Drawing.Size(64, 13)
        Me.lblRetailPrice.TabIndex = 3
        Me.lblRetailPrice.Text = "&Retail Price:"
        '
        'lblCostPrice
        '
        Me.lblCostPrice.AutoSize = True
        Me.lblCostPrice.Location = New System.Drawing.Point(61, 84)
        Me.lblCostPrice.Name = "lblCostPrice"
        Me.lblCostPrice.Size = New System.Drawing.Size(58, 13)
        Me.lblCostPrice.TabIndex = 2
        Me.lblCostPrice.Text = "&Cost Price:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(56, 58)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 13)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "&Description:"
        '
        'lblStockNo
        '
        Me.lblStockNo.AutoSize = True
        Me.lblStockNo.Location = New System.Drawing.Point(71, 32)
        Me.lblStockNo.Name = "lblStockNo"
        Me.lblStockNo.Size = New System.Drawing.Size(48, 13)
        Me.lblStockNo.TabIndex = 0
        Me.lblStockNo.Text = "Stock #:"
        '
        'frmVBAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(399, 485)
        Me.Controls.Add(Me.grpSalesPerson)
        Me.Controls.Add(Me.grpStockInfo)
        Me.Name = "frmVBAuto"
        Me.Text = "VB Auto Commission"
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar3, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar1, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar2, 0)
        Me.Controls.SetChildIndex(Me.grpStockInfo, 0)
        Me.Controls.SetChildIndex(Me.grpSalesPerson, 0)
        Me.Controls.SetChildIndex(Me.lblVBAuto, 0)
        Me.grpSalesPerson.ResumeLayout(False)
        Me.grpSalesPerson.PerformLayout()
        Me.grpStockInfo.ResumeLayout(False)
        Me.grpStockInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSalesPerson As System.Windows.Forms.GroupBox
    Friend WithEvents lblDealerCodeOutput As System.Windows.Forms.Label
    Friend WithEvents lblSalesPersonNameOutput As System.Windows.Forms.Label
    Friend WithEvents lblSalesPersonIDOutput As System.Windows.Forms.Label
    Friend WithEvents lblDealerCode As System.Windows.Forms.Label
    Friend WithEvents lblSalesPersonName As System.Windows.Forms.Label
    Friend WithEvents lblSalesPersonID As System.Windows.Forms.Label
    Friend WithEvents grpStockInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnViewComm As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents cboStockNo As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtCostPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtRetailPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblCommissionOutput As System.Windows.Forms.Label
    Friend WithEvents lblCommission As System.Windows.Forms.Label
    Friend WithEvents lblRetailPrice As System.Windows.Forms.Label
    Friend WithEvents lblCostPrice As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblStockNo As System.Windows.Forms.Label

End Class
