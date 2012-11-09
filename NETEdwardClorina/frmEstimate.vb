'variables must be declared before using
Option Explicit On
'variables must be explicitly casted
'if option strict is on, option explicit is automatically on
Option Strict On

Public Class frmEstimate
    'set to true in unit test to suppress the messagebox
    'default false in windows app causes msgbox to display
    Protected mblnTest As Boolean
    'used in unit test to manipulate user respone to msgbox
    Protected mdlgResult As DialogResult
    'used in unit test to represent text in msgbox
    Protected mstrTestString As String

    ''' <summary>
    ''' Used to suppress message boxs during testing.
    ''' </summary>
    ''' <param name="text"></param>
    ''' <param name="caption"></param>
    ''' <param name="buttons"></param>
    ''' <param name="icon"></param>
    ''' <param name="defaultButton"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function sendMessage(ByVal text As String, _
                                   ByVal caption As String, _
                                   Optional ByVal buttons As MessageBoxButtons = MessageBoxButtons.OK, _
                                   Optional ByVal icon As MessageBoxIcon = MessageBoxIcon.Information, _
                                   Optional ByVal defaultButton As MessageBoxDefaultButton = _
                                   MessageBoxDefaultButton.Button1) As DialogResult

        'Check if we are unit testing
        If mblnTest = True Then
            'unit testing
            mstrTestString = text
            Return mdlgResult
        Else 'We're not unit testing, so display the messagebox.
            Return MessageBox.Show(text, caption, buttons, icon, defaultButton)
        End If
    End Function
#Region "Private Sub Procedures"
    ''' <summary>
    ''' Enable/Disable the Accept Quote context menu item based on the passed parameter.
    ''' </summary>
    ''' <param name="accept_quote"></param>
    ''' <remarks></remarks>
    Private Sub quote(ByVal accept_quote As Boolean)
        AcceptQuoteToolStripMenuItem.Enabled = accept_quote
    End Sub
    ''' <summary>
    ''' Enable/Disable the Clear And Calculate context menu item based on the passed parameter.
    ''' </summary>
    ''' <param name="enable"></param>
    ''' <remarks></remarks>
    Private Sub clear(enable As Boolean)
        ClearToolStripMenuItem.Enabled = enable
        CalculateToolStripMenuItem.Enabled = enable
    End Sub

    ''' <summary>
    ''' Calculate the monthly payment using the built-in function "PMT"
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub calculate()
        lblMonthlyPaymentOutput.Text = Math.Abs(Pmt((hsbInterestRate.Value / 10000) / 12, _
                                           hsbYears.Value * 12, _
                                           mdecAmountDue, 0, DueDate.EndOfPeriod)).ToString("C")
    End Sub

    ''' <summary>
    ''' Enable/Disable the Finance groupbox based on the value of the passed parameter,
    ''' Also determine if any finance calculations have taken place.
    ''' </summary>
    ''' <param name="enable"></param>
    ''' <remarks></remarks>
    Private Sub enableFinance(enable As Boolean)
        grpFinance.Enabled = enable
        If (enable) Then
            If (CalculateToolStripMenuItem.Enabled) Then
                hsbYears.Value = 3
                hsbInterestRate.Value = 500
                calculate()
            End If
        End If
    End Sub
#End Region

#Region "Module level variables"
    'Holds our module level decimal variables used to store our values
    Dim mdecTotPrice As Decimal
    Dim mdecSalePrice As Decimal
    Dim mdecAmountDue As Decimal
    Dim mdecTradeIn As Decimal
    Dim mdecFinish As Decimal
    Dim mdecAccessories As Decimal
    Dim mdecStereo As Decimal
    Dim mdecLeather As Decimal
    Dim mdecCompNav As Decimal
    Dim mdecAverage As Decimal
    Dim mdecTotalAmountDue As Decimal
    Dim mintNoOfQuotes As Integer

    'Constant module level variables
    'Holds our values for 
    'Accessories & Finish
    Const mdecSTEREO_SYSTEM As Decimal = 505.05D
    Const mdecLEATHER_INTERIOR As Decimal = 1010.1D
    Const mdecCOMPUTER_NAVIGATION As Decimal = 1515.15D

    Const mdecSTANDARD As Decimal = 0D
    Const mdecPEARLIZED As Decimal = 404.04D
    Const mdecCUSTOMIZED_DETAIL As Decimal = 606.06D

    Const mdecTAX_RATE As Decimal = 0.12D

#End Region

#Region "Radio button procedures"
    ''' <summary>
    ''' Check which radio button is currently checked off
    ''' Will adjust the current mdecFinish value
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub radChanged_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles radStandard.CheckedChanged, _
                radPearlized.CheckedChanged, _
                radCustomDetail.CheckedChanged

        Dim radButton As RadioButton
        radButton = CType(sender, RadioButton)

        'Check which radiobutton is checked off
        'By Default Standard is checked off
        'Set the mdecFinish variable to the correct value, depending on what is checked
        If radButton.Name = "radCustomDetail" Then
            mdecFinish = mdecCUSTOMIZED_DETAIL
        ElseIf radButton.Name = "radPearlized" Then
            mdecFinish = mdecPEARLIZED
        Else
            mdecFinish = mdecSTANDARD
        End If

    End Sub

#End Region

#Region "Checkbox procedures"
    ''' <summary>
    ''' Shared event for all checkboxes.
    ''' Changes the module level variable appropriately
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chkChanged_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles chkStereo.CheckedChanged, _
                chkLeather.CheckedChanged, _
                chkCompNav.CheckedChanged

        'Create the Generic chkBox and convert it to a CheckBox
        Dim chkBox As CheckBox
        chkBox = CType(sender, CheckBox)

        'Check if the chkBox is chkStereo
        If chkBox.Name = "chkStereo" Then
            'Check if the chkBox is checked off
            If chkBox.Checked = True Then
                mdecStereo = mdecSTEREO_SYSTEM
            Else
                mdecStereo = 0
            End If

        End If

        'Check if the chkBox is chkLeather
        If chkBox.Name = "chkLeather" Then
            'Check if the chkBox is checked off
            If chkBox.Checked = True Then
                mdecLeather = mdecLEATHER_INTERIOR
            Else
                mdecLeather = 0
            End If
        End If

        'Check if the chkBox is chkCompNav
        If chkBox.Name = "chkCompNav" Then
            'Check if the chkBox is checked off
            If chkBox.Checked = True Then
                mdecCompNav = mdecCOMPUTER_NAVIGATION
            Else
                mdecCompNav = 0
            End If
        End If

    End Sub
#End Region

#Region "textbox procedures"
    ''' <summary>
    ''' Select all the text when the user enters the textbox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtSelectAll_Enter(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtCustomerName.Enter, _
                txtSalePrice.Enter, _
                txtTradeIn.Enter
        'Create a generic TextBox txtBox
        'change it to a TextBox type
        Dim txtBox As TextBox
        txtBox = CType(sender, TextBox)

        'Select all the text in the text box
        txtBox.SelectAll()
    End Sub

    ''' <summary>
    ''' Evaluate the text in the textbox after changing the textbox contents
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtChangedOrLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtSalePrice.TextChanged, _
                txtTradeIn.TextChanged, _
                txtSalePrice.Leave, _
                txtTradeIn.Leave
        'Create a generic TextBox txtBox
        'Change it to a textBox type
        Dim txtBox As TextBox
        txtBox = CType(sender, TextBox)

        'Check if the txtBox is not empty
        If txtBox.Text.Length > 0 Then

            'Check if the data is numeric
            If IsNumeric(txtBox.Text) Then
                If txtBox.Name = "txtSalePrice" Then
                    mdecSalePrice = CType(txtBox.Text, Decimal)
                    If txtTradeIn.Text.Length > 0 Then
                        If IsNumeric(txtTradeIn.Text) Then
                            clear(True)
                            mdecTradeIn = CType(txtTradeIn.Text, Decimal)
                        End If
                    End If
                ElseIf txtBox.Name = "txtTradeIn" Then
                    mdecTradeIn = CType(txtBox.Text, Decimal)
                    If txtSalePrice.Text.Length > 0 Then
                        If IsNumeric(txtSalePrice.Text) Then
                            clear(True)
                            mdecSalePrice = CType(txtSalePrice.Text, Decimal)
                        End If
                    End If
                End If

            Else 'Data was non-numeric
                sendMessage("Data must be numeric", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtBox.Focus()
                txtBox.SelectAll()
                clear(False)
                enableFinance(False)
            End If

        Else 'txtBox was empty
            txtBox.Text = CType(0, String)
            clear(False)
            enableFinance(False)
        End If

    End Sub
#End Region

#Region "Context menu procedures"
    ''' <summary>
    ''' Calculate the totals for the current estimate.
    ''' Using the approriate label, display out calculated results.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CalculateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateToolStripMenuItem.Click

        'Calculate our totals
        mdecAccessories = mdecCompNav + mdecLeather + mdecStereo
        mdecTotPrice = ((mdecAccessories + mdecSalePrice + mdecFinish) * mdecTAX_RATE)
        mdecTotPrice += mdecAccessories + mdecSalePrice + mdecFinish
        mdecAmountDue = mdecTotPrice - mdecTradeIn

        'Display our value
        lblAccessoriesOutput.Text = FormatCurrency(mdecAccessories + mdecFinish)
        lblSubtotalOutput.Text = FormatCurrency(mdecAccessories + mdecSalePrice + mdecFinish)
        lblSalesTaxOutput.Text = FormatCurrency(((mdecAccessories + mdecSalePrice + mdecFinish) * mdecTAX_RATE))
        lblTotalOutput.Text = FormatCurrency(mdecTotPrice)
        lblAmountDueOutput.Text = FormatCurrency(mdecAmountDue)
        txtSalePrice.Text = FormatCurrency(mdecSalePrice)
        txtTradeIn.Text = FormatCurrency(mdecTradeIn)

        'Give focus to our SalePrice textBox and select it all
        txtSalePrice.Focus()
        txtSalePrice.SelectAll()

        'Enable the Accept quote, clear, and grpFinance
        quote(True)
        clear(True)
        enableFinance(True)
        'Call the calculate procedure to calculate the monthly payments
        calculate()

    End Sub

    ''' <summary>
    ''' Clears out all labels and textfields
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        'Clear all the labels
        lblAccessoriesOutput.Text = ""
        lblAmountDueOutput.Text = ""
        lblSalesTaxOutput.Text = ""
        lblAmountDueOutput.Text = ""
        lblSubtotalOutput.Text = ""
        lblTotalOutput.Text = ""

        'Clear all the text boxs
        txtCustomerName.Text = ""
        txtSalePrice.Text = "0"
        txtTradeIn.Text = "0"

        'Uncheck all the checkboxs and reselect the Standard option
        chkCompNav.Checked = False
        chkLeather.Checked = False
        chkStereo.Checked = False
        radStandard.Checked = True

        'Set focus to the Customer Name textbox
        txtCustomerName.Focus()
        'Disable the calculate, accept quote, grpFinance items
        clear(False)
        quote(False)
        enableFinance(False)
    End Sub

    ''' <summary>
    ''' Accumulates data pertaining to the Amount Due and Number of Quotes for summary purposes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AcceptQuoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcceptQuoteToolStripMenuItem.Click
        mdecTotalAmountDue += mdecAmountDue
        mintNoOfQuotes += 1
        quote(False)
        SummaryToolStripMenuItem.Enabled = True
    End Sub

    ''' <summary>
    ''' Displays the summary of accepted quotes for the current session.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SummaryToolStripMenuItem.Click
        mdecAverage = mdecTotalAmountDue / mintNoOfQuotes
        Dim quote As String = "Total Estimates: " & FormatCurrency(mdecTotalAmountDue) & ControlChars.NewLine & _
                               "Number of Estimates: " & mintNoOfQuotes & ControlChars.NewLine & _
                               "Average: " & FormatCurrency(mdecAverage)
        sendMessage(quote, "Summary of Accepted Quotes", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#End Region

#Region "grpFinance"
    ''' <summary>
    ''' Shared event procedure to handle value changes in HScrollBars
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub hsbYearsInterestRate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
        hsbYears.ValueChanged, _
        hsbInterestRate.ValueChanged

        'Create a generic HScrollBar hsbScroll
        'Change it to a textBox type
        Dim hsbScroll As HScrollBar
        hsbScroll = CType(sender, HScrollBar)

        If (hsbScroll.Name = "hsbInterestRate") Then
            lblInterestRateOutput.Text = (hsbInterestRate.Value / 10000).ToString("P")
        Else
            lblNoOfYearsOutput.Text = hsbYears.Value.ToString()
        End If

        calculate()
    End Sub

#End Region
End Class