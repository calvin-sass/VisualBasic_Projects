<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCoverage
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
        radUnscheduled = New RadioButton()
        btnOK = New Button()
        radFull = New RadioButton()
        radPartial = New RadioButton()
        radNone = New RadioButton()
        SuspendLayout()
        ' 
        ' radUnscheduled
        ' 
        radUnscheduled.AutoSize = True
        radUnscheduled.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        radUnscheduled.Location = New Point(23, 35)
        radUnscheduled.Name = "radUnscheduled"
        radUnscheduled.Size = New Size(118, 25)
        radUnscheduled.TabIndex = 0
        radUnscheduled.TabStop = True
        radUnscheduled.Text = "Unscheduled"
        radUnscheduled.UseVisualStyleBackColor = True
        ' 
        ' btnOK
        ' 
        btnOK.BackColor = Color.Cyan
        btnOK.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOK.Location = New Point(85, 213)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(95, 42)
        btnOK.TabIndex = 1
        btnOK.Text = "OK"
        btnOK.UseVisualStyleBackColor = False
        ' 
        ' radFull
        ' 
        radFull.AutoSize = True
        radFull.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        radFull.Location = New Point(23, 78)
        radFull.Name = "radFull"
        radFull.Size = New Size(123, 25)
        radFull.TabIndex = 2
        radFull.TabStop = True
        radFull.Text = "Full Coverage"
        radFull.UseVisualStyleBackColor = True
        ' 
        ' radPartial
        ' 
        radPartial.AutoSize = True
        radPartial.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        radPartial.Location = New Point(23, 120)
        radPartial.Name = "radPartial"
        radPartial.Size = New Size(141, 25)
        radPartial.TabIndex = 3
        radPartial.TabStop = True
        radPartial.Text = "Partial Coverage"
        radPartial.UseVisualStyleBackColor = True
        ' 
        ' radNone
        ' 
        radNone.AutoSize = True
        radNone.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        radNone.Location = New Point(23, 161)
        radNone.Name = "radNone"
        radNone.Size = New Size(119, 25)
        radNone.TabIndex = 4
        radNone.TabStop = True
        radNone.Text = "No Coverage"
        radNone.UseVisualStyleBackColor = True
        ' 
        ' frmCoverage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(262, 267)
        Controls.Add(radNone)
        Controls.Add(radPartial)
        Controls.Add(radFull)
        Controls.Add(btnOK)
        Controls.Add(radUnscheduled)
        Name = "frmCoverage"
        Text = "frmCoverage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents radUnscheduled As RadioButton
    Friend WithEvents btnOK As Button
    Friend WithEvents radFull As RadioButton
    Friend WithEvents radPartial As RadioButton
    Friend WithEvents radNone As RadioButton
End Class
