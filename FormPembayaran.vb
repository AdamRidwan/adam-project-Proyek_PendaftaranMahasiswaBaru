Public Class FormPembayaran
    Private Sub FormPembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nama.Focus()
        pem.Items.Add("Reguler")
        prodi.Items.Add("Sistem Informasi")
        prodi.Items.Add("Sistem Komputer")
        prodi.Items.Add("Manajemen Informatika")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim jenisPembayaran As String = "Reguler"
        Dim jumlahPembayaran As Integer
        If jenisPembayaran = "Reguler" Then
            jumlahPembayaran = 3000000
        ElseIf jenisPembayaran = "KIP" Then
            jumlahPembayaran = 0
        Else
            MsgBox("Jenis Pembayaran Tidak Valid")
        End If
        Call proses("INSERT INTO pembayaran(namasiswa,tglbayar,jumlah,prodij,asalsekolah) values('" & nama.Text & "','" & Format(tgl.Value, "yyyy-MM-dd") & "','" & jumlahPembayaran & "','" & prodi.Text & "','" & asal.Text & "')")
        MsgBox("Data Berhasil DiSimpan", MsgBoxStyle.Information, "Informasi")
        Call proses("SELECT namasiswa from pembayaran where namasiswa like '%" & nama.Text & "%'")
        Call Formnotif.Show()
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            namasiswa = cek.Item("namasiswa")
        End If
        Formnotif.Label3.Text = namasiswa
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim crlaprental As New kwitansi
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT namasiswa from pembayaran where namasiswa like '%" & nama.Text & "%' or namasiswa = '" & Label3.Text & "'"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "Pembayaran")
        crlaprental.SetDataSource(ds.Tables("Pembayaran"))
        Form1.CrystalReportViewer1.ReportSource = crlaprental
        kon.Close()
        'FrmCetak.MdiParent = FrmMenuUtama
        Form1.Show()
        Form1.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub pem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pem.SelectedIndexChanged

    End Sub

    Private Sub bklik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bklik.Click
        Me.Close()
    End Sub
End Class