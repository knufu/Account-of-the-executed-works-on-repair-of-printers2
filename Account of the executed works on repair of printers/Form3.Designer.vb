<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.ЗаказыBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ЗаказыBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ЗаказыDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.МаркиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.База_данныхDataSet = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSet()
        Me.МоделиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЗаказыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.РаботаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ЗаказыTableAdapter = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.ЗаказыTableAdapter()
        Me.TableAdapterManager = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.TableAdapterManager()
        Me.МаркиTableAdapter = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.МаркиTableAdapter()
        Me.МоделиTableAdapter = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.МоделиTableAdapter()
        Me.РаботаTableAdapter = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.РаботаTableAdapter()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ВидРаботы = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.СуммаРем = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.ЗаказыBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ЗаказыBindingNavigator.SuspendLayout()
        CType(Me.ЗаказыDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.МаркиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.База_данныхDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.МоделиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ЗаказыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РаботаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ЗаказыBindingNavigator
        '
        Me.ЗаказыBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ЗаказыBindingNavigator.BindingSource = Me.ЗаказыBindingSource
        Me.ЗаказыBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ЗаказыBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ЗаказыBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ЗаказыBindingNavigatorSaveItem})
        Me.ЗаказыBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ЗаказыBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ЗаказыBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ЗаказыBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ЗаказыBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ЗаказыBindingNavigator.Name = "ЗаказыBindingNavigator"
        Me.ЗаказыBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ЗаказыBindingNavigator.Size = New System.Drawing.Size(766, 25)
        Me.ЗаказыBindingNavigator.TabIndex = 3
        Me.ЗаказыBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 22)
        Me.BindingNavigatorCountItem.Text = "для {0}"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'ЗаказыBindingNavigatorSaveItem
        '
        Me.ЗаказыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ЗаказыBindingNavigatorSaveItem.Image = CType(resources.GetObject("ЗаказыBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ЗаказыBindingNavigatorSaveItem.Name = "ЗаказыBindingNavigatorSaveItem"
        Me.ЗаказыBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ЗаказыBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ЗаказыDataGridView
        '
        Me.ЗаказыDataGridView.AutoGenerateColumns = False
        Me.ЗаказыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ЗаказыDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.ВидРаботы, Me.СуммаРем, Me.DataGridViewTextBoxColumn12, Me.DataGridViewCheckBoxColumn1})
        Me.ЗаказыDataGridView.DataSource = Me.ЗаказыBindingSource
        Me.ЗаказыDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.ЗаказыDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.ЗаказыDataGridView.Name = "ЗаказыDataGridView"
        Me.ЗаказыDataGridView.Size = New System.Drawing.Size(766, 289)
        Me.ЗаказыDataGridView.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(152, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Применить"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(127, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Критерий:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 314)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(766, 241)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Поиск"
        '
        'МаркиBindingSource
        '
        Me.МаркиBindingSource.DataMember = "Марки"
        Me.МаркиBindingSource.DataSource = Me.База_данныхDataSet
        '
        'База_данныхDataSet
        '
        Me.База_данныхDataSet.DataSetName = "База_данныхDataSet"
        Me.База_данныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'МоделиBindingSource
        '
        Me.МоделиBindingSource.DataMember = "Модели"
        Me.МоделиBindingSource.DataSource = Me.База_данныхDataSet
        '
        'ЗаказыBindingSource
        '
        Me.ЗаказыBindingSource.DataMember = "Заказы"
        Me.ЗаказыBindingSource.DataSource = Me.База_данныхDataSet
        '
        'РаботаBindingSource
        '
        Me.РаботаBindingSource.DataMember = "Работа"
        Me.РаботаBindingSource.DataSource = Me.База_данныхDataSet
        '
        'ЗаказыTableAdapter
        '
        Me.ЗаказыTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ЗаказыTableAdapter = Me.ЗаказыTableAdapter
        Me.TableAdapterManager.МаркиTableAdapter = Me.МаркиTableAdapter
        Me.TableAdapterManager.МоделиTableAdapter = Me.МоделиTableAdapter
        Me.TableAdapterManager.ПринтерыTableAdapter = Nothing
        Me.TableAdapterManager.РаботаTableAdapter = Me.РаботаTableAdapter
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
        'РаботаTableAdapter
        '
        Me.РаботаTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Организация"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Организация"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ФИО"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ФИО"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Адрес"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Адрес"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "КонтТел"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Контактный телефон"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ТелОрг"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Телефон организации"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "КодМарка"
        Me.DataGridViewTextBoxColumn7.DataSource = Me.МаркиBindingSource
        Me.DataGridViewTextBoxColumn7.DisplayMember = "Марка"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Марка"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.ValueMember = "КодМарки"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "КодМодель"
        Me.DataGridViewTextBoxColumn8.DataSource = Me.МоделиBindingSource
        Me.DataGridViewTextBoxColumn8.DisplayMember = "Модель"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Модель"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn8.ValueMember = "КодМодели"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ДатаОформления"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Дата оформления"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'ВидРаботы
        '
        Me.ВидРаботы.DataPropertyName = "ВидРаботы"
        Me.ВидРаботы.HeaderText = "Комплектующие"
        Me.ВидРаботы.Name = "ВидРаботы"
        Me.ВидРаботы.ReadOnly = True
        '
        'СуммаРем
        '
        Me.СуммаРем.DataPropertyName = "СуммаРем"
        Me.СуммаРем.HeaderText = "Сумма ремонта, руб"
        Me.СуммаРем.Name = "СуммаРем"
        Me.СуммаРем.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "СрокРем"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Срок ремонта"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Выполнен"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Выполнен"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(766, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ЗаказыDataGridView)
        Me.Controls.Add(Me.ЗаказыBindingNavigator)
        Me.Name = "Form3"
        Me.Text = "Заказы"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ЗаказыBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ЗаказыBindingNavigator.ResumeLayout(False)
        Me.ЗаказыBindingNavigator.PerformLayout()
        CType(Me.ЗаказыDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.МаркиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.База_данныхDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.МоделиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ЗаказыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РаботаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents База_данныхDataSet As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSet
    Friend WithEvents ЗаказыBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ЗаказыTableAdapter As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.ЗаказыTableAdapter
    Friend WithEvents TableAdapterManager As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ЗаказыBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ЗаказыBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ЗаказыDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents РаботаTableAdapter As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.РаботаTableAdapter
    Friend WithEvents РаботаBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents МаркиTableAdapter As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.МаркиTableAdapter
    Friend WithEvents МаркиBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents МоделиTableAdapter As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.МоделиTableAdapter
    Friend WithEvents МоделиBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents ВидРаботы As DataGridViewTextBoxColumn
    Friend WithEvents СуммаРем As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
