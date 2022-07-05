Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1, n2, soma As Integer
        n1 = Val(txtn1.Text)
        n2 = Val(txtn2.Text)
        soma = n1 + n2
        txttotal.Text = Str(soma)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n1, n2, soma As Integer
        n1 = Val(txtn1.Text)
        n2 = Val(txtn2.Text)
        soma = n1 - n2
        txttotal.Text = Str(soma)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n1, n2, soma As Integer
        n1 = Val(txtn1.Text)
        n2 = Val(txtn2.Text)
        soma = n1 * n2
        txttotal.Text = Str(soma)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim n1, n2, soma As Integer
        n1 = Val(txtn1.Text)
        n2 = Val(txtn2.Text)
        soma = n1 / n2
        txttotal.Text = Str(soma)
    End Sub
End Class
