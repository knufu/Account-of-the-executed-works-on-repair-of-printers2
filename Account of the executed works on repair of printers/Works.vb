Public Class Works

    Private Sub Works_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'База_данныхDataSet.ТипыРабот' table. You can move, or remove it, as needed.
        Me.ТипыРаботTableAdapter.Fill(Me.База_данныхDataSet.ТипыРабот)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Работа' table. You can move, or remove it, as needed.
        Me.РаботаTableAdapter.Fill(Me.База_данныхDataSet.Работа)

    End Sub

    Private Sub РаботаBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles РаботаBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.РаботаBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.База_данныхDataSet)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Укажите критерий", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim i As Integer
            Dim j As Integer
            For i = 0 To РаботаDataGridView.ColumnCount - 1
                For j = 0 To РаботаDataGridView.RowCount - 1
                    РаботаDataGridView.Item(i, j).Style.BackColor = Color.White
                    РаботаDataGridView.Item(i, j).Style.ForeColor = Color.Black
                Next j
            Next i
            For i = 0 To РаботаDataGridView.ColumnCount - 1
                For j = 0 To РаботаDataGridView.RowCount - 1
                    If InStr(РаботаDataGridView.Item(i, j).Value, TextBox1.Text) Then
                        РаботаDataGridView.Rows(j).Selected = True
                    End If
                Next j
            Next i
        End If
    End Sub
End Class