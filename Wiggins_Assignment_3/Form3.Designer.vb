<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnBackForm3 = New System.Windows.Forms.Button()
        Me.lblTotalCus = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(1, 279)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(179, 79)
        Me.btnReport.TabIndex = 0
        Me.btnReport.Text = "&Get Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnBackForm3
        '
        Me.btnBackForm3.Location = New System.Drawing.Point(389, 279)
        Me.btnBackForm3.Name = "btnBackForm3"
        Me.btnBackForm3.Size = New System.Drawing.Size(179, 79)
        Me.btnBackForm3.TabIndex = 1
        Me.btnBackForm3.Text = "&Back"
        Me.btnBackForm3.UseVisualStyleBackColor = True
        '
        'lblTotalCus
        '
        Me.lblTotalCus.AutoSize = True
        Me.lblTotalCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCus.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblTotalCus.Location = New System.Drawing.Point(63, 59)
        Me.lblTotalCus.Name = "lblTotalCus"
        Me.lblTotalCus.Size = New System.Drawing.Size(0, 18)
        Me.lblTotalCus.TabIndex = 2
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblGrandTotal.Location = New System.Drawing.Point(63, 138)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(0, 18)
        Me.lblGrandTotal.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(195, 279)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnClear.Size = New System.Drawing.Size(179, 79)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 460)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.lblTotalCus)
        Me.Controls.Add(Me.btnBackForm3)
        Me.Controls.Add(Me.btnReport)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grand Total Cost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnBackForm3 As System.Windows.Forms.Button
    Friend WithEvents lblTotalCus As System.Windows.Forms.Label
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
