Public Class Form3
    Dim n, c As Integer
    Public a(n) As Double
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'База_данныхDataSet.Модели' table. You can move, or remove it, as needed.
        Me.МоделиTableAdapter.Fill(Me.База_данныхDataSet.Модели)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Марки' table. You can move, or remove it, as needed.
        Me.МаркиTableAdapter.Fill(Me.База_данныхDataSet.Марки)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Работа' table. You can move, or remove it, as needed.
        Me.РаботаTableAdapter.Fill(Me.База_данныхDataSet.Работа)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Заказы' table. You can move, or remove it, as needed.
        Me.ЗаказыTableAdapter.Fill(Me.База_данныхDataSet.Заказы)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Работа' table. You can move, or remove it, as needed.
        Me.РаботаTableAdapter.Fill(Me.База_данныхDataSet.Работа)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Модели' table. You can move, or remove it, as needed.
        Me.МоделиTableAdapter.Fill(Me.База_данныхDataSet.Модели)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Марки' table. You can move, or remove it, as needed.
        Me.МаркиTableAdapter.Fill(Me.База_данныхDataSet.Марки)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Заказы' table. You can move, or remove it, as needed.
        Me.ЗаказыTableAdapter.Fill(Me.База_данныхDataSet.Заказы)
    End Sub

    Private Sub ЗаказыBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗаказыBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ЗаказыBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.База_данныхDataSet)
        Form1.Zap2TableAdapter.Fill(Form1.База_данныхDataSet.zap2)
        If Form1.Count___ЗаказыTextBox.Text = "" Then
            Form1.Count___ЗаказыTextBox.Text = 0
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Укажите критерий", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim i As Integer
            Dim j As Integer
            For i = 0 To ЗаказыDataGridView.ColumnCount - 1
                For j = 0 To ЗаказыDataGridView.RowCount - 1
                    ЗаказыDataGridView.Item(i, j).Style.BackColor = Color.White
                    ЗаказыDataGridView.Item(i, j).Style.ForeColor = Color.Black
                Next j
            Next i
            For i = 0 To ЗаказыDataGridView.ColumnCount - 1
                For j = 0 To ЗаказыDataGridView.RowCount - 1
                    If InStr(ЗаказыDataGridView.Item(i, j).Value, TextBox1.Text) Then
                        ЗаказыDataGridView.Rows(j).Selected = True
                    End If
                Next j
            Next i
        End If
    End Sub
End Class