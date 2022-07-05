Public Class frmquiz
    
    Public certo As Integer
    Public errado As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button2.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = False
        Button2.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Enabled = False
        Button4.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button3.Enabled = False
        Button4.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Enabled = False
        Button6.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button5.Enabled = False
        Button6.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.Enabled = False
        Button8.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button7.Enabled = False
        Button8.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button9.Enabled = False
        Button10.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button11.Enabled = False
        Button12.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Button11.Enabled = False
        Button12.Enabled = False
        certo = certo + 1

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button9.Enabled = False
        Button10.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button10.Enabled = True
        Button11.Enabled = True
        Button12.Enabled = True
        Button15.Enabled = True
        Button16.Enabled = True
        Button17.Enabled = True
        Button18.Enabled = True
        Button19.Enabled = True
        Button20.Enabled = True
        Button21.Enabled = True
        Button22.Enabled = True
        Button13.Enabled = True

        Button14.Enabled = False

        Timer1.Enabled = True

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Label7.Text = CStr(certo)
        Label8.Text = CStr(errado)
    End Sub

    Private Sub frmquiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub frmquiz_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
            Button7.Enabled = True
            Button8.Enabled = True
            Button9.Enabled = True
            Button10.Enabled = True
            Button11.Enabled = True
            Button12.Enabled = True
            Button12.Enabled = True
            Button15.Enabled = True
            Button16.Enabled = True
            Button17.Enabled = True
            Button18.Enabled = True
            Button19.Enabled = True
            Button20.Enabled = True
            Button21.Enabled = True
            Button22.Enabled = True
            Button13.Enabled = False
        End If
        If e.KeyCode = Keys.F3 Then
            Button14.Enabled = True
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Button15.Enabled = False
        Button19.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Button15.Enabled = False
        Button19.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Button16.Enabled = False
        Button20.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Button16.Enabled = False
        Button20.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Button17.Enabled = False
        Button21.Enabled = False
        certo = certo + 1
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Button17.Enabled = False
        Button21.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Button18.Enabled = False
        Button22.Enabled = False
        errado = errado + 1
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Button18.Enabled = False
        Button22.Enabled = False
        certo = certo + 1
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Timer1.Interval = 2000 Then
            MsgBox("tchau")
            Timer1.Enabled = False
            Close()

        End If

    End Sub
End Class
