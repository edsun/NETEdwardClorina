Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports NETEdwardClorina



'''<summary>
'''This is a test class for frmSummaryTest and is intended
'''to contain all frmSummaryTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmSummaryTest


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

    Dim target As frmSummary_Accessor = New frmSummary_Accessor
    'Use TestInitialize to run code before running each test
    <TestInitialize()> _
    Public Sub MyTestInitialize()
    End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''A test for frmSummary_Load
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub frmSummary_LoadTest()
        Dim test As BusinessTier.clsService = New BusinessTier.clsService(5, 5, 5)
        Dim sender As Object = test ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expectedTotal As String = "$16.80"
        Dim expectedNoOfServices As String = "1"
        Dim expectedGST As String = "$0.75"
        Dim expectedPST As String = "$1.05"
        Dim expectedAverage As String = "$16.80"

        Dim actualTotal As String
        Dim actualNoOfServices As String
        Dim actualGST As String
        Dim actualPST As String
        Dim actualAverage As String

        'setup
        test.calcAmount()

        target.frmSummary_Load(sender, e)
        actualTotal = target.lblTotServiceContractsOutput.Text
        actualNoOfServices = target.lblNoOfServiceContractsOutput.Text
        actualGST = target.lblTotalGSTOutput.Text
        actualPST = target.lblTotalPSTOutput.Text
        actualAverage = target.lblAvgServiceContractsOutput.Text

        Assert.AreEqual(expectedTotal, actualTotal, "total Service Contracts not properly set.")
        Assert.AreEqual(expectedNoOfServices, actualNoOfServices, "No of services not properly set.")
        Assert.AreEqual(expectedGST, actualGST, "GST not properly set.")
        Assert.AreEqual(expectedPST, actualPST, "PST not properly set.")
        Assert.AreEqual(expectedAverage, actualAverage, "Average not properly set.")
        'Assert.Inconclusive("A method that does not return a value cannot be verified.")
    End Sub
End Class
