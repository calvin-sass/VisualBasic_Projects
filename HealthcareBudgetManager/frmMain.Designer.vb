<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lstDepartments = New ListBox()
        lblServiceStatus = New Label()
        lblCheckup = New Label()
        lblSpecialist = New Label()
        lblDental = New Label()
        lblVision = New Label()
        lblPharmacy = New Label()
        lblEmergency = New Label()
        txtA = New TextBox()
        txtB = New TextBox()
        txtC = New TextBox()
        txtD = New TextBox()
        txtE = New TextBox()
        txtF = New TextBox()
        btnSummary = New Button()
        SuspendLayout()
        ' 
        ' lstDepartments
        ' 
        lstDepartments.FormattingEnabled = True
        lstDepartments.Location = New Point(20, 20)
        lstDepartments.Name = "lstDepartments"
        lstDepartments.Size = New Size(768, 244)
        lstDepartments.TabIndex = 0
        ' 
        ' lblServiceStatus
        ' 
        lblServiceStatus.AutoSize = True
        lblServiceStatus.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblServiceStatus.Location = New Point(259, 272)
        lblServiceStatus.Name = "lblServiceStatus"
        lblServiceStatus.Size = New Size(286, 32)
        lblServiceStatus.TabIndex = 1
        lblServiceStatus.Text = "Service Coverage Status"
        ' 
        ' lblCheckup
        ' 
        lblCheckup.AutoSize = True
        lblCheckup.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCheckup.Location = New Point(20, 318)
        lblCheckup.Name = "lblCheckup"
        lblCheckup.Size = New Size(106, 25)
        lblCheckup.TabIndex = 2
        lblCheckup.Text = "A: Checkup"
        ' 
        ' lblSpecialist
        ' 
        lblSpecialist.AutoSize = True
        lblSpecialist.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSpecialist.Location = New Point(154, 318)
        lblSpecialist.Name = "lblSpecialist"
        lblSpecialist.Size = New Size(111, 25)
        lblSpecialist.TabIndex = 3
        lblSpecialist.Text = "B: Specialist"
        ' 
        ' lblDental
        ' 
        lblDental.AutoSize = True
        lblDental.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDental.Location = New Point(295, 318)
        lblDental.Name = "lblDental"
        lblDental.Size = New Size(88, 25)
        lblDental.TabIndex = 4
        lblDental.Text = "C: Dental"
        ' 
        ' lblVision
        ' 
        lblVision.AutoSize = True
        lblVision.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblVision.Location = New Point(414, 318)
        lblVision.Name = "lblVision"
        lblVision.Size = New Size(86, 25)
        lblVision.TabIndex = 5
        lblVision.Text = "D: Vision"
        ' 
        ' lblPharmacy
        ' 
        lblPharmacy.AutoSize = True
        lblPharmacy.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPharmacy.Location = New Point(525, 318)
        lblPharmacy.Name = "lblPharmacy"
        lblPharmacy.Size = New Size(114, 25)
        lblPharmacy.TabIndex = 6
        lblPharmacy.Text = "E: Pharmacy"
        ' 
        ' lblEmergency
        ' 
        lblEmergency.AutoSize = True
        lblEmergency.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmergency.Location = New Point(655, 318)
        lblEmergency.Name = "lblEmergency"
        lblEmergency.Size = New Size(123, 25)
        lblEmergency.TabIndex = 7
        lblEmergency.Text = "F: Emergency"
        ' 
        ' txtA
        ' 
        txtA.Location = New Point(20, 346)
        txtA.Name = "txtA"
        txtA.ReadOnly = True
        txtA.Size = New Size(106, 23)
        txtA.TabIndex = 8
        txtA.Tag = "A"
        txtA.Text = "."
        ' 
        ' txtB
        ' 
        txtB.Location = New Point(154, 346)
        txtB.Name = "txtB"
        txtB.ReadOnly = True
        txtB.Size = New Size(111, 23)
        txtB.TabIndex = 9
        txtB.Tag = "B"
        txtB.Text = "."
        ' 
        ' txtC
        ' 
        txtC.Location = New Point(295, 346)
        txtC.Name = "txtC"
        txtC.ReadOnly = True
        txtC.Size = New Size(88, 23)
        txtC.TabIndex = 10
        txtC.Tag = "C"
        txtC.Text = "."
        ' 
        ' txtD
        ' 
        txtD.Location = New Point(414, 346)
        txtD.Name = "txtD"
        txtD.ReadOnly = True
        txtD.Size = New Size(86, 23)
        txtD.TabIndex = 11
        txtD.Tag = "D"
        txtD.Text = "."
        ' 
        ' txtE
        ' 
        txtE.Location = New Point(525, 346)
        txtE.Name = "txtE"
        txtE.ReadOnly = True
        txtE.Size = New Size(114, 23)
        txtE.TabIndex = 12
        txtE.Tag = "E"
        txtE.Text = "."
        ' 
        ' txtF
        ' 
        txtF.Location = New Point(655, 346)
        txtF.Name = "txtF"
        txtF.ReadOnly = True
        txtF.Size = New Size(123, 23)
        txtF.TabIndex = 13
        txtF.Tag = "F"
        txtF.Text = "."
        ' 
        ' btnSummary
        ' 
        btnSummary.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnSummary.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSummary.Location = New Point(211, 390)
        btnSummary.Name = "btnSummary"
        btnSummary.Size = New Size(389, 48)
        btnSummary.TabIndex = 14
        btnSummary.Text = "View Summary"
        btnSummary.UseVisualStyleBackColor = False
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(800, 450)
        Controls.Add(btnSummary)
        Controls.Add(txtF)
        Controls.Add(txtE)
        Controls.Add(txtD)
        Controls.Add(txtC)
        Controls.Add(txtB)
        Controls.Add(txtA)
        Controls.Add(lblEmergency)
        Controls.Add(lblPharmacy)
        Controls.Add(lblVision)
        Controls.Add(lblDental)
        Controls.Add(lblSpecialist)
        Controls.Add(lblCheckup)
        Controls.Add(lblServiceStatus)
        Controls.Add(lstDepartments)
        Name = "frmMain"
        Text = "Healthcare Budget App"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstDepartments As ListBox
    Friend WithEvents lblServiceStatus As Label
    Friend WithEvents lblCheckup As Label
    Friend WithEvents lblSpecialist As Label
    Friend WithEvents lblDental As Label
    Friend WithEvents lblVision As Label
    Friend WithEvents lblPharmacy As Label
    Friend WithEvents lblEmergency As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents txtD As TextBox
    Friend WithEvents txtE As TextBox
    Friend WithEvents txtF As TextBox
    Friend WithEvents btnSummary As Button

End Class
