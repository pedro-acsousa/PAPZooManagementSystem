Public Class Bilhete


    Private Sub Bilhete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JardimzoologicoDataSet.Bilhete' table. You can move, or remove it, as needed.
        Me.BilheteTableAdapter.Fill(Me.JardimzoologicoDataSet.Bilhete)
        NomeclienteTextBox.Text = Bilheteira.NomeclienteTextBox.Text
        CodbarrasnumTextBox.Text = Bilheteira.CodbarrasnumTextBox.Text
        NumbilheteTextBox.Text = Bilheteira.NumbilheteTextBox.Text
        PrecoTextBox.Text = Bilheteira.PrecoTextBox.Text & " €"
        TipoclienteTextBox.Text = Bilheteira.TipoclienteComboBox.Text
        ValidoTextBox.Text = Bilheteira.ValidoTextBox.Text
        If Bilheteira.ValidoTextBox.Text = "Sim" Then
            ValidoTextBox.Text = "Válido"
        Else
            ValidoTextBox.Text = "Inválido"
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Visible = False
        If MsgBox("Deseja mesmo imprimir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir?") = vbYes Then
            If PrintDialog1.ShowDialog() Then
                Me.PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
                PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
            End If
          
        Else
            Me.Close()
        End If
    End Sub
End Class