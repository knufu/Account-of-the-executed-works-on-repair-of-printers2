Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "База_данныхDataSet1.zap3". При необходимости она может быть перемещена или удалена.
        Me.Zap3TableAdapter.Fill(Me.База_данныхDataSet1.zap3)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "База_данныхDataSet.zap2". При необходимости она может быть перемещена или удалена.
        Me.Zap2TableAdapter.Fill(Me.База_данныхDataSet.zap2)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "База_данныхDataSet.zap2". При необходимости она может быть перемещена или удалена.
        Me.Zap2TableAdapter.Fill(Me.База_данныхDataSet.zap2)
        'TODO: This line of code loads data into the 'База_данныхDataSet.zap2' table. You can move, or remove it, as needed.
        Me.Zap2TableAdapter.Fill(Me.База_данныхDataSet.zap2)
        Form2.MdiParent = Me
        Form2.Show()
        If Count___ЗаказыTextBox.Text = "" Then
            Count___ЗаказыTextBox.Text = 0
        End If
        If Count___ЗаказыВыпTextBox.Text = "" Then
            Count___ЗаказыВыпTextBox.Text = 0
        End If

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Form2.MdiParent = Me
        Form2.Show()
        Form3.Hide()
        Марки.Hide()
        Printers.Hide()
        Works.Hide()
        Type.Hide()
    End Sub

    Private Sub ВыходToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВыходToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'ToolStripStatusLabel2.Text = Convert.ToString(Date.Now.Day & "." & Date.Now.Month & "." & Date.Now.Year)
    End Sub

    Private Sub ЗаказыToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ЗаказыToolStripMenuItem.Click
        Form3.MdiParent = Me
        Form3.Show()
        Form2.Hide()
        Марки.Hide()
        Printers.Hide()
        Works.Hide()
        Type.Hide()
    End Sub

    Private Sub ВидыРаботToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВидыРаботToolStripMenuItem.Click
        Works.MdiParent = Me
        Works.Show()
        Form2.Hide()
        Марки.Hide()
        Form3.Hide()
        Printers.Hide()
        Type.Hide()
    End Sub

    Private Sub МаркиToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles МаркиToolStripMenuItem.Click
        Марки.MdiParent = Me
        Марки.Show()
        Form2.Hide()
        Works.Hide()
        Form3.Hide()
        Printers.Hide()
        Type.Hide()
    End Sub

    Private Sub ПринтерыToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПринтерыToolStripMenuItem1.Click
        Printers.MdiParent = Me
        Printers.Show()
        Form2.Hide()
        Марки.Hide()
        Form3.Hide()
        Works.Hide()
        Type.Hide()
    End Sub

    Private Sub ТипыКомплектующихToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ТипыКомплектующихToolStripMenuItem.Click
        Type.MdiParent = Me
        Type.Show()
        Form2.Hide()
        Марки.Hide()
        Form3.Hide()
        Works.Hide()
        Printers.Hide()
    End Sub

    Private Sub СправкаToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles СправкаToolStripMenuItem.Click
        Process.Start("Help.chm")
    End Sub

    Private Sub Count___ЗаказыTextBox_TextChanged(sender As Object, e As EventArgs) Handles Count___ЗаказыTextBox.TextChanged

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

End Class
