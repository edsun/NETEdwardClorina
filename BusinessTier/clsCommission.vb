Public Class clsCommission
#Region "Class Variables"
    'Protected Constants
    Protected Const COMMISSION_RATE As Decimal = 0.2D

    'Auto implemented properties
    Property mdecCostPrice As Decimal
    Property mdecRetailPrice As Decimal
#End Region

#Region "Constructors"
    ''' <summary>
    ''' Default Constructor for clsCommission class
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        'Initialize our class properties
        mdecCostPrice = 0D
        mdecRetailPrice = 0D
    End Sub

    ''' <summary>
    ''' Parameterized constructor for the clsCommission class
    ''' </summary>
    ''' <param name="decCostPrice">our value to initiliaze our cost price</param>
    ''' <param name="decRetailPrice">our value to initialize our retail price</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal decCostPrice As Decimal, ByVal decRetailPrice As Decimal)
        'Initialize our class properties to our passed parameters
        mdecCostPrice = decCostPrice
        mdecRetailPrice = decRetailPrice
    End Sub
#End Region

#Region "Class Functions & Procedures"

    ''' <summary>
    ''' Calculates the commission by calculating the difference between retail and cost price and applying the commission rate.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function calcCommission() As Decimal
        Return (mdecRetailPrice - mdecCostPrice) * COMMISSION_RATE
    End Function
#End Region
End Class
