Imports System.Data.OleDb
Public Class formJenisBuku
    Sub clearBox()
        txtKodeJenis.Clear()
        txtNamaJenis.Clear()
        txtKodeJenis.Focus()
    End Sub

    Sub tampilData()
        dataAdapt = New OleDbDataAdapter("SELECT * FROM Jenis", conn)
        dataSet = New DataSet
        dataSet.Clear()
        dataAdapt.Fill(dataSet, "Jenis")
        DataGridView1.DataSource = dataSet.Tables("Jenis")
        DataGridView1.Refresh()
    End Sub
    Private Sub txtKodeJenis_TextChanged(sender As Object, e As EventArgs) Handles txtKodeJenis.TextChanged
        cmd = New OleDbCommand("SELECT * FROM Jenis WHERE KodeJenis='" & txtKodeJenis.Text & "'", conn)
        dataReader = cmd.ExecuteReader
        dataReader.Read()
        If dataReader.HasRows Then
            txtNamaJenis.Text = dataReader.GetString(1)
        Else
            txtNamaJenis.Clear()
        End If
    End Sub

    Private Sub formJenisBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksiServer()
        Call tampilData()
        Call clearBox()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        cmd = New OleDbCommand("SELECT * FROM Jenis WHERE Jenis LIKE '%" & txtCari.Text & "%'", conn)
        dataReader = cmd.ExecuteReader
        dataReader.Read()
        If dataReader.HasRows Then
            dataAdapt = New OleDbDataAdapter("SELECT * FROM Jenis WHERE Jenis LIKE '%" & txtCari.Text &
                                             "%'", conn)
            dataSet = New DataSet
            dataAdapt.Fill(dataSet, "Dapat")
            DataGridView1.DataSource = dataSet.Tables("Dapat")
        End If
    End Sub

    Private Sub bttnSimpan_Click(sender As Object, e As EventArgs) Handles bttnSimpan.Click
        If txtKodeJenis.Text = "" Or txtNamaJenis.Text = "" Then
            MsgBox("data belum lengkap.")
            txtKodeJenis.Focus()
        Else
            cmd = New OleDbCommand("SELECT * FROM Jenis WHERE KodeJenis='" & txtKodeJenis.Text & "'", conn)
            dataReader = cmd.ExecuteReader
            dataReader.Read()
            If dataReader.HasRows = False Then
                cmd = New OleDbCommand("INSERT INTO Jenis VALUES('" & txtKodeJenis.Text &
                                             "','" & txtNamaJenis.Text & "')", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Simpan data Sukses.", MsgBoxStyle.Information, "Perhatian")
            End If
        End If
        Call tampilData()
        Call clearBox()
    End Sub

    Private Sub bttnUbah_Click(sender As Object, e As EventArgs) Handles bttnUbah.Click
        If txtKodeJenis.Text = "" Then
            MsgBox("data belum lengkap.")
            txtKodeJenis.Focus()
        Else
            cmd = New OleDbCommand("SELECT * FROM Jenis WHERE KodeJenis='" & txtKodeJenis.Text & "'", conn)
            dataReader = cmd.ExecuteReader
            dataReader.Read()
            If dataReader.HasRows = True Then
                cmd = New OleDbCommand("UPDATE jenis SET Jenis ='" & txtNamaJenis.Text & "' WHERE KodeJenis = '" _
                                   & txtKodeJenis.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Ubah data Sukses.", MsgBoxStyle.Information, "Perhatian")
            Else
                MsgBox("Tidak ada kode dengan nama:" & txtKodeJenis.Text)
            End If

        End If
        Call tampilData()
        Call clearBox()
    End Sub

    Private Sub bttnHapus_Click(sender As Object, e As EventArgs) Handles bttnHapus.Click
        If txtKodeJenis.Text = "" Then
            MsgBox("Kode Jenis belum lengkap.")
            txtKodeJenis.Focus()
        Else
            If MessageBox.Show("Anda yakin menghapus data Buku dengan Kode buku " & txtKodeJenis.Text &
                               "?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("DELETE * FROM Jenis 
                                        WHERE KodeJenis='" & txtKodeJenis.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil diubah.", MsgBoxStyle.Information, "Perhatian")
            End If
        End If
        Call tampilData()
        Call clearBox()
    End Sub

    Private Sub bttnBatal_Click(sender As Object, e As EventArgs) Handles bttnBatal.Click
        Call clearBox()
    End Sub

    Private Sub bttnTutup_Click(sender As Object, e As EventArgs) Handles bttnTutup.Click
        Me.Close()
    End Sub
End Class