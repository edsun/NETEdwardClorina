Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports NETEdwardClorina



'''<summary>
'''This is a test class for frmCarWashTest and is intended
'''to contain all frmCarWashTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmCarWashTest


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

    Dim target As frmCarWash_Accessor = New frmCarWash_Accessor

    '
    'Use TestInitialize to run code before running each test
    <TestInitialize()> _
    Public Sub MyTestInitialize()
        Dim objSender As System.Object = Nothing
        Dim eventArgs As System.EventArgs = Nothing

        target.frmCarWash_Load(objSender, eventArgs)
    End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region

#Region "readFiles tests"
    '''<summary>
    '''A test for readFiles to check for proper reading of Interior.txt
    '''</summary>
    <TestMethod()> _
    Public Sub readFiles_Interior()
        target.readFiles("Interior.txt")
        Dim expectedSize As Integer = 4
        Dim actualSize As Integer = target.mstrInterior.Length

        'Check for the specific value at Index 0
        Dim expectedValue As String = "Fragrance"
        Dim actualValue As String = target.mstrInterior(0)

        Assert.AreEqual(expectedSize, actualSize, "Not the correct count.")
        Assert.AreEqual(expectedValue, actualValue, "Value not set correctly.")
    End Sub

    '''<summary>
    '''A test for readFiles to check for proper reading of Exterior.txt
    '''</summary>
    <TestMethod()> _
    Public Sub readFiles_Exterior()
        target.readFiles("Exterior.txt")
        Dim expectedSize As Integer = 4
        Dim actualSize As Integer = target.mstrExterior.Length

        'Check for the specific value at Index 2
        Dim expectedValue As String = "Check Engine Fluid"
        Dim actualValue As String = target.mstrExterior(2)

        Assert.AreEqual(expectedSize, actualSize, "Not the current count.")
        Assert.AreEqual(expectedValue, actualValue, "Value not set correctly.")
    End Sub

    ''' <summary>
    ''' A test for readFiles to check for proper reading of FragDesc.txt
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> _
    Public Sub readFiles_FragDesc()
        target.readFiles("FragDesc.txt")
        Dim expectedSize As Integer = 6
        Dim actualSize As Integer = target.mfrsFragrances.Length

        'Check for the specific Value at index 1
        Dim expectedValue As String = "Baby Powder"
        Dim actualValue As String = target.mfrsFragrances(1).strDesc.ToString

        Assert.AreEqual(expectedSize, actualSize, "Not the current count.")
        Assert.AreEqual(expectedValue, actualValue, "Value not set correctly.")
    End Sub

    ''' <summary>
    ''' A test for readFiles to check for proper reading of FragPrices.txt
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> _
    Public Sub readFiles_FragPrices()
        target.readFiles("FragPrices.txt")
        Dim expectedSize As Integer = 6
        Dim actualSize As Integer = target.mfrsFragrances.Length

        'Check for the specific value at index 4
        Dim expectedValue As Decimal = 0.75D
        Dim actualValue As Decimal = target.mfrsFragrances(4).decPrice

        Assert.AreEqual(expectedSize, actualSize, "Not the current count.")
        Assert.AreEqual(expectedValue, actualValue, "Value not set correctly.")
    End Sub

    ''' <summary>
    ''' A test for readFiles to check for proper reading of PkgDesc.txt
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> _
    Public Sub readFiles_PkgDesc()
        target.readFiles("PkgDesc.txt")
        Dim expectedSize As Integer = 4
        Dim actualSize As Integer = target.cboDetail.Items.Count

        'Check for the specific value at index 3
        Dim expectedValue As String = "Luxury"
        Dim actualValue As String = target.cboDetail.Items(3).ToString

        Assert.AreEqual(expectedSize, actualSize, "Not the current count.")
        Assert.AreEqual(expectedValue, actualValue, "Value not set correctly.")
    End Sub

    ''' <summary>
    ''' A test for readFiles to check for proper reading of PkgPrices.txt
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> _
    Public Sub readFiles_PkgPrices()
        target.readFiles("PkgPrices.txt")
        Dim expectedSize As Integer = 4
        Dim actualSize As Integer = target.mdecPrices.Length

        'Check for the specific value at index 2
        Dim expectedValue As Decimal = 35D
        Dim actualValue As Decimal = target.mdecPrices(2)

        Assert.AreEqual(expectedSize, actualSize, "Not the current count.")
        Assert.AreEqual(expectedValue, actualValue, "Value not set correctly.")
    End Sub
#End Region

    '''<summary>
    '''A test for resetFrag
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub resetFragTest()
        Dim expected As Integer = 4
        Dim actual As Integer
        actual = target.resetFrag
        Assert.AreEqual(expected, actual)
    End Sub

    '''<summary>
    '''A test for getFragIndex
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub getFragIndexTest()
        Dim strSelectedFrag As String = "Pine" ' TODO: Initialize to an appropriate value
        Dim expected As Integer = 2 ' TODO: Initialize to an appropriate value
        Dim actual As Integer
        actual = target.getFragIndex(strSelectedFrag)
        Assert.AreEqual(expected, actual)
    End Sub

    '''<summary>
    '''A test for frmCarWash_Load
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub frmCarWash_LoadTest()
        target.cboDetail.Items.Clear()
        target.cboFragrance.Items.Clear()

        Dim sender As Object = Nothing
        Dim e As EventArgs = Nothing
        'Expected values
        Dim expectedDetailIndex As Integer = 0
        Dim expectedFragIndex As Integer = 4
        'Actual values
        Dim actualDetailIndex As Integer
        Dim actualFragIndex As Integer
        target.frmCarWash_Load(sender, e)

        actualDetailIndex = target.cboDetail.SelectedIndex
        actualFragIndex = target.cboFragrance.SelectedIndex

        Assert.AreEqual(expectedDetailIndex, actualDetailIndex, "Detail index not set properly.")
        Assert.AreEqual(expectedFragIndex, actualFragIndex, "Fragrance Index not set properly.")


    End Sub

    '''<summary>
    '''A test for cbo_SelectedIndexChanged
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub cbo_SelectedIndexChangedTest()
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim cboSender As Object = target.cboDetail
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value
        Dim expected1 As Integer = 8
        Dim actual1 As Integer
        Dim expected2 As Integer = 1
        Dim actual2 As Integer

        target.frmCarWash_Load(sender, e)

        target.cboDetail.SelectedIndex = 1
        target.cboFragrance.SelectedIndex = 1

        target.cbo_SelectedIndexChanged(cboSender, e)

        actual1 = target.cboFragrance.SelectedIndex
        actual2 = target.cboDetail.SelectedIndex

        Assert.AreEqual(expected1, actual1)
        Assert.AreEqual(expected2, actual2)
    End Sub

    '''<summary>
    '''A test for btnClear_Click
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub btnClear_ClickTest()
        Dim sender As Object = Nothing ' TODO: Initialize to an appropriate value
        Dim e As EventArgs = Nothing ' TODO: Initialize to an appropriate value

        Dim expected1 As Integer = 0
        Dim actual1 As Integer
        Dim expected2 As Integer = 0
        Dim actual2 As Integer

        target.frmCarWash_Load(sender, e)

        target.cboDetail.SelectedIndex = 1
        target.cboFragrance.SelectedIndex = 1


        target.btnClear_Click(sender, e)



        Assert.AreEqual(expected1, actual1, "Value not set properly")
        Assert.AreEqual(expected2, actual2, "Value not set properly")
    End Sub
End Class
