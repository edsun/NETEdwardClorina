<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmService
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
        Me.components = New System.ComponentModel.Container()
        Me.lblServiceDescription = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblParts = New System.Windows.Forms.Label()
        Me.lblShopMaterial = New System.Windows.Forms.Label()
        Me.lblPST = New System.Windows.Forms.Label()
        Me.lblGST = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtServiceDescription = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.lblPSTOutput = New System.Windows.Forms.Label()
        Me.lblGSTOutput = New System.Windows.Forms.Label()
        Me.lblTotalOutput = New System.Windows.Forms.Label()
        Me.txtShopMaterial = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVBAuto
        '
        Me.lblVBAuto.Location = New System.Drawing.Point(150, 36)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(334, 361)
        Me.btnExit.TabIndex = 17
        '
        'lblBlackBar1
        '
        Me.lblBlackBar1.Location = New System.Drawing.Point(12, 344)
        Me.lblBlackBar1.Size = New System.Drawing.Size(397, 3)
        Me.lblBlackBar1.TabIndex = 14
        '
        'lblBlackBar2
        '
        Me.lblBlackBar2.Location = New System.Drawing.Point(12, 361)
        Me.lblBlackBar2.Size = New System.Drawing.Size(300, 3)
        Me.lblBlackBar2.TabIndex = 15
        '
        'lblBlackBar3
        '
        Me.lblBlackBar3.Location = New System.Drawing.Point(12, 381)
        Me.lblBlackBar3.Size = New System.Drawing.Size(300, 3)
        Me.lblBlackBar3.TabIndex = 16
        '
        'lblServiceDescription
        '
        Me.lblServiceDescription.AutoSize = True
        Me.lblServiceDescription.Location = New System.Drawing.Point(80, 79)
        Me.lblServiceDescription.Name = "lblServiceDescription"
        Me.lblServiceDescription.Size = New System.Drawing.Size(102, 13)
        Me.lblServiceDescription.TabIndex = 0
        Me.lblServiceDescription.Text = "Service Description:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(148, 123)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Price:"
        '
        'lblParts
        '
        Me.lblParts.AutoSize = True
        Me.lblParts.Location = New System.Drawing.Point(148, 156)
        Me.lblParts.Name = "lblParts"
        Me.lblParts.Size = New System.Drawing.Size(34, 13)
        Me.lblParts.TabIndex = 4
        Me.lblParts.Text = "Parts:"
        '
        'lblShopMaterial
        '
        Me.lblShopMaterial.AutoSize = True
        Me.lblShopMaterial.Location = New System.Drawing.Point(107, 189)
        Me.lblShopMaterial.Name = "lblShopMaterial"
        Me.lblShopMaterial.Size = New System.Drawing.Size(75, 13)
        Me.lblShopMaterial.TabIndex = 6
        Me.lblShopMaterial.Text = "Shop Material:"
        '
        'lblPST
        '
        Me.lblPST.AutoSize = True
        Me.lblPST.Location = New System.Drawing.Point(151, 221)
        Me.lblPST.Name = "lblPST"
        Me.lblPST.Size = New System.Drawing.Size(31, 13)
        Me.lblPST.TabIndex = 8
        Me.lblPST.Text = "PST:"
        '
        'lblGST
        '
        Me.lblGST.AutoSize = True
        Me.lblGST.Location = New System.Drawing.Point(150, 262)
        Me.lblGST.Name = "lblGST"
        Me.lblGST.Size = New System.Drawing.Size(32, 13)
        Me.lblGST.TabIndex = 10
        Me.lblGST.Text = "GST:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(148, 298)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "Total:"
        '
        'txtServiceDescription
        '
        Me.txtServiceDescription.Location = New System.Drawing.Point(221, 76)
        Me.txtServiceDescription.Name = "txtServiceDescription"
        Me.txtServiceDescription.Size = New System.Drawing.Size(166, 20)
        Me.txtServiceDescription.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(221, 116)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 3
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(221, 153)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(100, 20)
        Me.txtParts.TabIndex = 5
        Me.txtParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPSTOutput
        '
        Me.lblPSTOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPSTOutput.Location = New System.Drawing.Point(221, 211)
        Me.lblPSTOutput.Name = "lblPSTOutput"
        Me.lblPSTOutput.Size = New System.Drawing.Size(100, 23)
        Me.lblPSTOutput.TabIndex = 9
        Me.lblPSTOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGSTOutput
        '
        Me.lblGSTOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGSTOutput.Location = New System.Drawing.Point(221, 252)
        Me.lblGSTOutput.Name = "lblGSTOutput"
        Me.lblGSTOutput.Size = New System.Drawing.Size(100, 23)
        Me.lblGSTOutput.TabIndex = 11
        Me.lblGSTOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalOutput
        '
        Me.lblTotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalOutput.Location = New System.Drawing.Point(221, 288)
        Me.lblTotalOutput.Name = "lblTotalOutput"
        Me.lblTotalOutput.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalOutput.TabIndex = 13
        Me.lblTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShopMaterial
        '
        Me.txtShopMaterial.Location = New System.Drawing.Point(221, 182)
        Me.txtShopMaterial.Name = "txtShopMaterial"
        Me.txtShopMaterial.Size = New System.Drawing.Size(100, 20)
        Me.txtShopMaterial.TabIndex = 7
        Me.txtShopMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.ClearToolStripMenuItem, Me.SummaryToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(126, 70)
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Enabled = False
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.CalculateToolStripMenuItem.Text = "Calculate"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Enabled = False
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SummaryToolStripMenuItem.Text = "Summary"
        '
        'frmService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(440, 404)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.txtShopMaterial)
        Me.Controls.Add(Me.lblTotalOutput)
        Me.Controls.Add(Me.lblGSTOutput)
        Me.Controls.Add(Me.lblPSTOutput)
        Me.Controls.Add(Me.txtParts)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtServiceDescription)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblGST)
        Me.Controls.Add(Me.lblPST)
        Me.Controls.Add(Me.lblShopMaterial)
        Me.Controls.Add(Me.lblParts)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblServiceDescription)
        Me.Name = "frmService"
        Me.Controls.SetChildIndex(Me.lblVBAuto, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar1, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar2, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar3, 0)
        Me.Controls.SetChildIndex(Me.lblServiceDescription, 0)
        Me.Controls.SetChildIndex(Me.lblPrice, 0)
        Me.Controls.SetChildIndex(Me.lblParts, 0)
        Me.Controls.SetChildIndex(Me.lblShopMaterial, 0)
        Me.Controls.SetChildIndex(Me.lblPST, 0)
        Me.Controls.SetChildIndex(Me.lblGST, 0)
        Me.Controls.SetChildIndex(Me.lblTotal, 0)
        Me.Controls.SetChildIndex(Me.txtServiceDescription, 0)
        Me.Controls.SetChildIndex(Me.txtPrice, 0)
        Me.Controls.SetChildIndex(Me.txtParts, 0)
        Me.Controls.SetChildIndex(Me.lblPSTOutput, 0)
        Me.Controls.SetChildIndex(Me.lblGSTOutput, 0)
        Me.Controls.SetChildIndex(Me.lblTotalOutput, 0)
        Me.Controls.SetChildIndex(Me.txtShopMaterial, 0)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblServiceDescription As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblParts As System.Windows.Forms.Label
    Friend WithEvents lblShopMaterial As System.Windows.Forms.Label
    Friend WithEvents lblPST As System.Windows.Forms.Label
    Friend WithEvents lblGST As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtServiceDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtParts As System.Windows.Forms.TextBox
    Friend WithEvents lblPSTOutput As System.Windows.Forms.Label
    Friend WithEvents lblGSTOutput As System.Windows.Forms.Label
    Friend WithEvents lblTotalOutput As System.Windows.Forms.Label
    Friend WithEvents txtShopMaterial As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CalculateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
