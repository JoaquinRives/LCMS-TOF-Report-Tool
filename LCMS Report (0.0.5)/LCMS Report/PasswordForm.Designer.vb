<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordForm
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
        Me.PasswordButton = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PasswordButton
        '
        Me.PasswordButton.Location = New System.Drawing.Point(134, 90)
        Me.PasswordButton.Name = "PasswordButton"
        Me.PasswordButton.Size = New System.Drawing.Size(75, 23)
        Me.PasswordButton.TabIndex = 0
        Me.PasswordButton.Text = "Enter"
        Me.PasswordButton.UseVisualStyleBackColor = True
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(122, 51)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password:"
        '
        'PasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 157)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.PasswordButton)
        Me.Name = "PasswordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Required"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PasswordButton As Button
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
