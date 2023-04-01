Public Class Compras

    Dim a, f As Integer

    Private Sub ComprasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ComprasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JardimzoologicoDataSet)

    End Sub

    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = "Sessão iniciada, utilizador: " & index.sessaoiniciada
        Try
            ' f = 0
            Call EstadocompraComboBox_TextChanged(sender, e)
            'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Animais' table. You can move, or remove it, as needed.
            Me.AnimaisTableAdapter.Fill(Me.JardimzoologicoDataSet.Animais)
            'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Funcionarios' table. You can move, or remove it, as needed.
            Me.FuncionariosTableAdapter.Fill(Me.JardimzoologicoDataSet.Funcionarios)
            ToolStripButton1.Enabled = True
            ToolStripButton2.Enabled = False
            ToolStripButton3.Enabled = False
            GroupBox1.Enabled = False
            'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Detalhe_compras' table. You can move, or remove it, as needed.
            Me.Detalhe_comprasTableAdapter.Fill(Me.JardimzoologicoDataSet.Detalhe_compras)
            'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Compras' table. You can move, or remove it, as needed.
            Me.ComprasTableAdapter.Fill(Me.JardimzoologicoDataSet.Compras)
            ToolStripButton4.Enabled = True

        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            ToolStripButton1.Enabled = False
            ToolStripButton2.Enabled = True
            ToolStripButton3.Enabled = True
            primeiro.Enabled = False
            anterior.Enabled = False
            seguinte.Enabled = False
            ultimo.Enabled = False
            ToolStripButton4.Enabled = True
            GroupBox1.Enabled = True
            ComprasBindingSource.MoveLast()
            ComprasBindingSource.AddNew()
            ValorTextBox.Text = 0
            Data_compraDateTimePicker.Value = Date.Now()
            EstadocompraComboBox.Text = "Aguarda pagamento"
            '  f = 1
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim pos As Integer
        Try
            pos = ComprasBindingSource.Position
            ToolStripButton1.Enabled = True
            ToolStripButton2.Enabled = False
            ToolStripButton3.Enabled = False
            primeiro.Enabled = True
            anterior.Enabled = True
            seguinte.Enabled = True
            ultimo.Enabled = True
            ToolStripButton4.Enabled = True
            GroupBox1.Enabled = False

            ComprasBindingSource.EndEdit()
            ComprasTableAdapter.Update(JardimzoologicoDataSet.Compras)
            ComprasTableAdapter.Fill(JardimzoologicoDataSet.Compras)
            MsgBox("Gravado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            ComprasBindingNavigator.Enabled = True

        Catch ex As Exception
            MsgBox(ex.ToString + Chr(13) + "Erro ao gravar, tente novamente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            ComprasBindingNavigator.Enabled = True
        End Try

        ComprasBindingSource.Position = pos
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Try

       
        ToolStripButton1.Enabled = True
        ToolStripButton2.Enabled = False
        ToolStripButton3.Enabled = False
        primeiro.Enabled = True
        anterior.Enabled = True
        seguinte.Enabled = True
        ToolStripButton4.Enabled = True
        ultimo.Enabled = True
        ComprasBindingSource.CancelEdit()
        GroupBox1.Enabled = False
        ComprasTableAdapter.Fill(JardimzoologicoDataSet.Compras)
            MsgBox("Operação Cancelada!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click


        ToolStripButton4.Enabled = False
        GroupBox1.Enabled = True
        primeiro.Enabled = True
        anterior.Enabled = True
        seguinte.Enabled = True
        ultimo.Enabled = True
        ToolStripButton1.Enabled = False
        ToolStripButton2.Enabled = True
        ToolStripButton3.Enabled = True

        '  f = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

       
        a = 1
        If ComprasDataGridView.CurrentRow.Cells.Item(0).Value < 0 Then

            MsgBox("Grave primeiro a fatura!", MsgBoxStyle.Critical, "Erro")

        Else
            If EstadocompraComboBox.Text = "Paga" Or EstadocompraComboBox.Text = "Entregue" Or EstadocompraComboBox.Text = "Cancelada" Then
                MsgBox("Não é possível editar Compras Pagas, Entregues ou Canceladas", MsgBoxStyle.Critical)
                faturaatual.GroupBox2.Enabled = False
                faturaatual.ShowDialog()
                Exit Sub
            Else
                If MsgBox("Tem a certeza que pretende modificar a fatura atual?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = vbYes Then
                    '     ComprasBindingSource.Position = ComprasBindingSource.Position = ComprasBindingSource.Find("num_compra", Num_compraTextBox.Text)
                    faturaatual.ShowDialog()

                End If
            End If
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub Compras_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Try
            If a <> 1 Then
                Detalhe_comprasTableAdapter.Fill(JardimzoologicoDataSet.Detalhe_compras)
                ComprasBindingSource.EndEdit()
                ComprasTableAdapter.Update(JardimzoologicoDataSet.Compras)
                ComprasTableAdapter.Fill(JardimzoologicoDataSet.Compras)
                faturaatual.GroupBox2.Enabled = True
            End If
            a = 0
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try

        

    End Sub


 

    Private Sub EstadocompraComboBox_TextChanged(sender As Object, e As EventArgs) Handles EstadocompraComboBox.TextChanged
        Dim x As Integer
        Try
            x = ComprasBindingSource.Position
            '     If f = 1 Then

            If EstadocompraComboBox.Text = "Paga" Or EstadocompraComboBox.Text = "Entregue" Or EstadocompraComboBox.Text = "Cancelada" Then

                EstadocompraComboBox.Enabled = False
                Data_compraDateTimePicker.Enabled = False
                ComboBox1.Enabled = False
                ComboBox2.Enabled = False
                ComboBox3.Enabled = False
                ComboBox4.Enabled = False
            Else
                EstadocompraComboBox.Enabled = True
                Data_compraDateTimePicker.Enabled = True
                ComboBox1.Enabled = True
                ComboBox2.Enabled = True
                ComboBox3.Enabled = True
                ComboBox4.Enabled = True

            End If
            ' End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
        Exit Sub







    End Sub


    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Dim pos2 As Integer
        pos2 = ComprasBindingSource.Position()
        Try
            If Not (EstadocompraComboBox.Text = "Paga" Or EstadocompraComboBox.Text = "Entregue" Or EstadocompraComboBox.Text = "Cancelada") Then
                Detalhe_comprasTableAdapter.Fill(JardimzoologicoDataSet.Detalhe_compras)

                ComprasBindingSource.Position = pos2
                ComprasBindingSource.RemoveCurrent()
                ComprasBindingSource.EndEdit()
                ComprasTableAdapter.Update(JardimzoologicoDataSet.Compras)
                ComprasTableAdapter.Fill(JardimzoologicoDataSet.Compras)
                ComprasBindingSource.Position = pos2
                MsgBox("Eliminação concluída", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso")
            Else : MsgBox("Impossível eliminar faturas Pagas, Entregues ou Canceladas. Peça ao Admin da BD para apagar estes registos diretamente na BD! ", MsgBoxStyle.Critical, "Erro!")
            End If

        Catch ex As Exception
            MsgBox("Erro! Há registos relacionados! Apagar produtos do detalhe da fatura em primeiro lugar!", MsgBoxStyle.Critical, "Erro!")
            ComprasBindingSource.CancelEdit()
            ComprasTableAdapter.Fill(JardimzoologicoDataSet.Compras)
            ComprasBindingSource.Position() = pos2
        End Try


    End Sub


End Class