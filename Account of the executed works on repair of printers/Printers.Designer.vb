<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Printers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Printers))
        Me.База_данныхDataSet = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSet
        Me.ПринтерыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПринтерыTableAdapter = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.ПринтерыTableAdapter
        Me.TableAdapterManager = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.TableAdapterManager
        Me.МаркиTableAdapter = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.МаркиTableAdapter
        Me.МоделиTableAdapter = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.МоделиTableAdapter
        Me.ПринтерыBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ПринтерыBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ПринтерыDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.МаркиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.МоделиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.База_данныхDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПринтерыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПринтерыBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ПринтерыBindingNavigator.SuspendLayout()
        CType(Me.ПринтерыDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.МаркиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.МоделиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'База_данныхDataSet
        '
        Me.База_данныхDataSet.DataSetName = "База_данныхDataSet"
        Me.База_данныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ПринтерыBindingSource
        '
        Me.ПринтерыBindingSource.DataMember = "Принтеры"
        Me.ПринтерыBindingSource.DataSource = Me.База_данныхDataSet
        '
        'ПринтерыTableAdapter
        '
        Me.ПринтерыTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ЗаказыTableAdapter = Nothing
        Me.TableAdapterManager.МаркиTableAdapter = Me.МаркиTableAdapter
        Me.TableAdapterManager.МоделиTableAdapter = Me.МоделиTableAdapter
        Me.TableAdapterManager.ПринтерыTableAdapter = Me.ПринтерыTableAdapter
        Me.TableAdapterManager.РаботаTableAdapter = Nothing
        Me.TableAdapterManager.ТипыРаботTableAdapter = Nothing
        '
        'МаркиTableAdapter
        '
        Me.МаркиTableAdapter.ClearBeforeFill = True
        '
        'МоделиTableAdapter
        '
        Me.МоделиTableAdapter.ClearBeforeFill = True
        '
        'ПринтерыBindingNavigator
        '
        Me.ПринтерыBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ПринтерыBindingNavigator.BindingSource = Me.ПринтерыBindingSource
        Me.ПринтерыBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ПринтерыBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ПринтерыBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ПринтерыBindingNavigatorSaveItem})
        Me.ПринтерыBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ПринтерыBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ПринтерыBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ПринтерыBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ПринтерыBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ПринтерыBindingNavigator.Name = "ПринтерыBindingNavigator"
        Me.ПринтерыBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ПринтерыBindingNavigator.Size = New System.Drawing.Size(766, 25)
        Me.ПринтерыBindingNavigator.TabIndex = 0
        Me.ПринтерыBindingNavigator.Text = "BindingNavigator1"
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
        'ПринтерыBindingNavigatorSaveItem
        '
        Me.ПринтерыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ПринтерыBindingNavigatorSaveItem.Image = CType(resources.GetObject("ПринтерыBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ПринтерыBindingNavigatorSaveItem.Name = "ПринтерыBindingNavigatorSaveItem"
        Me.ПринтерыBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ПринтерыBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ПринтерыDataGridView
        '
        Me.ПринтерыDataGridView.AutoGenerateColumns = False
        Me.ПринтерыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ПринтерыDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ПринтерыDataGridView.DataSource = Me.ПринтерыBindingSource
        Me.ПринтерыDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ПринтерыDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.ПринтерыDataGridView.Name = "ПринтерыDataGridView"
        Me.ПринтерыDataGridView.Size = New System.Drawing.Size(766, 530)
        Me.ПринтерыDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "КодМарки"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.МаркиBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "Марка"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Марка"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "КодМарки"
        Me.DataGridViewTextBoxColumn2.Width = 65
        '
        'МаркиBindingSource
        '
        Me.МаркиBindingSource.DataMember = "Марки"
        Me.МаркиBindingSource.DataSource = Me.База_данныхDataSet
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "КодМодели"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.МоделиBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Модель"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Модель"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "КодМодели"
        Me.DataGridViewTextBoxColumn3.Width = 71
        '
        'МоделиBindingSource
        '
        Me.МоделиBindingSource.DataMember = "Модели"
        Me.МоделиBindingSource.DataSource = Me.База_данныхDataSet
        '
        'Printers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(766, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.ПринтерыDataGridView)
        Me.Controls.Add(Me.ПринтерыBindingNavigator)
        Me.Name = "Printers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Printers"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.База_данныхDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПринтерыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПринтерыBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ПринтерыBindingNavigator.ResumeLayout(False)
        Me.ПринтерыBindingNavigator.PerformLayout()
        CType(Me.ПринтерыDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.МаркиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.МоделиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents База_данныхDataSet As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSet
    Friend WithEvents ПринтерыBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ПринтерыTableAdapter As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.ПринтерыTableAdapter
    Friend WithEvents TableAdapterManager As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ПринтерыBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ПринтерыBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents МаркиTableAdapter As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.МаркиTableAdapter
    Friend WithEvents ПринтерыDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents МаркиBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents МоделиTableAdapter As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.МоделиTableAdapter
    Friend WithEvents МоделиBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
