<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UnitsRadioButton = New System.Windows.Forms.RadioButton()
        Me.NoUnitsRadioButton = New System.Windows.Forms.RadioButton()
        Me.CasTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NegativeRadioButton = New System.Windows.Forms.RadioButton()
        Me.PositiveRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddCancelButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cas# :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name :"
        '
        'UnitsRadioButton
        '
        Me.UnitsRadioButton.AutoSize = True
        Me.UnitsRadioButton.Checked = True
        Me.UnitsRadioButton.Location = New System.Drawing.Point(24, 19)
        Me.UnitsRadioButton.Name = "UnitsRadioButton"
        Me.UnitsRadioButton.Size = New System.Drawing.Size(82, 17)
        Me.UnitsRadioButton.TabIndex = 2
        Me.UnitsRadioButton.TabStop = True
        Me.UnitsRadioButton.Text = "Quantitative"
        Me.UnitsRadioButton.UseVisualStyleBackColor = True
        '
        'NoUnitsRadioButton
        '
        Me.NoUnitsRadioButton.AutoSize = True
        Me.NoUnitsRadioButton.Location = New System.Drawing.Point(24, 42)
        Me.NoUnitsRadioButton.Name = "NoUnitsRadioButton"
        Me.NoUnitsRadioButton.Size = New System.Drawing.Size(99, 17)
        Me.NoUnitsRadioButton.TabIndex = 3
        Me.NoUnitsRadioButton.Text = "No Quantitative"
        Me.NoUnitsRadioButton.UseVisualStyleBackColor = True
        '
        'CasTextBox
        '
        Me.CasTextBox.Location = New System.Drawing.Point(72, 33)
        Me.CasTextBox.Name = "CasTextBox"
        Me.CasTextBox.Size = New System.Drawing.Size(261, 20)
        Me.CasTextBox.TabIndex = 4
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(72, 66)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(261, 20)
        Me.NameTextBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(110, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UnitsRadioButton)
        Me.GroupBox1.Controls.Add(Me.NoUnitsRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(191, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 76)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NegativeRadioButton)
        Me.GroupBox2.Controls.Add(Me.PositiveRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(72, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(113, 76)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'NegativeRadioButton
        '
        Me.NegativeRadioButton.AutoSize = True
        Me.NegativeRadioButton.Location = New System.Drawing.Point(22, 42)
        Me.NegativeRadioButton.Name = "NegativeRadioButton"
        Me.NegativeRadioButton.Size = New System.Drawing.Size(86, 17)
        Me.NegativeRadioButton.TabIndex = 1
        Me.NegativeRadioButton.Text = "Negative-Ion"
        Me.NegativeRadioButton.UseVisualStyleBackColor = True
        '
        'PositiveRadioButton
        '
        Me.PositiveRadioButton.AutoSize = True
        Me.PositiveRadioButton.Checked = True
        Me.PositiveRadioButton.Location = New System.Drawing.Point(22, 19)
        Me.PositiveRadioButton.Name = "PositiveRadioButton"
        Me.PositiveRadioButton.Size = New System.Drawing.Size(80, 17)
        Me.PositiveRadioButton.TabIndex = 0
        Me.PositiveRadioButton.TabStop = True
        Me.PositiveRadioButton.Text = "Positive-Ion"
        Me.PositiveRadioButton.UseVisualStyleBackColor = True
        '
        'AddCancelButton
        '
        Me.AddCancelButton.Location = New System.Drawing.Point(191, 191)
        Me.AddCancelButton.Name = "AddCancelButton"
        Me.AddCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.AddCancelButton.TabIndex = 9
        Me.AddCancelButton.Text = "Cancel"
        Me.AddCancelButton.UseVisualStyleBackColor = True
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 240)
        Me.Controls.Add(Me.AddCancelButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.CasTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Analyte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UnitsRadioButton As RadioButton
    Friend WithEvents NoUnitsRadioButton As RadioButton
    Friend WithEvents CasTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NegativeRadioButton As RadioButton
    Friend WithEvents PositiveRadioButton As RadioButton
    Friend WithEvents AddCancelButton As Button
End Class
