<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHealthCareBudget
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnDiscountPrices = New Button()
        btnAddDental = New Button()
        btnBreakdown = New Button()
        btnInsertSorted = New Button()
        btnAddDynamic = New Button()
        btnLoadGrid = New Button()
        dgvHealthcare = New DataGridView()
        colItem = New DataGridViewTextBoxColumn()
        colCost = New DataGridViewTextBoxColumn()
        lblResultText = New Label()
        lblTotal = New Label()
        CType(dgvHealthcare, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnDiscountPrices
        ' 
        btnDiscountPrices.BackColor = Color.LightGray
        btnDiscountPrices.Location = New Point(32, 16)
        btnDiscountPrices.Name = "btnDiscountPrices"
        btnDiscountPrices.Size = New Size(254, 37)
        btnDiscountPrices.TabIndex = 1
        btnDiscountPrices.Text = "Apply 20% Discount"
        btnDiscountPrices.UseVisualStyleBackColor = False
        ' 
        ' btnAddDental
        ' 
        btnAddDental.BackColor = Color.LightGray
        btnAddDental.Location = New Point(32, 70)
        btnAddDental.Name = "btnAddDental"
        btnAddDental.Size = New Size(254, 37)
        btnAddDental.TabIndex = 2
        btnAddDental.Text = "Add Dental Cleaning"
        btnAddDental.UseVisualStyleBackColor = False
        ' 
        ' btnBreakdown
        ' 
        btnBreakdown.BackColor = Color.LightGray
        btnBreakdown.Location = New Point(32, 126)
        btnBreakdown.Name = "btnBreakdown"
        btnBreakdown.Size = New Size(254, 37)
        btnBreakdown.TabIndex = 3
        btnBreakdown.Text = "Show Budget Breakdown"
        btnBreakdown.UseVisualStyleBackColor = False
        ' 
        ' btnInsertSorted
        ' 
        btnInsertSorted.BackColor = Color.LightGray
        btnInsertSorted.Location = New Point(32, 183)
        btnInsertSorted.Name = "btnInsertSorted"
        btnInsertSorted.Size = New Size(254, 37)
        btnInsertSorted.TabIndex = 4
        btnInsertSorted.Text = "Insert Sorted Expenses"
        btnInsertSorted.UseVisualStyleBackColor = False
        ' 
        ' btnAddDynamic
        ' 
        btnAddDynamic.BackColor = Color.LightGray
        btnAddDynamic.Location = New Point(32, 240)
        btnAddDynamic.Name = "btnAddDynamic"
        btnAddDynamic.Size = New Size(254, 37)
        btnAddDynamic.TabIndex = 5
        btnAddDynamic.Text = "Add More Expenses"
        btnAddDynamic.UseVisualStyleBackColor = False
        ' 
        ' btnLoadGrid
        ' 
        btnLoadGrid.BackColor = Color.LightGray
        btnLoadGrid.Location = New Point(32, 300)
        btnLoadGrid.Name = "btnLoadGrid"
        btnLoadGrid.Size = New Size(254, 37)
        btnLoadGrid.TabIndex = 6
        btnLoadGrid.Text = "Load to GridView"
        btnLoadGrid.UseVisualStyleBackColor = False
        ' 
        ' dgvHealthcare
        ' 
        dgvHealthcare.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHealthcare.Columns.AddRange(New DataGridViewColumn() {colItem, colCost})
        dgvHealthcare.Location = New Point(314, 12)
        dgvHealthcare.Name = "dgvHealthcare"
        dgvHealthcare.Size = New Size(454, 375)
        dgvHealthcare.TabIndex = 7
        ' 
        ' colItem
        ' 
        colItem.HeaderText = "HealthCare Item"
        colItem.Name = "colItem"
        colItem.ReadOnly = True
        colItem.Width = 200
        ' 
        ' colCost
        ' 
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        colCost.DefaultCellStyle = DataGridViewCellStyle2
        colCost.HeaderText = "Cost (R)"
        colCost.Name = "colCost"
        colCost.ReadOnly = True
        colCost.Width = 200
        ' 
        ' lblResultText
        ' 
        lblResultText.AutoSize = True
        lblResultText.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblResultText.Location = New Point(314, 406)
        lblResultText.Name = "lblResultText"
        lblResultText.Size = New Size(67, 21)
        lblResultText.TabIndex = 8
        lblResultText.Text = "Results: "
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(314, 436)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(195, 21)
        lblTotal.TabIndex = 9
        lblTotal.Text = "Budget Breakdown Results"
        ' 
        ' frmHealthCareBudget
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 610)
        Controls.Add(lblTotal)
        Controls.Add(lblResultText)
        Controls.Add(dgvHealthcare)
        Controls.Add(btnLoadGrid)
        Controls.Add(btnAddDynamic)
        Controls.Add(btnInsertSorted)
        Controls.Add(btnBreakdown)
        Controls.Add(btnAddDental)
        Controls.Add(btnDiscountPrices)
        Name = "frmHealthCareBudget"
        Text = "HealthCare Budget App"
        CType(dgvHealthcare, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnDiscountPrices As Button
    Friend WithEvents btnAddDental As Button
    Friend WithEvents btnBreakdown As Button
    Friend WithEvents btnInsertSorted As Button
    Friend WithEvents btnAddDynamic As Button
    Friend WithEvents btnLoadGrid As Button
    Friend WithEvents dgvHealthcare As DataGridView
    Friend WithEvents lblResultText As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents colItem As DataGridViewTextBoxColumn
    Friend WithEvents colCost As DataGridViewTextBoxColumn

End Class
