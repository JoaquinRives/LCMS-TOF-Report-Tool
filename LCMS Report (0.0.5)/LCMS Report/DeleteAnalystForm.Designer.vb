<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteAnalystForm
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
        Me.DelButton = New System.Windows.Forms.Button()
        Me.CanButton = New System.Windows.Forms.Button()
        Me.DeleteAnalystComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'DelButton
        '
        Me.DelButton.Location = New System.Drawing.Point(36, 91)
        Me.DelButton.Name = "DelButton"
        Me.DelButton.Size = New System.Drawing.Size(75, 23)
        Me.DelButton.TabIndex = 0
        Me.DelButton.Text = "Delete"
        Me.DelButton.UseVisualStyleBackColor = True
        '
        'CanButton
        '
        Me.CanButton.Location = New System.Drawing.Point(143, 91)
        Me.CanButton.Name = "CanButton"
        Me.CanButton.Size = New System.Drawing.Size(75, 23)
        Me.CanButton.TabIndex = 1
        Me.CanButton.Text = "Cancel"
        Me.CanButton.UseVisualStyleBackColor = True
        '
        'DeleteAnalystComboBox
        '
        Me.DeleteAnalystComboBox.FormattingEnabled = True
        Me.DeleteAnalystComboBox.Location = New System.Drawing.Point(36, 35)
        Me.DeleteAnalystComboBox.Name = "DeleteAnalystComboBox"
        Me.DeleteAnalystComboBox.Size = New System.Drawing.Size(182, 21)
        Me.DeleteAnalystComboBox.TabIndex = 2
        '
        'DeleteAnalystForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 150)
        Me.Controls.Add(Me.DeleteAnalystComboBox)
        Me.Controls.Add(Me.CanButton)
        Me.Controls.Add(Me.DelButton)
        Me.Name = "DeleteAnalystForm"
        Me.Text = "DeleteAnalystForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DelButton As Button
    Friend WithEvents CanButton As Button
    Friend WithEvents DeleteAnalystComboBox As ComboBox
End Class
