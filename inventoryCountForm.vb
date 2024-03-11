Imports MySql.Data.MySqlClient
Public Class inventoryCountForm
    Private myConString As String = "server=localhost;uid=root;pwd=;database=vgc;"
    Private conn As MySqlConnection

    Private Sub populateDGV()
        Try
            conn.ConnectionString = myConString
            Dim query As String = "SELECT id, article, description, um, unitValue, dateOfPurchase, location, condit, remarks FROM inventory"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            dgvInventory.Rows.Clear()
            For Each row As DataRow In dataTable.Rows
                dgvInventory.Rows.Add(row.ItemArray)
            Next
            dgvInventory.ClearSelection()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub clearForm()
        populateDGV()
        dgvInventory.ClearSelection()
        tbxSearch.Clear()
        tbxArticle.Clear()
        tbxDescription.Clear()
        tbxPropNum.Clear()
        tbxNewPropNum.Clear()
        cbxUm.SelectedIndex = 0
        tbxUnitVal.Clear()
        tbxQtyPhysCount.Clear()
        tbxQtyPropCard.Clear()
        tbxLoc.Clear()
        dtpPurchase.ResetText()
        cbxCondition.SelectedIndex = 0
        tbxRemarks.Clear()
    End Sub
    Private Sub tbxSearch_TextChanged(sender As Object, e As EventArgs) Handles tbxSearch.TextChanged
        'search keyword on textchange
    End Sub
    Private Sub dgvInventory_SelectionChanged(sender As Object, e As EventArgs) Handles dgvInventory.SelectionChanged
        If dgvInventory.SelectedRows.Count > 0 AndAlso dgvInventory.Columns.Contains("id") Then
            Dim selectedRow As DataGridViewRow = dgvInventory.SelectedRows(0)
            Dim idColumn As DataGridViewColumn = dgvInventory.Columns("id")
            If idColumn IsNot Nothing Then
                Dim columnIndex As Integer = idColumn.Index
                Dim selectedID As Integer = Convert.ToInt32(selectedRow.Cells(columnIndex).Value)
                ' Fetch data from the database based on the selected ID
                Dim query As String = "SELECT * FROM inventory WHERE id = @id"
                Try
                    Using connection As New MySqlConnection(myConString)
                        Using command As New MySqlCommand(query, connection)
                            command.Parameters.AddWithValue("@id", selectedID)
                            connection.Open()
                            Dim reader As MySqlDataReader = command.ExecuteReader()
                            If reader.Read() Then
                                tbxArticle.Text = reader("article").ToString()
                                tbxDescription.Text = reader("description").ToString()
                                Dim purchaseDate As DateTime
                                If DateTime.TryParse(reader("dateOfPurchase").ToString(), purchaseDate) Then
                                    dtpPurchase.Value = purchaseDate
                                Else
                                    MessageBox.Show("Invalid date format in database.")
                                End If
                                tbxLoc.Text = reader("location").ToString
                                tbxUnitVal.Text = reader("unitValue").ToString
                                cbxUm.Text = reader("um").ToString
                                cbxCondition.Text = reader("condit").ToString
                                tbxRemarks.Text = reader("remarks").ToString
                                tbxPropNum.Text = reader("propNum").ToString
                                tbxNewPropNum.Text = reader("newPropNum").ToString
                                tbxQtyPropCard.Text = reader("qtyPropCard").ToString
                                tbxQtyPhysCount.Text = reader("qtyPhysCount").ToString
                            Else
                                MessageBox.Show("No data found for the selected ID.")
                            End If
                            reader.Close()
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Column 'id' not found.")
            End If
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to add this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim query As String = "INSERT INTO inventory (article, description, um, unitValue, dateOfPurchase, location, condit, remarks, propNum, newPropNum, qtyPropCard, qtyPhysCount) VALUES (@article, @description, @um, @unitValue, @dateOfPurchase, @location, @condit, @remarks, @propNum, @newPropNum, @qtyPropCard, @qtyPhysCount)"
            Try
                Using connection As New MySqlConnection(myConString)
                    Using command As New MySqlCommand(query, connection)
                        ' Add parameters
                        command.Parameters.AddWithValue("@article", tbxArticle.Text)
                        command.Parameters.AddWithValue("@description", tbxDescription.Text)
                        command.Parameters.AddWithValue("@um", cbxUm.Text)
                        command.Parameters.AddWithValue("@unitValue", tbxUnitVal.Text)
                        command.Parameters.AddWithValue("@dateOfPurchase", dtpPurchase.Text)
                        command.Parameters.AddWithValue("@location", tbxLoc.Text)
                        command.Parameters.AddWithValue("@condit", cbxCondition.Text)
                        command.Parameters.AddWithValue("@remarks", tbxRemarks.Text)
                        command.Parameters.AddWithValue("@propNum", tbxPropNum.Text)
                        command.Parameters.AddWithValue("@newPropNum", tbxNewPropNum.Text)
                        command.Parameters.AddWithValue("@qtyPropCard", tbxQtyPropCard.Text)
                        command.Parameters.AddWithValue("@qtyPhysCount", tbxQtyPhysCount.Text)
                        connection.Open()
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Item added successfully!")
                            clearForm()
                        Else
                            MessageBox.Show("Failed to add item!")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearForm()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'update from db where id = selected id
        'clearform
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvInventory.SelectedRows.Count > 0 AndAlso dgvInventory.Columns.Contains("id") Then
            Dim selectedRow As DataGridViewRow = dgvInventory.SelectedRows(0)
            Dim idColumn As DataGridViewColumn = dgvInventory.Columns("id")
            If idColumn IsNot Nothing Then
                Dim columnIndex As Integer = idColumn.Index
                Dim selectedID As Integer = Convert.ToInt32(selectedRow.Cells(columnIndex).Value)
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Dim query As String = "DELETE FROM inventory WHERE id = @id"
                    Try
                        Using connection As New MySqlConnection(myConString)
                            Using command As New MySqlCommand(query, connection)
                                command.Parameters.AddWithValue("@id", selectedID)
                                connection.Open()
                                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                                If rowsAffected > 0 Then
                                    MessageBox.Show("Item deleted successfully!")
                                    clearForm()
                                Else
                                    MessageBox.Show("No item deleted.")
                                End If
                            End Using
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error: " & ex.Message)
                    End Try
                End If
            Else
                MessageBox.Show("Column 'id' not found.")
            End If
        Else
            MessageBox.Show("No row selected.")
        End If
    End Sub
    Private Sub inventoryCountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection(myConString)
        Try
            populateDGV()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        clearForm()
    End Sub
    Private Sub inventoryCountForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Class