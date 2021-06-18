<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formJenisBuku
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
        Me.txtKodeJenis = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaJenis = New System.Windows.Forms.TextBox()
        Me.bttnTutup = New System.Windows.Forms.Button()
        Me.bttnBatal = New System.Windows.Forms.Button()
        Me.bttnHapus = New System.Windows.Forms.Button()
        Me.bttnUbah = New System.Windows.Forms.Button()
        Me.bttnSimpan = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kode Jenis"
        '
        'txtKodeJenis
        '
        Me.txtKodeJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKodeJenis.Location = New System.Drawing.Point(148, 36)
        Me.txtKodeJenis.Name = "txtKodeJenis"
        Me.txtKodeJenis.Size = New System.Drawing.Size(159, 26)
        Me.txtKodeJenis.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Jenis"
        '
        'txtNamaJenis
        '
        Me.txtNamaJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaJenis.Location = New System.Drawing.Point(148, 80)
        Me.txtNamaJenis.Name = "txtNamaJenis"
        Me.txtNamaJenis.Size = New System.Drawing.Size(357, 26)
        Me.txtNamaJenis.TabIndex = 4
        '
        'bttnTutup
        '
        Me.bttnTutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnTutup.Location = New System.Drawing.Point(418, 123)
        Me.bttnTutup.Name = "bttnTutup"
        Me.bttnTutup.Size = New System.Drawing.Size(87, 29)
        Me.bttnTutup.TabIndex = 26
        Me.bttnTutup.Text = "Tutup"
        Me.bttnTutup.UseVisualStyleBackColor = True
        '
        'bttnBatal
        '
        Me.bttnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBatal.Location = New System.Drawing.Point(325, 123)
        Me.bttnBatal.Name = "bttnBatal"
        Me.bttnBatal.Size = New System.Drawing.Size(87, 29)
        Me.bttnBatal.TabIndex = 25
        Me.bttnBatal.Text = "Batal"
        Me.bttnBatal.UseVisualStyleBackColor = True
        '
        'bttnHapus
        '
        Me.bttnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnHapus.Location = New System.Drawing.Point(232, 123)
        Me.bttnHapus.Name = "bttnHapus"
        Me.bttnHapus.Size = New System.Drawing.Size(87, 29)
        Me.bttnHapus.TabIndex = 24
        Me.bttnHapus.Text = "Hapus"
        Me.bttnHapus.UseVisualStyleBackColor = True
        '
        'bttnUbah
        '
        Me.bttnUbah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnUbah.Location = New System.Drawing.Point(139, 123)
        Me.bttnUbah.Name = "bttnUbah"
        Me.bttnUbah.Size = New System.Drawing.Size(87, 29)
        Me.bttnUbah.TabIndex = 23
        Me.bttnUbah.Text = "Ubah"
        Me.bttnUbah.UseVisualStyleBackColor = True
        '
        'bttnSimpan
        '
        Me.bttnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnSimpan.Location = New System.Drawing.Point(46, 123)
        Me.bttnSimpan.Name = "bttnSimpan"
        Me.bttnSimpan.Size = New System.Drawing.Size(87, 29)
        Me.bttnSimpan.TabIndex = 22
        Me.bttnSimpan.Text = "Simpan"
        Me.bttnSimpan.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(46, 158)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(459, 26)
        Me.txtCari.TabIndex = 27
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(46, 190)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(459, 215)
        Me.DataGridView1.TabIndex = 28
        '
        'formJenisBuku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 520)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.bttnTutup)
        Me.Controls.Add(Me.bttnBatal)
        Me.Controls.Add(Me.bttnHapus)
        Me.Controls.Add(Me.bttnUbah)
        Me.Controls.Add(Me.bttnSimpan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNamaJenis)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtKodeJenis)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formJenisBuku"
        Me.Text = "Data Jenis Buku"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtKodeJenis As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNamaJenis As TextBox
    Friend WithEvents bttnTutup As Button
    Friend WithEvents bttnBatal As Button
    Friend WithEvents bttnHapus As Button
    Friend WithEvents bttnUbah As Button
    Friend WithEvents bttnSimpan As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
