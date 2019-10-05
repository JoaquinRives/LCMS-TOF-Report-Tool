Public Class DeleteForm

    Public dt1 As DataTable
    Public dt2 As DataTable
    Public IndexSelection As Integer


    Public Sub LoadData()

        DataHandlerClass.UnprotectData("Data.zip")

        Try

            'Loading Positives'

            dt1 = New DataTable
            dt1.Columns.Add("CashNumber", GetType(String))
            dt1.Columns.Add("Name", GetType(String))

            If System.IO.File.Exists(MainForm.DataPathPositives) = True Then
                Dim fileReader As System.IO.StreamReader
                fileReader =
                My.Computer.FileSystem.OpenTextFileReader(MainForm.DataPathPositives)
                Dim Line As String

                Do While fileReader.Peek() <> -1
                    Line = fileReader.ReadLine()
                    dt1.Rows.Add(Split(Line, "|")(0), Split(Line, "|")(1))
                Loop

                DataGridView1.DataSource = dt1
                DataGridView1.ClearSelection()

                fileReader.Close()

            Else
                MsgBox("File Does Not Exist")
            End If

            'Loading Negatives'

            dt2 = New DataTable
            dt2.Columns.Add("Cash Number", GetType(String))
            dt2.Columns.Add("Name", GetType(String))

            If System.IO.File.Exists(MainForm.DataPathNegatives) = True Then
                Dim fileReader As System.IO.StreamReader
                fileReader =
                My.Computer.FileSystem.OpenTextFileReader(MainForm.DataPathNegatives)
                Dim Line As String

                Do While fileReader.Peek() <> -1
                    Line = fileReader.ReadLine()
                    dt2.Rows.Add(Split(Line, "|")(0), Split(Line, "|")(1))
                Loop

                DataGridView2.DataSource = dt2
                DataGridView2.ClearSelection()

                fileReader.Close()

            Else
                MsgBox("File Does Not Exist")
            End If

            DataGridView1.Columns(0).ReadOnly = False
            DataGridView1.Columns(1).ReadOnly = True
            DataGridView1.Columns(2).ReadOnly = True

            DataGridView2.Columns(0).ReadOnly = False
            DataGridView2.Columns(1).ReadOnly = True
            DataGridView2.Columns(2).ReadOnly = True


            DataGridView1.Columns(0).Width = 35
            DataGridView1.Columns(1).Width = 100
            DataGridView1.Columns(2).Width = 320

            DataGridView2.Columns(0).Width = 35
            DataGridView2.Columns(1).Width = 100
            DataGridView2.Columns(2).Width = 320

            DataGridView1.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridView1.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridView1.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable

            DataGridView2.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridView2.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            DataGridView2.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable

            TabControl1.Width = (DataGridView1.Columns(0).Width +
                                DataGridView1.Columns(1).Width +
                                DataGridView2.Columns(2).Width + 80)

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        DataHandlerClass.ProtectData("Data.zip")

    End Sub


    Private Sub DeleteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadData()

    End Sub

    Private Sub DeleteSelectionButton_Click(sender As Object, e As EventArgs) Handles DeleteSelectionButton.Click


        MainForm.DataGridView1.Columns.Clear()
        MainForm.DataGridView2.Columns.Clear()
        DataHandlerClass.LoadData()



        Dim Counter1 As Integer = 0 'The counter is to correct the change of index avery time that a item is deleted.
        Dim Counter2 As Integer = 0

        For Each Row As DataGridViewRow In DataGridView1.Rows

            If Row.Cells("Delete1").Value = True Then

                Dim NewDataBaseHandlerClass As New DataHandlerClass
                NewDataBaseHandlerClass.DeleteFromDataBase(Row.Index - Counter1, MainForm.DataGridView1)
                Counter1 += 1

            End If

        Next

        For Each Row As DataGridViewRow In DataGridView2.Rows

            If Row.Cells("Delete2").Value = True Then

                Dim NewDataBaseHandlerClass As New DataHandlerClass
                NewDataBaseHandlerClass.DeleteFromDataBase(Row.Index - Counter2, MainForm.DataGridView2)
                Counter2 += 1


            End If

        Next
        DataHandlerClass.ExportToDataBase()
        DataHandlerClass.DatabaseVersionControl()
        DataHandlerClass.LoadData()
        Me.Close()

    End Sub

    Private Sub CalcelButton_Click(sender As Object, e As EventArgs) Handles DelCancelButton.Click

        Me.Close()

    End Sub
End Class