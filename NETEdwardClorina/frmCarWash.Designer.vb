<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarWash
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
        Me.lblBlackBar4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblDetail = New System.Windows.Forms.Label()
        Me.lblFragrance = New System.Windows.Forms.Label()
        Me.lblInterior = New System.Windows.Forms.Label()
        Me.lblExterior = New System.Windows.Forms.Label()
        Me.lstInterior = New System.Windows.Forms.ListBox()
        Me.lstExterior = New System.Windows.Forms.ListBox()
        Me.cboDetail = New System.Windows.Forms.ComboBox()
        Me.cboFragrance = New System.Windows.Forms.ComboBox()
        Me.lblCharges = New System.Windows.Forms.Label()
        Me.lblTaxes = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblChargesOutput = New System.Windows.Forms.Label()
        Me.lblTaxesOutput = New System.Windows.Forms.Label()
        Me.lblTotalOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblVBAuto
        '
        Me.lblVBAuto.Location = New System.Drawing.Point(148, 9)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(346, 387)
        '
        'lblBlackBar1
        '
        Me.lblBlackBar1.Location = New System.Drawing.Point(47, 368)
        Me.lblBlackBar1.Size = New System.Drawing.Size(294, 3)
        '
        'lblBlackBar2
        '
        Me.lblBlackBar2.Location = New System.Drawing.Point(47, 387)
        Me.lblBlackBar2.Size = New System.Drawing.Size(294, 3)
        '
        'lblBlackBar3
        '
        Me.lblBlackBar3.Location = New System.Drawing.Point(47, 407)
        Me.lblBlackBar3.Size = New System.Drawing.Size(294, 3)
        '
        'lblBlackBar4
        '
        Me.lblBlackBar4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBlackBar4.Location = New System.Drawing.Point(47, 347)
        Me.lblBlackBar4.Name = "lblBlackBar4"
        Me.lblBlackBar4.Size = New System.Drawing.Size(375, 3)
        Me.lblBlackBar4.TabIndex = 5
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(346, 356)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblDetail
        '
        Me.lblDetail.AutoSize = True
        Me.lblDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetail.Location = New System.Drawing.Point(21, 60)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(70, 16)
        Me.lblDetail.TabIndex = 7
        Me.lblDetail.Text = "Detailing"
        '
        'lblFragrance
        '
        Me.lblFragrance.AutoSize = True
        Me.lblFragrance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFragrance.Location = New System.Drawing.Point(21, 191)
        Me.lblFragrance.Name = "lblFragrance"
        Me.lblFragrance.Size = New System.Drawing.Size(79, 16)
        Me.lblFragrance.TabIndex = 8
        Me.lblFragrance.Text = "Fragrance"
        '
        'lblInterior
        '
        Me.lblInterior.AutoSize = True
        Me.lblInterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterior.Location = New System.Drawing.Point(191, 46)
        Me.lblInterior.Name = "lblInterior"
        Me.lblInterior.Size = New System.Drawing.Size(56, 16)
        Me.lblInterior.TabIndex = 9
        Me.lblInterior.Text = "Interior"
        '
        'lblExterior
        '
        Me.lblExterior.AutoSize = True
        Me.lblExterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExterior.Location = New System.Drawing.Point(332, 46)
        Me.lblExterior.Name = "lblExterior"
        Me.lblExterior.Size = New System.Drawing.Size(61, 16)
        Me.lblExterior.TabIndex = 10
        Me.lblExterior.Text = "Exterior"
        '
        'lstInterior
        '
        Me.lstInterior.FormattingEnabled = True
        Me.lstInterior.Location = New System.Drawing.Point(158, 68)
        Me.lstInterior.Name = "lstInterior"
        Me.lstInterior.Size = New System.Drawing.Size(120, 95)
        Me.lstInterior.Sorted = True
        Me.lstInterior.TabIndex = 11
        '
        'lstExterior
        '
        Me.lstExterior.FormattingEnabled = True
        Me.lstExterior.Location = New System.Drawing.Point(306, 68)
        Me.lstExterior.Name = "lstExterior"
        Me.lstExterior.Size = New System.Drawing.Size(120, 95)
        Me.lstExterior.TabIndex = 12
        '
        'cboDetail
        '
        Me.cboDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDetail.FormattingEnabled = True
        Me.cboDetail.Location = New System.Drawing.Point(24, 79)
        Me.cboDetail.Name = "cboDetail"
        Me.cboDetail.Size = New System.Drawing.Size(94, 21)
        Me.cboDetail.TabIndex = 13
        '
        'cboFragrance
        '
        Me.cboFragrance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFragrance.FormattingEnabled = True
        Me.cboFragrance.Location = New System.Drawing.Point(24, 210)
        Me.cboFragrance.Name = "cboFragrance"
        Me.cboFragrance.Size = New System.Drawing.Size(94, 21)
        Me.cboFragrance.Sorted = True
        Me.cboFragrance.TabIndex = 14
        '
        'lblCharges
        '
        Me.lblCharges.AutoSize = True
        Me.lblCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharges.Location = New System.Drawing.Point(249, 215)
        Me.lblCharges.Name = "lblCharges"
        Me.lblCharges.Size = New System.Drawing.Size(70, 16)
        Me.lblCharges.TabIndex = 15
        Me.lblCharges.Text = "Charges:"
        '
        'lblTaxes
        '
        Me.lblTaxes.AutoSize = True
        Me.lblTaxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxes.Location = New System.Drawing.Point(122, 257)
        Me.lblTaxes.Name = "lblTaxes"
        Me.lblTaxes.Size = New System.Drawing.Size(200, 16)
        Me.lblTaxes.TabIndex = 16
        Me.lblTaxes.Text = "Taxes (GST && PST) @ 12%:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(271, 291)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(48, 16)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.Text = "Total:"
        '
        'lblChargesOutput
        '
        Me.lblChargesOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChargesOutput.Location = New System.Drawing.Point(328, 216)
        Me.lblChargesOutput.Name = "lblChargesOutput"
        Me.lblChargesOutput.Size = New System.Drawing.Size(93, 22)
        Me.lblChargesOutput.TabIndex = 18
        Me.lblChargesOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTaxesOutput
        '
        Me.lblTaxesOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaxesOutput.Location = New System.Drawing.Point(328, 251)
        Me.lblTaxesOutput.Name = "lblTaxesOutput"
        Me.lblTaxesOutput.Size = New System.Drawing.Size(93, 22)
        Me.lblTaxesOutput.TabIndex = 19
        Me.lblTaxesOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalOutput
        '
        Me.lblTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalOutput.Location = New System.Drawing.Point(328, 285)
        Me.lblTotalOutput.Name = "lblTotalOutput"
        Me.lblTotalOutput.Size = New System.Drawing.Size(93, 22)
        Me.lblTotalOutput.TabIndex = 20
        Me.lblTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCarWash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(438, 423)
        Me.Controls.Add(Me.cboFragrance)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblInterior)
        Me.Controls.Add(Me.lblCharges)
        Me.Controls.Add(Me.lblChargesOutput)
        Me.Controls.Add(Me.cboDetail)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTaxes)
        Me.Controls.Add(Me.lblBlackBar4)
        Me.Controls.Add(Me.lstExterior)
        Me.Controls.Add(Me.lblFragrance)
        Me.Controls.Add(Me.lstInterior)
        Me.Controls.Add(Me.lblTotalOutput)
        Me.Controls.Add(Me.lblTaxesOutput)
        Me.Controls.Add(Me.lblDetail)
        Me.Controls.Add(Me.lblExterior)
        Me.Name = "frmCarWash"
        Me.Controls.SetChildIndex(Me.lblExterior, 0)
        Me.Controls.SetChildIndex(Me.lblDetail, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar1, 0)
        Me.Controls.SetChildIndex(Me.lblTaxesOutput, 0)
        Me.Controls.SetChildIndex(Me.lblTotalOutput, 0)
        Me.Controls.SetChildIndex(Me.lstInterior, 0)
        Me.Controls.SetChildIndex(Me.lblFragrance, 0)
        Me.Controls.SetChildIndex(Me.lstExterior, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar4, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar3, 0)
        Me.Controls.SetChildIndex(Me.lblTaxes, 0)
        Me.Controls.SetChildIndex(Me.lblTotal, 0)
        Me.Controls.SetChildIndex(Me.cboDetail, 0)
        Me.Controls.SetChildIndex(Me.lblChargesOutput, 0)
        Me.Controls.SetChildIndex(Me.lblCharges, 0)
        Me.Controls.SetChildIndex(Me.lblInterior, 0)
        Me.Controls.SetChildIndex(Me.btnClear, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar2, 0)
        Me.Controls.SetChildIndex(Me.cboFragrance, 0)
        Me.Controls.SetChildIndex(Me.lblVBAuto, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBlackBar4 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblDetail As System.Windows.Forms.Label
    Friend WithEvents lblFragrance As System.Windows.Forms.Label
    Friend WithEvents lblInterior As System.Windows.Forms.Label
    Friend WithEvents lblExterior As System.Windows.Forms.Label
    Friend WithEvents lstInterior As System.Windows.Forms.ListBox
    Friend WithEvents lstExterior As System.Windows.Forms.ListBox
    Friend WithEvents cboDetail As System.Windows.Forms.ComboBox
    Friend WithEvents cboFragrance As System.Windows.Forms.ComboBox
    Friend WithEvents lblCharges As System.Windows.Forms.Label
    Friend WithEvents lblTaxes As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblChargesOutput As System.Windows.Forms.Label
    Friend WithEvents lblTaxesOutput As System.Windows.Forms.Label
    Friend WithEvents lblTotalOutput As System.Windows.Forms.Label

End Class
