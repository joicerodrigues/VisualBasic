Public Class frmaula3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        ListBox1.Items.Add(MaskedTextBox1.Text)
        ListBox1.Items.Add(ComboBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("Deseja sair?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class
