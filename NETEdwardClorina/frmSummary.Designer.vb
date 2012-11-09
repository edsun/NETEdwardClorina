<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummary
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
        Me.lblTotServiceContracts = New System.Windows.Forms.Label()
        Me.lblTotServiceContractsOutput = New System.Windows.Forms.Label()
        Me.lblNoOfServiceContracts = New System.Windows.Forms.Label()
        Me.lblNoOfServiceContractsOutput = New System.Windows.Forms.Label()
        Me.lblTotalPST = New System.Windows.Forms.Label()
        Me.lblTotalPSTOutput = New System.Windows.Forms.Label()
        Me.lblTotalGST = New System.Windows.Forms.Label()
        Me.lblTotalGSTOutput = New System.Windows.Forms.Label()
        Me.lblAvgServiceContracts = New System.Windows.Forms.Label()
        Me.lblAvgServiceContractsOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblVBAuto
        '
        Me.lblVBAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVBAuto.Location = New System.Drawing.Point(136, 34)
        Me.lblVBAuto.Size = New System.Drawing.Size(130, 20)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(313, 277)
        '
        'lblBlackBar1
        '
        Me.lblBlackBar1.Location = New System.Drawing.Point(12, 266)
        Me.lblBlackBar1.Size = New System.Drawing.Size(376, 3)
        '
        'lblBlackBar2
        '
        Me.lblBlackBar2.Location = New System.Drawing.Point(12, 282)
        Me.lblBlackBar2.Size = New System.Drawing.Size(295, 3)
        '
        'lblBlackBar3
        '
        Me.lblBlackBar3.Location = New System.Drawing.Point(12, 297)
        Me.lblBlackBar3.Size = New System.Drawing.Size(295, 3)
        '
        'lblTotServiceContracts
        '
        Me.lblTotServiceContracts.AutoSize = True
        Me.lblTotServiceContracts.Location = New System.Drawing.Point(58, 76)
        Me.lblTotServiceContracts.Name = "lblTotServiceContracts"
        Me.lblTotServiceContracts.Size = New System.Drawing.Size(121, 13)
        Me.lblTotServiceContracts.TabIndex = 5
        Me.lblTotServiceContracts.Text = "Total Service Contracts:"
        '
        'lblTotServiceContractsOutput
        '
        Me.lblTotServiceContractsOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotServiceContractsOutput.Location = New System.Drawing.Point(221, 76)
        Me.lblTotServiceContractsOutput.Name = "lblTotServiceContractsOutput"
        Me.lblTotServiceContractsOutput.Size = New System.Drawing.Size(109, 13)
        Me.lblTotServiceContractsOutput.TabIndex = 6
        Me.lblTotServiceContractsOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNoOfServiceContracts
        '
        Me.lblNoOfServiceContracts.AutoSize = True
        Me.lblNoOfServiceContracts.Location = New System.Drawing.Point(33, 104)
        Me.lblNoOfServiceContracts.Name = "lblNoOfServiceContracts"
        Me.lblNoOfServiceContracts.Size = New System.Drawing.Size(146, 13)
        Me.lblNoOfServiceContracts.TabIndex = 7
        Me.lblNoOfServiceContracts.Text = "Number of Service Contracts:"
        '
        'lblNoOfServiceContractsOutput
        '
        Me.lblNoOfServiceContractsOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNoOfServiceContractsOutput.Location = New System.Drawing.Point(221, 104)
        Me.lblNoOfServiceContractsOutput.Name = "lblNoOfServiceContractsOutput"
        Me.lblNoOfServiceContractsOutput.Size = New System.Drawing.Size(109, 13)
        Me.lblNoOfServiceContractsOutput.TabIndex = 8
        Me.lblNoOfServiceContractsOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalPST
        '
        Me.lblTotalPST.AutoSize = True
        Me.lblTotalPST.Location = New System.Drawing.Point(121, 136)
        Me.lblTotalPST.Name = "lblTotalPST"
        Me.lblTotalPST.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalPST.TabIndex = 9
        Me.lblTotalPST.Text = "Total PST:"
        '
        'lblTotalPSTOutput
        '
        Me.lblTotalPSTOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPSTOutput.Location = New System.Drawing.Point(221, 135)
        Me.lblTotalPSTOutput.Name = "lblTotalPSTOutput"
        Me.lblTotalPSTOutput.Size = New System.Drawing.Size(109, 13)
        Me.lblTotalPSTOutput.TabIndex = 10
        Me.lblTotalPSTOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalGST
        '
        Me.lblTotalGST.AutoSize = True
        Me.lblTotalGST.Location = New System.Drawing.Point(120, 165)
        Me.lblTotalGST.Name = "lblTotalGST"
        Me.lblTotalGST.Size = New System.Drawing.Size(59, 13)
        Me.lblTotalGST.TabIndex = 11
        Me.lblTotalGST.Text = "Total GST:"
        '
        'lblTotalGSTOutput
        '
        Me.lblTotalGSTOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalGSTOutput.Location = New System.Drawing.Point(221, 165)
        Me.lblTotalGSTOutput.Name = "lblTotalGSTOutput"
        Me.lblTotalGSTOutput.Size = New System.Drawing.Size(109, 13)
        Me.lblTotalGSTOutput.TabIndex = 12
        Me.lblTotalGSTOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAvgServiceContracts
        '
        Me.lblAvgServiceContracts.AutoSize = True
        Me.lblAvgServiceContracts.Location = New System.Drawing.Point(42, 196)
        Me.lblAvgServiceContracts.Name = "lblAvgServiceContracts"
        Me.lblAvgServiceContracts.Size = New System.Drawing.Size(137, 13)
        Me.lblAvgServiceContracts.TabIndex = 13
        Me.lblAvgServiceContracts.Text = "Average Service Contracts:"
        '
        'lblAvgServiceContractsOutput
        '
        Me.lblAvgServiceContractsOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAvgServiceContractsOutput.Location = New System.Drawing.Point(221, 196)
        Me.lblAvgServiceContractsOutput.Name = "lblAvgServiceContractsOutput"
        Me.lblAvgServiceContractsOutput.Size = New System.Drawing.Size(109, 13)
        Me.lblAvgServiceContractsOutput.TabIndex = 14
        Me.lblAvgServiceContractsOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(424, 319)
        Me.Controls.Add(Me.lblAvgServiceContractsOutput)
        Me.Controls.Add(Me.lblAvgServiceContracts)
        Me.Controls.Add(Me.lblTotalGSTOutput)
        Me.Controls.Add(Me.lblTotalGST)
        Me.Controls.Add(Me.lblTotalPSTOutput)
        Me.Controls.Add(Me.lblTotalPST)
        Me.Controls.Add(Me.lblNoOfServiceContractsOutput)
        Me.Controls.Add(Me.lblNoOfServiceContracts)
        Me.Controls.Add(Me.lblTotServiceContractsOutput)
        Me.Controls.Add(Me.lblTotServiceContracts)
        Me.Name = "frmSummary"
        Me.Controls.SetChildIndex(Me.lblVBAuto, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar1, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar2, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar3, 0)
        Me.Controls.SetChildIndex(Me.lblTotServiceContracts, 0)
        Me.Controls.SetChildIndex(Me.lblTotServiceContractsOutput, 0)
        Me.Controls.SetChildIndex(Me.lblNoOfServiceContracts, 0)
        Me.Controls.SetChildIndex(Me.lblNoOfServiceContractsOutput, 0)
        Me.Controls.SetChildIndex(Me.lblTotalPST, 0)
        Me.Controls.SetChildIndex(Me.lblTotalPSTOutput, 0)
        Me.Controls.SetChildIndex(Me.lblTotalGST, 0)
        Me.Controls.SetChildIndex(Me.lblTotalGSTOutput, 0)
        Me.Controls.SetChildIndex(Me.lblAvgServiceContracts, 0)
        Me.Controls.SetChildIndex(Me.lblAvgServiceContractsOutput, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotServiceContracts As System.Windows.Forms.Label
    Friend WithEvents lblTotServiceContractsOutput As System.Windows.Forms.Label
    Friend WithEvents lblNoOfServiceContracts As System.Windows.Forms.Label
    Friend WithEvents lblNoOfServiceContractsOutput As System.Windows.Forms.Label
    Friend WithEvents lblTotalPST As System.Windows.Forms.Label
    Friend WithEvents lblTotalPSTOutput As System.Windows.Forms.Label
    Friend WithEvents lblTotalGST As System.Windows.Forms.Label
    Friend WithEvents lblTotalGSTOutput As System.Windows.Forms.Label
    Friend WithEvents lblAvgServiceContracts As System.Windows.Forms.Label
    Friend WithEvents lblAvgServiceContractsOutput As System.Windows.Forms.Label

End Class
