Public Class frmrepete2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For numero As Integer = 0 To 10 Step 2
            MsgBox(numero)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For numero As Integer = 30 To 0 Step -1
            MsgBox(numero)
        Next
    End Sub
End Class
