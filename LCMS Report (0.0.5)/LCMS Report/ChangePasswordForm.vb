Public Class ChangePasswordForm
    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click

        If TextBox1.Text = TextBox2.Text Then

            If TextBox1.Text.Length >= 6 Then

                DataHandlerClass.Password = TextBox1.Text
                MessageBox.Show("Password Changed")
                Me.Close()

            Else

                MessageBox.Show("Invalid Password: Password must be at least 6 characters long.")

            End If

        Else

            MessageBox.Show("Error: Password does not macht.")

        End If

    End Sub

    Private Sub ChangePasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CanButton_Click(sender As Object, e As EventArgs) Handles CanButton.Click

        Me.Close()

    End Sub
End Class