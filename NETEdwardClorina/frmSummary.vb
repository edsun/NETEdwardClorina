Public Class frmSummary

    ''' <summary>
    ''' Once the form loads, pull the values for the Service contracts and place them into the label fields.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotServiceContractsOutput.Text = (BusinessTier.clsService.accCalcTotal).ToString("c")
        lblNoOfServiceContractsOutput.Text = (BusinessTier.clsService.noOfContracts).ToString()
        lblTotalGSTOutput.Text = (BusinessTier.clsService.accGST).ToString("c")
        lblTotalPSTOutput.Text = (BusinessTier.clsService.accPST).ToString("c")
        lblAvgServiceContractsOutput.Text = (BusinessTier.clsService.averageContract).ToString("c")
    End Sub
End Class
