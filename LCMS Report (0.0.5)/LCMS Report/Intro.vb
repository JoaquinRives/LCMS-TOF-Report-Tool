Public Class Intro
    Private Sub Intro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Me.Close()
        MainForm.RetrieveLastSession()


    End Sub


End Class