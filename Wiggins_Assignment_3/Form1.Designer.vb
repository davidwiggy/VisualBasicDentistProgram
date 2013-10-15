<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnForm2 = New System.Windows.Forms.Button()
        Me.btnForm3 = New System.Windows.Forms.Button()
        Me.btnForm4 = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnForm2
        '
        Me.btnForm2.Location = New System.Drawing.Point(123, 36)
        Me.btnForm2.Name = "btnForm2"
        Me.btnForm2.Size = New System.Drawing.Size(324, 83)
        Me.btnForm2.TabIndex = 0
        Me.btnForm2.Text = " form &2"
        Me.btnForm2.UseVisualStyleBackColor = True
        '
        'btnForm3
        '
        Me.btnForm3.Location = New System.Drawing.Point(123, 138)
        Me.btnForm3.Name = "btnForm3"
        Me.btnForm3.Size = New System.Drawing.Size(324, 83)
        Me.btnForm3.TabIndex = 1
        Me.btnForm3.Text = "Form &3"
        Me.btnForm3.UseVisualStyleBackColor = True
        '
        'btnForm4
        '
        Me.btnForm4.Location = New System.Drawing.Point(123, 240)
        Me.btnForm4.Name = "btnForm4"
        Me.btnForm4.Size = New System.Drawing.Size(324, 83)
        Me.btnForm4.TabIndex = 2
        Me.btnForm4.Text = "Form &4"
        Me.btnForm4.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(123, 342)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(324, 83)
        Me.btnDone.TabIndex = 3
        Me.btnDone.Text = "&Exit"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 460)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnForm4)
        Me.Controls.Add(Me.btnForm3)
        Me.Controls.Add(Me.btnForm2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnForm2 As System.Windows.Forms.Button
    Friend WithEvents btnForm3 As System.Windows.Forms.Button
    Friend WithEvents btnForm4 As System.Windows.Forms.Button
    Friend WithEvents btnDone As System.Windows.Forms.Button

End Class
