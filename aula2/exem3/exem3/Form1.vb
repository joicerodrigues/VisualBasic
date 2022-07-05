Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inicio As Date = CType(txtdatini.Text, Date)
        Dim fim As Date = CType(txtdatafim.Text, Date)
        Dim total As TimeSpan
        total = fim.Subtract(inicio)
        'substrac método para subtrair datas com a variavel timespan         MsgBox(total.TotalDays & " total dias")         MsgBox(total.TotalHours & " total de horas")         'existe outras opções 

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Deseja sair?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
