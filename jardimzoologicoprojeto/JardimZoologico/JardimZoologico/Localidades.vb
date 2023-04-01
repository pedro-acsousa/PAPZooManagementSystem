Public Class Localidades

    Private Sub LocalidadesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LocalidadesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JardimzoologicoDataSet)


    End Sub

    Private Sub Localidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = index.sessaoiniciada
        Try
            'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Funcionarios' table. You can move, or remove it, as needed.
            Me.FuncionariosTableAdapter.Fill(Me.JardimzoologicoDataSet.Funcionarios)
            'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Localidades' table. You can move, or remove it, as needed.
            Me.LocalidadesTableAdapter.Fill(Me.JardimzoologicoDataSet.Localidades)
            LocalidadesDataGridView.ReadOnly = True
            FuncionariosDataGridView.Enabled = True
            DistritoComboBox.SelectedIndex = 0

        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub

    Private Sub b_adicionar_Click(sender As Object, e As EventArgs) Handles b_adicionar.Click
        Dim codpostal, localidade, distrito As String

        distrito = DistritoComboBox.Text
        Try

            If MsgBox("Tem a certeza que o distrito a selecionar é " + distrito + "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = vbYes Then
                codpostal = InputBox("Insira o cód. Postal da Localidade")
                localidade = InputBox("Insira o nome da Localidade")
                LocalidadesBindingSource.AddNew()
                LocalidadesBindingSource.MoveLast()
                LocalidadesDataGridView.CurrentRow.Cells("cod_postal").Value() = codpostal
                LocalidadesDataGridView.CurrentRow.Cells("nomelocalidade").Value() = localidade
                LocalidadesDataGridView.CurrentRow.Cells("distrito").Value() = distrito
                If LocalidadesDataGridView.CurrentRow.Cells("cod_postal").Value() = vbEmpty Or LocalidadesDataGridView.CurrentRow.Cells("nomelocalidade").Value() = "" Or LocalidadesDataGridView.CurrentRow.Cells("distrito").Value() = "" Then
                    MsgBox("Campos Vazios ou com tipo de dados errado, abortando a operação!", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            Else : Exit Sub
            End If

            If Not LocalidadesDataGridView.CurrentRow.Cells("cod_postal").Value() = vbEmpty Or LocalidadesDataGridView.CurrentRow.Cells("nomelocalidade").Value() = "" Or LocalidadesDataGridView.CurrentRow.Cells("distrito").Value() = "" Then

                If MsgBox("Pretende guardar a Localidade que adicionou?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = vbYes Then
                    Try
                        LocalidadesBindingSource.EndEdit()
                        LocalidadesTableAdapter.Update(JardimzoologicoDataSet.Localidades)
                        LocalidadesTableAdapter.Fill(JardimzoologicoDataSet.Localidades)

                        MsgBox("Guardado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    Catch ex As Exception
                        MsgBox(ex.ToString + Chr(13) + "Operação não efetuada")
                        Exit Sub
                    End Try
                Else


                    MsgBox("Não Guardado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                    LocalidadesBindingSource.CancelEdit()
                    LocalidadesTableAdapter.Fill(JardimzoologicoDataSet.Localidades)

                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString + " Erro ao adicionar! ", MsgBoxStyle.Critical)


        End Try
    End Sub

    Private Sub b_remover_Click(sender As Object, e As EventArgs) Handles b_remover.Click
        Dim codaremover As Integer
        Try
            codaremover = InputBox("Qual o Cód. Postal da Localidade que deseja remover?", "Cód.Postal?")
            LocalidadesBindingSource.Position = LocalidadesBindingSource.Find("cod_postal", codaremover)
            If MsgBox("Tem a certeza que pretende remover?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = vbYes Then
                LocalidadesBindingSource.RemoveCurrent()
                Try
                    LocalidadesBindingSource.EndEdit()
                    LocalidadesTableAdapter.Update(JardimzoologicoDataSet.Localidades)
                    LocalidadesTableAdapter.Fill(JardimzoologicoDataSet.Localidades)
                Catch
                    MsgBox("Erro ao guardar!")
                End Try

                MsgBox("Foi removido e gravado na BD", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Else
                MsgBox("Não foi eliminado! Tente novamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            MsgBox("Valor inválido", MsgBoxStyle.Critical, "Erro")
        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.Click
        Asc_or_desc.ShowDialog()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.Click
        Asc_or_desc.ShowDialog()
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Dim param As String
            param = TextBox1.Text + "%"
            LocalidadesTableAdapter.Filtrarlocalidadenome(JardimzoologicoDataSet.Localidades, param)
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Try
            Dim a, b As Integer
            If TextBox2.Text = "" Then
                LocalidadesTableAdapter.Fill(Me.JardimzoologicoDataSet.Localidades)
            ElseIf Val(TextBox2.Text) >= 0 And Val(TextBox2.Text) <= 9 Then
                a = TextBox2.Text + "000"
                b = TextBox2.Text + "999"
                LocalidadesTableAdapter.Filtrarcodpostal(JardimzoologicoDataSet.Localidades, a, b)
            ElseIf Val(TextBox2.Text) >= 10 And Val(TextBox2.Text) <= 99 Then
                a = TextBox2.Text + "00"
                b = TextBox2.Text + "99"
                LocalidadesTableAdapter.Filtrarcodpostal(JardimzoologicoDataSet.Localidades, a, b)
            ElseIf Val(TextBox2.Text) >= 100 And Val(TextBox2.Text) <= 999 Then
                a = TextBox2.Text + "0"
                b = TextBox2.Text + "9"
                LocalidadesTableAdapter.Filtrarcodpostal(JardimzoologicoDataSet.Localidades, a, b)
            ElseIf Val(TextBox2.Text) >= 1000 And Val(TextBox2.Text) <= 9999 Then
                a = TextBox2.Text
                b = TextBox2.Text
                LocalidadesTableAdapter.Filtrarcodpostal(JardimzoologicoDataSet.Localidades, a, b)
            End If

        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            GroupBox3.Visible() = False
            LocalidadesDataGridView.Visible() = False
            PrintForm1.DocumentName = "Funcionários no dia " + Date.Now()
            If PrintDialog1.ShowDialog() Then
                PrintForm1.PrinterSettings = PrintDialog1.PrinterSettings
                PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
            End If
            GroupBox3.Visible() = True
            LocalidadesDataGridView.Visible() = True
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            GroupBox3.Visible() = False
            LocalidadesDataGridView.Visible() = True
            FuncionariosDataGridView.Visible() = False
            PrintForm1.DocumentName = "Funcionários no dia " + Date.Now()
            If PrintDialog1.ShowDialog() Then
                PrintForm1.PrinterSettings = PrintDialog1.PrinterSettings
                PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
            End If
            GroupBox3.Visible() = True
            LocalidadesDataGridView.Visible() = True
            FuncionariosDataGridView.Visible() = False
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Try
            GroupBox3.Visible() = False
            LocalidadesDataGridView.Visible() = True
            FuncionariosDataGridView.Visible() = True
            PrintForm1.DocumentName = "Funcionários no dia " + Date.Now()
            If PrintDialog1.ShowDialog() Then
                PrintForm1.PrinterSettings = PrintDialog1.PrinterSettings
                PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
            End If
            GroupBox3.Visible() = True
            LocalidadesDataGridView.Visible() = True
            FuncionariosDataGridView.Visible() = True
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles posicao.TextChanged
        Try

            LocalidadesBindingSource.Position = posicao.Text - 1
            If (posicao.Text - 1) < 0 Or posicao.Text > LocalidadesBindingSource.Count Then
                MsgBox("Selecione uma posição válida!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Posição Inválida!")
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
            Exit Sub
        End Try

    End Sub

   
  
End Class