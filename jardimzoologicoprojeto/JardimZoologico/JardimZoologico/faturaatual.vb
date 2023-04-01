Public Class faturaatual
    Dim totalfatura As Single
    Public condicao As Integer
    Dim manterposicao As Integer
    Private Sub Detalhe_comprasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Detalhe_comprasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JardimzoologicoDataSet)

    End Sub

    Private Sub faturaatual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Compras' table. You can move, or remove it, as needed.
            Me.ComprasTableAdapter.Fill(Me.JardimzoologicoDataSet.Compras)
            'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Compras' table. You can move, or remove it, as needed.
            Me.ComprasTableAdapter.Fill(Me.JardimzoologicoDataSet.Compras)
            'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Artigos' table. You can move, or remove it, as needed.
            Me.ArtigosTableAdapter.Fill(Me.JardimzoologicoDataSet.Artigos)
            'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Detalhe_compras' table. You can move, or remove it, as needed.
            Me.Detalhe_comprasTableAdapter.Fill(Me.JardimzoologicoDataSet.Detalhe_compras)
            ToolStripLabel1.Text = "Encontra-se a editar a fatura " & Compras.ComprasDataGridView.Rows(Compras.ComprasBindingSource.Position).Cells(0).Value
            ComprasBindingSource.Position = Compras.ComprasBindingSource.Find("num_compra", Compras.Num_compraTextBox.Text)
            Button2.Enabled = False
            Button3.Enabled = False
            manterposicao = ComprasBindingSource.Position
            totalfatura = Compras.ValorTextBox.Text

        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Detalhe_comprasBindingSource1.MoveLast()
            Detalhe_comprasBindingSource1.AddNew()
            Button2.Enabled = True
            Button3.Enabled = True

            Button1.Enabled = False
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
       


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

       
        If TextBox1.Text > 0 Then


            If (Val(Stock_aTextBox.Text) >= Val(TextBox1.Text)) Then
                totalfatura = 0
                Detalhe_comprasDataGridView.CurrentRow.Cells("num_compra").Value = Compras.ComprasDataGridView.Rows(Compras.ComprasBindingSource.Position).Cells(0).Value
                Detalhe_comprasDataGridView.CurrentRow.Cells("quantidade_encomendada").Value = Val(TextBox1.Text)
                Detalhe_comprasDataGridView.CurrentRow.Cells("preco").Value = Preco_aTextBox.Text
                Detalhe_comprasDataGridView.CurrentRow.Cells("artigo_num").Value = ComboBox1.Text
                Detalhe_comprasDataGridView.CurrentRow.Cells("totalpreco").Value = (Detalhe_comprasDataGridView.CurrentRow.Cells("preco").Value) * (Detalhe_comprasDataGridView.CurrentRow.Cells("quantidade_encomendada").Value)

                Try
                    For Each linha As DataGridViewRow In Detalhe_comprasDataGridView.Rows
                        If Detalhe_comprasDataGridView.CurrentRow.Cells("num_compra").Value = Compras.Num_compraTextBox.Text Then
                            totalfatura = totalfatura + Detalhe_comprasDataGridView.Rows(linha.Index).Cells("totalpreco").Value()
                        End If

                    Next

                Catch ex As Exception
                    MsgBox("Há células vazias!")
                End Try




                Compras.ValorTextBox.Text = totalfatura
                'fazer com que tome valor 0 se nao tiver la conteudo. para nao dar erro
                Stock_aTextBox.Text = Stock_aTextBox.Text - Detalhe_comprasDataGridView.CurrentRow.Cells("quantidade_encomendada").Value
                ArtigosBindingSource.EndEdit()
                ArtigosTableAdapter.Update(JardimzoologicoDataSet.Artigos)

                Try
                    Detalhe_comprasBindingSource1.EndEdit()
                    Detalhe_comprasTableAdapter.Update(JardimzoologicoDataSet.Detalhe_compras)
                    Detalhe_comprasTableAdapter.Fill(JardimzoologicoDataSet.Detalhe_compras)

                    Compras.ComprasTableAdapter.Update(JardimzoologicoDataSet.Compras)
                    Compras.ComprasTableAdapter.Fill(JardimzoologicoDataSet.Compras)
                    ComprasBindingSource.Position = manterposicao
                    MsgBox("Gravado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    Button2.Enabled = False
                    Button3.Enabled = False
                    Button1.Enabled = True

                Catch ex As Exception
                    MsgBox(ex.ToString + Chr(13) + "Erro ao gravar, tente novamente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try
            Else
                MsgBox("Não há stock em quantidade suficiente", MsgBoxStyle.Critical, "Sem Stock!")

            End If
        Else
            MsgBox("Inserir valor na quantidade", MsgBoxStyle.Critical)
        End If
            TextBox2.Text = totalfatura
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Detalhe_comprasBindingSource1.CancelEdit()
            Detalhe_comprasTableAdapter.Fill(JardimzoologicoDataSet.Detalhe_compras)
            ComprasBindingSource.Position = manterposicao
            Button2.Enabled = False
            Button3.Enabled = False
            Button1.Enabled = True
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
     
    End Sub

    Private Sub faturaatual_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try

       
        Compras.ComprasTableAdapter.Update(JardimzoologicoDataSet.Compras)
        Compras.ComprasTableAdapter.Fill(JardimzoologicoDataSet.Compras)
        Compras.Detalhe_comprasTableAdapter.Fill(JardimzoologicoDataSet.Detalhe_compras)
        Compras.ComprasBindingSource.Position = manterposicao
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try

            PrintForm1.DocumentName = "Fatura número " & Compras.ComprasDataGridView.Rows(Compras.ComprasBindingSource.Position).Cells(0).Value.ToString()
            If PrintDialog1.ShowDialog() Then
                PrintForm1.PrinterSettings = PrintDialog1.PrinterSettings
                PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
            End If


        Catch ex As Exception
            MsgBox(ex.ToString & "Erro de impressão", MsgBoxStyle.Critical, "Erro")
        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Try
            If RadioButton1.Checked Then
                Detalhe_comprasBindingSource1.Sort = "artigo_num"
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Try

      
        If RadioButton2.Checked Then
            Detalhe_comprasBindingSource1.Sort = "preco"
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim newtotal As Single
        Try



            If MsgBox("Pretende mesmo remover?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar?") = vbYes Then
                ArtigosBindingSource.Position = Detalhe_comprasDataGridView.Rows(Detalhe_comprasBindingSource1.Position).Cells(2).Value - 1
                Stock_aTextBox.Text = Stock_aTextBox.Text + Detalhe_comprasDataGridView.Rows(Detalhe_comprasBindingSource1.Position).Cells(4).Value
                Detalhe_comprasBindingSource1.RemoveCurrent()

                For Each linha As DataGridViewRow In Detalhe_comprasDataGridView.Rows
                    If Detalhe_comprasDataGridView.CurrentRow.Cells("num_compra").Value = Compras.Num_compraTextBox.Text Then
                        newtotal = newtotal + Detalhe_comprasDataGridView.Rows(linha.Index).Cells("totalpreco").Value()
                    Else
                        newtotal = 0
                    End If


                Next

                TextBox2.Text = newtotal
                Compras.ValorTextBox.Text = newtotal
                Detalhe_comprasBindingSource1.EndEdit()
                Detalhe_comprasTableAdapter.Update(JardimzoologicoDataSet.Detalhe_compras)
                Detalhe_comprasTableAdapter.Fill(JardimzoologicoDataSet.Detalhe_compras)
                ArtigosBindingSource.EndEdit()
                ArtigosTableAdapter.Update(JardimzoologicoDataSet.Artigos)

            End If

        Catch ex As Exception
            newtotal = 0
            TextBox2.Text = newtotal
            Compras.ValorTextBox.Text = newtotal
            Detalhe_comprasBindingSource1.EndEdit()
            Detalhe_comprasTableAdapter.Update(JardimzoologicoDataSet.Detalhe_compras)
            Detalhe_comprasTableAdapter.Fill(JardimzoologicoDataSet.Detalhe_compras)
            ArtigosBindingSource.EndEdit()
            ArtigosTableAdapter.Update(JardimzoologicoDataSet.Artigos)

        End Try

    End Sub
End Class