Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports BusinessTier



'''<summary>
'''This is a test class for clsServiceTest and is intended
'''to contain all clsServiceTest Unit Tests
'''</summary>
<TestClass()> _
Public Class clsServiceTest


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

    Dim target As clsService_Accessor = New clsService_Accessor
    'Use TestInitialize to run code before running each test
    <TestInitialize()> _
    Public Sub MyTestInitialize()
        clsService_Accessor.mintNoOfContracts = 0
        clsService_Accessor.mdecAccCalcTot = 0
        clsService_Accessor.mdecAccGST = 0
        clsService_Accessor.mdecAccPST = 0

    End Sub

    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region

    '''<summary>
    '''A test for mdecMaterials
    '''</summary>
    <TestMethod()> _
    Public Sub mdecMaterialsTest()
        Dim expected As [Decimal] = New [Decimal](50) ' TODO: Initialize to an appropriate value
        Dim actual As [Decimal]

        target.mdecMaterials = expected
        actual = target.mdecMaterials

        Assert.AreEqual(expected, actual)
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for mdecParts
    '''</summary>
    <TestMethod()> _
    Public Sub mdecPartsTest()
        Dim expected As [Decimal] = New [Decimal](50) ' TODO: Initialize to an appropriate value
        Dim actual As [Decimal]

        target.mdecParts = expected
        actual = target.mdecParts

        Assert.AreEqual(expected, actual)
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for mdecPrice
    '''</summary>
    <TestMethod()> _
    Public Sub mdecPriceTest()
        Dim expected As [Decimal] = New [Decimal](50) ' TODO: Initialize to an appropriate value
        Dim actual As [Decimal]

        target.mdecPrice = expected
        actual = target.mdecPrice

        Assert.AreEqual(expected, actual)
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for clsService Constructor checking for the default constructor.
    '''</summary>
    <TestMethod()> _
    Public Sub clsServiceConstructorTest_Default()
        Dim target As clsService = New clsService()
        Dim expectedPrice As Decimal = 0
        Dim expectedParts As Decimal = 0
        Dim expectedMaterials As Decimal = 0
        Dim actualPrice As Decimal = target.mdecPrice
        Dim actualParts As Decimal = target.mdecParts
        Dim actualMaterials As Decimal = target.mdecMaterials


        Assert.AreEqual(expectedPrice, actualPrice, "Price was not properly set.")
        Assert.AreEqual(expectedParts, actualParts, "Parts was not properly set.")
        Assert.AreEqual(expectedMaterials, actualMaterials, "Materials was not properly set.")
        'Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub

    '''<summary>
    '''A test for clsService Constructor for the paramterized
    '''</summary>
    <TestMethod()> _
    Public Sub clsServiceConstructorTest_Parameterized()
        Dim expectedPrice As [Decimal] = New [Decimal](50) ' TODO: Initialize to an appropriate value
        Dim expectedParts As [Decimal] = New [Decimal](50) ' TODO: Initialize to an appropriate value
        Dim expectedMaterials As [Decimal] = New [Decimal](50) ' TODO: Initialize to an appropriate value
        Dim actualPrice As Decimal
        Dim actualParts As Decimal
        Dim actualMaterials As Decimal


        'setup
        Dim target As clsService = New clsService(expectedPrice, expectedParts, expectedMaterials)
        actualPrice = target.mdecPrice
        actualParts = target.mdecParts
        actualMaterials = target.mdecMaterials

        Assert.AreEqual(expectedPrice, actualPrice, "Price not set properly")
        Assert.AreEqual(expectedParts, actualParts, "Parts not set properly")
        Assert.AreEqual(expectedMaterials, actualPrice, "Materials not set properly")

        'Assert.Inconclusive("TODO: Implement code to verify target")
    End Sub

    '''<summary>
    '''A test for calcAmount
    '''</summary>
    <TestMethod()> _
    Public Sub calcAmountTest()
        Dim target As clsService = New clsService(5, 5, 5)
        Dim expectedGST As Decimal = 0.75D
        Dim expectedPST As Decimal = 1.05D
        Dim expectedSubtotal As Decimal = 15D
        Dim expectedTotal As Decimal = 16.8D
        Dim expectedAccGST As Decimal = 1.5D
        Dim expectedAccPST As Decimal = 2.1D
        Dim expectedAccNoOfContracts As Integer = 2
        Dim expectedAccTotal As Decimal = 33.6D

        Dim actualGST As Decimal
        Dim actualPST As Decimal
        Dim actualSubtotal As Decimal
        Dim actualTotal As Decimal
        Dim actualAccGST As Decimal
        Dim actualAccPST As Decimal
        Dim actualAccNoOfContracts As Integer
        Dim actualAccTotal As Decimal

        'setup
        target.calcAmount()
        actualTotal = target.calcAmount()
        actualGST = target.calcGST
        actualPST = target.calcPST
        actualSubtotal = target.mdecPrice + target.mdecParts + target.mdecMaterials
        actualAccGST = clsService.accGST
        actualAccPST = clsService.accPST
        actualAccNoOfContracts = clsService.noOfContracts
        actualAccTotal = clsService.accCalcTotal




        Assert.AreEqual(expectedGST, actualGST, "GST not properly set.")
        Assert.AreEqual(expectedPST, actualPST, "PST not properly set.")
        Assert.AreEqual(expectedSubtotal, actualSubtotal, "Subtotal not properly set.")
        Assert.AreEqual(expectedTotal, actualTotal, "Total not properly set.")
        Assert.AreEqual(expectedAccGST, actualAccGST, "Accumulated GST not properly set.")
        Assert.AreEqual(expectedAccPST, actualAccPST, "Accumulated PST not properly set.")
        Assert.AreEqual(expectedAccNoOfContracts, actualAccNoOfContracts, "Accumuluted number of contracts, not properly set.")
        Assert.AreEqual(expectedAccTotal, actualAccTotal, "Accumulated Total, not properly set.")
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for averageContract
    '''</summary>
    <TestMethod()> _
    Public Sub averageContractTest()
        Dim target As clsService = New clsService(5, 5, 5)
        Dim expected As [Decimal] = New [Decimal](16.8) ' TODO: Initialize to an appropriate value
        Dim actual As [Decimal]

        'setup
        target.calcAmount()
        target.calcAmount()
        actual = clsService.averageContract

        Assert.AreEqual(expected, actual)
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub
End Class
