#Region "imports"
'provides the streamreader class needed for
'reading input files
Imports System.IO
'allows us to locate the files in the resource
'directory without any hard-coded pathing
Imports System.Reflection
#End Region

Public Class frmCarWash
#Region "Class Variables"
    Structure FragranceStruct
        Dim strDesc As String
        Dim decPrice As Decimal
    End Structure

    'Module level array to hold all the fragrances (assuming no additionals will be added)
    Dim mfrsFragrances(5) As FragranceStruct

    'Module level Dynamic Arrays to hold the contents of the following files:
    'Interior.txt, Exterior.txt, PkgPrices.txt
    Dim mstrInterior() As String
    Dim mstrExterior() As String
    Dim mdecPrices() As Decimal

    Dim mstrTextFiles() As String = {"Interior.txt", "Exterior.txt", "FragPrices.txt", "FragDesc.txt", "PkgDesc.txt", "PkgPrices.txt"}
#End Region

#Region "Public Subprocedures"

    ''' <summary>
    ''' Reads in a file and places it into the proper array or combobox.
    ''' </summary>
    ''' <param name="strFileName">Current file to be read in</param>
    ''' <remarks></remarks>
    Public Sub readFiles(ByVal strFileName As String)
        'Holds the upper limit of the dynamic arrays
        Dim intIndex As Integer = -1
        'Assembly: a resuable, versionable, self-describing
        'element of the CLR.  Contains metadata about
        'the application - including the assembly name
        Dim objAssembly As Assembly

        'populates assembly object with
        'attributes and methods of the currently
        'executing assembly (application)
        objAssembly = Assembly.GetExecutingAssembly()

        'Dynamically store the namespace
        Dim strNamespace As String
        strNamespace = objAssembly.GetName().Name

        'Create some variables we will use to store output from the files
        Dim strDesc As String
        Dim decPrice As Decimal

        Try
            Dim srFileReader As New StreamReader( _
            objAssembly.GetManifestResourceStream( _
                strNamespace & "." & strFileName))

            'Use a case statement to check which file is being opened.
            'Interior.txt, Exterior.txt, FragPrices.txt, FragDesc.txt, PkgDesc.txt, PkgPrices.txt
            Select Case strFileName

                'Interior.txt
                Case mstrTextFiles(0).ToString
                    Do While srFileReader.Peek <> -1
                        'Increase the size of the upper index
                        intIndex += 1

                        'Make room in the dynamic array for the new item
                        ReDim Preserve mstrInterior(intIndex)
                        'Grab the 
                        strDesc = srFileReader.ReadLine

                        mstrInterior(intIndex) = strDesc
                    Loop

                    'Exterior.txt
                Case mstrTextFiles(1).ToString
                    Do While srFileReader.Peek <> -1
                        'Increase the size of the upper index
                        intIndex += 1

                        'Make room in the dynamic array for the new item
                        ReDim Preserve mstrExterior(intIndex)
                        'Grab the 
                        strDesc = srFileReader.ReadLine

                        mstrExterior(intIndex) = strDesc
                    Loop

                    'FragPrices.txt
                Case mstrTextFiles(2).ToString
                    Do While srFileReader.Peek <> -1
                        'Increase the size of the upper index
                        intIndex += 1

                        'Parse the current line of the file as a decimal
                        decPrice = Decimal.Parse(srFileReader.ReadLine)

                        'Place the current price into the fragrances structure
                        mfrsFragrances(intIndex).decPrice = decPrice
                    Loop

                    'FragDesc.txt
                Case mstrTextFiles(3).ToString
                    Do While srFileReader.Peek <> -1
                        'Increase the size of the upper index
                        intIndex += 1

                        'Load the current line from the file
                        strDesc = srFileReader.ReadLine

                        'Place the current description into the structure
                        mfrsFragrances(intIndex).strDesc = strDesc
                        'Place the current description into the combobox
                        cboFragrance.Items.Add(strDesc)
                    Loop

                    'PkgDesc.txt
                Case mstrTextFiles(4).ToString
                    Do While srFileReader.Peek <> -1
                        'Load the current line from the file
                        'store it in an intermediate variable
                        strDesc = srFileReader.ReadLine

                        'Load the current line into the combobox
                        cboDetail.Items.Add(strDesc)
                    Loop

                    'PkgPrices.txt
                Case mstrTextFiles(5).ToString
                    Do While srFileReader.Peek <> -1
                        'Increase the size of the upper index
                        intIndex += 1

                        'Make room in the dynamic array for the new item
                        ReDim Preserve mdecPrices(intIndex)

                        'Parse the current line as a decimal
                        decPrice = Decimal.Parse(srFileReader.ReadLine)

                        'Place the current line into the dynamic array
                        mdecPrices(intIndex) = decPrice
                    Loop
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "Private Functions"
    ''' <summary>
    ''' Searches for the description Pine in the cbo
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function resetFrag() As Integer
        Dim intIndex As Integer
        Dim blnFound As Boolean

        For intIndex = 0 To cboFragrance.Items.Count - 1
            If cboFragrance.Items(intIndex).ToString.ToLower = "pine" Then
                blnFound = True

                'exit the for loop
                Exit For
            End If
        Next

        If Not blnFound Then
            Return -1
        Else
            Return intIndex
        End If
    End Function

    ''' <summary>
    ''' Searches through the fragrance structure for the passed selected fragrance
    ''' </summary>
    ''' <param name="strSelectedFrag">The Fragrance description to find</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getFragIndex(ByVal strSelectedFrag As String) As Integer
        Dim intIndex As Integer
        Dim blnFound As Boolean

        'Loop through until the selected fragrance is found
        For intIndex = 0 To mfrsFragrances.Length - 1
            If mfrsFragrances(intIndex).strDesc.ToLower = strSelectedFrag.ToLower Then
                blnFound = True

                'exit the for loop
                Exit For
            End If
        Next

        If blnFound Then
            Return intIndex
        Else
            Return -1
        End If
    End Function
#End Region
#Region "Form Events"
    ''' <summary>
    ''' Loops through all the files and loads them into the proper arrays/comboboxs.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmCarWash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Loop through the textfiles array
        'to read through every file
        For Each strFileName As String In mstrTextFiles
            readFiles(strFileName)
        Next

        'Set the details combobox to 0
        cboDetail.SelectedIndex = 0

        'Set the current index for the Fragrance combobox to Pine
        cboFragrance.SelectedIndex = resetFrag()
    End Sub

    ''' <summary>
    ''' Shared combobox procedure to handle index changes for both.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles cboDetail.SelectedIndexChanged, _
                cboFragrance.SelectedIndexChanged

        'Create a generic combobox
        Dim comboBox As ComboBox = CType(sender, ComboBox)
        Try
            Dim intIndex As Integer
            Dim intFrag As Integer

            If comboBox.Name = cboDetail.Name Then
                'reset the Fragrance combobox back to pine
                cboFragrance.SelectedIndex = resetFrag()
                'clear both lists
                lstInterior.Items.Clear()
                lstExterior.Items.Clear()

                For intIndex = 0 To comboBox.SelectedIndex
                    lstInterior.Items.Add(mstrInterior(intIndex))
                    lstExterior.Items.Add(mstrExterior(intIndex))
                Next

                lstInterior.Items(0) = "Fragrance - " & cboFragrance.SelectedItem.ToString

            Else
                If lstInterior.Items.Count > 0 Then
                    lstInterior.Items(0) = "Fragrance -" & cboFragrance.SelectedItem.ToString
                End If
            End If

            'Grab the price of the current selected fragrance
            intFrag = getFragIndex(cboFragrance.SelectedItem.ToString)

            'Create an instance of the clsCharges class
            Dim clsCharges As BusinessTier.clsCharges = New BusinessTier.clsCharges( _
                                                        mdecPrices(cboDetail.SelectedIndex), _
                                                        mfrsFragrances(intFrag).decPrice)

            'Calculate the charges
            clsCharges.calculate()

            'Output to the proper labels with Currency formatting
            lblChargesOutput.Text = FormatCurrency(clsCharges.getCharges)
            lblTaxesOutput.Text = FormatCurrency(clsCharges.getTaxes)
            lblTotalOutput.Text = FormatCurrency(clsCharges.getTotal)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    ''' <summary>
    ''' Initialize the comboboxes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cboDetail.SelectedIndex = 0
        cboFragrance.SelectedIndex = resetFrag()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
#End Region
End Class
