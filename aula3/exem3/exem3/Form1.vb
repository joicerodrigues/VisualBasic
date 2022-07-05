Public Class frmanimação

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles pic4.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If pic1.Visible = True Then


            pic1.Visible = False
            pic2.Visible = True
            pic3.Visible = False
            pic4.Visible = False
        ElseIf pic2.Visible = True Then
            pic1.Visible = False
            pic2.Visible = False
            pic3.Visible = True
            pic4.Visible = False
        ElseIf pic3.Visible = True Then
            pic1.Visible = False
            pic2.Visible = False
            pic3.Visible = False
            pic4.Visible = True
        ElseIf pic4.Visible = True Then
            pic1.Visible = True
            pic2.Visible = False
            pic3.Visible = False
            pic4.Visible = False
        End If
    End Sub

    Private Sub pic1_Click(sender As Object, e As EventArgs) Handles pic1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
