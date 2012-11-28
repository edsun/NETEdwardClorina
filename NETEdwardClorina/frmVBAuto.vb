Public Class frmVBAuto
#Region "Module Level Variables"
    ' Object of clsData Type
    Dim mobjData As New DataTier.clsData

    'Datasets to hold our records
    Dim mdsAllUsedCars As New DataSet
    Dim mdsSingleUsedCar As New DataSet
    Dim mdsAllSalesStaff As New DataSet

    'descendent of the bindingcontext object
    Dim mbmbSalesStaff As BindingManagerBase
    Dim mbmbUsedCars As BindingManagerBase
#End Region

#Region "Class Functions & Procedures"
    ''' <summary>
    ''' Displays the record for the passed stockNo parameter
    ''' </summary>
    ''' <param name="strStockNo"></param>
    ''' <remarks></remarks>
    Private Sub refreshData(ByVal strStockNo As String)
        'Clear out our Used Cars dataSet
        mdsAllUsedCars.Clear()

        'Call our clsData object's getallcars subprocedure
        'store the results in our Used cars dataset
        mdsAllUsedCars = mobjData.getAllCars

        cboStockNo.Text = strStockNo
    End Sub

    ''' <summary>
    ''' Bind our Sales Person Info, and Stock Info controls
    ''' to the appropriate columns in our SalesStaff and UsedCars tables
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub bindData()
        Try
            'Bind our Sales Person Info controls to the appropriate column
            lblSalesPersonIDOutput.DataBindings.Add("text", _
                                                    mdsAllSalesStaff.Tables("SalesStaff"), _
                                                    "SalesID")
            lblSalesPersonNameOutput.DataBindings.Add("text", _
                                                      mdsAllSalesStaff.Tables("SalesStaff"), _
                                                      "SalesPersonName")
            lblDealerCodeOutput.DataBindings.Add("text", _
                                                 mdsAllSalesStaff.Tables("SalesStaff"), _
                                                 "DealerCode")
            'Set our form's SalesStaff BindingManagerBase object to the form's
            'BindingContext property
            mbmbSalesStaff = Me.BindingContext(mdsAllSalesStaff.Tables("SalesStaff"))

            'Bind our Stock Information controls to the appropriate column
            With cboStockNo
                .DataSource = mdsAllUsedCars.Tables("UsedCars")
                .DisplayMember = "StockNo"
            End With
            txtDescription.DataBindings.Add("text", _
                                            mdsAllUsedCars.Tables("UsedCars"), _
                                            "Description")
            txtCostPrice.DataBindings.Add("text", _
                                          mdsAllUsedCars.Tables("UsedCars"), _
                                          "CostPrice")
            txtRetailPrice.DataBindings.Add("text", _
                                            mdsAllUsedCars.Tables("UsedCars"), _
                                            "RetailPrice")
            'Set our form's UsedCars BindingManagerBase object to the form's
            'BindingContext property
            mbmbUsedCars = Me.BindingContext(mdsAllUsedCars.Tables("UsedCars"))
        Catch ex As Exception
            MessageBox.Show("Error in databinding")
        End Try
    End Sub
#End Region

    Private Sub frmVBAuto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'connect to our database
            mobjData.connect()

            'Get our sales people
            mdsAllSalesStaff = mobjData.getSalesStaff

            'Get our used cars
            mdsAllUsedCars = mobjData.getAllCars

            bindData()

        Catch ex As Exception
            sendMessage("Database error on connecting/query", "Database Error")
        End Try
    End Sub

    ''' <summary>
    ''' Go to our next sales person
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        mbmbSalesStaff.Position += 1
        'Clear our commission label
        lblCommissionOutput.Text = ""
    End Sub

    ''' <summary>
    ''' Go to our previous sales person
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        mbmbSalesStaff.Position -= 1

        'Clear our commission label
        lblCommissionOutput.Text = ""
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Try
            'Declare a clsCommission object
            'Use our parameterized constructor to set our cost and retail price
            Dim objCommission As New BusinessTier.clsCommission(Decimal.Parse(txtCostPrice.Text), _
                                                                Decimal.Parse(txtRetailPrice.Text))
            'Calculate our commission
            lblCommissionOutput.Text = FormatCurrency(objCommission.calcCommission())

            'Call our clsData object's getCommission to prepare our clsData datadapter for the next update
            mobjData.getCommission()

            'Update our commissions with the passed parameters
            mobjData.updateCommission(lblSalesPersonNameOutput.Text, _
                                      cboStockNo.Text, _
                                      txtDescription.Text, _
                                      objCommission.calcCommission())
        Catch ex As Exception
            sendMessage("Error calculating commission", "Calculation Error")
        End Try

    End Sub

    ''' <summary>
    ''' Display our commissions form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnViewComm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewComm.Click
        Dim frmDisplay As New frmCommission
        frmDisplay.Show()
    End Sub

    Private Sub TextBoxShared_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles txtCostPrice.Leave, _
                txtDescription.Leave, _
                txtRetailPrice.Leave
        'Create a generic TextBox txtBox
        'Change it to a textBox type
        Dim txtBox As TextBox
        txtBox = CType(sender, TextBox)

        If (txtBox.Text.Length > 0 And txtBox.Modified) Then
            If (txtBox.Name = "txtCostPrice" Or txtBox.Name = "txtRetailPrice") Then
                If (IsNumeric(txtBox.Text)) Then
                Else
                    sendMessage("Value was must be numeric", "Numeric Error")
                    txtBox.Focus()
                    txtBox.SelectAll()
                End If
            End If

            'Create an instance of the Stock Maintenance form using the constructor
            'for existing Used Car Records
            Dim frmStockInstance As New frmStockMaintenance(cboStockNo.Text, txtBox.Name, txtBox.Text)

            'Display the Stock Maintenance form in modal fashion
            frmStockInstance.ShowDialog()
            'Call the refreshData() using the text property of the stockNo comboxbox as the required arguement
            refreshData(cboStockNo.Text)
        End If




    End Sub

    Private Sub cboStockNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboStockNo.Leave
        Dim drAnswer As DialogResult
        'Call our validateNumeric function to check if the user has entered
        'numeric data
        If (validateNumeric(Trim(cboStockNo.Text))) Then
            'Data was numeric

            'Check if the Stock No is a duplicate key
            mdsSingleUsedCar = mobjData.getOneCar(Trim(cboStockNo.Text))

            'Check if the dataset contains data
            If mdsSingleUsedCar.Tables("UsedCars").Rows.Count > 0 Then
                'There was data in the dataset
                'Duplicate key was found

                'Call our refreshData method to display the corresponding
                'record associated with our StockNo
                refreshData(Trim(cboStockNo.Text))
            Else
                'There was no data in the dataset
                'New key

                'Check if the StockNo entered is less than or equal to 7 digits
                If Trim(cboStockNo.Text.Length) <= 7 Then
                    'The StockNo was less than or equal to 7
                    'Prompt the user if they would like to create a new record

                    drAnswer = sendMessage("No value found in the database, would you like to add a new record to the database?", _
                                "Add a new record", _
                                MessageBoxButtons.YesNo)

                    'Check the users response to the messageBox
                    If drAnswer = Windows.Forms.DialogResult.Yes Then

                        'Create an instance of  the Stock Maintenance form
                        'using the constructor for new Used Cars
                        Dim frmStockInstance As New frmStockMaintenance(cboStockNo.Text)

                        'Display the form in modal fashion
                        frmStockInstance.ShowDialog()

                        'When the user exits the form, they have either:
                        'added a new record, or cancelled the operation

                        'Clear our forms module level One Car Dataset
                        mdsSingleUsedCar.Clear()

                        'Call our clsData's getOneCar sub procedure passing the text property
                        'of the combobox and capture the return value in the form
                        'in the forms module level One Car DataSet
                        mdsSingleUsedCar = mobjData.getOneCar(cboStockNo.Text)

                        'If the form's module level One Car DataSet
                        'contains data, then the user completed the insert operation
                        If mdsSingleUsedCar.Tables("UsedCars").Rows.Count > 0 Then
                            'The user completed the operation, call the refreshData function
                            'passing the text from the StockNo combobox as our arguement
                            refreshData(Trim(cboStockNo.Text))
                        Else
                            'The user returned to the form without saving
                            'set the selectedIndex of the combobox to the first record
                            cboStockNo.SelectedIndex = 0
                        End If


                    Else
                        'User selected No, set focus to the comboBox
                        cboStockNo.Focus()

                    End If



                Else
                    'The StockNo was greater than 7
                    'Send a message to the user with an error
                    sendMessage("StockNo cannot be greater than 7 digits", "StockNo Error")
                    'Set focus to our combobox and select all text
                    cboStockNo.Focus()
                    cboStockNo.SelectAll()

                End If


            End If
        Else
            'Data was non numeric

            'There was an error, select all the text in the combobox
            'and set focus to the combobox
            cboStockNo.Focus()
            cboStockNo.SelectAll()
        End If
    End Sub

    ''' <summary>
    ''' Clear out the Commission label
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cboStockNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStockNo.SelectedIndexChanged
        lblCommissionOutput.Text = ""
    End Sub
End Class
