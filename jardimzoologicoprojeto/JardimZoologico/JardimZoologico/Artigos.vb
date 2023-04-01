Public Class Artigos
    Dim user, pass As String
    Private Sub ArtigosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ArtigosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JardimzoologicoDataSet)

    End Sub

    Private Sub Artigos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Artigos' table. You can move, or remove it, as needed.
        Try

    
        Me.ArtigosTableAdapter.Fill(Me.JardimzoologicoDataSet.Artigos)
        Label4.Text = "Estado: Não editável!"
            Button3.Visible = False
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

 
        If Not (TextBox1.Text = "" Or TextBox2.Text = "") Then
            If user = "piter752" And pass = "adm123" Then
                MsgBox("Sessão Iniciada!", MsgBoxStyle.Information, "Sucesso no Login!")
                Label4.ForeColor = Color.Green
                Label4.Text = "Estado: Editável!"
                ArtigosDataGridView.ReadOnly = False
                Button3.Visible = True
            Else
                MsgBox("Credenciais erradas!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Erro!")
            End If
        Else
            MsgBox("Esqueceu-se de preencher o user ou a Password!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Credenciais em falta!")
        End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        user = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        pass = TextBox2.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

     
        user = ""
        pass = ""
        Label4.ForeColor = Color.DarkRed
            MsgBox("Sessão Terminada!", MsgBoxStyle.Information, "Sucesso no Logout!")
            TextBox1.Text = ""
            TextBox2.Text = ""
        Label4.Text = "Estado: Não editável!"
        ArtigosDataGridView.ReadOnly = True
            Button3.Visible = False
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            ArtigosBindingSource.EndEdit()
            ArtigosTableAdapter.Update(JardimzoologicoDataSet.Artigos)
            ArtigosTableAdapter.Fill(JardimzoologicoDataSet.Artigos)
            MsgBox("Guardado na BD!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sucesso!")
        Catch ex As Exception
            MsgBox(ex.ToString + Chr(13) + "Operação não efetuada")
        End Try

    End Sub
End Class