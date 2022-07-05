Public Class frmpagamento

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        txttotal.Text = txtvalor.Text
        PictureBox1.Load("e:\3\pc\aula3\dolar.png")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        txttotal.Text = txtvalor.Text
        PictureBox1.Load("e:\3\pc\aula3\mastercard.png")
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        txttotal.Text = txtvalor.Text
        PictureBox1.Load("e:\3\pc\aula3\visa.jpg")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Deseja sair?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then  
            Me.Close()
        End If
    End Sub
End Class
