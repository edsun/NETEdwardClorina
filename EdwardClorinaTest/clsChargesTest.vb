Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports BusinessTier



'''<summary>
'''This is a test class for clsChargesTest and is intended
'''to contain all clsChargesTest Unit Tests
'''</summary>
<TestClass()> _
Public Class clsChargesTest


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

    Dim target As clsCharges_Accessor = New clsCharges_Accessor
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
    '''A test for getCharges
    '''</summary>
    <TestMethod()> _
    Public Sub getChargesTest()
        'Set our variables
        target.mdecCharges = 7.5D
        Dim expected As Decimal = 7.5D

        Dim actual As [Decimal]

        'Grab the actual result
        actual = target.getCharges

        Assert.AreEqual(expected, actual, "Charges was not set properly")
    End Sub

    '''<summary>
    '''A test for getTaxes
    '''</summary>
    <TestMethod()> _
    Public Sub getTaxesTest()
        target.mdecTax = 0.9D
        Dim expected As Decimal = 0.9D

        Dim actual As [Decimal]


        actual = target.getTaxes
        Assert.AreEqual(expected, actual, "Taxes were not set properly")
    End Sub

    '''<summary>
    '''A test for getTotal
    '''</summary>
    <TestMethod()> _
    Public Sub getTotalTest()
        target.mdecTotal = 8D
        Dim expected As Decimal = 8D
        Dim actual As [Decimal]

        actual = target.getTotal

        Assert.AreEqual(expected, actual, "Total was not set properly")
    End Sub

    '''<summary>
    '''A test for clsCharges Constructor, default test
    '''</summary>
    <TestMethod()> _
    Public Sub clsChargesConstructor_Default()
        Dim target As clsCharges = New clsCharges()
        'Expected Results
        Dim expectedFragPrice As Decimal = 0D
        Dim expectedPackPrice As Decimal = 0D

        'Actual results
        Dim actualFragPrice As Decimal = target.mdecFragrancePrice
        Dim actualPackPrice As Decimal = target.mdecPackagePrice



        Assert.AreEqual(expectedFragPrice, actualFragPrice, "Fragrance price was not properly set.")
        Assert.AreEqual(expectedPackPrice, actualPackPrice, "Package price was not properly set.")
    End Sub

    '''<summary>
    '''A test for clsCharges Constructor, Parameterized test
    '''</summary>
    <TestMethod()> _
    Public Sub clsChargesConstructor_Parameterized()
        'Values to be passed
        Dim decPackagePrice As [Decimal] = New [Decimal](7.5)
        Dim decFragrancePrice As [Decimal] = New [Decimal](7.5)
        'Expected Values
        Dim expectedPackagePrice As Decimal = 7.5D
        Dim expectedFragrancePrice As Decimal = 7.5D
        'Actual values
        Dim actualPackagePrice As Decimal
        Dim actualFragrancePrice As Decimal

        'Create the clsCharges object
        Dim target As clsCharges = New clsCharges(decPackagePrice, decFragrancePrice)
        actualPackagePrice = target.mdecPackagePrice
        actualFragrancePrice = target.mdecFragrancePrice

        Assert.AreEqual(expectedFragrancePrice, actualFragrancePrice, "Fragrance Price was not properly set.")
        Assert.AreEqual(expectedPackagePrice, actualPackagePrice, "Package price was not properly set.")
    End Sub

    '''<summary>
    '''A test for calculate
    '''</summary>
    <TestMethod()> _
    Public Sub calculateTest()
        'Values to be passed
        Dim decPackagePrice As Decimal = 7.5D
        Dim decFragrancePrice As Decimal = 0D
        Dim target As clsCharges = New clsCharges(decPackagePrice, decFragrancePrice)
        'Expected Values
        Dim expectedCharges As Decimal = 7.5D
        Dim expectedTaxes As Decimal = 0.9D
        Dim expectedTotal As Decimal = 8.4D
        'Actual Values
        Dim actualCharges As Decimal
        Dim actualTaxes As Decimal
        Dim actualTotal As Decimal

        target.calculate()

        actualCharges = target.getCharges
        actualTaxes = target.getTaxes
        actualTotal = target.getTotal

        Assert.AreEqual(expectedCharges, actualCharges, "Charges not set properly")
        Assert.AreEqual(expectedTaxes, actualTaxes, "Taxes not set properly.")
        Assert.AreEqual(expectedTotal, actualTotal, "Total not set properly.")
    End Sub
End Class
