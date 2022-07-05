Public Class frmaula1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = txtnome.Text
        Label4.Text = txtfone.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtfone_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtfone.MaskInputRejected

    End Sub
End Class
