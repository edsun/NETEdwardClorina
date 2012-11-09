<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.lblProgrammedBy = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblVBAuto
        '
        Me.lblVBAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVBAuto.Location = New System.Drawing.Point(120, 33)
        Me.lblVBAuto.Size = New System.Drawing.Size(130, 20)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(282, 220)
        '
        'lblBlackBar1
        '
        Me.lblBlackBar1.Location = New System.Drawing.Point(12, 206)
        Me.lblBlackBar1.Size = New System.Drawing.Size(345, 3)
        '
        'lblBlackBar2
        '
        Me.lblBlackBar2.Location = New System.Drawing.Point(12, 220)
        Me.lblBlackBar2.Size = New System.Drawing.Size(253, 3)
        '
        'lblBlackBar3
        '
        Me.lblBlackBar3.Location = New System.Drawing.Point(12, 233)
        Me.lblBlackBar3.Size = New System.Drawing.Size(253, 3)
        '
        'lblProgrammedBy
        '
        Me.lblProgrammedBy.AutoSize = True
        Me.lblProgrammedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgrammedBy.Location = New System.Drawing.Point(120, 78)
        Me.lblProgrammedBy.Name = "lblProgrammedBy"
        Me.lblProgrammedBy.Size = New System.Drawing.Size(135, 20)
        Me.lblProgrammedBy.TabIndex = 5
        Me.lblProgrammedBy.Text = "Programmed By"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(123, 118)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(130, 20)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Edward Clorina"
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(387, 262)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblProgrammedBy)
        Me.Name = "frmAbout"
        Me.Controls.SetChildIndex(Me.lblVBAuto, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar1, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar2, 0)
        Me.Controls.SetChildIndex(Me.lblBlackBar3, 0)
        Me.Controls.SetChildIndex(Me.lblProgrammedBy, 0)
        Me.Controls.SetChildIndex(Me.lblName, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProgrammedBy As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label

End Class
