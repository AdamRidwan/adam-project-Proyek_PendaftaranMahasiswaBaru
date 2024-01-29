Public Class Form_pendaftaran
    Sub buatnomor()
        Dim kode, kodebaru, tgl As String
        Dim no As Integer
        tgl = Format(Now, "MM/yyyy")
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from pendaftar " & " order by nopen desc limit 1"
        cek = perintah.ExecuteReader()
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("nopen")
            no = Val(Microsoft.VisualBasic.Right(kode, 3))
            no = no + 1
            kodebaru = "REG-" + tgl + "-" + Format(no, "000")
            idp.Text = kodebaru
        Else
            idp.Text = "REG-" + tgl + "-" + "001"
        End If
        kon.Close()

    End Sub
    Sub bersih()
        idp.Text = ""
        nama.Text = ""
        jenkel.Text = ""
        prodi.Text = ""
        tempat.Text = ""
        agama.Text = ""
        alamat.Text = ""
        asal.Text = ""
        no.Text = ""
        email.Text = ""
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call proses("INSERT INTO pendaftar(nopen,nama,tanggal,jenkel,prodi,tempatdantgl,agama,alamat,asal,notelp,email) values('" & idp.Text & "', '" & nama.Text & "','" & Format(tgl.Value, "yyyy-MM-dd") & "','" & jenkel.Text & "','" & prodi.Text & "', '" & tempat.Text & "', '" & agama.Text & "', '" & alamat.Text & "', '" & asal.Text & "', '" & no.Text & "', '" & email.Text & "')")
        MsgBox("Data Berhasil DiSimpan", MsgBoxStyle.Information, "Informasi")
        Call bersih()
        Call FormPembayaran.Show()
    End Sub
    Private Sub Form_pendaftaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        idp.Focus()
        jenkel.Items.Add("Laki-laki")
        jenkel.Items.Add("Perempuan")
        prodi.Items.Add("Sistem Informasi")
        prodi.Items.Add("Sistem Komputer")
        prodi.Items.Add("Manajemen Informatika")
        agama.Items.Add("Islam")
        agama.Items.Add("Kristen")
        agama.Items.Add("Budha")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call bersih()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
    Private Sub bklik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bklik.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call buatnomor()
    End Sub

End Class
