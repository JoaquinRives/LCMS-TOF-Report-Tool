<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColumnsForm
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
        Me.ApplyButton = New System.Windows.Forms.Button()
        Me.CanButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplyButton
        '
        Me.ApplyButton.Location = New System.Drawing.Point(64, 81)
        Me.ApplyButton.Name = "ApplyButton"
        Me.ApplyButton.Size = New System.Drawing.Size(75, 23)
        Me.ApplyButton.TabIndex = 0
        Me.ApplyButton.Text = "Apply"
        Me.ApplyButton.UseVisualStyleBackColor = True
        '
        'CanButton
        '
        Me.CanButton.Location = New System.Drawing.Point(151, 81)
        Me.CanButton.Name = "CanButton"
        Me.CanButton.Size = New System.Drawing.Size(75, 23)
        Me.CanButton.TabIndex = 1
        Me.CanButton.Text = "Exit"
        Me.CanButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Width:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Column 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Column 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(175, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Column 3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Column 4"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(64, 40)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {450, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(46, 20)
        Me.NumericUpDown1.TabIndex = 12
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(121, 40)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {450, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(46, 20)
        Me.NumericUpDown2.TabIndex = 16
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(178, 40)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {450, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(46, 20)
        Me.NumericUpDown3.TabIndex = 17
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(235, 40)
        Me.NumericUpDown4.Maximum = New Decimal(New Integer() {450, 0, 0, 0})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(46, 20)
        Me.NumericUpDown4.TabIndex = 18
        '
        'ColumnsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 117)
        Me.Controls.Add(Me.NumericUpDown4)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CanButton)
        Me.Controls.Add(Me.ApplyButton)
        Me.Name = "ColumnsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Columns"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ApplyButton As Button
    Friend WithEvents CanButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents NumericUpDown4 As NumericUpDown
End Class
