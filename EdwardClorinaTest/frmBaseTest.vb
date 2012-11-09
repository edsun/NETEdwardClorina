Imports System.Windows.Forms

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports NETEdwardClorina



'''<summary>
'''This is a test class for frmBaseTest and is intended
'''to contain all frmBaseTest Unit Tests
'''</summary>
<TestClass()> _
Public Class frmBaseTest


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
    Dim target As frmBase_Accessor = New frmBase_Accessor
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


    '''<summary>
    '''A test for sendMessage
    '''</summary>
    <TestMethod(), _
     DeploymentItem("NETEdwardClorina.exe")> _
    Public Sub sendMessageTest()
        Dim text As String = "Error goes here" ' TODO: Initialize to an appropriate value
        Dim caption As String = "error" ' TODO: Initialize to an appropriate value
        Dim buttons As MessageBoxButtons = New MessageBoxButtons() ' TODO: Initialize to an appropriate value
        Dim icon As MessageBoxIcon = New MessageBoxIcon() ' TODO: Initialize to an appropriate value
        Dim defaultButton As MessageBoxDefaultButton = New MessageBoxDefaultButton() ' TODO: Initialize to an appropriate value
        Dim expected As String = "Error goes here" ' TODO: Initialize to an appropriate value
        Dim msgBox As DialogResult = target.sendMessage(text, caption, buttons, icon, defaultButton)
        Dim actual As String

        actual = target.mstrTestString

        Assert.AreEqual(expected, actual)
        'Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub
End Class
