Public Class frmcase

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedItem
            Case "Fevereiro"
                MsgBox("Este mês tem 28 dias")
            Case "Abril", "Junho", "Setembro", "Novembro"
                MsgBox("Este mês tem 30 dias")
            Case Else
                MsgBox("Este mês tem 31 dias")
        End Select
    End Sub
End Class
