Public Class Марки

    Private Sub Марки_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'База_данныхDataSet.Модели' table. You can move, or remove it, as needed.
        Me.МоделиTableAdapter.Fill(Me.База_данныхDataSet.Модели)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Марки' table. You can move, or remove it, as needed.
        Me.МаркиTableAdapter.Fill(Me.База_данныхDataSet.Марки)


    End Sub

    Private Sub МаркиBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles МаркиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.МаркиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.База_данныхDataSet)

    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Me.Validate()
        Me.МоделиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.База_данныхDataSet)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Укажите критерий", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim i As Integer
            Dim j As Integer
            For i = 0 To МаркиDataGridView.ColumnCount - 1
                For j = 0 To МаркиDataGridView.RowCount - 1
                    МаркиDataGridView.Item(i, j).Style.BackColor = Color.White
                    МаркиDataGridView.Item(i, j).Style.ForeColor = Color.Black
                Next j
            Next i
            For i = 0 To МаркиDataGridView.ColumnCount - 1
                For j = 0 To МаркиDataGridView.RowCount - 1
                    If InStr(МаркиDataGridView.Item(i, j).Value, TextBox1.Text) Then
                        МаркиDataGridView.Rows(j).Selected = True
                    End If
                Next j
            Next i
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Укажите критерий", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim i As Integer
            Dim j As Integer
            For i = 0 To МоделиDataGridView.ColumnCount - 1
                For j = 0 To МоделиDataGridView.RowCount - 1
                    МоделиDataGridView.Item(i, j).Style.BackColor = Color.White
                    МоделиDataGridView.Item(i, j).Style.ForeColor = Color.Black
                Next j
            Next i
            For i = 0 To МоделиDataGridView.ColumnCount - 1
                For j = 0 To МоделиDataGridView.RowCount - 1
                    If InStr(МоделиDataGridView.Item(i, j).Value, TextBox1.Text) Then
                        МоделиDataGridView.Rows(j).Selected = True
                    End If
                Next j
            Next i
        End If
    End Sub
End Class