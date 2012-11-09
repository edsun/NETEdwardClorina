<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBase
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
        Me.lblVBAuto = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblBlackBar1 = New System.Windows.Forms.Label()
        Me.lblBlackBar2 = New System.Windows.Forms.Label()
        Me.lblBlackBar3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblVBAuto
        '
        Me.lblVBAuto.AutoSize = True
        Me.lblVBAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVBAuto.Location = New System.Drawing.Point(101, 34)
        Me.lblVBAuto.Name = "lblVBAuto"
        Me.lblVBAuto.Size = New System.Drawing.Size(130, 20)
        Me.lblVBAuto.TabIndex = 0
        Me.lblVBAuto.Text = "VBAuto Centre"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(223, 217)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblBlackBar1
        '
        Me.lblBlackBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBlackBar1.Location = New System.Drawing.Point(51, 204)
        Me.lblBlackBar1.Name = "lblBlackBar1"
        Me.lblBlackBar1.Size = New System.Drawing.Size(247, 3)
        Me.lblBlackBar1.TabIndex = 2
        '
        'lblBlackBar2
        '
        Me.lblBlackBar2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBlackBar2.Location = New System.Drawing.Point(51, 220)
        Me.lblBlackBar2.Name = "lblBlackBar2"
        Me.lblBlackBar2.Size = New System.Drawing.Size(166, 3)
        Me.lblBlackBar2.TabIndex = 3
        '
        'lblBlackBar3
        '
        Me.lblBlackBar3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBlackBar3.Location = New System.Drawing.Point(51, 236)
        Me.lblBlackBar3.Name = "lblBlackBar3"
        Me.lblBlackBar3.Size = New System.Drawing.Size(166, 3)
        Me.lblBlackBar3.TabIndex = 4
        '
        'frmBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 262)
        Me.Controls.Add(Me.lblBlackBar3)
        Me.Controls.Add(Me.lblBlackBar2)
        Me.Controls.Add(Me.lblBlackBar1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblVBAuto)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBase"
        Me.Text = "VBAuto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents lblVBAuto As System.Windows.Forms.Label
    Protected WithEvents btnExit As System.Windows.Forms.Button
    Protected WithEvents lblBlackBar1 As System.Windows.Forms.Label
    Protected WithEvents lblBlackBar2 As System.Windows.Forms.Label
    Protected WithEvents lblBlackBar3 As System.Windows.Forms.Label
End Class
