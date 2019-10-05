Public Class AddAnalystForm
    Private Sub CanButton_Click(sender As Object, e As EventArgs) Handles CanButton.Click
        Me.Close()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        If Not String.IsNullOrWhiteSpace(NewAnalystTextBox.Text) Then

            MainForm.Analysts = MainForm.Analysts & "|" & NewAnalystTextBox.Text.Trim()
            MainForm.AnalystComboBox.Items.Add(NewAnalystTextBox.Text.Trim())

            Me.Close()

        End If

    End Sub

    Private Sub AddAnalystForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class