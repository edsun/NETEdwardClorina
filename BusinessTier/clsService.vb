Public Class clsService
#Region "Class Variables"

    'Protected Constants
    Protected Const PST_RATE As Decimal = 0.07D
    Protected Const GST_RATE As Decimal = 0.05D

    'Auto implemented Variables
    Property mdecPrice As Decimal
    Property mdecParts As Decimal
    Property mdecMaterials As Decimal

    'Class Variables
    Dim mdecCalcPST As Decimal
    Dim mdecCalcGST As Decimal
    Dim mdecCalcTot As Decimal

    'Shared Variables
    Protected Shared mintNoOfContracts As Integer
    Protected Shared mdecAccCalcTot As Decimal
    Protected Shared mdecAccGST As Decimal
    Protected Shared mdecAccPST As Decimal
#End Region

#Region "ReadOnly procedures"
    ReadOnly Property calcGST As Decimal
        Get
            Return mdecCalcGST
        End Get
    End Property

    ReadOnly Property calcPST As Decimal
        Get
            Return mdecCalcPST
        End Get
    End Property

    ReadOnly Property calcTot As Decimal
        Get
            Return mdecCalcTot
        End Get
    End Property

    Shared ReadOnly Property noOfContracts As Integer
        Get
            Return mintNoOfContracts
        End Get
    End Property

    Shared ReadOnly Property accCalcTotal As Decimal
        Get
            Return mdecAccCalcTot
        End Get
    End Property

    Shared ReadOnly Property accGST As Decimal
        Get
            Return mdecAccGST
        End Get
    End Property

    Shared ReadOnly Property accPST As Decimal
        Get
            Return mdecAccPST
        End Get
    End Property
#End Region

#Region "Constructors"

    ''' <summary>
    ''' Default Constructor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        _mdecPrice = 0
        _mdecParts = 0
        _mdecMaterials = 0
    End Sub

    ''' <summary>
    ''' Parameterized Constructor
    ''' </summary>
    ''' <param name="decPrice"></param>
    ''' <param name="decParts"></param>
    ''' <param name="decMaterials"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal decPrice As Decimal, ByVal decParts As Decimal, ByVal decMaterials As Decimal)
        _mdecPrice = decPrice
        _mdecParts = decParts
        _mdecMaterials = decMaterials
    End Sub
#End Region

#Region "Functions"
    ''' <summary>
    ''' calcAmount, used to accumuluate shared variables and return total price
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function calcAmount() As Decimal
        mdecCalcTot = mdecMaterials + mdecPrice + mdecParts
        mdecCalcGST = mdecCalcTot * GST_RATE
        mdecCalcPST = mdecCalcTot * PST_RATE
        Dim decTotal As Decimal = mdecCalcTot + mdecCalcPST + mdecCalcGST

        'Accumulate Shared Variables
        mdecAccGST += mdecCalcGST
        mdecAccPST += mdecCalcPST
        mintNoOfContracts += 1
        mdecAccCalcTot += decTotal

        'Return the service contact amount
        Return decTotal
    End Function

    ''' <summary>
    ''' averageContract, used to return the average cost of a Service Contract
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function averageContract() As Decimal
        Return mdecAccCalcTot / mintNoOfContracts
    End Function
#End Region
End Class
