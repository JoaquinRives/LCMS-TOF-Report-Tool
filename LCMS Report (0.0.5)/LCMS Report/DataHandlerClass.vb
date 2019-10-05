Public Class DataHandlerClass


    Public Shared Password As String

    Public Shared dt1 As DataTable
    Public Shared dt2 As DataTable


    Public Shared Sub DatabaseVersionControl()

        'This function will change the Version Number every time that
        'an analyte is added or deleted from the database.

        Dim ActualVersion As String = MainForm.DictSettings("DataBaseVersion")

        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim Num3 As Integer
        Dim NewVersion As String

        Num1 = Integer.Parse(ActualVersion.Split(".")(0))
        Num2 = Integer.Parse(ActualVersion.Split(".")(1))
        Num3 = Integer.Parse(ActualVersion.Split(".")(2))

        Num3 += 1

        If Num3 > 99 Then
            Num3 = 0
            Num2 += 1

            If Num2 > 99 Then
                Num2 = 0
                Num1 += 1
            End If

        End If

        NewVersion = Num1.ToString() & "." & Num2.ToString() & "." & Num3.ToString()
        MainForm.DictSettings("DataBaseVersion") = NewVersion
        MainForm.VersionLabel.Text = NewVersion

    End Sub


    Public Shared Sub LoadData()

        UnprotectData("Data.zip")

        Try

            'Loading DataGridView 1 with positive analites'

            dt1 = New DataTable
            dt1.Columns.Add("CashNumber", GetType(String))
            dt1.Columns.Add("Name", GetType(String))
            dt1.Columns.Add("Result", GetType(String))
            dt1.Columns.Add("Units", GetType(String))


            If System.IO.File.Exists(MainForm.DataPathPositives) = True Then
                Dim fileReader As System.IO.StreamReader
                fileReader =
                My.Computer.FileSystem.OpenTextFileReader(MainForm.DataPathPositives)
                Dim Line As String

                Do While fileReader.Peek() <> -1
                    Line = fileReader.ReadLine()
                    dt1.Rows.Add(Split(Line, "|"))
                Loop

                MainForm.DataGridView1.DataSource = dt1
                fileReader.Close()

            Else
                MsgBox("File Does Not Exist")
            End If

            'Loading DataGridView 2 with negative analytes'

            dt2 = New DataTable
            dt2.Columns.Add("CashNumber", GetType(String))
            dt2.Columns.Add("Name", GetType(String))
            dt2.Columns.Add("Result", GetType(String))
            dt2.Columns.Add("Units", GetType(String))


            If System.IO.File.Exists(MainForm.DataPathNegatives) = True Then
                Dim fileReader As System.IO.StreamReader
                fileReader =
                My.Computer.FileSystem.OpenTextFileReader(MainForm.DataPathNegatives)
                Dim Line As String

                Do While fileReader.Peek() <> -1
                    Line = fileReader.ReadLine()
                    dt2.Rows.Add(Split(Line, "|"))
                Loop

                MainForm.DataGridView2.DataSource = dt2
                fileReader.Close()

            Else
                MsgBox("File Does Not Exist")
            End If

            MainForm.DataGridView1.Columns(0).ReadOnly = True
            MainForm.DataGridView1.Columns(1).ReadOnly = True
            MainForm.DataGridView1.Columns(3).ReadOnly = True
            MainForm.DataGridView2.Columns(0).ReadOnly = True
            MainForm.DataGridView2.Columns(1).ReadOnly = True
            MainForm.DataGridView2.Columns(3).ReadOnly = True

            MainForm.DataGridView1.Columns(0).Width = MainForm.WidthColumns.Split(",")(0)
            MainForm.DataGridView1.Columns(1).Width = MainForm.WidthColumns.Split(",")(1)
            MainForm.DataGridView1.Columns(2).Width = MainForm.WidthColumns.Split(",")(2)
            MainForm.DataGridView1.Columns(3).Width = MainForm.WidthColumns.Split(",")(3)
            MainForm.DataGridView2.Columns(0).Width = MainForm.WidthColumns.Split(",")(0)
            MainForm.DataGridView2.Columns(1).Width = MainForm.WidthColumns.Split(",")(1)
            MainForm.DataGridView2.Columns(2).Width = MainForm.WidthColumns.Split(",")(2)
            MainForm.DataGridView2.Columns(3).Width = MainForm.WidthColumns.Split(",")(3)

            MainForm.DataGridView1.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            MainForm.DataGridView1.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            MainForm.DataGridView1.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            MainForm.DataGridView1.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
            MainForm.DataGridView2.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            MainForm.DataGridView2.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            MainForm.DataGridView2.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
            MainForm.DataGridView2.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable

            MainForm.DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            MainForm.DataGridView2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            MainForm.TabControl1.Width = (MainForm.DataGridView1.Columns(0).Width +
                                MainForm.DataGridView1.Columns(1).Width +
                                MainForm.DataGridView1.Columns(2).Width +
                                MainForm.DataGridView1.Columns(3).Width + 67)

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        ProtectData("Data.zip")

        MainForm.SetTheme(MainForm.Theme)

    End Sub

    Public Shared Sub ProtectData(database As String)

        'Protecting data by compresing it in a Zip File with Password.
        If database = "Data.zip" Then

            Try
                Using zip As Ionic.Zip.ZipFile = New Ionic.Zip.ZipFile

                    zip.Password = "qwerty"
                    zip.AddFile(MainForm.DataPathPositives, "")
                    zip.AddFile(MainForm.DataPathNegatives, "")

                    zip.Save(MainForm.MainPath & "\Data.zip")
                End Using
            Catch ex1 As Exception
                Console.Error.WriteLine("exception: {0}", ex1.ToString)
            End Try

            My.Computer.FileSystem.DeleteFile(MainForm.DataPathPositives)
            My.Computer.FileSystem.DeleteFile(MainForm.DataPathNegatives)

        End If


        If database = "AppSettings.zip" Then

            Try

                Using zip As Ionic.Zip.ZipFile = New Ionic.Zip.ZipFile

                    zip.Password = "qwerty"
                    zip.AddFile(MainForm.DataPathSettings, "")

                    zip.Save(MainForm.MainPath & "\AppSettings.zip")
                End Using
            Catch ex1 As Exception
                Console.Error.WriteLine("exception: {0}", ex1.ToString)
            End Try

            My.Computer.FileSystem.DeleteFile(MainForm.DataPathSettings)

        End If


    End Sub

    Public Shared Sub UnprotectData(database As String)

        Using zip As New Ionic.Zip.ZipFile(MainForm.MainPath & "\" & database)
            Dim o As Ionic.Zip.ZipEntry
            For Each o In zip
                If (o.UsesEncryption) Then
                    o.ExtractWithPassword("qwerty")
                Else
                    o.Extract()
                End If
            Next
        End Using

    End Sub


    Public Shared Sub ExportToDataBase()

        'Exporting positve analites to the Database-CSVfile'

        UnprotectData("Data.zip") 'UnZiping the .csv file protected with password

        System.IO.File.Create(MainForm.DataPathPositives).Dispose()

        Dim file1 As System.IO.StreamWriter
        file1 = My.Computer.FileSystem.OpenTextFileWriter(MainForm.DataPathPositives, True)

        Dim CashNumber As String
        Dim Name As String
        Dim Result As String
        Dim Units As String


        For row As Int32 = 0 To MainForm.DataGridView1.Rows.Count() - 1

            CashNumber = MainForm.DataGridView1.Rows(row).Cells("CashNumber").FormattedValue
            Name = MainForm.DataGridView1.Rows(row).Cells("Name").FormattedValue
            Result = MainForm.DataGridView1.Rows(row).Cells("Result").FormattedValue
            Units = MainForm.DataGridView1.Rows(row).Cells("Units").FormattedValue


            file1.WriteLine(CashNumber & "|" & Name & "|" & Result & "|" & Units)

        Next

        file1.Close()

        'Export negative analites'

        System.IO.File.Create(MainForm.DataPathNegatives).Dispose()

        Dim file2 As System.IO.StreamWriter
        file2 = My.Computer.FileSystem.OpenTextFileWriter(MainForm.DataPathNegatives, True)

        Dim CashNumber2 As String
        Dim Name2 As String
        Dim Result2 As String
        Dim Units2 As String


        For row As Int32 = 0 To MainForm.DataGridView2.Rows.Count() - 1

            CashNumber2 = MainForm.DataGridView2.Rows(row).Cells("CashNumber").FormattedValue
            Name2 = MainForm.DataGridView2.Rows(row).Cells("Name").FormattedValue
            Result2 = MainForm.DataGridView2.Rows(row).Cells("Result").FormattedValue
            Units2 = MainForm.DataGridView2.Rows(row).Cells("Units").FormattedValue

            file2.WriteLine(CashNumber2 & "|" & Name2 & "|" & Result2 & "|" & Units2)

        Next

        file2.Close()

        ProtectData("Data.zip")  'Compresing again with password




    End Sub


    Public Shared Sub AddToDatabase(casNumber As String, name As String, units As Boolean, positive As Boolean)

        Dim NewRow As String

        MainForm.DataGridView1.Columns.Clear()
        MainForm.DataGridView2.Columns.Clear()
        LoadData()

        If units Then

            NewRow = casNumber & "|" & name & "||" & "µg/l approx."

        Else
            NewRow = casNumber & "|" & name & "||"

        End If

        If positive Then

            dt1.Rows.Add(Split(NewRow, "|"))
            MainForm.DataGridView1.Sort(MainForm.DataGridView1.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        Else

            dt2.Rows.Add(Split(NewRow, "|"))
            MainForm.DataGridView2.Sort(MainForm.DataGridView2.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        End If
        ExportToDataBase()

    End Sub

    Public Sub DeleteFromDataBase(index As Integer, dataGridView As DataGridView)

        dataGridView.Rows.RemoveAt(index)

    End Sub


End Class
