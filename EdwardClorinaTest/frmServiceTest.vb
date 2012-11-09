Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports NETEdwardClorina



'''<summary>
'''This is a test class for frmServiceTest and is intended
'''to contain all frmServiceTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmServiceTest


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

    Dim target As frmService_Accessor = New frmService_Accessor
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


#Region "textbox tests"
    '''<summary>
    '''A test for textLeaveChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub textLeaveChangedTest_NonNumeric()
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expectedCalc As Boolean = False
        Dim actualCalc As Boolean

        target.txtParts.Text = "e"
        actualCalc = target.CalculateToolStripMenuItem.Enabled

        Assert.AreEqual(expectedCalc, actualCalc, "Calculate button not properly enabled/disabled.")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for textLeaveChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub textLeaveChangedTest_Numeric()
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expectedCalc As Boolean = True
        Dim actualCalc As Boolean

        target.txtParts.Text = "5"
        target.textLeaveChanged(target.txtParts, e)
        target.txtPrice.Text = "5"
        target.textLeaveChanged(target.txtPrice, e)
        target.txtShopMaterial.Text = "5"
        target.textLeaveChanged(target.txtShopMaterial, e)
        actualCalc = target.CalculateToolStripMenuItem.Enabled

        Assert.AreEqual(expectedCalc, actualCalc, "Calculate button not properly enabled/disabled.")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for textEntered
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub textEnteredTest()
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expected As String = "5"
        Dim actual As String

        target.txtParts.Text = "5"

        target.textEntered(target.txtParts, e)

        actual = target.txtParts.SelectedText

        Assert.AreEqual(expected, actual, "Selected text not properly set.")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
#End Region

#Region "Context menu tests"
    '''<summary>
    '''A test for CalculateToolStripMenuItem_Click
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub CalculateToolStripMenuItem_ClickTest()
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expectedPST As String = "$1.05"
        Dim expectedGST As String = "$0.75"
        Dim expectedTotal As String = "$16.80"
        Dim actualPST As String
        Dim actualGST As String
        Dim actualTotal As String

        'setup
        target.txtParts.Text = "5"
        target.txtPrice.Text = "5"
        target.txtShopMaterial.Text = "5"

        target.CalculateToolStripMenuItem_Click(sender, e)
        actualPST = target.lblPSTOutput.Text
        actualGST = target.lblGSTOutput.Text
        actualTotal = target.lblTotalOutput.Text

        Assert.AreEqual(expectedPST, actualPST, "PST not properly set.")
        Assert.AreEqual(expectedGST, actualGST, "GST not properly set.")
        Assert.AreEqual(expectedTotal, actualTotal, "Total not properly set.")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub

    '''<summary>
    '''A test for ClearToolStripMenuItem_Click
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub ClearToolStripMenuItem_ClickTest()
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expectedDescription As String = ""
        Dim expectedPrice As String = ""
        Dim expectedParts As String = ""
        Dim expectedMaterials As String = ""
        Dim expectedPST As String = ""
        Dim expectedGST As String = ""
        Dim expectedTotal As String = ""
        Dim expectedCalc As Boolean = False

        Dim actualDescription As String
        Dim actualPrice As String
        Dim actualParts As String
        Dim actualMaterials As String
        Dim actualPST As String
        Dim actualGST As String
        Dim actualTotal As String
        Dim actualCalc As Boolean

        target.ClearToolStripMenuItem_Click(sender, e)

        actualDescription = target.txtServiceDescription.Text
        actualPrice = target.txtPrice.Text
        actualParts = target.txtParts.Text
        actualMaterials = target.txtShopMaterial.Text
        actualPST = target.lblPSTOutput.Text
        actualGST = target.lblGSTOutput.Text
        actualTotal = target.lblTotalOutput.Text
        actualCalc = target.CalculateToolStripMenuItem.Enabled

        Assert.AreEqual(expectedDescription, actualDescription, "Description not properly cleared.")
        Assert.AreEqual(expectedPrice, actualPrice, "Price not properly cleared.")
        Assert.AreEqual(expectedParts, actualParts, "Parts not properly cleared.")
        Assert.AreEqual(expectedMaterials, actualMaterials, "Materials not properly cleared.")
        Assert.AreEqual(expectedPST, actualPST, "PST not properly cleared.")
        Assert.AreEqual(expectedGST, actualGST, "GST not properly cleared.")
        Assert.AreEqual(expectedTotal, actualTotal, "Total not properly cleared.")
        Assert.AreEqual(expectedCalc, actualCalc, "Calculate not properly disabled.")
    End Sub
#End Region
End Class
