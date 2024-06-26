﻿Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml.Serialization
Imports Excel = Microsoft.Office.Interop.Excel
Imports OfficeOpenXml
Imports System.IO


Public Class Form1

    Dim connectionString As String = "Server=localhost;Database=db_rivera_group_1;Uid=root;Pwd=capricorn1973@;"
    Dim connection As New MySqlConnection(connectionString)
    Dim _itemId

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getTotalItems()
        LoadData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim newItem As New ListViewItem({txtItem.Text})
        lsvIten.Items.Add(newItem)
        getTotalItems()
        txtItem.Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If lsvIten.SelectedItems.Count > 0 Then
            lsvIten.SelectedItems(0).SubItems(0).Text = txtItem.Text
            getTotalItems()

        Else
            MessageBox.Show("Please select an item to edit.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lsvIten.SelectedItems.Count > 0 Then
            If MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                lsvIten.Items.Remove(lsvIten.SelectedItems(0))
                getTotalItems()
            End If
        Else
            MessageBox.Show("Please select an item to delete.")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lsvIten.Clear()
        txtItem.Clear()
        getTotalItems()
    End Sub

    Private Sub getTotalItems()

        Dim itemCount As Integer = lsvIten.Items.Count
        txtTotal.Text = itemCount.ToString()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lsvIten_SelectedIndexChanged(sender As Object, e As EventArgs)
        If lsvIten.SelectedItems.Count > 0 Then
            Dim selectedItem = lsvIten.SelectedItems(0)

            Dim newItem = selectedItem.SubItems(0).Text

            txtItem.Text = newItem

        Else
            txtItem.Clear()

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each item As ListViewItem In lsvIten.Items
            Dim newItem As New ListViewItem(item.Text)

            For i = 1 To item.SubItems.Count - 1
                newItem.SubItems.Add(item.SubItems(i).Text)
            Next

            Using connection As New MySqlConnection(connectionString)
                Dim query = "INSERT INTO tbl_item (item) VALUES (@item);"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@item", newItem.Text)

                Try
                    connection.Open()
                    If command.ExecuteNonQuery() <= 0 Then

                    End If
                    Continue For
                    If command.ExecuteNonQuery > 0 Then

                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        Next

        MessageBox.Show("Record added successfully.")
        lsvIten.Clear()
        LoadData()
    End Sub

    Public Sub LoadData()
        ListNewItem.Clear()
        ListNewItem.Columns.Add("ID")
        ListNewItem.Columns.Add("Item")
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM tbl_item;"
            Dim command As New MySqlCommand(query, connection)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim lvItem As New ListViewItem({reader.GetInt32("id").ToString(), reader("item").ToString()})
                    ListNewItem.Items.Add(lvItem)
                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtItem_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged

    End Sub

    Private Sub ListNewItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListNewItem.SelectedIndexChanged
        If ListNewItem.SelectedItems.Count > 0 Then
            Dim selectedIndex = ListNewItem.SelectedIndices(0)
            Dim txtUpdateItem = ListNewItem.SelectedItems(0).SubItems(1).Text
            _itemId = selectedIndex.ToString
            txtUpdate.Text = txtUpdateItem
        End If
    End Sub

    Private Sub UpdateDatabase(id As String, newItem As String)
        Using connection As New MySqlConnection(connectionString)
            ' Open the connection
            connection.Open()

            ' Create the SQL Update Command
            Dim query As String = "UPDATE tbl_item SET item = @item WHERE id = @id"
            Using command As New MySqlCommand(query, connection)
                ' Add the parameters to the command
                command.Parameters.AddWithValue("@item", newItem)
                command.Parameters.AddWithValue("@id", id)

                ' Execute the command
                command.ExecuteNonQuery()
            End Using
        End Using
        MessageBox.Show("Record Updated Successfully")
        Clear()
    End Sub

    Private Sub btnNewUpdate_Click(sender As Object, e As EventArgs) Handles btnNewUpdate.Click
        If ListNewItem.SelectedItems.Count > 0 Then
            Dim selectedId As String = ListNewItem.SelectedItems(0).Text ' Assuming the ID is in the first column
            UpdateDatabase(selectedId, txtUpdate.Text)

        End If
    End Sub

    Private Sub Clear()
        LoadData()
        txtUpdate.Text = ""
    End Sub

    Private Sub btnNewDelete_Click(sender As Object, e As EventArgs) Handles btnNewDelete.Click
        If ListNewItem.SelectedItems.Count > 0 Then
            Dim selectedId As String = ListNewItem.SelectedItems(0).Text
            DeleteRecord(selectedId)
        Else
            MessageBox.Show("Please select an item to delete.")
        End If
    End Sub

    Private Sub DeleteRecord(id As String)
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "DELETE FROM tbl_item WHERE id = @id"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", id)

                Dim result As Integer = command.ExecuteNonQuery()
                If result > 0 Then
                    MessageBox.Show("Record Deleted Successfully")
                    Clear()
                Else
                    MessageBox.Show("No record was deleted. Please check the ID.")
                End If
            End Using
        End Using
    End Sub

    Private Sub btnNewClear_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtUpdate.Text = ""

    End Sub

    Private Sub btnNewRefresh_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Call a method to refresh the data in ListNewItem

        RefreshListNewItem()
    End Sub

    Private Sub RefreshListNewItem()
        ' txtUpdate.Text() = "Data has been refreshed"
        LoadData()
        MessageBox.Show("Database Refreshed")
    End Sub

    Private Sub btnNewExport_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connectionString As String = "Server=localhost;Database=db_rivera_group_1;Uid=root;Pwd=capricorn1973@;"
        Dim query As String = "SELECT * FROM tbl_item"

        ' Set EPPlus license context
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    Dim dataTable As New DataTable()
                    dataTable.Load(reader)

                    If dataTable.Rows.Count > 0 Then
                        Using package As New ExcelPackage()
                            Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Sheet1")

                            ' Write column names
                            For i As Integer = 0 To dataTable.Columns.Count - 1
                                worksheet.Cells(1, i + 1).Value = dataTable.Columns(i).ColumnName
                            Next

                            ' Write data
                            For i As Integer = 0 To dataTable.Rows.Count - 1
                                For j As Integer = 0 To dataTable.Columns.Count - 1
                                    worksheet.Cells(i + 2, j + 1).Value = dataTable.Rows(i)(j).ToString()
                                Next
                            Next

                            ' Save the Excel file
                            Dim saveFileDialog As New SaveFileDialog()
                            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx"
                            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                                Dim fileStream As New FileStream(saveFileDialog.FileName, FileMode.Create)
                                package.SaveAs(fileStream)
                                fileStream.Close()
                            End If
                        End Using
                    Else
                        MessageBox.Show("No data to export.")
                    End If
                End Using
            End Using
        End Using

    End Sub
End Class
