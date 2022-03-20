Public Class Printers

    Private Sub Printers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'База_данныхDataSet.Модели' table. You can move, or remove it, as needed.
        Me.МоделиTableAdapter.Fill(Me.База_данныхDataSet.Модели)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Марки' table. You can move, or remove it, as needed.
        Me.МаркиTableAdapter.Fill(Me.База_данныхDataSet.Марки)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Принтеры' table. You can move, or remove it, as needed.
        Me.ПринтерыTableAdapter.Fill(Me.База_данныхDataSet.Принтеры)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Модели' table. You can move, or remove it, as needed.
        Me.МоделиTableAdapter.Fill(Me.База_данныхDataSet.Модели)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Марки' table. You can move, or remove it, as needed.
        Me.МаркиTableAdapter.Fill(Me.База_данныхDataSet.Марки)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Принтеры' table. You can move, or remove it, as needed.
        Me.ПринтерыTableAdapter.Fill(Me.База_данныхDataSet.Принтеры)

    End Sub

    Private Sub ПринтерыBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ПринтерыBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ПринтерыBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.База_данныхDataSet)

    End Sub
End Class