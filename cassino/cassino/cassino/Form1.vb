Public Class frmcassino
    Public contador As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = False 'oculta moedas
        Label1.Text = Int(Rnd() * 10) 'escolhe números aleatórios 0 e 1
        Label2.Text = Int(Rnd() * 10)
        Label3.Text = Int(Rnd() * 10)
        'se qualquer um dos labels for 7 a figura aparece 'coloque and para dificulta"
        If (Label2.Text = 7) And (Label3.Text = 7) And (Label1.Text = 7) And
            PictureBox1.Visible = True Then
            MsgBox("Parabens!!!!")
        Else
            contador = contador + 1
        End If
        Dim n As String
        n = TextBox1.Text
        If contador = n Then
            MsgBox("acabou as tentatovas")

            Me.Close()
        End If


    End Sub

    Private Sub frmcassino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
