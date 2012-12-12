<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFrame
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstimateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarWashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbOpen = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tssbEstimate = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssbService = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssbCarWash = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssbCommission = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssbReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbTile = New System.Windows.Forms.ToolStripButton()
        Me.tsbLayer = New System.Windows.Forms.ToolStripButton()
        Me.tsbCascade = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WindowToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstimateToolStripMenuItem, Me.ServiceToolStripMenuItem, Me.CarWashToolStripMenuItem, Me.CommissionToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'EstimateToolStripMenuItem
        '
        Me.EstimateToolStripMenuItem.Name = "EstimateToolStripMenuItem"
        Me.EstimateToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.EstimateToolStripMenuItem.Text = "&Estimate"
        '
        'ServiceToolStripMenuItem
        '
        Me.ServiceToolStripMenuItem.Name = "ServiceToolStripMenuItem"
        Me.ServiceToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ServiceToolStripMenuItem.Text = "&Service"
        '
        'CarWashToolStripMenuItem
        '
        Me.CarWashToolStripMenuItem.Name = "CarWashToolStripMenuItem"
        Me.CarWashToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.CarWashToolStripMenuItem.Text = "&Car Wash"
        '
        'CommissionToolStripMenuItem
        '
        Me.CommissionToolStripMenuItem.Name = "CommissionToolStripMenuItem"
        Me.CommissionToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.CommissionToolStripMenuItem.Text = "Co&mmission"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(100, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TileToolStripMenuItem, Me.LayerToolStripMenuItem, Me.CascadeToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "&Window"
        '
        'TileToolStripMenuItem
        '
        Me.TileToolStripMenuItem.Name = "TileToolStripMenuItem"
        Me.TileToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.TileToolStripMenuItem.Text = "&Tile"
        '
        'LayerToolStripMenuItem
        '
        Me.LayerToolStripMenuItem.Name = "LayerToolStripMenuItem"
        Me.LayerToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.LayerToolStripMenuItem.Text = "&Layer"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbOpen, Me.ToolStripSeparator1, Me.tsbTile, Me.tsbLayer, Me.tsbCascade, Me.ToolStripSeparator2, Me.tsbHelp, Me.tsbExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(284, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbOpen
        '
        Me.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbOpen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssbEstimate, Me.tssbService, Me.tssbCarWash, Me.tssbCommission, Me.tssbReports})
        Me.tsbOpen.Image = Global.NETEdwardClorina.My.Resources.Resources.open
        Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbOpen.Name = "tsbOpen"
        Me.tsbOpen.Size = New System.Drawing.Size(29, 22)
        Me.tsbOpen.Text = "File Open"
        '
        'tssbEstimate
        '
        Me.tssbEstimate.Image = Global.NETEdwardClorina.My.Resources.Resources.sales
        Me.tssbEstimate.Name = "tssbEstimate"
        Me.tssbEstimate.Size = New System.Drawing.Size(152, 22)
        Me.tssbEstimate.Text = "Estimate"
        '
        'tssbService
        '
        Me.tssbService.Image = Global.NETEdwardClorina.My.Resources.Resources.service
        Me.tssbService.Name = "tssbService"
        Me.tssbService.Size = New System.Drawing.Size(152, 22)
        Me.tssbService.Text = "Service"
        '
        'tssbCarWash
        '
        Me.tssbCarWash.Image = Global.NETEdwardClorina.My.Resources.Resources.carwash
        Me.tssbCarWash.Name = "tssbCarWash"
        Me.tssbCarWash.Size = New System.Drawing.Size(152, 22)
        Me.tssbCarWash.Text = "Car Wash"
        '
        'tssbCommission
        '
        Me.tssbCommission.Image = Global.NETEdwardClorina.My.Resources.Resources.commission
        Me.tssbCommission.Name = "tssbCommission"
        Me.tssbCommission.Size = New System.Drawing.Size(152, 22)
        Me.tssbCommission.Text = "Commission"
        '
        'tssbReports
        '
        Me.tssbReports.Image = Global.NETEdwardClorina.My.Resources.Resources.reports
        Me.tssbReports.Name = "tssbReports"
        Me.tssbReports.Size = New System.Drawing.Size(152, 22)
        Me.tssbReports.Text = "Reports"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbTile
        '
        Me.tsbTile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbTile.Image = Global.NETEdwardClorina.My.Resources.Resources.tile
        Me.tsbTile.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTile.Name = "tsbTile"
        Me.tsbTile.Size = New System.Drawing.Size(23, 22)
        Me.tsbTile.Text = "Tile"
        '
        'tsbLayer
        '
        Me.tsbLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLayer.Image = Global.NETEdwardClorina.My.Resources.Resources.layer
        Me.tsbLayer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLayer.Name = "tsbLayer"
        Me.tsbLayer.Size = New System.Drawing.Size(23, 22)
        Me.tsbLayer.Text = "Layer"
        '
        'tsbCascade
        '
        Me.tsbCascade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCascade.Image = Global.NETEdwardClorina.My.Resources.Resources.cascade
        Me.tsbCascade.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCascade.Name = "tsbCascade"
        Me.tsbCascade.Size = New System.Drawing.Size(23, 22)
        Me.tsbCascade.Text = "Cascade"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbHelp
        '
        Me.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHelp.Image = Global.NETEdwardClorina.My.Resources.Resources.help
        Me.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHelp.Name = "tsbHelp"
        Me.tsbHelp.Size = New System.Drawing.Size(23, 22)
        Me.tsbHelp.Text = "Help"
        '
        'tsbExit
        '
        Me.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbExit.Image = Global.NETEdwardClorina.My.Resources.Resources._exit
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(23, 22)
        Me.tsbExit.Text = "Exit"
        '
        'frmFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFrame"
        Me.Text = "Auto Maintenance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstimateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarWashToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommissionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbTile As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbLayer As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCascade As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbOpen As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tssbEstimate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssbService As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssbCarWash As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssbCommission As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tssbReports As System.Windows.Forms.ToolStripMenuItem

End Class
