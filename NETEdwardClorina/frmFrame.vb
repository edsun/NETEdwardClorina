Public Class frmFrame

    Private Sub tsbOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbOpen.Click

    End Sub

    ''' <summary>
    ''' Tile all open forms horizontally
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tsbTile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles tsbTile.Click, _
                TileToolStripMenuItem.Click
        'Set the Mdi Layout to tile all open windows horizontally
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    ''' <summary>
    ''' Tile all open forms vertically
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tsbLayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles tsbLayer.Click, _
                LayerToolStripMenuItem.Click
        'Set the Mdi Layout to tile all open windows vertically
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    ''' <summary>
    ''' Cascade all open forms
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tsbCascade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles tsbCascade.Click, _
                CascadeToolStripMenuItem.Click
        'Set the Mdi Layout to cascade all open windows
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    ''' <summary>
    ''' Close the Frame
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tsbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles tsbExit.Click, _
                ExitToolStripMenuItem.Click
        'Close the frame
        Me.Close()

    End Sub

    ''' <summary>
    ''' Open the estimates form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub EstimateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles tssbEstimate.Click, _
                EstimateToolStripMenuItem.Click

        'create an instance of frmEstimate called frmInstance
        Dim frmInstance As New frmEstimate
        'frmInstance will behave as a child form in frmFrame
        frmInstance.MdiParent = Me
        'display the form
        frmInstance.Show()

    End Sub

    ''' <summary>
    ''' Open the Service form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tssbService_Click(sender As Object, e As EventArgs) _
        Handles tssbService.Click, _
                ServiceToolStripMenuItem.Click
        'create an instance of frmEstimate called frmInstance
        Dim frmInstance As New frmService
        'frmInstance will behave as a child form in frmFrame
        frmInstance.MdiParent = Me
        'display the form
        frmInstance.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles tsbHelp.Click, _
                AboutToolStripMenuItem.Click
        'create an instance of frmEstimate called frmInstance
        Dim frmInstance As New frmAbout
        'display the form
        frmInstance.ShowDialog()
    End Sub

    Private Sub CarWashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles CarWashToolStripMenuItem.Click, _
                tssbCarWash.Click
        'create an instance of frmEstimate called frmInstance
        Dim frmInstance As New frmCarWash
        'frmInstance will behave as a child form in frmFrame
        frmInstance.MdiParent = Me
        'display the form
        frmInstance.Show()
    End Sub

    Private Sub CommissionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles CommissionToolStripMenuItem.Click, _
                tssbCommission.Click
        'create an instance of frmVBAuto called frmInstance
        Dim frmInstance As New frmVBAuto
        'frmInstance will behave as a child form in frmFrame
        frmInstance.MdiParent = Me
        'display the form
        frmInstance.Show()

    End Sub
End Class
