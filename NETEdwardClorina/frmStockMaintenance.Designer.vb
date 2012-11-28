<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockMaintenance
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
        Me.lblStockNo = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblCostPrice = New System.Windows.Forms.Label()
        Me.lblRetailPrice = New System.Windows.Forms.Label()
        Me.lblStockNoOutput = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtCostPrice = New System.Windows.Forms.TextBox()
        Me.txtRetailPrice = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtColour = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblVBAuto
        '
        Me.lblVBAuto.Location = New System.Drawing.Point(162, 25)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(340, 274)
        '
        'lblBlackBar1
        '
        Me.lblBlackBar1.Location = New System.Drawing.Point(44, 237)
        Me.lblBlackBar1.Size = New System.Drawing.Size(371, 3)
        '
        'lblBlackBar2
        '
        Me.lblBlackBar2.Location = New System.Drawing.Point(44, 274)
        Me.lblBlackBar2.Size = New System.Drawing.Size(277, 3)
        '
        'lblBlackBar3
        '
        Me.lblBlackBar3.Location = New System.Drawing.Point(44, 289)
        Me.lblBlackBar3.Size = New System.Drawing.Size(277, 3)
        '
        'lblStockNo
        '
        Me.lblStockNo.AutoSize = True
        Me.lblStockNo.Location = New System.Drawing.Point(47, 74)
        Me.lblStockNo.Name = "lblStockNo"
        Me.lblStockNo.Size = New System.Drawing.Size(48, 13)
        Me.lblStockNo.TabIndex = 5
        Me.lblStockNo.Text = "Stock #:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(32, 109)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 13)
        Me.lblDescription.TabIndex = 6
        Me.lblDescription.Text = "Description:"
        '
        'lblCostPrice
        '
        Me.lblCostPrice.AutoSize = True
        Me.lblCostPrice.Location = New System.Drawing.Point(37, 141)
        Me.lblCostPrice.Name = "lblCostPrice"
        Me.lblCostPrice.Size = New System.Drawing.Size(58, 13)
        Me.lblCostPrice.TabIndex = 7
        Me.lblCostPrice.Text = "Cost Price:"
        '
        'lblRetailPrice
        '
        Me.lblRetailPrice.AutoSize = True
        Me.lblRetailPrice.Location = New System.Drawing.Point(31, 178)
        Me.lblRetailPrice.Name = "lblRetailPrice"
        Me.lblRetailPrice.Size = New System.Drawing.Size(64, 13)
        Me.lblRetailPrice.TabIndex = 8
        Me.lblRetailPrice.Text = "Retail Price:"
        '
        'lblStockNoOutput
        '
        Me.lblStockNoOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStockNoOutput.Location = New System.Drawing.Point(128, 64)
        Me.lblStockNoOutput.Name = "lblStockNoOutput"
        Me.lblStockNoOutput.Size = New System.Drawing.Size(108, 23)
        Me.lblStockNoOutput.TabIndex = 9
        Me.lblStockNoOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(128, 102)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(108, 20)
        Me.txtDescription.TabIndex = 10
        '
        'txtCostPrice
        '
        Me.txtCostPrice.Location = New System.Drawing.Point(128, 134)
        Me.txtCostPrice.Name = "txtCostPrice"
        Me.txtCostPrice.Size = New System.Drawing.Size(108, 20)
        Me.txtCostPrice.TabIndex = 11
        Me.txtCostPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.Location = New System.Drawing.Point(128, 170)
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.Size = New System.Drawing.Size(108, 20)
        Me.txtRetailPrice.TabIndex = 12
        Me.txtRetailPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(270, 74)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 13
        Me.lblYear.Text = "Year:"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(263, 108)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(39, 13)
        Me.lblModel.TabIndex = 14
        Me.lblModel.Text = "Model:"
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(262, 141)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(40, 13)
        Me.lblColour.TabIndex = 15
        Me.lblColour.Text = "Colour:"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(324, 67)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 16
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(324, 101)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(100, 20)
        Me.txtModel.TabIndex = 17
        '
        'txtColour
        '
        Me.txtColour.Location = New System.Drawing.Point(324, 133)
        Me.txtColour.Name = "txtColour"
        Me.txtColour.Size = New System.Drawing.Size(100, 20)
        Me.txtColour.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(47, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 3)
        Me.Label1.TabIndex = 19
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(340, 244)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 20
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmStockMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(449, 314)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtColour)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.txtRetailPrice)
        Me.Controls.Add(Me.lblStockNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblCostPrice)
        Me.Controls.Add(Me.txtCostPrice)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblRetailPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblStockNoOutput)
        Me.Name = "frmStockMaintenance"
        Me.Text = "Stock Maintenance"
        Me.Controls.SetChildIndex(Me.lblStockNoOutput, 0)
        Me.Controls.SetChildIndex(Me.lblYear, 0)
        Me.Controls.SetChildIndex(Me.lblRetailPrice, 0)
        Me.Controls.SetChildIndex(Me.txtDescription, 0)
        Me.Controls.SetChildIndex(Me.txtCostPrice, 0)
        Me.Controls.SetChildIndex(Me.lblCostPrice, 0)
        Me.Controls.SetChildIndex(Me.lblDescription, 0)
        Me.Controls.SetChildIndex(Me.lblColour, 0)
        Me.Controls.SetChildIndex(Me.txtYear, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar1, 0)
        Me.Controls.SetChildIndex(Me.lblVBAuto, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.lblStockNo, 0)
        Me.Controls.SetChildIndex(Me.txtRetailPrice, 0)
        Me.Controls.SetChildIndex(Me.lblModel, 0)
        Me.Controls.SetChildIndex(Me.txtModel, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.txtColour, 0)
        Me.Controls.SetChildIndex(Me.btnUpdate, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar3, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStockNo As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblCostPrice As System.Windows.Forms.Label
    Friend WithEvents lblRetailPrice As System.Windows.Forms.Label
    Friend WithEvents lblStockNoOutput As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtCostPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtRetailPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents lblColour As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents txtColour As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button

End Class
