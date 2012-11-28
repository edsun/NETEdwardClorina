'contains classes capable
'of working with an access database
Imports System.Data.OleDb
Public Class clsData

#Region "Database objects"
    'connection object, estables connection
    'to data source
    'In this case we are connecting to VBAutoSales.db
    Dim mcomAutoSales As OleDbConnection

    'data adapter: contains insert, delete, update
    'and select commands that may be applied to the database

    'All Records from the UsedCars Table
    Dim mdaAllUsedCars As New OleDbDataAdapter
    'A single record from the UsedCarsTable
    Dim mdaSingleUsedCar As New OleDbDataAdapter

    'All records from the SalesStaff Table
    Dim mdaAllSalesStaff As New OleDbDataAdapter

    'All records from the Commissions Table
    Dim mdaAllCommissions As New OleDbDataAdapter

    'dataset: collection of data tables
    'each datatable contains the result set
    'of an sql select command
    'the resultset is disconnected from the data source
    'vendor non specific

    'Holds all the used car records
    Dim mdsAllUsedCars As New DataSet
    'Holds a single used car record
    Dim mdsSingleUsedCar As New DataSet

    'Holds all the sales staff records
    Dim mdsAllSalesStaff As New DataSet

    'Holds all the commission records
    Dim mdsAllCommissions As New DataSet

    'CommandBuilder object to:
    'generate SQL statements for the single used car dataadapter
    Dim mcmdOneCar As New OleDbCommandBuilder
    'generate SQL statements for the all used cars dataadapter
    Dim mcmdAllCars As New OleDbCommandBuilder
    'generate SQL statements for the commission dataadapter
    Dim mcmdCommission As New OleDbCommandBuilder


#End Region

#Region "Class Functions & Procedures"
    ''' <summary>
    ''' Connects to our database using our OleDBConnection object
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub connect()
        Try
            mcomAutoSales = New OleDbConnection("provider = Microsoft.Jet.OLEDB.4.0; data source = VBAutoSales.mdb")
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Selects all the sales staff in the SalesStaff table and fills our dataset
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getSalesStaff() As DataSet
        Try
            mdaAllSalesStaff.SelectCommand = New OleDbCommand
            mdaAllSalesStaff.SelectCommand.Connection = mcomAutoSales
            mdaAllSalesStaff.SelectCommand.CommandText = "SELECT * FROM SalesStaff"

            'populates the dataset with data based on
            'the select command
            '"customers" is a handle that may be used
            'to refer to the specific result set within the
            'dataset
            mdaAllSalesStaff.Fill(mdsAllSalesStaff, "SalesStaff")

            Return mdsAllSalesStaff

        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Get all the used cars from the UsedCars table, filling our dataset and creating
    ''' the SQL insert, delete and update statements
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getAllCars() As DataSet
        Try
            mdaAllUsedCars.SelectCommand = New OleDbCommand
            mdaAllUsedCars.SelectCommand.Connection = mcomAutoSales
            mdaAllUsedCars.SelectCommand.CommandText = "SELECT * FROM UsedCars"

            'populates the dataset with data based on
            'the select command
            '"customers" is a handle that may be used
            'to refer to the specific result set within the
            'dataset
            mdaAllUsedCars.Fill(mdsAllUsedCars, "UsedCars")

            mcmdAllCars = New OleDbCommandBuilder(mdaAllUsedCars)

            Return mdsAllUsedCars
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Searchs the database for the passed StockNo
    ''' </summary>
    ''' <param name="strStockNo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getOneCar(ByVal strStockNo As String) As DataSet
        'Clear the dataset to make sure no data from the previous call is present
        mdsSingleUsedCar.Clear()

        Try
            mdaSingleUsedCar.SelectCommand = New OleDbCommand
            mdaSingleUsedCar.SelectCommand.Connection = mcomAutoSales
            mdaSingleUsedCar.SelectCommand.CommandText = "SELECT * FROM UsedCars WHERE StockNo = '" & strStockNo & "'"

            'populates the dataset with data based on
            'the select command
            '"customers" is a handle that may be used
            'to refer to the specific result set within the
            'dataset
            mdaSingleUsedCar.Fill(mdsSingleUsedCar, "UsedCars")

            mcmdOneCar = New OleDbCommandBuilder(mdaSingleUsedCar)

            Return mdsSingleUsedCar
        Catch ex As Exception
            Throw
        End Try

    End Function

    ''' <summary>
    ''' Grab all the commissions from the Commissions Table
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getCommission() As DataSet
        Try
            mdaAllCommissions.SelectCommand = New OleDbCommand
            mdaAllCommissions.SelectCommand.Connection = mcomAutoSales
            mdaAllCommissions.SelectCommand.CommandText = "SELECT * FROM Commissions"

            'populates the dataset with data based on
            'the select command
            '"customers" is a handle that may be used
            'to refer to the specific result set within the
            'dataset
            mdaAllCommissions.Fill(mdsAllCommissions, "Commissions")

            mcmdCommission = New OleDbCommandBuilder(mdaAllCommissions)

            Return mdsAllCommissions
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Add a new row to the commissions table using the passed parameters
    ''' </summary>
    ''' <param name="strSalesPersonName"></param>
    ''' <param name="strStockNo"></param>
    ''' <param name="strDescription"></param>
    ''' <param name="decCalcCommission"></param>
    ''' <remarks></remarks>
    Public Sub updateCommission(ByVal strSalesPersonName As String, _
                                ByVal strStockNo As String, _
                                ByVal strDescription As String, _
                                ByVal decCalcCommission As Decimal)
        'Create a new DataRow object which we will use to add a new row to our table
        Dim drNewCommission As DataRow

        'Place our passed parameters into the correct columns
        drNewCommission = mdsAllCommissions.Tables("Commissions").NewRow
        drNewCommission("SalesPersonName") = strSalesPersonName
        drNewCommission("StockNo") = strStockNo
        drNewCommission("Description") = strDescription
        drNewCommission("Commission") = decCalcCommission

        mdsAllCommissions.Tables("Commissions").Rows.Add(drNewCommission)

        'Make the new row permanent by updating the table
        Try
            mdaAllCommissions.Update(mdsAllCommissions, "Commissions")
        Catch ex As Exception
            Throw
        End Try
    End Sub

    ''' <summary>
    ''' Add a new car to our UsedCars table using the passed parameters
    ''' </summary>
    ''' <param name="strStockNo"></param>
    ''' <param name="intManuYear"></param>
    ''' <param name="strDescription"></param>
    ''' <param name="strModel"></param>
    ''' <param name="strColor"></param>
    ''' <param name="decCostPrice"></param>
    ''' <param name="decRetailPrice"></param>
    ''' <remarks></remarks>
    Public Sub updateNewCar(ByVal strStockNo As String, _
                            ByVal intManuYear As Integer, _
                            ByVal strDescription As String, _
                            ByVal strModel As String, _
                            ByVal strColor As String, _
                            ByVal decCostPrice As Decimal, _
                            ByVal decRetailPrice As Decimal)
        'Create a new DataRow object to add a new row to our table
        Dim drNewCar As DataRow

        'Place our passed parameters into the correct columns
        drNewCar = mdsAllUsedCars.Tables("UsedCars").NewRow
        drNewCar("StockNo") = strStockNo
        drNewCar("ManufacturedYear") = intManuYear
        drNewCar("Description") = strDescription
        drNewCar("Model") = strModel
        drNewCar("Color") = strColor
        drNewCar("CostPrice") = decCostPrice
        drNewCar("RetailPrice") = decRetailPrice

        mdsAllUsedCars.Tables(0).Rows.Add(drNewCar)

        'Make the new row permanent by updating the table
        Try
            mdaAllUsedCars.Update(mdsAllUsedCars, "UsedCars")
        Catch ex As Exception
            Throw
        End Try

    End Sub

    ''' <summary>
    ''' Update the database with the passed dataset
    ''' </summary>
    ''' <param name="dsOneCar"></param>
    ''' <remarks></remarks>
    Public Sub updateOneCar(ByVal dsOneCar As DataSet)
        Try
            mdaSingleUsedCar.Update(dsOneCar, "UsedCars")
        Catch ex As Exception
            Throw
        End Try
    End Sub
#End Region
End Class
