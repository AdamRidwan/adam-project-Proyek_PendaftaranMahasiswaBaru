<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Flogin
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bklik = New System.Windows.Forms.Button()
        Me.tpass = New System.Windows.Forms.TextBox()
        Me.tusername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btlogin = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(437, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(238, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Sudah Punya Account ?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Halaman Login " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'bklik
        '
        Me.bklik.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bklik.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bklik.Location = New System.Drawing.Point(527, 375)
        Me.bklik.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.bklik.Name = "bklik"
        Me.bklik.Size = New System.Drawing.Size(73, 25)
        Me.bklik.TabIndex = 8
        Me.bklik.Text = "Klik Disini"
        Me.bklik.UseVisualStyleBackColor = True
        '
        'tpass
        '
        Me.tpass.Location = New System.Drawing.Point(185, 215)
        Me.tpass.Name = "tpass"
        Me.tpass.Size = New System.Drawing.Size(295, 22)
        Me.tpass.TabIndex = 3
        '
        'tusername
        '
        Me.tusername.Location = New System.Drawing.Point(185, 131)
        Me.tusername.Name = "tusername"
        Me.tusername.Size = New System.Drawing.Size(295, 22)
        Me.tusername.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "User Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.bklik)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btlogin)
        Me.GroupBox2.Controls.Add(Me.tpass)
        Me.GroupBox2.Controls.Add(Me.tusername)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(687, 456)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'btlogin
        '
        Me.btlogin.BackColor = System.Drawing.Color.White
        Me.btlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btlogin.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btlogin.Location = New System.Drawing.Point(228, 289)
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Size = New System.Drawing.Size(218, 39)
        Me.btlogin.TabIndex = 4
        Me.btlogin.Text = "Login"
        Me.btlogin.UseVisualStyleBackColor = False
        '
        'Flogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 456)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Flogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flogin"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bklik As System.Windows.Forms.Button
    Friend WithEvents tpass As System.Windows.Forms.TextBox
    Friend WithEvents tusername As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btlogin As System.Windows.Forms.Button
End Class
