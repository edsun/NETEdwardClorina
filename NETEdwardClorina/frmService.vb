Public Class frmService
    Dim mobjService As BusinessTier.clsService
#Region "Private functions"

    ''' <summary>
    ''' Checks if the value in the textbox is numeric
    ''' </summary>
    ''' <param name="strText"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function checkText(ByVal strText As String) As Boolean
        If IsNumeric(strText) Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Check if all 3 textboxes(That should contain numeric data) does contain numeric data
    ''' </summary>
    ''' <param name="txtBox"></param>
    ''' <remarks></remarks>
    Private Sub enableCalc(ByVal txtBox As TextBox)
        If txtBox.Name = "txtPrice" Then
            'Check if the txtParts textbox contains numeric data
            If checkText(txtParts.Text) Then
                'Check if the txtShopMaterial textbox contains numeric data
                If checkText(txtShopMaterial.Text) Then
                    CalculateToolStripMenuItem.Enabled = True
                Else
                    CalculateToolStripMenuItem.Enabled = False
                End If
                'txtParts contained non-numeric data
            Else
                CalculateToolStripMenuItem.Enabled = False
            End If

        ElseIf txtBox.Name = "txtPart" Then
            'Check if the txtPrice textbox contains numeric data
            If checkText(txtPrice.Text) Then
                'Check if the txtShopMaterial textbox contains numeric data
                If checkText(txtShopMaterial.Text) Then
                    CalculateToolStripMenuItem.Enabled = True
                Else
                    CalculateToolStripMenuItem.Enabled = False
                End If
                'txtPrice contained non-numeric data
            Else
                CalculateToolStripMenuItem.Enabled = False
            End If
        ElseIf txtBox.Name = "txtShopMaterial" Then
            'Check if the txtPrice textbox contains numeric data
            If checkText(txtPrice.Text) Then
                'Check if the txtParts textbox contains numeric data
                If checkText(txtParts.Text) Then
                    CalculateToolStripMenuItem.Enabled = True
                Else
                    CalculateToolStripMenuItem.Enabled = False
                End If

                'txtPrice contained non-numeric data
            Else
                CalculateToolStripMenuItem.Enabled = False
            End If
        End If
    End Sub

#End Region
#Region "textbox procedures"
    ''' <summary>
    ''' Shared event to handle textbox code
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub textLeaveChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles txtPrice.TextChanged, _
                txtPrice.Leave, _
                txtParts.TextChanged, _
                txtParts.Leave, _
                txtShopMaterial.TextChanged, _
                txtShopMaterial.Leave

        'Create a generic TextBox txtBox
        'change it to a TextBox type
        Dim txtBox As TextBox
        txtBox = CType(sender, TextBox)

        If txtBox.Text.Length > 0 Then
            If checkText(txtBox.Text) Then
                enableCalc(txtBox)
            Else
                sendMessage("Value must be numeric", "Invalid Data")
                CalculateToolStripMenuItem.Enabled = False
                txtBox.SelectAll()
                txtBox.Focus()
            End If
        Else
            CalculateToolStripMenuItem.Enabled = False
        End If

    End Sub

    ''' <summary>
    ''' Select all the text when the user enters a textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub textEntered(ByVal sender As Object, ByVal e As EventArgs) _
        Handles txtServiceDescription.Enter, _
                txtPrice.Enter, _
                txtParts.Enter, _
                txtShopMaterial.Enter
        'Create a generic TextBox txtBox and change it to a TextBox
        Dim txtBox As TextBox
        txtBox = CType(sender, TextBox)

        txtBox.SelectAll()
    End Sub
#End Region

#Region "Context menu procedures"
    ''' <summary>
    ''' Create an instance of the clsService class, passing the proper values inputted by the user.
    ''' Display the values in the labels and enable the summary form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CalculateToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CalculateToolStripMenuItem.Click
        mobjService = New BusinessTier.clsService(Decimal.Parse(txtPrice.Text), Decimal.Parse(txtParts.Text), Decimal.Parse(txtShopMaterial.Text))

        lblTotalOutput.Text = (mobjService.calcAmount).ToString("C")
        lblGSTOutput.Text = (mobjService.calcGST).ToString("C")
        lblPSTOutput.Text = (mobjService.calcPST).ToString("C")
        SummaryToolStripMenuItem.Enabled = True
    End Sub

    ''' <summary>
    ''' Display the Summary form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SummaryToolStripMenuItem.Click
        Dim frmSummaryInstance As New frmSummary
        frmSummaryInstance.ShowDialog()
    End Sub

    ''' <summary>
    ''' Clear all Textboxs and labels
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ClearToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ClearToolStripMenuItem.Click
        txtServiceDescription.Text = ""
        txtPrice.Text = ""
        txtParts.Text = ""
        txtShopMaterial.Text = ""

        lblGSTOutput.Text = ""
        lblPSTOutput.Text = ""
        lblTotalOutput.Text = ""

        CalculateToolStripMenuItem.Enabled = False
        txtServiceDescription.Focus()
    End Sub
#End Region
End Class
