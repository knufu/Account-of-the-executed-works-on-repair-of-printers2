Public Class Form2
    Public detali As String
    Public itemQ As Integer = 0
    Dim mRow As Integer = 0
    Dim newpage As Boolean = True

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Select()
        'TODO: This line of code loads data into the 'База_данныхDataSet.Работа' table. You can move, or remove it, as needed.
        Me.РаботаTableAdapter.Fill(Me.База_данныхDataSet.Работа)
        'TODO: This line of code loads data into the 'База_данныхDataSet.ТипыРабот' table. You can move, or remove it, as needed.
        Me.ТипыРаботTableAdapter.Fill(Me.База_данныхDataSet.ТипыРабот)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Модели' table. You can move, or remove it, as needed.
        Me.МоделиTableAdapter.Fill(Me.База_данныхDataSet.Модели)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Марки' table. You can move, or remove it, as needed.
        Me.МаркиTableAdapter.Fill(Me.База_данныхDataSet.Марки)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Модели' table. You can move, or remove it, as needed.
        Me.МоделиTableAdapter.Fill(Me.База_данныхDataSet.Модели)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Марки' table. You can move, or remove it, as needed.
        Me.МаркиTableAdapter.Fill(Me.База_данныхDataSet.Марки)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Работа' table. You can move, or remove it, as needed.
        Me.РаботаTableAdapter.Fill(Me.База_данныхDataSet.Работа)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Работа' table. You can move, or remove it, as needed.
        Me.РаботаTableAdapter.Fill(Me.База_данныхDataSet.Работа)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Модели' table. You can move, or remove it, as needed.
        Me.МоделиTableAdapter.Fill(Me.База_данныхDataSet.Модели)
        'TODO: This line of code loads data into the 'База_данныхDataSet.Марки' table. You can move, or remove it, as needed.
        Me.МаркиTableAdapter.Fill(Me.База_данныхDataSet.Марки)
        TabPage2.Controls.Owner.Enabled = False
        TabPage3.Controls.Owner.Enabled = False
        If ComboBox1.Text = String.Empty Then
            МоделиBindingSource.RemoveFilter()
        Else : МоделиBindingSource.Filter = "КодМарка = " & ComboBox1.SelectedValue.ToString
        End If
        DateTimePicker1.Value = Date.Now
        RadioButton1.Checked = True
        ComboBox3.SelectedIndex = 0
        Label17.Text = 0
        TextBox4.Text = 0



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TabControl1.SelectTab(1)
        TabPage1.ImageKey = ImageList1.Images.Keys.Item(0)
        TabPage3.Controls.Owner.Enabled = True
        If ComboBox2.Text = String.Empty Then
            РаботаBindingSource.RemoveFilter()
        Else : РаботаBindingSource.Filter = "КодТипаРабот = " & ComboBox2.SelectedValue.ToString
        End If


        Dim f1() As String = IO.File.ReadAllLines("kvit.txt", System.Text.Encoding.Default)

        TextBox6.Text = Convert.ToDouble(f1(0)) + 1
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If RadioButton2.Checked = True Then
            TabControl1.SelectTab(2)
            TabPage3.ImageKey = ImageList1.Images.Keys.Item(0)
            TabPage2.Controls.Owner.Enabled = True
            Label12.Text = Convert.ToString(Date.Now.Day + NumericUpDown1.Value & "." & Date.Now.Month & "." & Date.Now.Year)
            ListBox1.Items.Add("Квитанция на оплату услуг № " & TextBox6.Text)
            ListBox1.Items.Add(" ")
            ListBox1.Items.Add("ОАО 'ПРИНТЕМАНИЯ Г.МИНСК'")
            ListBox1.Items.Add("ИНН 0545000078100 Юр. адрес: г. Минск, ул. Одоевского, 11 офис 10")
            ListBox1.Items.Add(" ")

            If Not IsNumeric(TextBox4.Text) Then
                TextBox4.Clear()
                MessageBox.Show("Введите числовое значение в поле стоимость работы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                TabControl1.SelectTab(2)
                TabPage3.ImageKey = ImageList1.Images.Keys.Item(0)
                TabPage2.Controls.Owner.Enabled = True


            End If

            ListBox5.Items.Add("Дата " & DateTimePicker1.Value & "                                                                                                                 Подпись                   " & TextBox7.Text)

            DataGridView1.Rows.Add(New String() {" ", "                                                                                             Подпись                   ", "Неизвестно"})

        End If
        If RadioButton1.Checked = True Then
            If TextBox4.Text = "" Then
                ErrorProvider1.SetError(TextBox4, "Укажите сумму ремонта")
            Else
                Label12.Text = Convert.ToString(Date.Now.Day + NumericUpDown1.Value & "." & Date.Now.Month & "." & Date.Now.Year)

                ListBox1.Items.Add("Квитанция на оплату услуг №" & TextBox6.Text)
                ListBox1.Items.Add(" ")
                ListBox1.Items.Add("ОАО 'ПРИНТЕМАНИЯ Г.МИНСК'")
                ListBox1.Items.Add("ИНН 0545000078100 Юр. адрес: г. Минск, ул. Одоевского, 11 офис 10")
                ListBox1.Items.Add(" ")

                If Not IsNumeric(TextBox4.Text) Then
                    TextBox4.Clear()
                    MessageBox.Show("Введите числовое значение в поле стоимость работы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    TabControl1.SelectTab(2)
                    TabPage3.ImageKey = ImageList1.Images.Keys.Item(0)
                    TabPage2.Controls.Owner.Enabled = True

                End If

                ListBox5.Items.Add("Дата " & DateTimePicker1.Value & "                                                                                             Подпись                   " & TextBox7.Text)

                DataGridView1.Rows.Add(New String() {" ", "                                                                                                                              Итого", Label17.Text})
            End If
        End If



    End Sub
    Dim w As Integer = 0
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim detal As String
        detal = ListBox2.Text
        itemQ += 1

        If itemQ < 2 Then
            detali = detal
        Else
            detali = detal + ", " + detali
        End If

        Label17.Text = Convert.ToDouble(ListBox4.Text) + Convert.ToDouble(Label17.Text)
        w += 1
        DataGridView1.Rows.Add(New String() {w, ListBox2.Text, ListBox4.Text})

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TabPage2.ImageKey = ImageList1.Images.Keys.Item(0)
        If MessageBox.Show("Заказ оформлен успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) = Windows.Forms.DialogResult.OK Then
            TabPage1.ImageKey = Nothing
            TabPage2.ImageKey = Nothing
            TabPage3.ImageKey = Nothing
            TabControl1.SelectTab(0)
            TabPage2.Controls.Owner.Enabled = False
            TabPage3.Controls.Owner.Enabled = False
            If ComboBox3.Text = "Сложный (сервис)" Then
                If RadioButton1.Checked Then
                    Account_of_the_executed_works_on_repair_of_printers.Form3.ЗаказыTableAdapter.Insert(TextBox2.Text, TextBox3.Text, "'service'", MaskedTextBox1.Text, MaskedTextBox2.Text, ComboBox1.SelectedValue, ListBox3.SelectedValue, DateTimePicker1.Value, detali, Convert.ToDouble(TextBox4.Text) + Convert.ToDouble(Label17.Text), Convert.ToString(Date.Now.Day + NumericUpDown1.Value & "." & Date.Now.Month & "." & Date.Now.Year), False)
                End If
                If RadioButton2.Checked Then
                    Account_of_the_executed_works_on_repair_of_printers.Form3.ЗаказыTableAdapter.Insert(TextBox2.Text, TextBox3.Text, "'service'", MaskedTextBox1.Text, MaskedTextBox2.Text, ComboBox1.SelectedValue, ListBox3.SelectedValue, DateTimePicker1.Value, detali, Convert.ToDouble(TextBox4.Text) + Convert.ToDouble(Label17.Text), Convert.ToString(Date.Now.Day & "." & Date.Now.Month & "." & Date.Now.Year & " +"), False)
                End If
            Else
                If RadioButton1.Checked Then
                    Account_of_the_executed_works_on_repair_of_printers.Form3.ЗаказыTableAdapter.Insert(TextBox2.Text, TextBox3.Text, TextBox1.Text, MaskedTextBox1.Text, MaskedTextBox2.Text, ComboBox1.SelectedValue, ListBox3.SelectedValue, DateTimePicker1.Value, detali, Convert.ToDouble(TextBox4.Text) + Convert.ToDouble(Label17.Text), Convert.ToString(Date.Now.Day + NumericUpDown1.Value & "." & Date.Now.Month & "." & Date.Now.Year), False)
                End If
                If RadioButton2.Checked Then
                    Account_of_the_executed_works_on_repair_of_printers.Form3.ЗаказыTableAdapter.Insert(TextBox2.Text, TextBox3.Text, TextBox1.Text, MaskedTextBox1.Text, MaskedTextBox2.Text, ComboBox1.SelectedValue, ListBox3.SelectedValue, DateTimePicker1.Value, detali, Convert.ToDouble(TextBox4.Text) + Convert.ToDouble(Label17.Text), Convert.ToString(Date.Now.Day & "." & Date.Now.Month & "." & Date.Now.Year & " +"), False)
                End If
            End If

            Dim ff2(0) As String
            ff2(0) = TextBox6.Text
            IO.File.WriteAllLines("kvit.txt", ff2)

            Form3.Validate()
            Form3.ЗаказыBindingSource.EndEdit()
            Form3.TableAdapterManager.UpdateAll(Form3.База_данныхDataSet)
            Form3.ЗаказыTableAdapter.Fill(Form3.База_данныхDataSet.Заказы)
            TextBox2.Clear()
            TextBox3.Clear()
            MaskedTextBox1.Clear()
            MaskedTextBox2.Clear()
            ComboBox3.SelectedIndex = 0
            TextBox1.Clear()
            RadioButton1.Checked = True
            NumericUpDown1.Value = 0
            TextBox4.Clear()
            ListBox1.Items.Clear()
            CheckBox2.Checked = False
            ListBox1.Items.Clear()
            If Form1.Count___ЗаказыTextBox.Text = "" Then
                Form1.Count___ЗаказыTextBox.Text = 0
            End If
            Form1.Zap2TableAdapter.Fill(Form1.База_данныхDataSet.zap2)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = String.Empty Then
            МоделиBindingSource.RemoveFilter()
        Else : МоделиBindingSource.Filter = "КодМарка = " & ComboBox1.SelectedValue.ToString
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = String.Empty Then
            РаботаBindingSource.RemoveFilter()
        Else : РаботаBindingSource.Filter = "КодТипаРабот = " & ComboBox2.SelectedValue.ToString
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            ComboBox2.Visible = False
            Label8.Visible = False
            РаботаBindingSource.RemoveFilter()
        End If
        If CheckBox2.Checked = False Then
            ComboBox2.Visible = True
            Label8.Visible = True
            If ComboBox2.Text = String.Empty Then
                РаботаBindingSource.RemoveFilter()
            Else : РаботаBindingSource.Filter = "КодТипаРабот = " & ComboBox2.SelectedValue.ToString
            End If
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label8.Enabled = True
        ComboBox2.Enabled = True
        Label16.Enabled = True
        ListBox2.Enabled = True
        ListBox4.Enabled = True
        CheckBox2.Enabled = True
        NumericUpDown1.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        ComboBox2.SelectedIndex = 0
        TextBox4.Visible = True
        Label14.Visible = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label8.Enabled = False
        ComboBox2.Enabled = False
        Label16.Enabled = False
        ListBox2.Enabled = False
        ListBox4.Enabled = False
        CheckBox2.Enabled = False
        NumericUpDown1.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        ComboBox2.SelectedIndex = 5
        ListBox2.SelectedIndex = 0
        ListBox4.SelectedIndex = 0
        TextBox4.Visible = False
        Label14.Visible = False
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "Сложный (сервис)" Then
            Label4.Enabled = False
            TextBox1.Enabled = False
        End If
        If ComboBox3.Text = "Простой (с выездом на месте)" Then
            Label4.Enabled = True
            TextBox1.Enabled = True
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox2.Clear()
        TextBox3.Clear()
        MaskedTextBox1.Clear()
        MaskedTextBox2.Clear()
        ComboBox3.SelectedIndex = 0
        TextBox1.Clear()
        RadioButton1.Checked = True
        NumericUpDown1.Value = 0
        TextBox4.Clear()
        ListBox1.Items.Clear()
        CheckBox2.Checked = False
    End Sub




    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim x3 As Integer = e.MarginBounds.Left
        Dim y3 As Single = e.MarginBounds.Top
        Dim lineheight As Single = Me.ListBox1.Font.GetHeight(e.Graphics)
        For Each item2 As String In Me.ListBox1.Items
            e.Graphics.DrawString(item2, Me.ListBox1.Font, Brushes.Black, x3, y3)
            y3 += lineheight
        Next



        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = e.MarginBounds.Top
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow


        If newpage Then
            row = DataGridView1.Rows(mRow)
            x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells

                If cell.Visible Then
                    rc = New Rectangle(x - 50, y + 120, cell.Size.Width, cell.Size.Height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)


                    Select Case DataGridView1.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(DataGridView1.Columns(cell.ColumnIndex).HeaderText,
                                            DataGridView1.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h

        End If
        newpage = False


        Dim thisNDX As Int32
        For thisNDX = mRow To DataGridView1.RowCount - 1

            If DataGridView1.Rows(thisNDX).IsNewRow Then Exit For

            row = DataGridView1.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0


            x = e.MarginBounds.Left


            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x - 50, y + 120, cell.Size.Width, cell.Size.Height)



                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case DataGridView1.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                      DataGridView1.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next
            y += h

            mRow = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True

                newpage = True
                Return
            End If
        Next



        Dim x2 As Integer = e.MarginBounds.Left
        Dim y2 As Single = e.MarginBounds.Top
        Dim lineheight2 As Single = Me.ListBox5.Font.GetHeight(e.Graphics)
        For Each item1 As String In Me.ListBox5.Items
            e.Graphics.DrawString(item1, Me.ListBox5.Font, Brushes.Black, x2, 1100)
            y2 += lineheight2
        Next
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        mRow = 0
        newpage = True
        PrintPreviewDialog1.PrintPreviewControl.StartPage = 0

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintDocument1.PrinterSettings.Copies = 1


        'PrintPreviewDialog1.ShowDialog()

        PrintDocument1.Print()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        mRow = 0
        newpage = True
        PrintPreviewDialog1.PrintPreviewControl.StartPage = 0


        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1

        PrintPreviewDialog1.ShowDialog()

    End Sub
End Class