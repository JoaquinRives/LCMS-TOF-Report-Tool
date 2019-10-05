Public Class MainForm

    Public DataPathPositives As String
    Public DataPathNegatives As String
    Public DataPathSettings As String
    Public DataPathSessionSaved As String
    Public MainPath As String

    Public DictSettings As Dictionary(Of String, String)

    Public Password As String
    Public WidthColumns As String
    Public Analysts As String
    Dim DefaultAnalyst As String
    Dim BackgroundColor As Color
    Dim TableBackgroundColor As Color
    Dim TableBackgroundColor2 As Color
    Dim FontColor As Color
    Dim ButtonColor As Color
    Dim ButtonStyle As FlatStyle
    Public Theme As String


    Private Sub GetDataPaths()
        MainPath = Application.StartupPath
        DataPathPositives = MainPath & "\DataPositive.txt"
        DataPathNegatives = MainPath & "\DataNegative.txt"
        DataPathSettings = MainPath & "\AppSettings.txt"
        DataPathSessionSaved = MainPath & "\SessionSaved.txt"




    End Sub

    Public Sub RetrieveLastSession()


        If System.IO.File.Exists(DataPathSessionSaved) Then

            Dim Answer As String = MsgBox("Do you want to retrieve last session?", vbQuestion + vbYesNo, "???")

            If Answer = vbYes Then

                Dim Counter As Integer = 0

                Dim fileReader As System.IO.StreamReader
                fileReader = My.Computer.FileSystem.OpenTextFileReader(DataPathSessionSaved)

                Do While fileReader.Peek() <> -1

                    Dim Line As String = fileReader.ReadLine()
                    Dim AnalyteSavedCashNumber As String = Line.Split("|")(0).Trim()
                    Dim AnalyteSavedResult As String = Line.Split("|")(1).Trim()

                    For row As Integer = 0 To DataGridView1.Rows.Count - 1

                        If DataGridView1.Rows(row).Cells("CashNumber").FormattedValue.Trim() = AnalyteSavedCashNumber Then

                            DataGridView1.Rows(row).Cells("Result").Value = AnalyteSavedResult
                            Counter += 1

                        End If
                    Next

                    For row As Integer = 0 To DataGridView2.Rows.Count - 1

                        If DataGridView2.Rows(row).Cells("CashNumber").FormattedValue = AnalyteSavedCashNumber Then

                            DataGridView2.Rows(row).Cells("Result").Value = AnalyteSavedResult
                            Counter += 1

                        End If

                    Next
                Loop

                fileReader.Close()
                MessageBox.Show("Results retrieved: " & Counter)
                My.Computer.FileSystem.DeleteFile(DataPathSessionSaved)

            Else

                My.Computer.FileSystem.DeleteFile(DataPathSessionSaved)

            End If
        End If
    End Sub

    Private Sub LoadSettings()

        DataHandlerClass.UnprotectData("AppSettings.zip")

        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(DataPathSettings)
        Dim Line As String
        Line = fileReader.ReadLine()
        DictSettings = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(Line)

        fileReader.Close()

        DataHandlerClass.ProtectData("AppSettings.zip")

    End Sub

    Private Sub SaveSettings()

        DataHandlerClass.UnprotectData("AppSettings.zip")

        Dim SettingsJSON As String = Newtonsoft.Json.JsonConvert.SerializeObject(DictSettings)

        System.IO.File.Create(DataPathSettings).Dispose()

        Dim file1 As System.IO.StreamWriter
        file1 = My.Computer.FileSystem.OpenTextFileWriter(DataPathSettings, True)

        file1.WriteLine(SettingsJSON)

        file1.Close()

        DataHandlerClass.ProtectData("AppSettings.zip")

    End Sub

    Private Sub GenerateReport()

        Dim dtReport As DataTable = New DataTable
        Dim CashNumber As String
        Dim Name As String
        Dim Result As String
        Dim Units As String
        Dim Analyst As String
        Dim SampleID As String
        Dim Instrument As String

        dtReport.Columns.Add("Cas#", GetType(String))
        dtReport.Columns.Add("Name", GetType(String))
        dtReport.Columns.Add("Result", GetType(String))
        dtReport.Columns.Add("Units", GetType(String))

        For row As Int32 = 0 To DataGridView1.Rows.Count() - 1

            Dim ResultValue As String = DataGridView1.Rows(row).Cells("Result").FormattedValue


            If Not String.IsNullOrWhiteSpace(ResultValue) Then

                CashNumber = DataGridView1.Rows(row).Cells("CashNumber").FormattedValue.Trim()
                Name = DataGridView1.Rows(row).Cells("Name").FormattedValue.Trim()
                Result = DataGridView1.Rows(row).Cells("Result").FormattedValue.Trim()
                Units = DataGridView1.Rows(row).Cells("Units").FormattedValue.Trim()

                If Not String.IsNullOrWhiteSpace(Units) Then

                    dtReport.Rows.Add(CashNumber, Name, Result, Units)

                Else

                    dtReport.Rows.Add(CashNumber, Name, "-", "n/a")

                End If
            End If
        Next

        For row As Int32 = 0 To DataGridView2.Rows.Count() - 1

            Dim ResultValue As String = DataGridView2.Rows(row).Cells("Result").FormattedValue

            If Not String.IsNullOrWhiteSpace(ResultValue) Then

                CashNumber = DataGridView2.Rows(row).Cells("CashNumber").FormattedValue.Trim()
                Name = DataGridView2.Rows(row).Cells("Name").FormattedValue.Trim()
                Result = DataGridView2.Rows(row).Cells("Result").FormattedValue.Trim()
                Units = DataGridView2.Rows(row).Cells("Units").FormattedValue.Trim()

                If Not String.IsNullOrWhiteSpace(Units) Then

                    dtReport.Rows.Add(CashNumber, Name, Result, Units)

                Else

                    dtReport.Rows.Add(CashNumber, Name, "-", "n/a")

                End If
            End If
        Next

        Analyst = AnalystComboBox.Text
        SampleID = NameTextBox.Text
        Instrument = InstrumentComboBox.Text

        Dim RptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument
        RptDoc = New CrystalReport1
        RptDoc.DataDefinition.FormulaFields("UnboundString1").Text = "'" & Analyst & "'"
        RptDoc.DataDefinition.FormulaFields("UnboundString3").Text = "'" & SampleID & "'"
        RptDoc.DataDefinition.FormulaFields("UnboundString4").Text = "'" & Instrument & "'"
        RptDoc.SetDataSource(dtReport)

        ReportViewerForm.CrystalReportViewer1.ReportSource = RptDoc
        ReportViewerForm.ShowDialog()
        ReportViewerForm.Dispose()


    End Sub


    Private Sub ExportDataToTextFile(exportPath As String)

        Dim Counter As Integer = 0

        Try

            System.IO.File.Create(exportPath).Dispose()

            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(exportPath, True)

            Dim CashNumber As String
            Dim Name As String
            Dim Result As String
            Dim Units As String

            For row As Int32 = 0 To DataGridView1.Rows.Count() - 1

                Dim ResultValue As String = DataGridView1.Rows(row).Cells("Result").FormattedValue


                If Not String.IsNullOrWhiteSpace(ResultValue) Then

                    CashNumber = DataGridView1.Rows(row).Cells("CashNumber").FormattedValue.Trim()
                    Name = DataGridView1.Rows(row).Cells("Name").FormattedValue.Trim()
                    Result = DataGridView1.Rows(row).Cells("Result").FormattedValue.Trim()
                    Units = DataGridView1.Rows(row).Cells("Units").FormattedValue.Trim()

                    If Not String.IsNullOrWhiteSpace(Units) Then
                        file.WriteLine(CashNumber & " " & Name & " " & Result & " " & Units)

                    Else
                        file.WriteLine(CashNumber & " " & Name)
                    End If

                    Counter += 1

                End If
            Next

            For row As Int32 = 0 To DataGridView2.Rows.Count() - 1

                Dim ResultValue As String = DataGridView2.Rows(row).Cells("Result").FormattedValue

                If Not String.IsNullOrWhiteSpace(ResultValue) Then

                    CashNumber = DataGridView2.Rows(row).Cells("CashNumber").FormattedValue.Trim()
                    Name = DataGridView2.Rows(row).Cells("Name").FormattedValue.Trim()
                    Result = DataGridView2.Rows(row).Cells("Result").FormattedValue.Trim()
                    Units = DataGridView2.Rows(row).Cells("Units").FormattedValue.Trim()

                    If Not String.IsNullOrWhiteSpace(Units) Then
                        file.WriteLine(CashNumber & " " & Name & " " & Result & " " & Units)

                    Else
                        file.WriteLine(CashNumber & " " & Name)

                    End If

                    Counter += 1

                End If
            Next

            file.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try

        MessageBox.Show("Text File created" & vbNewLine & vbNewLine & "Analites Included: " & Counter)

        If GenerateReportCheckBox.Checked Then

            GenerateReport()

        End If

    End Sub

    Public Sub SetTheme(whichColor)

        Theme = whichColor

        Select Case whichColor
            Case "Tan"
                BackgroundColor = Color.BurlyWood
                TableBackgroundColor = Color.Tan
                TableBackgroundColor2 = Color.Wheat
                FontColor = Color.Black
                ButtonColor = Color.LightGray
                ButtonStyle = FlatStyle.Standard


                TanToolStripMenuItem.Checked = True
                LightToolStripMenuItem.Checked = False
                DarkToolStripMenuItem.Checked = False
                GrayToolStripMenuItem.Checked = False
                DefaultToolStripMenuItem.Checked = False


            Case "Light"
                BackgroundColor = Color.White
                TableBackgroundColor = Color.White
                TableBackgroundColor2 = Color.FromArgb(209, 238, 238)
                FontColor = Color.Black
                ButtonColor = Color.LightGray
                ButtonStyle = FlatStyle.Standard

                TanToolStripMenuItem.Checked = False
                LightToolStripMenuItem.Checked = True
                DarkToolStripMenuItem.Checked = False
                GrayToolStripMenuItem.Checked = False
                DefaultToolStripMenuItem.Checked = False


            Case "Dark"
                BackgroundColor = Color.Black
                TableBackgroundColor = Color.Black
                TableBackgroundColor2 = Color.FromArgb(45, 45, 45)
                FontColor = Color.White
                ButtonColor = Color.FromArgb(110, 110, 110)
                ButtonStyle = FlatStyle.Flat

                TanToolStripMenuItem.Checked = False
                LightToolStripMenuItem.Checked = False
                DarkToolStripMenuItem.Checked = True
                GrayToolStripMenuItem.Checked = False
                DefaultToolStripMenuItem.Checked = False



            Case "Gray"
                BackgroundColor = Color.FromArgb(225, 225, 225)
                TableBackgroundColor = Color.FromArgb(190, 190, 190) 'Color.FromArgb(225, 225, 225)
                TableBackgroundColor2 = Color.FromArgb(225, 225, 225)
                FontColor = Color.Black
                ButtonColor = Color.FromArgb(175, 175, 175)
                ButtonStyle = FlatStyle.Flat

                TanToolStripMenuItem.Checked = False
                LightToolStripMenuItem.Checked = False
                DarkToolStripMenuItem.Checked = False
                GrayToolStripMenuItem.Checked = True
                DefaultToolStripMenuItem.Checked = False



            Case "Default"
                BackgroundColor = Color.WhiteSmoke
                TableBackgroundColor = Color.White
                TableBackgroundColor2 = Color.White
                FontColor = Color.Black
                ButtonColor = Color.LightGray
                ButtonStyle = FlatStyle.Standard


                TanToolStripMenuItem.Checked = False
                LightToolStripMenuItem.Checked = False
                DarkToolStripMenuItem.Checked = False
                GrayToolStripMenuItem.Checked = False
                DefaultToolStripMenuItem.Checked = True

        End Select

        'Setting colors to the form
        AnalystComboBox.BackColor = TableBackgroundColor2
        InstrumentComboBox.BackColor = TableBackgroundColor2
        BackColor = BackgroundColor
        DataGridView1.DefaultCellStyle.BackColor = TableBackgroundColor
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = TableBackgroundColor2
        DataGridView2.DefaultCellStyle.BackColor = TableBackgroundColor
        DataGridView2.AlternatingRowsDefaultCellStyle.BackColor = TableBackgroundColor2
        DataGridView1.Columns(2).DefaultCellStyle.BackColor = TableBackgroundColor2
        DataGridView2.Columns(2).DefaultCellStyle.BackColor = TableBackgroundColor2
        DataGridView1.DefaultCellStyle.ForeColor = FontColor
        DataGridView2.DefaultCellStyle.ForeColor = FontColor
        DirectoryTextBox.BackColor = TableBackgroundColor2
        NameTextBox.BackColor = TableBackgroundColor2
        MenuStrip1.BackColor = ButtonColor
        StatusStrip1.BackColor = ButtonColor
        DirectoryTextBox.ForeColor = FontColor
        NameTextBox.ForeColor = FontColor
        MenuStrip1.ForeColor = FontColor
        StatusStrip1.ForeColor = FontColor
        NameLabel.ForeColor = FontColor
        MenuStrip1.ForeColor = FontColor
        StatusStrip1.ForeColor = FontColor
        DirectoryButton.ForeColor = FontColor
        ClearButton.ForeColor = FontColor
        RunButton.ForeColor = FontColor
        DirectoryButton.BackColor = ButtonColor
        ClearButton.BackColor = ButtonColor
        RunButton.BackColor = ButtonColor
        DirectoryButton.FlatStyle = ButtonStyle
        ClearButton.FlatStyle = ButtonStyle
        RunButton.FlatStyle = ButtonStyle

    End Sub

    Public Sub SetAnalystComboBox()

        For Each analyst As String In Analysts.Split("|")

            AnalystComboBox.Items.Add(analyst)
        Next

        AnalystComboBox.Text = DefaultAnalyst

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Setting size window
        Dim Height As Integer = Screen.PrimaryScreen.WorkingArea.Height - 33
        Dim Width As Integer = 1100
        Me.ClientSize = New Size(Width, Height)

        'To get the all the paths where the files are located in the computer'
        GetDataPaths()

        'Showing Splashscreen
        Dim Intro As New Intro()
        Intro.Show()

        'Recovering settings of the last session:
        LoadSettings()
        WidthColumns = DictSettings("WidthColumns")
        Theme = DictSettings("Theme")
        Analysts = DictSettings("Analysts")
        DefaultAnalyst = DictSettings("DefaultAnalyst")
        SetAnalystComboBox()
        DataHandlerClass.Password = DictSettings("Password")
        VersionLabel.Text = DictSettings("DataBaseVersion")

        'Loding the data to the datagrigview
        DataHandlerClass.LoadData()

        InstrumentComboBox.SelectedIndex = 1

    End Sub

    Private Sub DirectoryButton_Click(sender As Object, e As EventArgs) Handles DirectoryButton.Click

        'FileBrowser'

        Dim fb As FolderBrowserDialog = New FolderBrowserDialog()

        If fb.ShowDialog() = DialogResult.OK Then

            DirectoryTextBox.Text = fb.SelectedPath

        End If

    End Sub

    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click

        Dim ExportPath As String = DirectoryTextBox.Text

        If System.IO.Directory.Exists(ExportPath) Then

            'To check if the ExportPath has the \ at the end'
            If ChrW(ExportPath.Length - 1) <> "\" Then

                ExportPath = ExportPath & "\"

            End If

            Dim FullPath As String = ExportPath & NameTextBox.Text & ".txt"

            ExportDataToTextFile(FullPath)

        Else

            MessageBox.Show("Error: ExportPath does not exist")

        End If

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        If System.IO.File.Exists(DataPathSessionSaved) Then

            My.Computer.FileSystem.DeleteFile(DataPathSessionSaved)

        End If

        DataGridView1.Columns.Clear()
        DataGridView2.Columns.Clear()
        DataHandlerClass.LoadData()
        NameTextBox.Text = ""

    End Sub

    Private Sub AddAnalyteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAnalyteToolStripMenuItem.Click

        Dim NewPasswordForm As New PasswordForm("AddForm")
        NewPasswordForm.Show()

    End Sub

    Private Sub DeleteAnalyteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAnalyteToolStripMenuItem.Click

        Dim NewPasswordForm As New PasswordForm("DeleteForm")
        NewPasswordForm.Show()

    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click

        Dim NewPasswordForm As New PasswordForm("ChangePassword")
        NewPasswordForm.Show()

    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'Saving setting when the form is closed'

        DictSettings("WidthColumns") = WidthColumns
        DictSettings("Theme") = Theme
        DictSettings("Password") = DataHandlerClass.Password
        DictSettings("DataBaseVersion") = VersionLabel.Text
        DictSettings("Analysts") = Analysts
        DictSettings("DefaultAnalyst") = DefaultAnalyst


        SaveSettings()


    End Sub

    Private Sub ColumnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColumnsToolStripMenuItem.Click

        Dim NewColumnsForm As New ColumnsForm()
        NewColumnsForm.Show()

    End Sub


    Private Sub DarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click

        SetTheme("Dark")

    End Sub

    Private Sub LightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightToolStripMenuItem.Click

        SetTheme("Light")

    End Sub

    Private Sub TanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TanToolStripMenuItem.Click

        SetTheme("Tan")

    End Sub

    Private Sub GrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrayToolStripMenuItem.Click

        SetTheme("Gray")

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click

        SetTheme("Default")

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click


        Try

            System.IO.File.Create(DataPathSessionSaved).Dispose()

            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(DataPathSessionSaved, True)

            Dim CashNumber As String
            Dim Result As String

            For row As Int32 = 0 To DataGridView1.Rows.Count() - 1

                Dim ResultValue As String = DataGridView1.Rows(row).Cells("Result").FormattedValue


                If Not String.IsNullOrWhiteSpace(ResultValue) Then

                    CashNumber = DataGridView1.Rows(row).Cells("CashNumber").FormattedValue.Trim()
                    Result = DataGridView1.Rows(row).Cells("Result").FormattedValue.Trim()

                    file.WriteLine(CashNumber & "|" & Result)
                End If

            Next

            For row As Int32 = 0 To DataGridView2.Rows.Count() - 1

                Dim ResultValue As String = DataGridView2.Rows(row).Cells("Result").FormattedValue

                If Not String.IsNullOrWhiteSpace(ResultValue) Then

                    CashNumber = DataGridView2.Rows(row).Cells("CashNumber").FormattedValue
                    Result = DataGridView2.Rows(row).Cells("Result").FormattedValue

                    file.WriteLine(CashNumber & "|" & Result)

                End If
            Next

            file.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try

        MessageBox.Show("Session Saved")

    End Sub

    Private Sub AddAnalystToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAnalystToolStripMenuItem.Click

        Dim NewAddAnalystForm As New AddAnalystForm()
        NewAddAnalystForm.Show()

    End Sub

    Private Sub DeleteAnalystToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAnalystToolStripMenuItem.Click

        Dim NewDeleteAnalystForm As New DeleteAnalystForm()
        NewDeleteAnalystForm.Show()

    End Sub


End Class


'TODO:

'add some more pictures
'add try/catch en todos los filewrite/fileread


