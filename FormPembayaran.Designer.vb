<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembayaran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.asal = New System.Windows.Forms.TextBox()
        Me.tgl = New System.Windows.Forms.DateTimePicker()
        Me.prodi = New System.Windows.Forms.ComboBox()
        Me.pem = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bklik = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(606, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORMULIR PEMBAYARAN MAHASISWA BARU STMIK AMIK JAYANUSA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(214, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tahun Akademik 2023/2024"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nama Siswa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Jenis Pembayaran"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(95, 396)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Program Studi Yang Dipilih"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 457)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Asal Sekolah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(96, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tanggal Bayar"
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(304, 182)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(248, 22)
        Me.nama.TabIndex = 3
        '
        'asal
        '
        Me.asal.Location = New System.Drawing.Point(305, 452)
        Me.asal.Name = "asal"
        Me.asal.Size = New System.Drawing.Size(248, 22)
        Me.asal.TabIndex = 3
        '
        'tgl
        '
        Me.tgl.Location = New System.Drawing.Point(304, 255)
        Me.tgl.Name = "tgl"
        Me.tgl.Size = New System.Drawing.Size(248, 22)
        Me.tgl.TabIndex = 4
        '
        'prodi
        '
        Me.prodi.FormattingEnabled = True
        Me.prodi.Location = New System.Drawing.Point(304, 389)
        Me.prodi.Name = "prodi"
        Me.prodi.Size = New System.Drawing.Size(249, 24)
        Me.prodi.TabIndex = 5
        Me.prodi.Text = "====Pilih===="
        '
        'pem
        '
        Me.pem.FormattingEnabled = True
        Me.pem.Location = New System.Drawing.Point(304, 321)
        Me.pem.Name = "pem"
        Me.pem.Size = New System.Drawing.Size(248, 24)
        Me.pem.TabIndex = 5
        Me.pem.Text = "====Pilih===="
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Location = New System.Drawing.Point(209, 574)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Bayar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Location = New System.Drawing.Point(391, 574)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 34)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cetak Kwitansi"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.bklik)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.pem)
        Me.Panel1.Controls.Add(Me.prodi)
        Me.Panel1.Controls.Add(Me.tgl)
        Me.Panel1.Controls.Add(Me.asal)
        Me.Panel1.Controls.Add(Me.nama)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(721, 651)
        Me.Panel1.TabIndex = 1
        '
        'bklik
        '
        Me.bklik.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bklik.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bklik.Location = New System.Drawing.Point(12, 56)
        Me.bklik.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bklik.Name = "bklik"
        Me.bklik.Size = New System.Drawing.Size(73, 25)
        Me.bklik.TabIndex = 10
        Me.bklik.Text = "<<-"
        Me.bklik.UseVisualStyleBackColor = True
        '
        'FormPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 651)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormPembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPembayaran"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents asal As System.Windows.Forms.TextBox
    Friend WithEvents tgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents prodi As System.Windows.Forms.ComboBox
    Friend WithEvents pem As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bklik As System.Windows.Forms.Button
End Class
