<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formDataBuku
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtKodeBuku = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNamaJenis = New System.Windows.Forms.TextBox()
        Me.cmbJenisBuku = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPengarang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPenerbit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtJmlhBuku = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDeskripsi = New System.Windows.Forms.TextBox()
        Me.bttnSimpan = New System.Windows.Forms.Button()
        Me.bttnUbah = New System.Windows.Forms.Button()
        Me.bttnHapus = New System.Windows.Forms.Button()
        Me.bttnBatal = New System.Windows.Forms.Button()
        Me.bttnTutup = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bttnUpdateJenis = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtKodeBuku
        '
        Me.txtKodeBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeBuku.Location = New System.Drawing.Point(132, 23)
        Me.txtKodeBuku.MaxLength = 3
        Me.txtKodeBuku.Name = "txtKodeBuku"
        Me.txtKodeBuku.Size = New System.Drawing.Size(80, 26)
        Me.txtKodeBuku.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Buku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Judul"
        '
        'txtJudul
        '
        Me.txtJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJudul.Location = New System.Drawing.Point(132, 55)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(694, 26)
        Me.txtJudul.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(222, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jenis Buku"
        '
        'txtNamaJenis
        '
        Me.txtNamaJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaJenis.Location = New System.Drawing.Point(420, 25)
        Me.txtNamaJenis.Name = "txtNamaJenis"
        Me.txtNamaJenis.ReadOnly = True
        Me.txtNamaJenis.Size = New System.Drawing.Size(248, 26)
        Me.txtNamaJenis.TabIndex = 6
        '
        'cmbJenisBuku
        '
        Me.cmbJenisBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJenisBuku.FormattingEnabled = True
        Me.cmbJenisBuku.Location = New System.Drawing.Point(315, 23)
        Me.cmbJenisBuku.Name = "cmbJenisBuku"
        Me.cmbJenisBuku.Size = New System.Drawing.Size(90, 28)
        Me.cmbJenisBuku.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Pengarang"
        '
        'txtPengarang
        '
        Me.txtPengarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPengarang.Location = New System.Drawing.Point(132, 89)
        Me.txtPengarang.Name = "txtPengarang"
        Me.txtPengarang.Size = New System.Drawing.Size(273, 26)
        Me.txtPengarang.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Penerbit"
        '
        'txtPenerbit
        '
        Me.txtPenerbit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenerbit.Location = New System.Drawing.Point(132, 132)
        Me.txtPenerbit.Name = "txtPenerbit"
        Me.txtPenerbit.Size = New System.Drawing.Size(273, 26)
        Me.txtPenerbit.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Jumlah Buku"
        '
        'txtJmlhBuku
        '
        Me.txtJmlhBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJmlhBuku.Location = New System.Drawing.Point(131, 172)
        Me.txtJmlhBuku.Name = "txtJmlhBuku"
        Me.txtJmlhBuku.Size = New System.Drawing.Size(80, 26)
        Me.txtJmlhBuku.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(221, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Harga"
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(280, 172)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(124, 26)
        Me.txtHarga.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDeskripsi)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(414, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 124)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deskripsi"
        '
        'txtDeskripsi
        '
        Me.txtDeskripsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeskripsi.Location = New System.Drawing.Point(6, 25)
        Me.txtDeskripsi.Multiline = True
        Me.txtDeskripsi.Name = "txtDeskripsi"
        Me.txtDeskripsi.Size = New System.Drawing.Size(397, 93)
        Me.txtDeskripsi.TabIndex = 17
        '
        'bttnSimpan
        '
        Me.bttnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSimpan.Location = New System.Drawing.Point(302, 217)
        Me.bttnSimpan.Name = "bttnSimpan"
        Me.bttnSimpan.Size = New System.Drawing.Size(87, 29)
        Me.bttnSimpan.TabIndex = 17
        Me.bttnSimpan.Text = "Simpan"
        Me.bttnSimpan.UseVisualStyleBackColor = True
        '
        'bttnUbah
        '
        Me.bttnUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnUbah.Location = New System.Drawing.Point(395, 217)
        Me.bttnUbah.Name = "bttnUbah"
        Me.bttnUbah.Size = New System.Drawing.Size(87, 29)
        Me.bttnUbah.TabIndex = 18
        Me.bttnUbah.Text = "Ubah"
        Me.bttnUbah.UseVisualStyleBackColor = True
        '
        'bttnHapus
        '
        Me.bttnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnHapus.Location = New System.Drawing.Point(488, 217)
        Me.bttnHapus.Name = "bttnHapus"
        Me.bttnHapus.Size = New System.Drawing.Size(87, 29)
        Me.bttnHapus.TabIndex = 19
        Me.bttnHapus.Text = "Hapus"
        Me.bttnHapus.UseVisualStyleBackColor = True
        '
        'bttnBatal
        '
        Me.bttnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBatal.Location = New System.Drawing.Point(581, 217)
        Me.bttnBatal.Name = "bttnBatal"
        Me.bttnBatal.Size = New System.Drawing.Size(87, 29)
        Me.bttnBatal.TabIndex = 20
        Me.bttnBatal.Text = "Batal"
        Me.bttnBatal.UseVisualStyleBackColor = True
        '
        'bttnTutup
        '
        Me.bttnTutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnTutup.Location = New System.Drawing.Point(674, 217)
        Me.bttnTutup.Name = "bttnTutup"
        Me.bttnTutup.Size = New System.Drawing.Size(87, 29)
        Me.bttnTutup.TabIndex = 21
        Me.bttnTutup.Text = "Tutup"
        Me.bttnTutup.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(29, 254)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(797, 26)
        Me.txtCari.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 290)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(797, 236)
        Me.DataGridView1.TabIndex = 23
        '
        'bttnUpdateJenis
        '
        Me.bttnUpdateJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnUpdateJenis.Location = New System.Drawing.Point(674, 24)
        Me.bttnUpdateJenis.Name = "bttnUpdateJenis"
        Me.bttnUpdateJenis.Size = New System.Drawing.Size(152, 28)
        Me.bttnUpdateJenis.TabIndex = 24
        Me.bttnUpdateJenis.Text = "Update Jenis Buku"
        Me.bttnUpdateJenis.UseVisualStyleBackColor = True
        '
        'formDataBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 623)
        Me.Controls.Add(Me.bttnUpdateJenis)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.bttnTutup)
        Me.Controls.Add(Me.bttnBatal)
        Me.Controls.Add(Me.bttnHapus)
        Me.Controls.Add(Me.bttnUbah)
        Me.Controls.Add(Me.bttnSimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtJmlhBuku)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPenerbit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPengarang)
        Me.Controls.Add(Me.cmbJenisBuku)
        Me.Controls.Add(Me.txtNamaJenis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtJudul)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKodeBuku)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formDataBuku"
        Me.Text = "Data Buku"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNamaJenis As TextBox
    Friend WithEvents cmbJenisBuku As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPengarang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtJmlhBuku As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents bttnSimpan As Button
    Friend WithEvents bttnUbah As Button
    Friend WithEvents bttnHapus As Button
    Friend WithEvents bttnBatal As Button
    Friend WithEvents bttnTutup As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bttnUpdateJenis As Button
End Class
