Public Class PasswordForm


    Public Access As String

    Public Sub New(access)

        InitializeComponent()
        Me.Access = access

    End Sub

    Private Sub PasswordButton_Click(sender As Object, e As EventArgs) Handles PasswordButton.Click


        Dim Input As String = PasswordTextBox.Text

        If Input = DataHandlerClass.Password Then


            Select Case Access

                Case "AddForm"
                    Dim NewAddForm As New AddForm()
                    NewAddForm.Show()

                Case "DeleteForm"

                    Dim NewDeleteForm As New DeleteForm()
                    NewDeleteForm.Show()

                Case "ChangePassword"

                    Dim NewChangePasswordForm As New ChangePasswordForm()
                    NewChangePasswordForm.Show()

            End Select

        Else

            MessageBox.Show("Invalid Password")

        End If

        Me.Close()

    End Sub

    Private Sub PasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class