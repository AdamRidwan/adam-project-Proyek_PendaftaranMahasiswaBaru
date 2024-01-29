Public Class Flogin

    Private Sub tusername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tusername.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                tpass.Focus()
        End Select
    End Sub
    Private Sub btlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btlogin.Click
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT * FROM user WHERE userid='" & tusername.Text & "' AND userpass = MD5('" & tpass.Text & "')"
        cek = perintah.ExecuteReader
        cek.Read()
        Call Form_pendaftaran.Show()
        kon.Close()
    End Sub

    Private Sub Flogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tusername.Focus()
    End Sub

    Private Sub bklik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bklik.Click
        Call FormDaftar.Show()
    End Sub

    Private Sub tpass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tpass.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btlogin_Click(e, AcceptButton)
        End Select
    End Sub

End Class