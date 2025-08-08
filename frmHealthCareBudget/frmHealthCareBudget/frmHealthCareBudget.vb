Imports System.IO
Imports System.Globalization

Public Class frmHealthCareBudget
    Dim filePath As String = "Healthcare.txt"

    '1. Apply 20% discount and save to Healthcare2.txt
    Private Sub btnDiscountPrices_Click(sender As Object, e As EventArgs) Handles btnDiscountPrices.Click
        ' Check if the file exists
        If Not File.Exists(filePath) Then
            MessageBox.Show("Healthcare.txt not found.")
            Return
        End If

        'Create variable to save information
        Dim lines = File.ReadAllLines(filePath)
        Dim newLines As New List(Of String)

        ' Save discounted prices in Healthcare2.txt
        For Each line As String In lines
            Dim parts = line.Replace(", ", ",").Split(","c)
            Dim name = parts(0).Trim()
            Dim cost = Double.Parse(parts(1).Trim(), CultureInfo.InvariantCulture)

            Dim discountedPrice = cost * 0.8
            newLines.Add($"{name}, {discountedPrice.ToString("F2", CultureInfo.InvariantCulture)}")
        Next

        File.WriteAllLines("Healthcare2.txt", newLines)
        MessageBox.Show("Discounted prices saved to Healthcare2.txt")
    End Sub

    '2. Add "Dental Cleaning, 95.00" to end of file
    Private Sub btnAddDental_Click(sender As Object, e As EventArgs) Handles btnAddDental.Click
        Using sw As StreamWriter = File.AppendText(filePath)
            sw.WriteLine()
            sw.WriteLine("Dental Cleaning, 95.00")
        End Using
        MessageBox.Show("Dental Cleaning added.")
    End Sub

    '3. Show budget breakdown using the order list
    Private Sub btnBreakdown_Click(sender As Object, e As EventArgs) Handles btnBreakdown.Click
        Dim orderFile As String = "HealthcareOrder.txt"
        File.WriteAllText(orderFile, "1,2,3,1,1") ' Fixed order for this example

        Dim quantities = File.ReadAllText(orderFile).Split(","c).Select(Function(x) CInt(x.Trim())).ToArray()
        Dim lines = File.ReadAllLines(filePath)

        If lines.Length < quantities.Length Then
            MessageBox.Show("Not enough items in file for the order list")
            Return
        End If

        Dim total As Double = 0
        Dim result As String = ""

        For i As Integer = 0 To quantities.Length - 1
            Dim parts = lines(i).Replace(", ", ",").Split(","c)
            Dim name = parts(0).Trim()
            Dim price = Double.Parse(parts(1).Trim(), CultureInfo.InvariantCulture)
            Dim qty = quantities(i)
            Dim cost = qty * price
            total += cost
            result &= $"{qty} x {name} @ R{price.ToString("F2", CultureInfo.InvariantCulture)} = R{cost.ToString("F2", CultureInfo.InvariantCulture)}" & Environment.NewLine
        Next

        result &= Environment.NewLine & $"Total Healthcare Budget: R{total.ToString("F2", CultureInfo.InvariantCulture)}"
        lblTotal.Text = result
    End Sub

    '4. Insert new item alphabetically and save as Healthcare2.txt
    Private Sub btnInsertSorted_Click(sender As Object, e As EventArgs) Handles btnInsertSorted.Click
        Dim item = InputBox("Enter new item (e.g. Physical Therapy, 80.00):", "Insert New Expense")
        If String.IsNullOrWhiteSpace(item) Then Exit Sub

        Dim allLines = File.ReadAllLines(filePath).ToList()
        allLines.Add(item)

        allLines.Sort(Function(a, b) a.Split(","c)(0).Trim().CompareTo(b.Split(","c)(0).Trim()))
        File.WriteAllLines("Healthcare2.txt", allLines)

        MessageBox.Show("Item inserted alphabetically into Healthcare2.txt.")
    End Sub

    '5. Add multiple items until user cancels
    Private Sub btnAddDynamic_Click(sender As Object, e As EventArgs) Handles btnAddDynamic.Click
        Dim firstEntry As Boolean = True

        While True
            Dim entry = InputBox("Enter item and cost (or leave blank to stop):", "Add Expense")
            If String.IsNullOrWhiteSpace(entry) Then Exit While

            Using sw As StreamWriter = File.AppendText(filePath)
                If firstEntry AndAlso New FileInfo(filePath).Length > 0 Then
                    sw.WriteLine()
                End If

                sw.WriteLine(entry)
            End Using

            firstEntry = False
        End While

        MessageBox.Show("All entries added.")
    End Sub

    '6. Load file into DataGridView
    Private Sub btnLoadGrid_Click(sender As Object, e As EventArgs) Handles btnLoadGrid.Click
        If Not File.Exists(filePath) Then
            MessageBox.Show("Healthcare.txt not found.")
            Return
        End If

        dgvHealthcare.Rows.Clear() ' Clear previous data, keep headers

        For Each line In File.ReadAllLines(filePath)
            Dim parts = line.Split(","c)
            If parts.Length = 2 Then
                dgvHealthcare.Rows.Add(parts(0).Trim(), parts(1).Trim())
            End If
        Next
    End Sub
End Class
