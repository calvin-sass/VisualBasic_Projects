Public Class frmCoverage
    Public SelectedCoverageChar As Char

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If radFull.Checked Then
            SelectedCoverageChar = "F"c
        ElseIf radPartial.Checked Then
            SelectedCoverageChar = "P"c
        ElseIf radNone.Checked Then
            SelectedCoverageChar = "N"c
        Else
            SelectedCoverageChar = "."c
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
