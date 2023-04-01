Public Class funcionarios
    Dim eliminar As Integer = 0
    Private Sub FuncionariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FuncionariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JardimzoologicoDataSet)

    End Sub

    Private Sub funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripLabel1.Text = "Sessão iniciada, utilizador: " & index.sessaoiniciada
        Try
            'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Localidades' table. You can move, or remove it, as needed.
            Me.LocalidadesTableAdapter.Fill(Me.JardimzoologicoDataSet.Localidades)
            'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Funcionarios' table. You can move, or remove it, as needed.
            Me.FuncionariosTableAdapter.Fill(Me.JardimzoologicoDataSet.Funcionarios)
            FuncionariosBindingNavigator.Enabled = True
            FuncionariosDataGridView.ReadOnly = True
            b_cancelar.Enabled = False
            b_gravar.Enabled = False
            FuncionariosDataGridView.Enabled = False

            GroupBox1.Enabled = False
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
        UsernameTextBox.Text = FuncionariosDataGridView.CurrentRow.Cells(7).Value
        PasswordTextBox.Text = FuncionariosDataGridView.CurrentRow.Cells(8).Value
    End Sub

    Private Sub b_gravar_Click(sender As Object, e As EventArgs) Handles b_gravar.Click
        Dim numfuncionarioalterar As Integer
        numfuncionarioalterar = FuncionariosDataGridView.CurrentRow.Cells(6).Value()
        If Not (Num_funcionarioTextBox.Text = "" Or GeneroComboBox.Text = "" Or NomeTextBox.Text = "" Or TelefoneTextBox.Text = "" Or DatanascDateTimePicker.Text = "" Or NifTextBox.Text = "" Or CodigopostalTextBox.Text = "" And ComboBox1.Text = "" And UsernameTextBox.Text = "" And PasswordTextBox.Text = "") Then
            If eliminar <> 1 Then
                For Each linha As DataGridViewRow In FuncionariosDataGridView.Rows
                    If UsernameTextBox.Text = FuncionariosDataGridView.Rows(linha.Index).Cells(7).Value() And numfuncionarioalterar <> FuncionariosDataGridView.Rows(linha.Index).Cells(6).Value() Then
                        MsgBox("Erro! Existe um username igual!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro!")
                        Exit Sub
                    End If


                Next



                Try
                    '    FuncionariosDataGridView.CurrentRow().Cells(7).Value() = UsernameTextBox.Text
                    '    FuncionariosDataGridView.CurrentRow().Cells(8).Value() = PasswordTextBox.Text
                    FuncionariosBindingSource.EndEdit()
                    FuncionariosTableAdapter.Update(JardimzoologicoDataSet.Funcionarios)
                    FuncionariosTableAdapter.Fill(JardimzoologicoDataSet.Funcionarios)
                    MsgBox("Gravado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                    FuncionariosBindingNavigator.Enabled = True
                    GroupBox1.Enabled = False

                    b_gravar.Enabled = False
                    b_cancelar.Enabled = False

                    b_adicionar.Enabled = True
                    b_alterar.Enabled = True
                    b_eliminar.Enabled = True
                    eliminar = 0

                Catch ex As Exception
                    MsgBox(ex.ToString + Chr(13) + "Erro ao gravar, tente novamente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                    FuncionariosBindingNavigator.Enabled = True
                    GroupBox1.Enabled = True

                End Try

            End If
        Else
            MsgBox("Deixou campos em branco!")
        End If
    End Sub

    Private Sub b_cancelar_Click(sender As Object, e As EventArgs) Handles b_cancelar.Click
        Try

        
        FuncionariosDataGridView.ReadOnly = False
        FuncionariosBindingSource.CancelEdit()
        FuncionariosTableAdapter.Fill(JardimzoologicoDataSet.Funcionarios)
        MsgBox("Operação Cancelada!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        FuncionariosBindingNavigator.Enabled = True
        GroupBox1.Enabled = False
        b_gravar.Enabled = False
        b_cancelar.Enabled = False

        b_adicionar.Enabled = True
        b_alterar.Enabled = True
        b_eliminar.Enabled = True
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub




    Private Sub b_carregar_Click(sender As Object, e As EventArgs) Handles b_carregar.Click
        Try
            Dim img As String
            OpenFileDialog1.Filter = "JPG | *.jpg"
            If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
                img = OpenFileDialog1.FileName
                fotobox.Image = System.Drawing.Bitmap.FromFile(img)
            End If

        Catch ex As Exception
            MsgBox("Ocorreu um erro!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Erro!")
        End Try

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4x.Click
        Try
            Dim resp As Integer
            resp = MsgBox("Tem a certeza que deseja sair?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
            If resp = vbYes Then
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
       
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles b_adicionar.Click
        Try

       
        FuncionariosBindingNavigator.Enabled = False
        FuncionariosBindingSource.MoveLast()
        FuncionariosBindingSource.AddNew()
        GroupBox1.Enabled = True
        b_cancelar.Enabled = True
        b_gravar.Enabled = True

        b_adicionar.Enabled = False
        b_alterar.Enabled = False
            b_eliminar.Enabled = False
            FuncionariosDataGridView.CurrentRow().Cells(7).Value() = "xxx"
            FuncionariosDataGridView.CurrentRow().Cells(8).Value() = "xxx"

        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles b_eliminar.Click
        Try

       
        Dim resp As Integer
        resp = MsgBox("Deseja mesmo eliminar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If resp = vbYes Then
            FuncionariosBindingSource.RemoveCurrent()
            MsgBox("Foi removido! Grave para sortir efeito na BD", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            GroupBox1.Enabled = False
            b_gravar.Enabled = True
            b_cancelar.Enabled = True

            b_adicionar.Enabled = False
            b_alterar.Enabled = False
                b_eliminar.Enabled = False
                eliminar = 1

        Else
            MsgBox("Não foi eliminado! Tente novamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles b_alterar.Click
        Dim num, a As Integer



        FuncionariosBindingNavigator.Enabled = False
        Try


            num = InputBox("Qual o número funcionário que deseja alterar?", "Qual Funcionário?")
            a = FuncionariosBindingSource.Find("num_funcionario", num)
            If a = -1 Then
                MsgBox("Esse funcionário não existe, a abortar alteração!", MsgBoxStyle.Critical, "Erro")
            Else
                FuncionariosBindingSource.Position = FuncionariosBindingSource.Find("num_funcionario", num)
                b_gravar.Enabled = True
                b_cancelar.Enabled = True

                b_adicionar.Enabled = False
                b_alterar.Enabled = False
                b_eliminar.Enabled = False

            End If
        Catch ex As Exception
            MsgBox("Insira um número válido", MsgBoxStyle.Critical, "Erro")
        End Try


        GroupBox1.Enabled = True
    End Sub

 
    ' Private Sub FuncionariosDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles FuncionariosDataGridView.SelectionChanged
    '    UsernameTextBox.Text = FuncionariosDataGridView.CurrentRow.Cells(7).Value
    '    PasswordTextBox.Text = FuncionariosDataGridView.CurrentRow.Cells(8).Value
    ' End Sub
End Class