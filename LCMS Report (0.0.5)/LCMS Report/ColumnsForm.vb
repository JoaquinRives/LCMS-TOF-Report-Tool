Public Class ColumnsForm
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NumericUpDown1.Value = Integer.Parse(MainForm.WidthColumns.Split(",")(0))
        NumericUpDown2.Value = Integer.Parse(MainForm.WidthColumns.Split(",")(1))
        NumericUpDown3.Value = Integer.Parse(MainForm.WidthColumns.Split(",")(2))
        NumericUpDown4.Value = Integer.Parse(MainForm.WidthColumns.Split(",")(3))

    End Sub

    Private Sub CanButton_Click(sender As Object, e As EventArgs) Handles CanButton.Click

        Me.Close()

    End Sub

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click

        MainForm.WidthColumns = NumericUpDown1.Value.ToString() & "," &
                                NumericUpDown2.Value.ToString() & "," &
                                NumericUpDown3.Value.ToString() & "," &
                                NumericUpDown4.Value.ToString()

        MainForm.DataGridView1.Columns(0).Width = MainForm.WidthColumns.Split(",")(0)
        MainForm.DataGridView1.Columns(1).Width = MainForm.WidthColumns.Split(",")(1)
        MainForm.DataGridView1.Columns(2).Width = MainForm.WidthColumns.Split(",")(2)
        MainForm.DataGridView1.Columns(3).Width = MainForm.WidthColumns.Split(",")(3)
        MainForm.DataGridView2.Columns(0).Width = MainForm.WidthColumns.Split(",")(0)
        MainForm.DataGridView2.Columns(1).Width = MainForm.WidthColumns.Split(",")(1)
        MainForm.DataGridView2.Columns(2).Width = MainForm.WidthColumns.Split(",")(2)
        MainForm.DataGridView2.Columns(3).Width = MainForm.WidthColumns.Split(",")(3)

        MainForm.TabControl1.Width = (MainForm.DataGridView1.Columns(0).Width +
                                MainForm.DataGridView1.Columns(1).Width +
                                MainForm.DataGridView1.Columns(2).Width +
                                MainForm.DataGridView1.Columns(3).Width + 74)

    End Sub
End Class