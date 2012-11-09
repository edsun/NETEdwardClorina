Public Class clsCharges
#Region "Class Variables"
    'Private Constants
    Private Const COMBINED_TAX_RATE As Decimal = 0.12D

    'Auto implemented Properties
    Property mdecPackagePrice As Decimal
    Property mdecFragrancePrice As Decimal

    'Private properties
    Private mdecCharges As Decimal
    Private mdecTax As Decimal
    Private mdecTotal As Decimal

#End Region

#Region "ReadOnly Property procedures"
    ''' <summary>
    ''' Return the charges
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property getCharges As Decimal
        Get
            Return mdecCharges
        End Get
    End Property

    ''' <summary>
    ''' Return the taxes
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property getTaxes As Decimal
        Get
            Return mdecTax
        End Get
    End Property

    ''' <summary>
    ''' Return the total
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property getTotal As Decimal
        Get
            Return mdecTotal
        End Get
    End Property
#End Region

#Region "Constructors"

    ''' <summary>
    ''' Default constructor
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        _mdecPackagePrice = 0
        _mdecFragrancePrice = 0
    End Sub

    ''' <summary>
    ''' Parameterized Constructor
    ''' </summary>
    ''' <param name="decPackagePrice"></param>
    ''' <param name="decFragrancePrice"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal decPackagePrice As Decimal, ByVal decFragrancePrice As Decimal)
        _mdecPackagePrice = decPackagePrice
        _mdecFragrancePrice = decFragrancePrice
    End Sub
#End Region

#Region "Public Subprocedures"
    ''' <summary>
    ''' Calculate the price before taxes, the total taxes, and the total (charges + taxes)
    ''' placing them into the corresponding private properties
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub calculate()
        mdecCharges = mdecFragrancePrice + mdecPackagePrice
        mdecTax = mdecCharges * COMBINED_TAX_RATE
        mdecTotal = mdecCharges + mdecTax
    End Sub
#End Region
End Class
