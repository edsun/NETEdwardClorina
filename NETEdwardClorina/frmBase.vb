'variables must be declared before using
Option Explicit On
'variables must be explicitly casted
'if option strict is on, option explicit is automatically on
Option Strict On

Public Class frmBase
#Region "Class Variables"
    'set to true in unit test to suppress the messagebox
    'default false in windows app causes msgbox to display
    Protected mblnTest As Boolean
    'used in unit test to manipulate user respone to msgbox
    Protected mdlgResult As DialogResult
    'used in unit test to represent text in msgbox
    Protected mstrTestString As String
#End Region
#Region "Protected Functions"
    ''' <summary>
    ''' Used to suppress message boxs during testing.
    ''' </summary>
    ''' <param name="text"></param>
    ''' <param name="caption"></param>
    ''' <param name="buttons"></param>
    ''' <param name="icon"></param>
    ''' <param name="defaultButton"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected Function sendMessage(ByVal text As String, _
                                   ByVal caption As String, _
                                   Optional ByVal buttons As MessageBoxButtons = MessageBoxButtons.OK, _
                                   Optional ByVal icon As MessageBoxIcon = MessageBoxIcon.Information, _
                                   Optional ByVal defaultButton As MessageBoxDefaultButton = _
                                   MessageBoxDefaultButton.Button1) As DialogResult

        'Check if we are unit testing
        If mblnTest = True Then
            'unit testing
            mstrTestString = text
            Return mdlgResult
        Else 'We're not unit testing, so display the messagebox.
            Return MessageBox.Show(text, caption, buttons, icon, defaultButton)
        End If
    End Function
#End Region

    ''' <summary>
    ''' Close the Form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class