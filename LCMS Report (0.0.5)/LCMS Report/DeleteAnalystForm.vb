Public Class DeleteAnalystForm
    Private Sub CanButton_Click(sender As Object, e As EventArgs) Handles CanButton.Click
        Me.Close()
    End Sub

    Private Sub DeleteAnalystForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DeleteAnalystComboBox.Text = "Select Analyst"

        For Each analyst As String In MainForm.Analysts.Split("|")

            DeleteAnalystComboBox.Items.Add(analyst)

        Next

    End Sub

    Private Sub DelButton_Click(sender As Object, e As EventArgs) Handles DelButton.Click

        Dim ListAnalysts As New List(Of String)

        For Each Analyst As String In MainForm.Analysts.Split("|")

            ListAnalysts.Add(Analyst)

        Next

        If ListAnalysts.Contains(DeleteAnalystComboBox.Text) Then

            ListAnalysts.Remove(DeleteAnalystComboBox.Text)
            MainForm.AnalystComboBox.Items.Remove(DeleteAnalystComboBox.Text)

        End If

        MainForm.Analysts = String.Join("|", ListAnalysts)

        Me.Close()

    End Sub

End Class