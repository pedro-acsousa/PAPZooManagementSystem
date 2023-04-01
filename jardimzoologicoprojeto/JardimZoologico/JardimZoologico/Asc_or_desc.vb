Public Class Asc_or_desc

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

      
        If Localidades.RadioButton1.Checked Then
            Localidades.LocalidadesBindingSource.Sort = "nomelocalidade asc"
        End If
        If Localidades.RadioButton2.Checked Then
            Localidades.LocalidadesBindingSource.Sort = "cod_postal asc"
        End If
        Do
            ProgressBar1.Value = ProgressBar1.Value + 1
        Loop Until ProgressBar1.Value = 100
        If MsgBox("Ordenação efetuada, OK para Fechar", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Fechar!") = vbOK Then
            Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

      
        If Localidades.RadioButton1.Checked Then
            Localidades.LocalidadesBindingSource.Sort = "nomelocalidade desc"
        End If
        If Localidades.RadioButton2.Checked Then
            Localidades.LocalidadesBindingSource.Sort = "cod_postal desc"
        End If
        Do
            ProgressBar1.Value = ProgressBar1.Value + 1
        Loop Until ProgressBar1.Value = 100
        If MsgBox("Ordenação efetuada, OK para Fechar!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Fechar!") = vbOK Then
            Me.Close()
        End If

        Catch ex As Exception
            MsgBox("Ocorreu um erro inexperado!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Erro")
        End Try


    End Sub

    Private Sub LocalidadesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LocalidadesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JardimzoologicoDataSet)

    End Sub

    Private Sub Asc_or_desc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Localidades' table. You can move, or remove it, as needed.
        Me.LocalidadesTableAdapter.Fill(Me.JardimzoologicoDataSet.Localidades)
        ProgressBar1.Value = 0

    End Sub


End Class