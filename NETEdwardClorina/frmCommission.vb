Public Class frmCommission

    Private Sub frmCommission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Declare an object of:
        'clsData Type
        Dim objData As New DataTier.clsData
        'DataSet Type
        Dim dsCommission As New DataSet

        Try
            'connect to our database
            objData.connect()

            'Grab our commssions
            dsCommission = objData.getCommission

            'Bind our dataset to the DataSource property of our DataGrid
            dgvCommissions.DataSource = dsCommission.Tables("Commissions")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
