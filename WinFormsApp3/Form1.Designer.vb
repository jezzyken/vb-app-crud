<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtItem = New TextBox()
        lsvIten = New ListView()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        Label1 = New Label()
        btnClear = New Button()
        txtTotal = New TextBox()
        btnClose = New Button()
        btnNewUpdate = New Button()
        btnNewDelete = New Button()
        txtUpdate = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button1 = New Button()
        ListNewItem = New ListView()
        SuspendLayout()
        ' 
        ' txtItem
        ' 
        txtItem.BackColor = SystemColors.InactiveCaption
        txtItem.Location = New Point(12, 13)
        txtItem.Name = "txtItem"
        txtItem.Size = New Size(180, 23)
        txtItem.TabIndex = 0
        txtItem.Text = "fgddyft"
        ' 
        ' lsvIten
        ' 
        lsvIten.BackColor = SystemColors.GrayText
        lsvIten.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lsvIten.ForeColor = SystemColors.InfoText
        lsvIten.Location = New Point(12, 56)
        lsvIten.MultiSelect = False
        lsvIten.Name = "lsvIten"
        lsvIten.Size = New Size(180, 168)
        lsvIten.TabIndex = 1
        lsvIten.UseCompatibleStateImageBehavior = False
        lsvIten.View = View.List
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.Highlight
        btnAdd.Location = New Point(198, 56)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = SystemColors.GradientActiveCaption
        btnUpdate.Location = New Point(198, 85)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.AppWorkspace
        btnDelete.BackgroundImageLayout = ImageLayout.None
        btnDelete.Location = New Point(198, 114)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 4
        btnDelete.Tag = "btnDelete"
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 237)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 5
        Label1.Text = "Total Items"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.InactiveCaption
        btnClear.Location = New Point(198, 172)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 6
        btnClear.Tag = "btnDelete"
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' txtTotal
        ' 
        txtTotal.BackColor = Color.OrangeRed
        txtTotal.BorderStyle = BorderStyle.FixedSingle
        txtTotal.Location = New Point(82, 235)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(52, 23)
        txtTotal.TabIndex = 7
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = SystemColors.MenuHighlight
        btnClose.Location = New Point(198, 201)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 8
        btnClose.Tag = "btnDelete"
        btnClose.Text = "Exit"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnNewUpdate
        ' 
        btnNewUpdate.BackColor = SystemColors.ActiveCaption
        btnNewUpdate.Location = New Point(538, 229)
        btnNewUpdate.Name = "btnNewUpdate"
        btnNewUpdate.Size = New Size(75, 23)
        btnNewUpdate.TabIndex = 15
        btnNewUpdate.Text = "Update"
        btnNewUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnNewDelete
        ' 
        btnNewDelete.BackColor = Color.IndianRed
        btnNewDelete.Location = New Point(619, 228)
        btnNewDelete.Name = "btnNewDelete"
        btnNewDelete.Size = New Size(75, 23)
        btnNewDelete.TabIndex = 16
        btnNewDelete.Text = "Delete"
        btnNewDelete.UseVisualStyleBackColor = False
        ' 
        ' txtUpdate
        ' 
        txtUpdate.BackColor = Color.DarkSalmon
        txtUpdate.Location = New Point(295, 25)
        txtUpdate.Name = "txtUpdate"
        txtUpdate.Size = New Size(156, 23)
        txtUpdate.TabIndex = 17
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.MenuHighlight
        Button2.Location = New Point(457, 230)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 20
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.RosyBrown
        Button3.Location = New Point(376, 229)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 21
        Button3.Text = "Refresh"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkOrange
        Button4.Location = New Point(295, 228)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 22
        Button4.Text = "Export"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.AppWorkspace
        Button1.Location = New Point(198, 143)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 10
        Button1.Text = "Save"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ListNewItem
        ' 
        ListNewItem.BackColor = SystemColors.MenuHighlight
        ListNewItem.FullRowSelect = True
        ListNewItem.Location = New Point(295, 54)
        ListNewItem.Name = "ListNewItem"
        ListNewItem.Size = New Size(399, 168)
        ListNewItem.TabIndex = 19
        ListNewItem.UseCompatibleStateImageBehavior = False
        ListNewItem.View = View.Details
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(710, 273)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(ListNewItem)
        Controls.Add(txtUpdate)
        Controls.Add(btnNewDelete)
        Controls.Add(Button1)
        Controls.Add(btnNewUpdate)
        Controls.Add(btnClose)
        Controls.Add(txtTotal)
        Controls.Add(btnClear)
        Controls.Add(Label1)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(lsvIten)
        Controls.Add(txtItem)
        ForeColor = SystemColors.Desktop
        FormBorderStyle = FormBorderStyle.Fixed3D
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Tag = " "
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtItem As TextBox
    Friend WithEvents lsvIten As ListView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnNewUpdate As Button
    Friend WithEvents btnNewDelete As Button
    Friend WithEvents txtUpdate As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ListNewItem As ListView

End Class
