<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TabPage1 As System.Windows.Forms.TabPage
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DirectoryButton = New System.Windows.Forms.Button()
        Me.DirectoryTextBox = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.RunButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalystsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAnalystToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAnalystToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAnalyteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAnalyteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.VersionLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.ReportGroupBox = New System.Windows.Forms.GroupBox()
        Me.AnalystLabel = New System.Windows.Forms.Label()
        Me.AnalystComboBox = New System.Windows.Forms.ComboBox()
        Me.GenerateReportCheckBox = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.InstrumentLabel = New System.Windows.Forms.Label()
        Me.InstrumentComboBox = New System.Windows.Forms.ComboBox()
        TabPage1 = New System.Windows.Forms.TabPage()
        TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ReportGroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        TabPage1.BackColor = System.Drawing.Color.Transparent
        TabPage1.Controls.Add(Me.DataGridView1)
        TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TabPage1.ForeColor = System.Drawing.SystemColors.ControlText
        TabPage1.Location = New System.Drawing.Point(10, 40)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New System.Windows.Forms.Padding(3)
        TabPage1.Size = New System.Drawing.Size(449, 554)
        TabPage1.TabIndex = 0
        TabPage1.Text = "(+) Positive-Ion"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 33
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(443, 548)
        Me.DataGridView1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.AccessibleName = ""
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(200, 30)
        Me.TabControl1.Location = New System.Drawing.Point(149, 114)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(469, 604)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(10, 40)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(449, 554)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "(-) Negative-Ion"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 33
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView2.ShowEditingIcon = False
        Me.DataGridView2.Size = New System.Drawing.Size(443, 548)
        Me.DataGridView2.TabIndex = 1
        '
        'DirectoryButton
        '
        Me.DirectoryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DirectoryButton.FlatAppearance.BorderSize = 0
        Me.DirectoryButton.Location = New System.Drawing.Point(154, 63)
        Me.DirectoryButton.Name = "DirectoryButton"
        Me.DirectoryButton.Size = New System.Drawing.Size(87, 27)
        Me.DirectoryButton.TabIndex = 1
        Me.DirectoryButton.Text = "Directory"
        Me.DirectoryButton.UseVisualStyleBackColor = True
        '
        'DirectoryTextBox
        '
        Me.DirectoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DirectoryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DirectoryTextBox.Location = New System.Drawing.Point(248, 66)
        Me.DirectoryTextBox.Name = "DirectoryTextBox"
        Me.DirectoryTextBox.Size = New System.Drawing.Size(331, 38)
        Me.DirectoryTextBox.TabIndex = 2
        '
        'ClearButton
        '
        Me.ClearButton.FlatAppearance.BorderSize = 0
        Me.ClearButton.Location = New System.Drawing.Point(734, 105)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(110, 27)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'RunButton
        '
        Me.RunButton.BackColor = System.Drawing.Color.Transparent
        Me.RunButton.FlatAppearance.BorderSize = 0
        Me.RunButton.Location = New System.Drawing.Point(734, 48)
        Me.RunButton.Name = "RunButton"
        Me.RunButton.Size = New System.Drawing.Size(110, 42)
        Me.RunButton.TabIndex = 4
        Me.RunButton.Text = "Run"
        Me.RunButton.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightGray
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.AnalystsToolStripMenuItem, Me.DataBaseToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1246, 45)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = Global.LCMS_Report.My.Resources.Resources.Save_icon
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(130, 41)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'AnalystsToolStripMenuItem
        '
        Me.AnalystsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAnalystToolStripMenuItem, Me.DeleteAnalystToolStripMenuItem})
        Me.AnalystsToolStripMenuItem.Name = "AnalystsToolStripMenuItem"
        Me.AnalystsToolStripMenuItem.Size = New System.Drawing.Size(136, 41)
        Me.AnalystsToolStripMenuItem.Text = "Analysts"
        '
        'AddAnalystToolStripMenuItem
        '
        Me.AddAnalystToolStripMenuItem.Name = "AddAnalystToolStripMenuItem"
        Me.AddAnalystToolStripMenuItem.Size = New System.Drawing.Size(337, 48)
        Me.AddAnalystToolStripMenuItem.Text = "Add Analyst"
        '
        'DeleteAnalystToolStripMenuItem
        '
        Me.DeleteAnalystToolStripMenuItem.Name = "DeleteAnalystToolStripMenuItem"
        Me.DeleteAnalystToolStripMenuItem.Size = New System.Drawing.Size(337, 48)
        Me.DeleteAnalystToolStripMenuItem.Text = "Delete Analyst"
        '
        'DataBaseToolStripMenuItem
        '
        Me.DataBaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAnalyteToolStripMenuItem, Me.DeleteAnalyteToolStripMenuItem})
        Me.DataBaseToolStripMenuItem.Name = "DataBaseToolStripMenuItem"
        Me.DataBaseToolStripMenuItem.Size = New System.Drawing.Size(149, 41)
        Me.DataBaseToolStripMenuItem.Text = "DataBase"
        '
        'AddAnalyteToolStripMenuItem
        '
        Me.AddAnalyteToolStripMenuItem.Name = "AddAnalyteToolStripMenuItem"
        Me.AddAnalyteToolStripMenuItem.Size = New System.Drawing.Size(340, 48)
        Me.AddAnalyteToolStripMenuItem.Text = "New Analyte"
        '
        'DeleteAnalyteToolStripMenuItem
        '
        Me.DeleteAnalyteToolStripMenuItem.Name = "DeleteAnalyteToolStripMenuItem"
        Me.DeleteAnalyteToolStripMenuItem.Size = New System.Drawing.Size(340, 48)
        Me.DeleteAnalyteToolStripMenuItem.Text = "Delete Analyte"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(248, 41)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColumnsToolStripMenuItem, Me.ThemeToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(134, 41)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ColumnsToolStripMenuItem
        '
        Me.ColumnsToolStripMenuItem.Name = "ColumnsToolStripMenuItem"
        Me.ColumnsToolStripMenuItem.Size = New System.Drawing.Size(271, 48)
        Me.ColumnsToolStripMenuItem.Text = "Columns"
        '
        'ThemeToolStripMenuItem
        '
        Me.ThemeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TanToolStripMenuItem, Me.GrayToolStripMenuItem, Me.LightToolStripMenuItem, Me.DarkToolStripMenuItem, Me.DefaultToolStripMenuItem})
        Me.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem"
        Me.ThemeToolStripMenuItem.Size = New System.Drawing.Size(271, 48)
        Me.ThemeToolStripMenuItem.Text = "Theme"
        '
        'TanToolStripMenuItem
        '
        Me.TanToolStripMenuItem.Checked = True
        Me.TanToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.TanToolStripMenuItem.Name = "TanToolStripMenuItem"
        Me.TanToolStripMenuItem.Size = New System.Drawing.Size(253, 48)
        Me.TanToolStripMenuItem.Text = "Tan"
        '
        'GrayToolStripMenuItem
        '
        Me.GrayToolStripMenuItem.Checked = True
        Me.GrayToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GrayToolStripMenuItem.Name = "GrayToolStripMenuItem"
        Me.GrayToolStripMenuItem.Size = New System.Drawing.Size(253, 48)
        Me.GrayToolStripMenuItem.Text = "Gray"
        '
        'LightToolStripMenuItem
        '
        Me.LightToolStripMenuItem.Checked = True
        Me.LightToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LightToolStripMenuItem.Name = "LightToolStripMenuItem"
        Me.LightToolStripMenuItem.Size = New System.Drawing.Size(253, 48)
        Me.LightToolStripMenuItem.Text = "Light"
        '
        'DarkToolStripMenuItem
        '
        Me.DarkToolStripMenuItem.Checked = True
        Me.DarkToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DarkToolStripMenuItem.Name = "DarkToolStripMenuItem"
        Me.DarkToolStripMenuItem.Size = New System.Drawing.Size(253, 48)
        Me.DarkToolStripMenuItem.Text = "Dark"
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(253, 48)
        Me.DefaultToolStripMenuItem.Text = "Default"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightGray
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.VersionLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 701)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1246, 48)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.LightGray
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(235, 37)
        Me.ToolStripStatusLabel1.Text = "Database Version: "
        '
        'VersionLabel
        '
        Me.VersionLabel.BackColor = System.Drawing.Color.LightGray
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(271, 37)
        Me.VersionLabel.Text = "ToolStripStatusLabel1"
        '
        'NameTextBox
        '
        Me.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(597, 66)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(116, 38)
        Me.NameTextBox.TabIndex = 7
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(625, 48)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(142, 31)
        Me.NameLabel.TabIndex = 8
        Me.NameLabel.Text = "Sample Nº"
        '
        'ReportGroupBox
        '
        Me.ReportGroupBox.Controls.Add(Me.AnalystLabel)
        Me.ReportGroupBox.Controls.Add(Me.AnalystComboBox)
        Me.ReportGroupBox.Controls.Add(Me.GenerateReportCheckBox)
        Me.ReportGroupBox.Location = New System.Drawing.Point(863, 47)
        Me.ReportGroupBox.Name = "ReportGroupBox"
        Me.ReportGroupBox.Size = New System.Drawing.Size(197, 92)
        Me.ReportGroupBox.TabIndex = 11
        Me.ReportGroupBox.TabStop = False
        Me.ReportGroupBox.Text = "Report"
        '
        'AnalystLabel
        '
        Me.AnalystLabel.AutoSize = True
        Me.AnalystLabel.Location = New System.Drawing.Point(25, 43)
        Me.AnalystLabel.Name = "AnalystLabel"
        Me.AnalystLabel.Size = New System.Drawing.Size(112, 31)
        Me.AnalystLabel.TabIndex = 2
        Me.AnalystLabel.Text = "Analyst:"
        '
        'AnalystComboBox
        '
        Me.AnalystComboBox.FormattingEnabled = True
        Me.AnalystComboBox.Location = New System.Drawing.Point(28, 61)
        Me.AnalystComboBox.Name = "AnalystComboBox"
        Me.AnalystComboBox.Size = New System.Drawing.Size(157, 39)
        Me.AnalystComboBox.TabIndex = 1
        '
        'GenerateReportCheckBox
        '
        Me.GenerateReportCheckBox.AutoSize = True
        Me.GenerateReportCheckBox.Checked = True
        Me.GenerateReportCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GenerateReportCheckBox.Location = New System.Drawing.Point(28, 20)
        Me.GenerateReportCheckBox.Name = "GenerateReportCheckBox"
        Me.GenerateReportCheckBox.Size = New System.Drawing.Size(248, 35)
        Me.GenerateReportCheckBox.TabIndex = 0
        Me.GenerateReportCheckBox.Text = "Generate Report"
        Me.GenerateReportCheckBox.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LCMS_Report.My.Resources.Resources.Env_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'InstrumentLabel
        '
        Me.InstrumentLabel.AutoSize = True
        Me.InstrumentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstrumentLabel.Location = New System.Drawing.Point(12, 218)
        Me.InstrumentLabel.Name = "InstrumentLabel"
        Me.InstrumentLabel.Size = New System.Drawing.Size(162, 36)
        Me.InstrumentLabel.TabIndex = 13
        Me.InstrumentLabel.Text = "Instrument:"
        '
        'InstrumentComboBox
        '
        Me.InstrumentComboBox.FormattingEnabled = True
        Me.InstrumentComboBox.Items.AddRange(New Object() {"SX O LCQQQ5", "SX O LCQQQ6"})
        Me.InstrumentComboBox.Location = New System.Drawing.Point(15, 246)
        Me.InstrumentComboBox.Name = "InstrumentComboBox"
        Me.InstrumentComboBox.Size = New System.Drawing.Size(121, 39)
        Me.InstrumentComboBox.TabIndex = 14
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1246, 749)
        Me.Controls.Add(Me.InstrumentComboBox)
        Me.Controls.Add(Me.InstrumentLabel)
        Me.Controls.Add(Me.ReportGroupBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.RunButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DirectoryTextBox)
        Me.Controls.Add(Me.DirectoryButton)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LCMS Q-TOF Screen Report Tool"
        TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ReportGroupBox.ResumeLayout(False)
        Me.ReportGroupBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DirectoryButton As Button
    Friend WithEvents DirectoryTextBox As TextBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents RunButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NameLabel As Label
    Friend WithEvents DataBaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAnalyteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAnalyteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColumnsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ThemeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DefaultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportGroupBox As GroupBox
    Friend WithEvents AnalystLabel As Label
    Friend WithEvents AnalystComboBox As ComboBox
    Friend WithEvents GenerateReportCheckBox As CheckBox
    Friend WithEvents AnalystsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAnalystToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAnalystToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstrumentLabel As Label
    Friend WithEvents InstrumentComboBox As ComboBox
End Class
