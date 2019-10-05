Public Class AddForm

    Dim NewCasNumber As String
    Dim NewName As String
    Dim NewUnits As Boolean
    Dim NewPositiveIon As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        NewCasNumber = CasTextBox.Text
        NewName = NameTextBox.Text
        NewUnits = UnitsRadioButton.Checked
        NewPositiveIon = PositiveRadioButton.Checked

        If Not (String.IsNullOrWhiteSpace(NewCasNumber)) And Not (String.IsNullOrWhiteSpace(NewName)) Then

            DataHandlerClass.AddToDatabase(NewCasNumber, NewName, NewUnits, NewPositiveIon)

            DataHandlerClass.DatabaseVersionControl()

            DataHandlerClass.LoadData()

            Me.Close()

        Else

            MessageBox.Show("Error: Empty Field")

        End If
    End Sub

    Private Sub AddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles AddCancelButton.Click

        Me.Close()

    End Sub
End Class