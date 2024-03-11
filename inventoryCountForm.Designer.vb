<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inventoryCountForm
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbxSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxArticle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxDescription = New System.Windows.Forms.RichTextBox()
        Me.tbxPropNum = New System.Windows.Forms.TextBox()
        Me.tbxNewPropNum = New System.Windows.Forms.TextBox()
        Me.tbxUnitVal = New System.Windows.Forms.TextBox()
        Me.tbxQtyPropCard = New System.Windows.Forms.TextBox()
        Me.cbxUm = New System.Windows.Forms.ComboBox()
        Me.tbxQtyPhysCount = New System.Windows.Forms.TextBox()
        Me.tbxLoc = New System.Windows.Forms.TextBox()
        Me.cbxCondition = New System.Windows.Forms.ComboBox()
        Me.dtpPurchase = New System.Windows.Forms.DateTimePicker()
        Me.tbxRemarks = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "PPE ACCOUNT GROUP:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.Location = New System.Drawing.Point(179, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(238, 14)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "OTHER MACHINERY && EQUIPMENT"
        '
        'dgvInventory
        '
        Me.dgvInventory.AllowUserToAddRows = False
        Me.dgvInventory.AllowUserToDeleteRows = False
        Me.dgvInventory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInventory.BackgroundColor = System.Drawing.Color.White
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvInventory.Location = New System.Drawing.Point(40, 56)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.ReadOnly = True
        Me.dgvInventory.RowHeadersVisible = False
        Me.dgvInventory.RowHeadersWidth = 51
        Me.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInventory.Size = New System.Drawing.Size(1190, 279)
        Me.dgvInventory.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbxSearch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1260, 50)
        Me.Panel1.TabIndex = 25
        '
        'tbxSearch
        '
        Me.tbxSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxSearch.BackColor = System.Drawing.Color.White
        Me.tbxSearch.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSearch.Location = New System.Drawing.Point(1007, 15)
        Me.tbxSearch.Name = "tbxSearch"
        Me.tbxSearch.Size = New System.Drawing.Size(223, 27)
        Me.tbxSearch.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(943, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search:"
        '
        'tbxArticle
        '
        Me.tbxArticle.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxArticle.Location = New System.Drawing.Point(40, 370)
        Me.tbxArticle.Name = "tbxArticle"
        Me.tbxArticle.Size = New System.Drawing.Size(254, 27)
        Me.tbxArticle.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Article:"
        '
        'tbxDescription
        '
        Me.tbxDescription.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxDescription.Location = New System.Drawing.Point(40, 428)
        Me.tbxDescription.Name = "tbxDescription"
        Me.tbxDescription.Size = New System.Drawing.Size(551, 135)
        Me.tbxDescription.TabIndex = 4
        Me.tbxDescription.Text = ""
        '
        'tbxPropNum
        '
        Me.tbxPropNum.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPropNum.Location = New System.Drawing.Point(40, 592)
        Me.tbxPropNum.Name = "tbxPropNum"
        Me.tbxPropNum.Size = New System.Drawing.Size(254, 27)
        Me.tbxPropNum.TabIndex = 6
        '
        'tbxNewPropNum
        '
        Me.tbxNewPropNum.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNewPropNum.Location = New System.Drawing.Point(337, 592)
        Me.tbxNewPropNum.Name = "tbxNewPropNum"
        Me.tbxNewPropNum.Size = New System.Drawing.Size(254, 27)
        Me.tbxNewPropNum.TabIndex = 8
        '
        'tbxUnitVal
        '
        Me.tbxUnitVal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUnitVal.Location = New System.Drawing.Point(337, 656)
        Me.tbxUnitVal.Name = "tbxUnitVal"
        Me.tbxUnitVal.Size = New System.Drawing.Size(254, 27)
        Me.tbxUnitVal.TabIndex = 12
        '
        'tbxQtyPropCard
        '
        Me.tbxQtyPropCard.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxQtyPropCard.Location = New System.Drawing.Point(658, 370)
        Me.tbxQtyPropCard.Name = "tbxQtyPropCard"
        Me.tbxQtyPropCard.Size = New System.Drawing.Size(254, 27)
        Me.tbxQtyPropCard.TabIndex = 14
        '
        'cbxUm
        '
        Me.cbxUm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxUm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxUm.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbxUm.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxUm.FormattingEnabled = True
        Me.cbxUm.Items.AddRange(New Object() {"", "unit1", "unit2", "unit3", "unit4", "unit5"})
        Me.cbxUm.Location = New System.Drawing.Point(40, 657)
        Me.cbxUm.Name = "cbxUm"
        Me.cbxUm.Size = New System.Drawing.Size(254, 30)
        Me.cbxUm.TabIndex = 10
        '
        'tbxQtyPhysCount
        '
        Me.tbxQtyPhysCount.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxQtyPhysCount.Location = New System.Drawing.Point(942, 370)
        Me.tbxQtyPhysCount.Name = "tbxQtyPhysCount"
        Me.tbxQtyPhysCount.Size = New System.Drawing.Size(254, 27)
        Me.tbxQtyPhysCount.TabIndex = 16
        '
        'tbxLoc
        '
        Me.tbxLoc.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLoc.Location = New System.Drawing.Point(658, 428)
        Me.tbxLoc.Name = "tbxLoc"
        Me.tbxLoc.Size = New System.Drawing.Size(538, 27)
        Me.tbxLoc.TabIndex = 18
        '
        'cbxCondition
        '
        Me.cbxCondition.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCondition.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbxCondition.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCondition.FormattingEnabled = True
        Me.cbxCondition.Items.AddRange(New Object() {"", "condition1", "condition2", "condition3", "condition4", "condition5"})
        Me.cbxCondition.Location = New System.Drawing.Point(942, 490)
        Me.cbxCondition.Name = "cbxCondition"
        Me.cbxCondition.Size = New System.Drawing.Size(254, 30)
        Me.cbxCondition.TabIndex = 22
        '
        'dtpPurchase
        '
        Me.dtpPurchase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpPurchase.CustomFormat = "MMM dd, yyyy"
        Me.dtpPurchase.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPurchase.Location = New System.Drawing.Point(658, 493)
        Me.dtpPurchase.Name = "dtpPurchase"
        Me.dtpPurchase.Size = New System.Drawing.Size(206, 26)
        Me.dtpPurchase.TabIndex = 20
        '
        'tbxRemarks
        '
        Me.tbxRemarks.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxRemarks.Location = New System.Drawing.Point(658, 551)
        Me.tbxRemarks.Name = "tbxRemarks"
        Me.tbxRemarks.Size = New System.Drawing.Size(538, 27)
        Me.tbxRemarks.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 411)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 14)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 575)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 14)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Property No.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(334, 575)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 14)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "New Property No.:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(37, 640)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 14)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "UM:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(334, 640)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 14)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Unit Value:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(655, 353)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 14)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Qty. Per Property Card:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(939, 353)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(168, 14)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Qty. Per Physical Count:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(655, 411)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 14)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Location:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(655, 476)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 14)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Date of Purchase:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(939, 473)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 14)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Condition:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(655, 534)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 14)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Remarks:"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnAdd.Location = New System.Drawing.Point(664, 618)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(133, 51)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.SteelBlue
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdate.Location = New System.Drawing.Point(803, 618)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(133, 51)
        Me.btnUpdate.TabIndex = 27
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DimGray
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.Location = New System.Drawing.Point(942, 618)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(133, 51)
        Me.btnClear.TabIndex = 28
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Firebrick
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelete.Location = New System.Drawing.Point(1081, 618)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(133, 51)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 65
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Article"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Description"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "UM"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 85
        '
        'Column5
        '
        Me.Column5.HeaderText = "Unit Value"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 110
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Date of Purchase"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "Location"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "Condition"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "Remarks"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'inventoryCountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(1260, 725)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbxRemarks)
        Me.Controls.Add(Me.dtpPurchase)
        Me.Controls.Add(Me.cbxCondition)
        Me.Controls.Add(Me.tbxLoc)
        Me.Controls.Add(Me.tbxQtyPhysCount)
        Me.Controls.Add(Me.cbxUm)
        Me.Controls.Add(Me.tbxQtyPropCard)
        Me.Controls.Add(Me.tbxUnitVal)
        Me.Controls.Add(Me.tbxNewPropNum)
        Me.Controls.Add(Me.tbxPropNum)
        Me.Controls.Add(Me.tbxDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxArticle)
        Me.Controls.Add(Me.dgvInventory)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "inventoryCountForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Count Form"
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbxSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxArticle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxDescription As RichTextBox
    Friend WithEvents tbxPropNum As TextBox
    Friend WithEvents tbxNewPropNum As TextBox
    Friend WithEvents tbxUnitVal As TextBox
    Friend WithEvents tbxQtyPropCard As TextBox
    Friend WithEvents cbxUm As ComboBox
    Friend WithEvents tbxQtyPhysCount As TextBox
    Friend WithEvents tbxLoc As TextBox
    Friend WithEvents cbxCondition As ComboBox
    Friend WithEvents dtpPurchase As DateTimePicker
    Friend WithEvents tbxRemarks As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
