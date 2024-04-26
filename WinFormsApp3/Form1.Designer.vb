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
        btnSave = New Button()
        btnNewUpdate = New Button()
        btnNewDelete = New Button()
        txtUpdate = New TextBox()
        ListNewItem = New ListView()
        btnNewClear = New Button()
        btnNewRefresh = New Button()
        btnNewExport = New Button()
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
        btnClear.Location = New Point(198, 143)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 6
        btnClear.Tag = "btnDelete"
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' txtTotal
        ' 
        txtTotal.BackColor = SystemColors.ControlLight
        txtTotal.BorderStyle = BorderStyle.FixedSingle
        txtTotal.Location = New Point(73, 235)
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
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.AppWorkspace
        btnSave.Location = New Point(198, 172)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 10
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnNewUpdate
        ' 
        btnNewUpdate.BackColor = SystemColors.ActiveCaption
        btnNewUpdate.Location = New Point(643, 230)
        btnNewUpdate.Name = "btnNewUpdate"
        btnNewUpdate.Size = New Size(75, 23)
        btnNewUpdate.TabIndex = 15
        btnNewUpdate.Text = "Update"
        btnNewUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnNewDelete
        ' 
        btnNewDelete.BackColor = Color.IndianRed
        btnNewDelete.Location = New Point(724, 229)
        btnNewDelete.Name = "btnNewDelete"
        btnNewDelete.Size = New Size(75, 23)
        btnNewDelete.TabIndex = 16
        btnNewDelete.Text = "Delete"
        btnNewDelete.UseVisualStyleBackColor = False
        ' 
        ' txtUpdate
        ' 
        txtUpdate.Location = New Point(335, 27)
        txtUpdate.Name = "txtUpdate"
        txtUpdate.Size = New Size(267, 23)
        txtUpdate.TabIndex = 17
        ' 
        ' ListNewItem
        ' 
        ListNewItem.FullRowSelect = True
        ListNewItem.Location = New Point(335, 55)
        ListNewItem.Name = "ListNewItem"
        ListNewItem.Size = New Size(464, 168)
        ListNewItem.TabIndex = 19
        ListNewItem.UseCompatibleStateImageBehavior = False
        ListNewItem.View = View.Details
        ' 
        ' btnNewClear
        ' 
        btnNewClear.BackColor = SystemColors.MenuHighlight
        btnNewClear.Location = New Point(562, 230)
        btnNewClear.Name = "btnNewClear"
        btnNewClear.Size = New Size(75, 23)
        btnNewClear.TabIndex = 20
        btnNewClear.Text = "Clear"
        btnNewClear.UseVisualStyleBackColor = False
        ' 
        ' btnNewRefresh
        ' 
        btnNewRefresh.BackColor = Color.RosyBrown
        btnNewRefresh.Location = New Point(481, 230)
        btnNewRefresh.Name = "btnNewRefresh"
        btnNewRefresh.Size = New Size(75, 23)
        btnNewRefresh.TabIndex = 21
        btnNewRefresh.Text = "Refresh"
        btnNewRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnNewExport
        ' 
        btnNewExport.BackColor = Color.DarkOrange
        btnNewExport.Location = New Point(400, 230)
        btnNewExport.Name = "btnNewExport"
        btnNewExport.Size = New Size(75, 23)
        btnNewExport.TabIndex = 22
        btnNewExport.Text = "Export"
        btnNewExport.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(841, 273)
        Controls.Add(btnNewExport)
        Controls.Add(btnNewRefresh)
        Controls.Add(btnNewClear)
        Controls.Add(ListNewItem)
        Controls.Add(txtUpdate)
        Controls.Add(btnNewDelete)
        Controls.Add(btnNewUpdate)
        Controls.Add(btnSave)
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
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNewUpdate As Button
    Friend WithEvents btnNewDelete As Button
    Friend WithEvents txtUpdate As TextBox
    Friend WithEvents ListNewItem As ListView
    Friend WithEvents btnNewClear As Button
    Friend WithEvents btnNewRefresh As Button
    Friend WithEvents btnNewExport As Button

End Class
