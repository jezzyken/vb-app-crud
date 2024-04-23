Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class Form1

    Dim connectionString As String = "Server=localhost;Database=db_rivera_group_1;Uid=root;Pwd=capricorn1973@;"
    Dim connection As New MySqlConnection(connectionString)

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

    Private Sub lsvIten_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvIten.SelectedIndexChanged
        If lsvIten.SelectedItems.Count > 0 Then
            Dim selectedItem = lsvIten.SelectedItems(0)

            Dim newItem = selectedItem.SubItems(0).Text

            txtItem.Text = newItem

        Else
            txtItem.Clear()

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        For Each item As ListViewItem In lsvIten.Items
            Dim newItem As New ListViewItem(item.Text)

            For i As Integer = 1 To item.SubItems.Count - 1
                newItem.SubItems.Add(item.SubItems(i).Text)
            Next

            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "INSERT INTO tbl_item (item) VALUES (@item);"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@item", newItem.Text)

                Try
                    connection.Open()
                    If command.ExecuteNonQuery() > 0 Then

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
        LsvItemList.Clear()
        LsvItemList.Columns.Add("ID")
        LsvItemList.Columns.Add("Item")
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM tbl_item;"
            Dim command As New MySqlCommand(query, connection)

            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim lvItem As New ListViewItem({reader.GetInt32("id").ToString(), reader("item").ToString()})
                    LsvItemList.Items.Add(lvItem)
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

    Private Sub LsvItemList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LsvItemList.SelectedIndexChanged

    End Sub
End Class
