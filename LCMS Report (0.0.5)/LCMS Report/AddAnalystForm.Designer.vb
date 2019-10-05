<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAnalystForm
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
        Me.NewAnalystTextBox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.CanButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NewAnalystTextBox
        '
        Me.NewAnalystTextBox.Location = New System.Drawing.Point(53, 55)
        Me.NewAnalystTextBox.Name = "NewAnalystTextBox"
        Me.NewAnalystTextBox.Size = New System.Drawing.Size(159, 20)
        Me.NewAnalystTextBox.TabIndex = 0
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(53, 100)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'CanButton
        '
        Me.CanButton.Location = New System.Drawing.Point(137, 100)
        Me.CanButton.Name = "CanButton"
        Me.CanButton.Size = New System.Drawing.Size(75, 23)
        Me.CanButton.TabIndex = 2
        Me.CanButton.Text = "Cancel"
        Me.CanButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "New Analyst:"
        '
        'AddAnalystForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 158)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CanButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.NewAnalystTextBox)
        Me.Name = "AddAnalystForm"
        Me.Text = "AddAnalystForm4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NewAnalystTextBox As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents CanButton As Button
    Friend WithEvents Label1 As Label
End Class
