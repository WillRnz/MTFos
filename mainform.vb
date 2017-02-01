Imports System.IO

Public Class mainform
    Dim ImgSE As Boolean = False
    ' Estrutura Mecher Form
    Public Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure
    Dim movef As MoveForm

    Private Sub cbt_Click(sender As Object, e As System.EventArgs) Handles cbt.Click
        If TabControl1.SelectedIndex = 0 Then
            If sha256.cmode = 0 Then
                cryptbox.Text = sha256.Decrypt(cryptbox.Text)
                cbt.Text = "Cript. Texto"
            ElseIf sha256.cmode = 1 Then
                cryptbox.Text = sha256.Encrypt(cryptbox.Text)
                cbt.Text = "Descript.Texto"
            End If
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles openfile_txts.FileOk
        Dim objreader As New System.IO.StreamReader(openfile_txts.FileName)
        cryptbox.Text = sha256.Decrypt(objreader.ReadToEnd)
        cbt.Text = "Descript.Texto"
        objreader.Close()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles savefile_txts.FileOk
        Dim objWriter As New System.IO.StreamWriter(savefile_txts.FileName)
        If sha256.cmode = 0 Then
            objWriter.Write(cryptbox.Text)
        ElseIf sha256.cmode = 1 Then
            objWriter.Write(sha256.Encrypt(cryptbox.Text))
        End If
        objWriter.Close()
    End Sub

    Private Sub main_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        titlelabel.Text = Me.Text
    End Sub

    Private Sub titlelabel_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles titlelabel.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        movef.X = Me.Left - MousePosition.X
        movef.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub titlelabel_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles titlelabel.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Left = movef.X + MousePosition.X
        Me.Top = movef.y + MousePosition.Y
    End Sub

    Private Sub saveb_Click(sender As Object, e As System.EventArgs) Handles saveb.Click
        If TabControl1.SelectedIndex = 0 Then
            savefile_txts.ShowDialog()
        End If
        If TabControl1.SelectedIndex = 1 Then
            savefile_image.ShowDialog()
        End If
    End Sub

    Private Sub openb_Click(sender As Object, e As System.EventArgs) Handles openb.Click
        If TabControl1.SelectedIndex = 0 Then
            openfile_txts.ShowDialog()
        End If
        If TabControl1.SelectedIndex = 1 Then
            openfile_image.ShowDialog()
        End If
    End Sub

    Private Sub cryptbox_TextChanged(sender As Object, e As System.EventArgs) Handles cryptbox.TextChanged
        If cryptbox.Text = "" Then
            If sha256.cmode = 0 Then
                cryptbox.Text = sha256.Decrypt(cryptbox.Text)
                cbt.Text = "Cript. Texto"
            End If
        End If
    End Sub

    Private Sub openfile_image_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles openfile_image.FileOk
        '  criptedimage.ImageLocation = openfile_image.FileName.ToString()
        Try
            criptedimage.Image = Image.FromStream(sha256.DecriptImage(openfile_image.FileName))
        Catch ex As Exception
            MsgBox("Essa imagem não está criptografada.", MsgBoxStyle.Exclamation, "! Aviso !")
            Try
                criptedimage.Image = Image.FromFile(openfile_image.FileName)
            Catch
                MsgBox("Não foi possivel carregar a imagem.", MsgBoxStyle.Critical, "Erro")
            End Try
        End Try
    End Sub

    Private Sub savefile_image_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles savefile_image.FileOk
        If ImgSE = True Then
            If savefile_image.FilterIndex = 1 Then
                criptedimage.Image.Save(savefile_image.FileName, Imaging.ImageFormat.Bmp)
            ElseIf savefile_image.FilterIndex = 2 Then
                criptedimage.Image.Save(savefile_image.FileName, Imaging.ImageFormat.Gif)
            ElseIf savefile_image.FilterIndex = 3 Then
                criptedimage.Image.Save(savefile_image.FileName, Imaging.ImageFormat.Jpeg)
            ElseIf savefile_image.FilterIndex = 4 Then
                criptedimage.Image.Save(savefile_image.FileName, Imaging.ImageFormat.Png)
            ElseIf savefile_image.FilterIndex = 5 Then
                criptedimage.Image.Save(savefile_image.FileName, Imaging.ImageFormat.Tiff)
            ElseIf savefile_image.FilterIndex = 6 Then
                criptedimage.Image.Save(savefile_image.FileName, Imaging.ImageFormat.Wmf)
            Else
                MsgBox("Escolha um formato válido para a imagem.", MsgBoxStyle.Critical, "Erro")
            End If
        Else
            Dim objWriter As New System.IO.StreamWriter(savefile_image.FileName)
            If savefile_image.FilterIndex = 1 Then
                objWriter.Write(sha256.EncriptImage(Imaging.ImageFormat.Bmp))
            ElseIf savefile_image.FilterIndex = 2 Then
                objWriter.Write(sha256.EncriptImage(Imaging.ImageFormat.Gif))
            ElseIf savefile_image.FilterIndex = 3 Then
                objWriter.Write(sha256.EncriptImage(Imaging.ImageFormat.Jpeg))
            ElseIf savefile_image.FilterIndex = 4 Then
                objWriter.Write(sha256.EncriptImage(Imaging.ImageFormat.Png))
            ElseIf savefile_image.FilterIndex = 5 Then
                objWriter.Write(sha256.EncriptImage(Imaging.ImageFormat.Tiff))
            ElseIf savefile_image.FilterIndex = 6 Then
                objWriter.Write(sha256.EncriptImage(Imaging.ImageFormat.Wmf))
            Else
                MsgBox("Escolha um formato válido para a imagem.", MsgBoxStyle.Critical, "Erro")
            End If
            objWriter.Close()
        End If
        ImgSE = False
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            salvar_se.Visible = True
            cbt.Visible = False
        ElseIf TabControl1.SelectedIndex = 0 Then
            salvar_se.Visible = False
            cbt.Visible = True
        End If
    End Sub

    Private Sub salvar_se_Click(sender As Object, e As EventArgs) Handles salvar_se.Click
        ImgSE = True
        savefile_image.ShowDialog()
    End Sub


    Private Sub minimize_btn_Click(sender As Object, e As EventArgs) Handles minimize_btn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub minimize_btn_MouseHover(sender As Object, e As EventArgs) Handles minimize_btn.MouseHover
        minimize_btn.Image = My.Resources.min_hov
    End Sub

    Private Sub minimize_btn_MouseLeave(sender As Object, e As EventArgs) Handles minimize_btn.MouseLeave
        minimize_btn.Image = My.Resources.min_pas
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Application.Exit()
    End Sub

    Private Sub close_btn_MouseHover(sender As Object, e As EventArgs) Handles close_btn.MouseHover
        close_btn.Image = My.Resources.close_hov
    End Sub

    Private Sub close_btn_MouseLeave(sender As Object, e As EventArgs) Handles close_btn.MouseLeave
        close_btn.Image = My.Resources.close_pas
    End Sub
End Class
