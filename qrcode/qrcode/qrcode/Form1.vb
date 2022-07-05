Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Codec.Data
Public Class frmqrcode


    Private Sub frmqrcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picimagem.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim qremcode As New QRCodeEncoder
            Dim qrcode As Bitmap = qremcode.Encode(txttexto.Text)
            picimagem.Image = TryCast(qrcode, Image)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim sfd As New SaveFileDialog()
            sfd.InitialDirectory = "c:\downs\QRcode\"
            sfd.Filter = "PNG | *.png| JPEG| *.jpg | BMP| *.bmp"
            If sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                picimagem.Image.Save(sfd.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try

            Dim ofd As New SaveFileDialog()
            sfd.InitialDirectory = "c:\downs\QRcode\"
            If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                picimagem.ImageLocation = ofd.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim decoder As New QRCodeDecoder
            MessageBox.Show(decoder.Decode(New QRCodeBitmapImage(TryCast(picimagem.Image, Bitmap))))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class
