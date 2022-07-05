Public Class frmrepete4

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, t, i As Integer
        n = TextBox1.Text
        For i = 0 To 10 Step 1
            t = n * i
            ListBox1.Items.Add(n & " x " & i & " = " & t)

        Next
    End Sub

    Private Sub frmrepete4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nome As String = "AAA"
        While (nome <> "INFO")
            nome = InputBox("Digite INFO para entrar!")
        End While
        MsgBox("Bem-vindo(a)")
    End Sub
End Class
