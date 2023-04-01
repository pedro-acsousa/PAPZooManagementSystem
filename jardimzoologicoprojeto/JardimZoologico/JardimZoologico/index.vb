Imports System.Data.OleDb

Public Class index
    Public pos As Integer
    Public caixaoperator As String
    Public sessaoiniciada As String

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        funcionarios.ShowDialog()
    End Sub

    Private Sub LocalidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocalidadesToolStripMenuItem.Click
        Localidades.ShowDialog()
    End Sub

    Private Sub index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Funcionarios' table. You can move, or remove it, as needed.
        Me.FuncionariosTableAdapter.Fill(Me.JardimzoologicoDataSet.Funcionarios)
        Button2.Enabled = False
    End Sub

  
    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Compras.ShowDialog()


    End Sub

    Private Sub AnimaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnimaisToolStripMenuItem.Click
        animais.ShowDialog()
    End Sub

    Private Sub ArtigosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArtigosToolStripMenuItem.Click
        Artigos.ShowDialog()
    End Sub


    Private Sub FuncionariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FuncionariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JardimzoologicoDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim utilizador, password As String
        utilizador = TextBox1.Text
        password = TextBox2.Text
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then


            For Each linha As DataGridViewRow In FuncionariosDataGridView.Rows

                If utilizador = FuncionariosDataGridView.Rows(linha.Index).Cells(8).Value() And password = FuncionariosDataGridView.Rows(linha.Index).Cells(9).Value() Then

                    MsgBox("Bem vindo: " & FuncionariosDataGridView.Rows(linha.Index).Cells(1).Value, MsgBoxStyle.Exclamation)
                    pos = (linha.Index)
                    If FuncionariosDataGridView.Rows(linha.Index).Cells(10).Value() = "administrador" Then
                        MenuStrip1.Enabled = True
                    Else
                        MenuStrip1.Enabled = True
                        FuncionáriosToolStripMenuItem.Enabled = False
                        LocalidadesToolStripMenuItem.Enabled = False

                    End If
                    Button1.Enabled = False
                    Button2.Enabled = True
                    sessaoiniciada = FuncionariosDataGridView.Rows(linha.Index).Cells(1).Value
                    FuncionariosBindingSource.Position = pos
                    caixaoperator = FuncionariosDataGridView.Rows(linha.Index).Cells(1).Value
                    Exit Sub
                End If


            Next
            MsgBox("Utilizador não encontrado!", MsgBoxStyle.Critical)
        Else : Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sessaoiniciada = ""
        MenuStrip1.Enabled = False
        TextBox1.Clear()
        TextBox2.Clear()
        Button1.Enabled = True
        Button2.Enabled = False
        FuncionáriosToolStripMenuItem.Enabled = True
        LocalidadesToolStripMenuItem.Enabled = True
    End Sub

    Private Sub BilheteiraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BilheteiraToolStripMenuItem.Click
   
        Bilheteira.ShowDialog()
    End Sub
End Class
