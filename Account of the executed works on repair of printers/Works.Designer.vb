<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Works
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Works))
        Me.База_данныхDataSet = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSet
        Me.РаботаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.РаботаTableAdapter = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.РаботаTableAdapter
        Me.TableAdapterManager = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.TableAdapterManager
        Me.ТипыРаботTableAdapter = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.ТипыРаботTableAdapter
        Me.РаботаBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.РаботаBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.РаботаDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.ТипыРаботBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        CType(Me.База_данныхDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РаботаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РаботаBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.РаботаBindingNavigator.SuspendLayout()
        CType(Me.РаботаDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ТипыРаботBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'База_данныхDataSet
        '
        Me.База_данныхDataSet.DataSetName = "База_данныхDataSet"
        Me.База_данныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'РаботаBindingSource
        '
        Me.РаботаBindingSource.DataMember = "Работа"
        Me.РаботаBindingSource.DataSource = Me.База_данныхDataSet
        '
        'РаботаTableAdapter
        '
        Me.РаботаTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ЗаказыTableAdapter = Nothing
        Me.TableAdapterManager.МаркиTableAdapter = Nothing
        Me.TableAdapterManager.МоделиTableAdapter = Nothing
        Me.TableAdapterManager.ПринтерыTableAdapter = Nothing
        Me.TableAdapterManager.РаботаTableAdapter = Me.РаботаTableAdapter
        Me.TableAdapterManager.ТипыРаботTableAdapter = Me.ТипыРаботTableAdapter
        '
        'ТипыРаботTableAdapter
        '
        Me.ТипыРаботTableAdapter.ClearBeforeFill = True
        '
        'РаботаBindingNavigator
        '
        Me.РаботаBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.РаботаBindingNavigator.BindingSource = Me.РаботаBindingSource
        Me.РаботаBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.РаботаBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.РаботаBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.РаботаBindingNavigatorSaveItem})
        Me.РаботаBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.РаботаBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.РаботаBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.РаботаBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.РаботаBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.РаботаBindingNavigator.Name = "РаботаBindingNavigator"
        Me.РаботаBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.РаботаBindingNavigator.Size = New System.Drawing.Size(766, 25)
        Me.РаботаBindingNavigator.TabIndex = 0
        Me.РаботаBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'РаботаBindingNavigatorSaveItem
        '
        Me.РаботаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.РаботаBindingNavigatorSaveItem.Image = CType(resources.GetObject("РаботаBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.РаботаBindingNavigatorSaveItem.Name = "РаботаBindingNavigatorSaveItem"
        Me.РаботаBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.РаботаBindingNavigatorSaveItem.Text = "Save Data"
        '
        'РаботаDataGridView
        '
        Me.РаботаDataGridView.AutoGenerateColumns = False
        Me.РаботаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.РаботаDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.РаботаDataGridView.DataSource = Me.РаботаBindingSource
        Me.РаботаDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.РаботаDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.РаботаDataGridView.Name = "РаботаDataGridView"
        Me.РаботаDataGridView.Size = New System.Drawing.Size(766, 289)
        Me.РаботаDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "КодТипаРабот"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.ТипыРаботBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "ТипРабот"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Вид комплектующих"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "КодТипаРабот"
        '
        'ТипыРаботBindingSource
        '
        Me.ТипыРаботBindingSource.DataMember = "ТипыРабот"
        Me.ТипыРаботBindingSource.DataSource = Me.База_данныхDataSet
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ВидРаботы"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Комплектующие"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "СуммаРаботы"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Стоимость, руб"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 314)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(766, 241)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Поиск"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Критерий:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(152, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Применить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(127, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Works
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(766, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.РаботаDataGridView)
        Me.Controls.Add(Me.РаботаBindingNavigator)
        Me.Name = "Works"
        Me.Text = "Works"
        CType(Me.База_данныхDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РаботаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РаботаBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.РаботаBindingNavigator.ResumeLayout(False)
        Me.РаботаBindingNavigator.PerformLayout()
        CType(Me.РаботаDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ТипыРаботBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents База_данныхDataSet As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSet
    Friend WithEvents РаботаBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents РаботаTableAdapter As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.РаботаTableAdapter
    Friend WithEvents TableAdapterManager As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.TableAdapterManager
    Friend WithEvents РаботаBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents РаботаBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents РаботаDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ТипыРаботTableAdapter As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.ТипыРаботTableAdapter
    Friend WithEvents ТипыРаботBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
