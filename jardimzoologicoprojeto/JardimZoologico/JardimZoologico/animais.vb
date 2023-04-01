Public Class animais

    Private Sub AnimaisBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AnimaisBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JardimzoologicoDataSet)

    End Sub

    Private Sub animais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripLabel1.Text = index.sessaoiniciada
        'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Animais' table. You can move, or remove it, as needed.
        Try
            Me.AnimaisTableAdapter.Fill(Me.JardimzoologicoDataSet.Animais)
            Button1.Enabled = False
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = True

            Nome_animalTextBox.ReadOnly = True
            Especie_animalTextBox.ReadOnly = True
            Datanas_animalDateTimePicker.Enabled = False

        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim img As String
            OpenFileDialog1.Filter = "JPG | *.jpg"
            If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
                img = OpenFileDialog1.FileName
                PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
            End If

        Catch ex As Exception
            MsgBox("Ocorreu um erro", MsgBoxStyle.Critical, "Erro")

        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

      
        AnimaisBindingSource.MoveLast()
        AnimaisBindingSource.AddNew()
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = False

        Nome_animalTextBox.ReadOnly = False
        Especie_animalTextBox.ReadOnly = False
            Datanas_animalDateTimePicker.Enabled = True
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim pos As Integer
        Try
            pos = 0
            pos = InputBox("NºAnimal a alterar?", "Alterar Nº")
            AnimaisBindingSource.Position = AnimaisBindingSource.Find("cod_animal", pos)
            Button1.Enabled = True
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = False

            Nome_animalTextBox.ReadOnly = False
            Especie_animalTextBox.ReadOnly = False
            Datanas_animalDateTimePicker.Enabled = True

        Catch ex As Exception
            MsgBox("Valor introduzido inválido")
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try

      
        Dim pos1 As Integer
        Dim Data As String
        Dim edata As Boolean
        pos1 = 0

        pos1 = AnimaisBindingSource.Position()
        Data = Datanas_animalDateTimePicker.Text
        edata = (IsDate(CStr(Data)))
        Try
            If Not (Nome_animalTextBox.Text = "" Or Especie_animalTextBox.Text = "" Or Datanas_animalDateTimePicker.Text = "" Or (PictureBox1.Image Is Nothing)) Then
                If (IsDate(CStr(Data))) Then
                    Try
                        AnimaisBindingSource.EndEdit()
                        AnimaisTableAdapter.Update(JardimzoologicoDataSet.Animais)
                        AnimaisTableAdapter.Fill(JardimzoologicoDataSet.Animais)
                        AnimaisBindingSource.Position = pos1
                        MsgBox("Gravado!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                        Button1.Enabled = False
                        Button2.Enabled = True
                        Button3.Enabled = True
                        Button4.Enabled = False
                        Button5.Enabled = False
                        Button6.Enabled = True

                        Nome_animalTextBox.ReadOnly = True
                        Especie_animalTextBox.ReadOnly = True
                        Datanas_animalDateTimePicker.Enabled = False

                    Catch ex As Exception
                        MsgBox(ex.ToString + Chr(13) + "Erro ao gravar, tente novamente!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                    End Try
                Else : MsgBox("Data não válida!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
                End If
            Else
                MsgBox("Impossível guardar se houver campos em falta, preencha todos os campos", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
            End If

        Catch ex As Exception
            MsgBox("Ocorreu um erro")
        End Try
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim posdel, resp As Integer
        Try

            Nome_animalTextBox.ReadOnly = True
            Especie_animalTextBox.ReadOnly = True
            Datanas_animalDateTimePicker.Enabled = False
            posdel = 0
            posdel = InputBox("NºAnimal a eliminar?", "Alterar Nº")
            AnimaisBindingSource.Position = AnimaisBindingSource.Find("cod_animal", posdel)

            resp = MsgBox("Deseja mesmo eliminar?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar")
            If resp = vbYes Then
                AnimaisBindingSource.RemoveCurrent()
                MsgBox("Foi removido! Grave para sortir efeito na BD", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = True
                Button5.Enabled = True
                Button6.Enabled = False


            Else
                MsgBox("Não foi eliminado! Tente novamente!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            AnimaisBindingSource.CancelEdit()
            AnimaisTableAdapter.Fill(JardimzoologicoDataSet.Animais)
            Button1.Enabled = False
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = True

            Nome_animalTextBox.ReadOnly = True
            Especie_animalTextBox.ReadOnly = True
            Datanas_animalDateTimePicker.Enabled = False

        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try

    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            AnimaisTableAdapter.filternome(JardimzoologicoDataSet.Animais, TextBox1.Text + "%")
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Try
            AnimaisTableAdapter.filterespecie(JardimzoologicoDataSet.Animais, TextBox1.Text + "%")
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try





    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AnimaisBindingSource.MoveFirst()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AnimaisBindingSource.MovePrevious()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        AnimaisBindingSource.MoveNext()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        AnimaisBindingSource.MoveLast()
    End Sub
End Class