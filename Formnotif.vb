Public Class Formnotif
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim crlaprental As New KartuUjian1
        kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT namasiswa from pembayaran where namasiswa ='" & Label3.Text & "'"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "Pembayaran")
        crlaprental.SetDataSource(ds.Tables("Pembayaran"))
        Form2.CrystalReportViewer1.ReportSource = crlaprental
        kon.Close()
        'FrmCetak.MdiParent = FrmMenuUtama
        Form2.Show()
        Form2.WindowState = FormWindowState.Maximized
    End Sub
End Class