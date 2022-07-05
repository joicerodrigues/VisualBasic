Public Class frmalunos

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total, masculino, feminina As Integer
        Dim porc_masculino, porc_feminina As Double
        total = txttotal.Text
        masculino = txtmasc.Text
        feminina = txtfem.Text
        porc_masculino = (masculino * 100) / total
        porc_feminina = (feminina * 100) / total
        MsgBox("A porcentagem de alunos masculinos é: " & CStr(porc_masculino) & "%")
        MsgBox("A porcentagem de alunos femininas é: " & CStr(porc_feminina) & "%")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
