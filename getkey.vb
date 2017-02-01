Public Class getkey

    Private Sub PictureBox2_Click(sender As Object, e As System.EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.wrlabstudios.hol.es")
    End Sub

    Private Sub enterb_Click(sender As Object, e As System.EventArgs) Handles enterb.Click
        sha256.pass = TextBox1.Text
        mainform.Show()
        Me.Hide()
    End Sub

    Private Sub getkey_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Image = My.Resources.close_hov
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = My.Resources.close_pas
    End Sub
End Class