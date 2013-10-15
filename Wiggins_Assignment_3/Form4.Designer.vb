<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lvPatientNumbers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtPatNum = New System.Windows.Forms.TextBox()
        Me.lblEnterPatNum = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lvPatRecords = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblPatRecordsReport = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(79, 421)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(148, 71)
        Me.btnReport.TabIndex = 0
        Me.btnReport.Text = "&Get Customer Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(325, 421)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(148, 71)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(571, 421)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(148, 71)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lvPatientNumbers
        '
        Me.lvPatientNumbers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvPatientNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPatientNumbers.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lvPatientNumbers.GridLines = True
        Me.lvPatientNumbers.Location = New System.Drawing.Point(12, 12)
        Me.lvPatientNumbers.Name = "lvPatientNumbers"
        Me.lvPatientNumbers.Size = New System.Drawing.Size(133, 344)
        Me.lvPatientNumbers.TabIndex = 3
        Me.lvPatientNumbers.UseCompatibleStateImageBehavior = False
        Me.lvPatientNumbers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Patient Numbers"
        Me.ColumnHeader1.Width = 128
        '
        'txtPatNum
        '
        Me.txtPatNum.Location = New System.Drawing.Point(334, 13)
        Me.txtPatNum.Name = "txtPatNum"
        Me.txtPatNum.Size = New System.Drawing.Size(149, 20)
        Me.txtPatNum.TabIndex = 4
        '
        'lblEnterPatNum
        '
        Me.lblEnterPatNum.AutoSize = True
        Me.lblEnterPatNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterPatNum.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblEnterPatNum.Location = New System.Drawing.Point(177, 12)
        Me.lblEnterPatNum.Name = "lblEnterPatNum"
        Me.lblEnterPatNum.Size = New System.Drawing.Size(148, 17)
        Me.lblEnterPatNum.TabIndex = 5
        Me.lblEnterPatNum.Text = "Enter Patient Number:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lvPatRecords
        '
        Me.lvPatRecords.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvPatRecords.GridLines = True
        Me.lvPatRecords.Location = New System.Drawing.Point(151, 95)
        Me.lvPatRecords.Name = "lvPatRecords"
        Me.lvPatRecords.Size = New System.Drawing.Size(619, 261)
        Me.lvPatRecords.TabIndex = 6
        Me.lvPatRecords.UseCompatibleStateImageBehavior = False
        Me.lvPatRecords.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Patient Number"
        Me.ColumnHeader2.Width = 85
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Gender"
        Me.ColumnHeader3.Width = 50
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Last Name"
        Me.ColumnHeader4.Width = 76
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "First Name"
        Me.ColumnHeader5.Width = 81
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Procedure Number"
        Me.ColumnHeader6.Width = 110
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Cost"
        Me.ColumnHeader7.Width = 100
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Description"
        Me.ColumnHeader8.Width = 129
        '
        'lblPatRecordsReport
        '
        Me.lblPatRecordsReport.AutoSize = True
        Me.lblPatRecordsReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatRecordsReport.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblPatRecordsReport.Location = New System.Drawing.Point(383, 64)
        Me.lblPatRecordsReport.Name = "lblPatRecordsReport"
        Me.lblPatRecordsReport.Size = New System.Drawing.Size(109, 17)
        Me.lblPatRecordsReport.TabIndex = 7
        Me.lblPatRecordsReport.Text = "Patient Records"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(66, 372)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(667, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Either click on a patient number or enter a patient number in the Enter Patient N" & _
    "umber box"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPatRecordsReport)
        Me.Controls.Add(Me.lvPatRecords)
        Me.Controls.Add(Me.lblEnterPatNum)
        Me.Controls.Add(Me.txtPatNum)
        Me.Controls.Add(Me.lvPatientNumbers)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnReport)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Old Customer Information"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lvPatientNumbers As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtPatNum As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterPatNum As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblPatRecordsReport As System.Windows.Forms.Label
    Friend WithEvents lvPatRecords As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
