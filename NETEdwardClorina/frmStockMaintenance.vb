Public Class frmStockMaintenance
#Region "Module Level Variables"
    'Boolean indicating whether the current record is:
    'True if new
    'False if existing
    Dim mblnNewRecord As Boolean

    'Boolean to determine if all our textboxes contain data
    Dim mblnAllData As Boolean

    'Grab the modified values from the VB Auto commission form
    Dim mstrTxtName As String
    Dim mstrTxtValue As String

    'Modified stockNo of the new or existing record
    Dim mstrStockNo As String

    'Datasets to hold our values
    Dim mdsSingleCar As DataSet
    Dim mdsAllCars As DataSet

    'Binding Manager associated with the form's One Car Dataset
    Dim mbmbOneCar As BindingManagerBase

    'clsData object
    Dim mobjData As New DataTier.clsData

#End Region

#Region "Class Functions & Procedures"
    ''' <summary>
    ''' Bind our various controls to the form's One Car dataSet
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub bindData()
        'Since this will be run each time the form is activated
        'It is important to clear any previous databindings before setting new ones
        For Each ctrl As Control In Me.Controls
            ctrl.DataBindings.Clear()
        Next

        'Bind our Controls to the proper columns
        lblStockNoOutput.DataBindings.Add("text", _
                                          mdsSingleCar.Tables("UsedCars"), _
                                          "StockNo")
        txtDescription.DataBindings.Add("text", _
                                        mdsSingleCar.Tables("UsedCars"), _
                                        "Description")
        txtCostPrice.DataBindings.Add("text", _
                                      mdsSingleCar.Tables("UsedCars"), _
                                      "CostPrice")
        txtRetailPrice.DataBindings.Add("text", _
                                        mdsSingleCar.Tables("UsedCars"), _
                                        "RetailPrice")
        txtYear.DataBindings.Add("text", _
                                 mdsSingleCar.Tables("UsedCars"), _
                                 "ManufacturedYear")
        txtModel.DataBindings.Add("text", _
                                  mdsSingleCar.Tables("UsedCars"), _
                                  "Model")
        txtColour.DataBindings.Add("text", _
                                   mdsSingleCar.Tables("UsedCars"), _
                                   "Color")

        'Set the BindingManager to the form's BindingContext property
        mbmbOneCar = Me.BindingContext(mdsSingleCar.Tables("UsedCars"))
    End Sub
#End Region

#Region "Constructors"
    ''' <summary>
    ''' Parameterized constructor that accepts a new Stock No
    ''' </summary>
    ''' <param name="strStockNo">New Stock No</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal strStockNo As String)
        'Call VB's InitializeComponent Method to ensure
        'that all inherited objects (visual & non visual) are initialized
        InitializeComponent()

        'Set our stock no label to the passed stock no
        lblStockNoOutput.Text = strStockNo

        'This is a new record
        mblnNewRecord = True

        'Disable the update button
        btnUpdate.Enabled = False

    End Sub

    ''' <summary>
    ''' Parameterized constructor used when an existing record is found.
    ''' </summary>
    ''' <param name="strStockNo">StockNo</param>
    ''' <param name="strColumnName">Column Name changed</param>
    ''' <param name="strValue">Column value changed</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal strStockNo As String, ByVal strColumnName As String, ByVal strValue As String)
        'Call VB's InitializeComponent Method to ensure
        'that all inherited objects (visual & non visual) are initialized
        InitializeComponent()

        'Set our stockNo label to the passed StockNo
        'Also set our module level StockNo variable to the passed parameter
        lblStockNoOutput.Text = strStockNo
        mstrStockNo = strStockNo

        'Set our module level column name & column value variables
        'to the passed parameters
        mstrTxtName = strColumnName
        mstrTxtValue = strValue

        'This is an existing record
        mblnNewRecord = False
    End Sub
#End Region

    ''' <summary>
    ''' Loads when our form is activated
    ''' connects to the database, determines if the record is new or existing
    ''' based on this, will populate our controls
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmStockMaintenance_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            'Call our clsData's connect sub procedure to connect to our database
            mobjData.connect()

            'Check the module level boolean variable
            'for either a new record, or existing record
            If mblnNewRecord Then
                'New Record
                'get all the records from the UsedCarsTable
                'Placing the return into our module level AllCars DataSet
                mdsAllCars = mobjData.getAllCars

                'Change the text property of our button to "Add"
                btnUpdate.Text = "Add"

                'Set focus to the description TextBox
                txtDescription.Focus()

            Else
                'Existing Record
                'get a single car record and place the return
                'into our One Car Dataset, using our module level StockNo as the arguement
                mdsSingleCar = mobjData.getOneCar(mstrStockNo)

                'Bind our controls
                bindData()

                'Determine which of the columns has changed based on the module level variable representing
                'the name of the changed column
                Select Case mstrTxtName
                    Case txtDescription.Name
                        txtDescription.Text = mstrTxtValue
                    Case txtCostPrice.Name
                        txtCostPrice.Text = mstrTxtValue
                    Case txtRetailPrice.Name
                        txtRetailPrice.Text = mstrTxtValue
                    Case txtYear.Name
                        txtYear.Text = mstrTxtValue
                    Case txtModel.Name
                        txtModel.Text = mstrTxtValue
                    Case txtColour.Name
                        txtColour.Text = mstrTxtValue
                    Case Else
                        txtDescription.Focus()
                End Select


            End If
        Catch ex As Exception
            sendMessage(ex.Message, "Error")
        End Try
    End Sub

    ''' <summary>
    ''' Shared textbox event to handle when the user tabs (leaves) a textbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtShared_Leave(ByVal sender As Object, ByVal e As System.EventArgs) _
        Handles txtDescription.Leave, _
                txtCostPrice.Leave, _
                txtRetailPrice.Leave, _
                txtYear.Leave, _
                txtModel.Leave, _
                txtColour.Leave

        'Create a generic TextBox txtBox
        'Change it to a textBox type
        Dim txtBox As TextBox
        txtBox = CType(sender, TextBox)

        'Determine which textbox lost focus
        Select Case txtBox.Name
            Case txtDescription.Name
                If Trim(txtBox.Text).Length > 0 Or txtBox.Text = "" Then
                    mblnAllData = True
                Else : mblnAllData = False
                End If
            Case txtCostPrice.Name
                'Check if the value in the textbox is numeric
                If validateNumeric(txtBox.Text) Then
                    'value was numeric
                    If Trim(txtBox.Text).Length > 0 Or txtBox.Text = "" Then
                        mblnAllData = True
                    Else : mblnAllData = False
                    End If
                Else
                    'Value was not numeric
                    txtBox.SelectAll()
                    txtBox.Focus()
                End If

            Case txtRetailPrice.Name
                'Check if the value in the textbox is numeric
                If validateNumeric(txtBox.Text) Then
                    'value was numeric
                    If Trim(txtBox.Text).Length > 0 Or txtBox.Text = "" Then
                        mblnAllData = True
                    Else : mblnAllData = False
                    End If
                Else
                    'Value was not numeric
                    txtBox.SelectAll()
                    txtBox.Focus()
                End If

            Case txtYear.Name
                'Check if the value in the textbox is numeric
                If validateNumeric(txtBox.Text) Then
                    'Since it was the year textbox
                    'we need further validation
                    If txtBox.Text.Length <> 4 Then
                        'Text within our textbox was not 4 digits long
                        'send a message and select all & focus on our textbox
                        sendMessage("Year must be 4 digits long.", "Year Error")
                        txtBox.SelectAll()
                        txtBox.Focus()

                    End If
                Else
                    'Value was not numeric
                    txtBox.SelectAll()
                    txtBox.Focus()
                End If

            Case txtModel.Name
                If Trim(txtBox.Text).Length > 0 Or txtBox.Text = "" Then
                    mblnAllData = True
                Else : mblnAllData = False
                End If

            Case txtColour.Name

                If Trim(txtBox.Text).Length > 0 Or txtBox.Text = "" Then
                    mblnAllData = True
                Else : mblnAllData = False
                End If

        End Select

        'Check our module level variable AllData
        'to see if all data is present in our text boxes
        If txtDescription.Text.Length > 0 And _
            txtCostPrice.Text.Length > 0 And _
            txtRetailPrice.Text.Length > 0 And _
            txtYear.Text.Length > 0 And _
            txtModel.Text.Length > 0 And _
            txtColour.Text.Length > 0 Then

            btnUpdate.Enabled = True
        Else
            btnUpdate.Enabled = False
        End If

    End Sub

    ''' <summary>
    ''' Used to update the UsedCars table in the VBAutoSales database
    ''' with the information currently displayed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            'determine if this is a new record, or an existing record
            If mblnNewRecord Then
                'New Record
                mobjData.updateNewCar(lblStockNoOutput.Text, _
                                      Integer.Parse(txtYear.Text), _
                                      txtDescription.Text, _
                                      txtModel.Text, txtColour.Text, _
                                      Decimal.Parse(txtCostPrice.Text), _
                                      Decimal.Parse(txtRetailPrice.Text))

                'Close our form
                Me.Close()
            Else
                'Existing Record
                'End the current edit
                mbmbOneCar.EndCurrentEdit()

                'Call the updateOneCar method
                'Passing our singlecar dataset as the arguement
                mobjData.updateOneCar(mdsSingleCar)

                'Close our form
                Me.Close()
            End If

        Catch ex As Exception
            sendMessage("error inserting/updating records", "Database Error")
        End Try

    End Sub
End Class
