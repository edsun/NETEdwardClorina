Public Class frmReport

    ''' <summary>
    ''' Connect to our database, fill a dataset with our commissions and display it.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Create an instance of our clsData class
        Dim objData As New DataTier.clsData

        'Connect to the database
        objData.connect()

        'Create our datasets
        Dim dsCommission As New DataSet

        dsCommission = objData.getCommission
        Dim crRpt As New DataTier.crReport 'The report you created.

        Try
            crRpt.SetDataSource(dsCommission)
            crvViewer.ReportSource = crRpt

        Catch Ex As Exception
            MessageBox.Show(Ex.Message, "Error")
        End Try
    End Sub
End Class
