<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommission
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
        Me.dgvCommissions = New System.Windows.Forms.DataGridView()
        CType(Me.dgvCommissions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVBAuto
        '
        Me.lblVBAuto.Location = New System.Drawing.Point(252, 26)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(480, 421)
        '
        'lblBlackBar1
        '
        Me.lblBlackBar1.Location = New System.Drawing.Point(16, 409)
        Me.lblBlackBar1.Size = New System.Drawing.Size(539, 3)
        '
        'lblBlackBar2
        '
        Me.lblBlackBar2.Location = New System.Drawing.Point(16, 425)
        Me.lblBlackBar2.Size = New System.Drawing.Size(458, 3)
        '
        'lblBlackBar3
        '
        Me.lblBlackBar3.Location = New System.Drawing.Point(16, 441)
        Me.lblBlackBar3.Size = New System.Drawing.Size(458, 3)
        '
        'dgvCommissions
        '
        Me.dgvCommissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCommissions.Location = New System.Drawing.Point(19, 60)
        Me.dgvCommissions.Name = "dgvCommissions"
        Me.dgvCommissions.ReadOnly = True
        Me.dgvCommissions.Size = New System.Drawing.Size(599, 332)
        Me.dgvCommissions.TabIndex = 5
        '
        'frmCommission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(642, 470)
        Me.Controls.Add(Me.dgvCommissions)
        Me.Name = "frmCommission"
        Me.Text = "Commission Listing"
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar2, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar3, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar1, 0)
        Me.Controls.SetChildIndex(Me.lblVBAuto, 0)
        Me.Controls.SetChildIndex(Me.dgvCommissions, 0)
        CType(Me.dgvCommissions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCommissions As System.Windows.Forms.DataGridView

End Class
