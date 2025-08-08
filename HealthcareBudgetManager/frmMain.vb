Public Class frmMain
    Dim schedule(14, 5) As Char ' 15 departments, 6 services A–F
    Dim selectedDept As Integer
    Dim selectedCategoryIndex As Integer

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 15
            lstDepartments.Items.Add($"Department {i}: ......")
            For j = 0 To 5
                schedule(i - 1, j) = "."c
            Next
        Next
    End Sub

    Private Sub lstDepartments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDepartments.SelectedIndexChanged
        selectedDept = lstDepartments.SelectedIndex
        If selectedDept >= 0 Then
            txtA.Text = schedule(selectedDept, 0)
            txtB.Text = schedule(selectedDept, 1)
            txtC.Text = schedule(selectedDept, 2)
            txtD.Text = schedule(selectedDept, 3)
            txtE.Text = schedule(selectedDept, 4)
            txtF.Text = schedule(selectedDept, 5)
        End If
    End Sub

    Private Sub ServiceTextBox_Click(sender As Object, e As EventArgs) Handles txtA.Click, txtB.Click, txtC.Click, txtD.Click, txtE.Click, txtF.Click
        Dim tb = DirectCast(sender, TextBox)
        selectedCategoryIndex = Asc(tb.Tag.ToString()) - Asc("A")

        Dim coverageForm As New frmCoverage()
        If coverageForm.ShowDialog() = DialogResult.OK Then
            Dim statusChar = coverageForm.SelectedCoverageChar
            tb.Text = statusChar
            schedule(selectedDept, selectedCategoryIndex) = statusChar
            UpdateListBoxEntry()
        End If
    End Sub

    Private Sub UpdateListBoxEntry()
        Dim line As String = $"Department {selectedDept + 1}: "
        For i = 0 To 5
            line &= schedule(selectedDept, i)
        Next
        lstDepartments.Items(selectedDept) = line
    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        Dim full As Integer = 0
        Dim partialCount As Integer = 0
        Dim none As Integer = 0
        Dim total As Integer = 0
        Dim preventiveSlots As Integer = 0

        For dept = 0 To 14
            For cat = 0 To 5
                Dim val = schedule(dept, cat)
                Select Case val
                    Case "F"c : full += 1
                    Case "P"c : partialCount += 1
                    Case "N"c : none += 1
                End Select

                If val <> "."c Then total += 1
            Next

            ' Category A (index 0) represents preventive care
            If schedule(dept, 0) = "."c Then
                preventiveSlots += 1
            End If
        Next

        MessageBox.Show($"Scheduled Services: {total}" & vbCrLf &
                        $"Preventive Care Slots: {preventiveSlots}" & vbCrLf &
                        $"Full: {full}, Partial: {partialCount}, No Coverage: {none}")
    End Sub
End Class
