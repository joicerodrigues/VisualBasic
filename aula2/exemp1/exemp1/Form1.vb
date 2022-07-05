Public Class frmaula2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim soma, sand, salg, doce, cafe, sorv As Double
        sand = Val(txtsand.Text)
        salg = Val(txtsalg.Text)
        doce = Val(txtdoce.Text)
        cafe = Val(txtcafe.Text)
        sorv = Val(txtsorvete.Text)
        soma = sand + salg + doce + cafe + sorv
        txttotal.Text = FormatCurrency(soma)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click





    End Sub
End Class
