Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtsabor.Clear()
        txtbebida.Clear()
        txtborda.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Deseja sair?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
