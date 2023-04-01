Public Class Bilheteira
    Public data As Date
    Dim x As New Random
    Dim a As Integer
    Dim pos As Integer
    Dim gerar As Integer = 0

    Dim FontEncoder As New IDAutomation.NetAssembly.FontEncoder
    Private Sub BilheteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BilheteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JardimzoologicoDataSet)

    End Sub

    Private Sub Bilheteira_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CancelarGerarBilheteToolStripMenuItem.Enabled = False
        GuardarBilheteToolStripMenuItem.Enabled = False
        ToolStripStatusLabel1.Text = "Sessão iniciada como: " & index.sessaoiniciada
        'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Bilheteira' table. You can move, or remove it, as needed.
        Me.BilheteiraTableAdapter.Fill(Me.JardimzoologicoDataSet.Bilheteira)
        'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Bilhete' table. You can move, or remove it, as needed.
        Me.BilheteTableAdapter.Fill(Me.JardimzoologicoDataSet.Bilhete)
        data = Date.Now.ToShortDateString()
        For Each linha As DataGridViewRow In BilheteiraDataGridView.Rows
            If BilheteiraDataGridView.Rows(linha.Index).Cells(0).Value() = data Then
                BilheteiraBindingSource.MoveLast()
                Exit Sub
            End If
        Next
        BilheteiraBindingSource.MoveLast()
        BilheteiraBindingSource.AddNew()
        DataTextBox.Text = data
        BilheteiraDataGridView.CurrentRow.Cells(0).Value() = data
        BilheteiraDataGridView.CurrentRow.Cells(1).Value() = 200
        BilheteiraBindingSource.EndEdit()
        BilheteiraTableAdapter.Update(JardimzoologicoDataSet.Bilheteira)
        BilheteiraBindingSource.MoveLast()
        GroupBox1.Enabled = False
        GerarBilheteToolStripMenuItem.Enabled = True
        GuardarBilheteToolStripMenuItem.Enabled = False
        CancelarBilheteToolStripMenuItem.Enabled = True
        ImprimirBilheteToolStripMenuItem.Enabled = True


    End Sub

    Private Sub IdadeTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdadeTextBox.TextChanged
        If IsNumeric(IdadeTextBox.Text) = False And IdadeTextBox.Text <> "" Then
            MsgBox("Insira apenas números!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
            IdadeTextBox.Clear()
        End If

        If Val(IdadeTextBox.Text) >= 0 And Val(IdadeTextBox.Text) <= 2 Then
            TipoclienteComboBox.Text = "Bebé"
        ElseIf Val(IdadeTextBox.Text) >= 3 And Val(IdadeTextBox.Text) <= 17 Then
            TipoclienteComboBox.Text = "Criança"
        ElseIf Val(IdadeTextBox.Text) >= 18 And Val(IdadeTextBox.Text) <= 120 Then
            TipoclienteComboBox.Text = "Adulto"
        End If

        If TipoclienteComboBox.Text = "Bebé" Then
            PrecoTextBox.Text = 2
        ElseIf TipoclienteComboBox.Text = "Criança" Then
            PrecoTextBox.Text = 4
        ElseIf TipoclienteComboBox.Text = "Adulto" Then
            PrecoTextBox.Text = 6
        End If

    End Sub

    Private Sub GerarBilheteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GerarBilheteToolStripMenuItem.Click
        If BilhetesdisponiveisTextBox.Text > 0 Then
            gerar = 1
            ImprimirBilheteToolStripMenuItem.Enabled = False
            CancelarBilheteToolStripMenuItem.Enabled = False
            BilhetesDeHojeToolStripMenuItem.Enabled = False
            CancelarGerarBilheteToolStripMenuItem.Enabled = True
            GroupBox1.Enabled = True
            BilheteBindingSource.MoveLast()
            BilheteBindingSource.AddNew()
            BilheteBindingSource.MoveLast()
            BilheteDataGridView.CurrentRow.Cells("codbarrasnum").Value() = 0
            ValidoTextBox.Text = "Sim"
            BilheteDataGridView.CurrentRow.Cells("valido").Value() = "Sim"
            BilheteDataGridView.CurrentRow.Cells("DataGridViewTextBoxColumn7").Value() = data
            GuardarBilheteToolStripMenuItem.Enabled = True
            GerarBilheteToolStripMenuItem.Enabled = False
            DataTextBox.Text = data
            OperadorcaixaTextBox.Text = index.caixaoperator
            a = Val(x.Next(1000, 99999))
            CodbarrasnumTextBox.Text = a
            For Each linha1 As DataGridViewRow In BilheteDataGridView.Rows
                If BilheteDataGridView.Rows(linha1.Index).Cells("codbarrasnum").Value() = a Then
                    Do
                        a = x.Next(1000, 99999)
                        CodbarrasnumTextBox.Text = a
                    Loop Until BilheteDataGridView.Rows(linha1.Index).Cells("codbarrasnum").Value() <> a
                End If
            Next
        Else
            BilhetesdisponiveisTextBox.Text = 0
            MsgBox("Não há mais bilhetes para venda no dia de hoje!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Erro")
            Exit Sub
        End If
    End Sub


    Private Sub GuardarBilheteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarBilheteToolStripMenuItem.Click
        If IdadeTextBox.Text = "" Then
            MsgBox("Insira a idade!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        Else
            Try
                Call ValidoTextBox_TextChanged(sender, e)
                ImprimirBilheteToolStripMenuItem.Enabled = True
                BilheteBindingSource.EndEdit()
                BilheteTableAdapter.Update(JardimzoologicoDataSet.Bilhete)
                BilheteiraDataGridView.CurrentRow.Cells(1).Value() = BilheteiraDataGridView.CurrentRow.Cells(1).Value() - 1
                BilheteiraBindingSource.EndEdit()
                BilheteiraTableAdapter.Update(JardimzoologicoDataSet.Bilheteira)
                GerarBilheteToolStripMenuItem.Enabled = True
                GuardarBilheteToolStripMenuItem.Enabled = False
                ' BilheteiraDataGridView.CurrentRow.Cells(1).Value() = BilheteiraDataGridView.CurrentRow.Cells(1).Value() - 1
                ' BilhetesdisponiveisTextBox.Text = Val(BilhetesdisponiveisTextBox.Text) - 1
                BilhetesDeHojeToolStripMenuItem.Enabled = True
                gerar = 0
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

 


    Private Sub ValidoTextBox_TextChanged(sender As Object, e As EventArgs) Handles ValidoTextBox.TextChanged
        If gerar = 1 Then
            CancelarBilheteToolStripMenuItem.Enabled = False
            CodbarrasnumTextBox.Enabled = False
            DataTextBox.Enabled = False
            DataDateTimePicker.Enabled = False
            IdadeTextBox.Enabled = True
            NomeclienteTextBox.Enabled = True
            NumbilheteTextBox.Enabled = False
            OperadorcaixaTextBox.Enabled = False
            PrecoTextBox.Enabled = False
            ValidoTextBox.Enabled = True
        Else

            If ValidoTextBox.Text = "Não" Or ValidoTextBox.Text = "Entrou" Then
                CodbarrasnumTextBox.Enabled = False
                DataTextBox.Enabled = False
                DataDateTimePicker.Enabled = False
                IdadeTextBox.Enabled = False
                NomeclienteTextBox.Enabled = False
                NumbilheteTextBox.Enabled = False
                OperadorcaixaTextBox.Enabled = False
                PrecoTextBox.Enabled = False
                ValidoTextBox.Enabled = False
            Else
                CodbarrasnumTextBox.Enabled = False
                DataTextBox.Enabled = False
                DataDateTimePicker.Enabled = False
                IdadeTextBox.Enabled = True
                NomeclienteTextBox.Enabled = True
                NumbilheteTextBox.Enabled = False
                OperadorcaixaTextBox.Enabled = False
                PrecoTextBox.Enabled = False
                ValidoTextBox.Enabled = True
            End If
            If ValidoTextBox.Text <> "Sim" And ValidoTextBox.Text <> "Entrou" Then
                CancelarBilheteToolStripMenuItem.Enabled = False
            Else
                CancelarBilheteToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub CancelarBilheteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelarBilheteToolStripMenuItem.Click
        GuardarBilheteToolStripMenuItem.Enabled = False
        ValidoTextBox.Text = "Não"
        Dim posicaobilhete As Integer
        posicaobilhete = BilheteBindingSource.Position()
        BilheteBindingSource.EndEdit()
        BilheteTableAdapter.Update(JardimzoologicoDataSet.Bilhete)
        BilheteBindingSource.Position() = posicaobilhete
    End Sub

    Private Sub ImprimirBilheteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirBilheteToolStripMenuItem.Click
        Bilhete.ShowDialog()
    End Sub

    
    Private Sub BilhetesDeHojeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BilhetesDeHojeToolStripMenuItem.Click
        listabilheteshoje.ShowDialog()
    End Sub

   

    Private Sub CancelarGerarBilheteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelarGerarBilheteToolStripMenuItem.Click
        gerar = 0
        BilheteBindingSource.CancelEdit()
        GerarBilheteToolStripMenuItem.Enabled = True
        GuardarBilheteToolStripMenuItem.Enabled = False
        CancelarGerarBilheteToolStripMenuItem.Enabled = False
        Call ValidoTextBox_TextChanged(sender, e)
        ImprimirBilheteToolStripMenuItem.Enabled = True
        BilhetesDeHojeToolStripMenuItem.Enabled = True
    End Sub
End Class