Public Class FormDaftar
    Sub bersih()
        tkd.Text = ""
        tnama.Text = ""
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub csimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles csimpan.Click
        Call proses("INSERT INTO user VALUES('" & tkd.Text & "','" & tnama.Text & "',MD5('12345')")
        MsgBox("Password Pendaftar Baru Adalah : 12345")
        Call bersih()
    End Sub
End Class