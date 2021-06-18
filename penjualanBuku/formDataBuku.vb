Imports System.Data.OleDb
Public Class formDataBuku
    Sub clearBox()
        txtJudul.Clear()
        cmbJenisBuku.Text = ""
        txtKodeBuku.Clear()
        txtPenerbit.Clear()
        txtPengarang.Clear()
        txtDeskripsi.Clear()
        txtHarga.Clear()
        txtJmlhBuku.Clear()
        txtNamaJenis.Clear()
        txtCari.Clear()
        txtKodeBuku.Focus()
    End Sub

    Sub isi()
        cmbJenisBuku.Text = ""
        txtKodeBuku.Clear()
        txtPenerbit.Clear()
        txtPengarang.Clear()
        txtDeskripsi.Clear()
        txtHarga.Clear()
        txtJmlhBuku.Clear()
        txtCari.Clear()
        cmbJenisBuku.Focus()
    End Sub

    Sub tampilBuku()
        dataAdapt = New OleDbDataAdapter("SELECT * FROM Buku", conn)
        dataSet = New DataSet
        dataSet.Clear()
        dataAdapt.Fill(dataSet, "Buku")
        DataGridView1.DataSource = dataSet.Tables("buku")
        DataGridView1.Refresh()
    End Sub

    Sub tampilJenis()
        cmd = New OleDbCommand("SELECT KodeJenis FROM Jenis", conn)
        dataReader = cmd.ExecuteReader()
        Do While dataReader.Read
            cmbJenisBuku.Items.Add(dataReader.Item(0))
        Loop
    End Sub

    Sub aturGrid()
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 50
        DataGridView1.Columns(2).Width = 300
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(7).Width = 300

        DataGridView1.Columns(0).HeaderText = "KODE BARANG"
        DataGridView1.Columns(1).HeaderText = "KODE JENIS"
        DataGridView1.Columns(2).HeaderText = "JUDUL"
        DataGridView1.Columns(3).HeaderText = "PENGARANG"
        DataGridView1.Columns(4).HeaderText = "PENERBIT"
        DataGridView1.Columns(5).HeaderText = "JUMLAH"
        DataGridView1.Columns(6).HeaderText = "HARGA"
        DataGridView1.Columns(7).HeaderText = "DESKRIPSI"
    End Sub
    Private Sub bttnSimpan_Click(sender As Object, e As EventArgs) Handles bttnSimpan.Click
        If txtKodeBuku.Text = "" Or cmbJenisBuku.Text = "" Or
        txtJudul.Text = "" Or txtDeskripsi.Text = "" Or
        txtHarga.Text = "" Or txtPenerbit.Text = "" Or
        txtPengarang.Text = "" Then
            MsgBox("data belum lengkap.")
            txtKodeBuku.Focus()
        Else
            cmd = New OleDbCommand("SELECT * FROM Buku WHERE KodeBuku='" & txtKodeBuku.Text & "'", conn)
            dataReader = cmd.ExecuteReader
            dataReader.Read()
            If dataReader.HasRows = False Then
                cmd = New OleDbCommand("INSERT INTO Buku VALUES('" & txtKodeBuku.Text &
                                             "','" & cmbJenisBuku.Text & "','" & txtJudul.Text &
                                             "','" & txtPengarang.Text & "','" & txtPenerbit.Text &
                                             "','" & txtJmlhBuku.Text & "','" & txtHarga.Text &
                                             "','" & txtDeskripsi.Text & "')", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Simpan data Sukses.", MsgBoxStyle.Information, "Perhatian")
                Call clearBox()
            End If
        End If
        Call tampilBuku()

    End Sub

    Private Sub formDataBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksiServer()
        Call tampilJenis()
        Call tampilBuku()
        Call clearBox()
        Call aturGrid()
    End Sub

    Private Sub cmbJenisBuku_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJenisBuku.SelectedIndexChanged
        Call koneksiServer()
        cmd = New OleDbCommand("SELECT * FROM Jenis WHERE KodeJenis='" _
                               & cmbJenisBuku.Text & "'", conn)
        dataReader = cmd.ExecuteReader
        dataReader.Read()
        If dataReader.HasRows = True Then
            txtNamaJenis.Text = dataReader.Item(1)
        Else
            MsgBox("Kode jenis ini tidak terdaftar")
        End If
    End Sub

    Private Sub bttnBatal_Click(sender As Object, e As EventArgs) Handles bttnBatal.Click
        Call clearBox()
    End Sub

    Private Sub bttnTutup_Click(sender As Object, e As EventArgs) Handles bttnTutup.Click
        Me.Close()
    End Sub

    Private Sub bttnUbah_Click(sender As Object, e As EventArgs) Handles bttnUbah.Click
        If txtKodeBuku.Text = "" Or cmbJenisBuku.Text = "" Or
        txtJudul.Text = "" Or txtDeskripsi.Text = "" Or
        txtHarga.Text = "" Or txtPenerbit.Text = "" Or
        txtPengarang.Text = "" Then
            MsgBox("data belum lengkap.")
            txtKodeBuku.Focus()
        Else
            cmd = New OleDbCommand("SELECT * FROM Buku WHERE KodeBuku='" & txtKodeBuku.Text & "'", conn)
            dataReader = cmd.ExecuteReader
            dataReader.Read()
            cmd = New OleDbCommand("UPDATE Buku SET KodeJenis='" & cmbJenisBuku.Text &
                                   "',Judul='" & txtJudul.Text & "',Pengrang='" & txtPengarang.Text &
                                   "',Penerbit='" & txtPenerbit.Text &
                                   "',JumlahBuku='" & txtJmlhBuku.Text &
                                   "',Harga='" & txtHarga.Text &
                                   "',Deskripsi='" & txtDeskripsi.Text &
                                   "' WHERE KodeJenis='" & txtKodeBuku.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Ubah data Sukses.", MsgBoxStyle.Information, "Perhatian")
        End If
        Call tampilBuku()
        Call clearBox()
    End Sub

    Private Sub bttnHapus_Click(sender As Object, e As EventArgs) Handles bttnHapus.Click
        If txtKodeBuku.Text = "" Then
            MsgBox("Kode buku belum lengkap.")
            txtKodeBuku.Focus()
        Else
            If MessageBox.Show("Anda yakin menghapus data Buku dengan Kode buku " & txtKodeBuku.Text &
                               "?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("DELETE * FROM Buku 
                                        WHERE KodeBuku='" & txtKodeBuku.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diubah.", MsgBoxStyle.Information, "Perhatian")
            End If
        End If
        Call tampilBuku()
        Call clearBox()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        cmd = New OleDbCommand("SELECT * FROM Buku WHERE Judul LIKE '%" & txtCari.Text & "%'", conn)
        dataReader = cmd.ExecuteReader
        dataReader.Read()
        If dataReader.HasRows Then
            dataAdapt = New OleDbDataAdapter("SELECT * FROM Buku WHERE Judul LIKE '%" & txtCari.Text &
                                             "%'", conn)
            dataSet = New DataSet
            dataAdapt.Fill(dataSet, "Dapat")
            DataGridView1.DataSource = dataSet.Tables("Dapat")
        End If
    End Sub

    Private Sub bttnUpdateJenis_Click(sender As Object, e As EventArgs) Handles bttnUpdateJenis.Click
        formMenu.Panel1.Controls.Clear()
        formMenu.Panel1.Controls.Add(formJenisBuku)
        formJenisBuku.Show()
        formMenu.Size = formJenisBuku.Size
    End Sub

    Private Sub txtKodeBuku_TextChanged(sender As Object, e As EventArgs) Handles txtKodeBuku.TextChanged
        cmd = New OleDbCommand("SELECT * FROM Buku WHERE KodeBuku='" & txtKodeBuku.Text & "'", conn)
        dataReader = cmd.ExecuteReader
        dataReader.Read()
        If dataReader.HasRows Then
            txtJudul.Text = dataReader.GetString(2)
            cmbJenisBuku.Text = dataReader.GetString(1)
        Else
            txtJudul.Clear()
            cmbJenisBuku.Text = ""
        End If
    End Sub
End Class
