Public Class frmcase2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dia As Integer
        dia = InputBox("Digite um numero de 1 a 7")
        Select Case dia
            Case 1
                MsgBox("Domingo")
            Case 2
                MsgBox("Segunda")
            Case 3
                MsgBox("Terça")
            Case 4
                MsgBox("Quarta")
            Case 5
                MsgBox("Quinta")
            Case 6
                MsgBox("Sexta")
            Case 7
                MsgBox("Sábado")
        End Select
    End Sub
End Class
