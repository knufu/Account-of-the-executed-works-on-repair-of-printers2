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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыходToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПомощьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ЗаказыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ПринтерыToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.МаркиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ПринтерыToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВидыРаботToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТипыКомплектующихToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Count___ЗаказыTextBox = New System.Windows.Forms.TextBox()
        Me.Count___ЗаказыВыпTextBox = New System.Windows.Forms.TextBox()
        Me.Zap3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Zap2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.База_данныхDataSet = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSet()
        Me.Zap2TableAdapter = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.zap2TableAdapter()
        Me.TableAdapterManager = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.TableAdapterManager()
        Me.База_данныхDataSet1 = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSet1()
        Me.Zap3TableAdapter = New Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSet1TableAdapters.zap3TableAdapter()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Zap3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zap2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.База_данныхDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.База_данныхDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.ПомощьToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(888, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ВыходToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'ВыходToolStripMenuItem
        '
        Me.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem"
        Me.ВыходToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.ВыходToolStripMenuItem.Text = "Выход"
        '
        'ПомощьToolStripMenuItem
        '
        Me.ПомощьToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СправкаToolStripMenuItem})
        Me.ПомощьToolStripMenuItem.Name = "ПомощьToolStripMenuItem"
        Me.ПомощьToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ПомощьToolStripMenuItem.Text = "Помощь"
        '
        'СправкаToolStripMenuItem
        '
        Me.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        Me.СправкаToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.СправкаToolStripMenuItem.Text = "Справка"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripDropDownButton1, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(888, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripButton1.Text = "Оформить заказ"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ЗаказыToolStripMenuItem, Me.ПринтерыToolStripMenuItem, Me.ВидыРаботToolStripMenuItem, Me.ТипыКомплектующихToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripDropDownButton1.Text = "Редактировать БД"
        '
        'ЗаказыToolStripMenuItem
        '
        Me.ЗаказыToolStripMenuItem.Name = "ЗаказыToolStripMenuItem"
        Me.ЗаказыToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ЗаказыToolStripMenuItem.Text = "Заказы"
        '
        'ПринтерыToolStripMenuItem
        '
        Me.ПринтерыToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.МаркиToolStripMenuItem, Me.ToolStripSeparator4, Me.ПринтерыToolStripMenuItem1})
        Me.ПринтерыToolStripMenuItem.Name = "ПринтерыToolStripMenuItem"
        Me.ПринтерыToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ПринтерыToolStripMenuItem.Text = "Принтеры"
        '
        'МаркиToolStripMenuItem
        '
        Me.МаркиToolStripMenuItem.Name = "МаркиToolStripMenuItem"
        Me.МаркиToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.МаркиToolStripMenuItem.Text = "Марки и модели"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(163, 6)
        '
        'ПринтерыToolStripMenuItem1
        '
        Me.ПринтерыToolStripMenuItem1.Name = "ПринтерыToolStripMenuItem1"
        Me.ПринтерыToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.ПринтерыToolStripMenuItem1.Text = "Принтеры"
        '
        'ВидыРаботToolStripMenuItem
        '
        Me.ВидыРаботToolStripMenuItem.Name = "ВидыРаботToolStripMenuItem"
        Me.ВидыРаботToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ВидыРаботToolStripMenuItem.Text = "Комплектующие"
        '
        'ТипыКомплектующихToolStripMenuItem
        '
        Me.ТипыКомплектующихToolStripMenuItem.Name = "ТипыКомплектующихToolStripMenuItem"
        Me.ТипыКомплектующихToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ТипыКомплектующихToolStripMenuItem.Text = "Типы комплектующих"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 537)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(888, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(210, 17)
        Me.ToolStripStatusLabel1.Text = "Количество невыполненных заказов"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(12, 17)
        Me.ToolStripStatusLabel3.Text = "-"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Margin = New System.Windows.Forms.Padding(50, 3, 0, 2)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(197, 17)
        Me.ToolStripStatusLabel2.Text = "Количество выполненных заказов"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(12, 17)
        Me.ToolStripStatusLabel4.Text = "-"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Count___ЗаказыTextBox
        '
        Me.Count___ЗаказыTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Zap2BindingSource, "Count - Заказы", True))
        Me.Count___ЗаказыTextBox.Location = New System.Drawing.Point(225, 539)
        Me.Count___ЗаказыTextBox.Name = "Count___ЗаказыTextBox"
        Me.Count___ЗаказыTextBox.ReadOnly = True
        Me.Count___ЗаказыTextBox.Size = New System.Drawing.Size(41, 20)
        Me.Count___ЗаказыTextBox.TabIndex = 7
        '
        'Count___ЗаказыВыпTextBox
        '
        Me.Count___ЗаказыВыпTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Zap3BindingSource, "Count - Заказы", True))
        Me.Count___ЗаказыВыпTextBox.Location = New System.Drawing.Point(493, 539)
        Me.Count___ЗаказыВыпTextBox.Name = "Count___ЗаказыВыпTextBox"
        Me.Count___ЗаказыВыпTextBox.ReadOnly = True
        Me.Count___ЗаказыВыпTextBox.Size = New System.Drawing.Size(41, 20)
        Me.Count___ЗаказыВыпTextBox.TabIndex = 8
        '
        'Zap3BindingSource
        '
        Me.Zap3BindingSource.DataMember = "zap3"
        Me.Zap3BindingSource.DataSource = Me.База_данныхDataSet1
        '
        'Zap2BindingSource
        '
        Me.Zap2BindingSource.DataMember = "zap2"
        Me.Zap2BindingSource.DataSource = Me.База_данныхDataSet
        '
        'База_данныхDataSet
        '
        Me.База_данныхDataSet.DataSetName = "База_данныхDataSet"
        Me.База_данныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Zap2TableAdapter
        '
        Me.Zap2TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.ЗаказыTableAdapter = Nothing
        Me.TableAdapterManager.МаркиTableAdapter = Nothing
        Me.TableAdapterManager.МоделиTableAdapter = Nothing
        Me.TableAdapterManager.ПринтерыTableAdapter = Nothing
        Me.TableAdapterManager.РаботаTableAdapter = Nothing
        Me.TableAdapterManager.ТипыРаботTableAdapter = Nothing
        '
        'База_данныхDataSet1
        '
        Me.База_данныхDataSet1.DataSetName = "База_данныхDataSet1"
        Me.База_данныхDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Zap3TableAdapter
        '
        Me.Zap3TableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 559)
        Me.Controls.Add(Me.Count___ЗаказыВыпTextBox)
        Me.Controls.Add(Me.Count___ЗаказыTextBox)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Zap3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zap2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.База_данныхDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.База_данныхDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВыходToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ЗаказыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПринтерыToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВидыРаботToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents МаркиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПомощьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents СправкаToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ПринтерыToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ТипыКомплектующихToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents База_данныхDataSet As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSet
    Friend WithEvents Zap2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Zap2TableAdapter As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.zap2TableAdapter
    Friend WithEvents TableAdapterManager As Account_of_the_executed_works_on_repair_of_printers.База_данныхDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Count___ЗаказыTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents Count___ЗаказыВыпTextBox As TextBox
    Friend WithEvents Zap3BindingSource As BindingSource
    Friend WithEvents База_данныхDataSet1 As База_данныхDataSet1
    Friend WithEvents Zap3TableAdapter As База_данныхDataSet1TableAdapters.zap3TableAdapter
End Class
