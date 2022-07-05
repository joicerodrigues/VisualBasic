Public Class frmrepete3

    Private Sub frmrepete3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero As Integer = 0
        While numero <= 10
            MsgBox(numero)
            numero += 1
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim numero As Integer = 10
        While numero >= 0
            MsgBox(numero)
            numero -= 1
        End While
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim nome As String = "AAA"
        While (nome <> "FIM")
            nome = InputBox("Digite FIM para Sair!")
        End While
        MsgBox("Terminou !!!!!!!!!")
    End Sub
End Class
