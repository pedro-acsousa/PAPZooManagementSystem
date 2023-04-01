Imports System.ComponentModel

Public Class listabilheteshoje

    Private Sub BilheteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BilheteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JardimzoologicoDataSet)

    End Sub

    Private Sub listabilheteshoje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Bilhete' table. You can move, or remove it, as needed.
        Me.BilheteTableAdapter.Fill(Me.JardimzoologicoDataSet.Bilhete)
        BilheteTableAdapter.filtrarbilheteshj(JardimzoologicoDataSet.Bilhete, Date.Today)
        ToolStripStatusLabel1.Text = "Está a visualizar os bilhetes do dia: " & Date.Today & " (Hoje)"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        BilheteTableAdapter.filtrarbilheteshj(JardimzoologicoDataSet.Bilhete, DateTimePicker1.Text)
        ToolStripStatusLabel1.Text = "Está a visualizar os bilhetes do dia: " & DateTimePicker1.Text
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BilheteTableAdapter.filtrarbilheteshj(JardimzoologicoDataSet.Bilhete, Date.Today)
        ToolStripStatusLabel1.Text = "Está a visualizar os bilhetes do dia: " & Date.Today & " (Hoje)"
        DateTimePicker1.Value = Date.Today()
    End Sub

    Private Sub AscendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AscendenteToolStripMenuItem.Click
        BilheteDataGridView.Sort(BilheteDataGridView.Columns(3), ListSortDirection.Ascending)

    End Sub


    Private Sub DescendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescendenteToolStripMenuItem.Click
        BilheteDataGridView.Sort(BilheteDataGridView.Columns(3), ListSortDirection.Descending)
    End Sub

    Private Sub NºAscendenteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NºAscendenteToolStripMenuItem1.Click
        BilheteDataGridView.Sort(BilheteDataGridView.Columns(0), ListSortDirection.Ascending)
    End Sub

    Private Sub NºAscendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NºAscendenteToolStripMenuItem.Click
        BilheteDataGridView.Sort(BilheteDataGridView.Columns(0), ListSortDirection.Descending)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim posbilhete As Integer
        Dim datatemporaria As Date
        If BilheteDataGridView.CurrentRow.Cells(7).Value = "Entrou" Then
            MsgBox("Este cliente já deu entrada", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Entrada duplicada")
            Exit Sub
        End If

        If BilheteDataGridView.CurrentRow.Cells(7).Value = "Sim" Then

            Try
                If MsgBox("Tem a certeza que pretende registar a entrada do cliente " & BilheteDataGridView.CurrentRow.Cells(3).Value & ", bilhete número " & BilheteDataGridView.CurrentRow.Cells(0).Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar") = vbYes Then
                    posbilhete = BilheteBindingSource.Position
                    datatemporaria = DateTimePicker1.Value
                    BilheteDataGridView.CurrentRow.Cells(7).Value = "Entrou"
                    BilheteBindingSource.EndEdit()
                    BilheteTableAdapter.Update(JardimzoologicoDataSet.Bilhete)
                    BilheteTableAdapter.Fill(JardimzoologicoDataSet.Bilhete)
                    BilheteBindingSource.Position = posbilhete
                    MsgBox("Deu entrada com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Sucesso")
                    DateTimePicker1.Value = datatemporaria
                    Call DateTimePicker1_ValueChanged(sender, e)
                End If
            Catch ex As Exception
                MsgBox("Erro no registo de entrada", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
            End Try
        Else
            MsgBox("O bilhete não é válido, entrada não autorizada", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Erro!")
        End If
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        BilheteTableAdapter.filtrarnum(JardimzoologicoDataSet.Bilhete, TextBox1.Text)
    End Sub

   
End Class