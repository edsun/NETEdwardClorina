Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports NETEdwardClorina



'''<summary>
'''This is a test class for frmEstimateTest and is intended
'''to contain all frmEstimateTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmEstimateTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '

    Dim target As frmEstimate_Accessor = New frmEstimate_Accessor()
    'Use TestInitialize to run code before running each test
    <TestInitialize()> _
    Public Sub MyTestInitialize()
        target.mblnTest = True
    End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region

#Region "Radio button tests"
    '''<summary>
    '''A test for radChanged_CheckedChanged
    ''' Checks for the Pearlized Radio Button to be checked
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub radChangedPearlized_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.radPearlized ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = 404.04D
        Dim actual As Decimal

        'set the radio button that is checked to pearlized
        target.radPearlized.Checked = True

        target.radChanged_CheckedChanged(sender, e)

        actual = target.mdecFinish

        Assert.AreEqual(expected, actual, "Data incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for radChanged_CheckedChanged
    ''' Checks to see if the Standard radio button is checked
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub radChangedStandard_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.radStandard ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = 0
        Dim actual As Decimal

        'set the radio button that is checked to Standard
        target.radStandard.Checked = True

        target.radChanged_CheckedChanged(sender, e)

        actual = target.mdecFinish

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for radChanged_CheckedChanged
    ''' Checks to see if the Custom Detail radio button is checked
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub radChangedCustomDetail_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.radCustomDetail ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = 606.06D
        Dim actual As Decimal

        'set the radio button that is checked to Custom Detail
        target.radCustomDetail.Checked = True

        target.radChanged_CheckedChanged(sender, e)

        actual = target.mdecFinish

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
#End Region

#Region "Checkbox tests"
    '''<summary>
    '''A test for chkChanged_CheckedChanged
    '''Checks to see if no check boxes are checked
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub chkChangedNone_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.chkStereo ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = 0D
        Dim actual As Decimal

        'setup the test
        target.chkChanged_CheckedChanged(sender, e)
        actual = target.mdecAccessories

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for chkChanged_CheckedChanged
    '''Checks to see if the Stereo System checkbox is checked
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub chkChangedStereo_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.chkStereo ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = 505.05D
        Dim actual As Decimal

        'setup the test
        target.chkStereo.Checked = True
        target.chkChanged_CheckedChanged(sender, e)

        actual = target.mdecStereo

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for chkChanged_CheckedChanged
    '''Checks to see if the Leather Interior checkbox is checked
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub chkChangedLeather_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.chkLeather ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = 1010.1D
        Dim actual As Decimal

        'setup the test
        target.chkLeather.Checked = True

        target.chkChanged_CheckedChanged(sender, e)

        actual = target.mdecLeather

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for chkChanged_CheckedChanged
    '''Checks to see if the Computer Navigation checkbox is checked
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub chkChangedCompNav_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.chkCompNav ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = 1515.15D
        Dim actual As Decimal

        'setup the test
        target.chkCompNav.Checked = True

        target.chkChanged_CheckedChanged(sender, e)

        actual = target.mdecCompNav

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for chkChanged_CheckedChanged
    '''Checks to see if all Checkboxes are checked
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub chkChangedAll_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.chkStereo ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = 3030.3D
        Dim actual As Decimal

        'setup the test
        target.chkCompNav.Checked = True
        target.chkLeather.Checked = True
        target.chkStereo.Checked = True

        target.chkChanged_CheckedChanged(sender, e)

        actual = (target.mdecStereo + target.mdecLeather + target.mdecCompNav)

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for chkChanged_CheckedChanged
    '''Checks to see if Stereo and Leather Checkboxs are checked
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub chkChangedStereoLeather_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.chkLeather ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = 1515.15D
        Dim actual As Decimal

        'setup the test
        target.chkStereo.Checked = True
        target.chkLeather.Checked = True

        target.chkChanged_CheckedChanged(sender, e)

        actual = target.mdecStereo + target.mdecLeather

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for chkChanged_CheckedChanged
    '''Checks to see if Stereo and Comp Nav checkboxes are checked
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub chkChangedStereoCompNav_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.chkStereo ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = 2020.2D
        Dim actual As Decimal

        'setup the test
        target.chkStereo.Checked = True
        target.chkCompNav.Checked = True

        target.chkChanged_CheckedChanged(sender, e)

        actual = target.mdecStereo + target.mdecCompNav

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for chkChanged_CheckedChanged
    '''Checks to see if Leather and Comp Nav are Checked 
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub chkChangedLeatherCompNav_CheckedChangedTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.chkStereo ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = 2525.25D
        Dim actual As Decimal

        'setup the test
        target.chkLeather.Checked = True
        target.chkCompNav.Checked = True

        target.chkChanged_CheckedChanged(sender, e)

        actual = target.mdecLeather + target.mdecCompNav

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
#End Region

#Region "Textbox tests"
    '''<summary>
    '''A test for txtSelectAll_Enter
    '''Checks to see if all the text in the txtCustomerName textBox was selected.
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub txtSelectAllCustomerName_EnterTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.txtCustomerName ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As String = "Edward"
        Dim actual As String

        'setup
        target.txtCustomerName.Text = "Edward"

        target.txtSelectAll_Enter(sender, e)

        actual = target.txtCustomerName.SelectedText

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtSelectAll_Enter
    '''Checks if all the text in txtSalePrice was selected
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub txtSelectAllSalePrice_EnterTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.txtSalePrice ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = 5000D
        Dim actual As Decimal

        'setup
        target.txtSalePrice.Text = CType(5000, String)

        target.txtSelectAll_Enter(sender, e)

        actual = CDec(target.txtSalePrice.SelectedText)

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtSelectAll_Enter
    '''Checks if all the text in txtTradeIn was selected
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub txtSelectAllTradeIn_EnterTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.txtTradeIn ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = 5000D
        Dim actual As Decimal

        'setup
        target.txtTradeIn.Text = CType(5000, String)

        target.txtSelectAll_Enter(sender, e)

        actual = CDec(target.txtTradeIn.SelectedText)

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtChangedLeave_LeaveOrTextChanged
    '''Checks the Sale Price textbox for non-numeric value, which will result in btnCalculate being Disabled (False)
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub txtChangedOrLeaveSalePrice_NonNumericTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.txtSalePrice ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As String = "non-numeric value"
        Dim actual As String
        Dim expectedEnabled As Boolean = False
        Dim actualEnabled As Boolean


        'setup
        target.mblnTest = True 'Disable popups
        target.txtSalePrice.Text = "non-numeric value"

        target.txtChangedOrLeave(sender, e)

        actual = target.txtSalePrice.Text
        actualEnabled = target.CalculateToolStripMenuItem.Enabled

        Assert.AreEqual(expectedEnabled, actualEnabled, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtChangedLeave_LeaveOrTextChanged
    '''Checks the Trade In textbox for non-numeric value, which will result in btnCalculate being Disabled (False)
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub txtChangedOrLeaveTradeIn_NonNumericTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.txtTradeIn ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As String = "non-numeric value"
        Dim actual As String
        Dim expectedEnabled As Boolean = False
        Dim actualEnabled As Boolean


        'setup
        target.mblnTest = True 'Disable popups
        target.txtSalePrice.Text = "non-numeric value"

        target.txtChangedOrLeave(sender, e)

        actual = target.txtTradeIn.Text
        actualEnabled = target.CalculateToolStripMenuItem.Enabled

        Assert.AreEqual(expectedEnabled, actualEnabled, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtChangedLeave_LeaveOrTextChanged
    '''Checks the Sale Price and Trade in textbox for a numeric value, 
    ''' which will result in btnCalculate being Enabled(True)
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub txtChangedOrLeave_NumericTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.txtSalePrice ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expectedEnabled As Boolean = True
        Dim actualEnabled As Boolean

        'setup
        target.mblnTest = True 'Disable popups
        target.txtTradeIn.Text = CType(5000, String)
        target.txtSalePrice.Text = CType(5000, String)

        target.txtChangedOrLeave(sender, e)

        actualEnabled = target.CalculateToolStripMenuItem.Enabled

        Assert.AreEqual(expectedEnabled, actualEnabled, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for txtChangedLeave_LeaveOrTextChanged
    '''Checks the Sale Price and Trade in textbox for a numeric value and an empty textbox,
    '''Which will result in the btnCalculate button being Disabled (False)
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub txtChangedOrLeave_NumericEmptyTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.txtSalePrice ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expectedEnabled As Boolean = False
        Dim actualEnabled As Boolean

        'setup
        target.mblnTest = True 'Disable popups
        target.txtTradeIn.Text = CType(5000, String)
        target.txtSalePrice.Text = ""

        target.txtChangedOrLeave(sender, e)

        actualEnabled = target.CalculateToolStripMenuItem.Enabled

        Assert.AreEqual(expectedEnabled, actualEnabled, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
#End Region

#Region "Button tests"
    '''<summary>
    '''A test for the Calculate context menu item
    '''Checks for proper calculation if all values are entered.
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub btnCalculate_AllTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.CalculateToolStripMenuItem ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = 4183.84D
        Dim actual As Decimal

        'setup
        target.txtSalePrice.Text = CType(5000, String)
        target.txtTradeIn.Text = CType(3000, String)
        target.chkLeather.Checked = True
        target.radPearlized.Checked = True


        target.CalculateToolStripMenuItem_Click(sender, e)

        actual = CType(target.lblAmountDueOutput.Text, Decimal)

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for the Calculate context menu item
    '''Checks for proper calculation if all values with no trade in are entered.
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub btnCalculate_NoTradeInTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.CalculateToolStripMenuItem ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = 7183.84D
        Dim actual As Decimal

        'setup
        target.txtSalePrice.Text = CType(5000, String)
        target.txtTradeIn.Text = ""
        target.chkLeather.Checked = True
        target.radPearlized.Checked = True


        target.CalculateToolStripMenuItem_Click(sender, e)

        actual = CType(target.lblAmountDueOutput.Text, Decimal)

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for the Calculate context menu item
    '''Checks for proper calculation if all values with no accessories are selected.
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub btnCalculate_NoAccessoriesTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.CalculateToolStripMenuItem ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = 3052.52D
        Dim actual As Decimal

        'setup
        target.txtSalePrice.Text = CType(5000, String)
        target.txtTradeIn.Text = CType(3000, String)
        target.radPearlized.Checked = True


        target.CalculateToolStripMenuItem_Click(sender, e)

        actual = CType(target.lblAmountDueOutput.Text, Decimal)

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for the Calculate context menu item
    '''Checks for proper calculation if all values with a greater trade in value than total cost.
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub btnCalculate_HigherTradeInTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.CalculateToolStripMenuItem ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = -816.16D
        Dim actual As Decimal

        'setup
        target.txtSalePrice.Text = CType(5000, String)
        target.txtTradeIn.Text = CType(8000, String)
        target.chkLeather.Checked = True
        target.radPearlized.Checked = True


        target.CalculateToolStripMenuItem_Click(sender, e)

        actual = CType(target.lblAmountDueOutput.Text, Decimal)

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for the Calculate context menu item
    '''Checks for proper calculation if the there are multiple calculations
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub btnCalculate_MultipleTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = target.CalculateToolStripMenuItem ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Decimal = 4183.84D
        Dim actual As Decimal

        'setup
        target.txtSalePrice.Text = CType(5000, String)
        target.txtTradeIn.Text = CType(3000, String)
        target.chkLeather.Checked = True
        target.radPearlized.Checked = True


        target.CalculateToolStripMenuItem_Click(sender, e)

        actual = CType(target.lblAmountDueOutput.Text, Decimal)

        target.CalculateToolStripMenuItem_Click(sender, e)

        actual = CType(target.lblAmountDueOutput.Text, Decimal)

        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for the Clear context menu item
    '''Concatenate all text in the textboxs and make sure they are empty
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub btnClear_ClickTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As String = "00"
        Dim actual As String

        target.ClearToolStripMenuItem_Click(sender, e)

        actual = target.txtCustomerName.Text & _
            target.txtSalePrice.Text & _
            target.txtTradeIn.Text & _
            target.lblAccessoriesOutput.Text & _
            target.lblAmountDueOutput.Text & _
            target.lblSalesTaxOutput.Text & _
            target.lblSubtotalOutput.Text & _
            target.lblTotalOutput.Text
        Assert.AreEqual(expected, actual, "Data Incorrect")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
#End Region

#Region "Quote Sub procedure tests"
    ''' <summary>
    ''' A test for Private Sub Procedure Quote, to see if proper boolean value is set when passed value is True
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), _
    DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub quoteEnabledTrue_Test()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Boolean = True
        Dim actual As Boolean

        'setup
        target.quote(True)

        actual = target.AcceptQuoteToolStripMenuItem.Enabled

        Assert.AreEqual(expected, actual, "Accept Quote button not properly set.")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
    ''' <summary>
    ''' A test for Private Sub Procedure Quote, to see if proper boolean value is set when passed value is False
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), _
   DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub quoteEnabledFalse_Test()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Boolean = False
        Dim actual As Boolean

        'setup
        target.quote(False)

        actual = target.AcceptQuoteToolStripMenuItem.Enabled

        Assert.AreEqual(expected, actual, "Accept Quote button not properly set.")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
#End Region

#Region "Clear sub procedure tests"
    ''' <summary>
    ''' A Test for Private Sub Procedure clear, to see if proper boolean value is set when passed value is True
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), _
   DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub clearEnabledTrue_Test()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Boolean = True
        Dim actual As Boolean

        'setup
        target.clear(True)

        actual = target.ClearToolStripMenuItem.Enabled

        Assert.AreEqual(expected, actual, "Clear button not properly set.")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    ''' <summary>
    ''' A Test for Private Sub Procedure clear, to see if proper boolean value is set when passed value is False
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), _
   DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub clearEnabledFalse_Test()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected As Boolean = False
        Dim actual As Boolean

        'setup
        target.clear(False)

        actual = target.ClearToolStripMenuItem.Enabled

        Assert.AreEqual(expected, actual, "Clear button not properly set.")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

#End Region

#Region "Calculate sub procedure tests"
    '''<summary>
    '''A test for calculate to test for proper calculation when rate is maximum.
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub calculateTest_rateMax()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value

        Dim expected As String = "$355.61"
        Dim actual As String

        'setup
        target.mdecTotPrice = 8993.936D
        target.mdecAccessories = 3030.3D
        target.mdecFinish = 0D
        target.mdecSalePrice = 5000D
        target.mdecTradeIn = 50D
        target.mdecAmountDue = 8943.94D
        target.hsbInterestRate.Value = 2500
        target.hsbYears.Value = 3

        actual = target.lblMonthlyPaymentOutput.Text
        Assert.AreEqual(expected, actual, "Something went wrong")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    ''' <summary>
    ''' A test for calculate to test for proper calculation when rate is minimum.
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub calculateTest_rateMin()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value

        Dim expected As String = "$248.44"
        Dim actual As String

        'setup
        target.mdecTotPrice = 8993.936D
        target.mdecAccessories = 3030.3D
        target.mdecFinish = 0D
        target.mdecSalePrice = 5000D
        target.mdecTradeIn = 50D
        target.mdecAmountDue = 8943.94D
        target.hsbInterestRate.Value = 0
        target.hsbYears.Value = 3
        target.calculate()

        actual = target.lblMonthlyPaymentOutput.Text
        Assert.AreEqual(expected, actual, "Something went wrong")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    ''' <summary>
    ''' A test for calculate to test for proper calculation when years is maximum.
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub calculateTest_yearsMax()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value

        Dim expected As String = "$94.86"
        Dim actual As String

        'setup
        target.mdecTotPrice = 8993.936D
        target.mdecAccessories = 3030.3D
        target.mdecFinish = 0D
        target.mdecSalePrice = 5000D
        target.mdecTradeIn = 50D
        target.mdecAmountDue = 8943.94D
        target.hsbInterestRate.Value = 500
        target.hsbYears.Value = 10
        target.calculate()

        actual = target.lblMonthlyPaymentOutput.Text
        Assert.AreEqual(expected, actual, "Something went wrong")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    ''' <summary>
    ''' A test for calculate to test for proper calculation when years is minimum.
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub calculateTest_yearsMin()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value

        Dim expected As String = "$765.67"
        Dim actual As String

        'setup
        target.mdecTotPrice = 8993.936D
        target.mdecAccessories = 3030.3D
        target.mdecFinish = 0D
        target.mdecSalePrice = 5000D
        target.mdecTradeIn = 50D
        target.mdecAmountDue = 8943.94D
        target.hsbInterestRate.Value = 500
        target.hsbYears.Value = 1
        target.calculate()

        actual = target.lblMonthlyPaymentOutput.Text
        Assert.AreEqual(expected, actual, "Something went wrong")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    ''' <summary>
    ''' A test for calculate to test for proper calculation when amount due is 0.
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub calculateTest_noAmountDue()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value

        Dim expected As String = "$0.00"
        Dim actual As String

        'setup
        target.mdecTotPrice = 8993.936D
        target.mdecAccessories = 3030.3D
        target.mdecFinish = 0D
        target.mdecSalePrice = 5000D
        target.mdecTradeIn = 8993.936D
        target.hsbInterestRate.Value = 500
        target.hsbYears.Value = 1
        target.calculate()

        actual = target.lblMonthlyPaymentOutput.Text
        Assert.AreEqual(expected, actual, "Something went wrong")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    ''' <summary>
    ''' A test for calculate to test for proper calculation.
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub calculateTest()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value

        Dim expected As String = "$126.41"
        Dim actual As String

        'setup
        target.mdecTotPrice = 8993.936D
        target.mdecAccessories = 3030.3D
        target.mdecFinish = 0D
        target.mdecSalePrice = 5000D
        target.mdecTradeIn = 50D
        target.mdecAmountDue = 8943.94D
        target.hsbInterestRate.Value = 500
        target.hsbYears.Value = 7
        target.calculate()

        actual = target.lblMonthlyPaymentOutput.Text
        Assert.AreEqual(expected, actual, "Something went wrong")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
#End Region

#Region "enableFinance sub procedure tests"
    ''' <summary>
    ''' A test for enableFinance to test if the groupbox was enabled.
    ''' In turn check if the years, and interest rate were set properly.
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub enableFinanceTest_TrueBoolean()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value

        Dim expected As Boolean = True
        Dim actual As Boolean

        'setup
        target.txtSalePrice.Text = "5000"
        target.txtTradeIn.Text = "50"
        target.enableFinance(True)


        actual = target.grpFinance.Enabled

        Assert.AreEqual(expected, actual, "Groupbox finance not properly set.")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    ''' <summary>
    ''' A test for enableFinance to test if the groupbox was enabled and for the proper years.
    ''' In turn check if the years, and interest rate were set properly.
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub enableFinanceTest_TrueYears()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value

        Dim expectedYears As String = "3"
        Dim actualYears As String

        'setup
        target.txtSalePrice.Text = "5000"
        target.txtTradeIn.Text = "50"
        target.enableFinance(True)

        actualYears = target.lblNoOfYearsOutput.Text

        Assert.AreEqual(expectedYears, actualYears, "Years not properly set.")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    ''' <summary>
    ''' A test for enableFinance to test if the groupbox was enabled and interest rate was set properly.
    ''' In turn check if the years, and interest rate were set properly.
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub enableFinanceTest_TrueRate()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value

        Dim expectedRate As String = "5.00 %"
        Dim actualRate As String

        'setup
        target.txtSalePrice.Text = "5000"
        target.txtTradeIn.Text = "50"
        target.enableFinance(True)

        actualRate = target.lblInterestRateOutput.Text

        Assert.AreEqual(expectedRate, actualRate, "Rate not properly set.")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    ''' <summary>
    ''' A test for enableFinance to test if the groupbox was not enabled.
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub enableFinanceTest_False()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value

        Dim expected As Boolean = False
        Dim actual As Boolean

        'setup
        target.txtSalePrice.Text = "5000"
        target.txtTradeIn.Text = "50"
        target.enableFinance(False)

        actual = target.grpFinance.Enabled

        Assert.AreEqual(expected, actual, "Groupbox finance not properly set.")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
#End Region

#Region "scrollbar tests"
    ''' <summary>
    ''' A test for hsbYearsInterestRate_ValueChanged, testing for proper value output for years.
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub hsbYearsInterestRate_Years()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value

        Dim expected As String = "5"
        Dim actual As String

        'setup
        target.hsbYears.Value = 5

        actual = target.lblNoOfYearsOutput.Text
        Assert.AreEqual(expected, actual, "Number of years, not properly set.")
    End Sub

    ''' <summary>
    ''' A test for hsbYearsInterestRate_ValueChanged, testing for proper value output for interest rate.
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub hsbYearsInterestRate_Rate()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value

        Dim expected As String = "5.00 %"
        Dim actual As String

        'setup
        target.hsbInterestRate.Value = 500

        actual = target.lblInterestRateOutput.Text
        Assert.AreEqual(expected, actual, "Number of years, not properly set.")
    End Sub
#End Region

#Region "Context menu tests"
    ''' <summary>
    ''' A test for AcceptQuoteToolStripMenuItem_Click, checking for 2 quotes of the same value.
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub AcceptQuoteToolStripMenuItem_Test()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expectedAmountDue As Decimal = 18792.9216D
        Dim actualAmountDue As Decimal
        Dim expectedNoOfQuotes As Integer = 2
        Dim actualNoOfQuotes As Integer

        'setup
        target.mdecSalePrice = 5000D
        target.chkStereo.Checked = True
        target.chkLeather.Checked = True
        target.chkCompNav.Checked = True
        target.radPearlized.Checked = True
        target.mdecTradeIn = 50D

        target.CalculateToolStripMenuItem_Click(sender, e)
        target.AcceptQuoteToolStripMenuItem_Click(sender, e)

        target.mdecSalePrice = 5000D
        target.mdecTradeIn = 50D
        target.chkStereo.Checked = True
        target.chkLeather.Checked = True
        target.chkCompNav.Checked = True
        target.radPearlized.Checked = True


        target.CalculateToolStripMenuItem_Click(sender, e)
        target.AcceptQuoteToolStripMenuItem_Click(sender, e)

        actualAmountDue = target.mdecTotalAmountDue
        actualNoOfQuotes = target.mintNoOfQuotes

        Assert.AreEqual(expectedAmountDue, actualAmountDue, "Total amount due, not properly set.")
        Assert.AreEqual(expectedNoOfQuotes, actualNoOfQuotes, "Total no. of quotes, not properly set.")
    End Sub

    ''' <summary>
    ''' A test for SummaryToolStripMenuItem_Click, checking for 2 quotes of the same value's average.
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub SummaryToolStripMenuItem_Test()
        Dim target As frmEstimate_Accessor = New frmEstimate_Accessor() ' TODO: Initialize to an appropriate value
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expectedAverage As Decimal = 8943.94D
        Dim actualAverage As Decimal

        'setup
        target.mdecTotalAmountDue = 17887.88D
        target.mintNoOfQuotes = 2
        target.SummaryToolStripMenuItem_Click(sender, e)
        actualAverage = target.mdecAverage

        Assert.AreEqual(expectedAverage, actualAverage, "Average, not properly set.")
    End Sub
#End Region
End Class
