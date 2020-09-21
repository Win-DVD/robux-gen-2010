Public Class Main
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.aud, AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub Play_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Play.Click
        My.Computer.Audio.Play(My.Resources.aud, AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub Play_Sto(ByVal sender As System.Object, ByVal e As EventArgs) Handles Sto.Click
        My.Computer.Audio.Stop()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        Gen.Show()
    End Sub
End Class
